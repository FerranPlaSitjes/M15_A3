using A3_CSharp_MVC;
using Model;
using Model.ModelDTO.Client;
using Model.ModelDTO.Habitacio;
using Model.ModelDTO.TipusHabitacio;
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
        RepositoryTipusHabitacio rth;

        public ControllerHabitacio(Form1 f, RepositoryClient rc)
        {
            this.f = f;
            this.rc = rc;
            this.rh = new RepositoryHabitacio(rc.context);
            this.rth = new RepositoryTipusHabitacio(rc.context);
            InitListeners();
            PopulateHabitacio();
        }

        public void PopulateHabitacio()
        {
            f.dgvHabitacio.DataSource = rh.mostrarHabitacio();
            List<tipushabitacioDTO> hab = rth.mostrarTipusHabitacio();               
            PopulateCBhabitacio(hab);

        }

        private void PopulateCBhabitacio(List<tipushabitacioDTO> llista)
        {
            f.idTipushabHabitacio.Items.Clear();
            foreach (tipushabitacioDTO h in llista)
            {
                f.idTipushabHabitacio.Items.Add(h.tipus);
            }
        }

        public void InitListeners()
        {
            f.verticalMenuHab.DrawItem += new DrawItemEventHandler(verticalMenu_DrawItem);
            f.dgvHabitacio.SelectionChanged += dgvHabitacio_SelectionChanged;
            f.AfegirHabitacio.Click += AfegirHabitacio;
            f.ModificarHabitacio.Click += ModificarHabitacio;
            f.EliminarHabitacio.Click += EliminarHabitacio;
        }

        private void dgvHabitacio_SelectionChanged(object sender, EventArgs e)
        {
            if (f.dgvHabitacio.SelectedRows.Count > 0)
            {
                DataGridViewCellCollection rows = f.dgvHabitacio.SelectedRows[0].Cells;

                habitacioDTO c = rh.habitacioDTOFromRow(rows);
                f.numeroHabitacio.Text = c.numero.ToString();
                f.metresQHabitacio.Text = c.metresQuadrats.ToString();
                f.terrasaHabitacio.Checked = c.terrassa.Value;
                f.utilitzableHabitacio.Checked = c.utilitzable.Value;
                f.titolHabitacio.Text = c.titol;
                f.caracteristiquesHabitacio.Text= c.caracteristiques;
                tipusHabitacio t = rth.returnTipusHabitacio(c.codiTipus);
                f.idTipushabHabitacio.SelectedIndex = f.idTipushabHabitacio.FindString(t.tipus);

            }
        }
      
        

        public void AfegirHabitacio(object sender, EventArgs e)
        {            
            rh.afegirHabitacio(int.Parse(f.numeroHabitacio.Text), int.Parse(f.metresQHabitacio.Text), f.terrasaHabitacio.Checked, f.utilitzableHabitacio.Checked, f.titolHabitacio.Text, f.caracteristiquesHabitacio.Text, f.idTipushabHabitacio.SelectedIndex+1);
            PopulateHabitacio();
        }

        public void EliminarHabitacio(object sender, EventArgs e)
        {
            int numero = int.Parse(f.dgvHabitacio.SelectedCells[0].Value.ToString());
            rh.eliminarHabitacio(numero);
            PopulateHabitacio();
        }

        public void ModificarHabitacio(object sender, EventArgs e)
        {           

            rh.modificarHabitacio(int.Parse(f.numeroHabitacio.Text), int.Parse(f.metresQHabitacio.Text), f.terrasaHabitacio.Checked, f.utilitzableHabitacio.Checked, f.titolHabitacio.Text, f.caracteristiquesHabitacio.Text, f.idTipushabHabitacio.SelectedIndex +1);
            PopulateHabitacio();
            
        }

        private void verticalMenu_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = f.verticalMenuHab.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = f.verticalMenuHab.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 10.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

    }

}
