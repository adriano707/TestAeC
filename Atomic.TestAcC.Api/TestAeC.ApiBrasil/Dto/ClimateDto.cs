using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAeC.ApiBrasil.Dto
{

    public class ClimateDto
    {
        public string data { get; set; }
        public string condicao { get; set; }
        public string condicao_desc { get; set; }
        public int min { get; set; }
        public int max { get; set; }
        public int indice_uv { get; set; }
    }

}
