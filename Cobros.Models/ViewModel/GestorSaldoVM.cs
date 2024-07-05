using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobros.Models.ViewModel
{
    public class GestorSaldoVM
    {
        [Display(Name = "Nombres")]
        public string Nombres { get; set; }
        
        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; }
        
        [Display(Name = "Còdigo de Identidad")]
        public string CodigoDeIdentidad { get; }

        [Display(Name = "Saldo")]
        public decimal Saldo { get; }
    }
}
