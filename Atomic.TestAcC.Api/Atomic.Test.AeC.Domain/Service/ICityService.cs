using Atomic.Test.AeC.Domain.Entities;

namespace Atomic.Test.AeC.Domain.Service
{
    public interface ICityService
    {
        Task<City> GetCitytWeather(int id);
        Task<City> Save(string cidade, string estado, DateTime atualizadoEm, List<CityClimate> listCityClimate);
    }
}
