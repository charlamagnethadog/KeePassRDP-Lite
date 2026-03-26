/*
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

using KeePassLib;
using KeePassLib.Collections;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace KeePassRDPLite
{
    public partial class CredentialPickerForm : Form
    {
        private readonly KprConfig _config;
        private readonly PwDatabase _db;
        private bool showExcluded;

        public CredentialPickerForm(KprConfig config, PwDatabase db)
        {
            _config = config;
            _db = db;
            InitializeComponent();
            showExcluded = false;
            this.Tag = this.Text;
        }

        // PwObjectList with all matching entries
        public PwObjectList<PwEntry> RdpAccountEntries { get; set; }
        public PwObjectList<PwEntry> RdpExcludedEntries { get; set; }
        public string DefaultUser;
        // PwEntry that contains the URL for the connection
        public PwEntry ConnPE { get; set; }
        // new PwEntry created for the connection (URL from connPE, username and password from selected rdpAccountEntry)
        public PwEntry ReturnPE { get; set; }

        private void CredentialPickerForm_Load(object sender, EventArgs e)
        {
            // set window size
            Width = Convert.ToInt32(_config.CredPickerWidth);
            Height = Convert.ToInt32(_config.CredPickerHeight);
            CenterToParent();

            LoadListEntries();
            olvEntries.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void LoadListEntries()
        {
            // create new list with AccountEntry-objects to show them in ObjectListView-element
            List<AccountEntry> listAccounts = new List<AccountEntry>();

            int defaultItem = -1;
            foreach (PwEntry account in RdpAccountEntries)
            {
                // get title, username, notes and a UUID-hash from the Account...
                int uidhash = account.Uuid.GetHashCode();

                string path, title, username, notes;
                path = account.ParentGroup.GetFullPath("\\", false);
                if (_config.KeePassShowResolvedReferences)
                {
                    title = Util.ResolveReferences(account, _db, PwDefs.TitleField);
                    username = Util.ResolveReferences(account, _db, PwDefs.UserNameField);
                    notes = Util.ResolveReferences(account, _db, PwDefs.NotesField);
                }
                else
                {
                    title = account.Strings.ReadSafe(PwDefs.TitleField);
                    username = account.Strings.ReadSafe(PwDefs.UserNameField);
                    notes = account.Strings.ReadSafe(PwDefs.NotesField);
                }

                // ...and add as new AccountEntry to the list
                AccountEntry accEntry = new AccountEntry(path, title, username, notes, uidhash);
                listAccounts.Add(accEntry);
                if (DefaultUser.Length > 0 && defaultItem == 0)
                {
                    if (string.Compare(username, DefaultUser, true) == 0)
                        defaultItem = listAccounts.Count - 1;
                    else if (string.Compare(title, DefaultUser, true) == 0)
                        defaultItem = listAccounts.Count - 1;
                }
            }
            if (showExcluded)
            {
                foreach (PwEntry account in RdpExcludedEntries)
                {
                    // get title, username, notes and a UUID-hash from the Account...
                    int uidhash = account.Uuid.GetHashCode();

                    string path, title, username, notes;
                    path = account.ParentGroup.GetFullPath("\\", false);
                    if (_config.KeePassShowResolvedReferences)
                    {
                        title = Util.ResolveReferences(account, _db, PwDefs.TitleField);
                        username = Util.ResolveReferences(account, _db, PwDefs.UserNameField);
                        notes = Util.ResolveReferences(account, _db, PwDefs.NotesField);
                    }
                    else
                    {
                        title = account.Strings.ReadSafe(PwDefs.TitleField);
                        username = account.Strings.ReadSafe(PwDefs.UserNameField);
                        notes = account.Strings.ReadSafe(PwDefs.NotesField);
                    }

                    // ...and add as new AccountEntry to the list
                    AccountEntry accEntry = new AccountEntry(path, title, username, notes, uidhash);
                    listAccounts.Add(accEntry);
                    if (DefaultUser.Length > 0 && defaultItem == 0)
                    {
                        if (string.Compare(username, DefaultUser, true) == 0)
                            defaultItem = listAccounts.Count - 1;
                        else if (string.Compare(title, DefaultUser, true) == 0)
                            defaultItem = listAccounts.Count - 1;
                    }
                }
            }
            if (defaultItem == -1)
            {
                // fill the ObjectListView-element with objects from the AccountEntry-list
                olvEntries.SetObjects(listAccounts);
                // select the first entry in the ObjectListView (so user can just press enter for a quick connection)
                olvEntries.Items[0].Selected = true;
            }
            else
            {
                //disable sorting so that default item can be selected (in same position as listAccounts)
                olvEntries.Sorting = SortOrder.None;
                // fill the ObjectListView-element with objects from the AccountEntry-list
                olvEntries.SetObjects(listAccounts);
                // select the default user name entry (so user can just press enter for a quick connection)
                olvEntries.Items[defaultItem].Selected = true;
                //enable sorting with the default item selected
                olvEntries.Sorting = SortOrder.Ascending;
            }
            Text = string.Format("{0} ({1})", this.Tag, olvEntries.Items.Count);
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdOk_Click(object sender, EventArgs e)
        {
            // set returnPE to the selected account
            ConfirmDialog();

            // Form schließen
            Close();
        }

        // when double-clicking an entry in the ObjectListView
        private void OlvEntries_ItemActivate(object sender, EventArgs e)
        {
            // set returnPE to the selected account
            ConfirmDialog();

            // return dialog result OK
            DialogResult = DialogResult.OK;
            // Form schließen
            Close();
        }

        private void ConfirmDialog()
        {
            // save window Size
            if (_config.CredPickerRememberSize)
            {
                _config.CredPickerWidth = Convert.ToUInt64(Width);
                _config.CredPickerHeight = Convert.ToUInt64(Height);
            }

            try
            {
                foreach (PwEntry account in RdpAccountEntries)
                {
                    // get UUID-Hash and use entry if it matches the selected custom entry
                    int uidhash = account.Uuid.GetHashCode();
                    if (uidhash == ((AccountEntry)olvEntries.SelectedObject).UidHash) { ReturnPE = account; }
                }
            }
            catch
            {
                MessageBox.Show("You have to select an account first", "KeePassRDP-Lite");
                return;
            }
        }

        private void cmdShowExcluded_Click(object sender, EventArgs e)
        {
            showExcluded = !showExcluded;
            cmdShowExcluded.Text = showExcluded ? "Hide Excluded" : "Show Excluded";
            LoadListEntries();
            olvEntries.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
