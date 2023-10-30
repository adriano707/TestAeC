namespace Atomic.TestAcC.Api.Dto
{
    public class AeroportoBRDto
    {
        public int Id { get; set; }
        public string Codigo_icao { get; set; }
        public DateTime Atualizado_em { get; set; }
        public string Pressao_atmosferica { get; set; }
        public string Visibilidade { get; set; }
        public int Vento { get; set; }
        public int Direcao_vento { get; set; }
        public int Umidade { get; set; }
        public string Condicao { get; set; }
        public int Condicao_Desc { get; set; }
    }
}
