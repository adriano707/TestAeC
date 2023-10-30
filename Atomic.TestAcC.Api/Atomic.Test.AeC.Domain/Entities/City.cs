namespace Atomic.Test.AeC.Domain.Entities
{
    public class City
    {
        private List<CityClimate> _climaList;
        public int Id { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public DateTime AtualziadoEm { get; private set; }
        public IReadOnlyCollection<CityClimate> ClimaList => _climaList;


        public City()
        {
            
        }

        public City(string cidade, string estado, DateTime atualziadoEm)
        {
            Cidade = cidade ?? throw new ArgumentNullException(nameof(cidade));
            Estado = estado ?? throw new ArgumentNullException(nameof(estado));
            AtualziadoEm = atualziadoEm;
            _climaList = new List<CityClimate>();
        }
    }
}
