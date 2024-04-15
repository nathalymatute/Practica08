using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace webApipractica.Models
{
    public class estados_equipo
    {
        [Key]
        [Display(Name = "ID")]
        public int id_estados_equipo { get; set; }
        [Display(Name = "Descripción")]
        public string?  descripcion { get; set; }
        [Display(Name = "Estado")]
        public string? estado { get; set; }

    }
}
