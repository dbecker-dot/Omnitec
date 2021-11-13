
namespace Omnitec.Views.Ordenes
{
    partial class frmprocesarproductosdeorden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprocesarproductosdeorden));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelsuperior = new Guna.UI.WinForms.GunaGradientPanel();
            this.lblote = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panelmenulateralizquierdo = new Guna.UI.WinForms.GunaGradientPanel();
            this.btnMenuizquierdo = new System.Windows.Forms.PictureBox();
            this.panelcontenedor = new Guna.UI.WinForms.GunaGradientPanel();
            this.dtpfegstk = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cmblotesasoc = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.panelsuperior.SuspendLayout();
            this.panelmenulateralizquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuizquierdo)).BeginInit();
            this.panelcontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelsuperior
            // 
            this.panelsuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelsuperior.BackgroundImage")));
            this.panelsuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelsuperior.Controls.Add(this.lblote);
            this.panelsuperior.Controls.Add(this.label19);
            this.panelsuperior.Controls.Add(this.BtnCerrar);
            this.panelsuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsuperior.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelsuperior.GradientColor2 = System.Drawing.Color.Gray;
            this.panelsuperior.GradientColor3 = System.Drawing.Color.Silver;
            this.panelsuperior.GradientColor4 = System.Drawing.Color.White;
            this.panelsuperior.Location = new System.Drawing.Point(0, 0);
            this.panelsuperior.Name = "panelsuperior";
            this.panelsuperior.Size = new System.Drawing.Size(784, 29);
            this.panelsuperior.TabIndex = 1;
            this.panelsuperior.Text = "gunaGradientPanel1";
            // 
            // lblote
            // 
            this.lblote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblote.Location = new System.Drawing.Point(183, 0);
            this.lblote.Name = "lblote";
            this.lblote.Size = new System.Drawing.Size(420, 30);
            this.lblote.TabIndex = 27;
            this.lblote.Text = "ASOCIAR ORDENES";
            this.lblote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(177, 30);
            this.label19.TabIndex = 26;
            this.label19.Text = "PROCESAR PRODUCTOS";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::Omnitec.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(746, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(38, 29);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panelmenulateralizquierdo
            // 
            this.panelmenulateralizquierdo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelmenulateralizquierdo.BackgroundImage")));
            this.panelmenulateralizquierdo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelmenulateralizquierdo.Controls.Add(this.btnMenuizquierdo);
            this.panelmenulateralizquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenulateralizquierdo.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelmenulateralizquierdo.GradientColor2 = System.Drawing.Color.White;
            this.panelmenulateralizquierdo.GradientColor3 = System.Drawing.Color.White;
            this.panelmenulateralizquierdo.GradientColor4 = System.Drawing.Color.White;
            this.panelmenulateralizquierdo.Location = new System.Drawing.Point(0, 29);
            this.panelmenulateralizquierdo.Name = "panelmenulateralizquierdo";
            this.panelmenulateralizquierdo.Size = new System.Drawing.Size(1, 421);
            this.panelmenulateralizquierdo.TabIndex = 2;
            this.panelmenulateralizquierdo.Text = "gunaGradientPanel1";
            // 
            // btnMenuizquierdo
            // 
            this.btnMenuizquierdo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenuizquierdo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuizquierdo.Image = global::Omnitec.Properties.Resources.menu2;
            this.btnMenuizquierdo.Location = new System.Drawing.Point(-42, 0);
            this.btnMenuizquierdo.Name = "btnMenuizquierdo";
            this.btnMenuizquierdo.Size = new System.Drawing.Size(43, 37);
            this.btnMenuizquierdo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMenuizquierdo.TabIndex = 12;
            this.btnMenuizquierdo.TabStop = false;
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelcontenedor.BackgroundImage")));
            this.panelcontenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcontenedor.Controls.Add(this.dtpfegstk);
            this.panelcontenedor.Controls.Add(this.gunaLabel1);
            this.panelcontenedor.Controls.Add(this.cmblotesasoc);
            this.panelcontenedor.Controls.Add(this.gunaLabel2);
            this.panelcontenedor.Controls.Add(this.dgvproductos);
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.GradientColor1 = System.Drawing.Color.Silver;
            this.panelcontenedor.GradientColor2 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor3 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor4 = System.Drawing.Color.White;
            this.panelcontenedor.Location = new System.Drawing.Point(1, 29);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(783, 421);
            this.panelcontenedor.TabIndex = 3;
            this.panelcontenedor.Text = "gunaGradientPanel1";
            // 
            // dtpfegstk
            // 
            this.dtpfegstk.BaseColor = System.Drawing.Color.White;
            this.dtpfegstk.BorderColor = System.Drawing.Color.Silver;
            this.dtpfegstk.CustomFormat = null;
            this.dtpfegstk.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpfegstk.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpfegstk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpfegstk.ForeColor = System.Drawing.Color.Black;
            this.dtpfegstk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfegstk.Location = new System.Drawing.Point(495, 13);
            this.dtpfegstk.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpfegstk.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpfegstk.Name = "dtpfegstk";
            this.dtpfegstk.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpfegstk.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpfegstk.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpfegstk.OnPressedColor = System.Drawing.Color.Black;
            this.dtpfegstk.Size = new System.Drawing.Size(127, 30);
            this.dtpfegstk.TabIndex = 153;
            this.dtpfegstk.Text = "31/10/2021";
            this.dtpfegstk.Value = new System.DateTime(2021, 10, 31, 10, 1, 36, 351);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(283, 13);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(208, 30);
            this.gunaLabel1.TabIndex = 152;
            this.gunaLabel1.Text = "FECHA EGRESO DE STOCK";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmblotesasoc
            // 
            this.cmblotesasoc.BackColor = System.Drawing.Color.Transparent;
            this.cmblotesasoc.BaseColor = System.Drawing.Color.White;
            this.cmblotesasoc.BorderColor = System.Drawing.Color.Silver;
            this.cmblotesasoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmblotesasoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmblotesasoc.FocusedColor = System.Drawing.Color.Empty;
            this.cmblotesasoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmblotesasoc.ForeColor = System.Drawing.Color.Black;
            this.cmblotesasoc.FormattingEnabled = true;
            this.cmblotesasoc.Location = new System.Drawing.Point(3, 32);
            this.cmblotesasoc.Name = "cmblotesasoc";
            this.cmblotesasoc.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmblotesasoc.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmblotesasoc.Size = new System.Drawing.Size(256, 26);
            this.cmblotesasoc.TabIndex = 151;
            this.cmblotesasoc.SelectedIndexChanged += new System.EventHandler(this.cmblotesasoc_SelectedIndexChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(3, 3);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(200, 26);
            this.gunaLabel2.TabIndex = 149;
            this.gunaLabel2.Text = "LOTES ASOCIADOS";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvproductos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvproductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvproductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvproductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.dgvproductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvproductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvproductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvproductos.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvproductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvproductos.EnableHeadersVisualStyles = false;
            this.dgvproductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dgvproductos.Location = new System.Drawing.Point(6, 64);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvproductos.Size = new System.Drawing.Size(765, 345);
            this.dgvproductos.TabIndex = 148;
            this.dgvproductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductos_CellClick);
            // 
            // frmprocesarproductosdeorden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.panelmenulateralizquierdo);
            this.Controls.Add(this.panelsuperior);
            this.Name = "frmprocesarproductosdeorden";
            this.Text = "frmprocesarproductosdeorden";
            this.Load += new System.EventHandler(this.frmprocesarproductosdeorden_Load);
            this.panelsuperior.ResumeLayout(false);
            this.panelmenulateralizquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuizquierdo)).EndInit();
            this.panelcontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel panelsuperior;
        private System.Windows.Forms.Button BtnCerrar;
        public System.Windows.Forms.Label lblote;
        private System.Windows.Forms.Label label19;
        private Guna.UI.WinForms.GunaGradientPanel panelmenulateralizquierdo;
        private System.Windows.Forms.PictureBox btnMenuizquierdo;
        private Guna.UI.WinForms.GunaGradientPanel panelcontenedor;
        private System.Windows.Forms.DataGridView dgvproductos;
        private Guna.UI.WinForms.GunaComboBox cmblotesasoc;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaDateTimePicker dtpfegstk;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}