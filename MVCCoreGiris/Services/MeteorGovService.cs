using MVCCoreGiris.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreGiris.Services
{
    public class MeteorGovService : IWeatherService
    {
        public decimal Temperature(string cityName)
        {
            switch (cityName.ToLower())
            {
                case "ankara":
                    return 31;
                case "istanbul":
                    return 30;
                default:
                    return 26;
            }
        }
    }
}
