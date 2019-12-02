using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Reserva
{
    public class reservaDTO
    {
        public reservaDTO(int id, DateTime dataInici, DateTime dataFinal, decimal preuTotal, decimal bestreta, string pensioFk, int idClientFk, string dniHosteFk, int idTipusHabitacio)
        {
            this.id = id;
            this.dataInici = dataInici;
            this.dataFinal = dataFinal;
            this.preuTotal = preuTotal;
            this.bestreta = bestreta;
            this.pensioFk = pensioFk;
            this.idClientFk = idClientFk;            
            this.dniHosteFk = dniHosteFk;
            this.idTipusHabitacio = idTipusHabitacio;
        }

        public reservaDTO(reserva r)
        {
            this.id = r.id;
            this.dataInici = r.dataInici;
            this.dataFinal = r.dataFinal;
            this.preuTotal = r.preuTotal;
            this.bestreta = r.bestreta;
            this.pensioFk = r.pensioFk;
            this.dniHosteFk = r.dniHosteFk;
            this.idTipusHabitacio = r.idTipusHabitacio;
            this.idClientFk = r.idClientFk;
        }

        public int id { get; set; }
        public Nullable<System.DateTime> dataInici { get; set; }
        public Nullable<System.DateTime> dataFinal { get; set; }
        public Nullable<decimal> preuTotal { get; set; }
        public Nullable<decimal> bestreta { get; set; }
        public string pensioFk { get; set; }
        public Nullable<int> idClientFk { get; set; }
        public string dniHosteFk { get; set; }
        public Nullable<int> idTipusHabitacio { get; set; }
        
    
        

    }
}
