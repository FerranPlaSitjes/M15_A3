using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Client
{
    public class RepositoryClient
    {
        hotelEntities context;
        
        public RepositoryClient(hotelEntities context)
        {
            this.context = context;
        }

        public void afegirClient(client client)
        {            
        }

        public void modificarClient(int id, string nom, string tipus)
        {
            var result = context.clients.SingleOrDefault(c => c.id == id);
            if (result != null)
            {
                result.nom = nom;
                result.tipus = tipus;
                context.SaveChanges();
            }
        }

        public void eliminarClient(int id)
        {
            var client = context.clients.Single(c => c.id == id);
            context.clients.Remove(client);
            context.SaveChanges();
        }
    }
}
