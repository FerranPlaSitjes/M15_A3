using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Temporada
{
    class temporadaDTO
    {
        public temporadaDTO(int codi, string nom, DateTime dataInici, DateTime dataFinal)
        {
            this.codi = codi;
            this.nom = nom;
            this.dataInici = dataInici;
            this.dataFinal = dataFinal;
        }

        public int codi { get; set; }
        public string nom { get; set; }
        public DateTime? dataInici { get; set; }
        public DateTime? dataFinal { get; set; }

    }
}
