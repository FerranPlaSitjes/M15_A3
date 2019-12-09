using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.ServeiHoste
{
    class serveihosteDTO
    {
        public serveihosteDTO(string dni,int idServei, DateTime data, decimal preu)
        {
            this.dniHoste= dni;
            this.idServei = idServei;
            this.data = data;
            this.preu = preu;
        }

        public string dniHoste { get; set; }
        public int idServei { get; set; }
        public DateTime? data { get; set; }
        public decimal? preu { get; set; }
    }
}
