function MapInitialiser() {
    var map;
    this.init = function (users) {

        var mapCanvas = document.getElementById('map-canvas');
        var myLatlng = new google.maps.LatLng(CURRENTPOSITION.coords.latitude, CURRENTPOSITION.coords.longitude );
        var mapOptions = {
            center: myLatlng,
            zoom: 17,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        }

         map = new google.maps.Map(mapCanvas, mapOptions);
        var marker = new google.maps.Marker({
            position: myLatlng,
            map: map,
            title: "you are here"
        });
        for (var i = 0; i < users.length; i++) {
            var userLatlng = new google.maps.LatLng(users[i].latitude, users[i].longitude);
            var marker = new google.maps.Marker({
                position: userLatlng,
                map: map,
                title: users[i].UserName
            });
        }
    }

    this.getMap = function () {
        return map;
    };
}