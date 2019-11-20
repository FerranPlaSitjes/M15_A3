using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Ocupacio
{
    class ocupacioDTO
    {
        public ocupacioDTO(int id, DateTime dataInici, DateTime dataFinal, int nHabitacioFk, string tipusPensioFk)
        {
            this.id = id;
            this.dataInici = dataInici;
            this.dataFinal = dataFinal;
            this.nHabitacioFk = nHabitacioFk;
            this.tipusPensioFk = tipusPensioFk;
        }

        public int id { get; set; }
        public DateTime? dataInici { get; set; }
        public DateTime? dataFinal { get; set; }
        public int? nHabitacioFk { get; set; }
        public string tipusPensioFk { get; set; }

    }
}
