// function addBtnsToCodeTags() {
//     let codes = Array.from(document.getElementsByTagName('code'))
//     codes.forEach(element => {
//         const btn = document.createElement('button')
//         btn.innerText = 'Copy'
//         btn.style.background = '#4e2c01'
//         btn.style.color = '#f5f5f5'
//         btn.style.borderWidth = '0'
//         btn.style.fontSize = '1.3em'
//         element.appendChild(btn)
//     })
// }

(function () {
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
        chocolatrasContainer.style.width = '25%';
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
    addButtonsToCodes()
    createContainer();
})()


function copyPackageToClipboard(text) {
    var input = document.createElement('input');
    input.setAttribute('value', text);
    document.body.appendChild(input);
    input.select();
    var result = document.execCommand('copy');
    document.body.removeChild(input)
    return result;
}


