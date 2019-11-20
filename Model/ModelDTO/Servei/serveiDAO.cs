using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Servei
{
    class serveiDTO
    {
        public serveiDTO(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        public int id { get; set; }
        public string nom { get; set; }
    }
}
