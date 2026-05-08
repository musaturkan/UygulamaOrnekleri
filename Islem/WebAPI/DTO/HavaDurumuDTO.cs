using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islem.WebAPI.DTO
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class OpenMeteoApiCurrentWeather
    {
        public string time { get; set; }
        public int interval { get; set; }
        public double temperature { get; set; }
        public double windspeed { get; set; }
        public int winddirection { get; set; }
        public int is_day { get; set; }
        public int weathercode { get; set; }
    }

    public class OpenMeteoApiCurrentWeatherUnits
    {
        public string time { get; set; }
        public string interval { get; set; }
        public string temperature { get; set; }
        public string windspeed { get; set; }
        public string winddirection { get; set; }
        public string is_day { get; set; }
        public string weathercode { get; set; }
    }

    public class OpenMeteoApiRoot
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public string timezone { get; set; }
        public string timezone_abbreviation { get; set; }
        public double elevation { get; set; }
        public OpenMeteoApiCurrentWeatherUnits current_weather_units { get; set; }
        public OpenMeteoApiCurrentWeather current_weather { get; set; }
    }


}
