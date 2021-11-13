
namespace Omnitec.Views.Ordenes
{
    partial class frmabmordendeproduccion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmabmordendeproduccion));
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.dgvordenparasoc = new System.Windows.Forms.DataGridView();
            this.asociar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelsuperior = new Guna.UI.WinForms.GunaGradientPanel();
            this.lbltituloform = new System.Windows.Forms.Label();
            this.panelcontenedorcabecera = new Guna.UI.WinForms.GunaGradientPanel();
            this.txtobservacionesaltaorden = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.lblote = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.cmbcliente = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lblfecha = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.btnguardarcambiosorden = new Guna.UI.WinForms.GunaButton();
            this.btnanulareabreorden = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenparasoc)).BeginInit();
            this.panelsuperior.SuspendLayout();
            this.panelcontenedorcabecera.SuspendLayout();
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
            this.BtnCerrar.Location = new System.Drawing.Point(835, -1);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(33, 31);
            this.BtnCerrar.TabIndex = 23;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // dgvordenparasoc
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvordenparasoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvordenparasoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvordenparasoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvordenparasoc.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvordenparasoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvordenparasoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvordenparasoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvordenparasoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvordenparasoc.ColumnHeadersHeight = 30;
            this.dgvordenparasoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asociar});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvordenparasoc.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvordenparasoc.EnableHeadersVisualStyles = false;
            this.dgvordenparasoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvordenparasoc.Location = new System.Drawing.Point(3, 211);
            this.dgvordenparasoc.Name = "dgvordenparasoc";
            this.dgvordenparasoc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvordenparasoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvordenparasoc.Size = new System.Drawing.Size(838, 110);
            this.dgvordenparasoc.TabIndex = 136;
            // 
            // asociar
            // 
            this.asociar.HeaderText = "Asociar";
            this.asociar.Name = "asociar";
            this.asociar.Width = 67;
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
            this.panelsuperior.Size = new System.Drawing.Size(868, 29);
            this.panelsuperior.TabIndex = 140;
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
            this.panelcontenedorcabecera.Controls.Add(this.gunaLabel1);
            this.panelcontenedorcabecera.Controls.Add(this.txtobservacionesaltaorden);
            this.panelcontenedorcabecera.Controls.Add(this.gunaLabel13);
            this.panelcontenedorcabecera.Controls.Add(this.lblote);
            this.panelcontenedorcabecera.Controls.Add(this.gunaLabel3);
            this.panelcontenedorcabecera.Controls.Add(this.dgvordenparasoc);
            this.panelcontenedorcabecera.Controls.Add(this.cmbcliente);
            this.panelcontenedorcabecera.Controls.Add(this.gunaLabel2);
            this.panelcontenedorcabecera.Controls.Add(this.lblfecha);
            this.panelcontenedorcabecera.Controls.Add(this.gunaLabel7);
            this.panelcontenedorcabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelcontenedorcabecera.GradientColor1 = System.Drawing.Color.Silver;
            this.panelcontenedorcabecera.GradientColor2 = System.Drawing.Color.White;
            this.panelcontenedorcabecera.GradientColor3 = System.Drawing.Color.White;
            this.panelcontenedorcabecera.GradientColor4 = System.Drawing.Color.White;
            this.panelcontenedorcabecera.Location = new System.Drawing.Point(0, 29);
            this.panelcontenedorcabecera.Name = "panelcontenedorcabecera";
            this.panelcontenedorcabecera.Size = new System.Drawing.Size(868, 328);
            this.panelcontenedorcabecera.TabIndex = 141;
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
            this.txtobservacionesaltaorden.Location = new System.Drawing.Point(3, 106);
            this.txtobservacionesaltaorden.MultiLine = true;
            this.txtobservacionesaltaorden.Name = "txtobservacionesaltaorden";
            this.txtobservacionesaltaorden.PasswordChar = '\0';
            this.txtobservacionesaltaorden.Size = new System.Drawing.Size(884, 65);
            this.txtobservacionesaltaorden.TabIndex = 28;
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel13.Location = new System.Drawing.Point(3, 82);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(178, 23);
            this.gunaLabel13.TabIndex = 27;
            this.gunaLabel13.Text = "OBSERVACIONES";
            this.gunaLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblote
            // 
            this.lblote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblote.Location = new System.Drawing.Point(70, 38);
            this.lblote.Name = "lblote";
            this.lblote.Size = new System.Drawing.Size(438, 23);
            this.lblote.TabIndex = 20;
            this.lblote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.Location = new System.Drawing.Point(3, 38);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(67, 23);
            this.gunaLabel3.TabIndex = 19;
            this.gunaLabel3.Text = "LOTE";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // gunaLabel7
            // 
            this.gunaLabel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel7.Location = new System.Drawing.Point(3, 9);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(67, 23);
            this.gunaLabel7.TabIndex = 0;
            this.gunaLabel7.Text = "FECHA";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnguardarcambiosorden.Location = new System.Drawing.Point(659, 363);
            this.btnguardarcambiosorden.Name = "btnguardarcambiosorden";
            this.btnguardarcambiosorden.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnguardarcambiosorden.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.btnguardarcambiosorden.OnHoverForeColor = System.Drawing.Color.White;
            this.btnguardarcambiosorden.OnHoverImage = null;
            this.btnguardarcambiosorden.OnPressedColor = System.Drawing.Color.Black;
            this.btnguardarcambiosorden.Size = new System.Drawing.Size(206, 42);
            this.btnguardarcambiosorden.TabIndex = 143;
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
            this.btnanulareabreorden.Location = new System.Drawing.Point(479, 363);
            this.btnanulareabreorden.Name = "btnanulareabreorden";
            this.btnanulareabreorden.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnanulareabreorden.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.btnanulareabreorden.OnHoverForeColor = System.Drawing.Color.White;
            this.btnanulareabreorden.OnHoverImage = null;
            this.btnanulareabreorden.OnPressedColor = System.Drawing.Color.Black;
            this.btnanulareabreorden.Size = new System.Drawing.Size(174, 42);
            this.btnanulareabreorden.TabIndex = 142;
            this.btnanulareabreorden.Text = "ANULAR ORDEN";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(3, 185);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(191, 23);
            this.gunaLabel1.TabIndex = 137;
            this.gunaLabel1.Text = "ASOCIAR LOTES";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmabmordendeproduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(868, 411);
            this.Controls.Add(this.btnguardarcambiosorden);
            this.Controls.Add(this.btnanulareabreorden);
            this.Controls.Add(this.panelcontenedorcabecera);
            this.Controls.Add(this.panelsuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmabmordendeproduccion";
            this.Text = "frmabmordenesdeproduccion";
            this.Load += new System.EventHandler(this.frmabmordendeproduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenparasoc)).EndInit();
            this.panelsuperior.ResumeLayout(false);
            this.panelcontenedorcabecera.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DataGridView dgvordenparasoc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn asociar;
        private Guna.UI.WinForms.GunaGradientPanel panelsuperior;
        public System.Windows.Forms.Label lbltituloform;
        private Guna.UI.WinForms.GunaGradientPanel panelcontenedorcabecera;
        private Guna.UI.WinForms.GunaTextBox txtobservacionesaltaorden;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private Guna.UI.WinForms.GunaLabel lblote;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaComboBox cmbcliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel lblfecha;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaButton btnguardarcambiosorden;
        private Guna.UI.WinForms.GunaButton btnanulareabreorden;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}