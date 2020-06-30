<script>
    function initMap() {
        var options = {
        zoom: 12,
            center: {lat: 38.5816, lng: -121.4944 }
        }
        var map = new
            google.maps.Map(document.getElementById('map'), options);
        //listen for click on map
        google.maps.event.addListener(map, 'click', function (event) {
        addMarker({ coords: event.latLng });
        });

        var markers = [
            {
        coords: {lat: 38.6058, lng: -121.5035 },
                iconImage: 'https://developers.google.com/maps/documentation/javascript/examples/full/images/beachflag.png',
                content: '<h4>Discovery Park - Sacramento/American River</h4>'
                    +
                    '<div id="content">' + '<a href="PublicProfileView" target="_blank"><img src="https://png.pngtree.com/png-vector/20190615/ourlarge/pngtree-fish-icon-png-image_1502304.jpg" width="30" height="30" alt: </a>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star"></span>' +

                    '<a href="PublicProfileView" target="_blank"><img src="" width="30" height="30" alt: </a>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star checked"></span>' +
                    '</div>',
            },
            {
        coords: {lat: 38.7848, lng: -121.6170 },
                iconImage: 'https://developers.google.com/maps/documentation/javascript/examples/full/images/beachflag.png',
                content: '<h4>Feather/Sac River - Verona Marina</h4>' +
                    '<div id="content">' + '<a href="PublicProfileView" target="_blank"><img src="https://png.pngtree.com/png-vector/20190615/ourlarge/pngtree-fish-icon-png-image_1502304.jpg" width="30" height="30" alt: </a>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star"></span>' +
                    '</div>',
            },
            {
        coords: {lat: 38.5911, lng: -121.5106 },
                iconImage: 'https://developers.google.com/maps/documentation/javascript/examples/full/images/beachflag.png',
                content: '<h4>Sacrmento River - Broderick</h4>'
                    + '<div id="content">' +
                    '<a href="PublicProfileView" target="_blank"><img src="https://png.pngtree.com/png-vector/20190615/ourlarge/pngtree-fish-icon-png-image_1502304.jpg" width="30" height="30" alt: </a>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star "></span>' +
                    '</div>',
            },
            {
        coords: {lat: 38.600275, lng: -121.480238 },
                iconImage: 'https://developers.google.com/maps/documentation/javascript/examples/full/images/beachflag.png',
                content: '<h4>American River</h4>'
                    + '<div id="content">' +
                    '<a href="PublicProfileView" target="_blank"><img src="https://png.pngtree.com/png-vector/20190615/ourlarge/pngtree-fish-icon-png-image_1502304.jpg" width="30" height="30" alt: </a>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star "></span>' +

                    '<a href="PublicProfileView" target="_blank"><img src="" width="30" height="30" alt: </a>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star "></span>' +
                    '<span class="fa fa-star "></span>' +

                    '<a href="PublicProfileView" target="_blank"><img src="" width="30" height="30" alt: </a>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<a href="PublicProfileView" target="_blank"><img src="" width="30" height="30" alt: </a>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star checked"></span>' +
                    '<span class="fa fa-star "></span>' +
                    '<span class="fa fa-star "></span>' +
                    '<span class="fa fa-star "></span>' +
                    '</div>',

            }
        ];

        for (var i = 0; i < markers.length; {
        addMarker(markers[i]);
        }

        function addMarker(props) {
            var marker = new google.maps.Marker({
        position: props.coords,
                map: map,

            });

            if (props.iconImage) {
        marker.setIcon(props.iconImage);
           e

            if (props.content) {
                var infoWindow = new google.maps.InfoWindow({
        content: props.content
                });
                marker.addListener('click', function () {
        infoWindow.open(map, marker);
                });
            }
        }
    }
</script>
    <script async defer
        src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBJ6fqouu8jpnXGUqQDxWugPXCBMrD41wc&callback=initMap">
    </script>