using A3_CSharp_MVC;
using Model;
using Model.ModelDTO.Client;
using Model.ModelDTO.Habitacio;
using Model.ModelDTO.Ocupacio;
using Model.ModelDTO.Pensio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    class ControllerOcupacio
    {
        Form1 f;
        RepositoryOcupacio ro;
        RepositoryClient rcl;
        RepositoryHabitacio rh;
        RepositoryPensio rp;

        public ControllerOcupacio(Form1 f, RepositoryClient rc)
        {
            this.f = f;
            rcl = rc;
            ro = new RepositoryOcupacio(rc.context);
            rh = new RepositoryHabitacio(rc.context);
            rp = new RepositoryPensio(rc.context);
            InitListeners();
            Inicialitza();
            PopulateOcupacio();
        }

        private void Inicialitza()
        {
            foreach (habitacioDTO h in rh.mostrarHabitacio())
            {
                f.habOcuCB.Items.Add(h.numero);
            }
            foreach (pensio p in rp.LlistarPensio())
            {
                f.pensioOcuCB.Items.Add(p.tipus);
            }
        }

        private void PopulateOcupacio()
        {
            f.dgvOcupacions.DataSource = ro.mostrarOcupacions();
        }

        private void InitListeners()
        {
            f.dgvOcupacions.SelectionChanged += DgvOcupacions_SelectionChanged;
            f.addOcuBt.Click += AddOcuBt_Click;
            f.modOcuBt.Click += ModOcuBt_Click;
            f.delOcuBt.Click += DelOcuBt_Click;
        }

        private void DelOcuBt_Click(object sender, EventArgs e)
        {
            int id = int.Parse(f.dgvOcupacions.SelectedCells[0].Value.ToString());

            ro.eliminarOcupacio(id);
            PopulateOcupacio();
        }

        private void ModOcuBt_Click(object sender, EventArgs e)
        {
            int id = int.Parse(f.dgvOcupacions.SelectedCells[0].Value.ToString());
            DateTime dataInici = Convert.ToDateTime(f.dataIniciOcu.Text);
            DateTime dataFinal = Convert.ToDateTime(f.dataFinalOcu.Text);
            int habitacio = Int32.Parse(f.habOcuCB.SelectedItem.ToString());
            string pensio = f.pensioOcuCB.SelectedItem.ToString();

            ro.modificarOcupacio(id, dataInici, dataFinal, habitacio, pensio);
            PopulateOcupacio();
        }

        private void AddOcuBt_Click(object sender, EventArgs e)
        {
            DateTime dataInici = Convert.ToDateTime(f.dataIniciOcu.Value.ToShortDateString());
            DateTime dataFinal = Convert.ToDateTime(f.dataFinalOcu.Value.ToShortDateString());
            int numero = Int32.Parse(f.habOcuCB.SelectedItem.ToString());
            string pensio = f.pensioOcuCB.SelectedItem.ToString();

            ro.afegirOcupacio(dataInici, dataFinal, numero, pensio);
            PopulateOcupacio();
        }

        private void DgvOcupacions_SelectionChanged(object sender, EventArgs e)
        {
            if (f.dgvOcupacions.SelectedRows.Count > 0)
            {
                DataGridViewCellCollection rows = f.dgvOcupacions.SelectedRows[0].Cells;

                ocupacioDTO o = ro.ocupacioDTOFromRow(rows);
                f.dataIniciOcu.Value = (DateTime)o.dataInici;
                f.dataFinalOcu.Value = (DateTime)o.dataFinal;
                f.habOcuCB.SelectedIndex = f.habOcuCB.FindString(o.nHabitacioFk.ToString());
                f.pensioOcuCB.SelectedIndex = f.pensioOcuCB.FindString(o.tipusPensioFk);
            }
        }
    }
}
