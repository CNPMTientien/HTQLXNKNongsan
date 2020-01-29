namespace BehavioralSample.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using MyApplication.WeatherForecasts.Queries.GetWeatherForecasts.Model;
    using MyApplication.WeatherForecasts.Queries.GetWeatherForecasts.Repository;    
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ApiController
    {
        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {            
            return await Mediator.Send(new GetWeatherForecastsQuery());
        }
    }
}
