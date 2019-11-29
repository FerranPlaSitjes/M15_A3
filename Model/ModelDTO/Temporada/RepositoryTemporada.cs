using Model.ModelDTO.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Temporada
{
    class RepositoryTemporada
    {
        hotelEntities context;
        RepositoryClient rc;
        public RepositoryTemporada()
        {
            this.context = rc.context;
        }

        public void afegirTemporada(int codi, string nom, DateTime dataInici, DateTime dataFinal)
        {
            temporada l = new temporada(codi, nom, dataInici, dataFinal);
            context.temporadas.Add(l);
            context.SaveChanges();
        }

        public void modificarTemporada(int codi, string nom, DateTime dataInici, DateTime dataFinal)
        {
            var result = context.temporadas.SingleOrDefault(l => l.codi == codi);
            if (result != null)
            {
                result.codi = codi;
                result.nom = nom;
                result.dataInici = dataInici;
                result.dataFinal = dataFinal;
                context.SaveChanges();
            }
        }

        public void eliminarTemporada(int id)
        {
            var temporada = context.temporadas.Single(c => c.codi == id);
            context.temporadas.Remove(temporada);
            context.SaveChanges();

        }
    }
}
