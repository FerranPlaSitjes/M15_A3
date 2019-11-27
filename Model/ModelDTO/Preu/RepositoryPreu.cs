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
        public RepositoryPreu(hotelEntities context)
        {
            this.context = context;
        }
    }
}
