﻿using Capstone_Proj.Interfaces;
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
        //public async Task<> GetCurrentWeather()
        //{
        //    HttpRequestMessage request = new HttpRequestMessage();
        //    string url = $"";
        //    HttpClient client = new HttpClient();
        //    client.DefaultRequestHeaders.Add("");
        //    client.DefaultRequestHeaders.Add("", APIKeys.OpenMusicSearchKey);

        //    HttpResponseMessage response = await client.GetAsync(url);

        //    if (response.IsSuccessStatusCode)
        //    {
        //        string json = await response.Content.ReadAsStringAsync();
        //          = JsonConvert.DeserializeObject<>(json);
        //        return ();
        //    }
        //    return null;
        //}
    }
}
