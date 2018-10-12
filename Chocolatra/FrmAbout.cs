using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocolatra
{
    public partial class FrmAbout : MaterialForm
    {
        public FrmAbout()
        { 
            InitializeComponent();
            TranslateForm();
        }

        private void TranslateForm()
        {
            var lines = Translation.Engine.Lines;
            Text = lines["frmabouttitle"];
            lblBy.Text = lines["lblby"];
            txtDescription.Text = lines["frmaboutdescription"];
            btnGithub.Text = lines["btngithub"];

        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            lblVersion.Text = Application.ProductVersion;
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Gustavo-Kuze/Chocolatra");
        }

        
    }
}
