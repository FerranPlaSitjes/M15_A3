using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Client
{
    public class clientDTO
    {
        private client c;

        public clientDTO(client c)
        {
            this.id = c.id;
            this.nom = c.nom;
            this.tipus = c.tipus;
        }

        public int id { get; set; }
        public string nom { get; set; }
        public string tipus { get; set; }
       
    }
}
