using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAeC.ApiBrasil.Dto
{

    public class CityClimateDto
    {
        public string cidade { get; set; }
        public string estado { get; set; }
        public DateTime atualizado_em { get; set; }
        public List<ClimateDto> clima { get; set; }
    }

    

}
