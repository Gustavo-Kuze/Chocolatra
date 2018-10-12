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
    };
    createContainer();