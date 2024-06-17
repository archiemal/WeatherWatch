using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace WeatherWatch
{
    internal class WeatherFetch
    {
        String location;
        public async Task<JObject> GetJsonData(String location)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiKey = "[ENTER API KEY HERE]";
                string units = "metric";
                string url = $"http://api.openweathermap.org/data/2.5/weather?q={location}&appid={apiKey}&units={units}"; // This is the URL that pulls data from OpenWeatherMap's API
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode) { // Checks if the response was a success and returns the JSON file if it is
                string weatherJson = await response.Content.ReadAsStringAsync();
                    return JObject.Parse(weatherJson);
            }
                else
                {
                    return null;
                }
            }
        }
    }
}
