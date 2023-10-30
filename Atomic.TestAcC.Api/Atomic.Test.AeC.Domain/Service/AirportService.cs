using Atomic.Test.AeC.Domain.Entities;
using Atomic.Test.AeC.Domain.Repositories;

namespace Atomic.Test.AeC.Domain.Service
{
    public class AirportService : IAirportService
    {
        private readonly IRepository _repository;

        public AirportService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<HistoricAirportClimate> GetAirportWeather(int id)
        {
            var aeroporto = _repository.Query<HistoricAirportClimate>().FirstOrDefault(a => a.Id == id);
            return aeroporto;
        }

        public async Task<HistoricAirportClimate> Save(string codigoIcao, DateTime atualizadoEm, string pressaoAtmosferica, string visibilidade, int vento,
            int direcaoVento, int Umidade, string Condicao, string CondicaoDesc)
        {
            HistoricAirportClimate airport = new HistoricAirportClimate(codigoIcao, atualizadoEm, pressaoAtmosferica, visibilidade,
                direcaoVento, direcaoVento, Umidade, Condicao, CondicaoDesc);

            await _repository.InsertAsync(airport);
            await _repository.SaveChangeAsync();

            return airport;
        }
    }
}
