
namespace Omnitec.Views
{
    partial class frmMantCliente
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
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lblaccioncliente = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.chactivo = new System.Windows.Forms.CheckBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.rbcuitexterior = new System.Windows.Forms.RadioButton();
            this.rbcuitinteriorarg = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_ppal = new System.Windows.Forms.Panel();
            this.panel_Selectcuit = new System.Windows.Forms.Panel();
            this.dgvcuitpais = new System.Windows.Forms.DataGridView();
            this.btnocultarselectcuit = new System.Windows.Forms.Button();
            this.tmExpandirMenu = new System.Windows.Forms.Timer(this.components);
            this.tmContraerMenu = new System.Windows.Forms.Timer(this.components);
            this.txtbusquedacuit = new CustomControls.RJControls.RJTextBox();
            this.lblbusqueda = new CustomControls.RJControls.RJTextBox();
            this.txtpais = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            this.btnguardarcambioscliente = new Soporte.Recursos.CustomButtons();
            this.txtid = new CustomControls.RJControls.RJTextBox();
            this.lblId = new CustomControls.RJControls.RJTextBox();
            this.txtcodigo = new CustomControls.RJControls.RJTextBox();
            this.lblnombre = new CustomControls.RJControls.RJTextBox();
            this.lblcodigo = new CustomControls.RJControls.RJTextBox();
            this.txtnombre = new CustomControls.RJControls.RJTextBox();
            this.lblcuit = new CustomControls.RJControls.RJTextBox();
            this.txtcuit = new CustomControls.RJControls.RJTextBox();
            this.BarraTitulo.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_ppal.SuspendLayout();
            this.panel_Selectcuit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuitpais)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BarraTitulo.Controls.Add(this.lblaccioncliente);
            this.BarraTitulo.Controls.Add(this.BtnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(827, 38);
            this.BarraTitulo.TabIndex = 3;
            // 
            // lblaccioncliente
            // 
            this.lblaccioncliente.AutoSize = true;
            this.lblaccioncliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaccioncliente.ForeColor = System.Drawing.Color.White;
            this.lblaccioncliente.Location = new System.Drawing.Point(8, 9);
            this.lblaccioncliente.Name = "lblaccioncliente";
            this.lblaccioncliente.Size = new System.Drawing.Size(130, 24);
            this.lblaccioncliente.TabIndex = 15;
            this.lblaccioncliente.Text = "Form Cliente";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::Omnitec.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(789, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(38, 38);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // chactivo
            // 
            this.chactivo.AutoSize = true;
            this.chactivo.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.chactivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chactivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chactivo.ForeColor = System.Drawing.Color.DimGray;
            this.chactivo.Location = new System.Drawing.Point(270, 171);
            this.chactivo.Name = "chactivo";
            this.chactivo.Size = new System.Drawing.Size(83, 21);
            this.chactivo.TabIndex = 34;
            this.chactivo.Text = "ACTIVO";
            this.chactivo.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.rbcuitexterior);
            this.GroupBox1.Controls.Add(this.rbcuitinteriorarg);
            this.GroupBox1.Location = new System.Drawing.Point(26, 94);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(197, 50);
            this.GroupBox1.TabIndex = 37;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "TIPO CUIT";
            // 
            // rbcuitexterior
            // 
            this.rbcuitexterior.AutoSize = true;
            this.rbcuitexterior.Location = new System.Drawing.Point(111, 19);
            this.rbcuitexterior.Name = "rbcuitexterior";
            this.rbcuitexterior.Size = new System.Drawing.Size(80, 17);
            this.rbcuitexterior.TabIndex = 1;
            this.rbcuitexterior.TabStop = true;
            this.rbcuitexterior.Text = "EXTERIOR";
            this.rbcuitexterior.UseVisualStyleBackColor = true;
            this.rbcuitexterior.CheckedChanged += new System.EventHandler(this.rbcuitexterior_CheckedChanged);
            // 
            // rbcuitinteriorarg
            // 
            this.rbcuitinteriorarg.AutoSize = true;
            this.rbcuitinteriorarg.Location = new System.Drawing.Point(6, 19);
            this.rbcuitinteriorarg.Name = "rbcuitinteriorarg";
            this.rbcuitinteriorarg.Size = new System.Drawing.Size(88, 17);
            this.rbcuitinteriorarg.TabIndex = 0;
            this.rbcuitinteriorarg.TabStop = true;
            this.rbcuitinteriorarg.Text = "ARGENTINA";
            this.rbcuitinteriorarg.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Omnitec.Properties.Resources.icono_cliente;
            this.pictureBox1.Location = new System.Drawing.Point(26, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // panel_ppal
            // 
            this.panel_ppal.BackColor = System.Drawing.Color.DarkGray;
            this.panel_ppal.Controls.Add(this.txtpais);
            this.panel_ppal.Controls.Add(this.rjTextBox2);
            this.panel_ppal.Controls.Add(this.pictureBox1);
            this.panel_ppal.Controls.Add(this.btnguardarcambioscliente);
            this.panel_ppal.Controls.Add(this.txtid);
            this.panel_ppal.Controls.Add(this.GroupBox1);
            this.panel_ppal.Controls.Add(this.lblId);
            this.panel_ppal.Controls.Add(this.txtcodigo);
            this.panel_ppal.Controls.Add(this.lblnombre);
            this.panel_ppal.Controls.Add(this.lblcodigo);
            this.panel_ppal.Controls.Add(this.txtnombre);
            this.panel_ppal.Controls.Add(this.chactivo);
            this.panel_ppal.Controls.Add(this.lblcuit);
            this.panel_ppal.Controls.Add(this.txtcuit);
            this.panel_ppal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ppal.Location = new System.Drawing.Point(0, 38);
            this.panel_ppal.Name = "panel_ppal";
            this.panel_ppal.Size = new System.Drawing.Size(827, 202);
            this.panel_ppal.TabIndex = 39;
            // 
            // panel_Selectcuit
            // 
            this.panel_Selectcuit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel_Selectcuit.Controls.Add(this.dgvcuitpais);
            this.panel_Selectcuit.Controls.Add(this.txtbusquedacuit);
            this.panel_Selectcuit.Controls.Add(this.lblbusqueda);
            this.panel_Selectcuit.Controls.Add(this.btnocultarselectcuit);
            this.panel_Selectcuit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Selectcuit.Location = new System.Drawing.Point(378, 38);
            this.panel_Selectcuit.Name = "panel_Selectcuit";
            this.panel_Selectcuit.Size = new System.Drawing.Size(449, 202);
            this.panel_Selectcuit.TabIndex = 40;
            // 
            // dgvcuitpais
            // 
            this.dgvcuitpais.AllowUserToAddRows = false;
            this.dgvcuitpais.AllowUserToDeleteRows = false;
            this.dgvcuitpais.AllowUserToOrderColumns = true;
            this.dgvcuitpais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvcuitpais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvcuitpais.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.dgvcuitpais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvcuitpais.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvcuitpais.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcuitpais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcuitpais.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcuitpais.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcuitpais.EnableHeadersVisualStyles = false;
            this.dgvcuitpais.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dgvcuitpais.Location = new System.Drawing.Point(4, 42);
            this.dgvcuitpais.Name = "dgvcuitpais";
            this.dgvcuitpais.ReadOnly = true;
            this.dgvcuitpais.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcuitpais.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcuitpais.Size = new System.Drawing.Size(442, 157);
            this.dgvcuitpais.TabIndex = 39;
            this.dgvcuitpais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcuitpais_CellContentClick);
            // 
            // btnocultarselectcuit
            // 
            this.btnocultarselectcuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnocultarselectcuit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnocultarselectcuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnocultarselectcuit.FlatAppearance.BorderSize = 0;
            this.btnocultarselectcuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnocultarselectcuit.Image = global::Omnitec.Properties.Resources.Close;
            this.btnocultarselectcuit.Location = new System.Drawing.Point(408, 3);
            this.btnocultarselectcuit.Name = "btnocultarselectcuit";
            this.btnocultarselectcuit.Size = new System.Drawing.Size(38, 32);
            this.btnocultarselectcuit.TabIndex = 5;
            this.btnocultarselectcuit.UseVisualStyleBackColor = false;
            this.btnocultarselectcuit.Click += new System.EventHandler(this.btnocultarselectcuit_Click);
            // 
            // tmExpandirMenu
            // 
            this.tmExpandirMenu.Interval = 15;
            // 
            // tmContraerMenu
            // 
            this.tmContraerMenu.Interval = 15;
            // 
            // txtbusquedacuit
            // 
            this.txtbusquedacuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbusquedacuit.BackColor = System.Drawing.SystemColors.Window;
            this.txtbusquedacuit.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbusquedacuit.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbusquedacuit.BorderSize = 2;
            this.txtbusquedacuit.Enabled = false;
            this.txtbusquedacuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusquedacuit.ForeColor = System.Drawing.Color.DimGray;
            this.txtbusquedacuit.Location = new System.Drawing.Point(105, 4);
            this.txtbusquedacuit.Margin = new System.Windows.Forms.Padding(4);
            this.txtbusquedacuit.Multiline = false;
            this.txtbusquedacuit.Name = "txtbusquedacuit";
            this.txtbusquedacuit.Padding = new System.Windows.Forms.Padding(7);
            this.txtbusquedacuit.PasswordChar = false;
            this.txtbusquedacuit.Size = new System.Drawing.Size(303, 31);
            this.txtbusquedacuit.TabIndex = 38;
            this.txtbusquedacuit.Texts = "";
            this.txtbusquedacuit.UnderlinedStyle = false;
            this.txtbusquedacuit._TextChanged += new System.EventHandler(this.txtbusquedacuit__TextChanged);
            // 
            // lblbusqueda
            // 
            this.lblbusqueda.BackColor = System.Drawing.SystemColors.Window;
            this.lblbusqueda.BorderColor = System.Drawing.Color.Lime;
            this.lblbusqueda.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lblbusqueda.BorderSize = 2;
            this.lblbusqueda.Enabled = false;
            this.lblbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbusqueda.ForeColor = System.Drawing.Color.DimGray;
            this.lblbusqueda.Location = new System.Drawing.Point(4, 4);
            this.lblbusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.lblbusqueda.Multiline = false;
            this.lblbusqueda.Name = "lblbusqueda";
            this.lblbusqueda.Padding = new System.Windows.Forms.Padding(7);
            this.lblbusqueda.PasswordChar = false;
            this.lblbusqueda.Size = new System.Drawing.Size(97, 31);
            this.lblbusqueda.TabIndex = 37;
            this.lblbusqueda.Texts = "CUIT / PAIS";
            this.lblbusqueda.UnderlinedStyle = false;
            // 
            // txtpais
            // 
            this.txtpais.BackColor = System.Drawing.SystemColors.Window;
            this.txtpais.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtpais.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtpais.BorderSize = 2;
            this.txtpais.Enabled = false;
            this.txtpais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpais.ForeColor = System.Drawing.Color.DimGray;
            this.txtpais.Location = new System.Drawing.Point(608, 99);
            this.txtpais.Margin = new System.Windows.Forms.Padding(4);
            this.txtpais.Multiline = false;
            this.txtpais.Name = "txtpais";
            this.txtpais.Padding = new System.Windows.Forms.Padding(7);
            this.txtpais.PasswordChar = false;
            this.txtpais.Size = new System.Drawing.Size(199, 31);
            this.txtpais.TabIndex = 40;
            this.txtpais.Texts = "";
            this.txtpais.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox2.BorderColor = System.Drawing.Color.Lime;
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox2.BorderSize = 2;
            this.rjTextBox2.Enabled = false;
            this.rjTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox2.Location = new System.Drawing.Point(553, 99);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.Size = new System.Drawing.Size(55, 31);
            this.rjTextBox2.TabIndex = 39;
            this.rjTextBox2.Texts = "PAIS";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // btnguardarcambioscliente
            // 
            this.btnguardarcambioscliente.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnguardarcambioscliente.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnguardarcambioscliente.BorderColor = System.Drawing.Color.Black;
            this.btnguardarcambioscliente.BorderColor1 = System.Drawing.Color.Black;
            this.btnguardarcambioscliente.BorderRadius = 15;
            this.btnguardarcambioscliente.BorderRadius1 = 15;
            this.btnguardarcambioscliente.BorderSize = 5;
            this.btnguardarcambioscliente.BorderSize1 = 5;
            this.btnguardarcambioscliente.FlatAppearance.BorderSize = 0;
            this.btnguardarcambioscliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnguardarcambioscliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarcambioscliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarcambioscliente.ForeColor = System.Drawing.Color.White;
            this.btnguardarcambioscliente.Location = new System.Drawing.Point(26, 159);
            this.btnguardarcambioscliente.Name = "btnguardarcambioscliente";
            this.btnguardarcambioscliente.Size = new System.Drawing.Size(216, 40);
            this.btnguardarcambioscliente.TabIndex = 38;
            this.btnguardarcambioscliente.Text = "GUARDAR CAMBIOS";
            this.btnguardarcambioscliente.TextColor = System.Drawing.Color.White;
            this.btnguardarcambioscliente.UseVisualStyleBackColor = false;
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.Window;
            this.txtid.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtid.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtid.BorderSize = 2;
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.Color.DimGray;
            this.txtid.Location = new System.Drawing.Point(117, 13);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Multiline = false;
            this.txtid.Name = "txtid";
            this.txtid.Padding = new System.Windows.Forms.Padding(7);
            this.txtid.PasswordChar = false;
            this.txtid.Size = new System.Drawing.Size(76, 31);
            this.txtid.TabIndex = 22;
            this.txtid.Texts = "";
            this.txtid.UnderlinedStyle = false;
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.SystemColors.Window;
            this.lblId.BorderColor = System.Drawing.Color.Lime;
            this.lblId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lblId.BorderSize = 2;
            this.lblId.Enabled = false;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.DimGray;
            this.lblId.Location = new System.Drawing.Point(74, 13);
            this.lblId.Margin = new System.Windows.Forms.Padding(4);
            this.lblId.Multiline = false;
            this.lblId.Name = "lblId";
            this.lblId.Padding = new System.Windows.Forms.Padding(7);
            this.lblId.PasswordChar = false;
            this.lblId.Size = new System.Drawing.Size(35, 31);
            this.lblId.TabIndex = 23;
            this.lblId.Texts = "ID";
            this.lblId.UnderlinedStyle = false;
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtcodigo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtcodigo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtcodigo.BorderSize = 2;
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.ForeColor = System.Drawing.Color.DimGray;
            this.txtcodigo.Location = new System.Drawing.Point(286, 13);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigo.Multiline = false;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Padding = new System.Windows.Forms.Padding(7);
            this.txtcodigo.PasswordChar = false;
            this.txtcodigo.Size = new System.Drawing.Size(134, 31);
            this.txtcodigo.TabIndex = 36;
            this.txtcodigo.Texts = "";
            this.txtcodigo.UnderlinedStyle = false;
            // 
            // lblnombre
            // 
            this.lblnombre.BackColor = System.Drawing.SystemColors.Window;
            this.lblnombre.BorderColor = System.Drawing.Color.Lime;
            this.lblnombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lblnombre.BorderSize = 2;
            this.lblnombre.Enabled = false;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.DimGray;
            this.lblnombre.Location = new System.Drawing.Point(26, 55);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(4);
            this.lblnombre.Multiline = false;
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Padding = new System.Windows.Forms.Padding(7);
            this.lblnombre.PasswordChar = false;
            this.lblnombre.Size = new System.Drawing.Size(93, 31);
            this.lblnombre.TabIndex = 24;
            this.lblnombre.Texts = "NOMBRE";
            this.lblnombre.UnderlinedStyle = false;
            // 
            // lblcodigo
            // 
            this.lblcodigo.BackColor = System.Drawing.SystemColors.Window;
            this.lblcodigo.BorderColor = System.Drawing.Color.Lime;
            this.lblcodigo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lblcodigo.BorderSize = 2;
            this.lblcodigo.Enabled = false;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.ForeColor = System.Drawing.Color.DimGray;
            this.lblcodigo.Location = new System.Drawing.Point(201, 13);
            this.lblcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.lblcodigo.Multiline = false;
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Padding = new System.Windows.Forms.Padding(7);
            this.lblcodigo.PasswordChar = false;
            this.lblcodigo.Size = new System.Drawing.Size(77, 31);
            this.lblcodigo.TabIndex = 35;
            this.lblcodigo.Texts = "CODIGO";
            this.lblcodigo.UnderlinedStyle = false;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtnombre.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtnombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtnombre.BorderSize = 2;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtnombre.Location = new System.Drawing.Point(122, 55);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Padding = new System.Windows.Forms.Padding(7);
            this.txtnombre.PasswordChar = false;
            this.txtnombre.Size = new System.Drawing.Size(604, 31);
            this.txtnombre.TabIndex = 25;
            this.txtnombre.Texts = "";
            this.txtnombre.UnderlinedStyle = false;
            // 
            // lblcuit
            // 
            this.lblcuit.BackColor = System.Drawing.SystemColors.Window;
            this.lblcuit.BorderColor = System.Drawing.Color.Lime;
            this.lblcuit.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lblcuit.BorderSize = 2;
            this.lblcuit.Enabled = false;
            this.lblcuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuit.ForeColor = System.Drawing.Color.DimGray;
            this.lblcuit.Location = new System.Drawing.Point(230, 99);
            this.lblcuit.Margin = new System.Windows.Forms.Padding(4);
            this.lblcuit.Multiline = false;
            this.lblcuit.Name = "lblcuit";
            this.lblcuit.Padding = new System.Windows.Forms.Padding(7);
            this.lblcuit.PasswordChar = false;
            this.lblcuit.Size = new System.Drawing.Size(62, 31);
            this.lblcuit.TabIndex = 32;
            this.lblcuit.Texts = "CUIT";
            this.lblcuit.UnderlinedStyle = false;
            // 
            // txtcuit
            // 
            this.txtcuit.BackColor = System.Drawing.SystemColors.Window;
            this.txtcuit.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtcuit.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtcuit.BorderSize = 2;
            this.txtcuit.Enabled = false;
            this.txtcuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcuit.ForeColor = System.Drawing.Color.DimGray;
            this.txtcuit.Location = new System.Drawing.Point(295, 99);
            this.txtcuit.Margin = new System.Windows.Forms.Padding(4);
            this.txtcuit.Multiline = false;
            this.txtcuit.Name = "txtcuit";
            this.txtcuit.Padding = new System.Windows.Forms.Padding(7);
            this.txtcuit.PasswordChar = false;
            this.txtcuit.Size = new System.Drawing.Size(250, 31);
            this.txtcuit.TabIndex = 33;
            this.txtcuit.Texts = "";
            this.txtcuit.UnderlinedStyle = false;
            // 
            // frmMantCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 240);
            this.Controls.Add(this.panel_Selectcuit);
            this.Controls.Add(this.panel_ppal);
            this.Controls.Add(this.BarraTitulo);
            this.Name = "frmMantCliente";
            this.Text = "frmMantCliente";
            this.Load += new System.EventHandler(this.frmMantCliente_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_ppal.ResumeLayout(false);
            this.panel_ppal.PerformLayout();
            this.panel_Selectcuit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuitpais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label lblaccioncliente;
        private System.Windows.Forms.Button BtnCerrar;
        private CustomControls.RJControls.RJTextBox txtnombre;
        private CustomControls.RJControls.RJTextBox lblnombre;
        private CustomControls.RJControls.RJTextBox lblId;
        private CustomControls.RJControls.RJTextBox txtid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chactivo;
        private CustomControls.RJControls.RJTextBox txtcuit;
        private CustomControls.RJControls.RJTextBox lblcuit;
        private CustomControls.RJControls.RJTextBox txtcodigo;
        private CustomControls.RJControls.RJTextBox lblcodigo;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton rbcuitexterior;
        internal System.Windows.Forms.RadioButton rbcuitinteriorarg;
        private Soporte.Recursos.CustomButtons btnguardarcambioscliente;
        private System.Windows.Forms.Panel panel_ppal;
        private System.Windows.Forms.Panel panel_Selectcuit;
        private System.Windows.Forms.Button btnocultarselectcuit;
        private System.Windows.Forms.DataGridView dgvcuitpais;
        private CustomControls.RJControls.RJTextBox txtbusquedacuit;
        private CustomControls.RJControls.RJTextBox lblbusqueda;
        private System.Windows.Forms.Timer tmExpandirMenu;
        private System.Windows.Forms.Timer tmContraerMenu;
        private CustomControls.RJControls.RJTextBox txtpais;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
    }
}