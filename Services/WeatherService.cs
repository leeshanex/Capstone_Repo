using Capstone_Proj.APIKeys;
using Capstone_Proj.Interfaces;
using Capstone_Proj.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Capstone_Proj.Services
{
    public class WeatherService : IWeatherServices
    {
        public WeatherService()
        {

        }
        public async Task<Weather> GetCurrentWeather()
        {
            HttpRequestMessage request = new HttpRequestMessage();
            string userInput = "95833";
            string postalCode = userInput;
            string url = $"dataservice.accuweather.com/locations/v1/postalcodes/search?apikey={ApiKeys.OpenCurrentWeatherKey}=O&q={postalCode}";
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                 var currentWeather = JsonConvert.DeserializeObject<Weather>(json);
                return (currentWeather);
            }
            return null;
        }

        Task<WeatherService> IWeatherServices.GetCurrentWeather()
        {
            throw new NotImplementedException();
        }
    }
}
