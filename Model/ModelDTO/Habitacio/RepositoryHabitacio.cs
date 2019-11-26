using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Habitacio
{
    public class RepositoryHabitacio
    {
        hotelEntities context;

        public RepositoryHabitacio(hotelEntities context)
        {
            this.context = context;
        }

        public void afegirHabitacio(int numero, int metresQuadrats, bool terrassa, bool utilitzable, string titol, string caracteristiques, int codiTipus)
        {
            habitacio h = new habitacio(numero, metresQuadrats, terrassa, utilitzable, titol, caracteristiques, codiTipus);
            context.habitacios.Add(h);
            context.SaveChanges();
        }

        public void modificarHabitacio(int numero, int metresQuadrats, bool terrassa, bool utilitzable, string titol, string caracteristiques, int codiTipus)
        {
            var result = context.habitacios.SingleOrDefault(h => h.numero == numero);
            if (result != null)
            {
                result.metresQuadrats = metresQuadrats;
                result.terrassa = terrassa;
                result.utilitzable = utilitzable;
                result.titol = titol;
                result.caracteristiques = caracteristiques;
                result.codiTipus = codiTipus;
                context.SaveChanges();
            }
        }

        public void eliminarHabitacio(int num)
        {
            var hab = context.habitacios.Single(h => h.numero == num);
            context.habitacios.Remove(hab);
            context.SaveChanges();
        }
    }
}
