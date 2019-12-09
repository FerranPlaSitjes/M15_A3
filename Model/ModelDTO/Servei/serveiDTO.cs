using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Servei
{
    public class serveiDTO
    {
        public serveiDTO(servei s)
        {
            this.id = s.id;
            this.nom = s.nom;
        }

        public serveiDTO(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        public int id { get; set; }
        public string nom { get; set; }
    }
}
