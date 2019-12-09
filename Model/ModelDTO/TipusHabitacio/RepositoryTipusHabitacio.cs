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

        public RepositoryTipusHabitacio(hotelEntities context)
        {
            this.context = context;
        }

        public List<tipushabitacioDTO> getAll()
        {
            List<tipushabitacioDTO> lth = context.tipusHabitacios.ToList().Select(th => new tipushabitacioDTO(th)).ToList();
            return lth;
        }

        public void afegirTipusHabitacio(int codi, string tipus, int capacitat)
        {
            tipusHabitacio l = new tipusHabitacio( codi,  tipus,  capacitat);
            context.tipusHabitacios.Add(l);
            context.SaveChanges();
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

        public tipusHabitacio getTipusHabitacio(int id)
        {
            tipusHabitacio th = context.tipusHabitacios.Where(x => x.codi == id).SingleOrDefault();
            return th;
        }

        public tipusHabitacio getTipusHabitacioByType(string tipus)
        {
            tipusHabitacio th = context.tipusHabitacios.Where(x => x.tipus == tipus).SingleOrDefault();
            return th;
        }
    }

}
