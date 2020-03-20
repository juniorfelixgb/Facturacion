using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Data.Entities
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }

        public virtual ICollection<Facturas> Facturas { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNac { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
