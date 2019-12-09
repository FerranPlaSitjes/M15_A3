using Model.ModelDTO.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Temporada
{
    public class RepositoryTemporada
    {
        hotelEntities context;

        public RepositoryTemporada(hotelEntities context)
        {
            this.context = context;
        }

        public List<temporadaDTO> getAll()
        {
            List<temporadaDTO> lt = context.temporadas.ToList().Select(t => new temporadaDTO(t)).ToList();
            return lt;
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

        public temporada getTemporada(int id)
        {
            temporada t = context.temporadas.Where(x => x.codi == id).SingleOrDefault();
            return t;
        }

        public temporada getTemporada(string nom)
        {
            temporada t = context.temporadas.Where(x => x.nom == nom).SingleOrDefault();
            return t;
        }
    }
}
