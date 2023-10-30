namespace Atomic.TestAcC.Api.Dto
{
    public class CidadeBRDto
    {
        public int Id { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public DateTime Atualziado_em { get; set; }
        public List<ClimaDto> Clima { get; set; }
    }
}
