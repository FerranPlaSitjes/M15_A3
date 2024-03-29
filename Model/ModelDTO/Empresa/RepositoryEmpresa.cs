﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Empresa
{
    public class RepositoryEmpresa
    {
        hotelEntities context;
        
        public RepositoryEmpresa()
        {
            context = new hotelEntities();
        }

        public void afegirEmpresa(int cif)
        {
            empresa e = new empresa(cif);
            context.empresas.Add(e);
            context.SaveChanges();
        }

        public void eliminarEmpresa(int cif)
        {
            var empresa = context.empresas.Single(e => e.cif == cif);
            context.empresas.Remove(empresa);
            context.SaveChanges();
        }
    }
}
