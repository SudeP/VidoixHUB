var vId = '';
var divytPlayer = '';
var iframe_api = '';
var routed = false;
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
    var crrloc = window.location.href;
    if (
        (hasText('502') && hasText('Error') && hasText('Cloudflare'))
        ||
        (hasText('500') && hasText('Internal Server Error'))
    ) {
        console.log('detected an error');
        ErrorJS();
    } else {
        console.log('not error');
        if (crrloc.startsWith('https://www.vidoix.com/login')) {
            loginJS();
        } else if (crrloc.startsWith('https://www.vidoix.com/youtube')) {
            videoJS();
        } else if (crrloc.startsWith('https://www.vidoix.com/dashboard')) {
            mainJS();
        } else if (crrloc.startsWith('https://www.vidoix.com')) {
            if ($('a[href="/logout"]').length > 0 && $('#filterCoins').length > 0 && $('#loadMoreVideo').length > 0) {
                mainJS();
            } else {
                homeJS();
            }
        } else {
            window.location.replace('https://www.vidoix.com');
        }
    }
}
async function ErrorJS() {
    await sleep(2000);
    var secSTR = '{{errorWaitTime}}';
    var second = parseInt(secSTR);
    for (; second > -1; second--) {
        $('body').html(second.toString() + ' saniye sonra yeniden yönlendiriliceksiniz')
        await sleep(1 * 1000);
    }
    window.location.reload();
}
function homeJS() {
    $('a[href="https://www.vidoix.com/login"]')[0].click();
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
    var first = $('#loadMoreVideo > div > a:first');
    if (first.length > 0) {
        first[0].click();
    } else {
        if ($('#filterSecond > i').length > 0) {
            $('#filterCoins').click();
        } else {
            $('#filterSecond').click();
        }
    }
}
function videoJS() {
    document.querySelector('[src="https://www.youtube.com/iframe_api"]').remove();
    document.getElementById('www-widgetapi-script').remove();
    document.getElementById('ytPlayer').remove();


    player = null;
    window["YT"] = null;
    window["YTConfig"] = null;


    divytPlayer = document.createElement('div');
    divytPlayer.id = "ytPlayer";
    document.querySelector('.embed-responsive').appendChild(divytPlayer);


    vId = onYouTubeIframeAPIReady.toString();
    vId = vId.split('videoId: \'')[1];
    vId = vId.split('\',')[0];

    eval('onYouTubePlayerStateChange =' +
        onYouTubePlayerStateChange
            .toString()
            .replace('interval = window.setInterval("YouTubePlaying()", 100)', 'window.clearInterval(interval);interval = window.setInterval("YouTubePlaying()", 100);')
    );

    eval('YouTubePlaying =' +
        YouTubePlaying
            .toString()
            .replace(/(?:\\[rn]|[\r\n\t]+)+/g, "")
            .replace(`if (roundedPlayed == length) {document.getElementById("other_video").style.display = "block"}`, `if ((parseInt(length / 15) === parseInt(roundedPlayed / 15) || roundedPlayed >= length) && routed === false) {routed = true; var others = $('#loadMoreSuggest > div:nth-child(1) > a'); if (others.length > 0) others[0].click(); else $('.page-sidebar .page-logo a')[0].click();}`)
    );


    onYouTubeIframeAPIReady = function onYouTubeIframeAPIReady() {
        player = new YT.Player('ytPlayer', {
            height: '270',
            width: '480',
            videoId: vId,
            events: {
                'onStateChange': onYouTubePlayerStateChange,
                'onReady': onReady,
                'onError': onError
            }
        });
    }

    iframe_api = document.createElement('script');
    iframe_api.src = "https://www.youtube.com/iframe_api";
    iframe_api.type = "text/javascript";
    iframe_api.id = "iframe_api";
    document.getElementsByTagName("head")[0].appendChild(iframe_api);
}
function onError(event) {
    console.log(event);
    $('a:contains("Geç")')[0].click();
}
function onReady(event) {
    player.mute();
    player.playVideo();
}

if (document.readyState !== 'loading') {
    inithome();
} else {
    document.addEventListener('DOMContentLoaded', function () {
        console.log('DOMContentLoaded RUNED');
        inithome();
    });
}