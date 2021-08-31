using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Refit;
using SimpleUI2.Model;

namespace SimpleUI2.DataAccess
{
    public interface IWeatherData
    {
        [Get("/WeatherForecast")]
        Task<List<WeatherModel>> GetWeather();

    }
}
