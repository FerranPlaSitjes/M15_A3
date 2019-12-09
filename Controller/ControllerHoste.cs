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
            this.rh = new RepositoryHoste(rc.context);
            InitListeners();
            PopulateHoste();
        }

        private void InitListeners()
        {
            f.dgvHostes.SelectionChanged += dgvHoste_SelectionChanged;
            f.AfegirHoste.Click += AfegirHoste;
            f.ModificarHoste.Click += ModificarHoste;
            f.EliminarHoste.Click += EliminarHoste;
            f.FiltreHoste.Click += FiltreHoste;
        }

        private void dgvHoste_SelectionChanged(object sender, EventArgs e)
        {
            if (f.dgvHostes.SelectedRows.Count > 0)
            {
                DataGridViewCellCollection rows = f.dgvHostes.SelectedRows[0].Cells;

                hosteDTO c = rh.hosteDTOFromRow(rows);
                f.dniHoste.Text = c.dni;
                f.nomHoste.Text = c.nom;
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
            
        }

        public void FiltreHoste(object sender, EventArgs e)
        {
            string filtre = f.textFiltrehoste.Text;

            if (f.RBdniHosteFiltre.Checked)
            {
                f.dgvHostes.DataSource = rh.FiltreDNIHoste(filtre);
            }
            else if (f.RBnomHostefiltre.Checked)
            {
                f.dgvHostes.DataSource = rh.FiltreNomHoste(filtre);
            }
            else if (f.RBtipusHabitacioHosteFiltre.Checked)
            {
                MessageBox.Show("per fer");
            }
            else
            {
                f.dgvHostes.DataSource = rh.MostrarHoste();
            }

            f.textFiltrehoste.Text = "";

        }

        public void AfegirHoste(object sender, EventArgs e)
        {
            string dni = f.dniHoste.Text;
            string nom = f.nomHoste.Text;
            string cognom = f.cognomHoste.Text;
            string poblacio = f.poblacioHoste.Text;
            string cp = f.cpHoste.Text;
            string telefon = f.telefonHoste.Text;
            string nacionalitat = f.nacinalitatHoste.Text;

            if (!nom.Equals("") && !cognom.Equals(""))
            {
                rh.afegirHoste(dni,nom, cognom,nacionalitat,telefon,cp,poblacio );
                PopulateHoste();
            }
        }

        public void EliminarHoste(object sender, EventArgs e)
        {
            string dni = f.dgvHostes.SelectedCells[0].Value.ToString();
            rh.eliminarHoste(dni);
            PopulateHoste();
        }

        public void ModificarHoste(object sender, EventArgs e)
        {
            string dni = f.dniHoste.Text;
            string nom = f.nomHoste.Text;
            string cognom = f.cognomHoste.Text;
            string poblacio = f.poblacioHoste.Text;
            string cp = f.cpHoste.Text;
            string telefon = f.telefonHoste.Text;
            string nacionalitat = f.nacinalitatHoste.Text;


            rh.modificarHoste(dni, nom, cognom, nacionalitat, telefon, cp, poblacio);
            PopulateHoste();
        }

    }
}
