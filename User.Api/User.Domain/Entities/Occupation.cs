using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Domain.Entities
{
    public class Occupation
    {
        public int Id { get; private set; }
        public string NameOccupation { get; private set; }

        public Occupation(){}

        public Occupation(string nameOccupation)
        {
            NameOccupation = nameOccupation ?? throw new ArgumentNullException(nameof(nameOccupation));
        }

        public void Update(string nameOccupation)
        {
            NameOccupation = NameOccupation;
        }
    }
}
