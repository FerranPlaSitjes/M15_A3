using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.TipusHabitacio
{
    public class tipushabitacioDTO
    {
        private tipusHabitacio c;

        public tipushabitacioDTO(tipusHabitacio c)
        {
            this.codi = c.codi;
            this.tipus = c.tipus;
            this.capacitat = c.capacitat;
        }

        public tipushabitacioDTO(int codi, string tipus, int capacitat)
        {
            this.codi = codi;
            this.tipus = tipus;
            this.capacitat = capacitat;
        }

        public int codi { get; set; }
        public string tipus { get; set; }
        public int? capacitat { get; set; }
    }
}
