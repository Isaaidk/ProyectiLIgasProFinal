using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Nombre { get; set; }
        [Required]
        public Posicion posicion { get; set; }

        public enum Posicion
        {

            Defensa,
            Delantero,
            Centrocampista,
            Portero,
            Defensacentral

        }

        [Range(0, 100)]
        [Required]
        public int Edad { get; set; }
        public Equipo? Equipo { get; set; }
        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }
    }
}
