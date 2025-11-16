using Consultorio.Application.Dtos;
using Consultorio.Application.Contract;
using Consultorio.Domain.Entities;
using Consultorio.Infrastructure.Interface;

namespace Consultorio.Application.Service;

public class MedicoService : IMedicoService
{
    private readonly IMedicoRepository _repository;

    public MedicoService(IMedicoRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Medicodto>> GetAll()
    {
        var medicos = await _repository.GetAll();

        return medicos.Select(m => new Medicodto
        {
            Id = m.Id,
            Name = m.Name,
            Lastname = m.Lastname,
            Especialidad = m.Especialidad,
            Email = m.Email,
        });
    }

    public async Task<Medicodto?> GetById(int id)
    {
        var medico = await _repository.GetById(id);

        if (medico == null) return null;

        return new Medicodto
        {
            Id = medico.Id,
            Name = medico.Name,
            Lastname = medico.Lastname,
            Especialidad = medico.Especialidad,
            Email = medico.Email,
        };
    }

    public async Task Add(Medicodto dto)
    {
        var medico = new Medico
        {
            Name = dto.Name,
            Lastname = dto.Lastname,
            Especialidad = dto.Especialidad,
            Email = dto.Email,
        };

        await _repository.Add(medico);
    }

    public async Task Update(Medicodto dto)
    {
        var medico = new Medico
        {
            Id = dto.Id,
            Name = dto.Name,
            Lastname = dto.Lastname,
            Especialidad = dto.Especialidad,
            Email = dto.Email,
           
        };

        await _repository.Update(medico);
    }

    public async Task Delete(int id)
    {
        await _repository.Delete(id);
    }
}

