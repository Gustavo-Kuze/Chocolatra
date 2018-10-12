<img src="https://github.com/Gustavo-Kuze/Chocolatra/blob/master/Chocolatra/assets/chocolatra_icon.png" width="25%" />
<h6>Instruções em Português no final da página!</h6>

_________

<h5>EN-US</h5>
<h1>Welcome to Chocolatra</h1>

<h2>An automating tool for <a href="https://chocolatey.org/" target="_blank">Chocolatey</a> scripts</h2>
<p>
I'm currently working on the code, so there's no documentation Yet. However, You can already download and try the latest <a href="https://github.com/Gustavo-Kuze/Chocolatra/releases" target="_blank">release</a>! I Hope You enjoy It!
</p>

<h1>Installation</h1>
Chocolatra needs Chocolatey installed on Your system for It to work. If that's not your case, don't worry, You can Install the Chocolatey CLI from the program by clicking the "INSTALL CHOCOLATEY" button, which will run the original installation script for downloading and installing automatically.

Or if You would prefer to install It manually, simply run cmd as administrator and paste the following script on It:
```
@"%SystemRoot%\System32\WindowsPowerShell\v1.0\powershell.exe" -NoProfile -InputFormat None -ExecutionPolicy Bypass -Command "iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))" && SET "PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin"

```
<h1>Usage</h1>

<h2>Installing upgrading and removing packages automatically</h2>

1. First of all, You need to add your packages to the automation row. There are a few ways You can do It:
* You can type the package name on the text field, and press enter or click the add button;

* You can look for installed packages by clicking the "add installed packages" button, which will Choco search in your system for Chocolatey programs;

* Or You can get packages directly from the website by clicking in "Online search". When You do so, a new integrated webbrowser window will open up with the a customized version of Chocolatey Website. You can simply click on the "Add to Chocolatra" buttons to add the packages to the list on your left. You can click the list item to remove It too. When You close the browser, all selected packages will be added to the automation row.

2. Now You have to check all packages that You want to manipulate, and choose an Action, like "Install Packages" for example. The packages Will suffer the Action sequentially, showing You the progress during Its execution.

3. That's It!

<h2>The packages file</h2>
Everytime Chocolatra is open, It will create a "packages" file if not found. This file is a pretty lazy Database for your saved packages.
So, if You want to move Chocolatra to another directory and You want to keep the packages saved, You need to move the packages file along with the main executable and the MaterialSkin.dll!


<h4>The future</h4>
I have plans to add a translation engine to the program, so people can add their own and help me out with that, but please note that I'm the only developer of this tool so far and I don't have much time, so It will take a while until this project is mature enough to become as BIG as I want!

____

<h5>PT-BR</h5>

<h1>Bem-vindo ao Chocolatra</h1>

<h2>Uma ferramenta de automação para scripts <a href="https://chocolatey.org/" target="_blank">Chocolatey</a></h2>
<p>
Atualmente estou trabalhando no código, Então ainda não existe nenhuma documentação. Contudo, você já pode baixar e testar a ultima <a href="https://github.com/Gustavo-Kuze/Chocolatra/releases" target="_blank">versão</a>! Espero que você goste!
</p>

<h1>Instalação</h1>
O Chocolatra precisa do Chocolatey instalado em seu sistema para funcionar. Se este não for o seu caso, não se preocupe, você pode instalar o CLI do Chocolatey através do programa ao clicar no botão "INSTALL CHOCOLATEY", que rodará o código original de instalação para baixá-lo e instalá-lo automaticamente.

Ou caso prefira instalá-lo automaticamente, abra o CMD como administrador e cole o seguinte script:
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


<h4>O futuro</h4>
Tenho planos para adicionar um motor de tradução ao programa, para que o pessoal possa criar suas próprias e me ajudar com isso, mas por favor note que sou o único desenvolvedor dessa ferramenta até o momento e não tenho muito tempo, então vai levar um tempo até que o projeto se torne maduro o suficiente.

