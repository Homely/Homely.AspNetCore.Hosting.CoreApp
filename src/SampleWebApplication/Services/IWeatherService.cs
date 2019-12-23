using System.Collections.Generic;
using System.Threading.Tasks;

namespace SampleWebApplication.Services
{
    public interface IWeatherService
    {
        Task<IEnumerable<WeatherForecast>> GetWeatherAsync();
    }
}
