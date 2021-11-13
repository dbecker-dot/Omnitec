namespace Omnitec.Views
{
    partial class frmusuarioadministradorapp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmusuarioadministradorapp));
            this.label5 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chaccesomovil = new System.Windows.Forms.CheckBox();
            this.txtemail = new CustomControls.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnrefrescapassuseradministrador = new Soporte.Recursos.CustomButtons();
            this.btngenerarusuarioadministradorapp = new Soporte.Recursos.CustomButtons();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(23, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Usuario";
            // 
            // txtusuario
            // 
            this.txtusuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtusuario.Enabled = false;
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(115, 19);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.ReadOnly = true;
            this.txtusuario.Size = new System.Drawing.Size(574, 23);
            this.txtusuario.TabIndex = 19;
            this.txtusuario.Text = "administrador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre:";
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnombre.Enabled = false;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(115, 48);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(574, 23);
            this.txtnombre.TabIndex = 15;
            this.txtnombre.Text = "Administrador App";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chaccesomovil);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnrefrescapassuseradministrador);
            this.groupBox1.Controls.Add(this.btngenerarusuarioadministradorapp);
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(27, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 175);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USUARIO ADMINISTRADOR";
            // 
            // chaccesomovil
            // 
            this.chaccesomovil.AutoSize = true;
            this.chaccesomovil.Location = new System.Drawing.Point(574, 88);
            this.chaccesomovil.Name = "chaccesomovil";
            this.chaccesomovil.Size = new System.Drawing.Size(105, 17);
            this.chaccesomovil.TabIndex = 29;
            this.chaccesomovil.Text = "ACCESO MOVIL";
            this.chaccesomovil.UseVisualStyleBackColor = true;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.SystemColors.Window;
            this.txtemail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtemail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtemail.BorderSize = 2;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.DimGray;
            this.txtemail.Location = new System.Drawing.Point(115, 78);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Multiline = false;
            this.txtemail.Name = "txtemail";
            this.txtemail.Padding = new System.Windows.Forms.Padding(7);
            this.txtemail.PasswordChar = false;
            this.txtemail.Size = new System.Drawing.Size(439, 31);
            this.txtemail.TabIndex = 28;
            this.txtemail.Texts = "";
            this.txtemail.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(23, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Email: ";
            // 
            // btnrefrescapassuseradministrador
            // 
            this.btnrefrescapassuseradministrador.BackColor = System.Drawing.Color.Black;
            this.btnrefrescapassuseradministrador.BackgroundColor = System.Drawing.Color.Black;
            this.btnrefrescapassuseradministrador.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnrefrescapassuseradministrador.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnrefrescapassuseradministrador.BorderRadius = 15;
            this.btnrefrescapassuseradministrador.BorderRadius1 = 15;
            this.btnrefrescapassuseradministrador.BorderSize = 5;
            this.btnrefrescapassuseradministrador.BorderSize1 = 5;
            this.btnrefrescapassuseradministrador.FlatAppearance.BorderSize = 0;
            this.btnrefrescapassuseradministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefrescapassuseradministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefrescapassuseradministrador.ForeColor = System.Drawing.Color.White;
            this.btnrefrescapassuseradministrador.Location = new System.Drawing.Point(399, 125);
            this.btnrefrescapassuseradministrador.Name = "btnrefrescapassuseradministrador";
            this.btnrefrescapassuseradministrador.Size = new System.Drawing.Size(290, 40);
            this.btnrefrescapassuseradministrador.TabIndex = 26;
            this.btnrefrescapassuseradministrador.Text = "REFRESCAR PASSWORD (12345678)";
            this.btnrefrescapassuseradministrador.TextColor = System.Drawing.Color.White;
            this.btnrefrescapassuseradministrador.UseVisualStyleBackColor = false;
            this.btnrefrescapassuseradministrador.Click += new System.EventHandler(this.btnrefrescapassuseradministrador_Click);
            // 
            // btngenerarusuarioadministradorapp
            // 
            this.btngenerarusuarioadministradorapp.BackColor = System.Drawing.Color.Black;
            this.btngenerarusuarioadministradorapp.BackgroundColor = System.Drawing.Color.Black;
            this.btngenerarusuarioadministradorapp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btngenerarusuarioadministradorapp.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btngenerarusuarioadministradorapp.BorderRadius = 15;
            this.btngenerarusuarioadministradorapp.BorderRadius1 = 15;
            this.btngenerarusuarioadministradorapp.BorderSize = 5;
            this.btngenerarusuarioadministradorapp.BorderSize1 = 5;
            this.btngenerarusuarioadministradorapp.FlatAppearance.BorderSize = 0;
            this.btngenerarusuarioadministradorapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerarusuarioadministradorapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerarusuarioadministradorapp.ForeColor = System.Drawing.Color.White;
            this.btngenerarusuarioadministradorapp.Location = new System.Drawing.Point(26, 125);
            this.btngenerarusuarioadministradorapp.Name = "btngenerarusuarioadministradorapp";
            this.btngenerarusuarioadministradorapp.Size = new System.Drawing.Size(292, 40);
            this.btngenerarusuarioadministradorapp.TabIndex = 25;
            this.btngenerarusuarioadministradorapp.Text = "GENERAR USUARIO ADMINISTRADOR";
            this.btngenerarusuarioadministradorapp.TextColor = System.Drawing.Color.White;
            this.btngenerarusuarioadministradorapp.UseVisualStyleBackColor = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::Omnitec.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(0, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(43, 43);
            this.BtnCerrar.TabIndex = 22;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // frmusuarioadministradorapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(870, 237);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmusuarioadministradorapp";
            this.Text = "FormMembresia";
            this.Load += new System.EventHandler(this.frmusuarioadministradorapp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCerrar;
        private Soporte.Recursos.CustomButtons btnrefrescapassuseradministrador;
        private Soporte.Recursos.CustomButtons btngenerarusuarioadministradorapp;
        private System.Windows.Forms.CheckBox chaccesomovil;
        private CustomControls.RJControls.RJTextBox txtemail;
        private System.Windows.Forms.Label label1;
    }
}