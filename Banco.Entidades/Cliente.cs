﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entidades
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string RazonSocial { get; set; }
        public string NumeroDocumento { get; set; }
        public int IDTipoCliente { get; set; }
        public int IDTipodocumento { get; set; }
        public string Direccion { get; set; }
        public string Referencias { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
