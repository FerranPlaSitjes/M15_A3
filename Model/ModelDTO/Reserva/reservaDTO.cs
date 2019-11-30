using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Reserva
{
    public class reservaDTO
    {
        public reservaDTO(int id, DateTime dataInici, DateTime dataFinal, decimal preuTotal, decimal bestreta, string pensioFk, int idClientFk)
        {
            this.id = id;
            this.dataInici = dataInici;
            this.dataFinal = dataFinal;
            this.preuTotal = preuTotal;
            this.bestreta = bestreta;
            this.pensioFk = pensioFk;
            this.idClientFk = idClientFk;
        }

        public reservaDTO(reserva r)
        {
            this.id = r.id;
            this.dataInici = r.dataInici;
            this.dataFinal = r.dataFinal;
            this.preuTotal = r.preuTotal;
            this.bestreta = r.bestreta;
            this.pensioFk = r.pensioFk;
            this.idClientFk = r.idClientFk;
        }

        public int id { get; set; }
        public DateTime? dataInici { get; set; }
        public DateTime? dataFinal { get; set; }
        public decimal? preuTotal { get; set; }
        public decimal? bestreta { get; set; }
        public string pensioFk { get; set; }
        public int? idClientFk { get; set; }

    }
}
