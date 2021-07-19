using BackendService.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendService.Services.Interfaces
{
    public interface IWeatherService
    {
      

        IEnumerable<WeatherForecast> FindAll();
        WeatherForecast FindOne(int id);
        int Insert(WeatherForecast forecast);
        bool Update(WeatherForecast forecast);
        //int Delete(int id);

        IEnumerable<WeatherForecast> getWeatherUpdate();
    }
}
