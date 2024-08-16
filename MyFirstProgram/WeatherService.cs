using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;





namespace MyFirstProgram
{
    internal class WeatherService
    {

        private const string ApiKey = "a24211faf25f0ab4e2edccf46b43153d"; // OpenWeather API key
        private const string BaseUrl = "http://api.openweathermap.org/data/2.5/weather";


        public static async Task<string> GetWeatherAsync(string city)
        {
            using (HttpClient client = new HttpClient())
            {
                var url = $"{BaseUrl}?q={city}&appid={ApiKey}&units=imperial"; // Use "imperial" for Fahrenheit
                var response = await client.GetStringAsync(url);
                var weatherData = JObject.Parse(response);

                var weatherDescription = weatherData["weather"][0]["description"].ToString();
                var temperature = weatherData["main"]["temp"].ToString();

                return $"It is currently {weatherDescription} with a temperature of {temperature} degrees Fahrenheit in {city}.\n";
            }
        }
    }
}
