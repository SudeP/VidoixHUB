﻿var index = -1;
var qualityInterval = setInterval(function () {
    ++index;
    switch (index) {
        case 0:
            document.querySelector('button.ytp-button.ytp-settings-button').click();
            break;
        case 1:
            document.querySelector('div.ytp-popup.ytp-settings-menu div div').children[document.querySelector('div.ytp-popup.ytp-settings-menu div div').children.length - 1].click();
            break;
        case 2:
            if (document.querySelector('div.ytp-popup.ytp-settings-menu div div.ytp-panel-menu').children[document.querySelector('div.ytp-popup.ytp-settings-menu div div.ytp-panel-menu').children.length - 1].innerText == "Otomatik") {
                document.querySelector('div.ytp-popup.ytp-settings-menu div div.ytp-panel-menu').children[document.querySelector('div.ytp-popup.ytp-settings-menu div div.ytp-panel-menu').children.length - 2].click();
            } else {
                document.querySelector('div.ytp-popup.ytp-settings-menu div div.ytp-panel-menu').children[document.querySelector('div.ytp-popup.ytp-settings-menu div div.ytp-panel-menu').children.length - 1].click();
            }
            break;
        default:
            clearInterval(qualityInterval);
            break;
    }
}, 1 * 1000);