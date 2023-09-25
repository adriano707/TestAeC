namespace User.Domain.Entities.Services
{
    public interface IAddressService
    {
        Task<Address.Address> GetAddressById(int id);
        Task<List<Address.Address>> GetAllAddress();
        Task<Address.Address> Update(int id, string name, string state, string city, string uf, string district, string number,
            string complement);
        Task<Address.Address> CreteAddress(string name, string state, string city, string uf, string district, string number, string complement);
        Task Delete(int id);
    }
}
