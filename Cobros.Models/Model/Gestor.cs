using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobros.Models.Model
{
    [Table("Cobros", Schema = "Gestor")]
    public class Gestor
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Nombres")]
        public string Nombres { get; set; }
        [Required]
        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; }
        [Required]
        [Display(Name = "Còdigo de Identidad")]
        public string CodigoDeIdentidad { get;}
    }
}
