using BackendService.Models.EntityModel;
using BackendService.Models.ViewModel;
using BackendService.Services.Interfaces;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendService.Services.Implementations
{
    public class WeatherService : IWeatherService
    {
       

        private LiteDatabase _liteDb; 
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public WeatherService(ILiteDbContext liteDbContext)
        {
            _liteDb = liteDbContext.Database;
        }


         public IEnumerable<WeatherForecast> FindAll()
        {
            var result = _liteDb.GetCollection<WeatherForecast>("WeatherForecast")
                .FindAll();
            return result;
        }

        public WeatherForecast FindOne(int id)
        {
            return _liteDb.GetCollection<WeatherForecast>("WeatherForecast")
                .Find(x => x.Id == id).FirstOrDefault();
        }

        public int Insert(WeatherForecast forecast)
        {
            return _liteDb.GetCollection<WeatherForecast>("WeatherForecast")
                .Insert(forecast);
        }

        public bool Update(WeatherForecast forecast)
        {
            return _liteDb.GetCollection<WeatherForecast>("WeatherForecast")
                .Update(forecast);
        }

        //public Boolean Delete(int id)
        //{
        //    return _liteDb.GetCollection<WeatherForecast>("WeatherForecast")
        //        .Delete(x => x.Id == id);
        //}

        public IEnumerable<WeatherForecast> getWeatherUpdate()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
