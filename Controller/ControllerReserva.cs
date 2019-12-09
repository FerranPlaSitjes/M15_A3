using A3_CSharp_MVC;
using Model;
using Model.ModelDTO.Client;
using Model.ModelDTO.Pensio;
using Model.ModelDTO.Reserva;
using Model.ModelDTO.TipusHabitacio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    class ControllerReserva
    {
        Form1 f;
        RepositoryReserva rs;        
        RepositoryPensio rp;
        RepositoryClient rC;
        RepositoryTipusHabitacio rt;
        public ControllerReserva(Form1 f, RepositoryClient rc)
        {
            this.f = f;
            rC = rc;
            rs = new RepositoryReserva(rc.context);            
            rp = new RepositoryPensio(rc.context);
            rt = new RepositoryTipusHabitacio(rc.context);
            InitListeners();
            PopulateReserva();
        }

        public void InitListeners() {
            //f.verticalMenuClients.DrawItem += new DrawItemEventHandler(verticalMenu_DrawItem);
            //f.verticalMenuHostes.DrawItem += new DrawItemEventHandler(verticalMenu_DrawItem);
            //f.verticalMenuHab.DrawItem += new DrawItemEventHandler(verticalMenu_DrawItem);
            //f.verticalMenuRes.DrawItem += new DrawItemEventHandler(verticalMenu_DrawItem);
            //f.verticalMenuOcu.DrawItem += new DrawItemEventHandler(verticalMenu_DrawItem);
            //f.verticalMenuSer.DrawItem += new DrawItemEventHandler(verticalMenu_DrawItem);
            f.dgvReserva.SelectionChanged += dgvReserve_SelectionChanged;
            f.AfegirReserva.Click += AfegirReserva;
            f.ModificarReserva.Click += ModificarReserva;
            f.EliminarReserva.Click += EliminarReserva;
            f.FiltreReserva.Click += Filtreserva;
            
        }

        private void dgvReserve_SelectionChanged(object sender, EventArgs e)
        {
            if (f.dgvReserva.SelectedRows.Count > 0)
            {
                DataGridViewCellCollection rows = f.dgvReserva.SelectedRows[0].Cells;

                reservaDTO c = rs.reservaDTOFromRow(rows);
                f.idReserva.Text = c.id.ToString();
                f.dataIniciReserva.Value = (DateTime)c.dataInici;
                f.dataFinalReserva.Value = (DateTime)c.dataFinal;
                f.preuTotalReserva.Text = c.preuTotal.ToString();
                f.Bestreta.Text = c.bestreta.ToString();
                f.pensioReserva.SelectedIndex = f.pensioReserva.FindString(c.pensioFk);
                client c1 = rC.returnClientId(c.idClientFk);
                f.clientReserva.SelectedIndex = f.clientReserva.FindString(c1.nom);
                tipusHabitacio th = rt.returnTipusHabitacio(c.idTipusHabitacio);
                f.CBTipusHabitacioreserva.SelectedIndex = f.CBTipusHabitacioreserva.FindString(th.tipus);

            }
        }

        public void Filtreserva(object sender, EventArgs e)
        {
            string filtre = f.textFiltrereserva.Text;

            if (!f.RBDniReserva.Checked)
            {
                f.dgvReserva.DataSource = rs.filtreDNIReserva(filtre);
            }else if (!f.RBNumerohabitacioreserva.Checked)
            {

                try
                {
                    f.dgvReserva.DataSource = rs.filtreHabitacioReserva(int.Parse(filtre));
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ha de ser un int");
                }
                
            }
            else
            {
                PopulateReserva();
            }

            f.textFiltrereserva.Text = "";
        }

        public void PopulateReserva()
        {
            f.dgvReserva.DataSource = rs.mostrarReserva();
            List<pensio> pensios = rp.LlistarPensio();
            List<clientDTO> clients = rC.llistar();
            List<tipushabitacioDTO> thabitacio = rt.mostrarTipusHabitacio();
            OmplirClient(clients);
            OmplirPensio(pensios);
            OmplirTipusHabitacio(thabitacio);
        }

        public void AfegirReserva(object sender, EventArgs e)
        {
            DateTime dataInici = Convert.ToDateTime(f.dataIniciReserva.Value.ToShortDateString());
            DateTime dataFinal = Convert.ToDateTime(f.dataFinalReserva.Value.ToShortDateString());
            decimal preuTotal = Decimal.Parse(f.preuTotalReserva.Text);
            decimal bestreta = Decimal.Parse(f.Bestreta.Text);
            string pensioFk = f.pensioReserva.SelectedItem.ToString();
            string nomClient = f.clientReserva.SelectedItem.ToString();
            string tipushabitacio = f.CBTipusHabitacioreserva.SelectedItem.ToString();
            tipusHabitacio idTipus = rt.returnTipusHabitacioTipus(tipushabitacio);

            if (!pensioFk.Equals("") && !nomClient.Equals(""))
            {
                client c = rC.returnClient(nomClient);
                rs.afegirReserva(dataInici, dataFinal, preuTotal, bestreta, pensioFk, c.id, idTipus.codi, c.persona.dniHoste );
                PopulateReserva();
            }
        }

        public void EliminarReserva(object sender, EventArgs e)
        {
            int id = int.Parse(f.dgvReserva.SelectedCells[0].Value.ToString());
            rs.eliminarReserva(id);
            PopulateReserva();
        }

        public void ModificarReserva(object sender, EventArgs e)
        {
            int id = int.Parse(f.dgvReserva.SelectedCells[0].Value.ToString());
            DateTime dataInici = Convert.ToDateTime(f.dataIniciReserva.Text);
            DateTime dataFinal = Convert.ToDateTime(f.dataFinalReserva.Text);
            decimal preuTotal = Decimal.Parse(f.preuTotalReserva.Text);
            decimal bestreta = Decimal.Parse(f.Bestreta.Text);
            //hola
            string pensioFk = f.pensioReserva.SelectedItem.ToString();
            string nomClient = f.clientReserva.SelectedItem.ToString();
            client c = rC.returnClient(nomClient);
            string tipushabitacio = f.CBTipusHabitacioreserva.SelectedItem.ToString();

            rs.modificarReserva(id, dataInici, dataFinal, preuTotal, bestreta, pensioFk, c.id);
            PopulateReserva();
        }

        public void OmplirPensio(List<pensio> pensios)
        {
            foreach (pensio p in pensios)
            {
                f.pensioReserva.Items.Add(p.tipus);
            }
        }

        public void OmplirClient(List<clientDTO> clients)
        {
            foreach (clientDTO c in clients)
            {
                f.clientReserva.Items.Add(c.nom);
            }
        }

        public void OmplirTipusHabitacio(List<tipushabitacioDTO> thabitacio)
        {
            foreach (tipushabitacioDTO c in thabitacio)
            {
                f.CBTipusHabitacioreserva.Items.Add(c.tipus);
            }
        }
    }
}
