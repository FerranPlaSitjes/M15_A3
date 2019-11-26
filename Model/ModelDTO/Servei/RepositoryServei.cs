using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Servei
{
    public class RepositoryServei
    {
        hotelEntities context;
        public RepositoryServei(hotelEntities context)
        {
            this.context = context;
        }

        public void afegirServei(string nom)
        {
            servei s = new servei(nom);
            context.serveis.Add(s);
            context.SaveChanges();
        }

        public void modificarServei(int id, string nom)
        {
            var result = context.serveis.SingleOrDefault(s => s.id == id);
            if (result != null)
            {
                result.nom = nom;
                context.SaveChanges();
            }
        }

        public void eliminarServei(int id)
        {
            var servei = context.serveis.Single(s => s.id == id);
            context.serveis.Remove(servei);
            context.SaveChanges();
        }
    }
}
