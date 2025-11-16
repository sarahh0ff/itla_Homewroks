using Consultorio.Domain.Repository;
using Consultorio.Infrastructure.Context;
using System.Threading.Tasks;

namespace Consultorio.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ConsultorioDbContext _context;

        public UnitOfWork(
            ConsultorioDbContext context,
            IMedicoRepository medicoRepository)
        {
            _context = context;
            Medicos = medicoRepository;
           
        }

        public IMedicoRepository Medicos { get; }

       

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
