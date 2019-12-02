using A3_CSharp_MVC;
using Model.ModelDTO.Client;
using Model.ModelDTO.Hoste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class ControllerHoste
    {
        Form1 f;
        RepositoryClient rc;
        RepositoryHoste rh;

        public ControllerHoste(Form1 f, RepositoryClient rc)
        {
            this.f = f;
            this.rc = rc;
            this.rh = new RepositoryHoste();
            InitListeners();            
        }

        private void InitListeners()
        {

        }

        private void dgvReserve_SelectionChanged(object sender, EventArgs e)
        {
            if (f.dgvReserva.SelectedRows.Count > 0)
            {
                DataGridViewCellCollection rows = f.dgvReserva.SelectedRows[0].Cells;

                hosteDTO c = rh.hosteDTOFromRow(rows);
                f.nomHoste.Text = c.nom.ToString();
                f.cognomHoste.Text = c.cognom;
                f.poblacioHoste.Text = c.poblacio;
                f.cpHoste.Text = c.cp;
                f.telefonHoste.Text = c.telefon;
                f.nacinalitatHoste.Text = c.nacionalitat;              
                
            }
        }

        public void PopulateHoste()
        {
            f.dgvHostes.DataSource = rh.MostrarHoste();           
            //List<clientDTO> clients = rc.llistar();
            //OmplirClient(clients);

        }

        public void AfegirReserva(object sender, EventArgs e)
        {

        }

        public void EliminarReserva(object sender, EventArgs e)
        {
            string dni = f.dgvHostes.SelectedCells[0].Value.ToString();
            rh.eliminarHoste(dni);
            PopulateHoste();
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
