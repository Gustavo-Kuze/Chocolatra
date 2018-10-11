using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocolatra
{
    public partial class FrmMain : MaterialForm
    {
        public FrmMain()
        {
            InitializeComponent();
            setMaterialThemeColors();
        }
        
        private async void btnAddInstalledPackages_Click(object sender, EventArgs e)
        {
            QuickLog("Searching for packages, please wait...");
            Task task = new Task(addInstalledToList);
            task.Start();
            await task;
        }

        #region More
        private void btnAbout_Click(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout();
            about.ShowDialog();
        }

        private async void btnInstallChoco_Click(object sender, EventArgs e)
        {
            ToggleEnableButtonsInvoked(false);
            Task tsk = new Task(() =>
            {
                ProcessWindowStyle style = ProcessWindowStyle.Hidden;
                Invoke(new MethodInvoker(() =>
                {
                    panelChocolateyButtons.Enabled = false;
                    if (chkShowConsole.Checked)
                    {
                        style = ProcessWindowStyle.Normal;
                    }
                }));
                Cmd.RunAndWait("@\"%SystemRoot%\\System32\\WindowsPowerShell\\v1.0\\powershell.exe\" -NoProfile -InputFormat None -ExecutionPolicy Bypass -Command \"iex((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))\" && SET \"PATH=%PATH%;%ALLUSERSPROFILE%\\chocolatey\\bin\"", true, style);
            });
            tsk.Start();
            await tsk;
            ToggleEnableButtonsInvoked(true);
        }


        private void btnUninstallChocolatey_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure You want to remove Chocolatey from your system? Chocolatra will no longer work until You reinstall Chocolatey!", "Do You really want to Uninstall Chocolatey?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\chocolatey", true);
                    MessageBox.Show("Chocolatey was removed from this computer", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error while trying to remove Chocolatey", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
        
        private void btnOpenSite_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmBrowser"] == null)
            {
                FrmBrowser browser = new FrmBrowser();
                browser.Show();
                browser.FormClosed += (send, ev) =>
                {
                    foreach (string package in browser.Chocolatras)
                    {
                        PackagesManagement pm = new PackagesManagement();
                        pm.add(new string[] { package });

                    }
                    RefreshList();
                };
            }
            else
            {
                Application.OpenForms["FrmBrowser"].BringToFront();
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddCommand.Text != string.Empty)
            {
                PackagesManagement pm = new PackagesManagement();
                pm.add(new string[] { txtAddCommand.Text });
                RefreshList();
                txtAddCommand.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("You have to type the Chocolatey package name on the text field before adding", "No given package name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveSelected();
        }



        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (!Utils.Internet.IsActive())
            {
                QuickLog("Attention: This application needs an active internet connection to work");
            }
            RefreshList();
        }


        private void chkCheckAll_CheckStateChanged(object sender, EventArgs e)
        {
            ChangeCheckAll();
        }

       

        private void AutoChocoWithProgress(string command, string logMessage)
        {
            ToggleEnableButtonsInvoked(false);
            var boxes = GetCheckedBoxesText();
            int currentIndex = 1;
            Invoke(new MethodInvoker(() =>
            {
                prgProgress.Maximum = boxes.Count();
                prgProgress.Visible = true;
                lblProgress.Visible = true;
            }));

            boxes.ForEach((box) =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    prgProgress.Value = currentIndex;
                    lblProgress.Text = logMessage + " " + box + " - " + (currentIndex) + "/" + boxes.Count();
                }));

                RunChoco(box, command);
                ++currentIndex;
            });
            Invoke(new MethodInvoker(() =>
            {
                prgProgress.Visible = false;
                lblProgress.Visible = false;
            }));
            ToggleEnableButtonsInvoked(true);

        }


        private async void btnInstallPackages_Click(object sender, EventArgs e)
        {
            if (isAnyPackageSelected())
            {
                Task tsk = new Task(() => { AutoChocoWithProgress("install", "Installing package"); });
                tsk.Start();
                await tsk;

            }
            else
            {
                MessageBox.Show("You have to select a package to install", "No packages selected for installation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnUpdatePackages_Click(object sender, EventArgs e)
        {
            if (isAnyPackageSelected())
            {
                Task tsk = new Task(() => { AutoChocoWithProgress("upgrade", "Upgrading package"); });
                tsk.Start();
                await tsk;
            }
            else
            {
                MessageBox.Show("You have to select a package to upgrade", "No packages selected for upgrading", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnUninstallPackages_Click(object sender, EventArgs e)
        {
            if (isAnyPackageSelected())
            {
                Task tsk = new Task(() => { AutoChocoWithProgress("uninstall --remove-dependencies", "Uninstalling package"); });
                tsk.Start();
                await tsk;

            }
            else
            {
                MessageBox.Show("You have to select a package to uninstall", "No packages selected for uninstallation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void txtAddCommand_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }

        #region Methods
        /// <summary>
        /// Changes the checked state of all checkboxes inside panelListBoxContainer
        /// </summary>
        private void ChangeCheckAll()
        {
            bool checkState = false;
            if (chkCheckAll.Checked)
            {
                checkState = true;
            }
            foreach (MaterialCheckBox chk in panelListBoxContainer.Controls.OfType<MaterialCheckBox>())
            {
                chk.Checked = checkState;
            }
        }

        /// <summary>
        /// Deletes all controls from panelListBoxContainer and than add a new checkbox for each
        /// package saved on the packages file
        /// </summary>
        private void RefreshList()
        {
            panelListBoxContainer.Controls.Clear();
            PackagesManagement pm = new PackagesManagement();
            var packages = pm.load();
            foreach (var pack in packages)
            {
                MaterialCheckBox chkNew = new MaterialCheckBox();
                chkNew.Text = pack;
                FixChkSize(chkNew);
                AddCheckBox(chkNew);
            }
        }

        /// <summary>
        /// Remove the packages from the packages file and than refreshes the list
        /// </summary>
        private void RemoveSelected()
        {
            if (isAnyPackageSelected())
            {
                PackagesManagement pm = new PackagesManagement();
                GetCheckedBoxesText().ForEach((box) =>
                {
                    pm.remove(box);
                });
                chkCheckAll.Checked = false;
                RefreshList();
            }
            else
            {
                MessageBox.Show("You have to select something to remove", "No packages selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// Returns true if there's any panelListBoxContainer checkbox selected
        /// </summary>
        private bool isAnyPackageSelected()
        {
            return GetCheckedBoxes().Count > 0;
        }

        /// <summary>
        /// Insert the passed MaterialCheckBox inside panelListBoxContainer after the last one. If there aren't any controls in panelListBoxContainer, The checkbox gets added at 10 pixels from the top of the panel.
        /// </summary>
        /// <param name="checkBox">A new MaterialCheckBox to add to the panel</param>
        private void AddCheckBox(MaterialCheckBox checkBox)
        {
            if (panelListBoxContainer.Controls.Count > 0)
            {
                foreach (Control item in panelListBoxContainer.Controls)
                {
                    if (item.Text == checkBox.Text)
                    {
                        return;
                    }
                }

                Point lastCtrlPos = panelListBoxContainer.Controls[panelListBoxContainer.Controls.Count - 1].Location;
                checkBox.Location = new Point(lastCtrlPos.X, lastCtrlPos.Y + checkBox.Height + 10);

                panelListBoxContainer.Controls.Add(checkBox);

            }
            else
            {
                checkBox.Location = new Point(10, 10);
                panelListBoxContainer.Controls.Add(checkBox);
            }

        }

        /// <summary>
        /// Sets the size of the passed checkbox to fill the parent control horizontally and changes Its anchor to left + top + right.
        /// </summary>
        /// <param name="chk"></param>
        private void FixChkSize(MaterialCheckBox chk)
        {
            chk.AutoSize = false;
            chk.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            chk.Size = new Size(panelListBoxContainer.Size.Width - 50, chk.Size.Height);
        }


        /// <summary>
        /// Change the color set of MaterialSkin library for the entire program.
        /// </summary>
        private void setMaterialThemeColors()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Brown700, Primary.Brown600, Primary.Brown300, Accent.Amber400, TextShade.WHITE);
        }

        /// <summary>
        /// Get the text of all checked checkboxes.
        /// </summary>
        /// <returns>Returns a list with the checked checkboxes text.</returns>
        private List<string> GetCheckedBoxesText()
        {
            List<string> checkedBoxes = new List<string>();
            GetCheckedBoxes().ForEach((box) =>
            {
                checkedBoxes.Add(box.Text);
            });
            return checkedBoxes;
        }

        /// <summary>
        /// Get all checked boxes
        /// </summary>
        /// <returns>Returns a list with the checked checkboxes</returns>
        private List<MaterialCheckBox> GetCheckedBoxes()
        {
            List<MaterialCheckBox> checkedBoxes = new List<MaterialCheckBox>();
            foreach (MaterialCheckBox chk in panelListBoxContainer.Controls.OfType<MaterialCheckBox>())
            {
                if (chk.Checked)
                {
                    checkedBoxes.Add(chk);
                }
            }
            return checkedBoxes;
        }

        /// <summary>
        /// Run chocolatey command using command prompt
        /// </summary>
        /// <param name="package">The name of the package to be passed as argument to Choco</param>
        /// <param name="command">What should the Choco tool do with the given package</param>
        private void RunChoco(string package, string command)
        {
            ProcessWindowStyle style = ProcessWindowStyle.Hidden;
            if (chkShowConsole.Checked)
            {
                style = ProcessWindowStyle.Normal;
            }

            Cmd.RunAndWait("choco " + command + " " + package + " -y", true, style);
        }


        private void QuickLog(string msg)
        {
            lblQuickLog.Text = msg;
            lblQuickLog.Visible = true;
        }

        private void HideLog()
        {
            lblQuickLog.Text = "...";
            lblQuickLog.Visible = false;
        }

        private void addInstalledToList()
        {
            string output = Cmd.RunAndWaitWithOutput("choco list --local-only", ProcessWindowStyle.Hidden);

            output.Split('\n').ToList().ForEach((line) =>
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    if ((!line.Contains("installed")) && line != "")
                    {
                        PackagesManagement pm = new PackagesManagement();
                        pm.add(new string[] { line.Split(' ')[0] });
                        RefreshList();
                    }
                    HideLog();
                }));
            });

        }


        private void ToggleEnableButtonsInvoked(bool enable = true)
        {
            Invoke(new MethodInvoker(() =>
            {
                panelActionButtons.Enabled = panelChocolateyButtons.Enabled = enable;
            }));
        }

        #endregion



    }
}
