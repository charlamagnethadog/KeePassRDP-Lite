﻿/*
 *  Copyright (C) 2018 - 2025 iSnackyCracky, NETertainer
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

using System;

namespace KeePassRDP.Generator
{
    [AttributeUsage(AttributeTargets.Property)]
    public class RdpSettingAttribute : Attribute
    {
        public string Template { get; private set; }
        public SettingCategory Category { get; set; }

        public RdpSettingAttribute(string template)
        {
            Template = template;
            Category = SettingCategory.General;
        }

        public enum SettingCategory
        {
            General = 0,
            Authentication,
            Network,
            Display,
            Redirect,
            AudioVideo,
            RemoteApp
        }
    }
}
