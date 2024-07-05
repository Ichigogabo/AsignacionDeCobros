using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobros.Models.Model
{
    [Table("Cobros", Schema = "Saldo")]
    public class Cobro
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Saldo")]
        public decimal Saldo { get; }
    }
}
