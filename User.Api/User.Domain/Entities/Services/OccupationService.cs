using User.Domain.Entities.Repository;

namespace User.Domain.Entities.Services
{
    public class OccupationService : IOccupationService
    {
        private readonly IRepository _repository;

        public OccupationService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<Occupation> Save(string nameOccupaition)
        {
            Occupation occupation = new Occupation(nameOccupaition);

            await _repository.InsertAsync(occupation);

            await _repository.SaveChangeAsync();

            return occupation;
        }

        public async Task<List<Occupation>> GetAllOccupations()
        {
            var occupations = _repository.Query<Occupation>().ToList();
            return occupations;
        }

        public async Task<Occupation> GetOccupationById(int id)
        {
            var occupation = _repository.Query<Occupation>().FirstOrDefault(o => o.Id == id);
            return occupation;
        }

        public async Task<Occupation> Update(int id, string nameOccupaition)
        {
            var occupation = _repository.Query<Occupation>().FirstOrDefault(u => u.Id == id);

            if (occupation is not null)
            {
                occupation.Update(nameOccupaition);
                _repository.Update(occupation);
                await _repository.SaveChangeAsync();
            }

            return occupation;
        }

        public async Task Delete(int id)
        {
            var occupation = _repository.Query<User>().FirstOrDefault(p => p.Id == id);

            if (occupation == null)
            {
                throw new Exception("Ocupação não encontrada!");
            }

            _repository.Delete(occupation);
            await _repository.SaveChangeAsync();
        }
    }
}
