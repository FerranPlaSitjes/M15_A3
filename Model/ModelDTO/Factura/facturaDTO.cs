using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Factura
{
    public class facturaDTO
    {
        public facturaDTO(int numero, DateTime data, decimal import, string dniHoste )
        {
            this.numero = numero;
            this.data = data;
            this.import = import;
            this.dniHosteFk = dniHoste;
        }

        public int numero { get; set; }
        public DateTime? data { get; set; }
        public decimal? import { get; set; }
        public string dniHosteFk { get; set; }
    }
}
