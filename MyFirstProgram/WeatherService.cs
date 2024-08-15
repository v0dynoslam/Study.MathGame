using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    internal class WeatherService
    {
        private readonly string _apiKey = "public key"; \\hidden for now
        private readonly HttpClient _httpClient;

        public WeatherService()
        {
            _httpClient = new HttpClient();
        }


        public async async Task<string> GetWeatherAsync(string city)
        {
            var url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=metric"; // Using metric units for Celsius
            var response = await _httpClient.GetAsync(url);
            var weatherData = JObject.Parse(response);
            var temperature = weatherData["main"]["temp"].ToString();
            var weatherDescription = weatherData["weather"][0]["description"].ToString();
            return $"The current temperature in {city} is {temperature}°C with {weatherDescription}.";
        }
    }
}
