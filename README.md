<img src="https://github.com/Gustavo-Kuze/Chocolatra/blob/master/Chocolatra/assets/chocolatra_icon.png" width="25%" />
<h6>An automating tool for <a href="https://chocolatey.org/" target="_blank">Chocolatey</a> scripts</h6>
<h6>Uma ferramenta de automação para scripts <a href="https://chocolatey.org/" target="_blank">Chocolatey</a></h6>

_________

<h5>EN-US</h5>
<h1>Welcome to Chocolatra</h1>




<h1>Installation</h1>

- Make sure that You have all these dependencies installed on your Windows before running Chocolatra:
  
  - <a href="https://www.microsoft.com/en-us/download/details.aspx?id=42642" target="_blank">.NET Framework 4.5.2</a>

- Download the latest <a href="https://github.com/Gustavo-Kuze/Chocolatra/releases" target="_blank">release</a> before anything else!

- Chocolatra needs Chocolatey installed on Your system for It to work. If that's not your case, don't worry, You can Install the Chocolatey CLI from the program by clicking the "INSTALL CHOCOLATEY" button, which will run the original installation script for downloading and installing automatically.

- Or if You would prefer to install It manually, simply run cmd as administrator and paste the following script on It:
```
@"%SystemRoot%\System32\WindowsPowerShell\v1.0\powershell.exe" -NoProfile -InputFormat None -ExecutionPolicy Bypass -Command "iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))" && SET "PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin"

```
<h1>Usage</h1>

<h2>Installing upgrading and removing packages automatically</h2>

1. First of all, You need to add your packages to the automation row. There are a few ways You can do It:

-You can type the package name on the text field, and press enter or click the add button;

- You can look for installed packages by clicking the "add installed packages" button, which will Choco search in your system for Chocolatey programs;

- Or You can get packages directly from the website by clicking in "Online search". When You do so, a new integrated webbrowser window will open up with the a customized version of Chocolatey Website. You can simply click on the "Add to Chocolatra" buttons to add the packages to the list on your left. You can click the list item to remove It too. When You close the browser, all selected packages will be added to the automation row.

2. Now You have to check all packages that You want to manipulate, and choose an Action, like "Install Packages" for example. The packages Will suffer the Action sequentially, showing You the progress during Its execution.

3. That's It!

<h2>The packages file</h2>
Everytime Chocolatra is open, It will create a "packages" file if not found. This file is a pretty lazy Database for your saved packages.
So, if You want to move Chocolatra to another directory and You want to keep the packages saved, You need to move the packages file along with the main executable and the MaterialSkin.dll!

<h2>Translation</h2>
Version 1.6 brings You the new Language Translator engine! Let's see how to set the program to show pt-br (Brazilian Portuguese) strings.

1. Download the language file from <a href="https://github.com/Gustavo-Kuze/Chocolatra/tree/v1.6/Translations">here</a>;

2. Put the file inside the same folder as Chocolatra.exe is contained;

3. Done!

NOTE: Since version 1.6, the program will automatically generate an English lang_dict.json file inside Its execution directory. You can use that file to translate to your own language and send It to me, if You want others to enjoy globalized texts as well.


## Credits

- The credits for the forms styling goes to the <a href="https://github.com/IgnaceMaes/MaterialSkin">MaterialSkin</a> project;

- The credits for the json parsing used on the translator engine goes to the <a href="https://github.com/JamesNK/Newtonsoft.Json">Json.NET</a> project;

____

<h5>PT-BR</h5>

<h1>Bem-vindo ao Chocolatra</h1>


<h1>Instalação</h1>

- Certifique-se de que o seu Windows tem as seguintes dependências instaladas antes de iniciar o Chocolatra:
  
  - <a href="https://www.microsoft.com/en-us/download/details.aspx?id=42642" target="_blank">.NET Framework 4.5.2</a>

- Baixe a ultima <a href="https://github.com/Gustavo-Kuze/Chocolatra/releases" target="_blank">versão</a> antes de mais nada!

- O Chocolatra precisa do Chocolatey instalado em seu sistema para funcionar. Se este não for o seu caso, não se preocupe, você pode instalar o CLI do Chocolatey através do programa ao clicar no botão "INSTALL CHOCOLATEY", que rodará o código original de instalação para baixá-lo e instalá-lo automaticamente.

- Ou caso prefira instalá-lo automaticamente, abra o CMD como administrador e cole o seguinte script:

```
@"%SystemRoot%\System32\WindowsPowerShell\v1.0\powershell.exe" -NoProfile -InputFormat None -ExecutionPolicy Bypass -Command "iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))" && SET "PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin"

```
<h1>Uso</h1>

<h2>Instalando, atualizando e removendo pacotes</h2>

1. Primeiramente, você precisa adicionar os pacotes à fila de automação. Existem algumas formas de fazer isso:
* Você pode digitar o nome do pacote na caixa de texto e pressionar enter ou clicar no botão "ADD";

* Você pode procurar pode pacotes instalados ao clicar em "add installed packages", o que fará uma busca por pacotes Chocolatey instalados préviamente em seu sistema;

* Ou você pode pegar os pacotes diretamente pelo site ao clicar em "Online search". Quando fizer isso, uma nova janela com um navegador integrado se abrirá com uma versão customizada do site do Chocolatey. Você pode então clicar nos botões "Add to Chocolatra"para adicionar os pacotes à lista na esquerda. Você pode remover os itens da lista ao clicar neles.Quando fechar o navegador, os pacotes serão adicionados à fila de automação.

2. Agora você deve marcar todos os pacotes que deseja manipular, e escolher uma Action, como "Install Packages" por exemplo. Os pacotes sofrerão a Action sequencialmente, mostrando todo o progresso durante sua execução.

3. Pronto!

<h2>O arquivo packages</h2>
Toda vez que o Chocolatra é aberto, ele cria um arquivo "packages" caso o mesmo não exista. Este arquivo é um banco de dados simples para guardar os pacotes Chocolatey adicionados à fila de automação.
Então, caso você queira mover o Chocolatra para outro diretório e manter os arquivos salvos, você deve mover o arquivo packages junto com o executável principal e o arquivo MaterialSkin.dll!

<h2>Tradução</h2>
A versão 1.6 traz para você o novo motor de tradução! Vamos ver como configurar o programa para mostrar as strings em pt-br (Português Brasileiro).

1. Baixe o arquivo de idioma <a href="https://github.com/Gustavo-Kuze/Chocolatra/tree/v1.6/Translations">daqui</a>;

2. Coloque o arquivo dentro da mesma pasta que o Chocolatra.exe está contido;

3. Feito!

NOTA: Desde a versão 1.6, o programa irá gerar automaticamente um arquivo lang_dict.json em seu diretório de execução. Você pode usar esse arquivo para traduzir para o seu próprio idioma e enviá-lo para mim, se quiser que outros também aproveitem os textos globalizados.

## Créditos

- Os créditos pela estilização dos formulários vão para o projeto <a href="https://github.com/IgnaceMaes/MaterialSkin">MaterialSkin</a>;

- Os créditos pela conversão Json usada no motor de tradução vão para o projeto <a href="https://github.com/JamesNK/Newtonsoft.Json">Json.NET</a>;
