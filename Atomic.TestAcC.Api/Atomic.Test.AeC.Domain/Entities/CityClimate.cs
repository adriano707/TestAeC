using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atomic.Test.AeC.Domain.Entities
{
    public class CityClimate
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int CidadeId { get; set; }
        public string Condicao { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public int IndiceUv { set; get; }
        public string CondicaoDesc { get; set; }

        public CityClimate()
        {
            
        }

        public CityClimate(DateTime data, string condicao, int min, int max, int indiceUv, string condicaoDesc)
        {
            Data = data;
            Condicao = condicao ?? throw new ArgumentNullException(nameof(condicao));
            Min = min;
            Max = max;
            IndiceUv = indiceUv;
            CondicaoDesc = condicaoDesc ?? throw new ArgumentNullException(nameof(condicaoDesc));
        }
    }
}
