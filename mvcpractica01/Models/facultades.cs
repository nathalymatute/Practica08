using System.ComponentModel.DataAnnotations;
namespace webApipractica.Models
{
    public class facultades
    {
        [Key]
        [Display(Name = "ID")]
        public int facultad_id { get; set; }
        [Display(Name = "Nombre de la facultad")]
        public string? nombre_facultad { get; set; }
        [Display(Name = "Estado")]
        public string? estado { get; set; }

    }
}
