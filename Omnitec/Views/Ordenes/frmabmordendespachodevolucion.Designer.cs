
namespace Omnitec.Views.Ordenes
{
    partial class frmabmordendespachodevolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmabmordendespachodevolucion));
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.dgvordenparasoc = new System.Windows.Forms.DataGridView();
            this.asociar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.errorProvider_camposform = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelsuperior = new Guna.UI.WinForms.GunaGradientPanel();
            this.lbltituloform = new System.Windows.Forms.Label();
            this.panelcontenedorcabecera = new Guna.UI.WinForms.GunaGradientPanel();
            this.txtobservacionesaltaorden = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.cmbcliente = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lblfecha = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.panelcontenedordatostransporte = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.cmbacoplado = new Guna.UI.WinForms.GunaComboBox();
            this.txtacoplado = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.cmbchasis = new Guna.UI.WinForms.GunaComboBox();
            this.txtchasis = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.txtdnichofer = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.txtchofer = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtcomprobante = new Guna.UI.WinForms.GunaTextBox();
            this.btnguardarcambiosorden = new Guna.UI.WinForms.GunaButton();
            this.btnanulareabreorden = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenparasoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_camposform)).BeginInit();
            this.panelsuperior.SuspendLayout();
            this.panelcontenedorcabecera.SuspendLayout();
            this.panelcontenedordatostransporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::Omnitec.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(856, 0);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(38, 31);
            this.BtnCerrar.TabIndex = 23;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // dgvordenparasoc
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvordenparasoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvordenparasoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvordenparasoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvordenparasoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.dgvordenparasoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvordenparasoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvordenparasoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvordenparasoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvordenparasoc.ColumnHeadersHeight = 30;
            this.dgvordenparasoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asociar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvordenparasoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvordenparasoc.EnableHeadersVisualStyles = false;
            this.dgvordenparasoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dgvordenparasoc.Location = new System.Drawing.Point(3, 108);
            this.dgvordenparasoc.Name = "dgvordenparasoc";
            this.dgvordenparasoc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvordenparasoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvordenparasoc.Size = new System.Drawing.Size(884, 134);
            this.dgvordenparasoc.TabIndex = 112;
            // 
            // asociar
            // 
            this.asociar.HeaderText = "Asociar";
            this.asociar.Name = "asociar";
            this.asociar.Width = 67;
            // 
            // errorProvider_camposform
            // 
            this.errorProvider_camposform.ContainerControl = this;
            // 
            // panelsuperior
            // 
            this.panelsuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelsuperior.BackgroundImage")));
            this.panelsuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelsuperior.Controls.Add(this.lbltituloform);
            this.panelsuperior.Controls.Add(this.BtnCerrar);
            this.panelsuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsuperior.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelsuperior.GradientColor2 = System.Drawing.Color.Gray;
            this.panelsuperior.GradientColor3 = System.Drawing.Color.Silver;
            this.panelsuperior.GradientColor4 = System.Drawing.Color.White;
            this.panelsuperior.Location = new System.Drawing.Point(0, 0);
            this.panelsuperior.Name = "panelsuperior";
            this.panelsuperior.Size = new System.Drawing.Size(894, 29);
            this.panelsuperior.TabIndex = 141;
            this.panelsuperior.Text = "gunaGradientPanel1";
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
            this.lbltituloform.TabIndex = 26;
            this.lbltituloform.Text = "AGREGAR ORDEN DE RECEPCION";
            this.lbltituloform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelcontenedorcabecera
            // 
            this.panelcontenedorcabecera.BackColor = System.Drawing.SystemColors.Control;
            this.panelcontenedorcabecera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelcontenedorcabecera.BackgroundImage")));
            this.panelcontenedorcabecera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcontenedorcabecera.Controls.Add(this.txtobservacionesaltaorden);
            this.panelcontenedorcabecera.Controls.Add(this.gunaLabel13);
            this.panelcontenedorcabecera.Controls.Add(this.cmbcliente);
            this.panelcontenedorcabecera.Controls.Add(this.gunaLabel2);
            this.panelcontenedorcabecera.Controls.Add(this.lblfecha);
            this.panelcontenedorcabecera.Controls.Add(this.gunaLabel4);
            this.panelcontenedorcabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelcontenedorcabecera.GradientColor1 = System.Drawing.Color.Silver;
            this.panelcontenedorcabecera.GradientColor2 = System.Drawing.Color.White;
            this.panelcontenedorcabecera.GradientColor3 = System.Drawing.Color.White;
            this.panelcontenedorcabecera.GradientColor4 = System.Drawing.Color.White;
            this.panelcontenedorcabecera.Location = new System.Drawing.Point(0, 29);
            this.panelcontenedorcabecera.Name = "panelcontenedorcabecera";
            this.panelcontenedorcabecera.Size = new System.Drawing.Size(894, 120);
            this.panelcontenedorcabecera.TabIndex = 142;
            this.panelcontenedorcabecera.Text = "gunaGradientPanel1";
            // 
            // txtobservacionesaltaorden
            // 
            this.txtobservacionesaltaorden.BaseColor = System.Drawing.Color.White;
            this.txtobservacionesaltaorden.BorderColor = System.Drawing.Color.Silver;
            this.txtobservacionesaltaorden.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtobservacionesaltaorden.FocusedBaseColor = System.Drawing.Color.White;
            this.txtobservacionesaltaorden.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtobservacionesaltaorden.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtobservacionesaltaorden.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtobservacionesaltaorden.Location = new System.Drawing.Point(3, 68);
            this.txtobservacionesaltaorden.MultiLine = true;
            this.txtobservacionesaltaorden.Name = "txtobservacionesaltaorden";
            this.txtobservacionesaltaorden.PasswordChar = '\0';
            this.txtobservacionesaltaorden.Size = new System.Drawing.Size(855, 45);
            this.txtobservacionesaltaorden.TabIndex = 28;
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel13.Location = new System.Drawing.Point(3, 42);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(178, 23);
            this.gunaLabel13.TabIndex = 27;
            this.gunaLabel13.Text = "OBSERVACIONES";
            this.gunaLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbcliente
            // 
            this.cmbcliente.BackColor = System.Drawing.Color.Transparent;
            this.cmbcliente.BaseColor = System.Drawing.Color.White;
            this.cmbcliente.BorderColor = System.Drawing.Color.Silver;
            this.cmbcliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcliente.FocusedColor = System.Drawing.Color.Empty;
            this.cmbcliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbcliente.ForeColor = System.Drawing.Color.Black;
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.Location = new System.Drawing.Point(319, 9);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbcliente.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbcliente.Size = new System.Drawing.Size(502, 26);
            this.cmbcliente.TabIndex = 18;
            this.cmbcliente.SelectedIndexChanged += new System.EventHandler(this.cmbcliente_SelectedIndexChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(241, 9);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(79, 26);
            this.gunaLabel2.TabIndex = 17;
            this.gunaLabel2.Text = "CLIENTE";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblfecha
            // 
            this.lblfecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblfecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblfecha.Location = new System.Drawing.Point(70, 9);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(164, 23);
            this.lblfecha.TabIndex = 13;
            this.lblfecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.Location = new System.Drawing.Point(3, 9);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(67, 23);
            this.gunaLabel4.TabIndex = 0;
            this.gunaLabel4.Text = "FECHA";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelcontenedordatostransporte
            // 
            this.panelcontenedordatostransporte.BackColor = System.Drawing.SystemColors.Control;
            this.panelcontenedordatostransporte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelcontenedordatostransporte.BackgroundImage")));
            this.panelcontenedordatostransporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcontenedordatostransporte.Controls.Add(this.gunaLabel3);
            this.panelcontenedordatostransporte.Controls.Add(this.cmbacoplado);
            this.panelcontenedordatostransporte.Controls.Add(this.txtacoplado);
            this.panelcontenedordatostransporte.Controls.Add(this.gunaLabel12);
            this.panelcontenedordatostransporte.Controls.Add(this.cmbchasis);
            this.panelcontenedordatostransporte.Controls.Add(this.dgvordenparasoc);
            this.panelcontenedordatostransporte.Controls.Add(this.txtchasis);
            this.panelcontenedordatostransporte.Controls.Add(this.gunaLabel11);
            this.panelcontenedordatostransporte.Controls.Add(this.txtdnichofer);
            this.panelcontenedordatostransporte.Controls.Add(this.gunaLabel10);
            this.panelcontenedordatostransporte.Controls.Add(this.txtchofer);
            this.panelcontenedordatostransporte.Controls.Add(this.gunaLabel9);
            this.panelcontenedordatostransporte.Controls.Add(this.gunaLabel1);
            this.panelcontenedordatostransporte.Controls.Add(this.txtcomprobante);
            this.panelcontenedordatostransporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelcontenedordatostransporte.GradientColor1 = System.Drawing.Color.Silver;
            this.panelcontenedordatostransporte.GradientColor2 = System.Drawing.Color.White;
            this.panelcontenedordatostransporte.GradientColor3 = System.Drawing.Color.White;
            this.panelcontenedordatostransporte.GradientColor4 = System.Drawing.Color.White;
            this.panelcontenedordatostransporte.Location = new System.Drawing.Point(0, 149);
            this.panelcontenedordatostransporte.Name = "panelcontenedordatostransporte";
            this.panelcontenedordatostransporte.Size = new System.Drawing.Size(894, 245);
            this.panelcontenedordatostransporte.TabIndex = 143;
            this.panelcontenedordatostransporte.Text = "gunaGradientPanel1";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.Location = new System.Drawing.Point(3, 81);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(144, 26);
            this.gunaLabel3.TabIndex = 32;
            this.gunaLabel3.Text = "ASOCIAR LOTE";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbacoplado
            // 
            this.cmbacoplado.BackColor = System.Drawing.Color.Transparent;
            this.cmbacoplado.BaseColor = System.Drawing.Color.White;
            this.cmbacoplado.BorderColor = System.Drawing.Color.Silver;
            this.cmbacoplado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbacoplado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbacoplado.FocusedColor = System.Drawing.Color.Empty;
            this.cmbacoplado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbacoplado.ForeColor = System.Drawing.Color.Black;
            this.cmbacoplado.FormattingEnabled = true;
            this.cmbacoplado.Location = new System.Drawing.Point(701, 43);
            this.cmbacoplado.Name = "cmbacoplado";
            this.cmbacoplado.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbacoplado.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbacoplado.Size = new System.Drawing.Size(91, 26);
            this.cmbacoplado.TabIndex = 31;
            this.cmbacoplado.SelectedIndexChanged += new System.EventHandler(this.cmbacoplado_SelectedIndexChanged);
            // 
            // txtacoplado
            // 
            this.txtacoplado.BaseColor = System.Drawing.Color.White;
            this.txtacoplado.BorderColor = System.Drawing.Color.Silver;
            this.txtacoplado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtacoplado.FocusedBaseColor = System.Drawing.Color.White;
            this.txtacoplado.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtacoplado.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtacoplado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtacoplado.Location = new System.Drawing.Point(794, 43);
            this.txtacoplado.Name = "txtacoplado";
            this.txtacoplado.PasswordChar = '\0';
            this.txtacoplado.Size = new System.Drawing.Size(93, 26);
            this.txtacoplado.TabIndex = 30;
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel12.Location = new System.Drawing.Point(600, 43);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(100, 26);
            this.gunaLabel12.TabIndex = 29;
            this.gunaLabel12.Text = "ACOPLADO";
            this.gunaLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbchasis
            // 
            this.cmbchasis.BackColor = System.Drawing.Color.Transparent;
            this.cmbchasis.BaseColor = System.Drawing.Color.White;
            this.cmbchasis.BorderColor = System.Drawing.Color.Silver;
            this.cmbchasis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbchasis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbchasis.FocusedColor = System.Drawing.Color.Empty;
            this.cmbchasis.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbchasis.ForeColor = System.Drawing.Color.Black;
            this.cmbchasis.FormattingEnabled = true;
            this.cmbchasis.Location = new System.Drawing.Point(675, 11);
            this.cmbchasis.Name = "cmbchasis";
            this.cmbchasis.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbchasis.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbchasis.Size = new System.Drawing.Size(103, 26);
            this.cmbchasis.TabIndex = 28;
            this.cmbchasis.SelectedIndexChanged += new System.EventHandler(this.cmbchasis_SelectedIndexChanged);
            // 
            // txtchasis
            // 
            this.txtchasis.BaseColor = System.Drawing.Color.White;
            this.txtchasis.BorderColor = System.Drawing.Color.Silver;
            this.txtchasis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtchasis.FocusedBaseColor = System.Drawing.Color.White;
            this.txtchasis.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtchasis.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtchasis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtchasis.Location = new System.Drawing.Point(779, 11);
            this.txtchasis.Name = "txtchasis";
            this.txtchasis.PasswordChar = '\0';
            this.txtchasis.Size = new System.Drawing.Size(93, 26);
            this.txtchasis.TabIndex = 27;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel11.Location = new System.Drawing.Point(600, 11);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(75, 26);
            this.gunaLabel11.TabIndex = 26;
            this.gunaLabel11.Text = "CHASIS";
            this.gunaLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdnichofer
            // 
            this.txtdnichofer.BaseColor = System.Drawing.Color.White;
            this.txtdnichofer.BorderColor = System.Drawing.Color.Silver;
            this.txtdnichofer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdnichofer.FocusedBaseColor = System.Drawing.Color.White;
            this.txtdnichofer.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtdnichofer.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtdnichofer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdnichofer.Location = new System.Drawing.Point(430, 11);
            this.txtdnichofer.Name = "txtdnichofer";
            this.txtdnichofer.PasswordChar = '\0';
            this.txtdnichofer.Size = new System.Drawing.Size(139, 26);
            this.txtdnichofer.TabIndex = 25;
            this.txtdnichofer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdnichofer_KeyPress);
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel10.Location = new System.Drawing.Point(315, 11);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(115, 26);
            this.gunaLabel10.TabIndex = 24;
            this.gunaLabel10.Text = "DNI CHOFER";
            this.gunaLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtchofer
            // 
            this.txtchofer.BaseColor = System.Drawing.Color.White;
            this.txtchofer.BorderColor = System.Drawing.Color.Silver;
            this.txtchofer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtchofer.FocusedBaseColor = System.Drawing.Color.White;
            this.txtchofer.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtchofer.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtchofer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtchofer.Location = new System.Drawing.Point(109, 43);
            this.txtchofer.Name = "txtchofer";
            this.txtchofer.PasswordChar = '\0';
            this.txtchofer.Size = new System.Drawing.Size(460, 26);
            this.txtchofer.TabIndex = 23;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel9.Location = new System.Drawing.Point(3, 43);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(107, 26);
            this.gunaLabel9.TabIndex = 1;
            this.gunaLabel9.Text = "CHOFER";
            this.gunaLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(3, 11);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(144, 26);
            this.gunaLabel1.TabIndex = 21;
            this.gunaLabel1.Text = "COMPROBANTE";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcomprobante
            // 
            this.txtcomprobante.BaseColor = System.Drawing.Color.White;
            this.txtcomprobante.BorderColor = System.Drawing.Color.Silver;
            this.txtcomprobante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcomprobante.FocusedBaseColor = System.Drawing.Color.White;
            this.txtcomprobante.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtcomprobante.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcomprobante.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtcomprobante.Location = new System.Drawing.Point(144, 11);
            this.txtcomprobante.Name = "txtcomprobante";
            this.txtcomprobante.PasswordChar = '\0';
            this.txtcomprobante.Size = new System.Drawing.Size(160, 26);
            this.txtcomprobante.TabIndex = 22;
            // 
            // btnguardarcambiosorden
            // 
            this.btnguardarcambiosorden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnguardarcambiosorden.AnimationHoverSpeed = 0.07F;
            this.btnguardarcambiosorden.AnimationSpeed = 0.03F;
            this.btnguardarcambiosorden.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnguardarcambiosorden.BorderColor = System.Drawing.Color.Black;
            this.btnguardarcambiosorden.BorderSize = 3;
            this.btnguardarcambiosorden.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnguardarcambiosorden.FocusedColor = System.Drawing.Color.Empty;
            this.btnguardarcambiosorden.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnguardarcambiosorden.ForeColor = System.Drawing.Color.White;
            this.btnguardarcambiosorden.Image = global::Omnitec.Properties.Resources.apply;
            this.btnguardarcambiosorden.ImageSize = new System.Drawing.Size(20, 20);
            this.btnguardarcambiosorden.Location = new System.Drawing.Point(685, 400);
            this.btnguardarcambiosorden.Name = "btnguardarcambiosorden";
            this.btnguardarcambiosorden.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnguardarcambiosorden.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.btnguardarcambiosorden.OnHoverForeColor = System.Drawing.Color.White;
            this.btnguardarcambiosorden.OnHoverImage = null;
            this.btnguardarcambiosorden.OnPressedColor = System.Drawing.Color.Black;
            this.btnguardarcambiosorden.Size = new System.Drawing.Size(206, 42);
            this.btnguardarcambiosorden.TabIndex = 145;
            this.btnguardarcambiosorden.Text = "GUARDAR CAMBIOS";
            this.btnguardarcambiosorden.Click += new System.EventHandler(this.btnguardarcambiosorden_Click);
            // 
            // btnanulareabreorden
            // 
            this.btnanulareabreorden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnanulareabreorden.AnimationHoverSpeed = 0.07F;
            this.btnanulareabreorden.AnimationSpeed = 0.03F;
            this.btnanulareabreorden.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnanulareabreorden.BorderColor = System.Drawing.Color.Black;
            this.btnanulareabreorden.BorderSize = 3;
            this.btnanulareabreorden.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnanulareabreorden.FocusedColor = System.Drawing.Color.Empty;
            this.btnanulareabreorden.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnanulareabreorden.ForeColor = System.Drawing.Color.White;
            this.btnanulareabreorden.Image = global::Omnitec.Properties.Resources.button_cancel;
            this.btnanulareabreorden.ImageSize = new System.Drawing.Size(20, 20);
            this.btnanulareabreorden.Location = new System.Drawing.Point(505, 400);
            this.btnanulareabreorden.Name = "btnanulareabreorden";
            this.btnanulareabreorden.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnanulareabreorden.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.btnanulareabreorden.OnHoverForeColor = System.Drawing.Color.White;
            this.btnanulareabreorden.OnHoverImage = null;
            this.btnanulareabreorden.OnPressedColor = System.Drawing.Color.Black;
            this.btnanulareabreorden.Size = new System.Drawing.Size(174, 42);
            this.btnanulareabreorden.TabIndex = 144;
            this.btnanulareabreorden.Text = "ANULAR ORDEN";
            this.btnanulareabreorden.Click += new System.EventHandler(this.btnanulareabreorden_Click);
            // 
            // frmabmordendespachodevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.btnguardarcambiosorden);
            this.Controls.Add(this.btnanulareabreorden);
            this.Controls.Add(this.panelcontenedordatostransporte);
            this.Controls.Add(this.panelcontenedorcabecera);
            this.Controls.Add(this.panelsuperior);
            this.Name = "frmabmordendespachodevolucion";
            this.Text = "frmabmordendespachodevolucion";
            this.Load += new System.EventHandler(this.frmabmordendespachodevolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenparasoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_camposform)).EndInit();
            this.panelsuperior.ResumeLayout(false);
            this.panelcontenedorcabecera.ResumeLayout(false);
            this.panelcontenedordatostransporte.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DataGridView dgvordenparasoc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn asociar;
        private System.Windows.Forms.ErrorProvider errorProvider_camposform;
        private Guna.UI.WinForms.GunaGradientPanel panelsuperior;
        public System.Windows.Forms.Label lbltituloform;
        private Guna.UI.WinForms.GunaGradientPanel panelcontenedorcabecera;
        private Guna.UI.WinForms.GunaTextBox txtobservacionesaltaorden;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private Guna.UI.WinForms.GunaComboBox cmbcliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel lblfecha;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaGradientPanel panelcontenedordatostransporte;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaComboBox cmbacoplado;
        private Guna.UI.WinForms.GunaTextBox txtacoplado;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI.WinForms.GunaComboBox cmbchasis;
        private Guna.UI.WinForms.GunaTextBox txtchasis;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaTextBox txtdnichofer;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaTextBox txtchofer;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtcomprobante;
        private Guna.UI.WinForms.GunaButton btnguardarcambiosorden;
        private Guna.UI.WinForms.GunaButton btnanulareabreorden;
    }
}