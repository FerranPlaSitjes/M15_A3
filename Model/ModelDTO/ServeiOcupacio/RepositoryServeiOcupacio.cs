using Model.ModelDTO.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.ServeiOcupacio
{
    class RepositoryServeiOcupacio
    {
        hotelEntities context;
        RepositoryClient rc;

        public RepositoryServeiOcupacio()
        {
            this.context = rc.context;
        }

        public void afegirServeiocupacio(int idOcupacio, int idServei, DateTime data, Decimal preu)
        {
            servei_ocupacio l = new servei_ocupacio(idOcupacio, idServei, data, preu);
            context.servei_ocupacio.Add(l);
            context.SaveChanges();
        }

        public void modificarServeiOcupacio(int idOcupacio, int idServei, DateTime data, Decimal preu)
        {
            var result = context.servei_ocupacio.SingleOrDefault(x => (x.idOcupacio == idOcupacio) && (x.idServei == idServei));
            if (result != null)
            {
                result.idOcupacio = idOcupacio;
                result.idServei = idServei;
                result.data = data;
                result.preu = preu;
                context.SaveChanges();
            }
        }

        public void eliminarServeiOcupacio(int idOcupacio, int idServei)
        {
            var serveiOcupacio = context.servei_ocupacio.Single(x => (x.idOcupacio == idOcupacio) && (x.idServei == idServei));
            context.servei_ocupacio.Remove(serveiOcupacio);
            context.SaveChanges();

        }
    }
}
