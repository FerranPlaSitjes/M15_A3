namespace A3_CSharp_MVC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Clients = new System.Windows.Forms.TabPage();
            this.verticalMenuClients = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.EliminarClient = new System.Windows.Forms.Button();
            this.ModificarClient = new System.Windows.Forms.Button();
            this.AfegirClient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tipusCB = new System.Windows.Forms.ComboBox();
            this.nomTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage18 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.verticalMenuHostes = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.ModificarReserva = new System.Windows.Forms.Button();
            this.EliminarReserva = new System.Windows.Forms.Button();
            this.AfegirReserva = new System.Windows.Forms.Button();
            this.labelClientReserva = new System.Windows.Forms.Label();
            this.labelPensioReserva = new System.Windows.Forms.Label();
            this.labelBestretaReserva = new System.Windows.Forms.Label();
            this.labelDataFinalReserva = new System.Windows.Forms.Label();
            this.labelDataIniciReserva = new System.Windows.Forms.Label();
            this.labelIdReserva = new System.Windows.Forms.Label();
            this.titolReserva = new System.Windows.Forms.Label();
            this.clientReserva = new System.Windows.Forms.ComboBox();
            this.pensioReserva = new System.Windows.Forms.ComboBox();
            this.Bestreta = new System.Windows.Forms.TextBox();
            this.idReserva = new System.Windows.Forms.TextBox();
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.verticalMenuHab = new System.Windows.Forms.TabControl();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.verticalMenuRes = new System.Windows.Forms.TabControl();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.verticalMenuOcu = new System.Windows.Forms.TabControl();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.verticalMenuSer = new System.Windows.Forms.TabControl();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.labelpreuTotalReserva = new System.Windows.Forms.Label();
            this.preuTotalReserva = new System.Windows.Forms.TextBox();
            this.dataIniciReserva = new System.Windows.Forms.DateTimePicker();
            this.dataFinalReserva = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.Clients.SuspendLayout();
            this.verticalMenuClients.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.verticalMenuHostes.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.verticalMenuHab.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.verticalMenuRes.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.verticalMenuOcu.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.verticalMenuSer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Clients);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(-5, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 10, 5, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 15);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1366, 768);
            this.tabControl1.TabIndex = 0;
            // 
            // Clients
            // 
            this.Clients.Controls.Add(this.verticalMenuClients);
            this.Clients.Location = new System.Drawing.Point(4, 46);
            this.Clients.Name = "Clients";
            this.Clients.Padding = new System.Windows.Forms.Padding(3);
            this.Clients.Size = new System.Drawing.Size(1358, 718);
            this.Clients.TabIndex = 0;
            this.Clients.Text = "Clients";
            this.Clients.UseVisualStyleBackColor = true;
            // 
            // verticalMenuClients
            // 
            this.verticalMenuClients.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.verticalMenuClients.Controls.Add(this.tabPage6);
            this.verticalMenuClients.Controls.Add(this.tabPage7);
            this.verticalMenuClients.Controls.Add(this.tabPage18);
            this.verticalMenuClients.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.verticalMenuClients.ItemSize = new System.Drawing.Size(25, 100);
            this.verticalMenuClients.Location = new System.Drawing.Point(0, 0);
            this.verticalMenuClients.Multiline = true;
            this.verticalMenuClients.Name = "verticalMenuClients";
            this.verticalMenuClients.SelectedIndex = 0;
            this.verticalMenuClients.Size = new System.Drawing.Size(1272, 670);
            this.verticalMenuClients.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.verticalMenuClients.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label3);
            this.tabPage6.Controls.Add(this.EliminarClient);
            this.tabPage6.Controls.Add(this.ModificarClient);
            this.tabPage6.Controls.Add(this.AfegirClient);
            this.tabPage6.Controls.Add(this.label2);
            this.tabPage6.Controls.Add(this.tipusCB);
            this.tabPage6.Controls.Add(this.nomTB);
            this.tabPage6.Controls.Add(this.label1);
            this.tabPage6.Controls.Add(this.dgvClients);
            this.tabPage6.Location = new System.Drawing.Point(104, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1164, 662);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Afegir client";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gestió de clients";
            // 
            // EliminarClient
            // 
            this.EliminarClient.Location = new System.Drawing.Point(851, 518);
            this.EliminarClient.Name = "EliminarClient";
            this.EliminarClient.Size = new System.Drawing.Size(75, 23);
            this.EliminarClient.TabIndex = 7;
            this.EliminarClient.Text = "Eliminar";
            this.EliminarClient.UseVisualStyleBackColor = true;
            // 
            // ModificarClient
            // 
            this.ModificarClient.Location = new System.Drawing.Point(562, 518);
            this.ModificarClient.Name = "ModificarClient";
            this.ModificarClient.Size = new System.Drawing.Size(75, 23);
            this.ModificarClient.TabIndex = 6;
            this.ModificarClient.Text = "Modificar";
            this.ModificarClient.UseVisualStyleBackColor = true;
            // 
            // AfegirClient
            // 
            this.AfegirClient.Location = new System.Drawing.Point(231, 518);
            this.AfegirClient.Name = "AfegirClient";
            this.AfegirClient.Size = new System.Drawing.Size(75, 23);
            this.AfegirClient.TabIndex = 5;
            this.AfegirClient.Text = "Afegir";
            this.AfegirClient.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipus";
            // 
            // tipusCB
            // 
            this.tipusCB.FormattingEnabled = true;
            this.tipusCB.Location = new System.Drawing.Point(448, 446);
            this.tipusCB.Name = "tipusCB";
            this.tipusCB.Size = new System.Drawing.Size(121, 21);
            this.tipusCB.TabIndex = 3;
            // 
            // nomTB
            // 
            this.nomTB.Location = new System.Drawing.Point(231, 446);
            this.nomTB.Name = "nomTB";
            this.nomTB.Size = new System.Drawing.Size(188, 20);
            this.nomTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(231, 98);
            this.dgvClients.MultiSelect = false;
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(695, 303);
            this.dgvClients.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(104, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1164, 662);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Modificar Client";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage18
            // 
            this.tabPage18.Location = new System.Drawing.Point(104, 4);
            this.tabPage18.Name = "tabPage18";
            this.tabPage18.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage18.Size = new System.Drawing.Size(1164, 662);
            this.tabPage18.TabIndex = 2;
            this.tabPage18.Text = "Llistar Clients";
            this.tabPage18.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.verticalMenuHostes);
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1358, 718);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reserves";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // verticalMenuHostes
            // 
            this.verticalMenuHostes.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.verticalMenuHostes.Controls.Add(this.tabPage8);
            this.verticalMenuHostes.Controls.Add(this.tabPage9);
            this.verticalMenuHostes.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.verticalMenuHostes.ItemSize = new System.Drawing.Size(25, 100);
            this.verticalMenuHostes.Location = new System.Drawing.Point(0, 0);
            this.verticalMenuHostes.Multiline = true;
            this.verticalMenuHostes.Name = "verticalMenuHostes";
            this.verticalMenuHostes.SelectedIndex = 0;
            this.verticalMenuHostes.Size = new System.Drawing.Size(1272, 670);
            this.verticalMenuHostes.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.verticalMenuHostes.TabIndex = 1;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.dataFinalReserva);
            this.tabPage8.Controls.Add(this.dataIniciReserva);
            this.tabPage8.Controls.Add(this.labelpreuTotalReserva);
            this.tabPage8.Controls.Add(this.preuTotalReserva);
            this.tabPage8.Controls.Add(this.ModificarReserva);
            this.tabPage8.Controls.Add(this.EliminarReserva);
            this.tabPage8.Controls.Add(this.AfegirReserva);
            this.tabPage8.Controls.Add(this.labelClientReserva);
            this.tabPage8.Controls.Add(this.labelPensioReserva);
            this.tabPage8.Controls.Add(this.labelBestretaReserva);
            this.tabPage8.Controls.Add(this.labelDataFinalReserva);
            this.tabPage8.Controls.Add(this.labelDataIniciReserva);
            this.tabPage8.Controls.Add(this.labelIdReserva);
            this.tabPage8.Controls.Add(this.titolReserva);
            this.tabPage8.Controls.Add(this.clientReserva);
            this.tabPage8.Controls.Add(this.pensioReserva);
            this.tabPage8.Controls.Add(this.Bestreta);
            this.tabPage8.Controls.Add(this.idReserva);
            this.tabPage8.Controls.Add(this.dgvReserva);
            this.tabPage8.Location = new System.Drawing.Point(104, 4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1164, 662);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "Afegir client";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // ModificarReserva
            // 
            this.ModificarReserva.Location = new System.Drawing.Point(672, 525);
            this.ModificarReserva.Name = "ModificarReserva";
            this.ModificarReserva.Size = new System.Drawing.Size(75, 23);
            this.ModificarReserva.TabIndex = 16;
            this.ModificarReserva.Text = "Modificar";
            this.ModificarReserva.UseVisualStyleBackColor = true;
            // 
            // EliminarReserva
            // 
            this.EliminarReserva.Location = new System.Drawing.Point(526, 525);
            this.EliminarReserva.Name = "EliminarReserva";
            this.EliminarReserva.Size = new System.Drawing.Size(75, 23);
            this.EliminarReserva.TabIndex = 15;
            this.EliminarReserva.Text = "Eliminar";
            this.EliminarReserva.UseVisualStyleBackColor = true;
            // 
            // AfegirReserva
            // 
            this.AfegirReserva.Location = new System.Drawing.Point(377, 525);
            this.AfegirReserva.Name = "AfegirReserva";
            this.AfegirReserva.Size = new System.Drawing.Size(75, 23);
            this.AfegirReserva.TabIndex = 14;
            this.AfegirReserva.Text = "Afegir";
            this.AfegirReserva.UseVisualStyleBackColor = true;
            // 
            // labelClientReserva
            // 
            this.labelClientReserva.AutoSize = true;
            this.labelClientReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientReserva.Location = new System.Drawing.Point(991, 443);
            this.labelClientReserva.Name = "labelClientReserva";
            this.labelClientReserva.Size = new System.Drawing.Size(43, 13);
            this.labelClientReserva.TabIndex = 13;
            this.labelClientReserva.Text = "Client:";
            // 
            // labelPensioReserva
            // 
            this.labelPensioReserva.AutoSize = true;
            this.labelPensioReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPensioReserva.Location = new System.Drawing.Point(815, 443);
            this.labelPensioReserva.Name = "labelPensioReserva";
            this.labelPensioReserva.Size = new System.Drawing.Size(49, 13);
            this.labelPensioReserva.TabIndex = 12;
            this.labelPensioReserva.Text = "Pensio:";
            // 
            // labelBestretaReserva
            // 
            this.labelBestretaReserva.AutoSize = true;
            this.labelBestretaReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBestretaReserva.Location = new System.Drawing.Point(659, 444);
            this.labelBestretaReserva.Name = "labelBestretaReserva";
            this.labelBestretaReserva.Size = new System.Drawing.Size(58, 13);
            this.labelBestretaReserva.TabIndex = 11;
            this.labelBestretaReserva.Text = "Bestreta:";
            // 
            // labelDataFinalReserva
            // 
            this.labelDataFinalReserva.AutoSize = true;
            this.labelDataFinalReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataFinalReserva.Location = new System.Drawing.Point(503, 443);
            this.labelDataFinalReserva.Name = "labelDataFinalReserva";
            this.labelDataFinalReserva.Size = new System.Drawing.Size(69, 13);
            this.labelDataFinalReserva.TabIndex = 10;
            this.labelDataFinalReserva.Text = "Data Final:";
            // 
            // labelDataIniciReserva
            // 
            this.labelDataIniciReserva.AutoSize = true;
            this.labelDataIniciReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataIniciReserva.Location = new System.Drawing.Point(372, 444);
            this.labelDataIniciReserva.Name = "labelDataIniciReserva";
            this.labelDataIniciReserva.Size = new System.Drawing.Size(66, 13);
            this.labelDataIniciReserva.TabIndex = 9;
            this.labelDataIniciReserva.Text = "Data Inici:";
            // 
            // labelIdReserva
            // 
            this.labelIdReserva.AutoSize = true;
            this.labelIdReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdReserva.Location = new System.Drawing.Point(93, 443);
            this.labelIdReserva.Name = "labelIdReserva";
            this.labelIdReserva.Size = new System.Drawing.Size(68, 13);
            this.labelIdReserva.TabIndex = 8;
            this.labelIdReserva.Text = "Id reserva:";
            // 
            // titolReserva
            // 
            this.titolReserva.AutoSize = true;
            this.titolReserva.Location = new System.Drawing.Point(523, 33);
            this.titolReserva.Name = "titolReserva";
            this.titolReserva.Size = new System.Drawing.Size(80, 13);
            this.titolReserva.TabIndex = 7;
            this.titolReserva.Text = "Gestió Reserva";
            // 
            // clientReserva
            // 
            this.clientReserva.FormattingEnabled = true;
            this.clientReserva.Location = new System.Drawing.Point(961, 476);
            this.clientReserva.Name = "clientReserva";
            this.clientReserva.Size = new System.Drawing.Size(121, 21);
            this.clientReserva.TabIndex = 6;
            // 
            // pensioReserva
            // 
            this.pensioReserva.FormattingEnabled = true;
            this.pensioReserva.Location = new System.Drawing.Point(791, 476);
            this.pensioReserva.Name = "pensioReserva";
            this.pensioReserva.Size = new System.Drawing.Size(121, 21);
            this.pensioReserva.TabIndex = 5;
            // 
            // Bestreta
            // 
            this.Bestreta.Location = new System.Drawing.Point(642, 476);
            this.Bestreta.Name = "Bestreta";
            this.Bestreta.Size = new System.Drawing.Size(100, 20);
            this.Bestreta.TabIndex = 4;
            // 
            // idReserva
            // 
            this.idReserva.Location = new System.Drawing.Point(73, 476);
            this.idReserva.Name = "idReserva";
            this.idReserva.Size = new System.Drawing.Size(100, 20);
            this.idReserva.TabIndex = 1;
            // 
            // dgvReserva
            // 
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserva.Location = new System.Drawing.Point(86, 101);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.ReadOnly = true;
            this.dgvReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReserva.Size = new System.Drawing.Size(1023, 317);
            this.dgvReserva.TabIndex = 0;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(104, 4);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1164, 662);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Modificar Client";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.verticalMenuHab);
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1358, 718);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Habitacions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // verticalMenuHab
            // 
            this.verticalMenuHab.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.verticalMenuHab.Controls.Add(this.tabPage10);
            this.verticalMenuHab.Controls.Add(this.tabPage11);
            this.verticalMenuHab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.verticalMenuHab.ItemSize = new System.Drawing.Size(25, 100);
            this.verticalMenuHab.Location = new System.Drawing.Point(0, 0);
            this.verticalMenuHab.Multiline = true;
            this.verticalMenuHab.Name = "verticalMenuHab";
            this.verticalMenuHab.SelectedIndex = 0;
            this.verticalMenuHab.Size = new System.Drawing.Size(1272, 670);
            this.verticalMenuHab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.verticalMenuHab.TabIndex = 1;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(104, 4);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(1164, 662);
            this.tabPage10.TabIndex = 0;
            this.tabPage10.Text = "Afegir client";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(104, 4);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(1164, 662);
            this.tabPage11.TabIndex = 1;
            this.tabPage11.Text = "Modificar Client";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.verticalMenuRes);
            this.tabPage3.Location = new System.Drawing.Point(4, 46);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1358, 718);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Hostes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // verticalMenuRes
            // 
            this.verticalMenuRes.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.verticalMenuRes.Controls.Add(this.tabPage12);
            this.verticalMenuRes.Controls.Add(this.tabPage13);
            this.verticalMenuRes.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.verticalMenuRes.ItemSize = new System.Drawing.Size(25, 100);
            this.verticalMenuRes.Location = new System.Drawing.Point(0, 0);
            this.verticalMenuRes.Multiline = true;
            this.verticalMenuRes.Name = "verticalMenuRes";
            this.verticalMenuRes.SelectedIndex = 0;
            this.verticalMenuRes.Size = new System.Drawing.Size(1272, 670);
            this.verticalMenuRes.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.verticalMenuRes.TabIndex = 1;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(104, 4);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(1164, 662);
            this.tabPage12.TabIndex = 0;
            this.tabPage12.Text = "Afegir client";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabPage13
            // 
            this.tabPage13.Location = new System.Drawing.Point(104, 4);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(1164, 662);
            this.tabPage13.TabIndex = 1;
            this.tabPage13.Text = "Modificar Client";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.verticalMenuOcu);
            this.tabPage4.Location = new System.Drawing.Point(4, 46);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1358, 718);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Ocupacions";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // verticalMenuOcu
            // 
            this.verticalMenuOcu.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.verticalMenuOcu.Controls.Add(this.tabPage14);
            this.verticalMenuOcu.Controls.Add(this.tabPage15);
            this.verticalMenuOcu.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.verticalMenuOcu.ItemSize = new System.Drawing.Size(25, 100);
            this.verticalMenuOcu.Location = new System.Drawing.Point(0, 0);
            this.verticalMenuOcu.Multiline = true;
            this.verticalMenuOcu.Name = "verticalMenuOcu";
            this.verticalMenuOcu.SelectedIndex = 0;
            this.verticalMenuOcu.Size = new System.Drawing.Size(1272, 670);
            this.verticalMenuOcu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.verticalMenuOcu.TabIndex = 1;
            // 
            // tabPage14
            // 
            this.tabPage14.Location = new System.Drawing.Point(104, 4);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(1164, 662);
            this.tabPage14.TabIndex = 0;
            this.tabPage14.Text = "Afegir client";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // tabPage15
            // 
            this.tabPage15.Location = new System.Drawing.Point(104, 4);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage15.Size = new System.Drawing.Size(1164, 662);
            this.tabPage15.TabIndex = 1;
            this.tabPage15.Text = "Modificar Client";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.verticalMenuSer);
            this.tabPage5.Location = new System.Drawing.Point(4, 46);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1358, 718);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Serveis";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // verticalMenuSer
            // 
            this.verticalMenuSer.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.verticalMenuSer.Controls.Add(this.tabPage16);
            this.verticalMenuSer.Controls.Add(this.tabPage17);
            this.verticalMenuSer.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.verticalMenuSer.ItemSize = new System.Drawing.Size(25, 100);
            this.verticalMenuSer.Location = new System.Drawing.Point(0, 0);
            this.verticalMenuSer.Multiline = true;
            this.verticalMenuSer.Name = "verticalMenuSer";
            this.verticalMenuSer.SelectedIndex = 0;
            this.verticalMenuSer.Size = new System.Drawing.Size(1272, 670);
            this.verticalMenuSer.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.verticalMenuSer.TabIndex = 1;
            // 
            // tabPage16
            // 
            this.tabPage16.Location = new System.Drawing.Point(104, 4);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage16.Size = new System.Drawing.Size(1164, 662);
            this.tabPage16.TabIndex = 0;
            this.tabPage16.Text = "Afegir client";
            this.tabPage16.UseVisualStyleBackColor = true;
            // 
            // tabPage17
            // 
            this.tabPage17.Location = new System.Drawing.Point(104, 4);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage17.Size = new System.Drawing.Size(1164, 662);
            this.tabPage17.TabIndex = 1;
            this.tabPage17.Text = "Modificar Client";
            this.tabPage17.UseVisualStyleBackColor = true;
            // 
            // labelpreuTotalReserva
            // 
            this.labelpreuTotalReserva.AutoSize = true;
            this.labelpreuTotalReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpreuTotalReserva.Location = new System.Drawing.Point(236, 443);
            this.labelpreuTotalReserva.Name = "labelpreuTotalReserva";
            this.labelpreuTotalReserva.Size = new System.Drawing.Size(37, 13);
            this.labelpreuTotalReserva.TabIndex = 18;
            this.labelpreuTotalReserva.Text = "Preu:";
            // 
            // preuTotalReserva
            // 
            this.preuTotalReserva.Location = new System.Drawing.Point(216, 476);
            this.preuTotalReserva.Name = "preuTotalReserva";
            this.preuTotalReserva.Size = new System.Drawing.Size(100, 20);
            this.preuTotalReserva.TabIndex = 17;
            // 
            // dataIniciReserva
            // 
            this.dataIniciReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataIniciReserva.Location = new System.Drawing.Point(370, 476);
            this.dataIniciReserva.Name = "dataIniciReserva";
            this.dataIniciReserva.Size = new System.Drawing.Size(82, 20);
            this.dataIniciReserva.TabIndex = 19;
            // 
            // dataFinalReserva
            // 
            this.dataFinalReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFinalReserva.Location = new System.Drawing.Point(506, 473);
            this.dataFinalReserva.Name = "dataFinalReserva";
            this.dataFinalReserva.Size = new System.Drawing.Size(82, 20);
            this.dataFinalReserva.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Clients.ResumeLayout(false);
            this.verticalMenuClients.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.verticalMenuHostes.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.verticalMenuHab.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.verticalMenuRes.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.verticalMenuOcu.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.verticalMenuSer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage Clients;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.TabControl verticalMenuClients;
        public System.Windows.Forms.TabPage tabPage6;
        public System.Windows.Forms.TabPage tabPage7;
        public System.Windows.Forms.TabControl verticalMenuHostes;
        public System.Windows.Forms.TabPage tabPage8;
        public System.Windows.Forms.TabPage tabPage9;
        public System.Windows.Forms.TabControl verticalMenuHab;
        public System.Windows.Forms.TabPage tabPage10;
        public System.Windows.Forms.TabPage tabPage11;
        public System.Windows.Forms.TabControl verticalMenuRes;
        public System.Windows.Forms.TabPage tabPage12;
        public System.Windows.Forms.TabPage tabPage13;
        public System.Windows.Forms.TabControl verticalMenuOcu;
        public System.Windows.Forms.TabPage tabPage14;
        public System.Windows.Forms.TabPage tabPage15;
        public System.Windows.Forms.TabControl verticalMenuSer;
        public System.Windows.Forms.TabPage tabPage16;
        public System.Windows.Forms.TabPage tabPage17;
        public System.Windows.Forms.TabPage tabPage18;
        public System.Windows.Forms.Label titolReserva;
        public System.Windows.Forms.ComboBox clientReserva;
        public System.Windows.Forms.ComboBox pensioReserva;
        public System.Windows.Forms.TextBox Bestreta;
        public System.Windows.Forms.TextBox idReserva;
        public System.Windows.Forms.DataGridView dgvReserva;
        public System.Windows.Forms.Label labelIdReserva;
        public System.Windows.Forms.Label labelClientReserva;
        public System.Windows.Forms.Label labelPensioReserva;
        public System.Windows.Forms.Label labelBestretaReserva;
        public System.Windows.Forms.Label labelDataFinalReserva;
        public System.Windows.Forms.Label labelDataIniciReserva;
        public System.Windows.Forms.Button ModificarReserva;
        public System.Windows.Forms.Button EliminarReserva;
        public System.Windows.Forms.Button AfegirReserva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox tipusCB;
        public System.Windows.Forms.TextBox nomTB;
        public System.Windows.Forms.Button AfegirClient;
        public System.Windows.Forms.DataGridView dgvClients;
        public System.Windows.Forms.Button ModificarClient;
        public System.Windows.Forms.Button EliminarClient;
        public System.Windows.Forms.Label labelpreuTotalReserva;
        public System.Windows.Forms.TextBox preuTotalReserva;
        public System.Windows.Forms.DateTimePicker dataFinalReserva;
        public System.Windows.Forms.DateTimePicker dataIniciReserva;
    }
}

