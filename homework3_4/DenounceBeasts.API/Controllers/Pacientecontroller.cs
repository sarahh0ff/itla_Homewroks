using Consultorio.Application.Dtos;
using Consultorio.Domain.Entities;
using Consultorio.Domain.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Consultorio.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicoController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public MedicoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] Medicodto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var medico = new Medico
            {
                Name = dto.Name,
                Lastname = dto.Lastname,
                Especialidad = dto.Especialidad,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber,
                CedulaProfesional = dto.CedulaProfesional,
                FechaContratacion = dto.FechaContratacion,
                Gender = dto.Gender,
                Address = dto.Address,
                CreatedAt = DateTime.UtcNow,
                IsActive = true
            };

            await _unitOfWork.Medicos.AddAsync(medico);
            await _unitOfWork.SaveChangesAsync();

            return Ok(new
            {
                id = medico.Id,
                message = "Médico creado exitosamente"
            });
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var medicos = await _unitOfWork.Medicos.GetAllAsync();
            return Ok(medicos);
        }
    }
}
