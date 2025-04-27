using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace SistemaAdopcionMascotas.Models
{
    [Table("t_mascota")]
    public class Mascota
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [NotNull]
        public string? Nombre { get; set; }

        [NotNull]
        public int Edad { get; set; }

        [NotNull]
        public string? Tipo { get; set; }

        [NotNull]
        public bool EstaAdoptada { get; set; } = false;

        public Adopcion? Adopcion { get; set; } // Relación uno a uno
    }
}
