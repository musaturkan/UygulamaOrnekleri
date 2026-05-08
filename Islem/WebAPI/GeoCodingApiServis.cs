using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Islem.WebAPI
{
    /// <summary>
    /// Bu sınıftaki metot geocoding web apisini kullanarak bir adresi koordinatlara dönüştürür
    /// </summary>
    public class GeoCodingApiServis
    {
        public async Task<DTO.GeoCodingApiRoot> AdresToKoordinatAsync(string sehir)
        {
            ///Bu metot geocoding web apisini kullanarak bir adresi koordinatlara dönüştürür
            ///Örneğin google maps geocoding api kullanılabilir
            ///Bu metotun içinde web api çağrısı yapılır ve gelen sonuç parse edilerek koordinatlar elde edilir
            string servisUrl = $"https://geocoding-api.open-meteo.com/v1/search?name={sehir}&count=1&language=tr&format=json";
            ///yukarıdaki servis url'si geocoding api'sine yapılacak çağrının örneğidir. Bu url'de name parametresi aranacak adresi belirtir, 
            ///count parametresi kaç sonuç döndürüleceğini belirtir, 
            ///language parametresi dil seçeneğini belirtir ve 
            ///format parametresi dönecek verinin formatını belirtir.
            HttpClient httpClient = new HttpClient();
            var response = httpClient.GetStringAsync(servisUrl).Result;
            var sonuc = JsonSerializer.Deserialize<DTO.GeoCodingApiRoot>(response);
            return sonuc;
        }

        public DTO.OpenMeteoApiRoot HavaDurumuGetir(string sehir)
        {
            ///Bu metot hava durumunu getirmek için kullanılabilir
            ///Örneğin openweathermap api kullanılabilir
            ///Bu metotun içinde web api çağrısı yapılır ve gelen sonuç parse edilerek hava durumu bilgisi elde edilir
            ///
            var adres = AdresToKoordinatAsync(sehir).Result;
            string enlem = adres.results.FirstOrDefault().latitude.ToString().Replace(",", ".");
            string boylam = adres.results.FirstOrDefault().longitude.ToString().Replace(",", ".");
            string servisUrl = $"https://api.open-meteo.com/v1/forecast?latitude={enlem}&longitude={boylam}&current_weather=true";
            HttpClient httpClient = new HttpClient();
            var response = httpClient.GetStringAsync(servisUrl).Result;
            var sonuc = JsonSerializer.Deserialize<DTO.OpenMeteoApiRoot>(response);
            return sonuc;
        }

        public DTO.WttrApi.Root HavaDurumuGetir2(string sehir)
        {
            ///Bu metot wttr api'sini kullanarak hava durumunu getirmek için kullanılabilir
            ///Bu metotun içinde web api çağrısı yapılır ve gelen sonuç parse edilerek hava durumu bilgisi elde edilir
            string servisUrl = $"https://wttr.in/{sehir}?format=j1";
            HttpClient httpClient = new HttpClient();
            
            var response = httpClient.GetStringAsync(servisUrl).Result;
            var sonuc = JsonSerializer.Deserialize<DTO.WttrApi.Root>(response);
            return sonuc;
        }
    }
}
