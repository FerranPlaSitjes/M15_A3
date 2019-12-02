using Model.ModelDTO.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Preu
{
    public class RepositoryPreu
    {
        hotelEntities context;
        RepositoryClient rc;

        public RepositoryPreu(hotelEntities context)
        {
            this.context = rc.context;
        }

        public List<preuDTO> llistar()
        {
            List<preuDTO> dades = context.preus.ToList().Select(p => new preuDTO(p)).ToList();
            return dades;
        }
    }
}
