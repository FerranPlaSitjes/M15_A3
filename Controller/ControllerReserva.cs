using A3_CSharp_MVC;
using Model;
using Model.ModelDTO.Client;
using Model.ModelDTO.Pensio;
using Model.ModelDTO.Reserva;
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
        public ControllerReserva(Form1 f, RepositoryClient rc)
        {
            this.f = f;
            rC = rc;
            rs = new RepositoryReserva(rc.context);            
            rp = new RepositoryPensio(rc.context);
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

            }
        }

        public void PopulateReserva()
        {
            f.dgvReserva.DataSource = rs.mostrarReserva();            
            List<pensio> pensios = rp.LlistarPensio();
            List<clientDTO> clients = rC.llistar();
            OmplirClient(clients);
            OmplirPensio(pensios);
        }

        public void AfegirReserva(object sender, EventArgs e)
        {
            DateTime dataInici = Convert.ToDateTime(f.dataIniciReserva.Value.ToShortDateString());
            DateTime dataFinal = Convert.ToDateTime(f.dataFinalReserva.Value.ToShortDateString());
            decimal preuTotal = Decimal.Parse(f.preuTotalReserva.Text);
            decimal bestreta = Decimal.Parse(f.Bestreta.Text);
            string pensioFk = f.pensioReserva.SelectedItem.ToString();
            string nomClient = f.clientReserva.SelectedItem.ToString();

            if (!pensioFk.Equals("") && !nomClient.Equals(""))
            {
                client c = rC.returnClient(nomClient);
                rs.afegirReserva(dataInici, dataFinal, preuTotal, bestreta, pensioFk, c.id);
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
            string pensioFk = f.pensioReserva.SelectedItem.ToString();
            string nomClient = f.clientReserva.SelectedItem.ToString();
            client c = rC.returnClient(nomClient);

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
    }
}
