using Capstone_Proj.APIKeys;
using Capstone_Proj.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Capstone_Proj.Services
{
    public class WeatherService
    {
        public WeatherService()
        {

        }
        public async Task<WeatherForecast> GetWeatherForecast()
        {
           
            string url = $"http://dataservice.accuweather.com/forecasts/v1/daily/5day/40223_PC?apikey={ApiKeys.OpenWeatherKey}";
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                WeatherForecast forecast = JsonConvert.DeserializeObject<WeatherForecast>(json);
                
                return forecast;
            }
            else
            {
                return (null);
            }
        }



    }
}
