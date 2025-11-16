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
              
            };

            return Ok(medicodto);
        }

        
        [HttpPost("Create")]
        public IActionResult Create([FromBody] Medicodto medicodto)
        {
            var medico = new Medicodto
            {
                Name = medicodto.Name,
                Lastname = medicodto.Lastname,
                Especialidad = medicodto.Especialidad,
                Email = medicodto.Email,
               
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
            medico.Especialidad = medicodto.Especialidad;

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
