using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]

        public string Nombre { get; set; }
        [MaxLength(100)]
        [Required]
        public string Ciudad { get; set; }

        public int Titulos { get; set; }
        [Required]
        public bool Extranjeros { get; set; }
    }
}
