using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Data.Repository
{
    public class FacturacionDbContext : DbContext
    {
        public FacturacionDbContext()
            : base("name=FacturacionDb")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
