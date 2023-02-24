using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entidades
{
    public class Prestamo
    {
        public int ID { get; set; }
        public string Numero { get; set; }
        public DateTime fecha { get; set; }
        public decimal Importe { get; set; }
        public decimal Tasa { get; set; }
        public int cuotas { get; set; }
        public DateTime FechaDeposito { get; set; }
        public int IDCliente { get; set; }
    }
}
