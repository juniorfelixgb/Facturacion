using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Data.Entities
{
    public class Detalles
    {
        [Key]
        public int NumDetalle { get; set; }
        [Key]
        public int FacturaId { get; set; }

        public virtual ICollection<Productos> ProductoId { get; set; }

        public virtual Facturas Facturas { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}
