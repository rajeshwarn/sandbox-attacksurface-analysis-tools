﻿namespace TokenViewer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabPage tabPageGeneral;
            System.Windows.Forms.GroupBox groupBoxLogonUser;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.TabPage tabPageServices;
            System.Windows.Forms.GroupBox groupBoxAnonymous;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.GroupBox groupBoxFromBits;
            System.Windows.Forms.Label label4;
            this.groupBoxServiceAccounts = new System.Windows.Forms.GroupBox();
            this.btnCreateSystem = new System.Windows.Forms.Button();
            this.btnCreateNetworkService = new System.Windows.Forms.Button();
            this.btnCreateLocalService = new System.Windows.Forms.Button();
            this.radioLUS4U = new System.Windows.Forms.RadioButton();
            this.radioLUNormal = new System.Windows.Forms.RadioButton();
            this.txtLUPassword = new System.Windows.Forms.TextBox();
            this.comboBoxS4ULogonType = new System.Windows.Forms.ComboBox();
            this.btnCreteS4U = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtS4URealm = new System.Windows.Forms.TextBox();
            this.txtS4UUserName = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.btnCreateAnonymous = new System.Windows.Forms.Button();
            this.btnClipboardToken = new System.Windows.Forms.Button();
            this.btnPipeConnect = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.txtPipeName = new System.Windows.Forms.TextBox();
            this.btnCreateFromBits = new System.Windows.Forms.Button();
            this.tabControlTests = new System.Windows.Forms.TabControl();
            this.tabPageProcesses = new System.Windows.Forms.TabPage();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.checkBoxUnrestricted = new System.Windows.Forms.CheckBox();
            this.btnCurrentProcess = new System.Windows.Forms.Button();
            this.treeViewProcesses = new System.Windows.Forms.TreeView();
            this.contextMenuStripProcesses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshTokenHandlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tabPageGeneral = new System.Windows.Forms.TabPage();
            groupBoxLogonUser = new System.Windows.Forms.GroupBox();
            label6 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tabPageServices = new System.Windows.Forms.TabPage();
            groupBoxAnonymous = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            groupBoxFromBits = new System.Windows.Forms.GroupBox();
            label4 = new System.Windows.Forms.Label();
            tabPageGeneral.SuspendLayout();
            this.groupBoxServiceAccounts.SuspendLayout();
            groupBoxLogonUser.SuspendLayout();
            tabPageServices.SuspendLayout();
            groupBoxAnonymous.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxFromBits.SuspendLayout();
            this.tabControlTests.SuspendLayout();
            this.tabPageProcesses.SuspendLayout();
            this.contextMenuStripProcesses.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageGeneral
            // 
            tabPageGeneral.Controls.Add(this.groupBoxServiceAccounts);
            tabPageGeneral.Controls.Add(groupBoxLogonUser);
            tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            tabPageGeneral.Name = "tabPageGeneral";
            tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            tabPageGeneral.Size = new System.Drawing.Size(600, 397);
            tabPageGeneral.TabIndex = 3;
            tabPageGeneral.Text = "Logon User";
            tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBoxServiceAccounts
            // 
            this.groupBoxServiceAccounts.Controls.Add(this.btnCreateSystem);
            this.groupBoxServiceAccounts.Controls.Add(this.btnCreateNetworkService);
            this.groupBoxServiceAccounts.Controls.Add(this.btnCreateLocalService);
            this.groupBoxServiceAccounts.Location = new System.Drawing.Point(6, 195);
            this.groupBoxServiceAccounts.Name = "groupBoxServiceAccounts";
            this.groupBoxServiceAccounts.Size = new System.Drawing.Size(308, 51);
            this.groupBoxServiceAccounts.TabIndex = 2;
            this.groupBoxServiceAccounts.TabStop = false;
            this.groupBoxServiceAccounts.Text = "Service Accounts";
            // 
            // btnCreateSystem
            // 
            this.btnCreateSystem.Location = new System.Drawing.Point(221, 19);
            this.btnCreateSystem.Name = "btnCreateSystem";
            this.btnCreateSystem.Size = new System.Drawing.Size(75, 23);
            this.btnCreateSystem.TabIndex = 13;
            this.btnCreateSystem.Text = "System";
            this.btnCreateSystem.UseVisualStyleBackColor = true;
            this.btnCreateSystem.Click += new System.EventHandler(this.btnCreateSystem_Click);
            // 
            // btnCreateNetworkService
            // 
            this.btnCreateNetworkService.Location = new System.Drawing.Point(112, 19);
            this.btnCreateNetworkService.Name = "btnCreateNetworkService";
            this.btnCreateNetworkService.Size = new System.Drawing.Size(103, 23);
            this.btnCreateNetworkService.TabIndex = 12;
            this.btnCreateNetworkService.Text = "Network Service";
            this.btnCreateNetworkService.UseVisualStyleBackColor = true;
            this.btnCreateNetworkService.Click += new System.EventHandler(this.btnCreateNetworkService_Click);
            // 
            // btnCreateLocalService
            // 
            this.btnCreateLocalService.Location = new System.Drawing.Point(14, 19);
            this.btnCreateLocalService.Name = "btnCreateLocalService";
            this.btnCreateLocalService.Size = new System.Drawing.Size(92, 23);
            this.btnCreateLocalService.TabIndex = 11;
            this.btnCreateLocalService.Text = "Local Service";
            this.btnCreateLocalService.UseVisualStyleBackColor = true;
            this.btnCreateLocalService.Click += new System.EventHandler(this.btnCreateLocalService_Click);
            // 
            // groupBoxLogonUser
            // 
            groupBoxLogonUser.Controls.Add(this.radioLUS4U);
            groupBoxLogonUser.Controls.Add(this.radioLUNormal);
            groupBoxLogonUser.Controls.Add(this.txtLUPassword);
            groupBoxLogonUser.Controls.Add(label6);
            groupBoxLogonUser.Controls.Add(this.comboBoxS4ULogonType);
            groupBoxLogonUser.Controls.Add(label2);
            groupBoxLogonUser.Controls.Add(this.btnCreteS4U);
            groupBoxLogonUser.Controls.Add(this.label1);
            groupBoxLogonUser.Controls.Add(this.txtS4URealm);
            groupBoxLogonUser.Controls.Add(this.txtS4UUserName);
            groupBoxLogonUser.Controls.Add(this.labelUsername);
            groupBoxLogonUser.Location = new System.Drawing.Point(6, 6);
            groupBoxLogonUser.Name = "groupBoxLogonUser";
            groupBoxLogonUser.Size = new System.Drawing.Size(308, 183);
            groupBoxLogonUser.TabIndex = 0;
            groupBoxLogonUser.TabStop = false;
            groupBoxLogonUser.Text = "Logon User";
            // 
            // radioLUS4U
            // 
            this.radioLUS4U.AutoSize = true;
            this.radioLUS4U.Location = new System.Drawing.Point(90, 19);
            this.radioLUS4U.Name = "radioLUS4U";
            this.radioLUS4U.Size = new System.Drawing.Size(105, 17);
            this.radioLUS4U.TabIndex = 17;
            this.radioLUS4U.Text = "Services 4 Users";
            this.radioLUS4U.UseVisualStyleBackColor = true;
            this.radioLUS4U.CheckedChanged += new System.EventHandler(this.radioLUS4U_CheckedChanged);
            // 
            // radioLUNormal
            // 
            this.radioLUNormal.AutoSize = true;
            this.radioLUNormal.Checked = true;
            this.radioLUNormal.Location = new System.Drawing.Point(16, 19);
            this.radioLUNormal.Name = "radioLUNormal";
            this.radioLUNormal.Size = new System.Drawing.Size(58, 17);
            this.radioLUNormal.TabIndex = 16;
            this.radioLUNormal.TabStop = true;
            this.radioLUNormal.Text = "Normal";
            this.radioLUNormal.UseVisualStyleBackColor = true;
            // 
            // txtLUPassword
            // 
            this.txtLUPassword.Location = new System.Drawing.Point(90, 98);
            this.txtLUPassword.Name = "txtLUPassword";
            this.txtLUPassword.Size = new System.Drawing.Size(195, 20);
            this.txtLUPassword.TabIndex = 15;
            this.txtLUPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(13, 99);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(56, 13);
            label6.TabIndex = 14;
            label6.Text = "Password:";
            // 
            // comboBoxS4ULogonType
            // 
            this.comboBoxS4ULogonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxS4ULogonType.FormattingEnabled = true;
            this.comboBoxS4ULogonType.Location = new System.Drawing.Point(90, 124);
            this.comboBoxS4ULogonType.Name = "comboBoxS4ULogonType";
            this.comboBoxS4ULogonType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxS4ULogonType.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 127);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 13);
            label2.TabIndex = 10;
            label2.Text = "Logon Type:";
            // 
            // btnCreteS4U
            // 
            this.btnCreteS4U.Location = new System.Drawing.Point(16, 151);
            this.btnCreteS4U.Name = "btnCreteS4U";
            this.btnCreteS4U.Size = new System.Drawing.Size(75, 23);
            this.btnCreteS4U.TabIndex = 9;
            this.btnCreteS4U.Text = "Create";
            this.btnCreteS4U.UseVisualStyleBackColor = true;
            this.btnCreteS4U.Click += new System.EventHandler(this.btnTestS4U_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Domain:";
            // 
            // txtS4URealm
            // 
            this.txtS4URealm.Location = new System.Drawing.Point(90, 72);
            this.txtS4URealm.Name = "txtS4URealm";
            this.txtS4URealm.Size = new System.Drawing.Size(195, 20);
            this.txtS4URealm.TabIndex = 7;
            // 
            // txtS4UUserName
            // 
            this.txtS4UUserName.Location = new System.Drawing.Point(90, 45);
            this.txtS4UUserName.Name = "txtS4UUserName";
            this.txtS4UUserName.Size = new System.Drawing.Size(195, 20);
            this.txtS4UUserName.TabIndex = 6;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(13, 48);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "Username:";
            // 
            // tabPageServices
            // 
            tabPageServices.Controls.Add(groupBoxAnonymous);
            tabPageServices.Controls.Add(groupBox2);
            tabPageServices.Controls.Add(groupBox1);
            tabPageServices.Controls.Add(groupBoxFromBits);
            tabPageServices.Location = new System.Drawing.Point(4, 22);
            tabPageServices.Name = "tabPageServices";
            tabPageServices.Padding = new System.Windows.Forms.Padding(3);
            tabPageServices.Size = new System.Drawing.Size(600, 397);
            tabPageServices.TabIndex = 4;
            tabPageServices.Text = "Services";
            tabPageServices.UseVisualStyleBackColor = true;
            // 
            // groupBoxAnonymous
            // 
            groupBoxAnonymous.Controls.Add(this.btnCreateAnonymous);
            groupBoxAnonymous.Location = new System.Drawing.Point(8, 229);
            groupBoxAnonymous.Name = "groupBoxAnonymous";
            groupBoxAnonymous.Size = new System.Drawing.Size(296, 53);
            groupBoxAnonymous.TabIndex = 3;
            groupBoxAnonymous.TabStop = false;
            groupBoxAnonymous.Text = "Anonymous Token";
            // 
            // btnCreateAnonymous
            // 
            this.btnCreateAnonymous.Location = new System.Drawing.Point(6, 19);
            this.btnCreateAnonymous.Name = "btnCreateAnonymous";
            this.btnCreateAnonymous.Size = new System.Drawing.Size(75, 23);
            this.btnCreateAnonymous.TabIndex = 10;
            this.btnCreateAnonymous.Text = "Create";
            this.btnCreateAnonymous.UseVisualStyleBackColor = true;
            this.btnCreateAnonymous.Click += new System.EventHandler(this.btnCreateAnonymous_Click);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.btnClipboardToken);
            groupBox2.Location = new System.Drawing.Point(8, 170);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(296, 53);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Win32 Clipboard Token";
            // 
            // btnClipboardToken
            // 
            this.btnClipboardToken.Location = new System.Drawing.Point(6, 19);
            this.btnClipboardToken.Name = "btnClipboardToken";
            this.btnClipboardToken.Size = new System.Drawing.Size(75, 23);
            this.btnClipboardToken.TabIndex = 2;
            this.btnClipboardToken.Text = "Create";
            this.btnClipboardToken.UseVisualStyleBackColor = true;
            this.btnClipboardToken.Click += new System.EventHandler(this.btnClipboardToken_Click);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.btnPipeConnect);
            groupBox1.Controls.Add(this.btnStartServer);
            groupBox1.Controls.Add(this.txtPipeName);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new System.Drawing.Point(8, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(296, 97);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Named Pipe";
            // 
            // btnPipeConnect
            // 
            this.btnPipeConnect.Location = new System.Drawing.Point(109, 62);
            this.btnPipeConnect.Name = "btnPipeConnect";
            this.btnPipeConnect.Size = new System.Drawing.Size(75, 23);
            this.btnPipeConnect.TabIndex = 10;
            this.btnPipeConnect.Text = "Connect";
            this.btnPipeConnect.UseVisualStyleBackColor = true;
            this.btnPipeConnect.Click += new System.EventHandler(this.btnPipeConnect_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(6, 62);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(75, 23);
            this.btnStartServer.TabIndex = 9;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // txtPipeName
            // 
            this.txtPipeName.Location = new System.Drawing.Point(83, 23);
            this.txtPipeName.Name = "txtPipeName";
            this.txtPipeName.Size = new System.Drawing.Size(195, 20);
            this.txtPipeName.TabIndex = 8;
            this.txtPipeName.Text = "dummypipe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 26);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 13);
            label3.TabIndex = 7;
            label3.Text = "Pipe Name:";
            // 
            // groupBoxFromBits
            // 
            groupBoxFromBits.Controls.Add(this.btnCreateFromBits);
            groupBoxFromBits.Location = new System.Drawing.Point(8, 6);
            groupBoxFromBits.Name = "groupBoxFromBits";
            groupBoxFromBits.Size = new System.Drawing.Size(296, 55);
            groupBoxFromBits.TabIndex = 0;
            groupBoxFromBits.TabStop = false;
            groupBoxFromBits.Text = "Token from BITS";
            // 
            // btnCreateFromBits
            // 
            this.btnCreateFromBits.Location = new System.Drawing.Point(6, 19);
            this.btnCreateFromBits.Name = "btnCreateFromBits";
            this.btnCreateFromBits.Size = new System.Drawing.Size(75, 23);
            this.btnCreateFromBits.TabIndex = 1;
            this.btnCreateFromBits.Text = "Create";
            this.btnCreateFromBits.UseVisualStyleBackColor = true;
            this.btnCreateFromBits.Click += new System.EventHandler(this.btnCreateFromBits_Click);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(109, 11);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 13);
            label4.TabIndex = 3;
            label4.Text = "Name Filter:";
            // 
            // tabControlTests
            // 
            this.tabControlTests.Controls.Add(this.tabPageProcesses);
            this.tabControlTests.Controls.Add(tabPageGeneral);
            this.tabControlTests.Controls.Add(tabPageServices);
            this.tabControlTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTests.Location = new System.Drawing.Point(0, 0);
            this.tabControlTests.Name = "tabControlTests";
            this.tabControlTests.SelectedIndex = 0;
            this.tabControlTests.Size = new System.Drawing.Size(608, 423);
            this.tabControlTests.TabIndex = 0;
            // 
            // tabPageProcesses
            // 
            this.tabPageProcesses.Controls.Add(this.btnFilter);
            this.tabPageProcesses.Controls.Add(this.txtFilter);
            this.tabPageProcesses.Controls.Add(label4);
            this.tabPageProcesses.Controls.Add(this.checkBoxUnrestricted);
            this.tabPageProcesses.Controls.Add(this.btnCurrentProcess);
            this.tabPageProcesses.Controls.Add(this.treeViewProcesses);
            this.tabPageProcesses.Location = new System.Drawing.Point(4, 22);
            this.tabPageProcesses.Name = "tabPageProcesses";
            this.tabPageProcesses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcesses.Size = new System.Drawing.Size(600, 397);
            this.tabPageProcesses.TabIndex = 2;
            this.tabPageProcesses.Text = "Processes";
            this.tabPageProcesses.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(438, 5);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Apply Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(178, 8);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(140, 20);
            this.txtFilter.TabIndex = 4;
            // 
            // checkBoxUnrestricted
            // 
            this.checkBoxUnrestricted.AutoSize = true;
            this.checkBoxUnrestricted.Location = new System.Drawing.Point(324, 8);
            this.checkBoxUnrestricted.Name = "checkBoxUnrestricted";
            this.checkBoxUnrestricted.Size = new System.Drawing.Size(108, 17);
            this.checkBoxUnrestricted.TabIndex = 2;
            this.checkBoxUnrestricted.Text = "Hide Unrestricted";
            this.checkBoxUnrestricted.UseVisualStyleBackColor = true;
            // 
            // btnCurrentProcess
            // 
            this.btnCurrentProcess.Location = new System.Drawing.Point(3, 6);
            this.btnCurrentProcess.Name = "btnCurrentProcess";
            this.btnCurrentProcess.Size = new System.Drawing.Size(100, 23);
            this.btnCurrentProcess.TabIndex = 1;
            this.btnCurrentProcess.Text = "Current Process";
            this.btnCurrentProcess.UseVisualStyleBackColor = true;
            this.btnCurrentProcess.Click += new System.EventHandler(this.btnCurrentProcess_Click);
            // 
            // treeViewProcesses
            // 
            this.treeViewProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewProcesses.ContextMenuStrip = this.contextMenuStripProcesses;
            this.treeViewProcesses.Location = new System.Drawing.Point(3, 31);
            this.treeViewProcesses.Name = "treeViewProcesses";
            this.treeViewProcesses.Size = new System.Drawing.Size(594, 363);
            this.treeViewProcesses.TabIndex = 0;
            this.treeViewProcesses.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeViewProcesses_MouseDown);
            // 
            // contextMenuStripProcesses
            // 
            this.contextMenuStripProcesses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTokenToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.refreshTokenHandlesToolStripMenuItem});
            this.contextMenuStripProcesses.Name = "contextMenuStripProcesses";
            this.contextMenuStripProcesses.Size = new System.Drawing.Size(196, 70);
            // 
            // openTokenToolStripMenuItem
            // 
            this.openTokenToolStripMenuItem.Name = "openTokenToolStripMenuItem";
            this.openTokenToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.openTokenToolStripMenuItem.Text = "Open Token";
            this.openTokenToolStripMenuItem.Click += new System.EventHandler(this.openTokenToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // refreshTokenHandlesToolStripMenuItem
            // 
            this.refreshTokenHandlesToolStripMenuItem.Name = "refreshTokenHandlesToolStripMenuItem";
            this.refreshTokenHandlesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.refreshTokenHandlesToolStripMenuItem.Text = "Refresh Token Handles";
            this.refreshTokenHandlesToolStripMenuItem.Click += new System.EventHandler(this.refreshTokenHandlesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 423);
            this.Controls.Add(this.tabControlTests);
            this.Name = "MainForm";
            this.Text = "Token Viewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            tabPageGeneral.ResumeLayout(false);
            this.groupBoxServiceAccounts.ResumeLayout(false);
            groupBoxLogonUser.ResumeLayout(false);
            groupBoxLogonUser.PerformLayout();
            tabPageServices.ResumeLayout(false);
            groupBoxAnonymous.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxFromBits.ResumeLayout(false);
            this.tabControlTests.ResumeLayout(false);
            this.tabPageProcesses.ResumeLayout(false);
            this.tabPageProcesses.PerformLayout();
            this.contextMenuStripProcesses.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTests;
        private System.Windows.Forms.TabPage tabPageProcesses;
        private System.Windows.Forms.TreeView treeViewProcesses;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProcesses;
        private System.Windows.Forms.ToolStripMenuItem openTokenToolStripMenuItem;
        private System.Windows.Forms.Button btnCreteS4U;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtS4URealm;
        private System.Windows.Forms.TextBox txtS4UUserName;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.GroupBox groupBoxServiceAccounts;
        private System.Windows.Forms.Button btnCreateSystem;
        private System.Windows.Forms.Button btnCreateNetworkService;
        private System.Windows.Forms.Button btnCreateLocalService;
        private System.Windows.Forms.ComboBox comboBoxS4ULogonType;
        private System.Windows.Forms.RadioButton radioLUS4U;
        private System.Windows.Forms.RadioButton radioLUNormal;
        private System.Windows.Forms.TextBox txtLUPassword;
        private System.Windows.Forms.Button btnCreateFromBits;
        private System.Windows.Forms.Button btnPipeConnect;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.TextBox txtPipeName;
        private System.Windows.Forms.Button btnClipboardToken;
        private System.Windows.Forms.Button btnCurrentProcess;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Button btnCreateAnonymous;
        private System.Windows.Forms.CheckBox checkBoxUnrestricted;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ToolStripMenuItem refreshTokenHandlesToolStripMenuItem;
    }
}

