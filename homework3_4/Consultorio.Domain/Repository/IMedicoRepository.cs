using Consultorio.Domain.Entities;

namespace Consultorio.Domain.Repository
{
    public interface IMedicoRepository
    {
        Task<IEnumerable<Medico>> GetAll();
        Task<Medico?> GetById(int id);
        Task Add(Medico medico);
        Task Update(Medico medico);
        Task Delete(int id);
    }
}
