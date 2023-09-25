using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Domain.Entities.Services
{
    public interface IUserService
    {
        Task<User> Save(string name, DateTime birthDate, string cpf);
        Task<List<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task<User> Update(int id, string name, string cpf, DateTime birthDate);
        Task Delete(int id);
    }
}
