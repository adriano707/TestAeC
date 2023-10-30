namespace Atomic.Test.AeC.Domain.Entities
{
    public class HistoricAirportClimate
    {
        public int Id { get; private set; }
        public string CodigoIcao { get; private set; }
        public DateTime AtualizadoEm { get; private set; }
        public string PressaoAtmosferica { get; private set; }
        public string Visibilidade { get; private set; }
        public int Vento { get; private set; }
        public int DirecaoVento { get; private set; }
        public int Umidade { get; private set;}
        public string Condicao { get; private set; }
        public string CondicaoDesc { get; private set; }
        public int Temp { get; set; }

        public HistoricAirportClimate()
        {
            
        }

        public HistoricAirportClimate(string codigoIcao, DateTime atualizadoEm, string pressaoAtmosferica, string visibilidade, int vento, int direcaoVento, int umidade, string condicao, string condicaoDesc, int temp)
        {
            CodigoIcao = codigoIcao ?? throw new ArgumentNullException(nameof(codigoIcao));
            AtualizadoEm = atualizadoEm;
            PressaoAtmosferica = pressaoAtmosferica ?? throw new ArgumentNullException(nameof(pressaoAtmosferica));
            Visibilidade = visibilidade ?? throw new ArgumentNullException(nameof(visibilidade));
            Vento = vento;
            DirecaoVento = direcaoVento;
            Umidade = umidade;
            Condicao = condicao ?? throw new ArgumentNullException(nameof(condicao));
            CondicaoDesc = condicaoDesc ?? throw new ArgumentNullException(nameof(condicaoDesc));
            Temp = temp;
        }
    }
}
