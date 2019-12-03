using Model.ModelDTO.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.TipusHabitacio
{
    public class RepositoryTipusHabitacio
    {
        hotelEntities context;
        RepositoryClient rc;

        public RepositoryTipusHabitacio(hotelEntities context)
        {
            this.context = context;
        }

        public void afegirTipusHabitacio(int codi, string tipus, int capacitat)
        {
            tipusHabitacio l = new tipusHabitacio( codi,  tipus,  capacitat);
            context.tipusHabitacios.Add(l);
            context.SaveChanges();
        }

        public tipusHabitacio returnTipusHabitacio(int? id)
        {
            var result = context.tipusHabitacios.Where(a => a.codi. == id).Single();

            return result;
        }

        public List<tipushabitacioDTO> mostrarTipusHabitacio()
        {
            List<tipushabitacioDTO> dades = context.tipusHabitacios.ToList().Select(c => new tipushabitacioDTO(c)).ToList();
            return dades;
        }

        public void modificarTipusHabitacio(int codi, string tipus, int capacitat)
        {
            var result = context.tipusHabitacios.SingleOrDefault(l =>l.codi == codi);
            if (result != null)
            {
                result.codi = codi;
                result.tipus = tipus;
                result.capacitat = capacitat;
                context.SaveChanges();
            }
        }

        public void eliminarTipusHabitacio(int id)
        {
            var tipusHabitacio = context.tipusHabitacios.Single(c => c.codi == id);
            context.tipusHabitacios.Remove(tipusHabitacio);
            context.SaveChanges();

        }
    }

}
