function timeOut(fn, seconds) {
    setTimeout(fn(), seconds * 1000);
}
function setFunctions() {
    alert = function () {
        return true;
    }
    confirm = function () {
        return true;
    }
    window.confirm = function () {
        return true;
    }
    document.hasFocus = function () {
        return true;
    }
}
function inithome() {
    setFunctions();
    whereAmI();
}
function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
}
function hasText(text) {
    try {
        var headings = document.evaluate("//*[contains(., '" + text + "')]", document, null, XPathResult.ANY_TYPE, null);
        if (headings) {
            var thisHeading = headings.iterateNext();
            if (thisHeading) {
                return thisHeading.innerText.includes(text);
            }
        }
    } catch (e) {
    }
    return false;
}
function whereAmI() {
    if (hasText('502') && hasText('Error') && hasText('Your IP') && hasText('Cloudflare') && hasText('Bad gateway') && hasText('Ray ID:')) {
        ErrorJS();
    } else {
        if (window.location.href.startsWith('https://www.vidoix.com/login')) {
            loginJS();
        } else if (window.location.href.startsWith('https://www.vidoix.com/youtube')) {
            videoJS();
        } else if (window.location.href.startsWith('https://www.vidoix.com/dashboard')) {
            mainJS();
        } else if (window.location.href.startsWith('https://www.vidoix.com')) {
            if ($('a[href="/logout"]').length > 0 && $('#filterCoins').length > 0 && $('#loadMoreVideo').length > 0) {
                mainJS();
            } else {
                homeJS();
            }
        } else {
            alert(`Bilinmeyen bir sayfa
        Link : ${window.location.href}
        ScreenShot atın bu yazıyı !!!`);
        }
    }
}
async function ErrorJS() {
    await sleep(3000);
    var second = 60;
    for (; second > -1; second--) {
        $('body').html(second.toString() + ' saniye sonra yeniden yönlendiriliceksiniz')
        await sleep(1000);
    }
    window.location.href = 'https://www.vidoix.com';
}
function homeJS() {
    window.location.href = 'https://www.vidoix.com/login';
}
function loginJS() {
    if ($('#js-login').parent().find('div.alert.alert-danger').length === 0) {
        $('#rememberme').click();
        $('#username').val('{{username}}');
        $('#password').val('{{password}}');
        $('#js-login button').click();
    } else {
        alert(`username veya password hatalı. eğer doğru ise bu yazıyı screenshot yapıp at.
            $('#js-login').parent().find('div.alert.alert-danger').length : ${$('#js-login').parent().find('div.alert.alert-danger').length}`);
    }
}
function mainJS() {
    var counter = 0;
    var loadMoreVideoInterval = setInterval(function () {
        counter += 1;
        try {
            if ($('#loadMoreVideo *').length > 0 || counter >= 5) {
                clearInterval(loadMoreVideoInterval);
                selectVideo();
            }
        } catch (e) {

        }
    }, 1000);
}
function selectVideo() {
    if ($('#loadMoreVideo > div > a:first').length > 0) {
        window.location.href = $('#loadMoreVideo > div > a:first').attr('href');
    } else {
        if ($('#filterSecond > i').length > 0) {
            timeOut(function () {
                $('#filterCoins').click();
            });
        } else if ($('#filterCoins > i').length > 0) {
            timeOut(function () {
                $('#filterSecond').click();
            });
        } else {
            $('#filterCoins').click();
        }
    }
}
function videoJS() {
    $(function () {
        Swal.fire = function () {
            window.location.href = 'https://www.vidoix.com';
        }
    });
    var waitTimes = 0;
    var maxWaitTimes = 15;
    var isPlayerSetInterval = setInterval(function () {
        if (player !== undefined) {
            player.addEventListener('onReady', 'onReady');
            player.addEventListener('onError', 'OnError');
            clearInterval(isPlayerSetInterval);
        } else {
            if (waitTimes == maxWaitTimes) {
                $('a:contains("Geç")')[0].click();
                clearInterval(isPlayerSetInterval);
            } else {
                waitTimes += 1;
            }
        }
    }, 250);
}
function OnError(event) {
    $('a:contains("Geç")')[0].click();
}
function onReady(event) {
    player.mute();
    player.playVideo();
    playing = true;
    isFinish();
}
function isFinish() {
    var isVideoFinishInterval = setInterval(function () {
        if (roundedPlayed >= length) {
            clearInterval(isVideoFinishInterval);
            window.location.href = 'https://www.vidoix.com';
        } else {
            if (parseInt(length / 15) === parseInt(roundedPlayed / 15)) {
                clearInterval(isVideoFinishInterval);
                window.location.href = 'https://www.vidoix.com';
            }
        }
    }, 500);
}
document.addEventListener('DOMContentLoaded', function () {
    inithome();
}, false);