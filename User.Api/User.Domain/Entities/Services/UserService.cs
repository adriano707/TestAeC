using User.Domain.Entities.Repository;

namespace User.Domain.Entities.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository _repository;

        public UserService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<User> Save(string name, DateTime birthDate, string cpf)
        {
            User user = new User(name, birthDate, cpf);

            await _repository.InsertAsync(user);

            await _repository.SaveChangeAsync();

            return user;
        }

        public async Task<List<User>> GetAllUsers()
        {
            var usesr = _repository.Query<User>().ToList();
            return usesr;
        }

        public async Task<User> GetUserById(int id)
        {
            var user = _repository.Query<User>().FirstOrDefault(p => p.Id == id);
            return user;
        }

        public async Task<User> Update(int id, string name, string cpf, DateTime birthDate)
        {
            var user = _repository.Query<User>().FirstOrDefault(u => u.Id == id);

            if (user is not null)
            {
                user.Update(name, birthDate, cpf);
                _repository.Update(user);
                await _repository.SaveChangeAsync();
            }

            return user;
        }

        public async Task Delete(int id)
        {
            var user = _repository.Query<User>().FirstOrDefault(p => p.Id == id);

            if (user == null)
            {
                throw new Exception("Usuário não encontrado!");
            }

            _repository.Delete(user);
            await _repository.SaveChangeAsync();
        }
    }
}
