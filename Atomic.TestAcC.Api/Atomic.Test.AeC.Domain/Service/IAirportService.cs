using Atomic.Test.AeC.Domain.Entities;

namespace Atomic.Test.AeC.Domain.Service
{
    public interface IAirportService
    {
        Task<HistoricAirportClimate> GetAirportWeather(int id);
        Task<HistoricAirportClimate> Save(string codigoIcao, DateTime atualizadoEm, string pressaoAtmosferica, string visibilidade, int vento, int direcaoVento, int Umidade, string Condicao, string CondicaoDesc);
    }
}
