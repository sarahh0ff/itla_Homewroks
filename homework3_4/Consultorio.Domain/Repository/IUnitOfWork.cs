using System.Threading.Tasks;

namespace Consultorio.Domain.Repository
{
    public interface IUnitOfWork
    {
        IMedicoRepository Medicos { get; }

        Task<int> SaveChangesAsync();
    }
}

