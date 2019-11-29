using Model.ModelDTO.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.LineaFactura
{
    public class RepositoryLiniaFactura
    {
        hotelEntities context;
        RepositoryClient rc;
        public RepositoryLiniaFactura()
        {
            this.context = rc.context;
        }

        public void afegirLiniaFactura(int nFactura, int nLinia, int quantitat, string descripcio, decimal import)
        {
            linia_factura l = new linia_factura(nFactura, nLinia, quantitat, descripcio, import);
            context.linia_factura.Add(l);
            context.SaveChanges();
        }

        public void modificarLiniaFactura(int nFactura, int nLinia, int quantitat, string descripcio, decimal import)
        {
            var result = context.linia_factura.SingleOrDefault(x => (x.nLinia == nLinia) && (x.nFactura == nFactura));
            if (result != null)
            {
                result.nFactura = nFactura;
                result.nLinia = nLinia;
                result.quantitat = quantitat;
                result.descripcio = descripcio;
                result.import = import;
                context.SaveChanges();
            }
        }

        public void eliminarLiniaFactura(int nFactura, int nLinia)
        {
            var linia_factura = context.linia_factura.Single(x => (x.nLinia == nLinia) && (x.nFactura == nFactura));
            context.linia_factura.Remove(linia_factura);
            context.SaveChanges();
        }
    }
}
