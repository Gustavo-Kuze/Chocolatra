namespace Chocolatra
{
    partial class FrmAbout
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVersion = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblBy = new MaterialSkin.Controls.MaterialLabel();
            this.btnGithub = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Chocolatra.Properties.Resources.chocolatra_icon;
            this.pictureBox1.Location = new System.Drawing.Point(267, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Depth = 0;
            this.lblVersion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVersion.Location = new System.Drawing.Point(322, 238);
            this.lblVersion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(61, 19);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(149, 282);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(406, 104);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Text = "\r\nChocolatra is an automation tool for installing, upgrading and uninstalling Cho" +
    "colatey packages.";
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Depth = 0;
            this.lblBy.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBy.Location = new System.Drawing.Point(231, 433);
            this.lblBy.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(249, 19);
            this.lblBy.TabIndex = 1;
            this.lblBy.Text = "Developed by Gustavo Kuze da Silva";
            // 
            // btnGithub
            // 
            this.btnGithub.AutoSize = true;
            this.btnGithub.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGithub.Depth = 0;
            this.btnGithub.Location = new System.Drawing.Point(276, 516);
            this.btnGithub.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGithub.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Primary = false;
            this.btnGithub.Size = new System.Drawing.Size(152, 36);
            this.btnGithub.TabIndex = 0;
            this.btnGithub.Text = "See more on Github";
            this.btnGithub.UseVisualStyleBackColor = true;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(1, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 539);
            this.panel1.TabIndex = 4;
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 603);
            this.Controls.Add(this.btnGithub);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblBy);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmAbout";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chocolatra - About";
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblVersion;
        private System.Windows.Forms.TextBox txtDescription;
        private MaterialSkin.Controls.MaterialLabel lblBy;
        private MaterialSkin.Controls.MaterialFlatButton btnGithub;
        private System.Windows.Forms.Panel panel1;
    }
}