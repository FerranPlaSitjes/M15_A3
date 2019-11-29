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
        public RepositoryPensio()
        {
            this.context = new hotelEntities();
        }

        public List<pensio> PopulatePensio()
        {
            List<pensio> pensions = context.pensios.OrderBy(x => x.tipus).ToList();

            return pensions;
        }
    }
}
