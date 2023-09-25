using User.Domain.Entities.Repository;

namespace User.Domain.Entities.Services
{
    public class AddressService : IAddressService
    {
        private readonly IRepository _repository;

        public AddressService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<Address.Address> GetAddressById(int id)
        {
            var address = _repository.Query<Address.Address>().FirstOrDefault(a => a.Id == id);
            return address;
        }

        public async Task<List<Address.Address>> GetAllAddress()
        {
            var address = _repository.Query<Address.Address>().ToList();
            return address;
        }

        public async Task<Address.Address> CreteAddress(string name, string state, string city, string uf, string district, string number, string complement)
        {
            Address.Address address = new Address.Address(name, state, city, uf, district, number, complement);

            await _repository.InsertAsync(address);
            await _repository.SaveChangeAsync();

            return address;
        }

        public async Task<Address.Address> Update(int id, string name, string state, string city, string uf, string district, string number, string complement)
        {
            Address.Address address = new Address.Address(name, state, city, uf, district, number, complement);

            await _repository.InsertAsync(address);
            await _repository.SaveChangeAsync();

            return address;
        }

        public async Task Delete(int id)
        {
            var address = _repository.Query<Address.Address>().FirstOrDefault(p => p.Id == id);

            if (address == null)
            {
                throw new Exception("Endereço não encontrado!");
            }

            _repository.Delete(address);
            await _repository.SaveChangeAsync();
        }
    }
}
