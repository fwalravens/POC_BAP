using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace BAP_Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public List<WeatherForecast> Forecasts { get; set; }=new();
       

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            Random rng = new Random();

            _logger = logger;
            using (StreamReader r = new StreamReader("forecasts.json"))
            {
                string json = r.ReadToEnd();
                Forecasts = JsonConvert.DeserializeObject<List<WeatherForecast>>(json);
            }
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Forecasts;
        }

        [HttpPost]
        public void Post(WeatherForecast payload)
        {
            Forecasts.Add(payload);
            System.IO.File.WriteAllText("forecasts.json",JsonConvert.SerializeObject(Forecasts));
        }
    }
}