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
        public RepositoryLiniaFactura()
        {
            context = new hotelEntities();
        }

        public void afegirLiniaFactura(int nFactura, int nLinia, int quantitat, string descripcio, decimal import)
        {
            linia_factura l = new linia_factura(nFactura, nLinia, quantitat, descripcio, import);
            context.linia_factura.Add(l);
            context.SaveChanges();
        }

        public void modificarLiniaFactura(int nFactura, int nLinia, int quantitat, string descripcio, decimal import)
        {
            //var result = context.linia_factura.SingleOrDefault(l => new { l.nFactura, l.nLinia });
            //if (result != null)
            //{
            //    result.nom = nom;
            //    result.tipus = tipus;
            //    context.SaveChanges();
            //}
        }

        public void eliminarClient(int id)
        {
            var client = context.clients.Single(c => c.id == id);
            context.clients.Remove(client);
            context.SaveChanges();
        }
    }
}
