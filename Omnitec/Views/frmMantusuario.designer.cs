namespace Omnitec.Views
{
    partial class frmMantusuario
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
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lblaccionusuario = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.cmbperfil = new System.Windows.Forms.ComboBox();
            this.cmbdiasexpiraclave = new System.Windows.Forms.ComboBox();
            this.chaccesomovil = new System.Windows.Forms.CheckBox();
            this.chactivo = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtdiasexpiraclave = new CustomControls.RJControls.RJTextBox();
            this.lbldiasexpirapass = new CustomControls.RJControls.RJTextBox();
            this.txtemail = new CustomControls.RJControls.RJTextBox();
            this.lblemail = new CustomControls.RJControls.RJTextBox();
            this.txtperfil = new CustomControls.RJControls.RJTextBox();
            this.lblperfil = new CustomControls.RJControls.RJTextBox();
            this.txtusuario = new CustomControls.RJControls.RJTextBox();
            this.lblusuario = new CustomControls.RJControls.RJTextBox();
            this.txtnombre = new CustomControls.RJControls.RJTextBox();
            this.lblnombre = new CustomControls.RJControls.RJTextBox();
            this.lblId = new CustomControls.RJControls.RJTextBox();
            this.txtid = new CustomControls.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguardarcambiosusuario = new Soporte.Recursos.CustomButtons();
            this.btnrefrescapass = new Soporte.Recursos.CustomButtons();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BarraTitulo.Controls.Add(this.lblaccionusuario);
            this.BarraTitulo.Controls.Add(this.BtnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(577, 38);
            this.BarraTitulo.TabIndex = 2;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // lblaccionusuario
            // 
            this.lblaccionusuario.AutoSize = true;
            this.lblaccionusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaccionusuario.ForeColor = System.Drawing.Color.White;
            this.lblaccionusuario.Location = new System.Drawing.Point(8, 9);
            this.lblaccionusuario.Name = "lblaccionusuario";
            this.lblaccionusuario.Size = new System.Drawing.Size(130, 24);
            this.lblaccionusuario.TabIndex = 15;
            this.lblaccionusuario.Text = "Form Cliente";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::Omnitec.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(539, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(38, 38);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // cmbperfil
            // 
            this.cmbperfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbperfil.FormattingEnabled = true;
            this.cmbperfil.Location = new System.Drawing.Point(0, 194);
            this.cmbperfil.Name = "cmbperfil";
            this.cmbperfil.Size = new System.Drawing.Size(121, 24);
            this.cmbperfil.TabIndex = 16;
            this.cmbperfil.SelectedIndexChanged += new System.EventHandler(this.cmbperfil_SelectedIndexChanged);
            // 
            // cmbdiasexpiraclave
            // 
            this.cmbdiasexpiraclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdiasexpiraclave.FormattingEnabled = true;
            this.cmbdiasexpiraclave.Items.AddRange(new object[] {
            "0",
            "30",
            "60",
            "90"});
            this.cmbdiasexpiraclave.Location = new System.Drawing.Point(190, 193);
            this.cmbdiasexpiraclave.Name = "cmbdiasexpiraclave";
            this.cmbdiasexpiraclave.Size = new System.Drawing.Size(65, 24);
            this.cmbdiasexpiraclave.TabIndex = 29;
            this.cmbdiasexpiraclave.SelectedIndexChanged += new System.EventHandler(this.cmbdiasexpiraclave_SelectedIndexChanged);
            // 
            // chaccesomovil
            // 
            this.chaccesomovil.AutoSize = true;
            this.chaccesomovil.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.chaccesomovil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chaccesomovil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chaccesomovil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chaccesomovil.ForeColor = System.Drawing.Color.DimGray;
            this.chaccesomovil.Location = new System.Drawing.Point(0, 260);
            this.chaccesomovil.Name = "chaccesomovil";
            this.chaccesomovil.Size = new System.Drawing.Size(185, 21);
            this.chaccesomovil.TabIndex = 30;
            this.chaccesomovil.Text = "ACCESO APP MOVIL?";
            this.chaccesomovil.UseVisualStyleBackColor = true;
            // 
            // chactivo
            // 
            this.chactivo.AutoSize = true;
            this.chactivo.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.chactivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chactivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chactivo.ForeColor = System.Drawing.Color.DimGray;
            this.chactivo.Location = new System.Drawing.Point(481, 259);
            this.chactivo.Name = "chactivo";
            this.chactivo.Size = new System.Drawing.Size(83, 21);
            this.chactivo.TabIndex = 31;
            this.chactivo.Text = "ACTIVO";
            this.chactivo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Omnitec.Properties.Resources.icono_cliente;
            this.pictureBox1.Location = new System.Drawing.Point(519, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txtdiasexpiraclave
            // 
            this.txtdiasexpiraclave.BackColor = System.Drawing.SystemColors.Window;
            this.txtdiasexpiraclave.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtdiasexpiraclave.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtdiasexpiraclave.BorderSize = 2;
            this.txtdiasexpiraclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiasexpiraclave.ForeColor = System.Drawing.Color.DimGray;
            this.txtdiasexpiraclave.Location = new System.Drawing.Point(361, 156);
            this.txtdiasexpiraclave.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiasexpiraclave.Multiline = false;
            this.txtdiasexpiraclave.Name = "txtdiasexpiraclave";
            this.txtdiasexpiraclave.Padding = new System.Windows.Forms.Padding(7);
            this.txtdiasexpiraclave.PasswordChar = false;
            this.txtdiasexpiraclave.Size = new System.Drawing.Size(100, 31);
            this.txtdiasexpiraclave.TabIndex = 28;
            this.txtdiasexpiraclave.Texts = "";
            this.txtdiasexpiraclave.UnderlinedStyle = false;
            // 
            // lbldiasexpirapass
            // 
            this.lbldiasexpirapass.BackColor = System.Drawing.SystemColors.Window;
            this.lbldiasexpirapass.BorderColor = System.Drawing.Color.Lime;
            this.lbldiasexpirapass.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lbldiasexpirapass.BorderSize = 2;
            this.lbldiasexpirapass.Enabled = false;
            this.lbldiasexpirapass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiasexpirapass.ForeColor = System.Drawing.Color.DimGray;
            this.lbldiasexpirapass.Location = new System.Drawing.Point(190, 156);
            this.lbldiasexpirapass.Margin = new System.Windows.Forms.Padding(4);
            this.lbldiasexpirapass.Multiline = false;
            this.lbldiasexpirapass.Name = "lbldiasexpirapass";
            this.lbldiasexpirapass.Padding = new System.Windows.Forms.Padding(7);
            this.lbldiasexpirapass.PasswordChar = false;
            this.lbldiasexpirapass.Size = new System.Drawing.Size(163, 31);
            this.lbldiasexpirapass.TabIndex = 27;
            this.lbldiasexpirapass.Texts = "DIAS EXPIRA CLAVE";
            this.lbldiasexpirapass.UnderlinedStyle = false;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.SystemColors.Window;
            this.txtemail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtemail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtemail.BorderSize = 2;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.DimGray;
            this.txtemail.Location = new System.Drawing.Point(96, 221);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Multiline = false;
            this.txtemail.Name = "txtemail";
            this.txtemail.Padding = new System.Windows.Forms.Padding(7);
            this.txtemail.PasswordChar = false;
            this.txtemail.Size = new System.Drawing.Size(468, 31);
            this.txtemail.TabIndex = 26;
            this.txtemail.Texts = "";
            this.txtemail.UnderlinedStyle = false;
            // 
            // lblemail
            // 
            this.lblemail.BackColor = System.Drawing.SystemColors.Window;
            this.lblemail.BorderColor = System.Drawing.Color.Lime;
            this.lblemail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lblemail.BorderSize = 2;
            this.lblemail.Enabled = false;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.DimGray;
            this.lblemail.Location = new System.Drawing.Point(0, 222);
            this.lblemail.Margin = new System.Windows.Forms.Padding(4);
            this.lblemail.Multiline = false;
            this.lblemail.Name = "lblemail";
            this.lblemail.Padding = new System.Windows.Forms.Padding(7);
            this.lblemail.PasswordChar = false;
            this.lblemail.Size = new System.Drawing.Size(93, 31);
            this.lblemail.TabIndex = 25;
            this.lblemail.Texts = "EMAIL";
            this.lblemail.UnderlinedStyle = false;
            // 
            // txtperfil
            // 
            this.txtperfil.BackColor = System.Drawing.SystemColors.Window;
            this.txtperfil.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtperfil.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtperfil.BorderSize = 2;
            this.txtperfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtperfil.ForeColor = System.Drawing.Color.DimGray;
            this.txtperfil.Location = new System.Drawing.Point(96, 156);
            this.txtperfil.Margin = new System.Windows.Forms.Padding(4);
            this.txtperfil.Multiline = false;
            this.txtperfil.Name = "txtperfil";
            this.txtperfil.Padding = new System.Windows.Forms.Padding(7);
            this.txtperfil.PasswordChar = false;
            this.txtperfil.Size = new System.Drawing.Size(86, 31);
            this.txtperfil.TabIndex = 24;
            this.txtperfil.Texts = "";
            this.txtperfil.UnderlinedStyle = false;
            // 
            // lblperfil
            // 
            this.lblperfil.BackColor = System.Drawing.SystemColors.Window;
            this.lblperfil.BorderColor = System.Drawing.Color.Lime;
            this.lblperfil.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lblperfil.BorderSize = 2;
            this.lblperfil.Enabled = false;
            this.lblperfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblperfil.ForeColor = System.Drawing.Color.DimGray;
            this.lblperfil.Location = new System.Drawing.Point(0, 156);
            this.lblperfil.Margin = new System.Windows.Forms.Padding(4);
            this.lblperfil.Multiline = false;
            this.lblperfil.Name = "lblperfil";
            this.lblperfil.Padding = new System.Windows.Forms.Padding(7);
            this.lblperfil.PasswordChar = false;
            this.lblperfil.Size = new System.Drawing.Size(93, 31);
            this.lblperfil.TabIndex = 23;
            this.lblperfil.Texts = "PERFIL";
            this.lblperfil.UnderlinedStyle = false;
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtusuario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtusuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtusuario.BorderSize = 2;
            this.txtusuario.Enabled = false;
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtusuario.Location = new System.Drawing.Point(96, 118);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtusuario.Multiline = false;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Padding = new System.Windows.Forms.Padding(7);
            this.txtusuario.PasswordChar = false;
            this.txtusuario.Size = new System.Drawing.Size(250, 31);
            this.txtusuario.TabIndex = 22;
            this.txtusuario.Texts = "";
            this.txtusuario.UnderlinedStyle = false;
            // 
            // lblusuario
            // 
            this.lblusuario.BackColor = System.Drawing.SystemColors.Window;
            this.lblusuario.BorderColor = System.Drawing.Color.Lime;
            this.lblusuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lblusuario.BorderSize = 2;
            this.lblusuario.Enabled = false;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.DimGray;
            this.lblusuario.Location = new System.Drawing.Point(0, 118);
            this.lblusuario.Margin = new System.Windows.Forms.Padding(4);
            this.lblusuario.Multiline = false;
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Padding = new System.Windows.Forms.Padding(7);
            this.lblusuario.PasswordChar = false;
            this.lblusuario.Size = new System.Drawing.Size(93, 31);
            this.lblusuario.TabIndex = 21;
            this.lblusuario.Texts = "USUARIO";
            this.lblusuario.UnderlinedStyle = false;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtnombre.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtnombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtnombre.BorderSize = 2;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtnombre.Location = new System.Drawing.Point(96, 84);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Padding = new System.Windows.Forms.Padding(7);
            this.txtnombre.PasswordChar = false;
            this.txtnombre.Size = new System.Drawing.Size(383, 31);
            this.txtnombre.TabIndex = 20;
            this.txtnombre.Texts = "";
            this.txtnombre.UnderlinedStyle = false;
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
            this.lblnombre.Location = new System.Drawing.Point(0, 84);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(4);
            this.lblnombre.Multiline = false;
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Padding = new System.Windows.Forms.Padding(7);
            this.lblnombre.PasswordChar = false;
            this.lblnombre.Size = new System.Drawing.Size(93, 31);
            this.lblnombre.TabIndex = 19;
            this.lblnombre.Texts = "NOMBRE";
            this.lblnombre.UnderlinedStyle = false;
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
            this.lblId.Location = new System.Drawing.Point(0, 45);
            this.lblId.Margin = new System.Windows.Forms.Padding(4);
            this.lblId.Multiline = false;
            this.lblId.Name = "lblId";
            this.lblId.Padding = new System.Windows.Forms.Padding(7);
            this.lblId.PasswordChar = false;
            this.lblId.Size = new System.Drawing.Size(35, 31);
            this.lblId.TabIndex = 18;
            this.lblId.Texts = "ID";
            this.lblId.UnderlinedStyle = false;
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
            this.txtid.Location = new System.Drawing.Point(36, 45);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Multiline = false;
            this.txtid.Name = "txtid";
            this.txtid.Padding = new System.Windows.Forms.Padding(7);
            this.txtid.PasswordChar = false;
            this.txtid.Size = new System.Drawing.Size(76, 31);
            this.txtid.TabIndex = 17;
            this.txtid.Texts = "";
            this.txtid.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "valor 0 la clave no expira";
            // 
            // btnguardarcambiosusuario
            // 
            this.btnguardarcambiosusuario.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnguardarcambiosusuario.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnguardarcambiosusuario.BorderColor = System.Drawing.Color.Black;
            this.btnguardarcambiosusuario.BorderColor1 = System.Drawing.Color.Black;
            this.btnguardarcambiosusuario.BorderRadius = 15;
            this.btnguardarcambiosusuario.BorderRadius1 = 15;
            this.btnguardarcambiosusuario.BorderSize = 5;
            this.btnguardarcambiosusuario.BorderSize1 = 5;
            this.btnguardarcambiosusuario.FlatAppearance.BorderSize = 0;
            this.btnguardarcambiosusuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnguardarcambiosusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarcambiosusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarcambiosusuario.ForeColor = System.Drawing.Color.White;
            this.btnguardarcambiosusuario.Location = new System.Drawing.Point(0, 294);
            this.btnguardarcambiosusuario.Name = "btnguardarcambiosusuario";
            this.btnguardarcambiosusuario.Size = new System.Drawing.Size(216, 40);
            this.btnguardarcambiosusuario.TabIndex = 33;
            this.btnguardarcambiosusuario.Text = "GUARDAR CAMBIOS";
            this.btnguardarcambiosusuario.TextColor = System.Drawing.Color.White;
            this.btnguardarcambiosusuario.UseVisualStyleBackColor = false;
            this.btnguardarcambiosusuario.Click += new System.EventHandler(this.btnguardarcambiosusuario_Click);
            // 
            // btnrefrescapass
            // 
            this.btnrefrescapass.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnrefrescapass.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnrefrescapass.BorderColor = System.Drawing.Color.Black;
            this.btnrefrescapass.BorderColor1 = System.Drawing.Color.Black;
            this.btnrefrescapass.BorderRadius = 15;
            this.btnrefrescapass.BorderRadius1 = 15;
            this.btnrefrescapass.BorderSize = 5;
            this.btnrefrescapass.BorderSize1 = 5;
            this.btnrefrescapass.FlatAppearance.BorderSize = 0;
            this.btnrefrescapass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnrefrescapass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefrescapass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefrescapass.ForeColor = System.Drawing.Color.White;
            this.btnrefrescapass.Location = new System.Drawing.Point(323, 294);
            this.btnrefrescapass.Name = "btnrefrescapass";
            this.btnrefrescapass.Size = new System.Drawing.Size(241, 40);
            this.btnrefrescapass.TabIndex = 34;
            this.btnrefrescapass.Text = "REFRESCAR PASSWORD";
            this.btnrefrescapass.TextColor = System.Drawing.Color.White;
            this.btnrefrescapass.UseVisualStyleBackColor = false;
            this.btnrefrescapass.Click += new System.EventHandler(this.btnrefrescapass_Click);
            // 
            // frmMantusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 346);
            this.Controls.Add(this.btnrefrescapass);
            this.Controls.Add(this.btnguardarcambiosusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chactivo);
            this.Controls.Add(this.chaccesomovil);
            this.Controls.Add(this.cmbdiasexpiraclave);
            this.Controls.Add(this.txtdiasexpiraclave);
            this.Controls.Add(this.lbldiasexpirapass);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtperfil);
            this.Controls.Add(this.lblperfil);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.cmbperfil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMantusuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMantCliente";
            this.Load += new System.EventHandler(this.frmMantusuario_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label lblaccionusuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbperfil;
        private CustomControls.RJControls.RJTextBox txtid;
        private CustomControls.RJControls.RJTextBox lblId;
        private CustomControls.RJControls.RJTextBox lblnombre;
        private CustomControls.RJControls.RJTextBox txtnombre;
        private CustomControls.RJControls.RJTextBox lblusuario;
        private CustomControls.RJControls.RJTextBox txtusuario;
        private CustomControls.RJControls.RJTextBox lblperfil;
        private CustomControls.RJControls.RJTextBox txtperfil;
        private CustomControls.RJControls.RJTextBox lblemail;
        private CustomControls.RJControls.RJTextBox txtemail;
        private CustomControls.RJControls.RJTextBox lbldiasexpirapass;
        private CustomControls.RJControls.RJTextBox txtdiasexpiraclave;
        private System.Windows.Forms.ComboBox cmbdiasexpiraclave;
        private System.Windows.Forms.CheckBox chaccesomovil;
        private System.Windows.Forms.CheckBox chactivo;
        private System.Windows.Forms.Label label1;
        private Soporte.Recursos.CustomButtons btnguardarcambiosusuario;
        private Soporte.Recursos.CustomButtons btnrefrescapass;
    }
}