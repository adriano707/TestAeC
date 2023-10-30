using Atomic.Test.AeC.Domain.Entities;
using Atomic.Test.AeC.Domain.Repositories;

namespace Atomic.Test.AeC.Domain.Service
{
    public class CityService : ICityService
    {
        private readonly IRepository _repository;

        public CityService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<City> GetCitytWeather(int id)
        {
            var cidade = _repository.Query<City>().FirstOrDefault(c => c.Id == id);
            return cidade;
        }

        public async Task<City> Save(string cidade, string estado, DateTime atualizadoEm)
        {
            City city = new City(cidade, estado, atualizadoEm);
            await _repository.InsertAsync(city);
            await _repository.SaveChangeAsync();

            return city;
        }
    }
}
