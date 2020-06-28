function getWeatherForecast(selectFiveDay) {
    $.ajax({
        url: "/Guide/WeatherPartial",
        type: 'GET',
        data: { DailyForecast: selectFiveDay },
        succes: function (data) {
            jQuery("#weatherForecast").html(data);
        },
        error: function (error) {
            alert("Error: Please try again.")
        }
    });
}

jQuery(document).ready(function () {
    jQuery("#fiveDayForecast").change(function (index) {
        var selectFiveDay = $(this).val();
        getWeatherForecast(selectFiveDay);
    });
});
