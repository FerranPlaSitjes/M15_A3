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
    
    public partial class preu
    {
        public int codiTemporada { get; set; }
        public string tipusPensio { get; set; }
        public int codiHabitacio { get; set; }
    
        public virtual habitacio habitacio { get; set; }
        public virtual pensio pensio { get; set; }
        public virtual temporada temporada { get; set; }
    }
}