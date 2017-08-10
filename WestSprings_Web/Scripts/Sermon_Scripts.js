//function not working
function SermonHeaderChange() {
    var background = document.getElementsByClassName('about_header');
    for (i = 0; i < background.length; i++) {
        background[i].style.background = "url(../Images/Headers/bible.jpg)"
    }

    var text = document.getElementsByClassName('about_one');
    for (a = 0; a < text.length; a++) {
        text[a].style.paddingTop = "none";
    }
}

document.getElementById('body').style.background = 'white';
document.getElementById('sermon_header').style.background = "url(../Images/Headers/bible.jpg)";
document.getElementById('sermon_header').style.backgroundSize = "cover";
document.getElementById('about_one').style.paddingTop = "none";
document.getElementById('about_one').style.color = "white";