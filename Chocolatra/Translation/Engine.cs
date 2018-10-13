using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocolatra.Translation
{
    internal class Engine
    {
        public static Dictionary<string, string> Lines { get; set; }

        public static void create()
        {
            /*
             create this dictionary is none is found
             */
            Lines = new Dictionary<string, string>
            {
                { "frmmaintitle", "Chocolatra - The Chocolatey packages automator" },
                {"lblautomationrow", "Automation row"},
                { "pleasewait", "Searching for packages, please wait..." },
                { "chkcheckall", "Check All" },
                {"txtaddcommandhint", "Package name"},
                {"btnadd", "Add"},
                {"btnremoveselected", "Remove selected"},
                {"btnaddinstalled", "Add installed packages"},
                {"btnonlinesearch", "Search online"},
                {"lblactions", "Actions"},
                {"btninstallchoco", "Install Chocolatey"},
                {"btnuninstallchoco", "Uninstall Chocolatey"},
                {"btninstall", "Install packages"},
                {"btnuninstall", "Uninstall packages"},
                {"btnupgrade", "Upgrade packages"},
                {"chkforcedependencies", "Force dependencies"},
                {"lblmore", "More"},
                {"chkshowconsole", "Show Chocolatey console"},
                {"mboxuninstallchocotext", "Are You sure You want to remove Chocolatey from your system? Chocolatra will no longer work until You reinstall Chocolatey!"},
                {"mboxuninstallchocotitle", "Do You really want to Uninstall Chocolatey?"},
                {"mboxchocoremovedtext", "Chocolatey was removed from this computer"},
                {"mboxchocoremovedtitle", "Success"},
                {"mboxuninstallchocoerrortitle", "Error while trying to remove Chocolatey"},
                {"mboxnopackagenamegiventitle", "No given package name"},
                {"mboxnopackagenamegiventext", "You have to type the Chocolatey package name on the text field before adding"},
                {"quicklognoconnection", "Attention: This application needs an active internet connection to work"},
                {"mboxnopackagesselectedtitle", "No packages selected"},
                {"mboxnopackagesselectedtext", "You have to select a package on the automation row first"},
                {"frmbrowsertitle", "Chocolatra - Choose a package online"},
                {"lbladdedpackageslist", "Added Packages"},
                {"btntogglepackageslist", "Toggle Packages List"},
                {"btncancel", "Cancel"},
                {"btnok", "Ok"},
                {"btnschocolateysite", "Add to Chocolatra"},
                {"frmabouttitle", "Chocolatra - About"},
                {"frmaboutdescription", "Chocolatra is an automation tool for installing, upgrading and uninstalling Chocolatey packages."},
                {"btngithub", "See more on Github"},
                {"lblby", "Developed by Gustavo Kuze da Silva"},
                {"ttlistbox", "The saved packages will be displayed here"},
                {"ttbtnadd", "Adds the typed package to the automation row"},
                {"ttbtnremove", "Removes the checked packages from the automation row"},
                {"ttbtnaddinstalled", "If You already have any Chocolatey packages installed, You can add them to the automation row by clicking here"},
                {"ttbtnonline", "Open the integrated Web browser to navigate through the online list of packages"},
                {"ttbtninstall", "It will install all checked packages from the automation row"},
                {"ttbtnupdate", "It will upgrade all checked packages from the automation row"},
                {"ttbtnuninstall", "It will uninstall all checked packages from the automation row"},
                {"ttbtninstallchoco", "Run the powershell script to download and install Chocolatey if You haven't done It yet. NOTE: This program will not work without Chocolatey installed on your computer."},
                {"ttchkforcedependencies", "When Installing, this adds --force and --force-dependencies commandline arguments to choco command. When Uninstalling this adds --remove-dependencies to choco command."},
                {"ttchkshowconsole", "If checked, the command prompt (terminal) will be displayed to You while running the Choco commands(Installing, upgrading, Uninstalling)."},
                { "mboxchocolateynotinstalledtext", "Chocolatey is not installed on your system, please click on \"Install Chocolatey\" before anything else! Chocolatra does not work without Chocolatey."},
                { "mboxchocolateynotinstalledtitle", "Chocolatey not found"}
            };

            string json = JsonConvert.SerializeObject(Lines, Formatting.Indented);
            File.WriteAllText(Application.StartupPath + "\\lang_dict.json", json, Encoding.UTF8);
        }


        public static Dictionary<string, string> load()
        {
            if (!File.Exists(Application.StartupPath + "\\lang_dict.json"))
            {
                create();
            }

            string jsonText = File.ReadAllText(Application.StartupPath + "\\lang_dict.json", Encoding.UTF8);
            Lines = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonText);
            return Lines;
        }
    }
}
/*
  { "frmmaintitle", "Chocolatra - O automatizador de pacotes Chocolatey" },
                {"lblautomationrow", "Fila de automação"},
                { "pleasewait", "Procurando pacotes, por favor aguarde..." },
                { "chkcheckall", "Selecionar todos" },
                {"txtaddcommandhint", "Nome do pacote para adicionar"},
                {"btnadd", "Adicionar"},
                {"btnremoveselected", "Remover selecionados"},
                {"btnaddinstalled", "Adicionar pacotes instalados"},
                {"btnonlinesearch", "Buscar online"},
                {"lblactions", "Ações"},
                {"btninstallchoco", "Instalar Chocolatey"},
                {"btnuninstallchoco", "Desinstalar Chocolatey"},
                {"btninstall", "Instalar pacotes"},
                {"btnuninstall", "Desinstalar pacotes"},
                {"btnupgrade", "Atualizar pacotes"},
                {"chkforcedependencies", "Forçar dependências"},
                {"lblmore", "Mais"},
                {"chkshowconsole", "Mostrar console do Chocolatey"},
                {"mboxuninstallchocotext", "Tem certeza de que deseja desinstalar Chocolatey do seu sistema? O Chocolatra não funcionará corretamente até que você reinstale-o"},
                {"mboxuninstallchocotitle", "Você realmente deseja desinstalar?"},
               
     
     */
