
namespace Omnitec.Views.Ordenes
{
    partial class frmverproductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmverproductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_principal = new System.Windows.Forms.Panel();
            this.panelcontenedor = new Guna.UI.WinForms.GunaGradientPanel();
            this.btnimprimir = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.dgvproductosordenes = new Guna.UI.WinForms.GunaDataGridView();
            this.panelmenulateralizquierdo = new Guna.UI.WinForms.GunaGradientPanel();
            this.btnagregarproducto = new Guna.UI.WinForms.GunaButton();
            this.txtkgprod = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gbgrano = new Guna.UI.WinForms.GunaGroupBox();
            this.lblgrano = new Guna.UI.WinForms.GunaLabel();
            this.cmbgrano = new Guna.UI.WinForms.GunaComboBox();
            this.gbtipoproducto = new Guna.UI.WinForms.GunaGroupBox();
            this.rbtipogranoindustria = new Guna.UI.WinForms.GunaRadioButton();
            this.rbtipogranorechazoseleccion = new Guna.UI.WinForms.GunaRadioButton();
            this.rbtipogranoblanchado = new Guna.UI.WinForms.GunaRadioButton();
            this.dtpfeingstk = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnMenuizquierdo = new System.Windows.Forms.PictureBox();
            this.panelsuperior = new Guna.UI.WinForms.GunaGradientPanel();
            this.lblote = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.printDocument_productos = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog_listaproductos = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBoxlogo = new System.Windows.Forms.PictureBox();
            this.panel_principal.SuspendLayout();
            this.panelcontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductosordenes)).BeginInit();
            this.panelmenulateralizquierdo.SuspendLayout();
            this.gbgrano.SuspendLayout();
            this.gbtipoproducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuizquierdo)).BeginInit();
            this.panelsuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_principal
            // 
            this.panel_principal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_principal.Controls.Add(this.panelcontenedor);
            this.panel_principal.Controls.Add(this.panelmenulateralizquierdo);
            this.panel_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_principal.Location = new System.Drawing.Point(0, 29);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(944, 421);
            this.panel_principal.TabIndex = 16;
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelcontenedor.BackgroundImage")));
            this.panelcontenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcontenedor.Controls.Add(this.btnimprimir);
            this.panelcontenedor.Controls.Add(this.gunaLabel4);
            this.panelcontenedor.Controls.Add(this.dgvproductosordenes);
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.GradientColor1 = System.Drawing.Color.Silver;
            this.panelcontenedor.GradientColor2 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor3 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor4 = System.Drawing.Color.White;
            this.panelcontenedor.Location = new System.Drawing.Point(400, 0);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(544, 421);
            this.panelcontenedor.TabIndex = 3;
            this.panelcontenedor.Text = "gunaGradientPanel1";
            // 
            // btnimprimir
            // 
            this.btnimprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnimprimir.AnimationHoverSpeed = 0.07F;
            this.btnimprimir.AnimationSpeed = 0.03F;
            this.btnimprimir.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnimprimir.BorderColor = System.Drawing.Color.Black;
            this.btnimprimir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnimprimir.FocusedColor = System.Drawing.Color.Empty;
            this.btnimprimir.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnimprimir.ForeColor = System.Drawing.Color.White;
            this.btnimprimir.Image = global::Omnitec.Properties.Resources.impresion;
            this.btnimprimir.ImageSize = new System.Drawing.Size(20, 20);
            this.btnimprimir.Location = new System.Drawing.Point(411, 3);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnimprimir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnimprimir.OnHoverForeColor = System.Drawing.Color.White;
            this.btnimprimir.OnHoverImage = null;
            this.btnimprimir.OnPressedColor = System.Drawing.Color.Black;
            this.btnimprimir.Size = new System.Drawing.Size(121, 20);
            this.btnimprimir.TabIndex = 24;
            this.btnimprimir.Text = "IMPRIMIR";
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.Location = new System.Drawing.Point(6, 3);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(248, 23);
            this.gunaLabel4.TabIndex = 14;
            this.gunaLabel4.Text = "PRODUCTOS";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvproductosordenes
            // 
            this.dgvproductosordenes.AllowUserToAddRows = false;
            this.dgvproductosordenes.AllowUserToDeleteRows = false;
            this.dgvproductosordenes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvproductosordenes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvproductosordenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvproductosordenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvproductosordenes.BackgroundColor = System.Drawing.Color.White;
            this.dgvproductosordenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvproductosordenes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvproductosordenes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproductosordenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvproductosordenes.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvproductosordenes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvproductosordenes.EnableHeadersVisualStyles = false;
            this.dgvproductosordenes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvproductosordenes.Location = new System.Drawing.Point(6, 29);
            this.dgvproductosordenes.Name = "dgvproductosordenes";
            this.dgvproductosordenes.ReadOnly = true;
            this.dgvproductosordenes.RowHeadersVisible = false;
            this.dgvproductosordenes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvproductosordenes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvproductosordenes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvproductosordenes.RowTemplate.ReadOnly = true;
            this.dgvproductosordenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproductosordenes.Size = new System.Drawing.Size(526, 380);
            this.dgvproductosordenes.TabIndex = 3;
            this.dgvproductosordenes.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.GreenSea;
            this.dgvproductosordenes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvproductosordenes.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvproductosordenes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvproductosordenes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvproductosordenes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvproductosordenes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvproductosordenes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvproductosordenes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dgvproductosordenes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvproductosordenes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvproductosordenes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvproductosordenes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvproductosordenes.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvproductosordenes.ThemeStyle.ReadOnly = true;
            this.dgvproductosordenes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dgvproductosordenes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvproductosordenes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvproductosordenes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvproductosordenes.ThemeStyle.RowsStyle.Height = 22;
            this.dgvproductosordenes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvproductosordenes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // panelmenulateralizquierdo
            // 
            this.panelmenulateralizquierdo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelmenulateralizquierdo.BackgroundImage")));
            this.panelmenulateralizquierdo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelmenulateralizquierdo.Controls.Add(this.pictureBoxlogo);
            this.panelmenulateralizquierdo.Controls.Add(this.btnagregarproducto);
            this.panelmenulateralizquierdo.Controls.Add(this.txtkgprod);
            this.panelmenulateralizquierdo.Controls.Add(this.gunaLabel3);
            this.panelmenulateralizquierdo.Controls.Add(this.gbgrano);
            this.panelmenulateralizquierdo.Controls.Add(this.gbtipoproducto);
            this.panelmenulateralizquierdo.Controls.Add(this.dtpfeingstk);
            this.panelmenulateralizquierdo.Controls.Add(this.gunaLabel2);
            this.panelmenulateralizquierdo.Controls.Add(this.gunaLabel1);
            this.panelmenulateralizquierdo.Controls.Add(this.btnMenuizquierdo);
            this.panelmenulateralizquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenulateralizquierdo.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelmenulateralizquierdo.GradientColor2 = System.Drawing.Color.White;
            this.panelmenulateralizquierdo.GradientColor3 = System.Drawing.Color.White;
            this.panelmenulateralizquierdo.GradientColor4 = System.Drawing.Color.White;
            this.panelmenulateralizquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelmenulateralizquierdo.Name = "panelmenulateralizquierdo";
            this.panelmenulateralizquierdo.Size = new System.Drawing.Size(400, 421);
            this.panelmenulateralizquierdo.TabIndex = 1;
            this.panelmenulateralizquierdo.Text = "gunaGradientPanel1";
            // 
            // btnagregarproducto
            // 
            this.btnagregarproducto.AnimationHoverSpeed = 0.07F;
            this.btnagregarproducto.AnimationSpeed = 0.03F;
            this.btnagregarproducto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnagregarproducto.BorderColor = System.Drawing.Color.Black;
            this.btnagregarproducto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnagregarproducto.FocusedColor = System.Drawing.Color.Empty;
            this.btnagregarproducto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnagregarproducto.ForeColor = System.Drawing.Color.White;
            this.btnagregarproducto.Image = global::Omnitec.Properties.Resources.img_confirmar;
            this.btnagregarproducto.ImageSize = new System.Drawing.Size(20, 20);
            this.btnagregarproducto.Location = new System.Drawing.Point(3, 303);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnagregarproducto.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnagregarproducto.OnHoverForeColor = System.Drawing.Color.White;
            this.btnagregarproducto.OnHoverImage = null;
            this.btnagregarproducto.OnPressedColor = System.Drawing.Color.Black;
            this.btnagregarproducto.Size = new System.Drawing.Size(121, 42);
            this.btnagregarproducto.TabIndex = 23;
            this.btnagregarproducto.Text = "AGREGAR";
            this.btnagregarproducto.Click += new System.EventHandler(this.btnagregarproducto_Click);
            // 
            // txtkgprod
            // 
            this.txtkgprod.BaseColor = System.Drawing.Color.White;
            this.txtkgprod.BorderColor = System.Drawing.Color.Silver;
            this.txtkgprod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtkgprod.FocusedBaseColor = System.Drawing.Color.White;
            this.txtkgprod.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtkgprod.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtkgprod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtkgprod.Location = new System.Drawing.Point(51, 267);
            this.txtkgprod.Name = "txtkgprod";
            this.txtkgprod.PasswordChar = '\0';
            this.txtkgprod.Size = new System.Drawing.Size(160, 30);
            this.txtkgprod.TabIndex = 22;
            this.txtkgprod.Text = "0";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.Location = new System.Drawing.Point(2, 267);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(48, 30);
            this.gunaLabel3.TabIndex = 21;
            this.gunaLabel3.Text = "KG";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbgrano
            // 
            this.gbgrano.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbgrano.BackColor = System.Drawing.Color.Transparent;
            this.gbgrano.BaseColor = System.Drawing.Color.White;
            this.gbgrano.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbgrano.Controls.Add(this.lblgrano);
            this.gbgrano.Controls.Add(this.cmbgrano);
            this.gbgrano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbgrano.LineColor = System.Drawing.Color.Gainsboro;
            this.gbgrano.Location = new System.Drawing.Point(207, 112);
            this.gbgrano.Name = "gbgrano";
            this.gbgrano.Size = new System.Drawing.Size(189, 100);
            this.gbgrano.TabIndex = 20;
            this.gbgrano.Text = "GRANO";
            this.gbgrano.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // lblgrano
            // 
            this.lblgrano.BackColor = System.Drawing.Color.LightGray;
            this.lblgrano.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblgrano.Location = new System.Drawing.Point(3, 35);
            this.lblgrano.Name = "lblgrano";
            this.lblgrano.Size = new System.Drawing.Size(88, 30);
            this.lblgrano.TabIndex = 17;
            this.lblgrano.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbgrano
            // 
            this.cmbgrano.BackColor = System.Drawing.Color.Transparent;
            this.cmbgrano.BaseColor = System.Drawing.Color.White;
            this.cmbgrano.BorderColor = System.Drawing.Color.Silver;
            this.cmbgrano.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbgrano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgrano.FocusedColor = System.Drawing.Color.Empty;
            this.cmbgrano.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbgrano.ForeColor = System.Drawing.Color.Black;
            this.cmbgrano.FormattingEnabled = true;
            this.cmbgrano.Location = new System.Drawing.Point(3, 68);
            this.cmbgrano.Name = "cmbgrano";
            this.cmbgrano.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbgrano.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbgrano.Size = new System.Drawing.Size(174, 26);
            this.cmbgrano.TabIndex = 18;
            this.cmbgrano.SelectedIndexChanged += new System.EventHandler(this.cmbgrano_SelectedIndexChanged);
            // 
            // gbtipoproducto
            // 
            this.gbtipoproducto.BackColor = System.Drawing.Color.Transparent;
            this.gbtipoproducto.BaseColor = System.Drawing.Color.White;
            this.gbtipoproducto.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbtipoproducto.Controls.Add(this.rbtipogranoindustria);
            this.gbtipoproducto.Controls.Add(this.rbtipogranorechazoseleccion);
            this.gbtipoproducto.Controls.Add(this.rbtipogranoblanchado);
            this.gbtipoproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtipoproducto.LineColor = System.Drawing.Color.Gainsboro;
            this.gbtipoproducto.Location = new System.Drawing.Point(3, 109);
            this.gbtipoproducto.Name = "gbtipoproducto";
            this.gbtipoproducto.Size = new System.Drawing.Size(198, 131);
            this.gbtipoproducto.TabIndex = 19;
            this.gbtipoproducto.Text = "TIPO DE GRANO";
            this.gbtipoproducto.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // rbtipogranoindustria
            // 
            this.rbtipogranoindustria.BaseColor = System.Drawing.SystemColors.Control;
            this.rbtipogranoindustria.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbtipogranoindustria.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbtipogranoindustria.FillColor = System.Drawing.Color.White;
            this.rbtipogranoindustria.Location = new System.Drawing.Point(3, 103);
            this.rbtipogranoindustria.Name = "rbtipogranoindustria";
            this.rbtipogranoindustria.Size = new System.Drawing.Size(91, 20);
            this.rbtipogranoindustria.TabIndex = 2;
            this.rbtipogranoindustria.Text = "INDUSTRIA";
            this.rbtipogranoindustria.CheckedChanged += new System.EventHandler(this.rbtipogranoindustria_CheckedChanged);
            // 
            // rbtipogranorechazoseleccion
            // 
            this.rbtipogranorechazoseleccion.BaseColor = System.Drawing.SystemColors.Control;
            this.rbtipogranorechazoseleccion.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbtipogranorechazoseleccion.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbtipogranorechazoseleccion.FillColor = System.Drawing.Color.White;
            this.rbtipogranorechazoseleccion.Location = new System.Drawing.Point(3, 71);
            this.rbtipogranorechazoseleccion.Name = "rbtipogranorechazoseleccion";
            this.rbtipogranorechazoseleccion.Size = new System.Drawing.Size(154, 20);
            this.rbtipogranorechazoseleccion.TabIndex = 1;
            this.rbtipogranorechazoseleccion.Text = "RECHAZO SELECCION";
            this.rbtipogranorechazoseleccion.CheckedChanged += new System.EventHandler(this.rbtipogranorechazoseleccion_CheckedChanged);
            // 
            // rbtipogranoblanchado
            // 
            this.rbtipogranoblanchado.BaseColor = System.Drawing.SystemColors.Control;
            this.rbtipogranoblanchado.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbtipogranoblanchado.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbtipogranoblanchado.FillColor = System.Drawing.Color.White;
            this.rbtipogranoblanchado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtipogranoblanchado.Location = new System.Drawing.Point(3, 38);
            this.rbtipogranoblanchado.Name = "rbtipogranoblanchado";
            this.rbtipogranoblanchado.Size = new System.Drawing.Size(118, 20);
            this.rbtipogranoblanchado.TabIndex = 0;
            this.rbtipogranoblanchado.Text = "BLANCHADO";
            this.rbtipogranoblanchado.CheckedChanged += new System.EventHandler(this.rbtipogranoblanchado_CheckedChanged);
            // 
            // dtpfeingstk
            // 
            this.dtpfeingstk.BaseColor = System.Drawing.Color.White;
            this.dtpfeingstk.BorderColor = System.Drawing.Color.Silver;
            this.dtpfeingstk.CustomFormat = null;
            this.dtpfeingstk.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpfeingstk.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpfeingstk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpfeingstk.ForeColor = System.Drawing.Color.Black;
            this.dtpfeingstk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfeingstk.Location = new System.Drawing.Point(212, 76);
            this.dtpfeingstk.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpfeingstk.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpfeingstk.Name = "dtpfeingstk";
            this.dtpfeingstk.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpfeingstk.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpfeingstk.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpfeingstk.OnPressedColor = System.Drawing.Color.Black;
            this.dtpfeingstk.Size = new System.Drawing.Size(127, 30);
            this.dtpfeingstk.TabIndex = 15;
            this.dtpfeingstk.Text = "31/10/2021";
            this.dtpfeingstk.Value = new System.DateTime(2021, 10, 31, 10, 1, 36, 351);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(3, 76);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(208, 30);
            this.gunaLabel2.TabIndex = 14;
            this.gunaLabel2.Text = "FECHA INGRESO A STOCK";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(3, 50);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(248, 23);
            this.gunaLabel1.TabIndex = 13;
            this.gunaLabel1.Text = "AGREGAR PRODUCTOS";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMenuizquierdo
            // 
            this.btnMenuizquierdo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenuizquierdo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuizquierdo.Image = global::Omnitec.Properties.Resources.menu2;
            this.btnMenuizquierdo.Location = new System.Drawing.Point(357, 0);
            this.btnMenuizquierdo.Name = "btnMenuizquierdo";
            this.btnMenuizquierdo.Size = new System.Drawing.Size(43, 37);
            this.btnMenuizquierdo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMenuizquierdo.TabIndex = 12;
            this.btnMenuizquierdo.TabStop = false;
            this.btnMenuizquierdo.Click += new System.EventHandler(this.btnMenuizquierdo_Click);
            // 
            // panelsuperior
            // 
            this.panelsuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelsuperior.BackgroundImage")));
            this.panelsuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelsuperior.Controls.Add(this.lblote);
            this.panelsuperior.Controls.Add(this.label19);
            this.panelsuperior.Controls.Add(this.btncerrar);
            this.panelsuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsuperior.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelsuperior.GradientColor2 = System.Drawing.Color.Gray;
            this.panelsuperior.GradientColor3 = System.Drawing.Color.Silver;
            this.panelsuperior.GradientColor4 = System.Drawing.Color.White;
            this.panelsuperior.Location = new System.Drawing.Point(0, 0);
            this.panelsuperior.Name = "panelsuperior";
            this.panelsuperior.Size = new System.Drawing.Size(944, 29);
            this.panelsuperior.TabIndex = 15;
            this.panelsuperior.Text = "gunaGradientPanel1";
            // 
            // lblote
            // 
            this.lblote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblote.Location = new System.Drawing.Point(183, -1);
            this.lblote.Name = "lblote";
            this.lblote.Size = new System.Drawing.Size(420, 30);
            this.lblote.TabIndex = 26;
            this.lblote.Text = "ASOCIAR ORDENES";
            this.lblote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(0, -1);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(177, 30);
            this.label19.TabIndex = 24;
            this.label19.Text = "PRODUCTOS";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Image = global::Omnitec.Properties.Resources.Close;
            this.btncerrar.Location = new System.Drawing.Point(906, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(38, 29);
            this.btncerrar.TabIndex = 5;
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // printPreviewDialog_listaproductos
            // 
            this.printPreviewDialog_listaproductos.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog_listaproductos.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog_listaproductos.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog_listaproductos.Enabled = true;
            this.printPreviewDialog_listaproductos.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog_listaproductos.Icon")));
            this.printPreviewDialog_listaproductos.Name = "printPreviewDialog_etiquetas";
            this.printPreviewDialog_listaproductos.Visible = false;
            // 
            // pictureBoxlogo
            // 
            this.pictureBoxlogo.Image = global::Omnitec.Properties.Resources.logo_pafsa_20;
            this.pictureBoxlogo.Location = new System.Drawing.Point(7, 6);
            this.pictureBoxlogo.Name = "pictureBoxlogo";
            this.pictureBoxlogo.Size = new System.Drawing.Size(42, 41);
            this.pictureBoxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxlogo.TabIndex = 24;
            this.pictureBoxlogo.TabStop = false;
            // 
            // frmverproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.panel_principal);
            this.Controls.Add(this.panelsuperior);
            this.Name = "frmverproductos";
            this.Text = "frmverproductos";
            this.Load += new System.EventHandler(this.frmverproductos_Load);
            this.panel_principal.ResumeLayout(false);
            this.panelcontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductosordenes)).EndInit();
            this.panelmenulateralizquierdo.ResumeLayout(false);
            this.gbgrano.ResumeLayout(false);
            this.gbtipoproducto.ResumeLayout(false);
            this.gbtipoproducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuizquierdo)).EndInit();
            this.panelsuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label19;
        private Guna.UI.WinForms.GunaGradientPanel panelsuperior;
        private System.Windows.Forms.Button btncerrar;
        public System.Windows.Forms.Label lblote;
        private System.Windows.Forms.Panel panel_principal;
        private Guna.UI.WinForms.GunaGradientPanel panelmenulateralizquierdo;
        private System.Windows.Forms.PictureBox btnMenuizquierdo;
        private Guna.UI.WinForms.GunaGradientPanel panelcontenedor;
        private Guna.UI.WinForms.GunaButton btnagregarproducto;
        private Guna.UI.WinForms.GunaTextBox txtkgprod;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaGroupBox gbgrano;
        private Guna.UI.WinForms.GunaLabel lblgrano;
        private Guna.UI.WinForms.GunaComboBox cmbgrano;
        private Guna.UI.WinForms.GunaGroupBox gbtipoproducto;
        private Guna.UI.WinForms.GunaRadioButton rbtipogranoindustria;
        private Guna.UI.WinForms.GunaRadioButton rbtipogranorechazoseleccion;
        private Guna.UI.WinForms.GunaRadioButton rbtipogranoblanchado;
        private Guna.UI.WinForms.GunaDateTimePicker dtpfeingstk;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaDataGridView dgvproductosordenes;
        private Guna.UI.WinForms.GunaButton btnimprimir;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog_listaproductos;
        private System.Drawing.Printing.PrintDocument printDocument_productos;
        private System.Windows.Forms.PictureBox pictureBoxlogo;
    }
}