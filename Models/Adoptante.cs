using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace SistemaAdopcionMascotas.Models
{
    [Table("t_adoptante")]
    public class Adoptante
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [NotNull]
        public string? Nombre { get; set; }

         [NotNull]
        public string? Apellido { get; set; }
        public ICollection<Adopcion> Adopciones { get; set; } = new List<Adopcion>(); // Relación uno a muchos
    }
}
