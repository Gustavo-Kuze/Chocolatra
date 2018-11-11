using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using mshtml;
using System.IO;
using System.Drawing;

namespace Chocolatra
{
    public partial class FrmBrowser : MaterialForm
    {
        public List<string> Chocolatras = new List<string>();
        private Dictionary<string, HtmlElement> AddedChocos = new Dictionary<string, HtmlElement>();


        public FrmBrowser()
        {
            InitializeComponent();
            TranslateForm();
        }

        private void TranslateForm()
        {
            var lines = Translation.Engine.Lines;
            Text = lines["frmbrowsertitle"];
            lblAddedPackagesList.Text = lines["lbladdedpackageslist"];
            btnToggleDrawer.Text = lines["btntogglepackageslist"];
            btnBrowserOk.Text = lines["btnok"];
            btnBrowserCancel.Text = lines["btncancel"];
        }


        private void FrmBrowser_Load(object sender, EventArgs e)
        {
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.Navigate("https://chocolatey.org/packages");
            webBrowser.DocumentCompleted += (send, ev) =>
            {
                HtmlElementCollection codes = webBrowser.Document.GetElementsByTagName("code");

                foreach (HtmlElement code in codes)
                {
                    var btn = webBrowser.Document.CreateElement("button");
                    btn.InnerText = Translation.Engine.Lines["btnschocolateysite"];
                    btn.Style = "background-color:#795548;color:white;border:1px solid #f5f5f5;font-family: Segoe UI, Sans;text-shadow: 3px 3px 8px #222;font-size: 1.1em;margin-top:10px;cursor: pointer;padding: 8px;";
                    code.AppendChild(btn);

                    btn.Click += (snrd, evt) =>
                    {
                        string packageName = code.InnerText.Replace("C:\\> choco install ", "").Replace(btn.InnerText, "");
                        Chocolatras.Add(packageName);
                        btn.Style = "display: none;";
                        AddedChocos.Add(packageName, btn);
                        refreshList();
                    };
                }

            };
        }

        private void btnBrowserOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBrowserCancel_Click(object sender, EventArgs e)
        {
            Chocolatras.Clear();
            Close();
        }

        private void btnToggleDrawer_Click(object sender, EventArgs e)
        {
            if (panelChocolatrasDrawer.Location.X >= 0)
            {
                panelChocolatrasDrawer.Location = new System.Drawing.Point(-4000, panelChocolatrasDrawer.Location.Y);
                panelChocolatrasDrawer.Visible = false;
            }
            else
            {
                panelChocolatrasDrawer.Visible = true;
                panelChocolatrasDrawer.Location = new System.Drawing.Point(1, panelChocolatrasDrawer.Location.Y);
            }
        }


        private void refreshList()
        {
            panelChocolatrasContainer.Controls.Clear();
            foreach (var choco in Chocolatras)
            {
                Label lbl = new Label();
                lbl.Text = choco;
                lbl.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Bold);
                lbl.ForeColor = System.Drawing.Color.White;
                lbl.AutoSize = false;
                lbl.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                lbl.Width = panelChocolatrasContainer.Width;


                lbl.Click += (sdr, evt) =>
                {
                    Chocolatras.Remove(lbl.Text);
                    AddedChocos[lbl.Text].Style = "background-color:#795548;color:white;border:1px solid #f5f5f5;font-family: Segoe UI, Sans;text-shadow: 3px 3px 8px #222;font-size: 1.1em;margin-top:10px;cursor: pointer;padding: 8px;";
                    AddedChocos.Remove(lbl.Text);
                    refreshList();
                };

                lbl.MouseEnter += (sdr, evt) =>
                {
                    lbl.ForeColor = Color.FromArgb(255, 229, 57, 53);
                    Cursor = Cursors.Hand;
                };

                lbl.MouseLeave += (sdr, evt) =>
                {
                    lbl.ForeColor = Color.FromArgb(255, 232, 232, 232);
                    Cursor = Cursors.Arrow;
                };

                lbl.BringToFront();
                if (panelChocolatrasContainer.Controls.Count > 0)
                {
                    Point lblLast = panelChocolatrasContainer.Controls[panelChocolatrasContainer.Controls.Count - 1].Location;
                    lbl.Location = new Point(10, lblLast.Y + lbl.Height + 10);
                    panelChocolatrasContainer.Controls.Add(lbl);

                }
                else
                {
                    lbl.Location = new Point(10, 10);
                    panelChocolatrasContainer.Controls.Add(lbl);
                }
            }
        }


    }
}
