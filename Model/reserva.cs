//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class reserva
    {
        public reserva(DateTime dataInici, DateTime dataFinal, decimal preuTotal, decimal bestreta, string pensioFk, int idClientFk, int idTipusHabitacio, string dniHoste)
        {
            this.dataInici = dataInici;
            this.dataFinal = dataFinal;
            this.preuTotal = preuTotal;
            this.bestreta = bestreta;
            this.pensioFk = pensioFk;
            this.idClientFk = idClientFk;
            this.idTipusHabitacio = idTipusHabitacio;
            this.dniHosteFk = dniHoste;
        }

        public reserva()
        {
            
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
    
        public virtual client client { get; set; }
        public virtual hoste hoste { get; set; }
        public virtual pensio pensio { get; set; }
        public virtual tipusHabitacio tipusHabitacio { get; set; }
    }
}
