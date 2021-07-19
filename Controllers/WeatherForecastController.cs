using BackendService.Helpers;
using BackendService.Models.ViewModel;
using BackendService.Services.Implementations;
using BackendService.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IWeatherService _weatherService;


        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherService weatherService)
        {
            _logger = logger;
            _weatherService = weatherService;
        }

        [HttpGet]
        [Route("GetWeatherUpdate")]
        public Payload GetWeatherUpdate()
        {
            return ResponseProcess.MakeResponse(_weatherService.getWeatherUpdate());
        }

        [HttpGet]
        public Payload Get()
        {
            return ResponseProcess.MakeResponse(_weatherService.FindAll());
        }

        [HttpPost]
        [Route("AddWeatherStatus")]
        public Payload AddWeatherStatus([FromBody]WeatherForecast dto)
        {
            return ResponseProcess.MakeResponse(_weatherService.Insert(dto));
        }
    }
}
