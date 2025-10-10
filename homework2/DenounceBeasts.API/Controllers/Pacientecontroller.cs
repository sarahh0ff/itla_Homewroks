using Consultorio.API.Models.Entities;
using DenounceBeasts.Dbcontext; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Consultorio.API.Models.Dtos;

namespace DenounceBeasts.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class MedicoController : ControllerBase
    {
        private readonly ConsultorioDBContex _context;

        public MedicoController(ConsultorioDBContex context)
        {
            _context = context;
        }

        
        [HttpGet("List")]
        public IActionResult GetAllMedicos()
        {
            var medicos = _context.Medicos.ToList();

            var selecmedicos = medicos.Select(m => new Medicodto
            {
                Id = m.Id,
                Name = m.Name,
                Lastname = m.Lastname,
                Email = m.Email,
                Address = m.Address,
                Especialidad = m.Especialidad,
                PhoneNumber = m.PhoneNumber,
                CedulaProfesional = m.CedulaProfesional,
                FechaContratacion = m.FechaContratacion,
                Gender = m.Gender
            }).ToList();

            return Ok(selecmedicos);
        }

        
        [HttpGet("Details/{id}")]
        public IActionResult GetMedicoById(int id)
        {
            var medico = _context.Medicos.FirstOrDefault(m => m.Id == id);
            if (medico == null)
            {
                return NotFound($"Médico con id {id} no encontrado");
            }

            var medicodto = new Medicodto
            {
                Id = medico.Id,
                Name = medico.Name,
                Lastname = medico.Lastname,
                Email = medico.Email,
                Address = medico.Address,
                Especialidad = medico.Especialidad,
                PhoneNumber = medico.PhoneNumber,
                CedulaProfesional = medico.CedulaProfesional,
                FechaContratacion = medico.FechaContratacion,
                Gender = medico.Gender
            };

            return Ok(medicodto);
        }

        
        [HttpPost("Create")]
        public IActionResult Create([FromBody] Medicodto medicodto)
        {
            var medico = new Medico
            {
                Name = medicodto.Name,
                Lastname = medicodto.Lastname,
                Especialidad = medicodto.Especialidad,
                Email = medicodto.Email,
                Address = medicodto.Address,
                PhoneNumber = medicodto.PhoneNumber,
                CedulaProfesional = medicodto.CedulaProfesional,
                FechaContratacion = medicodto.FechaContratacion,
                Gender = medicodto.Gender
            };

            _context.Medicos.Add(medico);
            _context.SaveChanges();

            return Ok(medico.Id);
        }

        
        [HttpPut("Update/{id}")]
        public IActionResult Update(int id, [FromBody] Medicodto medicodto)
        {
            var medico = _context.Medicos.FirstOrDefault(m => m.Id == id);
            if (medico == null)
            {
                return NotFound($"Médico con id {id} no encontrado");
            }

            medico.Name = medicodto.Name;
            medico.Lastname = medicodto.Lastname;
            medico.Email = medicodto.Email;
            medico.Address = medicodto.Address;
            medico.Especialidad = medicodto.Especialidad;
            medico.PhoneNumber = medicodto.PhoneNumber;
            medico.CedulaProfesional = medicodto.CedulaProfesional;
            medico.FechaContratacion = medicodto.FechaContratacion;
            medico.Gender = medicodto.Gender;

            _context.Medicos.Update(medico);
            _context.SaveChanges();

            return NoContent();
        }

        
        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var medico = _context.Medicos.FirstOrDefault(m => m.Id == id);
            if (medico == null)
            {
                return NotFound($"Médico con id {id} no encontrado");
            }

            _context.Medicos.Remove(medico);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
