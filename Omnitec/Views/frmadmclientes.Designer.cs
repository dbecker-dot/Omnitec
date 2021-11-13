namespace Omnitec.Views
{
    partial class frmadmclientes
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
            this.TablaCliente = new System.Windows.Forms.DataGridView();
            this.panel_Superior = new System.Windows.Forms.Panel();
            this.txttituloform = new CustomControls.RJControls.RJTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnnuevo = new Soporte.Recursos.CustomButtons();
            this.txtbusqueda = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCliente)).BeginInit();
            this.panel_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaCliente
            // 
            this.TablaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaCliente.Location = new System.Drawing.Point(9, 103);
            this.TablaCliente.Margin = new System.Windows.Forms.Padding(2);
            this.TablaCliente.Name = "TablaCliente";
            this.TablaCliente.RowTemplate.Height = 24;
            this.TablaCliente.Size = new System.Drawing.Size(747, 279);
            this.TablaCliente.TabIndex = 0;
            this.TablaCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaCliente_CellContentClick);
            // 
            // panel_Superior
            // 
            this.panel_Superior.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_Superior.Controls.Add(this.txttituloform);
            this.panel_Superior.Controls.Add(this.pictureBox1);
            this.panel_Superior.Controls.Add(this.BtnCerrar);
            this.panel_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Superior.Location = new System.Drawing.Point(0, 0);
            this.panel_Superior.Name = "panel_Superior";
            this.panel_Superior.Size = new System.Drawing.Size(777, 42);
            this.panel_Superior.TabIndex = 3;
            // 
            // txttituloform
            // 
            this.txttituloform.BackColor = System.Drawing.Color.Lime;
            this.txttituloform.BorderColor = System.Drawing.Color.Black;
            this.txttituloform.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txttituloform.BorderSize = 2;
            this.txttituloform.Enabled = false;
            this.txttituloform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttituloform.ForeColor = System.Drawing.Color.DimGray;
            this.txttituloform.Location = new System.Drawing.Point(54, 7);
            this.txttituloform.Margin = new System.Windows.Forms.Padding(4);
            this.txttituloform.Multiline = false;
            this.txttituloform.Name = "txttituloform";
            this.txttituloform.Padding = new System.Windows.Forms.Padding(7);
            this.txttituloform.PasswordChar = false;
            this.txttituloform.Size = new System.Drawing.Size(348, 31);
            this.txttituloform.TabIndex = 24;
            this.txttituloform.Texts = "";
            this.txttituloform.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Omnitec.Properties.Resources.logo_pafsa_20;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::Omnitec.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(734, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(43, 43);
            this.BtnCerrar.TabIndex = 23;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "BUSCAR CLIENTE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnnuevo.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnnuevo.BorderColor = System.Drawing.Color.Black;
            this.btnnuevo.BorderColor1 = System.Drawing.Color.Black;
            this.btnnuevo.BorderRadius = 15;
            this.btnnuevo.BorderRadius1 = 15;
            this.btnnuevo.BorderSize = 5;
            this.btnnuevo.BorderSize1 = 5;
            this.btnnuevo.FlatAppearance.BorderSize = 0;
            this.btnnuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.ForeColor = System.Drawing.Color.White;
            this.btnnuevo.Location = new System.Drawing.Point(607, 49);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(150, 40);
            this.btnnuevo.TabIndex = 6;
            this.btnnuevo.Text = "NUEVO";
            this.btnnuevo.TextColor = System.Drawing.Color.White;
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BackColor = System.Drawing.SystemColors.Window;
            this.txtbusqueda.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbusqueda.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbusqueda.BorderSize = 2;
            this.txtbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.ForeColor = System.Drawing.Color.DimGray;
            this.txtbusqueda.Location = new System.Drawing.Point(199, 54);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtbusqueda.Multiline = false;
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Padding = new System.Windows.Forms.Padding(7);
            this.txtbusqueda.PasswordChar = false;
            this.txtbusqueda.Size = new System.Drawing.Size(401, 31);
            this.txtbusqueda.TabIndex = 5;
            this.txtbusqueda.Texts = "";
            this.txtbusqueda.UnderlinedStyle = false;
            this.txtbusqueda._TextChanged += new System.EventHandler(this.txtbusqueda__TextChanged);
            // 
            // frmadmclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 393);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Superior);
            this.Controls.Add(this.TablaCliente);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmadmclientes";
            this.Text = "ClienteView";
            this.Load += new System.EventHandler(this.frmadmclientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaCliente)).EndInit();
            this.panel_Superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView TablaCliente;
        private System.Windows.Forms.Panel panel_Superior;
        private CustomControls.RJControls.RJTextBox txttituloform;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txtbusqueda;
        private Soporte.Recursos.CustomButtons btnnuevo;
    }
}