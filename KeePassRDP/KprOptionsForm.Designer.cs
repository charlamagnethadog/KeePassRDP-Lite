﻿namespace KeePassRDP
{
    partial class KprOptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.FlowLayoutPanel flpCredVaultTtl;
            System.Windows.Forms.FlowLayoutPanel flpSavedCredentials;
            System.Windows.Forms.Panel pnlCredPickerRegExPrefixes;
            System.Windows.Forms.FlowLayoutPanel flpCredPickerRegEx;
            System.Windows.Forms.Panel pnlCredPickerRegExPostfixes;
            System.Windows.Forms.FlowLayoutPanel flpCredPickerOptions;
            System.Windows.Forms.Label lblRevision;
            System.Windows.Forms.Label lblKeePassRDP;
            System.Windows.Forms.Label lblVersion;
            System.Windows.Forms.Panel pnlAboutLinks;
            System.Windows.Forms.FlowLayoutPanel flpCommandButtons;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KprOptionsForm));
            this.lblCredVaultTtl = new System.Windows.Forms.Label();
            this.numCredVaultTtl = new System.Windows.Forms.NumericUpDown();
            this.chkSavedCredsShowAll = new System.Windows.Forms.CheckBox();
            this.cmdRefreshCredentials = new System.Windows.Forms.Button();
            this.kprImageList = new KeePassRDP.KprImageList(this.components);
            this.imageList1 = ((System.Windows.Forms.ImageList)(this.kprImageList));
            this.lblRegexPrefixes = new System.Windows.Forms.Label();
            this.lstRegExPre = new System.Windows.Forms.ListBox();
            this.txtRegExPre = new System.Windows.Forms.TextBox();
            this.cmdRegExPreAdd = new System.Windows.Forms.Button();
            this.cmdRegExPreReset = new System.Windows.Forms.Button();
            this.cmdRegExPreRemove = new System.Windows.Forms.Button();
            this.lblRegexPostfixes = new System.Windows.Forms.Label();
            this.lstRegExPost = new System.Windows.Forms.ListBox();
            this.txtRegExPost = new System.Windows.Forms.TextBox();
            this.cmdRegExPostReset = new System.Windows.Forms.Button();
            this.cmdRegExPostAdd = new System.Windows.Forms.Button();
            this.cmdRegExPostRemove = new System.Windows.Forms.Button();
            this.grpCredPickerGeneralOptions = new System.Windows.Forms.GroupBox();
            this.chkCredPickSecureDesktop = new System.Windows.Forms.CheckBox();
            this.chkCredPickRememberSortOrder = new System.Windows.Forms.CheckBox();
            this.chkCredPickRememberSize = new System.Windows.Forms.CheckBox();
            this.lblCredPickWidth = new System.Windows.Forms.Label();
            this.numCredPickWidth = new System.Windows.Forms.NumericUpDown();
            this.numCredPickHeight = new System.Windows.Forms.NumericUpDown();
            this.lblCredPickHeight = new System.Windows.Forms.Label();
            this.grpCredPickerEntryOptions = new System.Windows.Forms.GroupBox();
            this.chkCredPickIncludeSelected = new System.Windows.Forms.CheckBox();
            this.chkCredPickShowInGroups = new System.Windows.Forms.CheckBox();
            this.chkKeepassShowResolvedReferences = new System.Windows.Forms.CheckBox();
            this.chkCredPickLargeRows = new System.Windows.Forms.CheckBox();
            this.grpCredPickerTriggerOptions = new System.Windows.Forms.GroupBox();
            this.chkCredPickerTriggerRecursive = new System.Windows.Forms.CheckBox();
            this.lblCredPickerCustomGroup = new System.Windows.Forms.Label();
            this.txtCredPickerCustomGroup = new System.Windows.Forms.TextBox();
            this.llLicense = new System.Windows.Forms.LinkLabel();
            this.llWebsite = new System.Windows.Forms.LinkLabel();
            this.cmdOk = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.flpOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.grpCredentialOptions = new System.Windows.Forms.GroupBox();
            this.chkCredVaultAdaptiveTtl = new System.Windows.Forms.CheckBox();
            this.chkCredVaultRemoveOnExit = new System.Windows.Forms.CheckBox();
            this.chkCredVaultOverwriteExisting = new System.Windows.Forms.CheckBox();
            this.chkCredVaultUseWindows = new System.Windows.Forms.CheckBox();
            this.grpEntryOptions = new System.Windows.Forms.GroupBox();
            this.chkKeePassDefaultEntryAction = new System.Windows.Forms.CheckBox();
            this.chkKeePassAlwaysConfirm = new System.Windows.Forms.CheckBox();
            this.chkKeePassConnectToAll = new System.Windows.Forms.CheckBox();
            this.grpHotkeyOptions = new System.Windows.Forms.GroupBox();
            this.chkKeePassConfirmOnClose = new System.Windows.Forms.CheckBox();
            this.chkKeePassContextMenuOnScreen = new System.Windows.Forms.CheckBox();
            this.chkKeePassHotkeysRegisterLast = new System.Windows.Forms.CheckBox();
            this.ttMstscParameters = new KeePassRDP.KprToolTip(this.components);
            this.numMstscHeight = new System.Windows.Forms.NumericUpDown();
            this.numMstscWidth = new System.Windows.Forms.NumericUpDown();
            this.chkMstscUseMultimon = new System.Windows.Forms.CheckBox();
            this.chkMstscUseSpan = new System.Windows.Forms.CheckBox();
            this.chkMstscUseAdmin = new System.Windows.Forms.CheckBox();
            this.chkMstscUseFullscreen = new System.Windows.Forms.CheckBox();
            this.chkMstscUsePublic = new System.Windows.Forms.CheckBox();
            this.chkMstscUseRestrictedAdmin = new System.Windows.Forms.CheckBox();
            this.chkMstscUseRemoteGuard = new System.Windows.Forms.CheckBox();
            this.chkMstscConfirmCertificate = new System.Windows.Forms.CheckBox();
            this.chkMstscReplaceTitle = new System.Windows.Forms.CheckBox();
            this.ttCredentials = new KeePassRDP.KprToolTip(this.components);
            this.ttEntries = new KeePassRDP.KprToolTip(this.components);
            this.ttUI = new KeePassRDP.KprToolTip(this.components);
            this.ttGeneral = new KeePassRDP.KprToolTip(this.components);
            this.ttGeneric = new KeePassRDP.KprToolTip(this.components);
            this.chkMstscSecureDesktop = new System.Windows.Forms.CheckBox();
            this.cbMstscExecutable = new System.Windows.Forms.ComboBox();
            this.cmdReset = new System.Windows.Forms.Button();
            this.cmdSelfSignedCertificate = new System.Windows.Forms.Button();
            this.ttTrigger = new KeePassRDP.KprToolTip(this.components);
            this.grpMstscParameters = new System.Windows.Forms.GroupBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.tcKprOptionsForm = new System.Windows.Forms.TabControl();
            this.tabIntegration = new System.Windows.Forms.TabPage();
            this.tblIntegration = new System.Windows.Forms.TableLayoutPanel();
            this.kprSettingsControl = new KeePassRDP.KprSettingsControl();
            this.tabPicker = new System.Windows.Forms.TabPage();
            this.tblPicker = new System.Windows.Forms.TableLayoutPanel();
            this.tabExecutable = new System.Windows.Forms.TabPage();
            this.tblExecutable = new System.Windows.Forms.TableLayoutPanel();
            this.grpMstscAutomation = new System.Windows.Forms.GroupBox();
            this.chkMstscHandleCredDialog = new System.Windows.Forms.CheckBox();
            this.chkMstscCleanupRegistry = new System.Windows.Forms.CheckBox();
            this.txtMstscSignRdpFiles = new System.Windows.Forms.TextBox();
            this.chkMstscSignRdpFiles = new System.Windows.Forms.CheckBox();
            this.tblMstscExecutable = new System.Windows.Forms.TableLayoutPanel();
            this.flpMstscExecutable = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMstscExecutable = new System.Windows.Forms.Label();
            this.txtMstscCustomCommand = new System.Windows.Forms.TextBox();
            this.tabVault = new System.Windows.Forms.TabPage();
            this.tblVault = new System.Windows.Forms.TableLayoutPanel();
            this.lvVault = new System.Windows.Forms.ListView();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.tblAbout = new System.Windows.Forms.TableLayoutPanel();
            this.lblRevisionText = new System.Windows.Forms.Label();
            this.pbAbout = new KeePassRDP.KprPictureBox();
            this.lblVersionText = new System.Windows.Forms.Label();
            this.tblKprOptionsForm = new System.Windows.Forms.TableLayoutPanel();
            this.pbKprOptionsForm = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ttMstscAutomation = new KeePassRDP.KprToolTip(this.components);
            flpCredVaultTtl = new System.Windows.Forms.FlowLayoutPanel();
            flpSavedCredentials = new System.Windows.Forms.FlowLayoutPanel();
            pnlCredPickerRegExPrefixes = new System.Windows.Forms.Panel();
            flpCredPickerRegEx = new System.Windows.Forms.FlowLayoutPanel();
            pnlCredPickerRegExPostfixes = new System.Windows.Forms.Panel();
            flpCredPickerOptions = new System.Windows.Forms.FlowLayoutPanel();
            lblRevision = new System.Windows.Forms.Label();
            lblKeePassRDP = new System.Windows.Forms.Label();
            lblVersion = new System.Windows.Forms.Label();
            pnlAboutLinks = new System.Windows.Forms.Panel();
            flpCommandButtons = new System.Windows.Forms.FlowLayoutPanel();
            flpCredVaultTtl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCredVaultTtl)).BeginInit();
            flpSavedCredentials.SuspendLayout();
            pnlCredPickerRegExPrefixes.SuspendLayout();
            flpCredPickerRegEx.SuspendLayout();
            pnlCredPickerRegExPostfixes.SuspendLayout();
            flpCredPickerOptions.SuspendLayout();
            this.grpCredPickerGeneralOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCredPickWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCredPickHeight)).BeginInit();
            this.grpCredPickerEntryOptions.SuspendLayout();
            this.grpCredPickerTriggerOptions.SuspendLayout();
            pnlAboutLinks.SuspendLayout();
            flpCommandButtons.SuspendLayout();
            this.flpOptions.SuspendLayout();
            this.grpCredentialOptions.SuspendLayout();
            this.grpEntryOptions.SuspendLayout();
            this.grpHotkeyOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMstscHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMstscWidth)).BeginInit();
            this.grpMstscParameters.SuspendLayout();
            this.tcKprOptionsForm.SuspendLayout();
            this.tabIntegration.SuspendLayout();
            this.tblIntegration.SuspendLayout();
            this.tabPicker.SuspendLayout();
            this.tblPicker.SuspendLayout();
            this.tabExecutable.SuspendLayout();
            this.tblExecutable.SuspendLayout();
            this.grpMstscAutomation.SuspendLayout();
            this.tblMstscExecutable.SuspendLayout();
            this.flpMstscExecutable.SuspendLayout();
            this.tabVault.SuspendLayout();
            this.tblVault.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.tblAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).BeginInit();
            this.tblKprOptionsForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKprOptionsForm)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpCredVaultTtl
            // 
            flpCredVaultTtl.AutoSize = true;
            flpCredVaultTtl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flpCredVaultTtl.Controls.Add(this.lblCredVaultTtl);
            flpCredVaultTtl.Controls.Add(this.numCredVaultTtl);
            flpCredVaultTtl.Location = new System.Drawing.Point(4, 83);
            flpCredVaultTtl.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            flpCredVaultTtl.Name = "flpCredVaultTtl";
            flpCredVaultTtl.Size = new System.Drawing.Size(171, 22);
            flpCredVaultTtl.TabIndex = 6;
            // 
            // lblCredVaultTtl
            // 
            this.lblCredVaultTtl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCredVaultTtl.AutoSize = true;
            this.lblCredVaultTtl.BackColor = System.Drawing.Color.Transparent;
            this.lblCredVaultTtl.Location = new System.Drawing.Point(0, 0);
            this.lblCredVaultTtl.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblCredVaultTtl.Name = "lblCredVaultTtl";
            this.lblCredVaultTtl.Size = new System.Drawing.Size(83, 19);
            this.lblCredVaultTtl.TabIndex = 3;
            this.lblCredVaultTtl.Text = "Credential TTL:";
            this.lblCredVaultTtl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numCredVaultTtl
            // 
            this.numCredVaultTtl.Location = new System.Drawing.Point(86, 0);
            this.numCredVaultTtl.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.numCredVaultTtl.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.numCredVaultTtl.Name = "numCredVaultTtl";
            this.numCredVaultTtl.Size = new System.Drawing.Size(85, 22);
            this.numCredVaultTtl.TabIndex = 4;
            this.ttCredentials.SetToolTip(this.numCredVaultTtl, "Specify duration (in seconds) that credentials reside in Windows vault.\r\n0 disabl" +
        "es expiration.");
            this.numCredVaultTtl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCredVaultTtl.ValueChanged += new System.EventHandler(this.numCredVaultTtl_ValueChanged);
            this.numCredVaultTtl.Enter += new System.EventHandler(this.num_Enter);
            this.numCredVaultTtl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.num_KeyUp);
            this.numCredVaultTtl.Leave += new System.EventHandler(this.num_Leave);
            // 
            // flpSavedCredentials
            // 
            flpSavedCredentials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            flpSavedCredentials.AutoSize = true;
            flpSavedCredentials.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flpSavedCredentials.Controls.Add(this.chkSavedCredsShowAll);
            flpSavedCredentials.Controls.Add(this.cmdRefreshCredentials);
            flpSavedCredentials.Location = new System.Drawing.Point(0, 0);
            flpSavedCredentials.Margin = new System.Windows.Forms.Padding(0);
            flpSavedCredentials.Name = "flpSavedCredentials";
            flpSavedCredentials.Size = new System.Drawing.Size(570, 23);
            flpSavedCredentials.TabIndex = 0;
            // 
            // chkSavedCredsShowAll
            // 
            this.chkSavedCredsShowAll.AutoSize = true;
            this.chkSavedCredsShowAll.BackColor = System.Drawing.Color.Transparent;
            this.chkSavedCredsShowAll.Location = new System.Drawing.Point(4, 4);
            this.chkSavedCredsShowAll.Margin = new System.Windows.Forms.Padding(4, 4, 3, 2);
            this.chkSavedCredsShowAll.Name = "chkSavedCredsShowAll";
            this.chkSavedCredsShowAll.Size = new System.Drawing.Size(129, 17);
            this.chkSavedCredsShowAll.TabIndex = 0;
            this.chkSavedCredsShowAll.Text = "Show all credentials";
            this.ttGeneric.SetToolTip(this.chkSavedCredsShowAll, "Toggle showing only credentials managed by KeePassRDP or all.");
            this.chkSavedCredsShowAll.UseVisualStyleBackColor = false;
            this.chkSavedCredsShowAll.CheckedChanged += new System.EventHandler(this.chkSavedCredsShowAll_CheckedChanged);
            // 
            // cmdRefreshCredentials
            // 
            this.cmdRefreshCredentials.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdRefreshCredentials.AutoSize = true;
            this.cmdRefreshCredentials.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdRefreshCredentials.FlatAppearance.BorderSize = 0;
            this.cmdRefreshCredentials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRefreshCredentials.ImageKey = "Refresh";
            this.cmdRefreshCredentials.ImageList = this.imageList1;
            this.cmdRefreshCredentials.Location = new System.Drawing.Point(136, 0);
            this.cmdRefreshCredentials.Margin = new System.Windows.Forms.Padding(0);
            this.cmdRefreshCredentials.Name = "cmdRefreshCredentials";
            this.cmdRefreshCredentials.Padding = new System.Windows.Forms.Padding(0, 0, 2, 1);
            this.cmdRefreshCredentials.Size = new System.Drawing.Size(24, 23);
            this.cmdRefreshCredentials.TabIndex = 1;
            this.ttGeneric.SetToolTip(this.cmdRefreshCredentials, "Refresh credentials list");
            this.cmdRefreshCredentials.UseVisualStyleBackColor = true;
            this.cmdRefreshCredentials.Click += new System.EventHandler(this.cmdRefreshCredentials_Click);
            // 
            // pnlCredPickerRegExPrefixes
            // 
            pnlCredPickerRegExPrefixes.AutoSize = true;
            pnlCredPickerRegExPrefixes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            pnlCredPickerRegExPrefixes.Controls.Add(this.lblRegexPrefixes);
            pnlCredPickerRegExPrefixes.Controls.Add(this.lstRegExPre);
            pnlCredPickerRegExPrefixes.Controls.Add(this.txtRegExPre);
            pnlCredPickerRegExPrefixes.Controls.Add(this.cmdRegExPreAdd);
            pnlCredPickerRegExPrefixes.Controls.Add(this.cmdRegExPreReset);
            pnlCredPickerRegExPrefixes.Controls.Add(this.cmdRegExPreRemove);
            pnlCredPickerRegExPrefixes.Location = new System.Drawing.Point(0, 0);
            pnlCredPickerRegExPrefixes.Margin = new System.Windows.Forms.Padding(0);
            pnlCredPickerRegExPrefixes.Name = "pnlCredPickerRegExPrefixes";
            pnlCredPickerRegExPrefixes.Size = new System.Drawing.Size(156, 144);
            pnlCredPickerRegExPrefixes.TabIndex = 0;
            // 
            // lblRegexPrefixes
            // 
            this.lblRegexPrefixes.AutoSize = true;
            this.lblRegexPrefixes.BackColor = System.Drawing.Color.Transparent;
            this.lblRegexPrefixes.Location = new System.Drawing.Point(3, 3);
            this.lblRegexPrefixes.Margin = new System.Windows.Forms.Padding(3);
            this.lblRegexPrefixes.Name = "lblRegexPrefixes";
            this.lblRegexPrefixes.Size = new System.Drawing.Size(84, 13);
            this.lblRegexPrefixes.TabIndex = 0;
            this.lblRegexPrefixes.Text = "RegEx prefixes:";
            // 
            // lstRegExPre
            // 
            this.lstRegExPre.FormattingEnabled = true;
            this.lstRegExPre.HorizontalScrollbar = true;
            this.lstRegExPre.IntegralHeight = false;
            this.lstRegExPre.Location = new System.Drawing.Point(6, 45);
            this.lstRegExPre.Name = "lstRegExPre";
            this.lstRegExPre.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstRegExPre.Size = new System.Drawing.Size(120, 95);
            this.lstRegExPre.TabIndex = 3;
            this.lstRegExPre.SelectedIndexChanged += new System.EventHandler(this.lstRegExPre_SelectedIndexChanged);
            this.lstRegExPre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lst_KeyDownDelete);
            // 
            // txtRegExPre
            // 
            this.txtRegExPre.Location = new System.Drawing.Point(6, 19);
            this.txtRegExPre.Name = "txtRegExPre";
            this.txtRegExPre.Size = new System.Drawing.Size(120, 22);
            this.txtRegExPre.TabIndex = 1;
            this.txtRegExPre.TextChanged += new System.EventHandler(this.txtRegExPre_TextChanged);
            this.txtRegExPre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRegExPre_KeyDown);
            this.txtRegExPre.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_PreviewKeyDown);
            // 
            // cmdRegExPreAdd
            // 
            this.cmdRegExPreAdd.AutoSize = true;
            this.cmdRegExPreAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdRegExPreAdd.Enabled = false;
            this.cmdRegExPreAdd.ImageKey = "Add";
            this.cmdRegExPreAdd.ImageList = this.imageList1;
            this.cmdRegExPreAdd.Location = new System.Drawing.Point(129, 18);
            this.cmdRegExPreAdd.Name = "cmdRegExPreAdd";
            this.cmdRegExPreAdd.Padding = new System.Windows.Forms.Padding(1);
            this.cmdRegExPreAdd.Size = new System.Drawing.Size(24, 24);
            this.cmdRegExPreAdd.TabIndex = 2;
            this.ttGeneric.SetToolTip(this.cmdRegExPreAdd, "Add RegEx prefix");
            this.cmdRegExPreAdd.UseVisualStyleBackColor = true;
            this.cmdRegExPreAdd.Click += new System.EventHandler(this.cmdRegExPreAdd_Click);
            // 
            // cmdRegExPreReset
            // 
            this.cmdRegExPreReset.AutoSize = true;
            this.cmdRegExPreReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdRegExPreReset.ImageKey = "Refresh";
            this.cmdRegExPreReset.ImageList = this.imageList1;
            this.cmdRegExPreReset.Location = new System.Drawing.Point(129, 117);
            this.cmdRegExPreReset.Name = "cmdRegExPreReset";
            this.cmdRegExPreReset.Padding = new System.Windows.Forms.Padding(1);
            this.cmdRegExPreReset.Size = new System.Drawing.Size(24, 24);
            this.cmdRegExPreReset.TabIndex = 5;
            this.ttGeneric.SetToolTip(this.cmdRegExPreReset, "Reset RegEx prefixes to default");
            this.cmdRegExPreReset.UseVisualStyleBackColor = true;
            this.cmdRegExPreReset.Click += new System.EventHandler(this.cmdRegExPreReset_Click);
            // 
            // cmdRegExPreRemove
            // 
            this.cmdRegExPreRemove.AutoSize = true;
            this.cmdRegExPreRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdRegExPreRemove.Enabled = false;
            this.cmdRegExPreRemove.ImageKey = "Remove";
            this.cmdRegExPreRemove.ImageList = this.imageList1;
            this.cmdRegExPreRemove.Location = new System.Drawing.Point(129, 44);
            this.cmdRegExPreRemove.Name = "cmdRegExPreRemove";
            this.cmdRegExPreRemove.Padding = new System.Windows.Forms.Padding(1);
            this.cmdRegExPreRemove.Size = new System.Drawing.Size(24, 24);
            this.cmdRegExPreRemove.TabIndex = 4;
            this.ttGeneric.SetToolTip(this.cmdRegExPreRemove, "Remove selected RegEx prefix(es)");
            this.cmdRegExPreRemove.UseVisualStyleBackColor = true;
            this.cmdRegExPreRemove.Click += new System.EventHandler(this.cmdRegExPreRemove_Click);
            // 
            // flpCredPickerRegEx
            // 
            flpCredPickerRegEx.AutoSize = true;
            flpCredPickerRegEx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flpCredPickerRegEx.Controls.Add(pnlCredPickerRegExPrefixes);
            flpCredPickerRegEx.Controls.Add(pnlCredPickerRegExPostfixes);
            flpCredPickerRegEx.Dock = System.Windows.Forms.DockStyle.Fill;
            flpCredPickerRegEx.Location = new System.Drawing.Point(3, 154);
            flpCredPickerRegEx.Name = "flpCredPickerRegEx";
            flpCredPickerRegEx.Size = new System.Drawing.Size(564, 144);
            flpCredPickerRegEx.TabIndex = 1;
            flpCredPickerRegEx.WrapContents = false;
            // 
            // pnlCredPickerRegExPostfixes
            // 
            pnlCredPickerRegExPostfixes.AutoSize = true;
            pnlCredPickerRegExPostfixes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            pnlCredPickerRegExPostfixes.Controls.Add(this.lblRegexPostfixes);
            pnlCredPickerRegExPostfixes.Controls.Add(this.lstRegExPost);
            pnlCredPickerRegExPostfixes.Controls.Add(this.txtRegExPost);
            pnlCredPickerRegExPostfixes.Controls.Add(this.cmdRegExPostReset);
            pnlCredPickerRegExPostfixes.Controls.Add(this.cmdRegExPostAdd);
            pnlCredPickerRegExPostfixes.Controls.Add(this.cmdRegExPostRemove);
            pnlCredPickerRegExPostfixes.Location = new System.Drawing.Point(156, 0);
            pnlCredPickerRegExPostfixes.Margin = new System.Windows.Forms.Padding(0);
            pnlCredPickerRegExPostfixes.Name = "pnlCredPickerRegExPostfixes";
            pnlCredPickerRegExPostfixes.Size = new System.Drawing.Size(156, 144);
            pnlCredPickerRegExPostfixes.TabIndex = 1;
            // 
            // lblRegexPostfixes
            // 
            this.lblRegexPostfixes.AutoSize = true;
            this.lblRegexPostfixes.BackColor = System.Drawing.Color.Transparent;
            this.lblRegexPostfixes.Location = new System.Drawing.Point(3, 3);
            this.lblRegexPostfixes.Margin = new System.Windows.Forms.Padding(3);
            this.lblRegexPostfixes.Name = "lblRegexPostfixes";
            this.lblRegexPostfixes.Size = new System.Drawing.Size(90, 13);
            this.lblRegexPostfixes.TabIndex = 0;
            this.lblRegexPostfixes.Text = "RegEx postfixes:";
            // 
            // lstRegExPost
            // 
            this.lstRegExPost.FormattingEnabled = true;
            this.lstRegExPost.HorizontalScrollbar = true;
            this.lstRegExPost.IntegralHeight = false;
            this.lstRegExPost.Location = new System.Drawing.Point(6, 45);
            this.lstRegExPost.Name = "lstRegExPost";
            this.lstRegExPost.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstRegExPost.Size = new System.Drawing.Size(120, 95);
            this.lstRegExPost.TabIndex = 3;
            this.lstRegExPost.SelectedIndexChanged += new System.EventHandler(this.lstRegExPost_SelectedIndexChanged);
            this.lstRegExPost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lst_KeyDownDelete);
            // 
            // txtRegExPost
            // 
            this.txtRegExPost.Location = new System.Drawing.Point(6, 19);
            this.txtRegExPost.Name = "txtRegExPost";
            this.txtRegExPost.Size = new System.Drawing.Size(120, 22);
            this.txtRegExPost.TabIndex = 1;
            this.txtRegExPost.TextChanged += new System.EventHandler(this.txtRegExPost_TextChanged);
            this.txtRegExPost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRegExPost_KeyDown);
            this.txtRegExPost.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_PreviewKeyDown);
            // 
            // cmdRegExPostReset
            // 
            this.cmdRegExPostReset.AutoSize = true;
            this.cmdRegExPostReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdRegExPostReset.ImageKey = "Refresh";
            this.cmdRegExPostReset.ImageList = this.imageList1;
            this.cmdRegExPostReset.Location = new System.Drawing.Point(129, 117);
            this.cmdRegExPostReset.Name = "cmdRegExPostReset";
            this.cmdRegExPostReset.Padding = new System.Windows.Forms.Padding(1);
            this.cmdRegExPostReset.Size = new System.Drawing.Size(24, 24);
            this.cmdRegExPostReset.TabIndex = 5;
            this.ttGeneric.SetToolTip(this.cmdRegExPostReset, "Reset RegEx postfixes to default");
            this.cmdRegExPostReset.UseVisualStyleBackColor = true;
            this.cmdRegExPostReset.Click += new System.EventHandler(this.cmdRegExPostReset_Click);
            // 
            // cmdRegExPostAdd
            // 
            this.cmdRegExPostAdd.AutoSize = true;
            this.cmdRegExPostAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdRegExPostAdd.Enabled = false;
            this.cmdRegExPostAdd.ImageKey = "Add";
            this.cmdRegExPostAdd.ImageList = this.imageList1;
            this.cmdRegExPostAdd.Location = new System.Drawing.Point(129, 18);
            this.cmdRegExPostAdd.Name = "cmdRegExPostAdd";
            this.cmdRegExPostAdd.Padding = new System.Windows.Forms.Padding(1);
            this.cmdRegExPostAdd.Size = new System.Drawing.Size(24, 24);
            this.cmdRegExPostAdd.TabIndex = 2;
            this.ttGeneric.SetToolTip(this.cmdRegExPostAdd, "Add RegEx postfix");
            this.cmdRegExPostAdd.UseVisualStyleBackColor = true;
            this.cmdRegExPostAdd.Click += new System.EventHandler(this.cmdRegExPostAdd_Click);
            // 
            // cmdRegExPostRemove
            // 
            this.cmdRegExPostRemove.AutoSize = true;
            this.cmdRegExPostRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdRegExPostRemove.Enabled = false;
            this.cmdRegExPostRemove.ImageKey = "Remove";
            this.cmdRegExPostRemove.ImageList = this.imageList1;
            this.cmdRegExPostRemove.Location = new System.Drawing.Point(129, 44);
            this.cmdRegExPostRemove.Name = "cmdRegExPostRemove";
            this.cmdRegExPostRemove.Padding = new System.Windows.Forms.Padding(1);
            this.cmdRegExPostRemove.Size = new System.Drawing.Size(24, 24);
            this.cmdRegExPostRemove.TabIndex = 4;
            this.ttGeneric.SetToolTip(this.cmdRegExPostRemove, "Remove selected RegEx postfix(es)");
            this.cmdRegExPostRemove.UseVisualStyleBackColor = true;
            this.cmdRegExPostRemove.Click += new System.EventHandler(this.cmdRegExPostRemove_Click);
            // 
            // flpCredPickerOptions
            // 
            flpCredPickerOptions.AutoSize = true;
            flpCredPickerOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flpCredPickerOptions.Controls.Add(this.grpCredPickerGeneralOptions);
            flpCredPickerOptions.Controls.Add(this.grpCredPickerEntryOptions);
            flpCredPickerOptions.Controls.Add(this.grpCredPickerTriggerOptions);
            flpCredPickerOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            flpCredPickerOptions.Location = new System.Drawing.Point(3, 3);
            flpCredPickerOptions.Name = "flpCredPickerOptions";
            flpCredPickerOptions.Size = new System.Drawing.Size(564, 145);
            flpCredPickerOptions.TabIndex = 0;
            flpCredPickerOptions.WrapContents = false;
            // 
            // grpCredPickerGeneralOptions
            // 
            this.grpCredPickerGeneralOptions.AutoSize = true;
            this.grpCredPickerGeneralOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpCredPickerGeneralOptions.BackColor = System.Drawing.Color.Transparent;
            this.grpCredPickerGeneralOptions.Controls.Add(this.chkCredPickSecureDesktop);
            this.grpCredPickerGeneralOptions.Controls.Add(this.chkCredPickRememberSortOrder);
            this.grpCredPickerGeneralOptions.Controls.Add(this.chkCredPickRememberSize);
            this.grpCredPickerGeneralOptions.Controls.Add(this.lblCredPickWidth);
            this.grpCredPickerGeneralOptions.Controls.Add(this.numCredPickWidth);
            this.grpCredPickerGeneralOptions.Controls.Add(this.numCredPickHeight);
            this.grpCredPickerGeneralOptions.Controls.Add(this.lblCredPickHeight);
            this.grpCredPickerGeneralOptions.Location = new System.Drawing.Point(0, 0);
            this.grpCredPickerGeneralOptions.Margin = new System.Windows.Forms.Padding(0);
            this.grpCredPickerGeneralOptions.Name = "grpCredPickerGeneralOptions";
            this.grpCredPickerGeneralOptions.Padding = new System.Windows.Forms.Padding(0);
            this.grpCredPickerGeneralOptions.Size = new System.Drawing.Size(184, 145);
            this.grpCredPickerGeneralOptions.TabIndex = 0;
            this.grpCredPickerGeneralOptions.TabStop = false;
            this.grpCredPickerGeneralOptions.Text = "General";
            // 
            // chkCredPickSecureDesktop
            // 
            this.chkCredPickSecureDesktop.AutoSize = true;
            this.chkCredPickSecureDesktop.BackColor = System.Drawing.Color.Transparent;
            this.chkCredPickSecureDesktop.Location = new System.Drawing.Point(6, 113);
            this.chkCredPickSecureDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.chkCredPickSecureDesktop.Name = "chkCredPickSecureDesktop";
            this.chkCredPickSecureDesktop.Size = new System.Drawing.Size(153, 17);
            this.chkCredPickSecureDesktop.TabIndex = 6;
            this.chkCredPickSecureDesktop.Text = "Open on secure desktop";
            this.ttGeneral.SetToolTip(this.chkCredPickSecureDesktop, "Open credential picker on an isolated desktop to prevent sniffing and key-logging" +
        ".");
            this.chkCredPickSecureDesktop.UseVisualStyleBackColor = false;
            // 
            // chkCredPickRememberSortOrder
            // 
            this.chkCredPickRememberSortOrder.AutoSize = true;
            this.chkCredPickRememberSortOrder.BackColor = System.Drawing.Color.Transparent;
            this.chkCredPickRememberSortOrder.Location = new System.Drawing.Point(6, 92);
            this.chkCredPickRememberSortOrder.Margin = new System.Windows.Forms.Padding(0);
            this.chkCredPickRememberSortOrder.Name = "chkCredPickRememberSortOrder";
            this.chkCredPickRememberSortOrder.Size = new System.Drawing.Size(134, 17);
            this.chkCredPickRememberSortOrder.TabIndex = 5;
            this.chkCredPickRememberSortOrder.Text = "Remember sort order";
            this.ttGeneral.SetToolTip(this.chkCredPickRememberSortOrder, "Automatically save last credential picker column sort order.");
            this.chkCredPickRememberSortOrder.UseVisualStyleBackColor = false;
            // 
            // chkCredPickRememberSize
            // 
            this.chkCredPickRememberSize.AutoSize = true;
            this.chkCredPickRememberSize.BackColor = System.Drawing.Color.Transparent;
            this.chkCredPickRememberSize.Location = new System.Drawing.Point(6, 21);
            this.chkCredPickRememberSize.Margin = new System.Windows.Forms.Padding(0);
            this.chkCredPickRememberSize.Name = "chkCredPickRememberSize";
            this.chkCredPickRememberSize.Size = new System.Drawing.Size(102, 17);
            this.chkCredPickRememberSize.TabIndex = 0;
            this.chkCredPickRememberSize.Text = "Remember size";
            this.ttGeneral.SetToolTip(this.chkCredPickRememberSize, "Automatically save last credential picker window size.");
            this.chkCredPickRememberSize.UseVisualStyleBackColor = false;
            // 
            // lblCredPickWidth
            // 
            this.lblCredPickWidth.AutoSize = true;
            this.lblCredPickWidth.BackColor = System.Drawing.Color.Transparent;
            this.lblCredPickWidth.Location = new System.Drawing.Point(3, 45);
            this.lblCredPickWidth.Margin = new System.Windows.Forms.Padding(0);
            this.lblCredPickWidth.Name = "lblCredPickWidth";
            this.lblCredPickWidth.Size = new System.Drawing.Size(87, 13);
            this.lblCredPickWidth.TabIndex = 1;
            this.lblCredPickWidth.Text = "Window width:";
            // 
            // numCredPickWidth
            // 
            this.numCredPickWidth.Location = new System.Drawing.Point(95, 42);
            this.numCredPickWidth.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.numCredPickWidth.Name = "numCredPickWidth";
            this.numCredPickWidth.Size = new System.Drawing.Size(85, 22);
            this.numCredPickWidth.TabIndex = 2;
            this.ttGeneral.SetToolTip(this.numCredPickWidth, "Overwrite credential pickers window width.");
            this.numCredPickWidth.Enter += new System.EventHandler(this.num_Enter);
            this.numCredPickWidth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.num_KeyUp);
            this.numCredPickWidth.Leave += new System.EventHandler(this.num_Leave);
            // 
            // numCredPickHeight
            // 
            this.numCredPickHeight.Location = new System.Drawing.Point(95, 66);
            this.numCredPickHeight.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.numCredPickHeight.Name = "numCredPickHeight";
            this.numCredPickHeight.Size = new System.Drawing.Size(85, 22);
            this.numCredPickHeight.TabIndex = 4;
            this.ttGeneral.SetToolTip(this.numCredPickHeight, "Overwrite credential pickers window height.");
            this.numCredPickHeight.Enter += new System.EventHandler(this.num_Enter);
            this.numCredPickHeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.num_KeyUp);
            this.numCredPickHeight.Leave += new System.EventHandler(this.num_Leave);
            // 
            // lblCredPickHeight
            // 
            this.lblCredPickHeight.AutoSize = true;
            this.lblCredPickHeight.BackColor = System.Drawing.Color.Transparent;
            this.lblCredPickHeight.Location = new System.Drawing.Point(3, 69);
            this.lblCredPickHeight.Margin = new System.Windows.Forms.Padding(0);
            this.lblCredPickHeight.Name = "lblCredPickHeight";
            this.lblCredPickHeight.Size = new System.Drawing.Size(91, 13);
            this.lblCredPickHeight.TabIndex = 3;
            this.lblCredPickHeight.Text = "Window height:";
            // 
            // grpCredPickerEntryOptions
            // 
            this.grpCredPickerEntryOptions.AutoSize = true;
            this.grpCredPickerEntryOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpCredPickerEntryOptions.BackColor = System.Drawing.Color.Transparent;
            this.grpCredPickerEntryOptions.Controls.Add(this.chkCredPickIncludeSelected);
            this.grpCredPickerEntryOptions.Controls.Add(this.chkCredPickShowInGroups);
            this.grpCredPickerEntryOptions.Controls.Add(this.chkKeepassShowResolvedReferences);
            this.grpCredPickerEntryOptions.Controls.Add(this.chkCredPickLargeRows);
            this.grpCredPickerEntryOptions.Location = new System.Drawing.Point(187, 0);
            this.grpCredPickerEntryOptions.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.grpCredPickerEntryOptions.Name = "grpCredPickerEntryOptions";
            this.grpCredPickerEntryOptions.Padding = new System.Windows.Forms.Padding(0);
            this.grpCredPickerEntryOptions.Size = new System.Drawing.Size(127, 116);
            this.grpCredPickerEntryOptions.TabIndex = 1;
            this.grpCredPickerEntryOptions.TabStop = false;
            this.grpCredPickerEntryOptions.Text = "Entries";
            // 
            // chkCredPickIncludeSelected
            // 
            this.chkCredPickIncludeSelected.AutoSize = true;
            this.chkCredPickIncludeSelected.BackColor = System.Drawing.Color.Transparent;
            this.chkCredPickIncludeSelected.Location = new System.Drawing.Point(6, 63);
            this.chkCredPickIncludeSelected.Margin = new System.Windows.Forms.Padding(0);
            this.chkCredPickIncludeSelected.Name = "chkCredPickIncludeSelected";
            this.chkCredPickIncludeSelected.Size = new System.Drawing.Size(109, 17);
            this.chkCredPickIncludeSelected.TabIndex = 2;
            this.chkCredPickIncludeSelected.Text = "Inlcude selected";
            this.ttEntries.SetToolTip(this.chkCredPickIncludeSelected, "Always include selected entries with credentials in credential picker list.");
            this.chkCredPickIncludeSelected.UseVisualStyleBackColor = false;
            // 
            // chkCredPickShowInGroups
            // 
            this.chkCredPickShowInGroups.AutoSize = true;
            this.chkCredPickShowInGroups.BackColor = System.Drawing.Color.Transparent;
            this.chkCredPickShowInGroups.Location = new System.Drawing.Point(6, 42);
            this.chkCredPickShowInGroups.Margin = new System.Windows.Forms.Padding(0);
            this.chkCredPickShowInGroups.Name = "chkCredPickShowInGroups";
            this.chkCredPickShowInGroups.Size = new System.Drawing.Size(108, 17);
            this.chkCredPickShowInGroups.TabIndex = 1;
            this.chkCredPickShowInGroups.Text = "Show in groups";
            this.ttEntries.SetToolTip(this.chkCredPickShowInGroups, "Show selectable credential entries in groups if checked.");
            this.chkCredPickShowInGroups.UseVisualStyleBackColor = false;
            // 
            // chkKeepassShowResolvedReferences
            // 
            this.chkKeepassShowResolvedReferences.AutoSize = true;
            this.chkKeepassShowResolvedReferences.BackColor = System.Drawing.Color.Transparent;
            this.chkKeepassShowResolvedReferences.Location = new System.Drawing.Point(6, 21);
            this.chkKeepassShowResolvedReferences.Margin = new System.Windows.Forms.Padding(0);
            this.chkKeepassShowResolvedReferences.Name = "chkKeepassShowResolvedReferences";
            this.chkKeepassShowResolvedReferences.Size = new System.Drawing.Size(121, 17);
            this.chkKeepassShowResolvedReferences.TabIndex = 0;
            this.chkKeepassShowResolvedReferences.Text = "Resolve references";
            this.ttEntries.SetToolTip(this.chkKeepassShowResolvedReferences, "Enable or disable resolving of references for entries shown in credential picker." +
        "");
            this.chkKeepassShowResolvedReferences.UseVisualStyleBackColor = false;
            // 
            // chkCredPickLargeRows
            // 
            this.chkCredPickLargeRows.AutoSize = true;
            this.chkCredPickLargeRows.BackColor = System.Drawing.Color.Transparent;
            this.chkCredPickLargeRows.Location = new System.Drawing.Point(6, 84);
            this.chkCredPickLargeRows.Margin = new System.Windows.Forms.Padding(0);
            this.chkCredPickLargeRows.Name = "chkCredPickLargeRows";
            this.chkCredPickLargeRows.Size = new System.Drawing.Size(86, 17);
            this.chkCredPickLargeRows.TabIndex = 3;
            this.chkCredPickLargeRows.Text = "Larger rows";
            this.ttEntries.SetToolTip(this.chkCredPickLargeRows, "Enlarge row height of entries shown in credential picker list.");
            this.chkCredPickLargeRows.UseVisualStyleBackColor = false;
            // 
            // grpCredPickerTriggerOptions
            // 
            this.grpCredPickerTriggerOptions.AutoSize = true;
            this.grpCredPickerTriggerOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpCredPickerTriggerOptions.BackColor = System.Drawing.Color.Transparent;
            this.grpCredPickerTriggerOptions.Controls.Add(this.chkCredPickerTriggerRecursive);
            this.grpCredPickerTriggerOptions.Controls.Add(this.lblCredPickerCustomGroup);
            this.grpCredPickerTriggerOptions.Controls.Add(this.txtCredPickerCustomGroup);
            this.grpCredPickerTriggerOptions.Location = new System.Drawing.Point(317, 0);
            this.grpCredPickerTriggerOptions.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.grpCredPickerTriggerOptions.Name = "grpCredPickerTriggerOptions";
            this.grpCredPickerTriggerOptions.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.grpCredPickerTriggerOptions.Size = new System.Drawing.Size(137, 99);
            this.grpCredPickerTriggerOptions.TabIndex = 2;
            this.grpCredPickerTriggerOptions.TabStop = false;
            this.grpCredPickerTriggerOptions.Text = "Trigger";
            // 
            // chkCredPickerTriggerRecursive
            // 
            this.chkCredPickerTriggerRecursive.AutoSize = true;
            this.chkCredPickerTriggerRecursive.BackColor = System.Drawing.Color.Transparent;
            this.chkCredPickerTriggerRecursive.Location = new System.Drawing.Point(6, 67);
            this.chkCredPickerTriggerRecursive.Margin = new System.Windows.Forms.Padding(0);
            this.chkCredPickerTriggerRecursive.Name = "chkCredPickerTriggerRecursive";
            this.chkCredPickerTriggerRecursive.Size = new System.Drawing.Size(112, 17);
            this.chkCredPickerTriggerRecursive.TabIndex = 3;
            this.chkCredPickerTriggerRecursive.Text = "Recursive trigger";
            this.ttTrigger.SetToolTip(this.chkCredPickerTriggerRecursive, "When enabled sub-groups will trigger the credential picker.");
            this.chkCredPickerTriggerRecursive.UseVisualStyleBackColor = false;
            // 
            // lblCredPickerCustomGroup
            // 
            this.lblCredPickerCustomGroup.AutoSize = true;
            this.lblCredPickerCustomGroup.BackColor = System.Drawing.Color.Transparent;
            this.lblCredPickerCustomGroup.Location = new System.Drawing.Point(3, 22);
            this.lblCredPickerCustomGroup.Margin = new System.Windows.Forms.Padding(0);
            this.lblCredPickerCustomGroup.Name = "lblCredPickerCustomGroup";
            this.lblCredPickerCustomGroup.Size = new System.Drawing.Size(122, 13);
            this.lblCredPickerCustomGroup.TabIndex = 0;
            this.lblCredPickerCustomGroup.Text = "Custom trigger group:";
            // 
            // txtCredPickerCustomGroup
            // 
            this.txtCredPickerCustomGroup.Location = new System.Drawing.Point(6, 39);
            this.txtCredPickerCustomGroup.Margin = new System.Windows.Forms.Padding(0);
            this.txtCredPickerCustomGroup.Name = "txtCredPickerCustomGroup";
            this.txtCredPickerCustomGroup.Size = new System.Drawing.Size(125, 22);
            this.txtCredPickerCustomGroup.TabIndex = 1;
            this.txtCredPickerCustomGroup.WordWrap = false;
            this.txtCredPickerCustomGroup.Enter += new System.EventHandler(this.txtCredPickerCustomGroup_Enter);
            this.txtCredPickerCustomGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCredPickerCustomGroup_KeyDown);
            this.txtCredPickerCustomGroup.Leave += new System.EventHandler(this.txtCredPickerCustomGroup_Leave);
            this.txtCredPickerCustomGroup.MouseEnter += new System.EventHandler(this.txtCredPickerCustomGroup_MouseEnter);
            this.txtCredPickerCustomGroup.MouseLeave += new System.EventHandler(this.txtCredPickerCustomGroup_MouseLeave);
            this.txtCredPickerCustomGroup.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtCredPickerCustomGroup_MouseMove);
            this.txtCredPickerCustomGroup.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_PreviewKeyDown);
            // 
            // lblRevision
            // 
            lblRevision.AutoSize = true;
            lblRevision.BackColor = System.Drawing.Color.Transparent;
            lblRevision.Location = new System.Drawing.Point(3, 314);
            lblRevision.Margin = new System.Windows.Forms.Padding(3);
            lblRevision.Name = "lblRevision";
            lblRevision.Size = new System.Drawing.Size(53, 13);
            lblRevision.TabIndex = 4;
            lblRevision.Text = "Revision:";
            // 
            // lblKeePassRDP
            // 
            lblKeePassRDP.AutoSize = true;
            lblKeePassRDP.BackColor = System.Drawing.Color.Transparent;
            this.tblAbout.SetColumnSpan(lblKeePassRDP, 2);
            lblKeePassRDP.Dock = System.Windows.Forms.DockStyle.Fill;
            lblKeePassRDP.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblKeePassRDP.Location = new System.Drawing.Point(3, 259);
            lblKeePassRDP.Margin = new System.Windows.Forms.Padding(3);
            lblKeePassRDP.Name = "lblKeePassRDP";
            lblKeePassRDP.Size = new System.Drawing.Size(250, 30);
            lblKeePassRDP.TabIndex = 3;
            lblKeePassRDP.Text = "KeePassRDP";
            lblKeePassRDP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.BackColor = System.Drawing.Color.Transparent;
            lblVersion.Location = new System.Drawing.Point(3, 295);
            lblVersion.Margin = new System.Windows.Forms.Padding(3);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new System.Drawing.Size(48, 13);
            lblVersion.TabIndex = 9;
            lblVersion.Text = "Version:";
            // 
            // pnlAboutLinks
            // 
            pnlAboutLinks.AutoSize = true;
            pnlAboutLinks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            pnlAboutLinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblAbout.SetColumnSpan(pnlAboutLinks, 2);
            pnlAboutLinks.Controls.Add(this.llLicense);
            pnlAboutLinks.Controls.Add(this.llWebsite);
            pnlAboutLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlAboutLinks.Location = new System.Drawing.Point(3, 336);
            pnlAboutLinks.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            pnlAboutLinks.Name = "pnlAboutLinks";
            pnlAboutLinks.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            pnlAboutLinks.Size = new System.Drawing.Size(250, 40);
            pnlAboutLinks.TabIndex = 1;
            // 
            // llLicense
            // 
            this.llLicense.AutoSize = true;
            this.llLicense.BackColor = System.Drawing.Color.Transparent;
            this.llLicense.Location = new System.Drawing.Point(3, 22);
            this.llLicense.Name = "llLicense";
            this.llLicense.Size = new System.Drawing.Size(44, 13);
            this.llLicense.TabIndex = 1;
            this.llLicense.TabStop = true;
            this.llLicense.Text = "License";
            this.llLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLicense_LinkClicked);
            // 
            // llWebsite
            // 
            this.llWebsite.AutoSize = true;
            this.llWebsite.BackColor = System.Drawing.Color.Transparent;
            this.llWebsite.Location = new System.Drawing.Point(3, 3);
            this.llWebsite.Name = "llWebsite";
            this.llWebsite.Size = new System.Drawing.Size(113, 13);
            this.llWebsite.TabIndex = 0;
            this.llWebsite.TabStop = true;
            this.llWebsite.Text = "KeePassRDP Website";
            this.llWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llWebsite_LinkClicked);
            // 
            // flpCommandButtons
            // 
            flpCommandButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            flpCommandButtons.AutoSize = true;
            flpCommandButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flpCommandButtons.Controls.Add(this.cmdOk);
            flpCommandButtons.Controls.Add(this.cmdCancel);
            flpCommandButtons.Location = new System.Drawing.Point(417, 2);
            flpCommandButtons.Margin = new System.Windows.Forms.Padding(0, 2, 1, 0);
            flpCommandButtons.Name = "flpCommandButtons";
            flpCommandButtons.Size = new System.Drawing.Size(160, 23);
            flpCommandButtons.TabIndex = 5;
            // 
            // cmdOk
            // 
            this.cmdOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOk.AutoSize = true;
            this.cmdOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOk.ImageKey = "Checkmark";
            this.cmdOk.ImageList = this.imageList1;
            this.cmdOk.Location = new System.Drawing.Point(0, 0);
            this.cmdOk.Margin = new System.Windows.Forms.Padding(0);
            this.cmdOk.MinimumSize = new System.Drawing.Size(80, 0);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cmdOk.Size = new System.Drawing.Size(80, 23);
            this.cmdOk.TabIndex = 0;
            this.cmdOk.Text = "&OK";
            this.cmdOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttGeneric.SetToolTip(this.cmdOk, "Save changes");
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.AutoSize = true;
            this.cmdCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.ImageKey = "Cancel";
            this.cmdCancel.ImageList = this.imageList1;
            this.cmdCancel.Location = new System.Drawing.Point(80, 0);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(0);
            this.cmdCancel.MinimumSize = new System.Drawing.Size(80, 0);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cmdCancel.Size = new System.Drawing.Size(80, 23);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttGeneric.SetToolTip(this.cmdCancel, "Discard changes");
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // flpOptions
            // 
            this.flpOptions.Controls.Add(this.grpCredentialOptions);
            this.flpOptions.Controls.Add(this.grpEntryOptions);
            this.flpOptions.Controls.Add(this.grpHotkeyOptions);
            this.flpOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOptions.Location = new System.Drawing.Point(3, 3);
            this.flpOptions.Name = "flpOptions";
            this.flpOptions.Size = new System.Drawing.Size(547, 140);
            this.flpOptions.TabIndex = 0;
            this.flpOptions.WrapContents = false;
            // 
            // grpCredentialOptions
            // 
            this.grpCredentialOptions.AutoSize = true;
            this.grpCredentialOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpCredentialOptions.Controls.Add(this.chkCredVaultAdaptiveTtl);
            this.grpCredentialOptions.Controls.Add(flpCredVaultTtl);
            this.grpCredentialOptions.Controls.Add(this.chkCredVaultRemoveOnExit);
            this.grpCredentialOptions.Controls.Add(this.chkCredVaultOverwriteExisting);
            this.grpCredentialOptions.Controls.Add(this.chkCredVaultUseWindows);
            this.grpCredentialOptions.Location = new System.Drawing.Point(0, 0);
            this.grpCredentialOptions.Margin = new System.Windows.Forms.Padding(0);
            this.grpCredentialOptions.Name = "grpCredentialOptions";
            this.grpCredentialOptions.Padding = new System.Windows.Forms.Padding(0);
            this.grpCredentialOptions.Size = new System.Drawing.Size(184, 140);
            this.grpCredentialOptions.TabIndex = 0;
            this.grpCredentialOptions.TabStop = false;
            this.grpCredentialOptions.Text = "Credentials";
            // 
            // chkCredVaultAdaptiveTtl
            // 
            this.chkCredVaultAdaptiveTtl.AutoSize = true;
            this.chkCredVaultAdaptiveTtl.BackColor = System.Drawing.Color.Transparent;
            this.chkCredVaultAdaptiveTtl.Location = new System.Drawing.Point(6, 108);
            this.chkCredVaultAdaptiveTtl.Margin = new System.Windows.Forms.Padding(0);
            this.chkCredVaultAdaptiveTtl.Name = "chkCredVaultAdaptiveTtl";
            this.chkCredVaultAdaptiveTtl.Size = new System.Drawing.Size(112, 17);
            this.chkCredVaultAdaptiveTtl.TabIndex = 5;
            this.chkCredVaultAdaptiveTtl.Text = "Adaptive lifetime";
            this.ttCredentials.SetToolTip(this.chkCredVaultAdaptiveTtl, "Increase TTL of credential until mstsc.exe is connected and remove instantly.");
            this.chkCredVaultAdaptiveTtl.UseVisualStyleBackColor = false;
            // 
            // chkCredVaultRemoveOnExit
            // 
            this.chkCredVaultRemoveOnExit.AutoSize = true;
            this.chkCredVaultRemoveOnExit.BackColor = System.Drawing.Color.Transparent;
            this.chkCredVaultRemoveOnExit.Location = new System.Drawing.Point(6, 63);
            this.chkCredVaultRemoveOnExit.Margin = new System.Windows.Forms.Padding(0);
            this.chkCredVaultRemoveOnExit.Name = "chkCredVaultRemoveOnExit";
            this.chkCredVaultRemoveOnExit.Size = new System.Drawing.Size(112, 17);
            this.chkCredVaultRemoveOnExit.TabIndex = 2;
            this.chkCredVaultRemoveOnExit.Text = "Remove on close";
            this.ttCredentials.SetToolTip(this.chkCredVaultRemoveOnExit, "Always remove credential when mstsc.exe exits (ignoring TTL).\r\nSet TTL to 0 to re" +
        "move credentials on exit only.");
            this.chkCredVaultRemoveOnExit.UseVisualStyleBackColor = false;
            // 
            // chkCredVaultOverwriteExisting
            // 
            this.chkCredVaultOverwriteExisting.AutoSize = true;
            this.chkCredVaultOverwriteExisting.BackColor = System.Drawing.Color.Transparent;
            this.chkCredVaultOverwriteExisting.Location = new System.Drawing.Point(6, 42);
            this.chkCredVaultOverwriteExisting.Margin = new System.Windows.Forms.Padding(0);
            this.chkCredVaultOverwriteExisting.Name = "chkCredVaultOverwriteExisting";
            this.chkCredVaultOverwriteExisting.Size = new System.Drawing.Size(135, 17);
            this.chkCredVaultOverwriteExisting.TabIndex = 1;
            this.chkCredVaultOverwriteExisting.Text = "Overwrite credentials";
            this.ttCredentials.SetToolTip(this.chkCredVaultOverwriteExisting, "Force overwriting of existing credentials in Windows vault that are not managed b" +
        "y KeePassRDP.");
            this.chkCredVaultOverwriteExisting.UseVisualStyleBackColor = false;
            // 
            // chkCredVaultUseWindows
            // 
            this.chkCredVaultUseWindows.AutoSize = true;
            this.chkCredVaultUseWindows.BackColor = System.Drawing.Color.Transparent;
            this.chkCredVaultUseWindows.Location = new System.Drawing.Point(6, 21);
            this.chkCredVaultUseWindows.Margin = new System.Windows.Forms.Padding(0);
            this.chkCredVaultUseWindows.Name = "chkCredVaultUseWindows";
            this.chkCredVaultUseWindows.Size = new System.Drawing.Size(178, 17);
            this.chkCredVaultUseWindows.TabIndex = 0;
            this.chkCredVaultUseWindows.Text = "Store as Windows credentials";
            this.ttCredentials.SetToolTip(this.chkCredVaultUseWindows, resources.GetString("chkCredVaultUseWindows.ToolTip"));
            this.chkCredVaultUseWindows.UseVisualStyleBackColor = false;
            // 
            // grpEntryOptions
            // 
            this.grpEntryOptions.AutoSize = true;
            this.grpEntryOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpEntryOptions.Controls.Add(this.chkKeePassDefaultEntryAction);
            this.grpEntryOptions.Controls.Add(this.chkKeePassAlwaysConfirm);
            this.grpEntryOptions.Controls.Add(this.chkKeePassConnectToAll);
            this.grpEntryOptions.Location = new System.Drawing.Point(187, 0);
            this.grpEntryOptions.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.grpEntryOptions.Name = "grpEntryOptions";
            this.grpEntryOptions.Padding = new System.Windows.Forms.Padding(0);
            this.grpEntryOptions.Size = new System.Drawing.Size(160, 108);
            this.grpEntryOptions.TabIndex = 1;
            this.grpEntryOptions.TabStop = false;
            this.grpEntryOptions.Text = "Entries";
            // 
            // chkKeePassDefaultEntryAction
            // 
            this.chkKeePassDefaultEntryAction.AutoSize = true;
            this.chkKeePassDefaultEntryAction.BackColor = System.Drawing.Color.Transparent;
            this.chkKeePassDefaultEntryAction.Location = new System.Drawing.Point(6, 76);
            this.chkKeePassDefaultEntryAction.Margin = new System.Windows.Forms.Padding(0);
            this.chkKeePassDefaultEntryAction.Name = "chkKeePassDefaultEntryAction";
            this.chkKeePassDefaultEntryAction.Size = new System.Drawing.Size(136, 17);
            this.chkKeePassDefaultEntryAction.TabIndex = 2;
            this.chkKeePassDefaultEntryAction.Text = "Add as default action";
            this.ttEntries.SetToolTip(this.chkKeePassDefaultEntryAction, "Trigger \"Open RDP connection\" when double-clicking URL of entries in RDP group(s)" +
        "");
            this.chkKeePassDefaultEntryAction.UseVisualStyleBackColor = false;
            // 
            // chkKeePassAlwaysConfirm
            // 
            this.chkKeePassAlwaysConfirm.AutoSize = true;
            this.chkKeePassAlwaysConfirm.BackColor = System.Drawing.Color.Transparent;
            this.chkKeePassAlwaysConfirm.Location = new System.Drawing.Point(6, 42);
            this.chkKeePassAlwaysConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.chkKeePassAlwaysConfirm.Name = "chkKeePassAlwaysConfirm";
            this.chkKeePassAlwaysConfirm.Size = new System.Drawing.Size(154, 30);
            this.chkKeePassAlwaysConfirm.TabIndex = 1;
            this.chkKeePassAlwaysConfirm.Text = "Always confirm duplicate\r\nconnection attempts";
            this.ttEntries.SetToolTip(this.chkKeePassAlwaysConfirm, "Toggle between always asking for confirmation when connecting\r\nto the same target" +
        ", or only when using the same credentials.");
            this.chkKeePassAlwaysConfirm.UseVisualStyleBackColor = false;
            // 
            // chkKeePassConnectToAll
            // 
            this.chkKeePassConnectToAll.AutoSize = true;
            this.chkKeePassConnectToAll.BackColor = System.Drawing.Color.Transparent;
            this.chkKeePassConnectToAll.Location = new System.Drawing.Point(6, 21);
            this.chkKeePassConnectToAll.Margin = new System.Windows.Forms.Padding(0);
            this.chkKeePassConnectToAll.Name = "chkKeePassConnectToAll";
            this.chkKeePassConnectToAll.Size = new System.Drawing.Size(98, 17);
            this.chkKeePassConnectToAll.TabIndex = 0;
            this.chkKeePassConnectToAll.Text = "Connect to all";
            this.ttEntries.SetToolTip(this.chkKeePassConnectToAll, "Toggle opening RDP for all selected entries or last selected entry only.\r\nShows c" +
        "redential picker once for each parent group with all entry settings merged.");
            this.chkKeePassConnectToAll.UseVisualStyleBackColor = false;
            // 
            // grpHotkeyOptions
            // 
            this.grpHotkeyOptions.AutoSize = true;
            this.grpHotkeyOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpHotkeyOptions.Controls.Add(this.chkKeePassConfirmOnClose);
            this.grpHotkeyOptions.Controls.Add(this.chkKeePassContextMenuOnScreen);
            this.grpHotkeyOptions.Controls.Add(this.chkKeePassHotkeysRegisterLast);
            this.grpHotkeyOptions.Location = new System.Drawing.Point(350, 0);
            this.grpHotkeyOptions.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.grpHotkeyOptions.MinimumSize = new System.Drawing.Size(100, 0);
            this.grpHotkeyOptions.Name = "grpHotkeyOptions";
            this.grpHotkeyOptions.Padding = new System.Windows.Forms.Padding(0);
            this.grpHotkeyOptions.Size = new System.Drawing.Size(130, 101);
            this.grpHotkeyOptions.TabIndex = 2;
            this.grpHotkeyOptions.TabStop = false;
            this.grpHotkeyOptions.Text = "UI";
            // 
            // chkKeePassConfirmOnClose
            // 
            this.chkKeePassConfirmOnClose.AutoSize = true;
            this.chkKeePassConfirmOnClose.BackColor = System.Drawing.Color.Transparent;
            this.chkKeePassConfirmOnClose.Location = new System.Drawing.Point(6, 69);
            this.chkKeePassConfirmOnClose.Margin = new System.Windows.Forms.Padding(0);
            this.chkKeePassConfirmOnClose.Name = "chkKeePassConfirmOnClose";
            this.chkKeePassConfirmOnClose.Size = new System.Drawing.Size(113, 17);
            this.chkKeePassConfirmOnClose.TabIndex = 2;
            this.chkKeePassConfirmOnClose.Text = "Confirm on close";
            this.ttUI.SetToolTip(this.chkKeePassConfirmOnClose, "Confirm closing of KeePass when there are active RDP connections.");
            this.chkKeePassConfirmOnClose.UseVisualStyleBackColor = false;
            // 
            // chkKeePassContextMenuOnScreen
            // 
            this.chkKeePassContextMenuOnScreen.AutoSize = true;
            this.chkKeePassContextMenuOnScreen.BackColor = System.Drawing.Color.Transparent;
            this.chkKeePassContextMenuOnScreen.Location = new System.Drawing.Point(6, 15);
            this.chkKeePassContextMenuOnScreen.Margin = new System.Windows.Forms.Padding(0);
            this.chkKeePassContextMenuOnScreen.Name = "chkKeePassContextMenuOnScreen";
            this.chkKeePassContextMenuOnScreen.Size = new System.Drawing.Size(124, 30);
            this.chkKeePassContextMenuOnScreen.TabIndex = 1;
            this.chkKeePassContextMenuOnScreen.Text = "Keep context menu\r\non screen";
            this.ttUI.SetToolTip(this.chkKeePassContextMenuOnScreen, "Make the context menu stay on the same screen when opening.");
            this.chkKeePassContextMenuOnScreen.UseVisualStyleBackColor = false;
            // 
            // chkKeePassHotkeysRegisterLast
            // 
            this.chkKeePassHotkeysRegisterLast.AutoSize = true;
            this.chkKeePassHotkeysRegisterLast.BackColor = System.Drawing.Color.Transparent;
            this.chkKeePassHotkeysRegisterLast.Location = new System.Drawing.Point(6, 46);
            this.chkKeePassHotkeysRegisterLast.Margin = new System.Windows.Forms.Padding(0);
            this.chkKeePassHotkeysRegisterLast.Name = "chkKeePassHotkeysRegisterLast";
            this.chkKeePassHotkeysRegisterLast.Size = new System.Drawing.Size(119, 17);
            this.chkKeePassHotkeysRegisterLast.TabIndex = 0;
            this.chkKeePassHotkeysRegisterLast.Text = "Overwrite hotkeys";
            this.ttUI.SetToolTip(this.chkKeePassHotkeysRegisterLast, "Force registering of hotkeys after all KeePass plugins have initialized.\r\nOnly en" +
        "able when necessary. Can have unwanted side-effects.");
            this.chkKeePassHotkeysRegisterLast.UseVisualStyleBackColor = false;
            // 
            // ttMstscParameters
            // 
            this.ttMstscParameters.AutoPopDelay = 10000;
            this.ttMstscParameters.InitialDelay = 500;
            this.ttMstscParameters.ReshowDelay = 100;
            this.ttMstscParameters.ToolTipTitle = "mstsc.exe parameters";
            // 
            // numMstscHeight
            // 
            this.numMstscHeight.Location = new System.Drawing.Point(70, 191);
            this.numMstscHeight.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.numMstscHeight.Name = "numMstscHeight";
            this.numMstscHeight.Size = new System.Drawing.Size(85, 22);
            this.numMstscHeight.TabIndex = 7;
            this.ttMstscParameters.SetToolTip(this.numMstscHeight, "/h:<height>\r\nSpecifies the height of the remote desktop window.\r\n0 = unset");
            this.numMstscHeight.Enter += new System.EventHandler(this.num_Enter);
            this.numMstscHeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.num_KeyUp);
            this.numMstscHeight.Leave += new System.EventHandler(this.num_Leave);
            // 
            // numMstscWidth
            // 
            this.numMstscWidth.Location = new System.Drawing.Point(70, 167);
            this.numMstscWidth.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.numMstscWidth.Name = "numMstscWidth";
            this.numMstscWidth.Size = new System.Drawing.Size(85, 22);
            this.numMstscWidth.TabIndex = 5;
            this.ttMstscParameters.SetToolTip(this.numMstscWidth, "/w:<width>\r\nSpecifies the width of the remote desktop window.\r\n0 = unset");
            this.numMstscWidth.Enter += new System.EventHandler(this.num_Enter);
            this.numMstscWidth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.num_KeyUp);
            this.numMstscWidth.Leave += new System.EventHandler(this.num_Leave);
            // 
            // chkMstscUseMultimon
            // 
            this.chkMstscUseMultimon.AutoSize = true;
            this.chkMstscUseMultimon.BackColor = System.Drawing.Color.Transparent;
            this.chkMstscUseMultimon.Location = new System.Drawing.Point(6, 147);
            this.chkMstscUseMultimon.Margin = new System.Windows.Forms.Padding(0);
            this.chkMstscUseMultimon.Name = "chkMstscUseMultimon";
            this.chkMstscUseMultimon.Size = new System.Drawing.Size(160, 17);
            this.chkMstscUseMultimon.TabIndex = 3;
            this.chkMstscUseMultimon.Text = "Use &multimon - /multimon";
            this.ttMstscParameters.SetToolTip(this.chkMstscUseMultimon, "/multimon\r\nConfigures the remote desktop services session monitor layout to be id" +
        "entical to the\r\ncurrent client-side configuration.");
            this.chkMstscUseMultimon.UseVisualStyleBackColor = false;
            this.chkMstscUseMultimon.CheckedChanged += new System.EventHandler(this.chkMstsc_CheckedChanged);
            // 
            // chkMstscUseSpan
            // 
            this.chkMstscUseSpan.AutoSize = true;
            this.chkMstscUseSpan.BackColor = System.Drawing.Color.Transparent;
            this.chkMstscUseSpan.Location = new System.Drawing.Point(6, 126);
            this.chkMstscUseSpan.Margin = new System.Windows.Forms.Padding(0);
            this.chkMstscUseSpan.Name = "chkMstscUseSpan";
            this.chkMstscUseSpan.Size = new System.Drawing.Size(136, 17);
            this.chkMstscUseSpan.TabIndex = 2;
            this.chkMstscUseSpan.Text = "Use &spanning - /span";
            this.ttMstscParameters.SetToolTip(this.chkMstscUseSpan, resources.GetString("chkMstscUseSpan.ToolTip"));
            this.chkMstscUseSpan.UseVisualStyleBackColor = false;
            this.chkMstscUseSpan.CheckedChanged += new System.EventHandler(this.chkMstsc_CheckedChanged);
            // 
            // chkMstscUseAdmin
            // 
            this.chkMstscUseAdmin.AutoSize = true;
            this.chkMstscUseAdmin.BackColor = System.Drawing.Color.Transparent;
            this.chkMstscUseAdmin.Location = new System.Drawing.Point(6, 63);
            this.chkMstscUseAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.chkMstscUseAdmin.Name = "chkMstscUseAdmin";
            this.chkMstscUseAdmin.Size = new System.Drawing.Size(126, 17);
            this.chkMstscUseAdmin.TabIndex = 1;
            this.chkMstscUseAdmin.Text = "Use &admin - /admin";
            this.ttMstscParameters.SetToolTip(this.chkMstscUseAdmin, "/admin\r\nConnects you to the session for administering a remote computer.");
            this.chkMstscUseAdmin.UseVisualStyleBackColor = false;
            // 
            // chkMstscUseFullscreen
            // 
            this.chkMstscUseFullscreen.AutoSize = true;
            this.chkMstscUseFullscreen.BackColor = System.Drawing.Color.Transparent;
            this.chkMstscUseFullscreen.Location = new System.Drawing.Point(6, 21);
            this.chkMstscUseFullscreen.Margin = new System.Windows.Forms.Padding(0);
            this.chkMstscUseFullscreen.Name = "chkMstscUseFullscreen";
            this.chkMstscUseFullscreen.Size = new System.Drawing.Size(116, 17);
            this.chkMstscUseFullscreen.TabIndex = 0;
            this.chkMstscUseFullscreen.Text = "Use &fullscreen - /f";
            this.ttMstscParameters.SetToolTip(this.chkMstscUseFullscreen, "/f\r\nStarts remote desktop connection in full-screen mode.");
            this.chkMstscUseFullscreen.UseVisualStyleBackColor = false;
            this.chkMstscUseFullscreen.CheckedChanged += new System.EventHandler(this.chkMstsc_CheckedChanged);
            // 
            // chkMstscUsePublic
            // 
            this.chkMstscUsePublic.AutoSize = true;
            this.chkMstscUsePublic.BackColor = System.Drawing.Color.Transparent;
            this.chkMstscUsePublic.Location = new System.Drawing.Point(6, 42);
            this.chkMstscUsePublic.Margin = new System.Windows.Forms.Padding(0);
            this.chkMstscUsePublic.Name = "chkMstscUsePublic";
            this.chkMstscUsePublic.Size = new System.Drawing.Size(126, 17);
            this.chkMstscUsePublic.TabIndex = 8;
            this.chkMstscUsePublic.Text = "Use &public - /public";
            this.ttMstscParameters.SetToolTip(this.chkMstscUsePublic, "/public\r\nRuns Remote Desktop in public mode. In public mode, passwords and bitmap" +
        "s aren\'t cached.");
            this.chkMstscUsePublic.UseVisualStyleBackColor = false;
            // 
            // chkMstscUseRestrictedAdmin
            // 
            this.chkMstscUseRestrictedAdmin.AutoSize = true;
            this.chkMstscUseRestrictedAdmin.BackColor = System.Drawing.Color.Transparent;
            this.chkMstscUseRestrictedAdmin.Location = new System.Drawing.Point(6, 84);
            this.chkMstscUseRestrictedAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.chkMstscUseRestrictedAdmin.Name = "chkMstscUseRestrictedAdmin";
            this.chkMstscUseRestrictedAdmin.Size = new System.Drawing.Size(224, 17);
            this.chkMstscUseRestrictedAdmin.TabIndex = 9;
            this.chkMstscUseRestrictedAdmin.Text = "Use &restrictedAdmin - /restrictedAdmin";
            this.ttMstscParameters.SetToolTip(this.chkMstscUseRestrictedAdmin, resources.GetString("chkMstscUseRestrictedAdmin.ToolTip"));
            this.chkMstscUseRestrictedAdmin.UseVisualStyleBackColor = false;
            // 
            // chkMstscUseRemoteGuard
            // 
            this.chkMstscUseRemoteGuard.AutoSize = true;
            this.chkMstscUseRemoteGuard.BackColor = System.Drawing.Color.Transparent;
            this.chkMstscUseRemoteGuard.Location = new System.Drawing.Point(6, 105);
            this.chkMstscUseRemoteGuard.Margin = new System.Windows.Forms.Padding(0);
            this.chkMstscUseRemoteGuard.Name = "chkMstscUseRemoteGuard";
            this.chkMstscUseRemoteGuard.Size = new System.Drawing.Size(198, 17);
            this.chkMstscUseRemoteGuard.TabIndex = 10;
            this.chkMstscUseRemoteGuard.Text = "Use &remoteGuard - /remoteGuard";
            this.ttMstscParameters.SetToolTip(this.chkMstscUseRemoteGuard, resources.GetString("chkMstscUseRemoteGuard.ToolTip"));
            this.chkMstscUseRemoteGuard.UseVisualStyleBackColor = false;
            // 
            // chkMstscConfirmCertificate
            // 
            this.chkMstscConfirmCertificate.AutoSize = true;
            this.chkMstscConfirmCertificate.BackColor = System.Drawing.Color.Transparent;
            this.chkMstscConfirmCertificate.Location = new System.Drawing.Point(6, 84);
            this.chkMstscConfirmCertificate.Margin = new System.Windows.Forms.Padding(0);
            this.chkMstscConfirmCertificate.Name = "chkMstscConfirmCertificate";
            this.chkMstscConfirmCertificate.Size = new System.Drawing.Size(180, 17);
            this.chkMstscConfirmCertificate.TabIndex = 8;
            this.chkMstscConfirmCertificate.Text = "Confirm self-signed certificate";
            this.ttMstscAutomation.SetToolTip(this.chkMstscConfirmCertificate, "Automatically continue connecting to hosts with self-signed certificates.");
            this.chkMstscConfirmCertificate.UseVisualStyleBackColor = false;
            // 
            // chkMstscReplaceTitle
            // 
            this.chkMstscReplaceTitle.AutoSize = true;
            this.chkMstscReplaceTitle.BackColor = System.Drawing.Color.Transparent;
            this.chkMstscReplaceTitle.Location = new System.Drawing.Point(6, 21);
            this.chkMstscReplaceTitle.Margin = new System.Windows.Forms.Padding(0);
            this.chkMstscReplaceTitle.Name = "chkMstscReplaceTitle";
            this.chkMstscReplaceTitle.Size = new System.Drawing.Size(134, 17);
            this.chkMstscReplaceTitle.TabIndex = 0;
            this.chkMstscReplaceTitle.Text = "Replace window title";
            this.ttMstscAutomation.SetToolTip(this.chkMstscReplaceTitle, "Set mstsc.exe window title to title of entry.");
            this.chkMstscReplaceTitle.UseVisualStyleBackColor = false;
            // 
            // ttCredentials
            // 
            this.ttCredentials.AutoPopDelay = 10000;
            this.ttCredentials.InitialDelay = 500;
            this.ttCredentials.ReshowDelay = 100;
            this.ttCredentials.ToolTipTitle = "Credentials";
            // 
            // ttEntries
            // 
            this.ttEntries.AutoPopDelay = 10000;
            this.ttEntries.InitialDelay = 500;
            this.ttEntries.ReshowDelay = 100;
            this.ttEntries.ToolTipTitle = "Entries";
            // 
            // ttUI
            // 
            this.ttUI.AutoPopDelay = 10000;
            this.ttUI.InitialDelay = 500;
            this.ttUI.ReshowDelay = 100;
            this.ttUI.ToolTipTitle = "UI";
            // 
            // ttGeneral
            // 
            this.ttGeneral.AutoPopDelay = 10000;
            this.ttGeneral.InitialDelay = 500;
            this.ttGeneral.ReshowDelay = 100;
            this.ttGeneral.ToolTipTitle = "General";
            // 
            // ttGeneric
            // 
            this.ttGeneric.AutoPopDelay = 10000;
            this.ttGeneric.InitialDelay = 500;
            this.ttGeneric.ReshowDelay = 100;
            // 
            // chkMstscSecureDesktop
            // 
            this.chkMstscSecureDesktop.AutoSize = true;
            this.chkMstscSecureDesktop.BackColor = System.Drawing.Color.Transparent;
            this.chkMstscSecureDesktop.Location = new System.Drawing.Point(10, 255);
            this.chkMstscSecureDesktop.Margin = new System.Windows.Forms.Padding(10, 4, 0, 0);
            this.chkMstscSecureDesktop.Name = "chkMstscSecureDesktop";
            this.chkMstscSecureDesktop.Size = new System.Drawing.Size(145, 17);
            this.chkMstscSecureDesktop.TabIndex = 3;
            this.chkMstscSecureDesktop.Text = "Run on secure desktop";
            this.ttGeneric.SetToolTip(this.chkMstscSecureDesktop, "Run executable on an isolated desktop to prevent sniffing and key-logging.\r\nWhen " +
        "enabled, switchting to other windows is not possible.");
            this.chkMstscSecureDesktop.UseVisualStyleBackColor = false;
            // 
            // cbMstscExecutable
            // 
            this.cbMstscExecutable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMstscExecutable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMstscExecutable.FormattingEnabled = true;
            this.cbMstscExecutable.Location = new System.Drawing.Point(62, 0);
            this.cbMstscExecutable.Margin = new System.Windows.Forms.Padding(0);
            this.cbMstscExecutable.Name = "cbMstscExecutable";
            this.cbMstscExecutable.Size = new System.Drawing.Size(127, 21);
            this.cbMstscExecutable.TabIndex = 1;
            this.ttGeneric.SetToolTip(this.cbMstscExecutable, "Select the type of executable.");
            this.cbMstscExecutable.SelectedIndexChanged += new System.EventHandler(this.cbMstscExecutable_SelectedIndexChanged);
            // 
            // cmdReset
            // 
            this.cmdReset.AutoSize = true;
            this.cmdReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdReset.ImageKey = "Refresh";
            this.cmdReset.ImageList = this.imageList1;
            this.cmdReset.Location = new System.Drawing.Point(0, 1);
            this.cmdReset.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Padding = new System.Windows.Forms.Padding(1);
            this.cmdReset.Size = new System.Drawing.Size(24, 24);
            this.cmdReset.TabIndex = 6;
            this.ttGeneric.SetToolTip(this.cmdReset, "Reset all options to default");
            this.cmdReset.UseVisualStyleBackColor = true;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // cmdSelfSignedCertificate
            // 
            this.cmdSelfSignedCertificate.AutoSize = true;
            this.cmdSelfSignedCertificate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdSelfSignedCertificate.Enabled = false;
            this.cmdSelfSignedCertificate.ImageKey = "Certificate";
            this.cmdSelfSignedCertificate.ImageList = this.imageList1;
            this.cmdSelfSignedCertificate.Location = new System.Drawing.Point(6, 164);
            this.cmdSelfSignedCertificate.Margin = new System.Windows.Forms.Padding(0);
            this.cmdSelfSignedCertificate.Name = "cmdSelfSignedCertificate";
            this.cmdSelfSignedCertificate.Padding = new System.Windows.Forms.Padding(1);
            this.cmdSelfSignedCertificate.Size = new System.Drawing.Size(24, 24);
            this.cmdSelfSignedCertificate.TabIndex = 11;
            this.ttMstscAutomation.SetToolTip(this.cmdSelfSignedCertificate, "Create a self-signed certificate.");
            this.cmdSelfSignedCertificate.UseVisualStyleBackColor = true;
            this.cmdSelfSignedCertificate.Visible = false;
            this.cmdSelfSignedCertificate.Click += new System.EventHandler(this.cmdSelfSignedCertificate_Click);
            // 
            // ttTrigger
            // 
            this.ttTrigger.AutoPopDelay = 10000;
            this.ttTrigger.InitialDelay = 500;
            this.ttTrigger.ReshowDelay = 100;
            this.ttTrigger.ToolTipTitle = "Trigger";
            // 
            // grpMstscParameters
            // 
            this.grpMstscParameters.AutoSize = true;
            this.grpMstscParameters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpMstscParameters.Controls.Add(this.chkMstscUseRemoteGuard);
            this.grpMstscParameters.Controls.Add(this.chkMstscUseRestrictedAdmin);
            this.grpMstscParameters.Controls.Add(this.chkMstscUsePublic);
            this.grpMstscParameters.Controls.Add(this.chkMstscUseFullscreen);
            this.grpMstscParameters.Controls.Add(this.lblHeight);
            this.grpMstscParameters.Controls.Add(this.chkMstscUseMultimon);
            this.grpMstscParameters.Controls.Add(this.numMstscWidth);
            this.grpMstscParameters.Controls.Add(this.numMstscHeight);
            this.grpMstscParameters.Controls.Add(this.chkMstscUseSpan);
            this.grpMstscParameters.Controls.Add(this.chkMstscUseAdmin);
            this.grpMstscParameters.Controls.Add(this.lblWidth);
            this.grpMstscParameters.Location = new System.Drawing.Point(3, 3);
            this.grpMstscParameters.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.grpMstscParameters.Name = "grpMstscParameters";
            this.grpMstscParameters.Padding = new System.Windows.Forms.Padding(0);
            this.tblExecutable.SetRowSpan(this.grpMstscParameters, 2);
            this.grpMstscParameters.Size = new System.Drawing.Size(230, 228);
            this.grpMstscParameters.TabIndex = 0;
            this.grpMstscParameters.TabStop = false;
            this.grpMstscParameters.Text = "mstsc.exe parameters";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.Color.Transparent;
            this.lblHeight.Location = new System.Drawing.Point(3, 193);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(66, 13);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Height - /h:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.BackColor = System.Drawing.Color.Transparent;
            this.lblWidth.Location = new System.Drawing.Point(3, 169);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(0);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(65, 13);
            this.lblWidth.TabIndex = 4;
            this.lblWidth.Text = "Width - /w:";
            // 
            // tcKprOptionsForm
            // 
            this.tcKprOptionsForm.Controls.Add(this.tabIntegration);
            this.tcKprOptionsForm.Controls.Add(this.tabPicker);
            this.tcKprOptionsForm.Controls.Add(this.tabExecutable);
            this.tcKprOptionsForm.Controls.Add(this.tabVault);
            this.tcKprOptionsForm.Controls.Add(this.tabAbout);
            this.tcKprOptionsForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcKprOptionsForm.ImageList = this.imageList1;
            this.tcKprOptionsForm.Location = new System.Drawing.Point(3, 66);
            this.tcKprOptionsForm.Margin = new System.Windows.Forms.Padding(0);
            this.tcKprOptionsForm.Multiline = true;
            this.tcKprOptionsForm.Name = "tcKprOptionsForm";
            this.tcKprOptionsForm.Padding = new System.Drawing.Point(0, 0);
            this.tcKprOptionsForm.SelectedIndex = 0;
            this.tcKprOptionsForm.Size = new System.Drawing.Size(578, 467);
            this.tcKprOptionsForm.TabIndex = 0;
            this.tcKprOptionsForm.Visible = false;
            this.tcKprOptionsForm.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcKprOptionsForm_Selected);
            // 
            // tabIntegration
            // 
            this.tabIntegration.AutoScroll = true;
            this.tabIntegration.BackColor = System.Drawing.Color.White;
            this.tabIntegration.Controls.Add(this.tblIntegration);
            this.tabIntegration.ImageKey = "PowerShellProject";
            this.tabIntegration.Location = new System.Drawing.Point(4, 23);
            this.tabIntegration.Name = "tabIntegration";
            this.tabIntegration.Size = new System.Drawing.Size(570, 440);
            this.tabIntegration.TabIndex = 2;
            this.tabIntegration.Text = "Integration";
            this.tabIntegration.SizeChanged += new System.EventHandler(this.tabIntegration_Resize);
            this.tabIntegration.Resize += new System.EventHandler(this.tabIntegration_Resize);
            // 
            // tblIntegration
            // 
            this.tblIntegration.AutoSize = true;
            this.tblIntegration.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblIntegration.ColumnCount = 1;
            this.tblIntegration.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblIntegration.Controls.Add(this.flpOptions, 0, 0);
            this.tblIntegration.Controls.Add(this.kprSettingsControl, 0, 1);
            this.tblIntegration.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblIntegration.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tblIntegration.Location = new System.Drawing.Point(0, 0);
            this.tblIntegration.MinimumSize = new System.Drawing.Size(0, 500);
            this.tblIntegration.Name = "tblIntegration";
            this.tblIntegration.RowCount = 2;
            this.tblIntegration.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblIntegration.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblIntegration.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblIntegration.Size = new System.Drawing.Size(553, 500);
            this.tblIntegration.TabIndex = 0;
            // 
            // kprSettingsControl
            // 
            this.kprSettingsControl.AutoSize = true;
            this.kprSettingsControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kprSettingsControl.BackColor = System.Drawing.Color.White;
            this.kprSettingsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kprSettingsControl.Location = new System.Drawing.Point(0, 146);
            this.kprSettingsControl.Margin = new System.Windows.Forms.Padding(0);
            this.kprSettingsControl.Name = "kprSettingsControl";
            this.kprSettingsControl.Size = new System.Drawing.Size(553, 354);
            this.kprSettingsControl.TabIndex = 1;
            this.kprSettingsControl.Visible = false;
            // 
            // tabPicker
            // 
            this.tabPicker.BackColor = System.Drawing.Color.White;
            this.tabPicker.Controls.Add(this.tblPicker);
            this.tabPicker.ImageKey = "ModalPopup";
            this.tabPicker.Location = new System.Drawing.Point(4, 23);
            this.tabPicker.Name = "tabPicker";
            this.tabPicker.Size = new System.Drawing.Size(570, 440);
            this.tabPicker.TabIndex = 0;
            this.tabPicker.Text = "Picker";
            // 
            // tblPicker
            // 
            this.tblPicker.ColumnCount = 1;
            this.tblPicker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPicker.Controls.Add(flpCredPickerRegEx, 0, 1);
            this.tblPicker.Controls.Add(flpCredPickerOptions, 0, 0);
            this.tblPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPicker.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tblPicker.Location = new System.Drawing.Point(0, 0);
            this.tblPicker.Name = "tblPicker";
            this.tblPicker.RowCount = 3;
            this.tblPicker.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPicker.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPicker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tblPicker.Size = new System.Drawing.Size(570, 440);
            this.tblPicker.TabIndex = 0;
            this.tblPicker.Visible = false;
            // 
            // tabExecutable
            // 
            this.tabExecutable.BackColor = System.Drawing.Color.White;
            this.tabExecutable.Controls.Add(this.tblExecutable);
            this.tabExecutable.ImageKey = "RemoteDesktop";
            this.tabExecutable.Location = new System.Drawing.Point(4, 23);
            this.tabExecutable.Name = "tabExecutable";
            this.tabExecutable.Size = new System.Drawing.Size(570, 440);
            this.tabExecutable.TabIndex = 1;
            this.tabExecutable.Text = "Executable";
            // 
            // tblExecutable
            // 
            this.tblExecutable.AutoSize = true;
            this.tblExecutable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblExecutable.ColumnCount = 3;
            this.tblExecutable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblExecutable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblExecutable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tblExecutable.Controls.Add(this.chkMstscSecureDesktop, 0, 2);
            this.tblExecutable.Controls.Add(this.grpMstscParameters, 0, 0);
            this.tblExecutable.Controls.Add(this.grpMstscAutomation, 1, 0);
            this.tblExecutable.Controls.Add(this.tblMstscExecutable, 1, 1);
            this.tblExecutable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblExecutable.Location = new System.Drawing.Point(0, 0);
            this.tblExecutable.Name = "tblExecutable";
            this.tblExecutable.RowCount = 3;
            this.tblExecutable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblExecutable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblExecutable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tblExecutable.Size = new System.Drawing.Size(570, 440);
            this.tblExecutable.TabIndex = 4;
            this.tblExecutable.Visible = false;
            // 
            // grpMstscAutomation
            // 
            this.grpMstscAutomation.AutoSize = true;
            this.grpMstscAutomation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpMstscAutomation.Controls.Add(this.chkMstscHandleCredDialog);
            this.grpMstscAutomation.Controls.Add(this.chkMstscCleanupRegistry);
            this.grpMstscAutomation.Controls.Add(this.cmdSelfSignedCertificate);
            this.grpMstscAutomation.Controls.Add(this.txtMstscSignRdpFiles);
            this.grpMstscAutomation.Controls.Add(this.chkMstscSignRdpFiles);
            this.grpMstscAutomation.Controls.Add(this.chkMstscConfirmCertificate);
            this.grpMstscAutomation.Controls.Add(this.chkMstscReplaceTitle);
            this.grpMstscAutomation.Location = new System.Drawing.Point(236, 3);
            this.grpMstscAutomation.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.grpMstscAutomation.Name = "grpMstscAutomation";
            this.grpMstscAutomation.Padding = new System.Windows.Forms.Padding(0);
            this.grpMstscAutomation.Size = new System.Drawing.Size(186, 203);
            this.grpMstscAutomation.TabIndex = 1;
            this.grpMstscAutomation.TabStop = false;
            this.grpMstscAutomation.Text = "mstsc.exe automation";
            this.grpMstscAutomation.SizeChanged += new System.EventHandler(this.grpMstscAutomation_SizeChanged);
            // 
            // chkMstscHandleCredDialog
            // 
            this.chkMstscHandleCredDialog.AutoSize = true;
            this.chkMstscHandleCredDialog.BackColor = System.Drawing.Color.Transparent;
            this.chkMstscHandleCredDialog.Location = new System.Drawing.Point(6, 63);
            this.chkMstscHandleCredDialog.Margin = new System.Windows.Forms.Padding(0);
            this.chkMstscHandleCredDialog.Name = "chkMstscHandleCredDialog";
            this.chkMstscHandleCredDialog.Size = new System.Drawing.Size(158, 17);
            this.chkMstscHandleCredDialog.TabIndex = 13;
            this.chkMstscHandleCredDialog.Text = "Handle credentials dialog";
            this.ttMstscAutomation.SetToolTip(this.chkMstscHandleCredDialog, "Cleanup credentials dialog if it pops up.");
            this.chkMstscHandleCredDialog.UseVisualStyleBackColor = false;
            // 
            // chkMstscCleanupRegistry
            // 
            this.chkMstscCleanupRegistry.AutoSize = true;
            this.chkMstscCleanupRegistry.BackColor = System.Drawing.Color.Transparent;
            this.chkMstscCleanupRegistry.Location = new System.Drawing.Point(6, 42);
            this.chkMstscCleanupRegistry.Margin = new System.Windows.Forms.Padding(0);
            this.chkMstscCleanupRegistry.Name = "chkMstscCleanupRegistry";
            this.chkMstscCleanupRegistry.Size = new System.Drawing.Size(134, 17);
            this.chkMstscCleanupRegistry.TabIndex = 12;
            this.chkMstscCleanupRegistry.Text = "Cleanup registry hint";
            this.ttMstscAutomation.SetToolTip(this.chkMstscCleanupRegistry, "Remove username hint from registry before and after connecting.");
            this.chkMstscCleanupRegistry.UseVisualStyleBackColor = false;
            // 
            // txtMstscSignRdpFiles
            // 
            this.txtMstscSignRdpFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMstscSignRdpFiles.Enabled = false;
            this.txtMstscSignRdpFiles.Location = new System.Drawing.Point(6, 126);
            this.txtMstscSignRdpFiles.Margin = new System.Windows.Forms.Padding(0);
            this.txtMstscSignRdpFiles.Multiline = true;
            this.txtMstscSignRdpFiles.Name = "txtMstscSignRdpFiles";
            this.txtMstscSignRdpFiles.ReadOnly = true;
            this.txtMstscSignRdpFiles.ShortcutsEnabled = false;
            this.txtMstscSignRdpFiles.Size = new System.Drawing.Size(174, 36);
            this.txtMstscSignRdpFiles.TabIndex = 10;
            this.txtMstscSignRdpFiles.Text = "Click here to select a certificate from the user store.";
            this.txtMstscSignRdpFiles.Visible = false;
            this.txtMstscSignRdpFiles.Click += new System.EventHandler(this.txtMstscSignRdpFiles_Click);
            this.txtMstscSignRdpFiles.TextChanged += new System.EventHandler(this.txtMstscSignRdpFiles_TextChanged);
            this.txtMstscSignRdpFiles.Enter += new System.EventHandler(this.txtMstscSignRdpFiles_Enter);
            this.txtMstscSignRdpFiles.Leave += new System.EventHandler(this.txtMstscSignRdpFiles_Leave);
            this.txtMstscSignRdpFiles.MouseEnter += new System.EventHandler(this.txtMstscSignRdpFiles_MouseEnter);
            this.txtMstscSignRdpFiles.MouseLeave += new System.EventHandler(this.txtMstscSignRdpFiles_MouseLeave);
            this.txtMstscSignRdpFiles.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtMstscSignRdpFiles_MouseMove);
            // 
            // chkMstscSignRdpFiles
            // 
            this.chkMstscSignRdpFiles.AutoSize = true;
            this.chkMstscSignRdpFiles.BackColor = System.Drawing.Color.Transparent;
            this.chkMstscSignRdpFiles.Location = new System.Drawing.Point(6, 105);
            this.chkMstscSignRdpFiles.Margin = new System.Windows.Forms.Padding(0);
            this.chkMstscSignRdpFiles.Name = "chkMstscSignRdpFiles";
            this.chkMstscSignRdpFiles.Size = new System.Drawing.Size(97, 17);
            this.chkMstscSignRdpFiles.TabIndex = 9;
            this.chkMstscSignRdpFiles.Text = "Sign .rdp files";
            this.ttMstscAutomation.SetToolTip(this.chkMstscSignRdpFiles, "Use certificate from store to sign .rdp files.");
            this.chkMstscSignRdpFiles.UseVisualStyleBackColor = false;
            this.chkMstscSignRdpFiles.CheckedChanged += new System.EventHandler(this.chkMstscSignRdpFiles_CheckedChanged);
            // 
            // tblMstscExecutable
            // 
            this.tblMstscExecutable.AutoSize = true;
            this.tblMstscExecutable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblMstscExecutable.ColumnCount = 1;
            this.tblMstscExecutable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMstscExecutable.Controls.Add(this.flpMstscExecutable, 0, 0);
            this.tblMstscExecutable.Controls.Add(this.txtMstscCustomCommand, 0, 1);
            this.tblMstscExecutable.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblMstscExecutable.Location = new System.Drawing.Point(233, 206);
            this.tblMstscExecutable.Margin = new System.Windows.Forms.Padding(0);
            this.tblMstscExecutable.Name = "tblMstscExecutable";
            this.tblMstscExecutable.RowCount = 2;
            this.tblMstscExecutable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMstscExecutable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMstscExecutable.Size = new System.Drawing.Size(192, 45);
            this.tblMstscExecutable.TabIndex = 4;
            // 
            // flpMstscExecutable
            // 
            this.flpMstscExecutable.AutoSize = true;
            this.flpMstscExecutable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpMstscExecutable.Controls.Add(this.lblMstscExecutable);
            this.flpMstscExecutable.Controls.Add(this.cbMstscExecutable);
            this.flpMstscExecutable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMstscExecutable.Location = new System.Drawing.Point(0, 2);
            this.flpMstscExecutable.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.flpMstscExecutable.Name = "flpMstscExecutable";
            this.flpMstscExecutable.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.flpMstscExecutable.Size = new System.Drawing.Size(192, 23);
            this.flpMstscExecutable.TabIndex = 2;
            // 
            // lblMstscExecutable
            // 
            this.lblMstscExecutable.AutoSize = true;
            this.lblMstscExecutable.Location = new System.Drawing.Point(0, 4);
            this.lblMstscExecutable.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblMstscExecutable.Name = "lblMstscExecutable";
            this.lblMstscExecutable.Size = new System.Drawing.Size(62, 13);
            this.lblMstscExecutable.TabIndex = 0;
            this.lblMstscExecutable.Text = "Executable";
            this.lblMstscExecutable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMstscCustomCommand
            // 
            this.txtMstscCustomCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMstscCustomCommand.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMstscCustomCommand.Location = new System.Drawing.Point(3, 26);
            this.txtMstscCustomCommand.Margin = new System.Windows.Forms.Padding(3, 1, 0, 0);
            this.txtMstscCustomCommand.Name = "txtMstscCustomCommand";
            this.txtMstscCustomCommand.Size = new System.Drawing.Size(189, 19);
            this.txtMstscCustomCommand.TabIndex = 3;
            this.txtMstscCustomCommand.Visible = false;
            this.txtMstscCustomCommand.WordWrap = false;
            this.txtMstscCustomCommand.VisibleChanged += new System.EventHandler(this.txtMstscCustomCommand_VisibleChanged);
            this.txtMstscCustomCommand.Enter += new System.EventHandler(this.txtMstscCustomCommand_Enter);
            this.txtMstscCustomCommand.Leave += new System.EventHandler(this.txtMstscCustomCommand_Leave);
            this.txtMstscCustomCommand.MouseEnter += new System.EventHandler(this.txtMstscCustomCommand_MouseEnter);
            this.txtMstscCustomCommand.MouseLeave += new System.EventHandler(this.txtMstscCustomCommand_MouseLeave);
            this.txtMstscCustomCommand.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtMstscCustomCommand_MouseMove);
            // 
            // tabVault
            // 
            this.tabVault.BackColor = System.Drawing.Color.White;
            this.tabVault.Controls.Add(this.tblVault);
            this.tabVault.ImageKey = "KeyVault";
            this.tabVault.Location = new System.Drawing.Point(4, 23);
            this.tabVault.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabVault.Name = "tabVault";
            this.tabVault.Size = new System.Drawing.Size(570, 440);
            this.tabVault.TabIndex = 3;
            this.tabVault.Text = "Vault";
            // 
            // tblVault
            // 
            this.tblVault.ColumnCount = 1;
            this.tblVault.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblVault.Controls.Add(this.lvVault, 0, 1);
            this.tblVault.Controls.Add(flpSavedCredentials, 0, 0);
            this.tblVault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblVault.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tblVault.Location = new System.Drawing.Point(0, 0);
            this.tblVault.Margin = new System.Windows.Forms.Padding(0);
            this.tblVault.Name = "tblVault";
            this.tblVault.RowCount = 2;
            this.tblVault.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblVault.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblVault.Size = new System.Drawing.Size(570, 440);
            this.tblVault.TabIndex = 1;
            this.tblVault.Visible = false;
            // 
            // lvVault
            // 
            this.lvVault.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvVault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvVault.FullRowSelect = true;
            this.lvVault.GridLines = true;
            this.lvVault.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvVault.HideSelection = false;
            this.lvVault.Location = new System.Drawing.Point(0, 23);
            this.lvVault.Margin = new System.Windows.Forms.Padding(0);
            this.lvVault.MultiSelect = false;
            this.lvVault.Name = "lvVault";
            this.lvVault.OwnerDraw = true;
            this.lvVault.Size = new System.Drawing.Size(570, 417);
            this.lvVault.TabIndex = 1;
            this.lvVault.UseCompatibleStateImageBehavior = false;
            this.lvVault.View = System.Windows.Forms.View.Details;
            this.lvVault.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.lvVault_ColumnWidthChanged);
            this.lvVault.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvVault_DrawColumnHeader);
            this.lvVault.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lvVault_DrawItem);
            this.lvVault.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvVault_DrawSubItem);
            this.lvVault.SizeChanged += new System.EventHandler(this.lvVault_SizeChanged);
            this.lvVault.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lvVault_MouseMove);
            // 
            // tabAbout
            // 
            this.tabAbout.BackColor = System.Drawing.Color.White;
            this.tabAbout.Controls.Add(this.tblAbout);
            this.tabAbout.ImageKey = "StatusHelpOutline";
            this.tabAbout.Location = new System.Drawing.Point(4, 23);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(570, 440);
            this.tabAbout.TabIndex = 4;
            this.tabAbout.Text = "About";
            this.tabAbout.SizeChanged += new System.EventHandler(this.tabAbout_SizeChanged);
            // 
            // tblAbout
            // 
            this.tblAbout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblAbout.AutoSize = true;
            this.tblAbout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblAbout.ColumnCount = 3;
            this.tblAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tblAbout.Controls.Add(this.lblRevisionText, 1, 3);
            this.tblAbout.Controls.Add(this.pbAbout, 0, 0);
            this.tblAbout.Controls.Add(pnlAboutLinks, 0, 4);
            this.tblAbout.Controls.Add(lblRevision, 0, 3);
            this.tblAbout.Controls.Add(this.lblVersionText, 1, 2);
            this.tblAbout.Controls.Add(lblVersion, 0, 2);
            this.tblAbout.Controls.Add(lblKeePassRDP, 0, 1);
            this.tblAbout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tblAbout.Location = new System.Drawing.Point(-1548, -1797);
            this.tblAbout.Name = "tblAbout";
            this.tblAbout.RowCount = 6;
            this.tblAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tblAbout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblAbout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblAbout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblAbout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tblAbout.Size = new System.Drawing.Size(257, 380);
            this.tblAbout.TabIndex = 2;
            this.tblAbout.SizeChanged += new System.EventHandler(this.tblAbout_SizeChanged);
            // 
            // lblRevisionText
            // 
            this.lblRevisionText.AutoSize = true;
            this.lblRevisionText.BackColor = System.Drawing.Color.Transparent;
            this.lblRevisionText.Location = new System.Drawing.Point(62, 314);
            this.lblRevisionText.Margin = new System.Windows.Forms.Padding(3);
            this.lblRevisionText.Name = "lblRevisionText";
            this.lblRevisionText.Size = new System.Drawing.Size(70, 13);
            this.lblRevisionText.TabIndex = 6;
            this.lblRevisionText.Text = "RevisionText";
            // 
            // pbAbout
            // 
            this.tblAbout.SetColumnSpan(this.pbAbout, 2);
            this.pbAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAbout.Location = new System.Drawing.Point(0, 0);
            this.pbAbout.Margin = new System.Windows.Forms.Padding(0);
            this.pbAbout.Name = "pbAbout";
            this.pbAbout.Size = new System.Drawing.Size(256, 256);
            this.pbAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAbout.TabIndex = 8;
            this.pbAbout.TabStop = false;
            // 
            // lblVersionText
            // 
            this.lblVersionText.AutoSize = true;
            this.lblVersionText.BackColor = System.Drawing.Color.Transparent;
            this.lblVersionText.Location = new System.Drawing.Point(62, 295);
            this.lblVersionText.Margin = new System.Windows.Forms.Padding(3);
            this.lblVersionText.Name = "lblVersionText";
            this.lblVersionText.Size = new System.Drawing.Size(65, 13);
            this.lblVersionText.TabIndex = 5;
            this.lblVersionText.Text = "VersionText";
            // 
            // tblKprOptionsForm
            // 
            this.tblKprOptionsForm.ColumnCount = 1;
            this.tblKprOptionsForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblKprOptionsForm.Controls.Add(this.tcKprOptionsForm, 0, 1);
            this.tblKprOptionsForm.Controls.Add(this.pbKprOptionsForm, 0, 0);
            this.tblKprOptionsForm.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tblKprOptionsForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblKprOptionsForm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblKprOptionsForm.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tblKprOptionsForm.Location = new System.Drawing.Point(0, 0);
            this.tblKprOptionsForm.Name = "tblKprOptionsForm";
            this.tblKprOptionsForm.Padding = new System.Windows.Forms.Padding(3);
            this.tblKprOptionsForm.RowCount = 3;
            this.tblKprOptionsForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tblKprOptionsForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblKprOptionsForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblKprOptionsForm.Size = new System.Drawing.Size(584, 561);
            this.tblKprOptionsForm.TabIndex = 0;
            // 
            // pbKprOptionsForm
            // 
            this.pbKprOptionsForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbKprOptionsForm.Location = new System.Drawing.Point(3, 3);
            this.pbKprOptionsForm.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pbKprOptionsForm.Name = "pbKprOptionsForm";
            this.pbKprOptionsForm.Size = new System.Drawing.Size(578, 60);
            this.pbKprOptionsForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbKprOptionsForm.TabIndex = 5;
            this.pbKprOptionsForm.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cmdReset, 0, 0);
            this.tableLayoutPanel1.Controls.Add(flpCommandButtons, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 533);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(578, 25);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // ttMstscAutomation
            // 
            this.ttMstscAutomation.AutoPopDelay = 10000;
            this.ttMstscAutomation.InitialDelay = 500;
            this.ttMstscAutomation.ReshowDelay = 100;
            this.ttMstscAutomation.ToolTipTitle = "mstsc.exe automation";
            // 
            // KprOptionsForm
            // 
            this.AcceptButton = this.cmdOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.tblKprOptionsForm);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 900);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 445);
            this.Name = "KprOptionsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KeePassRDP Options";
            this.Activated += new System.EventHandler(this.KprOptionsForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KprOptionsForm_FormClosed);
            this.Load += new System.EventHandler(this.KprOptionsForm_Load);
            this.Shown += new System.EventHandler(this.KprOptionsForm_Shown);
            this.ResizeBegin += new System.EventHandler(this.KprOptionsForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.KprOptionsForm_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.KprOptionsForm_SizeChanged);
            flpCredVaultTtl.ResumeLayout(false);
            flpCredVaultTtl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCredVaultTtl)).EndInit();
            flpSavedCredentials.ResumeLayout(false);
            flpSavedCredentials.PerformLayout();
            pnlCredPickerRegExPrefixes.ResumeLayout(false);
            pnlCredPickerRegExPrefixes.PerformLayout();
            flpCredPickerRegEx.ResumeLayout(false);
            flpCredPickerRegEx.PerformLayout();
            pnlCredPickerRegExPostfixes.ResumeLayout(false);
            pnlCredPickerRegExPostfixes.PerformLayout();
            flpCredPickerOptions.ResumeLayout(false);
            flpCredPickerOptions.PerformLayout();
            this.grpCredPickerGeneralOptions.ResumeLayout(false);
            this.grpCredPickerGeneralOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCredPickWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCredPickHeight)).EndInit();
            this.grpCredPickerEntryOptions.ResumeLayout(false);
            this.grpCredPickerEntryOptions.PerformLayout();
            this.grpCredPickerTriggerOptions.ResumeLayout(false);
            this.grpCredPickerTriggerOptions.PerformLayout();
            pnlAboutLinks.ResumeLayout(false);
            pnlAboutLinks.PerformLayout();
            flpCommandButtons.ResumeLayout(false);
            flpCommandButtons.PerformLayout();
            this.flpOptions.ResumeLayout(false);
            this.flpOptions.PerformLayout();
            this.grpCredentialOptions.ResumeLayout(false);
            this.grpCredentialOptions.PerformLayout();
            this.grpEntryOptions.ResumeLayout(false);
            this.grpEntryOptions.PerformLayout();
            this.grpHotkeyOptions.ResumeLayout(false);
            this.grpHotkeyOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMstscHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMstscWidth)).EndInit();
            this.grpMstscParameters.ResumeLayout(false);
            this.grpMstscParameters.PerformLayout();
            this.tcKprOptionsForm.ResumeLayout(false);
            this.tabIntegration.ResumeLayout(false);
            this.tabIntegration.PerformLayout();
            this.tblIntegration.ResumeLayout(false);
            this.tblIntegration.PerformLayout();
            this.tabPicker.ResumeLayout(false);
            this.tblPicker.ResumeLayout(false);
            this.tblPicker.PerformLayout();
            this.tabExecutable.ResumeLayout(false);
            this.tabExecutable.PerformLayout();
            this.tblExecutable.ResumeLayout(false);
            this.tblExecutable.PerformLayout();
            this.grpMstscAutomation.ResumeLayout(false);
            this.grpMstscAutomation.PerformLayout();
            this.tblMstscExecutable.ResumeLayout(false);
            this.tblMstscExecutable.PerformLayout();
            this.flpMstscExecutable.ResumeLayout(false);
            this.flpMstscExecutable.PerformLayout();
            this.tabVault.ResumeLayout(false);
            this.tblVault.ResumeLayout(false);
            this.tblVault.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.tblAbout.ResumeLayout(false);
            this.tblAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).EndInit();
            this.tblKprOptionsForm.ResumeLayout(false);
            this.tblKprOptionsForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKprOptionsForm)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox chkMstscUseFullscreen;
        private System.Windows.Forms.CheckBox chkMstscUseMultimon;
        private System.Windows.Forms.CheckBox chkMstscUseSpan;
        private System.Windows.Forms.CheckBox chkMstscUseAdmin;
        private System.Windows.Forms.NumericUpDown numMstscHeight;
        private System.Windows.Forms.NumericUpDown numMstscWidth;
        private System.Windows.Forms.CheckBox chkKeepassShowResolvedReferences;
        private System.Windows.Forms.CheckBox chkCredVaultUseWindows;
        private System.Windows.Forms.NumericUpDown numCredPickHeight;
        private System.Windows.Forms.NumericUpDown numCredPickWidth;
        private System.Windows.Forms.CheckBox chkCredPickRememberSize;
        private System.Windows.Forms.NumericUpDown numCredVaultTtl;
        private System.Windows.Forms.TabControl tcKprOptionsForm;
        private System.Windows.Forms.TabPage tabPicker;
        private System.Windows.Forms.TabPage tabExecutable;
        private System.Windows.Forms.TabPage tabIntegration;
        private System.Windows.Forms.Button cmdRegExPostRemove;
        private System.Windows.Forms.Button cmdRegExPostAdd;
        private System.Windows.Forms.TextBox txtRegExPost;
        private System.Windows.Forms.ListBox lstRegExPost;
        private System.Windows.Forms.Button cmdRegExPreRemove;
        private System.Windows.Forms.Button cmdRegExPreAdd;
        private System.Windows.Forms.TextBox txtRegExPre;
        private System.Windows.Forms.ListBox lstRegExPre;
        private System.Windows.Forms.Button cmdRegExPostReset;
        private System.Windows.Forms.Button cmdRegExPreReset;
        private System.Windows.Forms.TabPage tabVault;
        private System.Windows.Forms.ListView lvVault;
        private System.Windows.Forms.CheckBox chkCredPickLargeRows;
        private System.Windows.Forms.CheckBox chkSavedCredsShowAll;
        private System.Windows.Forms.CheckBox chkCredVaultOverwriteExisting;
        private System.Windows.Forms.Button cmdRefreshCredentials;
        private System.Windows.Forms.CheckBox chkKeePassConnectToAll;
        private System.Windows.Forms.CheckBox chkCredVaultRemoveOnExit;
        private System.Windows.Forms.CheckBox chkKeePassHotkeysRegisterLast;
        private System.Windows.Forms.CheckBox chkCredVaultAdaptiveTtl;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TableLayoutPanel tblIntegration;
        private System.Windows.Forms.TableLayoutPanel tblVault;
        private System.Windows.Forms.TableLayoutPanel tblKprOptionsForm;
        private System.Windows.Forms.TableLayoutPanel tblPicker;
        private System.Windows.Forms.CheckBox chkCredPickShowInGroups;
        private System.Windows.Forms.CheckBox chkCredPickIncludeSelected;
        private System.Windows.Forms.ImageList imageList1;
        private KprImageList kprImageList;
        private System.Windows.Forms.TextBox txtCredPickerCustomGroup;
        private System.Windows.Forms.CheckBox chkCredPickRememberSortOrder;
        private System.Windows.Forms.PictureBox pbKprOptionsForm;
        private System.Windows.Forms.GroupBox grpMstscParameters;
        private KprToolTip ttTrigger;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Label lblRevisionText;
        private System.Windows.Forms.Label lblVersionText;
        private System.Windows.Forms.TableLayoutPanel tblAbout;
        private KprPictureBox pbAbout;
        private KprToolTip ttGeneric;
        private KprToolTip ttCredentials;
        private KprToolTip ttEntries;
        private KprToolTip ttUI;
        private KprToolTip ttMstscParameters;
        private KprToolTip ttGeneral;
        private System.Windows.Forms.GroupBox grpCredentialOptions;
        private System.Windows.Forms.GroupBox grpEntryOptions;
        private System.Windows.Forms.GroupBox grpHotkeyOptions;
        private System.Windows.Forms.GroupBox grpCredPickerGeneralOptions;
        private System.Windows.Forms.GroupBox grpCredPickerEntryOptions;
        private System.Windows.Forms.GroupBox grpCredPickerTriggerOptions;
        private System.Windows.Forms.LinkLabel llLicense;
        private System.Windows.Forms.LinkLabel llWebsite;
        private System.Windows.Forms.Label lblCredPickHeight;
        private System.Windows.Forms.Label lblCredPickWidth;
        private System.Windows.Forms.Label lblCredVaultTtl;
        private System.Windows.Forms.Label lblCredPickerCustomGroup;
        private System.Windows.Forms.Label lblRegexPostfixes;
        private System.Windows.Forms.Label lblRegexPrefixes;
        private System.Windows.Forms.CheckBox chkMstscUsePublic;
        private System.Windows.Forms.CheckBox chkMstscUseRemoteGuard;
        private System.Windows.Forms.CheckBox chkMstscUseRestrictedAdmin;
        private System.Windows.Forms.GroupBox grpMstscAutomation;
        private System.Windows.Forms.CheckBox chkMstscConfirmCertificate;
        private System.Windows.Forms.CheckBox chkMstscReplaceTitle;
        private KprToolTip ttMstscAutomation;
        private System.Windows.Forms.CheckBox chkKeePassAlwaysConfirm;
        private System.Windows.Forms.CheckBox chkKeePassContextMenuOnScreen;
        private System.Windows.Forms.TextBox txtMstscSignRdpFiles;
        private System.Windows.Forms.CheckBox chkMstscSignRdpFiles;
        private System.Windows.Forms.Button cmdSelfSignedCertificate;
        private System.Windows.Forms.ComboBox cbMstscExecutable;
        private System.Windows.Forms.Label lblMstscExecutable;
        private System.Windows.Forms.TableLayoutPanel tblExecutable;
        private System.Windows.Forms.FlowLayoutPanel flpMstscExecutable;
        private System.Windows.Forms.CheckBox chkKeePassConfirmOnClose;
        private System.Windows.Forms.CheckBox chkMstscCleanupRegistry;
        private System.Windows.Forms.CheckBox chkCredPickSecureDesktop;
        private System.Windows.Forms.CheckBox chkMstscSecureDesktop;
        private System.Windows.Forms.TableLayoutPanel tblMstscExecutable;
        private System.Windows.Forms.TextBox txtMstscCustomCommand;
        private System.Windows.Forms.FlowLayoutPanel flpOptions;
        private KprSettingsControl kprSettingsControl;
        private System.Windows.Forms.CheckBox chkCredPickerTriggerRecursive;
        private System.Windows.Forms.CheckBox chkKeePassDefaultEntryAction;
        private System.Windows.Forms.CheckBox chkMstscHandleCredDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Button cmdCancel;
    }
}