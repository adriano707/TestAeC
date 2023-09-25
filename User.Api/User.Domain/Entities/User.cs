using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Domain.Entities
{
    public class User
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string CPF { get; private set; }

        public User(){ }

        public User(string name, DateTime birthDate, string cpf)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            BirthDate = birthDate;
            CPF = cpf ?? throw new ArgumentNullException(nameof(cpf));
        }

        public void Update(string name, DateTime birthDate, string cpf)
        {
            Name = name;
            BirthDate = birthDate;
            CPF = cpf;
        }
    }
}
