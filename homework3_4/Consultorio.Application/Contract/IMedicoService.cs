using Consultorio.Application.Dtos;

namespace Consultorio.Application.Contract;

public interface IMedicoService
{
    Task<IEnumerable<Medicodto>> GetAll();
    Task<Medicodto?> GetById(int id);
    Task Add(Medicodto dto);
    Task Update(Medicodto dto);
    Task Delete(int id);
}
