using System.ComponentModel.DataAnnotations;

namespace webApipractica.Models
{
    public class tipo_equipo
    {
        [Key]
        [Display(Name = "ID")]
        public int id_tipo_equipo { get; set; }
        [Display(Name = "Descripción")]
        public string? descripcion { get; set; }
        [Display(Name = "Estado")]
        public string? estado  { get; set; }

    }
}
