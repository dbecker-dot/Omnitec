
namespace Omnitec.Views.Ordenes
{
    partial class frmlistarordenes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlistarordenes));
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.dgvordenes = new System.Windows.Forms.DataGridView();
            this.btnvertodaslasordenes = new Soporte.Recursos.CustomButtons();
            this.btnagregarordendevolucion = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnagregarordenrecepcion = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.panelsuperior = new Guna.UI.WinForms.GunaGradientPanel();
            this.lbltituloform = new System.Windows.Forms.Label();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.btnagregarordendespacho = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnagregarordenreproceso = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnagregarordenproduccion = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.cmbtipo = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cmbcliente = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.panel_contenedorppal = new Guna.UI.WinForms.GunaPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenes)).BeginInit();
            this.panelsuperior.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.panel_contenedorppal.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::Omnitec.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(801, 0);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(33, 29);
            this.BtnCerrar.TabIndex = 23;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // dgvordenes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
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
            this.dgvordenes.Location = new System.Drawing.Point(7, 221);
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
            this.dgvordenes.Size = new System.Drawing.Size(815, 292);
            this.dgvordenes.TabIndex = 27;
            this.dgvordenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvordenes_CellContentClick);
            // 
            // btnvertodaslasordenes
            // 
            this.btnvertodaslasordenes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnvertodaslasordenes.BackColor = System.Drawing.Color.Teal;
            this.btnvertodaslasordenes.BackgroundColor = System.Drawing.Color.Teal;
            this.btnvertodaslasordenes.BorderColor = System.Drawing.Color.Black;
            this.btnvertodaslasordenes.BorderColor1 = System.Drawing.Color.Black;
            this.btnvertodaslasordenes.BorderRadius = 15;
            this.btnvertodaslasordenes.BorderRadius1 = 15;
            this.btnvertodaslasordenes.BorderSize = 5;
            this.btnvertodaslasordenes.BorderSize1 = 5;
            this.btnvertodaslasordenes.FlatAppearance.BorderSize = 0;
            this.btnvertodaslasordenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvertodaslasordenes.ForeColor = System.Drawing.Color.White;
            this.btnvertodaslasordenes.Location = new System.Drawing.Point(677, 176);
            this.btnvertodaslasordenes.Name = "btnvertodaslasordenes";
            this.btnvertodaslasordenes.Size = new System.Drawing.Size(150, 40);
            this.btnvertodaslasordenes.TabIndex = 101;
            this.btnvertodaslasordenes.Text = "VER TODAS";
            this.btnvertodaslasordenes.TextColor = System.Drawing.Color.White;
            this.btnvertodaslasordenes.UseVisualStyleBackColor = false;
            this.btnvertodaslasordenes.Click += new System.EventHandler(this.btnvertodaslasordenes_Click);
            // 
            // btnagregarordendevolucion
            // 
            this.btnagregarordendevolucion.AnimationHoverSpeed = 0.07F;
            this.btnagregarordendevolucion.AnimationSpeed = 0.03F;
            this.btnagregarordendevolucion.BaseColor = System.Drawing.Color.Teal;
            this.btnagregarordendevolucion.BorderColor = System.Drawing.Color.Black;
            this.btnagregarordendevolucion.BorderSize = 3;
            this.btnagregarordendevolucion.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnagregarordendevolucion.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnagregarordendevolucion.CheckedForeColor = System.Drawing.Color.White;
            this.btnagregarordendevolucion.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnagregarordendevolucion.CheckedImage")));
            this.btnagregarordendevolucion.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnagregarordendevolucion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnagregarordendevolucion.FocusedColor = System.Drawing.Color.Empty;
            this.btnagregarordendevolucion.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnagregarordendevolucion.ForeColor = System.Drawing.Color.White;
            this.btnagregarordendevolucion.Image = global::Omnitec.Properties.Resources.ordenes_de_devolucion;
            this.btnagregarordendevolucion.ImageSize = new System.Drawing.Size(52, 52);
            this.btnagregarordendevolucion.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnagregarordendevolucion.Location = new System.Drawing.Point(169, 37);
            this.btnagregarordendevolucion.Name = "btnagregarordendevolucion";
            this.btnagregarordendevolucion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnagregarordendevolucion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnagregarordendevolucion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnagregarordendevolucion.OnHoverImage = null;
            this.btnagregarordendevolucion.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnagregarordendevolucion.OnPressedColor = System.Drawing.Color.Black;
            this.btnagregarordendevolucion.Size = new System.Drawing.Size(160, 132);
            this.btnagregarordendevolucion.TabIndex = 19;
            this.btnagregarordendevolucion.Text = "DEVOLUCION";
            this.btnagregarordendevolucion.Click += new System.EventHandler(this.btnagregarordendevolucion_Click);
            // 
            // btnagregarordenrecepcion
            // 
            this.btnagregarordenrecepcion.AnimationHoverSpeed = 0.07F;
            this.btnagregarordenrecepcion.AnimationSpeed = 0.03F;
            this.btnagregarordenrecepcion.BaseColor = System.Drawing.Color.Teal;
            this.btnagregarordenrecepcion.BorderColor = System.Drawing.Color.Black;
            this.btnagregarordenrecepcion.BorderSize = 3;
            this.btnagregarordenrecepcion.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnagregarordenrecepcion.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnagregarordenrecepcion.CheckedForeColor = System.Drawing.Color.White;
            this.btnagregarordenrecepcion.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnagregarordenrecepcion.CheckedImage")));
            this.btnagregarordenrecepcion.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnagregarordenrecepcion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnagregarordenrecepcion.FocusedColor = System.Drawing.Color.Empty;
            this.btnagregarordenrecepcion.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnagregarordenrecepcion.ForeColor = System.Drawing.Color.White;
            this.btnagregarordenrecepcion.Image = global::Omnitec.Properties.Resources.ordenes_de_recepcion;
            this.btnagregarordenrecepcion.ImageSize = new System.Drawing.Size(52, 52);
            this.btnagregarordenrecepcion.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnagregarordenrecepcion.Location = new System.Drawing.Point(3, 37);
            this.btnagregarordenrecepcion.Name = "btnagregarordenrecepcion";
            this.btnagregarordenrecepcion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnagregarordenrecepcion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnagregarordenrecepcion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnagregarordenrecepcion.OnHoverImage = null;
            this.btnagregarordenrecepcion.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnagregarordenrecepcion.OnPressedColor = System.Drawing.Color.Black;
            this.btnagregarordenrecepcion.Size = new System.Drawing.Size(160, 132);
            this.btnagregarordenrecepcion.TabIndex = 18;
            this.btnagregarordenrecepcion.Text = "RECEPCION";
            this.btnagregarordenrecepcion.Click += new System.EventHandler(this.btnagregarordenrecepcion_Click);
            // 
            // panelsuperior
            // 
            this.panelsuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelsuperior.BackgroundImage")));
            this.panelsuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelsuperior.Controls.Add(this.BtnCerrar);
            this.panelsuperior.Controls.Add(this.lbltituloform);
            this.panelsuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsuperior.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelsuperior.GradientColor2 = System.Drawing.Color.Gray;
            this.panelsuperior.GradientColor3 = System.Drawing.Color.Silver;
            this.panelsuperior.GradientColor4 = System.Drawing.Color.White;
            this.panelsuperior.Location = new System.Drawing.Point(0, 0);
            this.panelsuperior.Name = "panelsuperior";
            this.panelsuperior.Size = new System.Drawing.Size(834, 29);
            this.panelsuperior.TabIndex = 103;
            this.panelsuperior.Text = "gunaGradientPanel1";
            // 
            // lbltituloform
            // 
            this.lbltituloform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbltituloform.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltituloform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltituloform.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloform.Location = new System.Drawing.Point(0, -1);
            this.lbltituloform.Name = "lbltituloform";
            this.lbltituloform.Size = new System.Drawing.Size(420, 30);
            this.lbltituloform.TabIndex = 27;
            this.lbltituloform.Text = "AGREGAR ORDEN DE RECEPCION";
            this.lbltituloform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.LightGray;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.LightGray;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.gunaGroupBox1.Controls.Add(this.btnagregarordendespacho);
            this.gunaGroupBox1.Controls.Add(this.btnagregarordenreproceso);
            this.gunaGroupBox1.Controls.Add(this.btnagregarordenproduccion);
            this.gunaGroupBox1.Controls.Add(this.btnagregarordendevolucion);
            this.gunaGroupBox1.Controls.Add(this.btnagregarordenrecepcion);
            this.gunaGroupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(0, 29);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(834, 177);
            this.gunaGroupBox1.TabIndex = 104;
            this.gunaGroupBox1.Text = "AGREGAR ORDENES";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btnagregarordendespacho
            // 
            this.btnagregarordendespacho.AnimationHoverSpeed = 0.07F;
            this.btnagregarordendespacho.AnimationSpeed = 0.03F;
            this.btnagregarordendespacho.BaseColor = System.Drawing.Color.Teal;
            this.btnagregarordendespacho.BorderColor = System.Drawing.Color.Black;
            this.btnagregarordendespacho.BorderSize = 3;
            this.btnagregarordendespacho.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnagregarordendespacho.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnagregarordendespacho.CheckedForeColor = System.Drawing.Color.White;
            this.btnagregarordendespacho.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnagregarordendespacho.CheckedImage")));
            this.btnagregarordendespacho.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnagregarordendespacho.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnagregarordendespacho.FocusedColor = System.Drawing.Color.Empty;
            this.btnagregarordendespacho.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnagregarordendespacho.ForeColor = System.Drawing.Color.White;
            this.btnagregarordendespacho.Image = global::Omnitec.Properties.Resources.ordenes_de_despacho;
            this.btnagregarordendespacho.ImageSize = new System.Drawing.Size(52, 52);
            this.btnagregarordendespacho.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnagregarordendespacho.Location = new System.Drawing.Point(667, 37);
            this.btnagregarordendespacho.Name = "btnagregarordendespacho";
            this.btnagregarordendespacho.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnagregarordendespacho.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnagregarordendespacho.OnHoverForeColor = System.Drawing.Color.White;
            this.btnagregarordendespacho.OnHoverImage = null;
            this.btnagregarordendespacho.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnagregarordendespacho.OnPressedColor = System.Drawing.Color.Black;
            this.btnagregarordendespacho.Size = new System.Drawing.Size(160, 132);
            this.btnagregarordendespacho.TabIndex = 22;
            this.btnagregarordendespacho.Text = "DESPACHO";
            this.btnagregarordendespacho.Click += new System.EventHandler(this.btnagregarordendespacho_Click);
            // 
            // btnagregarordenreproceso
            // 
            this.btnagregarordenreproceso.AnimationHoverSpeed = 0.07F;
            this.btnagregarordenreproceso.AnimationSpeed = 0.03F;
            this.btnagregarordenreproceso.BaseColor = System.Drawing.Color.Teal;
            this.btnagregarordenreproceso.BorderColor = System.Drawing.Color.Black;
            this.btnagregarordenreproceso.BorderSize = 3;
            this.btnagregarordenreproceso.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnagregarordenreproceso.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnagregarordenreproceso.CheckedForeColor = System.Drawing.Color.White;
            this.btnagregarordenreproceso.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnagregarordenreproceso.CheckedImage")));
            this.btnagregarordenreproceso.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnagregarordenreproceso.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnagregarordenreproceso.FocusedColor = System.Drawing.Color.Empty;
            this.btnagregarordenreproceso.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnagregarordenreproceso.ForeColor = System.Drawing.Color.White;
            this.btnagregarordenreproceso.Image = global::Omnitec.Properties.Resources.ordenes_de_reproceso;
            this.btnagregarordenreproceso.ImageSize = new System.Drawing.Size(52, 52);
            this.btnagregarordenreproceso.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnagregarordenreproceso.Location = new System.Drawing.Point(501, 37);
            this.btnagregarordenreproceso.Name = "btnagregarordenreproceso";
            this.btnagregarordenreproceso.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnagregarordenreproceso.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnagregarordenreproceso.OnHoverForeColor = System.Drawing.Color.White;
            this.btnagregarordenreproceso.OnHoverImage = null;
            this.btnagregarordenreproceso.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnagregarordenreproceso.OnPressedColor = System.Drawing.Color.Black;
            this.btnagregarordenreproceso.Size = new System.Drawing.Size(160, 132);
            this.btnagregarordenreproceso.TabIndex = 21;
            this.btnagregarordenreproceso.Text = "REPROCESO";
            this.btnagregarordenreproceso.Click += new System.EventHandler(this.btnagregarordenreproceso_Click);
            // 
            // btnagregarordenproduccion
            // 
            this.btnagregarordenproduccion.AnimationHoverSpeed = 0.07F;
            this.btnagregarordenproduccion.AnimationSpeed = 0.03F;
            this.btnagregarordenproduccion.BaseColor = System.Drawing.Color.Teal;
            this.btnagregarordenproduccion.BorderColor = System.Drawing.Color.Black;
            this.btnagregarordenproduccion.BorderSize = 3;
            this.btnagregarordenproduccion.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnagregarordenproduccion.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnagregarordenproduccion.CheckedForeColor = System.Drawing.Color.White;
            this.btnagregarordenproduccion.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnagregarordenproduccion.CheckedImage")));
            this.btnagregarordenproduccion.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnagregarordenproduccion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnagregarordenproduccion.FocusedColor = System.Drawing.Color.Empty;
            this.btnagregarordenproduccion.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnagregarordenproduccion.ForeColor = System.Drawing.Color.White;
            this.btnagregarordenproduccion.Image = global::Omnitec.Properties.Resources.ordenes_de_produccion;
            this.btnagregarordenproduccion.ImageSize = new System.Drawing.Size(52, 52);
            this.btnagregarordenproduccion.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnagregarordenproduccion.Location = new System.Drawing.Point(335, 37);
            this.btnagregarordenproduccion.Name = "btnagregarordenproduccion";
            this.btnagregarordenproduccion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnagregarordenproduccion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnagregarordenproduccion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnagregarordenproduccion.OnHoverImage = null;
            this.btnagregarordenproduccion.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnagregarordenproduccion.OnPressedColor = System.Drawing.Color.Black;
            this.btnagregarordenproduccion.Size = new System.Drawing.Size(160, 132);
            this.btnagregarordenproduccion.TabIndex = 20;
            this.btnagregarordenproduccion.Text = "PRODUCCION";
            this.btnagregarordenproduccion.Click += new System.EventHandler(this.btnagregarordenproduccion_Click);
            // 
            // cmbtipo
            // 
            this.cmbtipo.BackColor = System.Drawing.Color.Transparent;
            this.cmbtipo.BaseColor = System.Drawing.Color.White;
            this.cmbtipo.BorderColor = System.Drawing.Color.Silver;
            this.cmbtipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipo.FocusedColor = System.Drawing.Color.Empty;
            this.cmbtipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbtipo.ForeColor = System.Drawing.Color.Black;
            this.cmbtipo.FormattingEnabled = true;
            this.cmbtipo.Location = new System.Drawing.Point(85, 180);
            this.cmbtipo.Name = "cmbtipo";
            this.cmbtipo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbtipo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbtipo.Size = new System.Drawing.Size(159, 26);
            this.cmbtipo.TabIndex = 105;
            this.cmbtipo.SelectedIndexChanged += new System.EventHandler(this.cmbtipo_SelectedIndexChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(7, 180);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(79, 26);
            this.gunaLabel1.TabIndex = 104;
            this.gunaLabel1.Text = "TIPO";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbcliente
            // 
            this.cmbcliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbcliente.BackColor = System.Drawing.Color.Transparent;
            this.cmbcliente.BaseColor = System.Drawing.Color.White;
            this.cmbcliente.BorderColor = System.Drawing.Color.Silver;
            this.cmbcliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcliente.FocusedColor = System.Drawing.Color.Empty;
            this.cmbcliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbcliente.ForeColor = System.Drawing.Color.Black;
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.Location = new System.Drawing.Point(328, 180);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbcliente.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbcliente.Size = new System.Drawing.Size(333, 26);
            this.cmbcliente.TabIndex = 103;
            this.cmbcliente.SelectedIndexChanged += new System.EventHandler(this.cmbcliente_SelectedIndexChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(250, 180);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(79, 26);
            this.gunaLabel2.TabIndex = 102;
            this.gunaLabel2.Text = "CLIENTE";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_contenedorppal
            // 
            this.panel_contenedorppal.BackColor = System.Drawing.SystemColors.Control;
            this.panel_contenedorppal.Controls.Add(this.dgvordenes);
            this.panel_contenedorppal.Controls.Add(this.cmbcliente);
            this.panel_contenedorppal.Controls.Add(this.btnvertodaslasordenes);
            this.panel_contenedorppal.Controls.Add(this.cmbtipo);
            this.panel_contenedorppal.Controls.Add(this.gunaLabel2);
            this.panel_contenedorppal.Controls.Add(this.gunaLabel1);
            this.panel_contenedorppal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedorppal.Location = new System.Drawing.Point(0, 29);
            this.panel_contenedorppal.Name = "panel_contenedorppal";
            this.panel_contenedorppal.Size = new System.Drawing.Size(834, 525);
            this.panel_contenedorppal.TabIndex = 106;
            // 
            // frmlistarordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(834, 554);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.panel_contenedorppal);
            this.Controls.Add(this.panelsuperior);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmlistarordenes";
            this.Text = "Listarordenes";
            this.Load += new System.EventHandler(this.frmlistarordenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenes)).EndInit();
            this.panelsuperior.ResumeLayout(false);
            this.gunaGroupBox1.ResumeLayout(false);
            this.panel_contenedorppal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DataGridView dgvordenes;
        private Soporte.Recursos.CustomButtons btnvertodaslasordenes;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnagregarordendevolucion;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnagregarordenrecepcion;
        private Guna.UI.WinForms.GunaGradientPanel panelsuperior;
        public System.Windows.Forms.Label lbltituloform;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnagregarordendespacho;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnagregarordenreproceso;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnagregarordenproduccion;
        private Guna.UI.WinForms.GunaComboBox cmbcliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox cmbtipo;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel panel_contenedorppal;
    }
}