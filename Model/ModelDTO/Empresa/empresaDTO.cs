using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Empresa
{
    public class empresaDTO
    {
        public empresaDTO(int cif)
        {
            this.cif = cif;
        }
        public int cif { get; set; }

        
    }
}
