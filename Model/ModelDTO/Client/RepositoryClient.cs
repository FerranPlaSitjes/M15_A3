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
        public RepositoryClient()
        {
            context = new hotelEntities();
        }
        public void afegirClient(client client)
        {
            context.clients.Add(client);
            context.SaveChanges();
        }
    }
}
