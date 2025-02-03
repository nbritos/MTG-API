using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicTCGReviewApp.Models
{
    public class Carta
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Costo { get; set; }
        public List<string> Color { get; set; } = new List<string>();
        public string Rareza { get; set; }
        public string Text { get; set; }

        [ForeignKey("Expansion")]
        public int ExpansionId { get; set; }
        public Expansion Expansion { get; set; }
        public int? Fuerza { get; set; } //opcional para criatura
        public int? Resistencia { get; set; } //opcional para criatura
        public int? Lealtad { get; set; } //opcional para planeswalkers
        public string UrlImagen { get; set; }
        public string Artista { get; set; }
        public List<Habilidad> Habilidades { get; set; } = new List<Habilidad>();

    }
}
