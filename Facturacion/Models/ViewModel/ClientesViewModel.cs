﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facturacion.Models.ViewModel
{
    public class ClientesViewModel
    {
        public int ClienteId { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNac { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}