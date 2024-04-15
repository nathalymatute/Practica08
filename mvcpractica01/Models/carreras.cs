using System.ComponentModel.DataAnnotations;
namespace webApipractica.Models
{
    public class carreras
    {
        [Key]
        [Display(Name ="ID")]
        public int carrera_id { get; set; }
        [Display(Name = "Nombre de la marca")]
        public string? nombre_carrera { get; set; }
        [Display(Name = "Facultad_id")]
        public int? facultad_id { get; set; }
        [Display(Name = "Estado")]
        public string? estado  { get; set; }
    }
}
