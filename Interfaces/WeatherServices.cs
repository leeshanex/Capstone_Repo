using Capstone_Proj.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone_Proj.Interfaces
{
    public interface IWeatherServices
    {
        Task<WeatherService> GetCurrentWeather();
    }
}
