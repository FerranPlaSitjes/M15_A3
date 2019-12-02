using Model.ModelDTO.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Pensio
{
    public class RepositoryPensio
    {
        hotelEntities context;
        RepositoryClient rc;
        public RepositoryPensio(hotelEntities context)
        {
            this.context = context;
        }

        public List<pensio> LlistarPensio()
        {
            var result = context.pensios.OrderBy(x => x.tipus).ToList();
            return result;
        }
    }
}
