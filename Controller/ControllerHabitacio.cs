using A3_CSharp_MVC;
using Model.ModelDTO.Client;
using Model.ModelDTO.Habitacio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class ControllerHabitacio
    {
        Form1 f;
        RepositoryClient rc;
        RepositoryHabitacio rh;

        public ControllerHabitacio(Form1 f, RepositoryClient rc)
        {
            this.f = f;
            this.rc = rc;
            this.rh = new RepositoryHabitacio(rc.context);
            InitListeners();
            PopulateHabitacio();
        }

        public void PopulateHabitacio()
        {
            //f.dgvHabitacio.Datasource = rh.mostrarHabitacio();
        }


        public void InitListeners()
        {            
            //f.dgvReserva.SelectionChanged += dgvReserve_SelectionChanged;
            //f.AfegirReserva.Click += AfegirReserva;
            //f.ModificarReserva.Click += ModificarReserva;
            //f.EliminarReserva.Click += EliminarReserva;
        }

        private void dgvReserve_SelectionChanged(object sender, EventArgs e)
        {
            if (f.dgvReserva.SelectedRows.Count > 0)
            {
                DataGridViewCellCollection rows = f.dgvReserva.SelectedRows[0].Cells;

                habitacioDTO c = rh.habitacioDTOFromRow(rows);
                //f.idReserva.Text = c.id.ToString();
                //f.dataIniciReserva.Value = (DateTime)c.dataInici;
                //f.dataFinalReserva.Value = (DateTime)c.dataFinal;
                //f.preuTotalReserva.Text = c.preuTotal.ToString();
                //f.Bestreta.Text = c.bestreta.ToString();
                //f.pensioReserva.SelectedIndex = f.pensioReserva.FindString(c.pensioFk);
                //client c1 = rC.returnClientId(c.idClientFk);
                //f.clientReserva.SelectedIndex = f.clientReserva.FindString(c1.nom);

            }
        }

        public void PopulateReserva()
        {
            //f.dgvHabitacio.DataSource = rh.mostrarHabitacio();           
            //List<clientDTO> clients = rc.llistar();
            //OmplirClient(clients);
            
        }

        public void AfegirReserva(object sender, EventArgs e)
        {            
            
        }

        public void EliminarReserva(object sender, EventArgs e)
        {
            int id = int.Parse(f.dgvReserva.SelectedCells[0].Value.ToString());
            rh.eliminarHabitacio(id);
            PopulateReserva();
        }

        public void ModificarReserva(object sender, EventArgs e)
        {
            //int numero;
            //int metresQuadrats;
            //bool terrassa; bool utilitzable;
            //string titol;
            //string caracteristiques;
            //int codiTipus;


            //rh.modificarHabitacio(numero, metresQuadrats, terrassa, utilitzable, titol, caracteristiques, codiTipus);
            //PopulateHabitacio();
        }



    }

}
