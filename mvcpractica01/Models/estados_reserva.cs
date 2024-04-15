using System.ComponentModel.DataAnnotations;
namespace webApipractica.Models
{
    public class estados_reserva
    {
        [Key]
        [Display(Name = "ID")]
        public int estado_res_id { get; set; }
        [Display(Name = "Estado")]
        public string? estado { get; set; }
    }
}
