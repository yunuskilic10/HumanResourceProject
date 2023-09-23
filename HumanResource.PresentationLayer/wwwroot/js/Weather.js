
    $(document).ready(function () {
        // Sayfa yüklendiğinde konum bilgisini al
        getLocation();
        });

    function getLocation() {
            if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(function (position) {
            var latitude = position.coords.latitude;
            var longitude = position.coords.longitude;

            // Hava durumu sorgusu için OpenWeatherMap API'sini kullanın
            var apiKey = '44376d44e7b7eed53bde971c2caeb175'; // OpenWeatherMap API anahtarınızı buraya ekleyin
            var apiUrl = 'https://api.openweathermap.org/data/2.5/weather?lat=' + latitude + '&lon=' + longitude + '&appid=' + apiKey;

            $.getJSON(apiUrl, function (data) {
                var temperature = Math.round(data.main.temp - 273.15); // Kelvin'i Celsius'a çevirin
                var locationName = data.name;
                var iconCode = data.weather[0].icon;
                var iconUrl = 'http://openweathermap.org/img/w/' + iconCode + '.png';

                $("#locationName").text(locationName);
                $("#temperature").text(temperature);
                $("#weatherIcon").attr("src", iconUrl).attr("alt", "Hava Durumu İkonu");
            });
        });
            } else {
        $("#locationInfo").html("Tarayıcınız konum bilgisini desteklemiyor.");
            }
        }
