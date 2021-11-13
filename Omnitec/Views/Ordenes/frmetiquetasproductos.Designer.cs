
namespace Omnitec.Views.Ordenes
{
    partial class frmetiquetasproductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmetiquetasproductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelcontenedor = new Guna.UI.WinForms.GunaGradientPanel();
            this.lblkg = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.lblcodigo = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.lbltipoproducto = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.lblgrano = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.lblfeingreso = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lblcliente = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.pb_etiqueta = new Guna.UI.WinForms.GunaPictureBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.dgvetiquetas = new Guna.UI.WinForms.GunaDataGridView();
            this.panelsuperior = new Guna.UI.WinForms.GunaGradientPanel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.printDocument_etiquetas = new System.Drawing.Printing.PrintDocument();
            this.btnimprimiretiqueta = new FontAwesome.Sharp.IconButton();
            this.printPreviewDialog_etiquetas = new System.Windows.Forms.PrintPreviewDialog();
            this.btnimprimirtodasetiqueta = new FontAwesome.Sharp.IconButton();
            this.panelcontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_etiqueta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvetiquetas)).BeginInit();
            this.panelsuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelcontenedor.BackgroundImage")));
            this.panelcontenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcontenedor.Controls.Add(this.btnimprimirtodasetiqueta);
            this.panelcontenedor.Controls.Add(this.btnimprimiretiqueta);
            this.panelcontenedor.Controls.Add(this.lblkg);
            this.panelcontenedor.Controls.Add(this.gunaLabel5);
            this.panelcontenedor.Controls.Add(this.lblcodigo);
            this.panelcontenedor.Controls.Add(this.gunaLabel8);
            this.panelcontenedor.Controls.Add(this.lbltipoproducto);
            this.panelcontenedor.Controls.Add(this.gunaLabel4);
            this.panelcontenedor.Controls.Add(this.lblgrano);
            this.panelcontenedor.Controls.Add(this.gunaLabel6);
            this.panelcontenedor.Controls.Add(this.lblfeingreso);
            this.panelcontenedor.Controls.Add(this.gunaLabel2);
            this.panelcontenedor.Controls.Add(this.lblcliente);
            this.panelcontenedor.Controls.Add(this.gunaLabel3);
            this.panelcontenedor.Controls.Add(this.pb_etiqueta);
            this.panelcontenedor.Controls.Add(this.btnSiguiente);
            this.panelcontenedor.Controls.Add(this.btnAnterior);
            this.panelcontenedor.Controls.Add(this.dgvetiquetas);
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.GradientColor1 = System.Drawing.Color.Silver;
            this.panelcontenedor.GradientColor2 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor3 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor4 = System.Drawing.Color.White;
            this.panelcontenedor.Location = new System.Drawing.Point(0, 29);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(800, 371);
            this.panelcontenedor.TabIndex = 3;
            this.panelcontenedor.Text = "gunaGradientPanel1";
            // 
            // lblkg
            // 
            this.lblkg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblkg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblkg.Location = new System.Drawing.Point(692, 133);
            this.lblkg.Name = "lblkg";
            this.lblkg.Size = new System.Drawing.Size(91, 23);
            this.lblkg.TabIndex = 71;
            this.lblkg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.Location = new System.Drawing.Point(638, 133);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(53, 23);
            this.gunaLabel5.TabIndex = 70;
            this.gunaLabel5.Text = "KG";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcodigo
            // 
            this.lblcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblcodigo.Location = new System.Drawing.Point(533, 166);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(250, 23);
            this.lblcodigo.TabIndex = 69;
            this.lblcodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel8.Location = new System.Drawing.Point(459, 166);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(77, 23);
            this.gunaLabel8.TabIndex = 68;
            this.gunaLabel8.Text = "CODIGO";
            this.gunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltipoproducto
            // 
            this.lbltipoproducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltipoproducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbltipoproducto.Location = new System.Drawing.Point(609, 100);
            this.lbltipoproducto.Name = "lbltipoproducto";
            this.lbltipoproducto.Size = new System.Drawing.Size(174, 23);
            this.lbltipoproducto.TabIndex = 67;
            this.lbltipoproducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.Location = new System.Drawing.Point(459, 100);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(149, 23);
            this.gunaLabel4.TabIndex = 66;
            this.gunaLabel4.Text = "TIPO PRODUCTO";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblgrano
            // 
            this.lblgrano.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblgrano.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblgrano.Location = new System.Drawing.Point(533, 133);
            this.lblgrano.Name = "lblgrano";
            this.lblgrano.Size = new System.Drawing.Size(99, 23);
            this.lblgrano.TabIndex = 65;
            this.lblgrano.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel6.Location = new System.Drawing.Point(459, 133);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(77, 23);
            this.gunaLabel6.TabIndex = 64;
            this.gunaLabel6.Text = "GRANO";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblfeingreso
            // 
            this.lblfeingreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblfeingreso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblfeingreso.Location = new System.Drawing.Point(597, 34);
            this.lblfeingreso.Name = "lblfeingreso";
            this.lblfeingreso.Size = new System.Drawing.Size(186, 23);
            this.lblfeingreso.TabIndex = 63;
            this.lblfeingreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(459, 34);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(137, 23);
            this.gunaLabel2.TabIndex = 62;
            this.gunaLabel2.Text = "FECHA INGRESO";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcliente
            // 
            this.lblcliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblcliente.Location = new System.Drawing.Point(533, 67);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(250, 23);
            this.lblcliente.TabIndex = 61;
            this.lblcliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.Location = new System.Drawing.Point(459, 67);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(77, 23);
            this.gunaLabel3.TabIndex = 60;
            this.gunaLabel3.Text = "CLIENTE";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_etiqueta
            // 
            this.pb_etiqueta.BaseColor = System.Drawing.Color.White;
            this.pb_etiqueta.Location = new System.Drawing.Point(21, 34);
            this.pb_etiqueta.Name = "pb_etiqueta";
            this.pb_etiqueta.Size = new System.Drawing.Size(432, 312);
            this.pb_etiqueta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_etiqueta.TabIndex = 59;
            this.pb_etiqueta.TabStop = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(70, 6);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(40, 23);
            this.btnSiguiente.TabIndex = 58;
            this.btnSiguiente.Text = ">>";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(21, 6);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(43, 23);
            this.btnAnterior.TabIndex = 57;
            this.btnAnterior.Text = "<<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // dgvetiquetas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvetiquetas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvetiquetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvetiquetas.BackgroundColor = System.Drawing.Color.White;
            this.dgvetiquetas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvetiquetas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvetiquetas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvetiquetas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvetiquetas.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvetiquetas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvetiquetas.EnableHeadersVisualStyles = false;
            this.dgvetiquetas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvetiquetas.Location = new System.Drawing.Point(459, 206);
            this.dgvetiquetas.Name = "dgvetiquetas";
            this.dgvetiquetas.RowHeadersVisible = false;
            this.dgvetiquetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvetiquetas.Size = new System.Drawing.Size(324, 43);
            this.dgvetiquetas.TabIndex = 0;
            this.dgvetiquetas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvetiquetas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvetiquetas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvetiquetas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvetiquetas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvetiquetas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvetiquetas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvetiquetas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvetiquetas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvetiquetas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvetiquetas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvetiquetas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvetiquetas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvetiquetas.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvetiquetas.ThemeStyle.ReadOnly = false;
            this.dgvetiquetas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvetiquetas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvetiquetas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvetiquetas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvetiquetas.ThemeStyle.RowsStyle.Height = 22;
            this.dgvetiquetas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvetiquetas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panelsuperior
            // 
            this.panelsuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelsuperior.BackgroundImage")));
            this.panelsuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelsuperior.Controls.Add(this.BtnCerrar);
            this.panelsuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsuperior.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelsuperior.GradientColor2 = System.Drawing.Color.Gray;
            this.panelsuperior.GradientColor3 = System.Drawing.Color.Silver;
            this.panelsuperior.GradientColor4 = System.Drawing.Color.White;
            this.panelsuperior.Location = new System.Drawing.Point(0, 0);
            this.panelsuperior.Name = "panelsuperior";
            this.panelsuperior.Size = new System.Drawing.Size(800, 29);
            this.panelsuperior.TabIndex = 1;
            this.panelsuperior.Text = "gunaGradientPanel1";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::Omnitec.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(762, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(38, 29);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnimprimiretiqueta
            // 
            this.btnimprimiretiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimiretiqueta.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnimprimiretiqueta.IconColor = System.Drawing.Color.Black;
            this.btnimprimiretiqueta.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnimprimiretiqueta.IconSize = 25;
            this.btnimprimiretiqueta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimiretiqueta.Location = new System.Drawing.Point(459, 255);
            this.btnimprimiretiqueta.Name = "btnimprimiretiqueta";
            this.btnimprimiretiqueta.Size = new System.Drawing.Size(126, 30);
            this.btnimprimiretiqueta.TabIndex = 72;
            this.btnimprimiretiqueta.Text = "IMPRIMIR";
            this.btnimprimiretiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnimprimiretiqueta.UseVisualStyleBackColor = true;
            this.btnimprimiretiqueta.Click += new System.EventHandler(this.btnimprimiretiqueta_Click);
            // 
            // printPreviewDialog_etiquetas
            // 
            this.printPreviewDialog_etiquetas.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog_etiquetas.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog_etiquetas.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog_etiquetas.Enabled = true;
            this.printPreviewDialog_etiquetas.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog_etiquetas.Icon")));
            this.printPreviewDialog_etiquetas.Name = "printPreviewDialog_etiquetas";
            this.printPreviewDialog_etiquetas.Visible = false;
            // 
            // btnimprimirtodasetiqueta
            // 
            this.btnimprimirtodasetiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimirtodasetiqueta.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnimprimirtodasetiqueta.IconColor = System.Drawing.Color.Black;
            this.btnimprimirtodasetiqueta.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnimprimirtodasetiqueta.IconSize = 25;
            this.btnimprimirtodasetiqueta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimirtodasetiqueta.Location = new System.Drawing.Point(459, 291);
            this.btnimprimirtodasetiqueta.Name = "btnimprimirtodasetiqueta";
            this.btnimprimirtodasetiqueta.Size = new System.Drawing.Size(193, 30);
            this.btnimprimirtodasetiqueta.TabIndex = 73;
            this.btnimprimirtodasetiqueta.Text = "IMPRIMIR TODAS";
            this.btnimprimirtodasetiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnimprimirtodasetiqueta.UseVisualStyleBackColor = true;
            this.btnimprimirtodasetiqueta.Click += new System.EventHandler(this.btnimprimirtodasetiqueta_Click);
            // 
            // frmetiquetasproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.panelsuperior);
            this.Name = "frmetiquetasproductos";
            this.Text = "frmetiquetasproductos";
            this.Load += new System.EventHandler(this.frmetiquetasproductos_Load);
            this.panelcontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_etiqueta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvetiquetas)).EndInit();
            this.panelsuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel panelsuperior;
        private System.Windows.Forms.Button BtnCerrar;
        private Guna.UI.WinForms.GunaGradientPanel panelcontenedor;
        private Guna.UI.WinForms.GunaDataGridView dgvetiquetas;
        private Guna.UI.WinForms.GunaPictureBox pb_etiqueta;
        internal System.Windows.Forms.Button btnSiguiente;
        internal System.Windows.Forms.Button btnAnterior;
        private Guna.UI.WinForms.GunaLabel lblkg;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel lblcodigo;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel lbltipoproducto;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel lblgrano;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel lblfeingreso;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel lblcliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Drawing.Printing.PrintDocument printDocument_etiquetas;
        private FontAwesome.Sharp.IconButton btnimprimiretiqueta;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog_etiquetas;
        private FontAwesome.Sharp.IconButton btnimprimirtodasetiqueta;
    }
}