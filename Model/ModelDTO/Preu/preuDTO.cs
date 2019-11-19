using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Preu
{
    public class preuDTO
    {

        public preuDTO(int codiTemporada, string tipusPensio, int codiHabitacio)
        {
            this.codiTemporada = codiTemporada;
            this.tipusPensio = tipusPensio;
            this.codiHabitacio = codiHabitacio;
        }
        public int codiTemporada { get; set; }
        public string tipusPensio { get; set; }
        public int codiHabitacio { get; set; }

    }
}
