using A3_CSharp_MVC;
using Model;
using Model.ModelDTO.Client;
using Model.ModelDTO.Pensio;
using Model.ModelDTO.Preu;
using Model.ModelDTO.Temporada;
using Model.ModelDTO.TipusHabitacio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class ControllerPreu
    {
        Form1 f;
        RepositoryClient rc;
        RepositoryPreu rp;
        RepositoryTemporada rt;
        RepositoryPensio rpe;
        RepositoryTipusHabitacio rth;

        public ControllerPreu(Form1 f, RepositoryClient rc)
        {
            this.f = f;
            this.rc = rc;
            this.rp = new RepositoryPreu(rc.context);
            this.rt = new RepositoryTemporada(rc.context);
            this.rpe = new RepositoryPensio(rc.context);
            this.rth = new RepositoryTipusHabitacio(rc.context);
            InitListeners();
            Inicialitza();
            PopulatePreus();
        }

        private void Inicialitza()
        {
            List<temporadaDTO> lt = rt.getAll();
            foreach (temporadaDTO te in lt)
            {
                f.temporadaPreuCB.Items.Add(te.nom);
            }

            List<pensio> lp = rpe.LlistarPensio();
            foreach (pensio p in lp)
            {
                f.pensioPreuCB.Items.Add(p.tipus);
            }

            List<tipushabitacioDTO> lth = rth.getAll();
            foreach (tipushabitacioDTO th in lth)
            {
                f.tipusHabPreuCB.Items.Add(th.tipus);
            }
        }

        private void PopulatePreus()
        {
            List<preuDTO> codis = rp.llistar();
            List<preuDTO> dades = new List<preuDTO>();
            foreach (preuDTO p in codis)
            {
                temporada t = rt.getTemporada(p.codiTemporada);
                tipusHabitacio th = rth.getTipusHabitacio(p.codiHabitacio);
                preuDTO p1 = new preuDTO(t.nom, p.tipusPensio, th.tipus, p.preu);
                dades.Add(p1);
            }
            f.dgvPreus.DataSource = dades;
            f.dgvPreus.Columns["codiTemporada"].Visible = false;
            f.dgvPreus.Columns["codiHabitacio"].Visible = false;
        }

        private void InitListeners()
        {
            f.dgvPreus.SelectionChanged += DgvPreus_SelectionChanged;
            f.addPreuBt.Click += AddPreuBt_Click;
            f.modPreuBt.Click += ModPreuBt_Click;
            f.delPreuBt.Click += DelPreuBt_Click;
        }

        private void DelPreuBt_Click(object sender, EventArgs e)
        {
            int selRow = f.dgvPreus.CurrentRow.Index;

            string temporada = f.dgvPreus.SelectedCells[0].Value.ToString();
            string pensio = f.dgvPreus.SelectedCells[3].Value.ToString();
            string tipusHab = f.dgvPreus.SelectedCells[1].Value.ToString();
            MessageBox.Show(temporada);
            MessageBox.Show(pensio);
            MessageBox.Show(tipusHab);
            temporada t = rt.getTemporada(temporada);
            tipusHabitacio th = rth.getTipusHabitacioByType(tipusHab);

            if (t != null && th != null)
            {
                MessageBox.Show(t.codi.ToString() + pensio + th.codi.ToString());
                rp.eliminarPreu(t.codi, pensio, th.codi);
                PopulatePreus();
                if (selRow > 0)
                {
                    f.dgvPreus.Rows[selRow - 1].Selected = true;
                } else
                    f.dgvPreus.Rows[selRow + 1].Selected = true;
            }
        }

        private void ModPreuBt_Click(object sender, EventArgs e)
        {
            int selRow = f.dgvPreus.CurrentRow.Index;

            string temporada = f.temporadaPreuCB.Text;
            string pensio = f.pensioPreuCB.Text;
            string tipusHab = f.tipusHabPreuCB.Text;
            decimal preu = Decimal.Parse(f.preuTB.Text);

            temporada t = rt.getTemporada(temporada);
            tipusHabitacio th = rth.getTipusHabitacioByType(tipusHab);

            rp.modificarPreu(t.codi, pensio, th.codi, preu);
            PopulatePreus();
            f.dgvPreus.Rows[selRow].Selected = true;
        }

        private void AddPreuBt_Click(object sender, EventArgs e)
        {
            string temporada = f.temporadaPreuCB.Text;
            string pensio = f.pensioPreuCB.Text;
            string tipusHab = f.tipusHabPreuCB.Text;
            decimal preu = Decimal.Parse(f.preuTB.Text);

            temporada t = rt.getTemporada(temporada);
            tipusHabitacio th = rth.getTipusHabitacioByType(tipusHab);

            rp.afegirPreu(t.codi, pensio, th.codi, preu);
            PopulatePreus();
        }

        private void DgvPreus_SelectionChanged(object sender, EventArgs e)
        {
            if (f.dgvPreus.SelectedRows.Count > 0)
            {
                DataGridViewCellCollection rows = f.dgvPreus.SelectedRows[0].Cells;

                preuDTO p = rp.preuDTOFromRow(rows);
                f.temporadaPreuCB.SelectedIndex = f.temporadaPreuCB.FindString(p.temporada);
                f.pensioPreuCB.SelectedIndex = f.pensioPreuCB.FindString(p.tipusPensio);
                f.tipusHabPreuCB.SelectedIndex = f.tipusHabPreuCB.FindString(p.tipusHabitacio);
                f.preuTB.Text = p.preu.ToString();
            }
        }
    }
}
