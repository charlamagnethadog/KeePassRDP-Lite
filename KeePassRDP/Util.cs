﻿/*
 *  Copyright (C) 2018-2020 iSnackyCracky
 *
 *  This file is part of KeePassRDP.
 *
 *  KeePassRDP is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  KeePassRDP is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with KeePassRDP.  If not, see <http://www.gnu.org/licenses/>.
 *
 */

using KeePass.Util.Spr;
using KeePassLib;
using KeePassLib.Security;
using Newtonsoft.Json;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KeePassRDP
{
    public static class Util
    {
        public const string IgnoreEntryString = "rdpignore";
        public const string KprCpIgnoreField = IgnoreEntryString;
        public const string KprEntrySettingsField = "KeePassRDP Settings";
        public const string DefaultCredPickRegExPre = "domain|domänen|local|lokaler|windows";
        public const string DefaultCredPickRegExPost = "admin|user|administrator|benutzer|nutzer";
        public const string ToolbarConnectBtnId = "KprConnect";

        public static JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings()
        {
            DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate,
        };

        /// <summary>
        /// Checks if the ParentGroup of a PwEntry is named "RDP".
        /// </summary>
        /// <param name="pe"></param>
        /// <returns></returns>
        public static bool InRdpSubgroup(PwEntry pe)
        {
            PwGroup pg = pe.ParentGroup;
            return pg.Name == "RDP";
        }

        /// <summary>
        /// Uses the KeePass SprEngine to resolve field references.
        /// </summary>
        /// <param name="pe"></param>
        /// <param name="pd"></param>
        /// <param name="field"></param>
        /// <returns></returns>
        public static string ResolveReferences(PwEntry pe, PwDatabase pd, string field)
        {
            var ctx = new SprContext(pe, pd, SprCompileFlags.All);
            return SprEngine.Compile(pe.Strings.ReadSafe(field), ctx);
        }

        public static PwEntry GetResolvedReferencesEntry(PwEntry pe, PwDatabase pd)
        {
            var retPE = new PwEntry(false, false);
            retPE.Strings.Set(PwDefs.UserNameField, new ProtectedString(false, Util.ResolveReferences(pe, pd, PwDefs.UserNameField)));
            retPE.Strings.Set(PwDefs.PasswordField, new ProtectedString(true, Util.ResolveReferences(pe, pd, PwDefs.PasswordField)));
            retPE.Strings.Set(PwDefs.UrlField, new ProtectedString(false, Util.ResolveReferences(pe, pd, PwDefs.UrlField)));

            return retPE;
        }

        /// <summary>
        /// Checks if a given PwEntry has the "rdpignore-flag" set
        /// </summary>
        /// <param name="pe"></param>
        /// <returns></returns>
        public static bool IsEntryIgnored(PwEntry pe)
        {
            var entrySettings = GetEntrySettings(pe);
            // Does a CustomField "rdpignore" exist and is the value NOT set to "false"?
            if (pe.Strings.Exists(KprCpIgnoreField) && !(pe.Strings.ReadSafe(KprCpIgnoreField).ToLower() == Boolean.FalseString.ToLower())) { return true; }
            else { return entrySettings.Ignore; }
        }

        /// <summary>
        /// Removes protocol "prefix" (i.e. http:// ; https:// ; ...) and optionally a following port (i.e. :8080) from a given string.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string StripUrl(string text, bool stripPort = false)
        {
            text = Regex.Replace(text, @"^(?:http(?:s)?://)?(?:www(?:[0-9]+)?.)?", String.Empty, RegexOptions.IgnoreCase);
            text = Regex.Replace(text, @"^(?:(?:s)?ftp://)?(?:ftp.)?", String.Empty, RegexOptions.IgnoreCase);
            text = Regex.Replace(text, @"^(?:ssh://)", String.Empty, RegexOptions.IgnoreCase);
            text = Regex.Replace(text, @"^(?:rdp://)", String.Empty, RegexOptions.IgnoreCase);
            text = Regex.Replace(text, @"^(?:mailto:)", String.Empty, RegexOptions.IgnoreCase);
            text = Regex.Replace(text, @"^(?:callto:)", String.Empty, RegexOptions.IgnoreCase);
            text = Regex.Replace(text, @"^(?:tel:)", String.Empty, RegexOptions.IgnoreCase);
            text = Regex.Replace(text, @"(?:/.*)?", String.Empty, RegexOptions.IgnoreCase);
            if (stripPort) { text = Regex.Replace(text, @"(?:\:[0-9]+)", String.Empty, RegexOptions.IgnoreCase); }
            return text;
        }

        /// <summary>
        /// Retrieves the KprEntrySettings of a given entry.
        /// </summary>
        /// <param name="pe"></param>
        /// <returns></returns>
        public static KprEntrySettings GetEntrySettings(PwEntry pe)
        {
            var entrySettingsString = pe.Strings.ReadSafe(Util.KprEntrySettingsField);
            var entrySettings = JsonConvert.DeserializeObject<KprEntrySettings>(entrySettingsString, jsonSerializerSettings);
            if (entrySettings == null) { entrySettings = new KprEntrySettings(); }
            return entrySettings;
        }

        /// <summary>
        /// Toggles the "rdpignore-flag" of a given PwEntry
        /// </summary>
        /// <param name="pe"></param>
        public static void ToggleEntryIgnored(PwEntry pe)
        {
            var entrySettings = GetEntrySettings(pe);

            // Does a CustomField "rdpignore" exist?
            if (pe.Strings.Exists(KprCpIgnoreField))
            {
                // Is the CustomField value set to "false"?
                if (pe.Strings.ReadSafe(KprCpIgnoreField).ToLower() == Boolean.FalseString.ToLower())
                {
                    entrySettings.Ignore = true;
                    pe.Strings.Remove(KprCpIgnoreField);
                }
                else
                {
                    entrySettings.Ignore = false;
                    pe.Strings.Remove(KprCpIgnoreField);
                }
            }
            // Else the entry currently has no "rdpignore-flags" set, so just toggle the entrySetting
            else { entrySettings.Ignore = !entrySettings.Ignore; }

            pe.Strings.Set(KprEntrySettingsField, entrySettings.ToProtectedJsonString());
            pe.Touch(true, false);
        }

        public static int ConvertStringToKeys(string shortcut)
        {
            var conv = new KeysConverter();
            return (int)conv.ConvertFromString(shortcut);
        }

        public static string ConvertKeysToString(int shortcut)
        {
            var conv = new KeysConverter();
            return conv.ConvertToString((Keys)shortcut);
        }
    }
}
