
namespace Omnitec.Views.Ordenes
{
    partial class frmodificaranularordenes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmodificaranularordenes));
            this.panel_Superior = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.cmbtipo = new System.Windows.Forms.ComboBox();
            this.cmbcliente = new System.Windows.Forms.ComboBox();
            this.cmbstatusorden = new System.Windows.Forms.ComboBox();
            this.panel_lateralfiltrofechas = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.btnxrango = new Soporte.Recursos.CustomButtons();
            this.dtphasta = new System.Windows.Forms.DateTimePicker();
            this.dtpdesde = new System.Windows.Forms.DateTimePicker();
            this.rjTextBox5 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox4 = new CustomControls.RJControls.RJTextBox();
            this.btnesteaño = new Soporte.Recursos.CustomButtons();
            this.btnestemes = new Soporte.Recursos.CustomButtons();
            this.btnestasemana = new Soporte.Recursos.CustomButtons();
            this.btnhoy = new Soporte.Recursos.CustomButtons();
            this.dgvordenes = new System.Windows.Forms.DataGridView();
            this.tmExpandirMenu = new System.Windows.Forms.Timer(this.components);
            this.tmContraerMenu = new System.Windows.Forms.Timer(this.components);
            this.panel_contenido = new System.Windows.Forms.Panel();
            this.cmblimpiaflitros = new Soporte.Recursos.CustomButtons();
            this.txtfiltrodebusqueda = new CustomControls.RJControls.RJTextBox();
            this.lbltipo = new CustomControls.RJControls.RJTextBox();
            this.lblstatus = new CustomControls.RJControls.RJTextBox();
            this.btnvertodaslasordenes = new Soporte.Recursos.CustomButtons();
            this.lblcliente = new CustomControls.RJControls.RJTextBox();
            this.lbltituloform = new System.Windows.Forms.Label();
            this.panel_Superior.SuspendLayout();
            this.panel_lateralfiltrofechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenes)).BeginInit();
            this.panel_contenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Superior
            // 
            this.panel_Superior.BackColor = System.Drawing.Color.Silver;
            this.panel_Superior.Controls.Add(this.lbltituloform);
            this.panel_Superior.Controls.Add(this.BtnCerrar);
            this.panel_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Superior.Location = new System.Drawing.Point(0, 0);
            this.panel_Superior.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Superior.Name = "panel_Superior";
            this.panel_Superior.Size = new System.Drawing.Size(1055, 31);
            this.panel_Superior.TabIndex = 10;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::Omnitec.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(1018, 0);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(37, 30);
            this.BtnCerrar.TabIndex = 23;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // cmbtipo
            // 
            this.cmbtipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtipo.FormattingEnabled = true;
            this.cmbtipo.Location = new System.Drawing.Point(89, 6);
            this.cmbtipo.Name = "cmbtipo";
            this.cmbtipo.Size = new System.Drawing.Size(239, 28);
            this.cmbtipo.TabIndex = 105;
            this.cmbtipo.SelectedIndexChanged += new System.EventHandler(this.cmbtipo_SelectedIndexChanged);
            // 
            // cmbcliente
            // 
            this.cmbcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.Location = new System.Drawing.Point(418, 8);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.Size = new System.Drawing.Size(311, 28);
            this.cmbcliente.TabIndex = 103;
            this.cmbcliente.SelectedIndexChanged += new System.EventHandler(this.cmbcliente_SelectedIndexChanged);
            // 
            // cmbstatusorden
            // 
            this.cmbstatusorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstatusorden.FormattingEnabled = true;
            this.cmbstatusorden.Location = new System.Drawing.Point(89, 45);
            this.cmbstatusorden.Name = "cmbstatusorden";
            this.cmbstatusorden.Size = new System.Drawing.Size(239, 28);
            this.cmbstatusorden.TabIndex = 108;
            this.cmbstatusorden.SelectedIndexChanged += new System.EventHandler(this.cmbstatusorden_SelectedIndexChanged);
            // 
            // panel_lateralfiltrofechas
            // 
            this.panel_lateralfiltrofechas.BackColor = System.Drawing.Color.LightGreen;
            this.panel_lateralfiltrofechas.Controls.Add(this.btnMenu);
            this.panel_lateralfiltrofechas.Controls.Add(this.btnxrango);
            this.panel_lateralfiltrofechas.Controls.Add(this.dtphasta);
            this.panel_lateralfiltrofechas.Controls.Add(this.dtpdesde);
            this.panel_lateralfiltrofechas.Controls.Add(this.rjTextBox5);
            this.panel_lateralfiltrofechas.Controls.Add(this.rjTextBox4);
            this.panel_lateralfiltrofechas.Controls.Add(this.btnesteaño);
            this.panel_lateralfiltrofechas.Controls.Add(this.btnestemes);
            this.panel_lateralfiltrofechas.Controls.Add(this.btnestasemana);
            this.panel_lateralfiltrofechas.Controls.Add(this.btnhoy);
            this.panel_lateralfiltrofechas.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_lateralfiltrofechas.Location = new System.Drawing.Point(0, 31);
            this.panel_lateralfiltrofechas.Name = "panel_lateralfiltrofechas";
            this.panel_lateralfiltrofechas.Size = new System.Drawing.Size(165, 419);
            this.panel_lateralfiltrofechas.TabIndex = 109;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::Omnitec.Properties.Resources.menu2;
            this.btnMenu.Location = new System.Drawing.Point(120, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(43, 36);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMenu.TabIndex = 116;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnxrango
            // 
            this.btnxrango.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnxrango.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnxrango.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnxrango.BorderColor = System.Drawing.Color.Black;
            this.btnxrango.BorderColor1 = System.Drawing.Color.Black;
            this.btnxrango.BorderRadius = 15;
            this.btnxrango.BorderRadius1 = 15;
            this.btnxrango.BorderSize = 5;
            this.btnxrango.BorderSize1 = 5;
            this.btnxrango.FlatAppearance.BorderSize = 0;
            this.btnxrango.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxrango.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxrango.ForeColor = System.Drawing.Color.White;
            this.btnxrango.Location = new System.Drawing.Point(7, 354);
            this.btnxrango.Name = "btnxrango";
            this.btnxrango.Size = new System.Drawing.Size(150, 40);
            this.btnxrango.TabIndex = 115;
            this.btnxrango.Text = "X RANGO";
            this.btnxrango.TextColor = System.Drawing.Color.White;
            this.btnxrango.UseVisualStyleBackColor = false;
            this.btnxrango.Click += new System.EventHandler(this.btnxrango_Click);
            // 
            // dtphasta
            // 
            this.dtphasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtphasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtphasta.Location = new System.Drawing.Point(12, 322);
            this.dtphasta.Name = "dtphasta";
            this.dtphasta.Size = new System.Drawing.Size(118, 26);
            this.dtphasta.TabIndex = 114;
            // 
            // dtpdesde
            // 
            this.dtpdesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdesde.Location = new System.Drawing.Point(12, 254);
            this.dtpdesde.Name = "dtpdesde";
            this.dtpdesde.Size = new System.Drawing.Size(118, 26);
            this.dtpdesde.TabIndex = 113;
            // 
            // rjTextBox5
            // 
            this.rjTextBox5.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox5.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox5.BorderSize = 2;
            this.rjTextBox5.Enabled = false;
            this.rjTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox5.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox5.Location = new System.Drawing.Point(38, 284);
            this.rjTextBox5.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox5.Multiline = false;
            this.rjTextBox5.Name = "rjTextBox5";
            this.rjTextBox5.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox5.PasswordChar = false;
            this.rjTextBox5.Size = new System.Drawing.Size(66, 31);
            this.rjTextBox5.TabIndex = 112;
            this.rjTextBox5.Texts = "HASTA";
            this.rjTextBox5.UnderlinedStyle = false;
            // 
            // rjTextBox4
            // 
            this.rjTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox4.BorderSize = 2;
            this.rjTextBox4.Enabled = false;
            this.rjTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox4.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox4.Location = new System.Drawing.Point(38, 216);
            this.rjTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox4.Multiline = false;
            this.rjTextBox4.Name = "rjTextBox4";
            this.rjTextBox4.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox4.PasswordChar = false;
            this.rjTextBox4.Size = new System.Drawing.Size(66, 31);
            this.rjTextBox4.TabIndex = 111;
            this.rjTextBox4.Texts = "DESDE";
            this.rjTextBox4.UnderlinedStyle = false;
            // 
            // btnesteaño
            // 
            this.btnesteaño.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnesteaño.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnesteaño.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnesteaño.BorderColor = System.Drawing.Color.Black;
            this.btnesteaño.BorderColor1 = System.Drawing.Color.Black;
            this.btnesteaño.BorderRadius = 15;
            this.btnesteaño.BorderRadius1 = 15;
            this.btnesteaño.BorderSize = 5;
            this.btnesteaño.BorderSize1 = 5;
            this.btnesteaño.FlatAppearance.BorderSize = 0;
            this.btnesteaño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnesteaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnesteaño.ForeColor = System.Drawing.Color.White;
            this.btnesteaño.Location = new System.Drawing.Point(7, 170);
            this.btnesteaño.Name = "btnesteaño";
            this.btnesteaño.Size = new System.Drawing.Size(150, 40);
            this.btnesteaño.TabIndex = 110;
            this.btnesteaño.Text = "ESTE AÑO";
            this.btnesteaño.TextColor = System.Drawing.Color.White;
            this.btnesteaño.UseVisualStyleBackColor = false;
            this.btnesteaño.Click += new System.EventHandler(this.btnesteaño_Click);
            // 
            // btnestemes
            // 
            this.btnestemes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnestemes.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnestemes.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnestemes.BorderColor = System.Drawing.Color.Black;
            this.btnestemes.BorderColor1 = System.Drawing.Color.Black;
            this.btnestemes.BorderRadius = 15;
            this.btnestemes.BorderRadius1 = 15;
            this.btnestemes.BorderSize = 5;
            this.btnestemes.BorderSize1 = 5;
            this.btnestemes.FlatAppearance.BorderSize = 0;
            this.btnestemes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnestemes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnestemes.ForeColor = System.Drawing.Color.White;
            this.btnestemes.Location = new System.Drawing.Point(7, 127);
            this.btnestemes.Name = "btnestemes";
            this.btnestemes.Size = new System.Drawing.Size(150, 40);
            this.btnestemes.TabIndex = 109;
            this.btnestemes.Text = "ESTE MES";
            this.btnestemes.TextColor = System.Drawing.Color.White;
            this.btnestemes.UseVisualStyleBackColor = false;
            this.btnestemes.Click += new System.EventHandler(this.btnestemes_Click);
            // 
            // btnestasemana
            // 
            this.btnestasemana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnestasemana.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnestasemana.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnestasemana.BorderColor = System.Drawing.Color.Black;
            this.btnestasemana.BorderColor1 = System.Drawing.Color.Black;
            this.btnestasemana.BorderRadius = 15;
            this.btnestasemana.BorderRadius1 = 15;
            this.btnestasemana.BorderSize = 5;
            this.btnestasemana.BorderSize1 = 5;
            this.btnestasemana.FlatAppearance.BorderSize = 0;
            this.btnestasemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnestasemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnestasemana.ForeColor = System.Drawing.Color.White;
            this.btnestasemana.Location = new System.Drawing.Point(7, 83);
            this.btnestasemana.Name = "btnestasemana";
            this.btnestasemana.Size = new System.Drawing.Size(150, 40);
            this.btnestasemana.TabIndex = 108;
            this.btnestasemana.Text = "ESTA SEMANA";
            this.btnestasemana.TextColor = System.Drawing.Color.White;
            this.btnestasemana.UseVisualStyleBackColor = false;
            this.btnestasemana.Click += new System.EventHandler(this.btnestasemana_Click);
            // 
            // btnhoy
            // 
            this.btnhoy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnhoy.BackColor = System.Drawing.Color.Red;
            this.btnhoy.BackgroundColor = System.Drawing.Color.Red;
            this.btnhoy.BorderColor = System.Drawing.Color.Black;
            this.btnhoy.BorderColor1 = System.Drawing.Color.Black;
            this.btnhoy.BorderRadius = 15;
            this.btnhoy.BorderRadius1 = 15;
            this.btnhoy.BorderSize = 5;
            this.btnhoy.BorderSize1 = 5;
            this.btnhoy.FlatAppearance.BorderSize = 0;
            this.btnhoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhoy.ForeColor = System.Drawing.Color.White;
            this.btnhoy.Location = new System.Drawing.Point(7, 41);
            this.btnhoy.Name = "btnhoy";
            this.btnhoy.Size = new System.Drawing.Size(150, 40);
            this.btnhoy.TabIndex = 107;
            this.btnhoy.Text = "HOY";
            this.btnhoy.TextColor = System.Drawing.Color.White;
            this.btnhoy.UseVisualStyleBackColor = false;
            this.btnhoy.Click += new System.EventHandler(this.btnhoy_Click);
            // 
            // dgvordenes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvordenes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvordenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvordenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvordenes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.dgvordenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvordenes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvordenes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvordenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvordenes.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvordenes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvordenes.EnableHeadersVisualStyles = false;
            this.dgvordenes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dgvordenes.Location = new System.Drawing.Point(6, 79);
            this.dgvordenes.Name = "dgvordenes";
            this.dgvordenes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvordenes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvordenes.Size = new System.Drawing.Size(881, 336);
            this.dgvordenes.TabIndex = 110;
            this.dgvordenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvordenes_CellContentClick);
            // 
            // tmExpandirMenu
            // 
            this.tmExpandirMenu.Interval = 15;
            this.tmExpandirMenu.Tick += new System.EventHandler(this.tmExpandirMenu_Tick);
            // 
            // tmContraerMenu
            // 
            this.tmContraerMenu.Interval = 15;
            this.tmContraerMenu.Tick += new System.EventHandler(this.tmContraerMenu_Tick);
            // 
            // panel_contenido
            // 
            this.panel_contenido.Controls.Add(this.cmblimpiaflitros);
            this.panel_contenido.Controls.Add(this.txtfiltrodebusqueda);
            this.panel_contenido.Controls.Add(this.lbltipo);
            this.panel_contenido.Controls.Add(this.dgvordenes);
            this.panel_contenido.Controls.Add(this.cmbtipo);
            this.panel_contenido.Controls.Add(this.lblstatus);
            this.panel_contenido.Controls.Add(this.btnvertodaslasordenes);
            this.panel_contenido.Controls.Add(this.cmbstatusorden);
            this.panel_contenido.Controls.Add(this.cmbcliente);
            this.panel_contenido.Controls.Add(this.lblcliente);
            this.panel_contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenido.Location = new System.Drawing.Point(165, 31);
            this.panel_contenido.Name = "panel_contenido";
            this.panel_contenido.Size = new System.Drawing.Size(890, 419);
            this.panel_contenido.TabIndex = 111;
            // 
            // cmblimpiaflitros
            // 
            this.cmblimpiaflitros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmblimpiaflitros.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cmblimpiaflitros.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cmblimpiaflitros.BorderColor = System.Drawing.Color.Black;
            this.cmblimpiaflitros.BorderColor1 = System.Drawing.Color.Black;
            this.cmblimpiaflitros.BorderRadius = 15;
            this.cmblimpiaflitros.BorderRadius1 = 15;
            this.cmblimpiaflitros.BorderSize = 5;
            this.cmblimpiaflitros.BorderSize1 = 5;
            this.cmblimpiaflitros.FlatAppearance.BorderSize = 0;
            this.cmblimpiaflitros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmblimpiaflitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmblimpiaflitros.ForeColor = System.Drawing.Color.White;
            this.cmblimpiaflitros.Location = new System.Drawing.Point(736, 39);
            this.cmblimpiaflitros.Name = "cmblimpiaflitros";
            this.cmblimpiaflitros.Size = new System.Drawing.Size(151, 40);
            this.cmblimpiaflitros.TabIndex = 112;
            this.cmblimpiaflitros.Text = "LIMPIA FILTROS";
            this.cmblimpiaflitros.TextColor = System.Drawing.Color.White;
            this.cmblimpiaflitros.UseVisualStyleBackColor = false;
            this.cmblimpiaflitros.Click += new System.EventHandler(this.cmblimpiaflitros_Click);
            // 
            // txtfiltrodebusqueda
            // 
            this.txtfiltrodebusqueda.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtfiltrodebusqueda.BorderColor = System.Drawing.Color.Black;
            this.txtfiltrodebusqueda.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtfiltrodebusqueda.BorderSize = 2;
            this.txtfiltrodebusqueda.Enabled = false;
            this.txtfiltrodebusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfiltrodebusqueda.ForeColor = System.Drawing.Color.White;
            this.txtfiltrodebusqueda.Location = new System.Drawing.Point(335, 41);
            this.txtfiltrodebusqueda.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtfiltrodebusqueda.Multiline = false;
            this.txtfiltrodebusqueda.Name = "txtfiltrodebusqueda";
            this.txtfiltrodebusqueda.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtfiltrodebusqueda.PasswordChar = false;
            this.txtfiltrodebusqueda.Size = new System.Drawing.Size(392, 35);
            this.txtfiltrodebusqueda.TabIndex = 111;
            this.txtfiltrodebusqueda.Texts = "";
            this.txtfiltrodebusqueda.UnderlinedStyle = false;
            // 
            // lbltipo
            // 
            this.lbltipo.BackColor = System.Drawing.SystemColors.Window;
            this.lbltipo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.lbltipo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lbltipo.BorderSize = 2;
            this.lbltipo.Enabled = false;
            this.lbltipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.ForeColor = System.Drawing.Color.DimGray;
            this.lbltipo.Location = new System.Drawing.Point(4, 5);
            this.lbltipo.Margin = new System.Windows.Forms.Padding(4);
            this.lbltipo.Multiline = false;
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Padding = new System.Windows.Forms.Padding(7);
            this.lbltipo.PasswordChar = false;
            this.lbltipo.Size = new System.Drawing.Size(85, 31);
            this.lbltipo.TabIndex = 104;
            this.lbltipo.Texts = "TIPO";
            this.lbltipo.UnderlinedStyle = false;
            // 
            // lblstatus
            // 
            this.lblstatus.BackColor = System.Drawing.SystemColors.Window;
            this.lblstatus.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.lblstatus.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lblstatus.BorderSize = 2;
            this.lblstatus.Enabled = false;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.ForeColor = System.Drawing.Color.DimGray;
            this.lblstatus.Location = new System.Drawing.Point(4, 44);
            this.lblstatus.Margin = new System.Windows.Forms.Padding(4);
            this.lblstatus.Multiline = false;
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Padding = new System.Windows.Forms.Padding(7);
            this.lblstatus.PasswordChar = false;
            this.lblstatus.Size = new System.Drawing.Size(85, 31);
            this.lblstatus.TabIndex = 107;
            this.lblstatus.Texts = "STATUS";
            this.lblstatus.UnderlinedStyle = false;
            // 
            // btnvertodaslasordenes
            // 
            this.btnvertodaslasordenes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnvertodaslasordenes.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnvertodaslasordenes.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnvertodaslasordenes.BorderColor = System.Drawing.Color.Black;
            this.btnvertodaslasordenes.BorderColor1 = System.Drawing.Color.Black;
            this.btnvertodaslasordenes.BorderRadius = 15;
            this.btnvertodaslasordenes.BorderRadius1 = 15;
            this.btnvertodaslasordenes.BorderSize = 5;
            this.btnvertodaslasordenes.BorderSize1 = 5;
            this.btnvertodaslasordenes.FlatAppearance.BorderSize = 0;
            this.btnvertodaslasordenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvertodaslasordenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvertodaslasordenes.ForeColor = System.Drawing.Color.White;
            this.btnvertodaslasordenes.Location = new System.Drawing.Point(767, 0);
            this.btnvertodaslasordenes.Name = "btnvertodaslasordenes";
            this.btnvertodaslasordenes.Size = new System.Drawing.Size(120, 40);
            this.btnvertodaslasordenes.TabIndex = 106;
            this.btnvertodaslasordenes.Text = "VER TODAS";
            this.btnvertodaslasordenes.TextColor = System.Drawing.Color.White;
            this.btnvertodaslasordenes.UseVisualStyleBackColor = false;
            this.btnvertodaslasordenes.Click += new System.EventHandler(this.btnvertodaslasordenes_Click);
            // 
            // lblcliente
            // 
            this.lblcliente.BackColor = System.Drawing.SystemColors.Window;
            this.lblcliente.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.lblcliente.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lblcliente.BorderSize = 2;
            this.lblcliente.Enabled = false;
            this.lblcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.ForeColor = System.Drawing.Color.DimGray;
            this.lblcliente.Location = new System.Drawing.Point(335, 6);
            this.lblcliente.Margin = new System.Windows.Forms.Padding(4);
            this.lblcliente.Multiline = false;
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Padding = new System.Windows.Forms.Padding(7);
            this.lblcliente.PasswordChar = false;
            this.lblcliente.Size = new System.Drawing.Size(85, 31);
            this.lblcliente.TabIndex = 102;
            this.lblcliente.Texts = "CLIENTE";
            this.lblcliente.UnderlinedStyle = false;
            // 
            // lbltituloform
            // 
            this.lbltituloform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbltituloform.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltituloform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltituloform.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloform.Location = new System.Drawing.Point(0, 0);
            this.lbltituloform.Name = "lbltituloform";
            this.lbltituloform.Size = new System.Drawing.Size(420, 30);
            this.lbltituloform.TabIndex = 28;
            this.lbltituloform.Text = "AGREGAR ORDEN DE RECEPCION";
            this.lbltituloform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmodificaranularordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1055, 450);
            this.Controls.Add(this.panel_contenido);
            this.Controls.Add(this.panel_lateralfiltrofechas);
            this.Controls.Add(this.panel_Superior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmodificaranularordenes";
            this.Text = "frmodificaranularordenes";
            this.Load += new System.EventHandler(this.frmodificaranularordenes_Load);
            this.panel_Superior.ResumeLayout(false);
            this.panel_lateralfiltrofechas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenes)).EndInit();
            this.panel_contenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Superior;
        private System.Windows.Forms.Button BtnCerrar;
        private Soporte.Recursos.CustomButtons btnvertodaslasordenes;
        private System.Windows.Forms.ComboBox cmbtipo;
        private CustomControls.RJControls.RJTextBox lbltipo;
        private System.Windows.Forms.ComboBox cmbcliente;
        private CustomControls.RJControls.RJTextBox lblcliente;
        private System.Windows.Forms.ComboBox cmbstatusorden;
        private CustomControls.RJControls.RJTextBox lblstatus;
        private System.Windows.Forms.Panel panel_lateralfiltrofechas;
        private Soporte.Recursos.CustomButtons btnxrango;
        private System.Windows.Forms.DateTimePicker dtphasta;
        private System.Windows.Forms.DateTimePicker dtpdesde;
        private CustomControls.RJControls.RJTextBox rjTextBox5;
        private CustomControls.RJControls.RJTextBox rjTextBox4;
        private Soporte.Recursos.CustomButtons btnesteaño;
        private Soporte.Recursos.CustomButtons btnestemes;
        private Soporte.Recursos.CustomButtons btnestasemana;
        private Soporte.Recursos.CustomButtons btnhoy;
        private System.Windows.Forms.DataGridView dgvordenes;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Timer tmExpandirMenu;
        private System.Windows.Forms.Timer tmContraerMenu;
        private System.Windows.Forms.Panel panel_contenido;
        public CustomControls.RJControls.RJTextBox txtfiltrodebusqueda;
        private Soporte.Recursos.CustomButtons cmblimpiaflitros;
        public System.Windows.Forms.Label lbltituloform;
    }
}