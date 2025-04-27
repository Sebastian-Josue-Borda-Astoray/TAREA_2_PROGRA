using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace SistemaAdopcionMascotas.Models
{
    [Table("t_adopcion")]
    public class Adopcion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [NotNull]
        [ForeignKey("Mascota")]
        public int MascotaId { get; set; }
        public Mascota? Mascota { get; set; }

        [NotNull]
        [ForeignKey("Adoptante")]
        public int AdoptanteId { get; set; }
        public Adoptante? Adoptante { get; set; }

        [NotNull]
        public DateTime FechaAdopcion { get; set; } = DateTime.Now;
    }
}
