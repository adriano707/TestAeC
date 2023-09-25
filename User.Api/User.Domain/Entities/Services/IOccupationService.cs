namespace User.Domain.Entities.Services
{
    public interface IOccupationService
    {
        Task<Occupation> Save(string nameOccupaition);
        Task<List<Occupation>> GetAllOccupations();
        Task<Occupation> GetOccupationById(int id);
        Task<Occupation> Update(int id, string nameOccupaition);
        Task Delete(int id);
    }
}
