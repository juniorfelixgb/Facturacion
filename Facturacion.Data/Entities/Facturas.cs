using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Data.Entities
{
    public class Facturas
    {
        public int NumFactura { get; set; }
        public virtual Clientes Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public virtual ICollection<Detalles> Detalles { get; set; }
    }
}
