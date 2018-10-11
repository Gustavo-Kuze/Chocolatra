using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using mshtml;
using System.IO;

namespace Chocolatra
{
    public partial class FrmBrowser : MaterialForm
    {
        public List<string> Chocolatras = new List<string>();

        public FrmBrowser()
        {
            InitializeComponent();
        }

        private void FrmBrowser_Load(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\js\\chocolatras-container.js"))
            {
                webBrowser.ScriptErrorsSuppressed = true;
                webBrowser.Navigate("https://chocolatey.org/packages");
                webBrowser.DocumentCompleted += (send, ev) =>
                {
                    HtmlElement head = webBrowser.Document.GetElementsByTagName("head")[0];
                    HtmlElement scriptEl = webBrowser.Document.CreateElement("script");
                    IHTMLScriptElement element = (IHTMLScriptElement)scriptEl.DomElement;
                    element.text = File.ReadAllText(Application.StartupPath + "\\js\\chocolatras-container.js", System.Text.Encoding.UTF8);
                    head.AppendChild(scriptEl);
                    webBrowser.Document.InvokeScript("addButtonsToCodes");

                };
            }
            else
            {
                MessageBox.Show("Javascript file not found. Please download and extract the program again.", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void btnBrowserOk_Click(object sender, EventArgs e)
        {
            var chocolatras = webBrowser.Document.GetElementsByTagName("chocolatra");
            foreach (HtmlElement choc in chocolatras)
            {
                Chocolatras.Add(choc.InnerText);
            }
            Close();
        }

        private void btnBrowserCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

/*
  element.text = @"
       function addButtonsToCodes() {
        var codes = Array.from(document.getElementsByTagName('code'));
        codes.forEach(function (element) {
            var btn = document.createElement('button');
            btn.innerText = 'Add package to Chocolatra';
            btn.style.background = '#4e2c01';
            btn.style.color = '#f5f5f5';
            btn.style.borderWidth = '0';
            btn.style.fontSize = '1.1em';
            btn.style.marginTop = '10px';

            btn.onclick = function (e) {
                var packageText = element.parentElement.innerText.replace('C:\\> choco install ', '')
                                                    .replace('Add package to Chocolatra', '').trim();
                addPackageToList(packageText);
                element.removeChild(element.getElementsByTagName('button')[0]);
            };

            element.appendChild(btn);
        })
    }

    function createContainer(){
        var chocolatrasContainer = document.createElement('div')
        chocolatrasContainer.setAttribute('id', 'chocolatras-container')
        chocolatrasContainer.style.display = 'flex';
        chocolatrasContainer.style.flexDirection = 'column';
        chocolatrasContainer.style.alignItems = 'center';
        chocolatrasContainer.style.position = 'fixed';
        chocolatrasContainer.style.top = '35%';
        chocolatrasContainer.style.border = 'solid 1px brown';
        chocolatrasContainer.style.backgroundColor = '#4e2c01';
        chocolatrasContainer.style.height = '800px';
        chocolatrasContainer.style.width = '15%';
        chocolatrasContainer.style.opacity = '0.9';
        chocolatrasContainer.style.fontFamily = 'Segoe UI, Sans';
        document.body.appendChild(chocolatrasContainer);
        var chocContainerTitle = document.createElement('h5');
        chocContainerTitle.innerText = 'Packages added to Chocolatra:';
        chocContainerTitle.style.fontWeight = 'bold';
        chocContainerTitle.style.color = '#f5f5f5';

        chocolatrasContainer.appendChild(chocContainerTitle);
    }

    function addPackageToList(package){
        var chocolatra = document.createElement('chocolatra');
        chocolatra.innerText = package;
        chocolatra.style.color = '#f5f5f5';
        chocolatra.style.fontSize = '1.1em';
       document.getElementById('chocolatras-container').appendChild(chocolatra);
       // alert('Package ' + package + ' added. It will be saved to the packages list as soon as You close this Window');
    };
    createContainer();
                                ";
     
     
     */
