using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Hoste
{
    public class RepositoryHoste
    {
        hotelEntities context;
        public RepositoryHoste()
        {
            context = new hotelEntities();
        }

        public void afegirHoste(string dni, string nom, string cognom, string nacionalitat, string telefon, string cp, string poblacio, int idReservaFk)
        {
            hoste h = new hoste(dni, nom, cognom, nacionalitat, telefon, cp, poblacio, idReservaFk);
            context.hostes.Add(h);
            context.SaveChanges();
        }

        public void modificarHoste(string dni, string nom, string cognom, string nacionalitat, string telefon, string cp, string poblacio, int idReservaFk)
        {
            var result = context.hostes.SingleOrDefault(h => h.dni == dni);
            if (result != null)
            {
                result.nom = nom;
                result.cognom = cognom;
                result.nacionalitat = nacionalitat;
                result.telefon = telefon;
                result.cp = cp;
                result.poblacio = poblacio;
                result.idReservaFk = idReservaFk;
                context.SaveChanges();
            }
        }

        public void eliminarHoste(string dni)
        {
            var hoste = context.hostes.Single(h => h.dni == dni);
            context.hostes.Remove(hoste);
            context.SaveChanges();
        }
    }
}
