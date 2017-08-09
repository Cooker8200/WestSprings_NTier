document.getElementById('about_one').style.color = "yellow";
document.getElementById('about_two').style.color = "white";
document.getElementById('about_one').style.marginRight = "1%";

//todo  not working
function HeaderChange() {
    var height = document.getElementsByClassName('about_header');
    for (i = 0; i < height.length; i++) {
        height[i].style.height = "25em"
    }
};