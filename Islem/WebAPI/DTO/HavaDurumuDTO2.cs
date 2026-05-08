using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islem.WebAPI.DTO.WttrApi
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AreaName
    {
        public string value { get; set; }
    }

    public class Astronomy
    {
        public string moon_illumination { get; set; }
        public string moon_phase { get; set; }
        public string moonrise { get; set; }
        public string moonset { get; set; }
        public string sunrise { get; set; }
        public string sunset { get; set; }
    }

    public class Country
    {
        public string value { get; set; }
    }

    public class CurrentCondition
    {
        public string FeelsLikeC { get; set; }
        public string FeelsLikeF { get; set; }
        public string cloudcover { get; set; }
        public string humidity { get; set; }
        public string localObsDateTime { get; set; }
        public string observation_time { get; set; }
        public string precipInches { get; set; }
        public string precipMM { get; set; }
        public string pressure { get; set; }
        public string pressureInches { get; set; }
        public string temp_C { get; set; }
        public string temp_F { get; set; }
        public string uvIndex { get; set; }
        public string visibility { get; set; }
        public string visibilityMiles { get; set; }
        public string weatherCode { get; set; }
        public List<WeatherDesc> weatherDesc { get; set; }
        public List<WeatherIconUrl> weatherIconUrl { get; set; }
        public string winddir16Point { get; set; }
        public string winddirDegree { get; set; }
        public string windspeedKmph { get; set; }
        public string windspeedMiles { get; set; }
    }

    public class Hourly
    {
        public string DewPointC { get; set; }
        public string DewPointF { get; set; }
        public string FeelsLikeC { get; set; }
        public string FeelsLikeF { get; set; }
        public string HeatIndexC { get; set; }
        public string HeatIndexF { get; set; }
        public string WindChillC { get; set; }
        public string WindChillF { get; set; }
        public string WindGustKmph { get; set; }
        public string WindGustMiles { get; set; }
        public string chanceoffog { get; set; }
        public string chanceoffrost { get; set; }
        public string chanceofhightemp { get; set; }
        public string chanceofovercast { get; set; }
        public string chanceofrain { get; set; }
        public string chanceofremdry { get; set; }
        public string chanceofsnow { get; set; }
        public string chanceofsunshine { get; set; }
        public string chanceofthunder { get; set; }
        public string chanceofwindy { get; set; }
        public string cloudcover { get; set; }
        public string diffRad { get; set; }
        public string humidity { get; set; }
        public string precipInches { get; set; }
        public string precipMM { get; set; }
        public string pressure { get; set; }
        public string pressureInches { get; set; }
        public string shortRad { get; set; }
        public string tempC { get; set; }
        public string tempF { get; set; }
        public string time { get; set; }
        public string uvIndex { get; set; }
        public string visibility { get; set; }
        public string visibilityMiles { get; set; }
        public string weatherCode { get; set; }
        public List<WeatherDesc> weatherDesc { get; set; }
        public List<WeatherIconUrl> weatherIconUrl { get; set; }
        public string winddir16Point { get; set; }
        public string winddirDegree { get; set; }
        public string windspeedKmph { get; set; }
        public string windspeedMiles { get; set; }
    }

    public class NearestArea
    {
        public List<AreaName> areaName { get; set; }
        public List<Country> country { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string population { get; set; }
        public List<Region> region { get; set; }
        public List<WeatherUrl> weatherUrl { get; set; }
    }

    public class Region
    {
        public string value { get; set; }
    }

    public class Request
    {
        public string query { get; set; }
        public string type { get; set; }
    }

    public class Root
    {
        public List<CurrentCondition> current_condition { get; set; }
        public List<NearestArea> nearest_area { get; set; }
        public List<Request> request { get; set; }
        public List<Weather> weather { get; set; }
    }

    public class Weather
    {
        public List<Astronomy> astronomy { get; set; }
        public string avgtempC { get; set; }
        public string avgtempF { get; set; }
        public string date { get; set; }
        public List<Hourly> hourly { get; set; }
        public string maxtempC { get; set; }
        public string maxtempF { get; set; }
        public string mintempC { get; set; }
        public string mintempF { get; set; }
        public string sunHour { get; set; }
        public string totalSnow_cm { get; set; }
        public string uvIndex { get; set; }
    }

    public class WeatherDesc
    {
        public string value { get; set; }
    }

    public class WeatherIconUrl
    {
        public string value { get; set; }
    }

    public class WeatherUrl
    {
        public string value { get; set; }
    }


}
