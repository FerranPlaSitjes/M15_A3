using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Habitacio
{
    public class habitacioDTO
    {
        
        public habitacioDTO(int numero, int metresQuadrats, bool terrassa, bool utilitzable, string titol, string caracteristiques, int codiTipus)
        {
            this.numero = numero;
            this.metresQuadrats = metresQuadrats;
            this.terrassa = terrassa;
            this.utilitzable = utilitzable;
            this.titol = titol;
            this.caracteristiques = caracteristiques;
            this.codiTipus = codiTipus;
        }

        public int numero { get; set; }
        public int? metresQuadrats { get; set; }
        public bool? terrassa { get; set; }
        public bool? utilitzable { get; set; }
        public string titol { get; set; }
        public string caracteristiques { get; set; }
        public int? codiTipus { get; set; }
        
    }
}
