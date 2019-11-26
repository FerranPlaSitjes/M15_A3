﻿using A3_CSharp_MVC;
using Model.ModelDTO.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class Controller1
    {
        Form1 f;
        RepositoryClient rc;

        public Controller1()
        {
            f = new Form1();
            rc = new RepositoryClient();
            Inicialitza();
        }

        private void Inicialitza()
        {
            InitListeners();
            populateClients();
            Application.Run(f);
        }

        private void populateClients()
        {
            f.dgvClients.DataSource = rc.llistar();
            f.tipusCB.Items.Add("Empresa");
            f.tipusCB.Items.Add("Particular");
        }

        private void InitListeners()
        {
            f.verticalMenuClients.DrawItem += new DrawItemEventHandler(verticalMenu_DrawItem);
            f.verticalMenuHostes.DrawItem += new DrawItemEventHandler(verticalMenu_DrawItem);
            f.verticalMenuHab.DrawItem += new DrawItemEventHandler(verticalMenu_DrawItem);
            f.verticalMenuRes.DrawItem += new DrawItemEventHandler(verticalMenu_DrawItem);
            f.verticalMenuOcu.DrawItem += new DrawItemEventHandler(verticalMenu_DrawItem);
            f.verticalMenuSer.DrawItem += new DrawItemEventHandler(verticalMenu_DrawItem);
            f.addButton.Click += AddButton_Click;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            String nom = f.nomTB.Text;
            String tipus = f.tipusCB.SelectedItem.ToString();
            if (!nom.Equals("") && !tipus.Equals(""))
            {
                rc.afegirClient(nom, tipus);
                populateClients();
            }
        }

        private void verticalMenu_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = f.verticalMenuClients.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = f.verticalMenuClients.GetTabRect(e.Index);

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
