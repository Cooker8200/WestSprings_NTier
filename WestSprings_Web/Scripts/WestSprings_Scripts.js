$(document).ready(function () {

    //hidden navbar function
    $(window).scroll({
        previousTop: 0
    },

function () {
    var currentTop = $(window).scrollTop();
    if (currentTop < this.previousTop) {
        $("#nav").fadeIn();
    }
    else {
        $("#nav").fadeOut();
    }
    this.previousTop = currentTop;
});


})