using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.LineaFactura
{
    public class linia_facturaDTO
    {
        public linia_facturaDTO(int nFactura, int nLinia, int quantitat, string descripcio, decimal import)
        {
            this.nFactura = nFactura;
            this.nLinia = nLinia;
            this.quantitat = quantitat;
            this.descripcio = descripcio;
            this.import = import;
        }
        
        public int nFactura { get; set; }
        public int nLinia { get; set; }
        public int? quantitat { get; set; }
        public string descripcio { get; set; }
        public decimal? import { get; set; }
    }
}
