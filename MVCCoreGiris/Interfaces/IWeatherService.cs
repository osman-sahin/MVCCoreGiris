using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreGiris.Interfaces
{
    public interface IWeatherService
    {
        decimal Temperature(string cityName);
    }
}
