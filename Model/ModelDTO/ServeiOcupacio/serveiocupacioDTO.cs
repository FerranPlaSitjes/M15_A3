using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.ServeiOcupacio
{
    class serveiocupacioDTO
    {

        public serveiocupacioDTO(int idOcupacio,int idServei, DateTime data, decimal preu)
        {
            this.idOcupacio = idOcupacio;
            this.idServei = idServei;
            this.data = data;
            this.preu = preu;
        }

        public int idOcupacio { get; set; }
        public int idServei { get; set; }
        public DateTime? data { get; set; }
        public decimal? preu { get; set; }
    }
}
