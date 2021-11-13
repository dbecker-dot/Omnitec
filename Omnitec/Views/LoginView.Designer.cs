
namespace Omnitec.Views
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.txtuser = new System.Windows.Forms.TextBox();
            this.panel_lateralogo = new System.Windows.Forms.Panel();
            this.lblversion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.piclogoomnitec = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.btnacceder = new Soporte.Recursos.CustomButtons();
            this.panel_lateralogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogoomnitec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.White;
            this.txtuser.Location = new System.Drawing.Point(311, 74);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(363, 13);
            this.txtuser.TabIndex = 1;
            this.txtuser.Text = "Usuario";
            this.txtuser.Enter += new System.EventHandler(this.txtuser_Enter);
            this.txtuser.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // panel_lateralogo
            // 
            this.panel_lateralogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel_lateralogo.Controls.Add(this.lblversion);
            this.panel_lateralogo.Controls.Add(this.label2);
            this.panel_lateralogo.Controls.Add(this.piclogoomnitec);
            this.panel_lateralogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_lateralogo.Location = new System.Drawing.Point(0, 0);
            this.panel_lateralogo.Name = "panel_lateralogo";
            this.panel_lateralogo.Size = new System.Drawing.Size(284, 225);
            this.panel_lateralogo.TabIndex = 2;
            this.panel_lateralogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_lateralogo_MouseDown);
            // 
            // lblversion
            // 
            this.lblversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblversion.ForeColor = System.Drawing.Color.White;
            this.lblversion.Location = new System.Drawing.Point(28, 178);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(228, 23);
            this.lblversion.TabIndex = 6;
            this.lblversion.Text = "GESTION DE DEPOSITOS";
            this.lblversion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "GESTION DE DEPOSITOS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // piclogoomnitec
            // 
            this.piclogoomnitec.Image = global::Omnitec.Properties.Resources.logo;
            this.piclogoomnitec.Location = new System.Drawing.Point(31, 29);
            this.piclogoomnitec.Name = "piclogoomnitec";
            this.piclogoomnitec.Size = new System.Drawing.Size(225, 101);
            this.piclogoomnitec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogoomnitec.TabIndex = 0;
            this.piclogoomnitec.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(311, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 1);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(311, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.White;
            this.txtpass.Location = new System.Drawing.Point(311, 106);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(363, 13);
            this.txtpass.TabIndex = 2;
            this.txtpass.Text = "Contraseña";
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(311, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 1);
            this.panel2.TabIndex = 6;
            // 
            // btncerrar
            // 
            this.btncerrar.Image = global::Omnitec.Properties.Resources.Close;
            this.btncerrar.Location = new System.Drawing.Point(665, 12);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(29, 25);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btncerrar.TabIndex = 7;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // lblerror
            // 
            this.lblerror.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.White;
            this.lblerror.Location = new System.Drawing.Point(311, 139);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(363, 23);
            this.lblerror.TabIndex = 8;
            this.lblerror.Text = "mensage de error";
            this.lblerror.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblerror.Visible = false;
            // 
            // btnacceder
            // 
            this.btnacceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnacceder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnacceder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnacceder.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnacceder.BorderRadius = 15;
            this.btnacceder.BorderRadius1 = 15;
            this.btnacceder.BorderSize = 5;
            this.btnacceder.BorderSize1 = 5;
            this.btnacceder.FlatAppearance.BorderSize = 0;
            this.btnacceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnacceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnacceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnacceder.ForeColor = System.Drawing.Color.White;
            this.btnacceder.Location = new System.Drawing.Point(314, 167);
            this.btnacceder.Name = "btnacceder";
            this.btnacceder.Size = new System.Drawing.Size(360, 40);
            this.btnacceder.TabIndex = 9;
            this.btnacceder.Text = "ACCEDER";
            this.btnacceder.TextColor = System.Drawing.Color.White;
            this.btnacceder.UseVisualStyleBackColor = false;
            this.btnacceder.Click += new System.EventHandler(this.btnacceder_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(706, 225);
            this.Controls.Add(this.btnacceder);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_lateralogo);
            this.Controls.Add(this.txtuser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginView";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.LoginView_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginView_MouseDown);
            this.panel_lateralogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piclogoomnitec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Panel panel_lateralogo;
        private System.Windows.Forms.PictureBox piclogoomnitec;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblversion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Label lblerror;
        private Soporte.Recursos.CustomButtons btnacceder;
    }
}