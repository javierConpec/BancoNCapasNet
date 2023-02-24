using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entidades
{
    public class DetalolePrestamo
    {
        public int NumerodeCuota { get; set; }
        public decimal ImporteCuota { get; set; }
        public decimal ImporteInteres { get; set; } 
        public string Estado { get; set; }
        public int IdPrestamo { get; set; }
    }
}
