using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Preu
{
    public class preuDTO
    {

        public preuDTO(preu p)
        {
            this.codiTemporada = p.codiTemporada;
            this.tipusPensio = p.tipusPensio;
            this.codiHabitacio = p.codiTipusHabitacio;
            this.preu = p.preu1;
        }

        public preuDTO(int codiTemporada, string tipusPensio, int codiHabitacio, decimal preu)
        {
            this.codiTemporada = codiTemporada;
            this.tipusPensio = tipusPensio;
            this.codiHabitacio = codiHabitacio;
            this.preu = preu;
        }

        public int codiTemporada { get; set; }
        public string tipusPensio { get; set; }
        public int codiHabitacio { get; set; }
        public decimal? preu { get; set; }

    }
}
