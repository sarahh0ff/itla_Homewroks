using System.ComponentModel.DataAnnotations;

namespace Consultorio.API.Models.Dtos
{
    public class Medicodto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        public string Lastname { get; set; } = null!;

        [Required(ErrorMessage = "La especialidad es obligatoria.")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        public string Especialidad { get; set; } = null!;

        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "Debe ser un correo electrónico válido.")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "El número de teléfono es obligatorio.")]
        [Phone(ErrorMessage = "Debe ser un número de teléfono válido.")]
        [MaxLength(15, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = "La cédula profesional es obligatoria.")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        public string CedulaProfesional { get; set; } = null!;

        [Required(ErrorMessage = "La fecha de contratación es obligatoria.")]
        [DataType(DataType.Date)]
        public DateTime FechaContratacion { get; set; }

        [Required(ErrorMessage = "El género es obligatorio.")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        public string Gender { get; set; } = null!;

        [MaxLength(200, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        public string? Address { get; set; }
    }
}

