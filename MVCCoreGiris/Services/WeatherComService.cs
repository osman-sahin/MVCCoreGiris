using MVCCoreGiris.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreGiris.Services
{
    public class WeatherComService : IWeatherService
    {
        public decimal Temperature(string cityName)
        {
            switch (cityName.ToLower())
            {
                case "ankara":
                    return 30;
                case "istanbul":
                    return 28;
                default:
                    return 25;
            }
        }
    }
}
