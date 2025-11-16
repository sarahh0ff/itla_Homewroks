using Consultorio.Application.Dtos;
using Consultorio.Application.Service;
using Consultorio.Domain.Entities;
using Consultorio.Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;

namespace Consultorio.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteController : ControllerBase


    {
        private readonly ConsultorioDbContext _context;

        public PacienteController(ConsultorioDbContext context)
        {
            _context = context;
        }

        [HttpPost("Create")]
        public IActionResult Create([FromBody] Medicodto medicodto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var medico = new Medico
            {
                Name = medicodto.Name,
                Lastname = medicodto.Lastname,
                Especialidad = medicodto.Especialidad,
                Email = medicodto.Email,
                PhoneNumber = medicodto.PhoneNumber,
                CedulaProfesional = medicodto.CedulaProfesional,
                FechaContratacion = medicodto.FechaContratacion,
                Gender = medicodto.Gender,
                Address = medicodto.Address
            };

            _context.Medicos.Add(medico);
            _context.SaveChanges();

            return Ok(new { id = medico.Id, message = "Médico creado exitosamente" });
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var medicos = _context.Medicos.ToList();
            return Ok(medicos);
        }
    }
}
