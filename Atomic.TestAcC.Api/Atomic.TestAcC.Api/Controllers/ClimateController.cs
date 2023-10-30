using Atomic.Test.AeC.Domain.Entities;
using Atomic.Test.AeC.Domain.Service;
using Microsoft.AspNetCore.Mvc;
using TestAeC.ApiBrasil;

namespace Atomic.TestAcC.Api.Controllers
{
    [ApiController]
    [Route("climate")]
    public class ClimateController : ControllerBase
    {
        private readonly IAirportService _airportService;
        private readonly ICityService _cityService;
        private readonly IClimateConsultation _climateConsultation;

        public ClimateController(IAirportService airportService, ICityService cityService, IClimateConsultation climateConsultation)
        {
            _airportService = airportService;
            _cityService = cityService;
            _climateConsultation = climateConsultation;
        }

        [HttpGet]
        [Route("airport/{id}")]
        public async Task<IActionResult> GetAirportWeather([FromRoute] int id)
        {
            var aeroporto = await _airportService.GetAirportWeather(id);
            return Ok(aeroporto);
        }

        [HttpGet]
        [Route("airport-condicao/{codigoIcao}")]
        public async Task<IActionResult> GetResponseAirportWeather([FromRoute] string codigoIcao)
        {
            var airportWeather = await _climateConsultation.AirportClimateConsultation(codigoIcao);
            await _airportService.Save(airportWeather.codigo_icao, airportWeather.atualizado_em, airportWeather.pressao_atmosferica, 
                airportWeather.visibilidade, airportWeather.vento, airportWeather.direcao_vento, airportWeather.umidade, 
                airportWeather.condicao, airportWeather.condicao_Desc, airportWeather.temp);

            return Ok(airportWeather);
        }

        [HttpGet]
        [Route("city/{id}")]
        public async Task<IActionResult> GetCitytWeather([FromRoute] int id)
        {
            var cidade = await _cityService.GetCitytWeather(id);
            return Ok(cidade);
        }

        [HttpGet]
        [Route("city-condicao/{cityCode}")]
        public async Task<IActionResult> GetResponseCityWeather([FromRoute] int cityCode)
        {
            List<CityClimate> listCityClimate = new List<CityClimate>();

            var cityWeathe = await _climateConsultation.CityClimateConsultation(cityCode, listCityClimate);
            await _cityService.Save(cityWeathe.cidade, cityWeathe.estado, cityWeathe.atualizado_em, listCityClimate);

            return Ok(cityWeathe);
        }
    }
}
