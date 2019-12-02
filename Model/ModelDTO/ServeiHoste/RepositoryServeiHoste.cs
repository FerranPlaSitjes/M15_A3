using Model.ModelDTO.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.ServeiHoste
{
    class RepositoryServeiHoste
    {
        hotelEntities context;
        RepositoryClient rc;

        public RepositoryServeiHoste()
        {
            this.context = rc.context;
        }

        public void afegirServeiHoste(string dnihoste, int idServei, DateTime data, Decimal preu)
        {
            servei_hoste l = new servei_hoste(dnihoste, idServei, data, preu);
            context.servei_hoste.Add(l);
            context.SaveChanges();
        }

        public void modificarServeiHoste(string dniHoste, int idServei, DateTime data, Decimal preu)
        {
            var result = context.servei_hoste.SingleOrDefault(x => (x.dniHoste == dniHoste) && (x.idServei == idServei));
            if (result != null)
            {
                result.dniHoste = dniHoste;
                result.idServei = idServei;
                result.data = data;
                result.preu = preu;
                context.SaveChanges();
            }
        }

        public void eliminarServeiHoste(string dniHoste, int idServei)
        {
            var serveiOcupacio = context.servei_hoste.Single(x => (x.dniHoste == dniHoste) && (x.idServei == idServei));
            context.servei_hoste.Remove(serveiOcupacio);
            context.SaveChanges();

        }
    }
}
