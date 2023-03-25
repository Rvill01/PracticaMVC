using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class estados_reservas
    {
        [Key]
        public int estado_res_id { get; set; }
        public string? estado { get; set; }
    }
}
