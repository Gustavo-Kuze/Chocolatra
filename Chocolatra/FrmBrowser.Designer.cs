namespace Chocolatra
{
    partial class FrmBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBrowser));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btnBrowserOk = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panelWebBrowserContainer = new System.Windows.Forms.Panel();
            this.btnBrowserCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnToggleDrawer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panelChocolatrasDrawer = new System.Windows.Forms.Panel();
            this.lblAddedPackagesList = new System.Windows.Forms.Label();
            this.panelChocolatrasContainer = new System.Windows.Forms.Panel();
            this.panelWebBrowserContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelChocolatrasDrawer.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(-1, -1);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(853, 547);
            this.webBrowser.TabIndex = 0;
            // 
            // btnBrowserOk
            // 
            this.btnBrowserOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowserOk.Depth = 0;
            this.btnBrowserOk.Location = new System.Drawing.Point(692, 614);
            this.btnBrowserOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowserOk.Name = "btnBrowserOk";
            this.btnBrowserOk.Primary = true;
            this.btnBrowserOk.Size = new System.Drawing.Size(130, 37);
            this.btnBrowserOk.TabIndex = 1;
            this.btnBrowserOk.Text = "OK";
            this.btnBrowserOk.UseVisualStyleBackColor = true;
            this.btnBrowserOk.Click += new System.EventHandler(this.btnBrowserOk_Click);
            // 
            // panelWebBrowserContainer
            // 
            this.panelWebBrowserContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWebBrowserContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWebBrowserContainer.Controls.Add(this.webBrowser);
            this.panelWebBrowserContainer.Location = new System.Drawing.Point(-1, 61);
            this.panelWebBrowserContainer.Name = "panelWebBrowserContainer";
            this.panelWebBrowserContainer.Size = new System.Drawing.Size(853, 547);
            this.panelWebBrowserContainer.TabIndex = 2;
            // 
            // btnBrowserCancel
            // 
            this.btnBrowserCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowserCancel.Depth = 0;
            this.btnBrowserCancel.Location = new System.Drawing.Point(556, 614);
            this.btnBrowserCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowserCancel.Name = "btnBrowserCancel";
            this.btnBrowserCancel.Primary = true;
            this.btnBrowserCancel.Size = new System.Drawing.Size(130, 37);
            this.btnBrowserCancel.TabIndex = 1;
            this.btnBrowserCancel.Text = "Cancel";
            this.btnBrowserCancel.UseVisualStyleBackColor = true;
            this.btnBrowserCancel.Click += new System.EventHandler(this.btnBrowserCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(44)))), ((int)(((byte)(1)))));
            this.panel1.Controls.Add(this.btnToggleDrawer);
            this.panel1.Location = new System.Drawing.Point(-1, 601);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 63);
            this.panel1.TabIndex = 3;
            // 
            // btnToggleDrawer
            // 
            this.btnToggleDrawer.Depth = 0;
            this.btnToggleDrawer.Location = new System.Drawing.Point(7, 13);
            this.btnToggleDrawer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnToggleDrawer.Name = "btnToggleDrawer";
            this.btnToggleDrawer.Primary = true;
            this.btnToggleDrawer.Size = new System.Drawing.Size(236, 37);
            this.btnToggleDrawer.TabIndex = 2;
            this.btnToggleDrawer.Text = "Toggle Packages List";
            this.btnToggleDrawer.UseVisualStyleBackColor = true;
            this.btnToggleDrawer.Click += new System.EventHandler(this.btnToggleDrawer_Click);
            // 
            // panelChocolatrasDrawer
            // 
            this.panelChocolatrasDrawer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelChocolatrasDrawer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(44)))), ((int)(((byte)(1)))));
            this.panelChocolatrasDrawer.Controls.Add(this.lblAddedPackagesList);
            this.panelChocolatrasDrawer.Controls.Add(this.panelChocolatrasContainer);
            this.panelChocolatrasDrawer.Location = new System.Drawing.Point(0, 314);
            this.panelChocolatrasDrawer.Name = "panelChocolatrasDrawer";
            this.panelChocolatrasDrawer.Size = new System.Drawing.Size(245, 294);
            this.panelChocolatrasDrawer.TabIndex = 4;
            // 
            // lblAddedPackagesList
            // 
            this.lblAddedPackagesList.AutoSize = true;
            this.lblAddedPackagesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddedPackagesList.ForeColor = System.Drawing.Color.White;
            this.lblAddedPackagesList.Location = new System.Drawing.Point(18, 9);
            this.lblAddedPackagesList.Name = "lblAddedPackagesList";
            this.lblAddedPackagesList.Size = new System.Drawing.Size(212, 18);
            this.lblAddedPackagesList.TabIndex = 3;
            this.lblAddedPackagesList.Text = "Packages added to Chocolatra";
            // 
            // panelChocolatrasContainer
            // 
            this.panelChocolatrasContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelChocolatrasContainer.AutoScroll = true;
            this.panelChocolatrasContainer.Location = new System.Drawing.Point(4, 45);
            this.panelChocolatrasContainer.Name = "panelChocolatrasContainer";
            this.panelChocolatrasContainer.Size = new System.Drawing.Size(236, 237);
            this.panelChocolatrasContainer.TabIndex = 1;
            // 
            // FrmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 654);
            this.ControlBox = false;
            this.Controls.Add(this.panelChocolatrasDrawer);
            this.Controls.Add(this.panelWebBrowserContainer);
            this.Controls.Add(this.btnBrowserCancel);
            this.Controls.Add(this.btnBrowserOk);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chocolatra - Choose packages online";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBrowser_Load);
            this.panelWebBrowserContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelChocolatrasDrawer.ResumeLayout(false);
            this.panelChocolatrasDrawer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private MaterialSkin.Controls.MaterialRaisedButton btnBrowserOk;
        private System.Windows.Forms.Panel panelWebBrowserContainer;
        private MaterialSkin.Controls.MaterialRaisedButton btnBrowserCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelChocolatrasDrawer;
        private MaterialSkin.Controls.MaterialRaisedButton btnToggleDrawer;
        private System.Windows.Forms.Panel panelChocolatrasContainer;
        private System.Windows.Forms.Label lblAddedPackagesList;
    }
}