using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorio.Domain.Entities;

namespace Consultorio.Infrastructure.Interface;

public interface IMedicoRepository
{
    Task<IEnumerable<Medico>> GetAll();
    Task<Medico?> GetById(int id);
    Task Add(Medico medico);
    Task Update(Medico medico);
    Task Delete(int id);
}
