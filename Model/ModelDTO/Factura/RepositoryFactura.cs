using Model.ModelDTO.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Factura
{
    public class RepositoryFactura
    {
        hotelEntities context;
        RepositoryClient rc;
        public RepositoryFactura()
        {
            this.context = rc.context;
        }

        public void afegirFactura(int numero, DateTime data, decimal import, string dniHoste)
        {
            factura f = new factura(numero, data, import, dniHoste);
            context.facturas.Add(f);
            context.SaveChanges();
        }

        public void modificarFactura(int numero, DateTime data, decimal import, string dniHoste)
        {
            var result = context.facturas.SingleOrDefault(f => f.numero == numero);
            if (result != null)
            {
                result.data = data;
                result.import = import;
                result.dniHosteFk = dniHoste;
                context.SaveChanges();
            }
        }

        public void eliminarFactura(int numero)
        {
            var factura = context.facturas.Single(f => f.numero == numero);
            context.facturas.Remove(factura);
            context.SaveChanges();
        }
    }
}
