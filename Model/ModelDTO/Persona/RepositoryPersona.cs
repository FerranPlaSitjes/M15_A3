using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Persona
{
    public class RepositoryPersona
    {
        hotelEntities context;
        public RepositoryPersona(hotelEntities context)
        {
            this.context = context;
        }

        public void afegirPersona(int id, string dniHoste)
        {
            persona p = new persona(id, dniHoste);
            context.personas.Add(p);
            context.SaveChanges();
        }

        public void modificarPersona(int id, string dniHoste)
        {
            var result = context.personas.SingleOrDefault(p => p.id == id);
            if (result != null)
            {
                result.dniHoste = dniHoste;
                context.SaveChanges();
            }
        }

        public void eliminarPeronsa(int id)
        {
            var persona = context.personas.Single(p => p.id == id);
            context.personas.Remove(persona);
            context.SaveChanges();
        }
    }
}
