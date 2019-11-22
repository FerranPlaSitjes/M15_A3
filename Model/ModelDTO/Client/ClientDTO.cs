using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Client
{
    public class clientDTO
    {        
        public clientDTO(int id , string nom , string tipus)
        {
            this.id = id;
            this.nom = nom;
            this.tipus = tipus;
        }

        public int id { get; set; }
        public string nom { get; set; }
        public string tipus { get; set; }
       
    }
}
