using User.Domain.Entities.Repository;

namespace User.Domain.Entities.Services
{
    public class PhoneService : IPhoneService
    {
        private readonly IRepository _repository;

        public PhoneService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<Phone> Save(string ddd, string number)
        {
            Phone phone = new Phone(ddd, number);

            await _repository.InsertAsync(phone);

            await _repository.SaveChangeAsync();

            return phone;
        }

        public async Task<List<Phone>> GetAllPhones()
        {
            var phones = _repository.Query<Phone>().ToList();
            return phones;
        }

        public async Task<Phone> GetPhoneById(int id)
        {
            var phone = _repository.Query<Phone>().FirstOrDefault(p => p.Id == id);
            return phone;
        }

        public async Task<Phone> Update(int id, string ddd, string number)
        {
            var phone = _repository.Query<Phone>().FirstOrDefault(p => p.Id == id);

            if (phone is not null)
            {
                phone.Update(ddd, number);
                _repository.Update(phone);
                await _repository.SaveChangeAsync();
            }

            return phone;
        }

        public async Task Delete(int id)
        {
            var phone = _repository.Query<Phone>().FirstOrDefault(p => p.Id == id);

            if (phone == null)
            {
                throw new Exception("Telefone não encontrado!");
            }

            _repository.Delete(phone);
            await _repository.SaveChangeAsync();
        }
    }
}
