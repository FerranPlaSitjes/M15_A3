using Model.ModelDTO.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model.ModelDTO.Ocupacio
{
    public class RepositoryOcupacio
    {
        hotelEntities context;

        public RepositoryOcupacio(hotelEntities context)
        {
            this.context = context;
        }

        public List<ocupacioDTO> mostrarOcupacions()
        {
            List<ocupacioDTO> dades = context.ocupacios.ToList().Select(o => new ocupacioDTO(o)).ToList();
            return dades;
        }

        public void afegirOcupacio(DateTime dataInici, DateTime dataFinal, int nHabitacioFk, string tipusPensioFk)
        {
            ocupacio o = new ocupacio(dataInici, dataFinal, nHabitacioFk, tipusPensioFk);
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

        public ocupacioDTO ocupacioDTOFromRow(DataGridViewCellCollection row)
        {
            return new ocupacioDTO((DateTime)row["dataInici"].Value, (DateTime)row["dataFinal"].Value, (int)row["nHabitacioFk"].Value, (string)row["tipusPensioFk"].Value);
        }
    }
}
