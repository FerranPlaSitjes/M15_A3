using A3_CSharp_MVC;
using Model.ModelDTO.Client;
using Model.ModelDTO.Preu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class ControllerPreu
    {
        Form1 f;
        RepositoryClient rc;
        RepositoryPreu rp;

        public ControllerPreu(Form1 f, RepositoryClient rc)
        {
            this.f = f;
            this.rc = rc;
            this.rp = new RepositoryPreu(rc.context);
            InitListeners();
            PopulatePreus();
        }

        private void PopulatePreus()
        {
            f.dgvPreus.DataSource = rc.llistar();

        }

        private void InitListeners()
        {
            throw new NotImplementedException();
        }
    }
}
