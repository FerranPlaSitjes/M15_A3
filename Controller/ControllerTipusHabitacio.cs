using A3_CSharp_MVC;
using Model;
using Model.ModelDTO.Client;
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
    public class ControllerTipusHabitacio
    {
        Form1 f;
        RepositoryClient rc;        
        RepositoryTipusHabitacio rth;

        public ControllerTipusHabitacio(Form1 f, RepositoryClient rc)
        {
            this.f = f;
            this.rc = rc;            
            this.rth = new RepositoryTipusHabitacio(rc.context);
            InitListeners();
            PopulateTipusHabitacio();
        }

        public void PopulateTipusHabitacio()
        {
            f.dgvTipusHabitacio.DataSource = rth.mostrarTipusHabitacio();
            List<tipushabitacioDTO> hab = rth.mostrarTipusHabitacio();            

        }
        
        public void InitListeners()
        {
            f.verticalMenuHab.DrawItem += new DrawItemEventHandler(verticalMenu_DrawItem);
            f.dgvTipusHabitacio.SelectionChanged += dgTipusHabitacio_SelectionChanged;
            f.AfegirTipusHabitacio.Click += AfegirTipusHabitacio;
            f.ModificarTipusHabitacio.Click += ModificarTipusHabitacio;
            f.EliminarTipusHabitacio.Click += EliminarTipusHabitacio;
        }

        private void dgTipusHabitacio_SelectionChanged(object sender, EventArgs e)
        {
            if (f.dgvTipusHabitacio.SelectedRows.Count > 0)
            {
                DataGridViewCellCollection rows = f.dgvTipusHabitacio.SelectedRows[0].Cells;

                tipushabitacioDTO c = rth.TipushabitacioDTOFromRow(rows);                
                tipusHabitacio t = rth.returnTipusHabitacio(c.codi);
                f.CodiTipusHabitacio.Text = t.codi.ToString();
                f.capacitatTipusHabitacio.Text = c.capacitat.ToString();
                f.TipusHabitacio.Text = c.tipus;    

            }
        }

        public void AfegirTipusHabitacio(object sender, EventArgs e)
        {
            rth.afegirTipusHabitacio(int.Parse(f.CodiTipusHabitacio.Text),f.TipusHabitacio.Text, int.Parse(f.capacitatTipusHabitacio.Text));
            PopulateTipusHabitacio();
        }

        public void EliminarTipusHabitacio(object sender, EventArgs e)
        {
            int numero = int.Parse(f.dgvTipusHabitacio.SelectedCells[0].Value.ToString());
            rth.eliminarTipusHabitacio(numero);
            PopulateTipusHabitacio();
        }

        public void ModificarTipusHabitacio(object sender, EventArgs e)
        {

            rth.modificarTipusHabitacio(int.Parse(f.CodiTipusHabitacio.Text), f.TipusHabitacio.Text,int.Parse(f.capacitatTipusHabitacio.Text));
            PopulateTipusHabitacio();

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

