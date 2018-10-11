﻿namespace Chocolatra
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panelMainContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInternetConn = new System.Windows.Forms.Label();
            this.lblInstalledMsg = new MaterialSkin.Controls.MaterialLabel();
            this.chkCheckAll = new MaterialSkin.Controls.MaterialCheckBox();
            this.panelListBoxContainer = new System.Windows.Forms.Panel();
            this.txtAddCommand = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAddInstalledPackages = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRemove = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnOpenSite = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.prgProgress = new System.Windows.Forms.ProgressBar();
            this.btnUninstallPackages = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblProgress = new MaterialSkin.Controls.MaterialLabel();
            this.btnUpdatePackages = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnInstallPackages = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkShowConsole = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnInstallChoco = new MaterialSkin.Controls.MaterialFlatButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnAbout = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panelMainContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainContainer.BackColor = System.Drawing.Color.White;
            this.panelMainContainer.Controls.Add(this.panel1);
            this.panelMainContainer.Controls.Add(this.panel2);
            this.panelMainContainer.Controls.Add(this.panel3);
            this.panelMainContainer.Location = new System.Drawing.Point(12, 69);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(757, 557);
            this.panelMainContainer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblInternetConn);
            this.panel1.Controls.Add(this.lblInstalledMsg);
            this.panel1.Controls.Add(this.chkCheckAll);
            this.panel1.Controls.Add(this.panelListBoxContainer);
            this.panel1.Controls.Add(this.txtAddCommand);
            this.panel1.Controls.Add(this.btnAddInstalledPackages);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnOpenSite);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 283);
            this.panel1.TabIndex = 15;
            // 
            // lblInternetConn
            // 
            this.lblInternetConn.AutoSize = true;
            this.lblInternetConn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternetConn.ForeColor = System.Drawing.Color.Red;
            this.lblInternetConn.Location = new System.Drawing.Point(289, 19);
            this.lblInternetConn.Name = "lblInternetConn";
            this.lblInternetConn.Size = new System.Drawing.Size(427, 20);
            this.lblInternetConn.TabIndex = 14;
            this.lblInternetConn.Text = "Attention: This tool needs an active internet connection to work";
            this.lblInternetConn.Visible = false;
            // 
            // lblInstalledMsg
            // 
            this.lblInstalledMsg.AutoSize = true;
            this.lblInstalledMsg.Depth = 0;
            this.lblInstalledMsg.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblInstalledMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInstalledMsg.Location = new System.Drawing.Point(2, 4);
            this.lblInstalledMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInstalledMsg.Name = "lblInstalledMsg";
            this.lblInstalledMsg.Size = new System.Drawing.Size(130, 19);
            this.lblInstalledMsg.TabIndex = 0;
            this.lblInstalledMsg.Text = "Manage packages";
            // 
            // chkCheckAll
            // 
            this.chkCheckAll.AutoSize = true;
            this.chkCheckAll.Depth = 0;
            this.chkCheckAll.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkCheckAll.Location = new System.Drawing.Point(35, 29);
            this.chkCheckAll.Margin = new System.Windows.Forms.Padding(0);
            this.chkCheckAll.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkCheckAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkCheckAll.Name = "chkCheckAll";
            this.chkCheckAll.Ripple = true;
            this.chkCheckAll.Size = new System.Drawing.Size(86, 30);
            this.chkCheckAll.TabIndex = 1;
            this.chkCheckAll.Text = "Check all";
            this.chkCheckAll.UseVisualStyleBackColor = true;
            this.chkCheckAll.CheckStateChanged += new System.EventHandler(this.chkCheckAll_CheckStateChanged);
            // 
            // panelListBoxContainer
            // 
            this.panelListBoxContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelListBoxContainer.AutoScroll = true;
            this.panelListBoxContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelListBoxContainer.Location = new System.Drawing.Point(26, 62);
            this.panelListBoxContainer.Name = "panelListBoxContainer";
            this.panelListBoxContainer.Size = new System.Drawing.Size(433, 207);
            this.panelListBoxContainer.TabIndex = 2;
            this.toolTip.SetToolTip(this.panelListBoxContainer, "The saved packages will be displayed here");
            // 
            // txtAddCommand
            // 
            this.txtAddCommand.Depth = 0;
            this.txtAddCommand.Hint = "Chocolatey package name to add";
            this.txtAddCommand.Location = new System.Drawing.Point(482, 74);
            this.txtAddCommand.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddCommand.Name = "txtAddCommand";
            this.txtAddCommand.PasswordChar = '\0';
            this.txtAddCommand.SelectedText = "";
            this.txtAddCommand.SelectionLength = 0;
            this.txtAddCommand.SelectionStart = 0;
            this.txtAddCommand.Size = new System.Drawing.Size(234, 23);
            this.txtAddCommand.TabIndex = 3;
            this.txtAddCommand.UseSystemPasswordChar = false;
            this.txtAddCommand.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAddCommand_KeyUp);
            // 
            // btnAddInstalledPackages
            // 
            this.btnAddInstalledPackages.AutoSize = true;
            this.btnAddInstalledPackages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddInstalledPackages.Depth = 0;
            this.btnAddInstalledPackages.Location = new System.Drawing.Point(466, 185);
            this.btnAddInstalledPackages.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddInstalledPackages.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddInstalledPackages.Name = "btnAddInstalledPackages";
            this.btnAddInstalledPackages.Primary = false;
            this.btnAddInstalledPackages.Size = new System.Drawing.Size(240, 36);
            this.btnAddInstalledPackages.TabIndex = 11;
            this.btnAddInstalledPackages.Text = "Add Installed Packages to List";
            this.toolTip.SetToolTip(this.btnAddInstalledPackages, "If You already have any Chocolatey packages installed, \r\nYou can add them to the " +
        "saved packages list by clicking here");
            this.btnAddInstalledPackages.UseVisualStyleBackColor = true;
            this.btnAddInstalledPackages.Click += new System.EventHandler(this.btnAddInstalledPackages_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Depth = 0;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(508, 106);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = false;
            this.btnAdd.Size = new System.Drawing.Size(39, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.toolTip.SetToolTip(this.btnAdd, "Add a package to the automation row");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.Depth = 0;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(555, 106);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Primary = false;
            this.btnRemove.Size = new System.Drawing.Size(135, 36);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove selected";
            this.toolTip.SetToolTip(this.btnRemove, "Remove the selected packages from the automation row");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnOpenSite
            // 
            this.btnOpenSite.AutoSize = true;
            this.btnOpenSite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenSite.Depth = 0;
            this.btnOpenSite.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSite.Location = new System.Drawing.Point(466, 233);
            this.btnOpenSite.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOpenSite.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenSite.Name = "btnOpenSite";
            this.btnOpenSite.Primary = false;
            this.btnOpenSite.Size = new System.Drawing.Size(264, 36);
            this.btnOpenSite.TabIndex = 6;
            this.btnOpenSite.Text = "Open Chocolatey Packages online";
            this.toolTip.SetToolTip(this.btnOpenSite, "Open the integrated Web browser to navigate through the online list of packages");
            this.btnOpenSite.UseVisualStyleBackColor = true;
            this.btnOpenSite.Click += new System.EventHandler(this.btnOpenSite_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Controls.Add(this.prgProgress);
            this.panel2.Controls.Add(this.btnUninstallPackages);
            this.panel2.Controls.Add(this.lblProgress);
            this.panel2.Controls.Add(this.btnUpdatePackages);
            this.panel2.Controls.Add(this.btnInstallPackages);
            this.panel2.Location = new System.Drawing.Point(7, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 173);
            this.panel2.TabIndex = 16;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 11);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Actions";
            // 
            // prgProgress
            // 
            this.prgProgress.Location = new System.Drawing.Point(3, 142);
            this.prgProgress.Maximum = 4;
            this.prgProgress.Name = "prgProgress";
            this.prgProgress.Size = new System.Drawing.Size(735, 20);
            this.prgProgress.TabIndex = 8;
            this.prgProgress.Visible = false;
            // 
            // btnUninstallPackages
            // 
            this.btnUninstallPackages.AutoSize = true;
            this.btnUninstallPackages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUninstallPackages.Depth = 0;
            this.btnUninstallPackages.Location = new System.Drawing.Point(499, 58);
            this.btnUninstallPackages.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUninstallPackages.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUninstallPackages.Name = "btnUninstallPackages";
            this.btnUninstallPackages.Primary = false;
            this.btnUninstallPackages.Size = new System.Drawing.Size(227, 36);
            this.btnUninstallPackages.TabIndex = 11;
            this.btnUninstallPackages.Text = "Uninstall Selected Packages";
            this.toolTip.SetToolTip(this.btnUninstallPackages, "It will uninstall all packages that are saved on the automation row\r\n");
            this.btnUninstallPackages.UseVisualStyleBackColor = true;
            this.btnUninstallPackages.Click += new System.EventHandler(this.btnUninstallPackages_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Depth = 0;
            this.lblProgress.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProgress.Location = new System.Drawing.Point(55, 120);
            this.lblProgress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(13, 19);
            this.lblProgress.TabIndex = 9;
            this.lblProgress.Text = "-";
            this.lblProgress.Visible = false;
            // 
            // btnUpdatePackages
            // 
            this.btnUpdatePackages.AutoSize = true;
            this.btnUpdatePackages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdatePackages.Depth = 0;
            this.btnUpdatePackages.Location = new System.Drawing.Point(275, 58);
            this.btnUpdatePackages.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdatePackages.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdatePackages.Name = "btnUpdatePackages";
            this.btnUpdatePackages.Primary = false;
            this.btnUpdatePackages.Size = new System.Drawing.Size(216, 36);
            this.btnUpdatePackages.TabIndex = 11;
            this.btnUpdatePackages.Text = "Upgrade Selected Packages";
            this.toolTip.SetToolTip(this.btnUpdatePackages, "It will upgrade all packages that are saved on the automation row\r\n");
            this.btnUpdatePackages.UseVisualStyleBackColor = true;
            this.btnUpdatePackages.Click += new System.EventHandler(this.btnUpdatePackages_Click);
            // 
            // btnInstallPackages
            // 
            this.btnInstallPackages.AutoSize = true;
            this.btnInstallPackages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInstallPackages.Depth = 0;
            this.btnInstallPackages.Location = new System.Drawing.Point(59, 58);
            this.btnInstallPackages.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInstallPackages.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInstallPackages.Name = "btnInstallPackages";
            this.btnInstallPackages.Primary = false;
            this.btnInstallPackages.Size = new System.Drawing.Size(208, 36);
            this.btnInstallPackages.TabIndex = 11;
            this.btnInstallPackages.Text = "Install Selected Packages";
            this.toolTip.SetToolTip(this.btnInstallPackages, "It will install all packages that are saved on the automation row");
            this.btnInstallPackages.UseVisualStyleBackColor = true;
            this.btnInstallPackages.Click += new System.EventHandler(this.btnInstallPackages_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnAbout);
            this.panel3.Controls.Add(this.chkShowConsole);
            this.panel3.Controls.Add(this.materialLabel2);
            this.panel3.Controls.Add(this.btnInstallChoco);
            this.panel3.Location = new System.Drawing.Point(7, 475);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(743, 61);
            this.panel3.TabIndex = 17;
            // 
            // chkShowConsole
            // 
            this.chkShowConsole.AutoSize = true;
            this.chkShowConsole.Checked = true;
            this.chkShowConsole.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowConsole.Depth = 0;
            this.chkShowConsole.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkShowConsole.Location = new System.Drawing.Point(357, 14);
            this.chkShowConsole.Margin = new System.Windows.Forms.Padding(0);
            this.chkShowConsole.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkShowConsole.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkShowConsole.Name = "chkShowConsole";
            this.chkShowConsole.Ripple = true;
            this.chkShowConsole.Size = new System.Drawing.Size(190, 30);
            this.chkShowConsole.TabIndex = 13;
            this.chkShowConsole.Text = "Show Chocolatey Console";
            this.toolTip.SetToolTip(this.chkShowConsole, "If checked, the command prompt (terminal) will be displayed to\r\nYou while running" +
        " the Choco commands (Installing, upgrading, Uninstalling).");
            this.chkShowConsole.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(4, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(44, 19);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "More";
            // 
            // btnInstallChoco
            // 
            this.btnInstallChoco.AutoSize = true;
            this.btnInstallChoco.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInstallChoco.Depth = 0;
            this.btnInstallChoco.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallChoco.Location = new System.Drawing.Point(142, 11);
            this.btnInstallChoco.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInstallChoco.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInstallChoco.Name = "btnInstallChoco";
            this.btnInstallChoco.Primary = false;
            this.btnInstallChoco.Size = new System.Drawing.Size(192, 36);
            this.btnInstallChoco.TabIndex = 6;
            this.btnInstallChoco.Text = "Install Chocolatey Now";
            this.toolTip.SetToolTip(this.btnInstallChoco, "Run the powershell script to download and install Chocolatey if You haven\'t done " +
        "It yet.\r\nNOTE: This program will not work without Chocolatey installed on your c" +
        "omputer.");
            this.btnInstallChoco.UseVisualStyleBackColor = true;
            this.btnInstallChoco.Click += new System.EventHandler(this.btnInstallChoco_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 300;
            this.toolTip.AutoPopDelay = 15000;
            this.toolTip.InitialDelay = 300;
            this.toolTip.ReshowDelay = 60;
            // 
            // btnAbout
            // 
            this.btnAbout.Depth = 0;
            this.btnAbout.Location = new System.Drawing.Point(671, 14);
            this.btnAbout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Primary = true;
            this.btnAbout.Size = new System.Drawing.Size(45, 33);
            this.btnAbout.TabIndex = 14;
            this.btnAbout.Text = "?";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 638);
            this.Controls.Add(this.panelMainContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Chocolatra - The Chocolatey Packages Automator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelMainContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainContainer;
        private MaterialSkin.Controls.MaterialCheckBox chkCheckAll;
        private System.Windows.Forms.Panel panelListBoxContainer;
        private MaterialSkin.Controls.MaterialFlatButton btnRemove;
        private MaterialSkin.Controls.MaterialFlatButton btnAdd;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAddCommand;
        private MaterialSkin.Controls.MaterialFlatButton btnInstallChoco;
        private MaterialSkin.Controls.MaterialFlatButton btnOpenSite;
        private MaterialSkin.Controls.MaterialLabel lblInstalledMsg;
        private MaterialSkin.Controls.MaterialLabel lblProgress;
        private System.Windows.Forms.ProgressBar prgProgress;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton btnUninstallPackages;
        private MaterialSkin.Controls.MaterialFlatButton btnUpdatePackages;
        private MaterialSkin.Controls.MaterialFlatButton btnInstallPackages;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCheckBox chkShowConsole;
        private System.Windows.Forms.Label lblInternetConn;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialFlatButton btnAddInstalledPackages;
        private MaterialSkin.Controls.MaterialRaisedButton btnAbout;
    }
}

