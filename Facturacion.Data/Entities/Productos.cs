using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Data.Entities
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Foto { get; set; }
        public virtual Categorias Categorias { get; set; }
    }
}
