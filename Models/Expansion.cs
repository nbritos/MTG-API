using System.ComponentModel.DataAnnotations;

namespace MagicTCGReviewApp.Models
{
    public class Expansion
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public List<Carta> Cartas { get; set; } = new List<Carta>();
      
    }
}
