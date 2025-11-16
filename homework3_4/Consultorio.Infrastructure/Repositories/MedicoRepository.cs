    using Consultorio.Domain.Entities;
    using Consultorio.Infrastructure.Interface;
    using Consultorio.Infrastructure.Context;
    using Microsoft.EntityFrameworkCore;

    namespace Consultorio.Infrastructure.Repositories
    {
        public class MedicoRepository : IMedicoRepository
        {
            private readonly ConsultorioDbContext _context;

            public MedicoRepository(ConsultorioDbContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<Medico>> GetAll()
            {
                return await _context.Medicos.ToListAsync();
            }

            public async Task<Medico?> GetById(int id)
            {
                return await _context.Medicos.FirstOrDefaultAsync(m => m.Id == id);
            }

            public async Task Add(Medico medico)
            {
                _context.Medicos.Add(medico);
                await _context.SaveChangesAsync();
            }

            public async Task Update(Medico medico)
            {
                _context.Medicos.Update(medico);
                await _context.SaveChangesAsync();
            }

            public async Task Delete(int id)
            {
                var medico = await _context.Medicos.FindAsync(id);

                if (medico is null) return;

                _context.Medicos.Remove(medico);
                await _context.SaveChangesAsync();
            }
        }
    }


