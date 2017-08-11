function initMap() {
    var loc = { lat: 38.568251, lng: -90.542090 };
    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 15,
        center: loc
    });
    var marker = new google.maps.Marker({
        position: loc,
        map: map
    });
}