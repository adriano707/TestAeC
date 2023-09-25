using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace User.Domain.Entities.Address
{
    public class Address
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Number { get; private set; }
        public string State { get; private set; }
        public string City { get; private set; }
        public string UF { get; private set; }
        public string District { get; private set; }
        public string Complement { get; private set; }

        public Address() { }

        public Address(string name, string state, string city, string uf, string district, string number, string complement)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Number = number ?? throw new ArgumentNullException(nameof(number));
            State = state ?? throw new ArgumentNullException(nameof(state));
            City = city ?? throw new ArgumentNullException(nameof(city));
            UF = uf ?? throw new ArgumentNullException( nameof(uf));
            District = district ?? throw new ArgumentNullException(nameof(district));
            Complement = complement ?? throw new ArgumentNullException(nameof(complement));
        }

        public void Update(string name, string state, string city, string uf, string district, string number,
            string complement)
        {
            Name = name;
            Number = number;
            State = state;
            City = city;
            UF = uf;
            District = district;
            Complement = complement;
        }
    }
}
