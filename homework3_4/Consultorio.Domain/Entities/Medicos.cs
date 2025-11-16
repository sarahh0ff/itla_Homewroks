

using Consultorio.Domain.Core;  
namespace Consultorio.Domain.Entities
{
    public class Medico : BaseEntity
    {
        public new int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string Especialidad { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string CedulaProfesional { get; set; } = null!;
        public DateTime FechaContratacion { get; set; }
        public string Gender { get; set; } = null!;
        public string? Address { get; set; }
    }
}

