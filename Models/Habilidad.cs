using System.ComponentModel.DataAnnotations;

namespace MagicTCGReviewApp.Models
{
    public class Habilidad
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set;} //opcional, algunas habilidades no tienen nombre
        public string Descripcion { get; set; }
    }
}
