using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Pensio
{
    public class pensioDTO
    {

        public pensioDTO(string tipus, decimal preu)
        {
            this.tipus = tipus;
            this.preu = preu;
        }

        public string tipus { get; set; }
        public decimal? preu { get; set; }

        
    }
}
