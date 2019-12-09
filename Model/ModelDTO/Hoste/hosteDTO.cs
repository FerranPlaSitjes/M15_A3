using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Hoste
{
    public class hosteDTO
    {
        public hoste c;

        public hosteDTO(hoste c)
        {
            this.dni = c.dni;
            this.nom = c.nom;
            this.cognom = c.cognom;
            this.nacionalitat = c.nacionalitat;
            this.telefon = c.telefon;
            this.cp = c.cp;
            this.poblacio = c.poblacio;
        }

        public hosteDTO(string dni, string nom, string cognom, string nacionalitat, string telefon, string cp, string poblacio)
        {
            this.dni = dni;
            this.nom = nom;
            this.cognom = cognom;
            this.nacionalitat = nacionalitat;
            this.telefon = telefon;
            this.cp = cp;
            this.poblacio = poblacio;
        }

        public string dni { get; set; }
        public string nom { get; set; }
        public string cognom { get; set; }
        public string nacionalitat { get; set; }
        public string telefon { get; set; }
        public string cp { get; set; }
        public string poblacio { get; set; }       

    }
}
