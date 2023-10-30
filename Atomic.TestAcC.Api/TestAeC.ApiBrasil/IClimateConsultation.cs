using Atomic.Test.AeC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAeC.ApiBrasil.Dto;

namespace TestAeC.ApiBrasil
{
    public interface IClimateConsultation
    {
        Task<CityClimateDto> CityClimateConsultation(int idCidade, List<CityClimate> climateList);
        Task<ClimaAeroportoDto> AirportClimateConsultation(string codigoIcao);
    }
}
