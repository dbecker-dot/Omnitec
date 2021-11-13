
namespace Omnitec.Views
{
    partial class frmmodificapassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmodificapassword));
            this.panel_Superior = new System.Windows.Forms.Panel();
            this.txttituloform = new CustomControls.RJControls.RJTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.txtusuario = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox3 = new CustomControls.RJControls.RJTextBox();
            this.txtnombre = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox5 = new CustomControls.RJControls.RJTextBox();
            this.txtpasswordactual = new CustomControls.RJControls.RJTextBox();
            this.txtpasswordnueva = new CustomControls.RJControls.RJTextBox();
            this.txtrepetirpasswordnueva = new CustomControls.RJControls.RJTextBox();
            this.btnmodificarpassword = new Soporte.Recursos.CustomButtons();
            this.panel_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel_Superior.Size = new System.Drawing.Size(672, 42);
            this.panel_Superior.TabIndex = 4;
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
            this.BtnCerrar.Location = new System.Drawing.Point(629, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(43, 43);
            this.BtnCerrar.TabIndex = 23;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtusuario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtusuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtusuario.BorderSize = 2;
            this.txtusuario.Enabled = false;
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtusuario.Location = new System.Drawing.Point(13, 49);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtusuario.Multiline = false;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Padding = new System.Windows.Forms.Padding(7);
            this.txtusuario.PasswordChar = false;
            this.txtusuario.Size = new System.Drawing.Size(250, 35);
            this.txtusuario.TabIndex = 5;
            this.txtusuario.Texts = "";
            this.txtusuario.UnderlinedStyle = false;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Enabled = false;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox1.Location = new System.Drawing.Point(13, 92);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.Size = new System.Drawing.Size(97, 35);
            this.rjTextBox1.TabIndex = 6;
            this.rjTextBox1.Texts = "NOMBRE";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox2.BorderSize = 2;
            this.rjTextBox2.Enabled = false;
            this.rjTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox2.Location = new System.Drawing.Point(13, 178);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.Size = new System.Drawing.Size(268, 35);
            this.rjTextBox2.TabIndex = 7;
            this.rjTextBox2.Texts = "NUEVA PASSWORD";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // rjTextBox3
            // 
            this.rjTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox3.BorderSize = 2;
            this.rjTextBox3.Enabled = false;
            this.rjTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox3.Location = new System.Drawing.Point(13, 135);
            this.rjTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox3.Multiline = false;
            this.rjTextBox3.Name = "rjTextBox3";
            this.rjTextBox3.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox3.PasswordChar = false;
            this.rjTextBox3.Size = new System.Drawing.Size(268, 35);
            this.rjTextBox3.TabIndex = 8;
            this.rjTextBox3.Texts = "PASSWORD ACTUAL";
            this.rjTextBox3.UnderlinedStyle = false;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtnombre.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtnombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtnombre.BorderSize = 2;
            this.txtnombre.Enabled = false;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtnombre.Location = new System.Drawing.Point(113, 92);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Padding = new System.Windows.Forms.Padding(7);
            this.txtnombre.PasswordChar = false;
            this.txtnombre.Size = new System.Drawing.Size(366, 35);
            this.txtnombre.TabIndex = 9;
            this.txtnombre.Texts = "";
            this.txtnombre.UnderlinedStyle = false;
            // 
            // rjTextBox5
            // 
            this.rjTextBox5.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox5.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox5.BorderSize = 2;
            this.rjTextBox5.Enabled = false;
            this.rjTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox5.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox5.Location = new System.Drawing.Point(13, 221);
            this.rjTextBox5.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox5.Multiline = false;
            this.rjTextBox5.Name = "rjTextBox5";
            this.rjTextBox5.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox5.PasswordChar = false;
            this.rjTextBox5.Size = new System.Drawing.Size(268, 35);
            this.rjTextBox5.TabIndex = 10;
            this.rjTextBox5.Texts = "REPETIR NUEVA PASSWORD";
            this.rjTextBox5.UnderlinedStyle = false;
            // 
            // txtpasswordactual
            // 
            this.txtpasswordactual.BackColor = System.Drawing.SystemColors.Window;
            this.txtpasswordactual.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtpasswordactual.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtpasswordactual.BorderSize = 2;
            this.txtpasswordactual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpasswordactual.ForeColor = System.Drawing.Color.DimGray;
            this.txtpasswordactual.Location = new System.Drawing.Point(289, 135);
            this.txtpasswordactual.Margin = new System.Windows.Forms.Padding(4);
            this.txtpasswordactual.Multiline = false;
            this.txtpasswordactual.Name = "txtpasswordactual";
            this.txtpasswordactual.Padding = new System.Windows.Forms.Padding(7);
            this.txtpasswordactual.PasswordChar = true;
            this.txtpasswordactual.Size = new System.Drawing.Size(366, 35);
            this.txtpasswordactual.TabIndex = 11;
            this.txtpasswordactual.Texts = "";
            this.txtpasswordactual.UnderlinedStyle = false;
            // 
            // txtpasswordnueva
            // 
            this.txtpasswordnueva.BackColor = System.Drawing.SystemColors.Window;
            this.txtpasswordnueva.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtpasswordnueva.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtpasswordnueva.BorderSize = 2;
            this.txtpasswordnueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpasswordnueva.ForeColor = System.Drawing.Color.DimGray;
            this.txtpasswordnueva.Location = new System.Drawing.Point(289, 178);
            this.txtpasswordnueva.Margin = new System.Windows.Forms.Padding(4);
            this.txtpasswordnueva.Multiline = false;
            this.txtpasswordnueva.Name = "txtpasswordnueva";
            this.txtpasswordnueva.Padding = new System.Windows.Forms.Padding(7);
            this.txtpasswordnueva.PasswordChar = true;
            this.txtpasswordnueva.Size = new System.Drawing.Size(366, 35);
            this.txtpasswordnueva.TabIndex = 12;
            this.txtpasswordnueva.Texts = "";
            this.txtpasswordnueva.UnderlinedStyle = false;
            // 
            // txtrepetirpasswordnueva
            // 
            this.txtrepetirpasswordnueva.BackColor = System.Drawing.SystemColors.Window;
            this.txtrepetirpasswordnueva.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtrepetirpasswordnueva.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtrepetirpasswordnueva.BorderSize = 2;
            this.txtrepetirpasswordnueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrepetirpasswordnueva.ForeColor = System.Drawing.Color.DimGray;
            this.txtrepetirpasswordnueva.Location = new System.Drawing.Point(289, 221);
            this.txtrepetirpasswordnueva.Margin = new System.Windows.Forms.Padding(4);
            this.txtrepetirpasswordnueva.Multiline = false;
            this.txtrepetirpasswordnueva.Name = "txtrepetirpasswordnueva";
            this.txtrepetirpasswordnueva.Padding = new System.Windows.Forms.Padding(7);
            this.txtrepetirpasswordnueva.PasswordChar = true;
            this.txtrepetirpasswordnueva.Size = new System.Drawing.Size(366, 35);
            this.txtrepetirpasswordnueva.TabIndex = 13;
            this.txtrepetirpasswordnueva.Texts = "";
            this.txtrepetirpasswordnueva.UnderlinedStyle = false;
            // 
            // btnmodificarpassword
            // 
            this.btnmodificarpassword.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnmodificarpassword.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnmodificarpassword.BorderColor = System.Drawing.Color.Black;
            this.btnmodificarpassword.BorderColor1 = System.Drawing.Color.Black;
            this.btnmodificarpassword.BorderRadius = 15;
            this.btnmodificarpassword.BorderRadius1 = 15;
            this.btnmodificarpassword.BorderSize = 5;
            this.btnmodificarpassword.BorderSize1 = 5;
            this.btnmodificarpassword.FlatAppearance.BorderSize = 0;
            this.btnmodificarpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificarpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificarpassword.ForeColor = System.Drawing.Color.White;
            this.btnmodificarpassword.Location = new System.Drawing.Point(13, 263);
            this.btnmodificarpassword.Name = "btnmodificarpassword";
            this.btnmodificarpassword.Size = new System.Drawing.Size(211, 51);
            this.btnmodificarpassword.TabIndex = 14;
            this.btnmodificarpassword.Text = "GUARDAR CAMBIOS";
            this.btnmodificarpassword.TextColor = System.Drawing.Color.White;
            this.btnmodificarpassword.UseVisualStyleBackColor = false;
            this.btnmodificarpassword.Click += new System.EventHandler(this.btnmodificarpassword_Click);
            // 
            // frmmodificapassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 324);
            this.Controls.Add(this.btnmodificarpassword);
            this.Controls.Add(this.txtrepetirpasswordnueva);
            this.Controls.Add(this.txtpasswordnueva);
            this.Controls.Add(this.txtpasswordactual);
            this.Controls.Add(this.rjTextBox5);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.rjTextBox3);
            this.Controls.Add(this.rjTextBox2);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.panel_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmmodificapassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmmodificapassword";
            this.Load += new System.EventHandler(this.frmmodificapassword_Load);
            this.panel_Superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Superior;
        private CustomControls.RJControls.RJTextBox txttituloform;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCerrar;
        private CustomControls.RJControls.RJTextBox txtusuario;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        private CustomControls.RJControls.RJTextBox rjTextBox3;
        private CustomControls.RJControls.RJTextBox txtnombre;
        private CustomControls.RJControls.RJTextBox rjTextBox5;
        private CustomControls.RJControls.RJTextBox txtpasswordactual;
        private CustomControls.RJControls.RJTextBox txtpasswordnueva;
        private CustomControls.RJControls.RJTextBox txtrepetirpasswordnueva;
        private Soporte.Recursos.CustomButtons btnmodificarpassword;
    }
}