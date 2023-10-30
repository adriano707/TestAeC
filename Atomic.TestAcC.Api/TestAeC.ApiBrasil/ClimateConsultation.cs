using Newtonsoft.Json;
using System.Security.Claims;
using Atomic.Test.AeC.Domain.Entities;
using TestAeC.ApiBrasil.Dto;

namespace TestAeC.ApiBrasil;

public class ClimateConsultation : IClimateConsultation
{
    private readonly HttpClient _httpClient;

    public ClimateConsultation(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<CityClimateDto> CityClimateConsultation(int idCidade, List<CityClimate> climateList)
    {
        string url = $"https://brasilapi.com.br/api/cptec/v1/clima/previsao/{idCidade}";

        var citytClimateResponse = await GetAsync(url);

        if (citytClimateResponse.IsSuccessStatusCode)
        {
            var climateCityJson = await citytClimateResponse.Content.ReadAsStringAsync();
            var climateCity = JsonConvert.DeserializeObject<CityClimateDto>(climateCityJson);
            return climateCity;

            foreach (var climateDto in climateCity.clima)
            {
                climateList.Add(new CityClimate
                {
                    Data = DateTime.Parse(climateDto.data),
                    Condicao = climateDto.condicao,
                    CondicaoDesc = climateDto.condicao_desc,
                    Min = climateDto.min,
                    Max = climateDto.max,
                    IndiceUv = climateDto.indice_uv
                });
            }

            return climateCity;
        }

        throw new HttpRequestException($"Request error: {citytClimateResponse.StatusCode}");
    }

    public async Task<ClimateAirportDto> AirportClimateConsultation(string codigoIcao)
    {
        string url = $"https://brasilapi.com.br/api/cptec/v1/clima/aeroporto/{codigoIcao}";

        var airportClimateResponse = await GetAsync(url);

        if (airportClimateResponse.IsSuccessStatusCode)
        {
            var climateAirportJson = await airportClimateResponse.Content.ReadAsStringAsync();
            var climateAirportDto = JsonConvert.DeserializeObject<ClimateAirportDto>(climateAirportJson);
            return climateAirportDto;
        }
        
        throw new HttpRequestException($"Request error: {airportClimateResponse.StatusCode}");
    }

    private async Task<HttpResponseMessage> GetAsync(string url)
    {
        using (var handler = new HttpClientHandler())
        {
            handler.UseDefaultCredentials = true;

            using (var httpClient = new HttpClient(handler))
            {
                HttpResponseMessage httpResponse = await httpClient.GetAsync(url);

                return httpResponse;
            }
        }
    }
}