using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Persona
{
    public class personaDTO
    {
        public personaDTO(int id, string dniHoste)
        {
            this.id = id;
            this.dniHoste = dniHoste;
        }
        public int id { get; set; }
        public string dniHoste { get; set; }

    }
}
