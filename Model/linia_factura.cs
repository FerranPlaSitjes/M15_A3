//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class linia_factura
    {
        public int nFactura { get; set; }
        public int nLinia { get; set; }
        public Nullable<int> quantitat { get; set; }
        public string descripcio { get; set; }
        public Nullable<decimal> import { get; set; }
    
        public virtual factura factura { get; set; }

        public linia_factura(int nFactura, int nLinia, int quantitat, string descripcio, decimal import)
        {
            this.nFactura = nFactura;
            this.nLinia = nLinia;
            this.quantitat = quantitat;
            this.descripcio = descripcio;
            this.import = import;
        }
    }
}
