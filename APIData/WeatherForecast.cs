using System;

namespace Capstone_Proj.Models
{
    [Keyless]
    public class WeatherForecast
    {
        [Keyless]
        public Dailyforecast[] DailyForecasts { get; set; }
    }
    [Keyless]
    public class Dailyforecast
    {
        [Keyless]
        public DateTime Date { get; set; }
        public Temperature Temperature { get; set; }
        public Day Day { get; set; }
        public Night Night { get; set; }
    }

    public class Temperature
    {
        public Minimum Minimum { get; set; }
        public Maximum Maximum { get; set; }
    }

    public class Minimum
    {
        public float Value { get; set; }
        public string Unit { get; set; }
    }

    public class Maximum
    {
        public float Value { get; set; }
        public string Unit { get; set; }
    }

    public class Day
    {
        public int Icon { get; set; }
        public string IconPhrase { get; set; }
        public bool HasPrecipitation { get; set; }
    }

    public class Night
    {
        public int Icon { get; set; }
        public string IconPhrase { get; set; }
        public bool HasPrecipitation { get; set; }
    }
}