using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Ocupacio
{
    public class RepositoryOcupacio
    {
        hotelEntities context;
        public RepositoryOcupacio(hotelEntities context)
        {
            this.context = context;
        }

        public void afegirOcupacio(int id, DateTime dataInici, DateTime dataFinal, int nHabitacioFk, string tipusPensioFk)
        {
            ocupacio o = new ocupacio(id, dataInici, dataFinal, nHabitacioFk, tipusPensioFk);
            context.ocupacios.Add(o);
            context.SaveChanges();
        }

        public void modificarOcupacio(int id, DateTime dataInici, DateTime dataFinal, int nHabitacioFk, string tipusPensioFk)
        {
            var result = context.ocupacios.SingleOrDefault(o => o.id == id);
            if (result != null)
            {
                result.dataInici = dataInici;
                result.dataFinal = dataFinal;
                result.nHabitacioFk = nHabitacioFk;
                result.tipusPensioFk = tipusPensioFk;
                context.SaveChanges();
            }
        }

        public void eliminarOcupacio(int id)
        {
            var oc = context.ocupacios.Single(o => o.id == id);
            context.ocupacios.Remove(oc);
            context.SaveChanges();
        }
    }
}
