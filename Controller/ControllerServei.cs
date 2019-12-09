using A3_CSharp_MVC;
using Model.ModelDTO.Client;
using Model.ModelDTO.Servei;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    class ControllerServei
    {
        Form1 f;
        RepositoryClient rcl;
        RepositoryServei rs;

        public ControllerServei(Form1 f, RepositoryClient rc)
        {
            this.f = f;
            rcl = rc;
            rs = new RepositoryServei(rc.context);
            InitListeners();
            PopulateServei();
        }

        private void PopulateServei()
        {
            f.dgvServeis.DataSource = rs.mostrarServeis();
            f.dgvServeis.Focus();
        }

        private void InitListeners()
        {
            f.dgvServeis.SelectionChanged += DgvServeis_SelectionChanged;
            f.addSer.Click += AddSer_Click;
            f.modSer.Click += ModSer_Click;
            f.delSer.Click += DelSer_Click;
        }

        private void DelSer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(f.dgvServeis.SelectedCells[0].Value.ToString());

            rs.eliminarServei(id);
            PopulateServei();
        }

        private void ModSer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(f.dgvServeis.SelectedCells[0].Value.ToString());
            string nom = f.nomServeiTB.Text;

            rs.modificarServei(id, nom);
            PopulateServei();
        }

        private void AddSer_Click(object sender, EventArgs e)
        {
            string nom = f.nomServeiTB.Text;

            rs.afegirServei(nom);
            PopulateServei();
        }

        private void DgvServeis_SelectionChanged(object sender, EventArgs e)
        {
            if (f.dgvServeis.SelectedRows.Count > 0)
            {
                DataGridViewCellCollection rows = f.dgvServeis.SelectedRows[0].Cells;

                serveiDTO s = rs.serveiDTOFromRow(rows);
                f.nomServeiTB.Text = s.nom;
            }
        }
    }
}
