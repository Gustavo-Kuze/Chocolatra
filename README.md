<img src="https://github.com/Gustavo-Kuze/Chocolatra/blob/master/Chocolatra/assets/chocolatra_icon.png" width="25%" />
<h1>Welcome to Chocolatra</h1>

<h2>An automating tool for <a href="https://chocolatey.org/" target="_blank">Chocolatey</a> scripts</h2>
<p>
I'm currently working on the code, so there's no documentation Yet. However, You can already download and try the latest <a href="https://github.com/Gustavo-Kuze/Chocolatra/releases" target="_blank">release</a>! I Hope You enjoy It!
</p>

<h1>Installation</h1>
Chocolatra needs Chocolatey installed on Your system for It to work. If that's not your case, don't worry. You can Install the Chocolatey CLI from the program by clicking the "INSTALL CHOCOLATEY" button, which will run the original installation script for download and installing automatically.

If You would prefer to install It manually, simply run cmd as administrator and paste the following script on It:
```
@"%SystemRoot%\System32\WindowsPowerShell\v1.0\powershell.exe" -NoProfile -InputFormat None -ExecutionPolicy Bypass -Command "iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))" && SET "PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin"

```
