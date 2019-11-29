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

        public RepositoryPreu()
        {
            this.context = rc.context;
        }
    }
}
