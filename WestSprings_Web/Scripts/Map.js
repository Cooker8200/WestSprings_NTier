function initMap() {
    var uluru = { lat: 38.568251, lng: -90.542090 };
    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 4,
        center: uluru
    });
    var marker = new google.maps.Marker({
        position: uluru,
        map: map
    });
}