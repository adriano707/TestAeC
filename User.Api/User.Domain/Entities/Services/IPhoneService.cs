using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Domain.Entities.Services
{
    public interface IPhoneService
    {
        Task<Phone> Save(string ddd, string number);
        Task<List<Phone>> GetAllPhones();
        Task<Phone> GetPhoneById(int id);
        Task<Phone> Update(int id, string ddd, string number);
        Task Delete(int id);
    }
}
