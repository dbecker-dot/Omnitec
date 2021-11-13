
namespace Omnitec.Views.Ordenes
{
    partial class frmverorden
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
            this.panel_Superior = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.lblcant = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.lblfecha = new CustomControls.RJControls.RJTextBox();
            this.lblcliente = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox6 = new CustomControls.RJControls.RJTextBox();
            this.lblkgnetos = new CustomControls.RJControls.RJTextBox();
            this.lblstatus = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox8 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox5 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox10 = new CustomControls.RJControls.RJTextBox();
            this.lbllote = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox4 = new CustomControls.RJControls.RJTextBox();
            this.lbltipo = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox3 = new CustomControls.RJControls.RJTextBox();
            this.lblorden = new System.Windows.Forms.Label();
            this.panel_Superior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Superior
            // 
            this.panel_Superior.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_Superior.Controls.Add(this.lblorden);
            this.panel_Superior.Controls.Add(this.label19);
            this.panel_Superior.Controls.Add(this.BtnCerrar);
            this.panel_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Superior.Location = new System.Drawing.Point(0, 0);
            this.panel_Superior.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel_Superior.Name = "panel_Superior";
            this.panel_Superior.Size = new System.Drawing.Size(800, 30);
            this.panel_Superior.TabIndex = 15;
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
            this.label19.TabIndex = 24;
            this.label19.Text = "DATOS ORDEN";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::Omnitec.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(765, 0);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(35, 30);
            this.BtnCerrar.TabIndex = 23;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // lblcant
            // 
            this.lblcant.BackColor = System.Drawing.SystemColors.Window;
            this.lblcant.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.lblcant.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lblcant.BorderSize = 2;
            this.lblcant.Enabled = false;
            this.lblcant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcant.ForeColor = System.Drawing.Color.DimGray;
            this.lblcant.Location = new System.Drawing.Point(576, 117);
            this.lblcant.Margin = new System.Windows.Forms.Padding(4);
            this.lblcant.Multiline = false;
            this.lblcant.Name = "lblcant";
            this.lblcant.Padding = new System.Windows.Forms.Padding(7);
            this.lblcant.PasswordChar = false;
            this.lblcant.Size = new System.Drawing.Size(54, 31);
            this.lblcant.TabIndex = 51;
            this.lblcant.Texts = "";
            this.lblcant.UnderlinedStyle = false;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Enabled = false;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox1.Location = new System.Drawing.Point(13, 39);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.Size = new System.Drawing.Size(63, 31);
            this.rjTextBox1.TabIndex = 38;
            this.rjTextBox1.Texts = "FECHA";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // lblfecha
            // 
            this.lblfecha.BackColor = System.Drawing.SystemColors.Window;
            this.lblfecha.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.lblfecha.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lblfecha.BorderSize = 2;
            this.lblfecha.Enabled = false;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.DimGray;
            this.lblfecha.Location = new System.Drawing.Point(78, 39);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4);
            this.lblfecha.Multiline = false;
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Padding = new System.Windows.Forms.Padding(7);
            this.lblfecha.PasswordChar = false;
            this.lblfecha.Size = new System.Drawing.Size(121, 31);
            this.lblfecha.TabIndex = 39;
            this.lblfecha.Texts = "";
            this.lblfecha.UnderlinedStyle = false;
            // 
            // lblcliente
            // 
            this.lblcliente.BackColor = System.Drawing.SystemColors.Window;
            this.lblcliente.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.lblcliente.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lblcliente.BorderSize = 2;
            this.lblcliente.Enabled = false;
            this.lblcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.ForeColor = System.Drawing.Color.DimGray;
            this.lblcliente.Location = new System.Drawing.Point(96, 78);
            this.lblcliente.Margin = new System.Windows.Forms.Padding(4);
            this.lblcliente.Multiline = false;
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Padding = new System.Windows.Forms.Padding(7);
            this.lblcliente.PasswordChar = false;
            this.lblcliente.Size = new System.Drawing.Size(536, 31);
            this.lblcliente.TabIndex = 46;
            this.lblcliente.Texts = "";
            this.lblcliente.UnderlinedStyle = false;
            // 
            // rjTextBox6
            // 
            this.rjTextBox6.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox6.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox6.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox6.BorderSize = 2;
            this.rjTextBox6.Enabled = false;
            this.rjTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox6.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox6.Location = new System.Drawing.Point(522, 117);
            this.rjTextBox6.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox6.Multiline = false;
            this.rjTextBox6.Name = "rjTextBox6";
            this.rjTextBox6.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox6.PasswordChar = false;
            this.rjTextBox6.Size = new System.Drawing.Size(54, 31);
            this.rjTextBox6.TabIndex = 44;
            this.rjTextBox6.Texts = "CANT";
            this.rjTextBox6.UnderlinedStyle = false;
            // 
            // lblkgnetos
            // 
            this.lblkgnetos.BackColor = System.Drawing.SystemColors.Window;
            this.lblkgnetos.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.lblkgnetos.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lblkgnetos.BorderSize = 2;
            this.lblkgnetos.Enabled = false;
            this.lblkgnetos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkgnetos.ForeColor = System.Drawing.Color.DimGray;
            this.lblkgnetos.Location = new System.Drawing.Point(399, 117);
            this.lblkgnetos.Margin = new System.Windows.Forms.Padding(4);
            this.lblkgnetos.Multiline = false;
            this.lblkgnetos.Name = "lblkgnetos";
            this.lblkgnetos.Padding = new System.Windows.Forms.Padding(7);
            this.lblkgnetos.PasswordChar = false;
            this.lblkgnetos.Size = new System.Drawing.Size(101, 31);
            this.lblkgnetos.TabIndex = 45;
            this.lblkgnetos.Texts = "";
            this.lblkgnetos.UnderlinedStyle = false;
            // 
            // lblstatus
            // 
            this.lblstatus.BackColor = System.Drawing.SystemColors.Window;
            this.lblstatus.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.lblstatus.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lblstatus.BorderSize = 2;
            this.lblstatus.Enabled = false;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.ForeColor = System.Drawing.Color.DimGray;
            this.lblstatus.Location = new System.Drawing.Point(502, 39);
            this.lblstatus.Margin = new System.Windows.Forms.Padding(4);
            this.lblstatus.Multiline = false;
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Padding = new System.Windows.Forms.Padding(7);
            this.lblstatus.PasswordChar = false;
            this.lblstatus.Size = new System.Drawing.Size(130, 31);
            this.lblstatus.TabIndex = 50;
            this.lblstatus.Texts = "";
            this.lblstatus.UnderlinedStyle = false;
            // 
            // rjTextBox8
            // 
            this.rjTextBox8.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox8.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox8.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox8.BorderSize = 2;
            this.rjTextBox8.Enabled = false;
            this.rjTextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox8.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox8.Location = new System.Drawing.Point(207, 39);
            this.rjTextBox8.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox8.Multiline = false;
            this.rjTextBox8.Name = "rjTextBox8";
            this.rjTextBox8.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox8.PasswordChar = false;
            this.rjTextBox8.Size = new System.Drawing.Size(52, 31);
            this.rjTextBox8.TabIndex = 47;
            this.rjTextBox8.Texts = "TIPO";
            this.rjTextBox8.UnderlinedStyle = false;
            // 
            // rjTextBox5
            // 
            this.rjTextBox5.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox5.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox5.BorderSize = 2;
            this.rjTextBox5.Enabled = false;
            this.rjTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox5.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox5.Location = new System.Drawing.Point(310, 117);
            this.rjTextBox5.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox5.Multiline = false;
            this.rjTextBox5.Name = "rjTextBox5";
            this.rjTextBox5.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox5.PasswordChar = false;
            this.rjTextBox5.Size = new System.Drawing.Size(91, 31);
            this.rjTextBox5.TabIndex = 43;
            this.rjTextBox5.Texts = "KG NETOS";
            this.rjTextBox5.UnderlinedStyle = false;
            // 
            // rjTextBox10
            // 
            this.rjTextBox10.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox10.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox10.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox10.BorderSize = 2;
            this.rjTextBox10.Enabled = false;
            this.rjTextBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox10.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox10.Location = new System.Drawing.Point(424, 39);
            this.rjTextBox10.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox10.Multiline = false;
            this.rjTextBox10.Name = "rjTextBox10";
            this.rjTextBox10.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox10.PasswordChar = false;
            this.rjTextBox10.Size = new System.Drawing.Size(76, 31);
            this.rjTextBox10.TabIndex = 49;
            this.rjTextBox10.Texts = "STATUS";
            this.rjTextBox10.UnderlinedStyle = false;
            // 
            // lbllote
            // 
            this.lbllote.BackColor = System.Drawing.SystemColors.Window;
            this.lbllote.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.lbllote.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lbllote.BorderSize = 2;
            this.lbllote.Enabled = false;
            this.lbllote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllote.ForeColor = System.Drawing.Color.DimGray;
            this.lbllote.Location = new System.Drawing.Point(96, 117);
            this.lbllote.Margin = new System.Windows.Forms.Padding(4);
            this.lbllote.Multiline = false;
            this.lbllote.Name = "lbllote";
            this.lbllote.Padding = new System.Windows.Forms.Padding(7);
            this.lbllote.PasswordChar = false;
            this.lbllote.Size = new System.Drawing.Size(213, 31);
            this.lbllote.TabIndex = 41;
            this.lbllote.Texts = "";
            this.lbllote.UnderlinedStyle = false;
            // 
            // rjTextBox4
            // 
            this.rjTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox4.BorderSize = 2;
            this.rjTextBox4.Enabled = false;
            this.rjTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox4.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox4.Location = new System.Drawing.Point(13, 117);
            this.rjTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox4.Multiline = false;
            this.rjTextBox4.Name = "rjTextBox4";
            this.rjTextBox4.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox4.PasswordChar = false;
            this.rjTextBox4.Size = new System.Drawing.Size(85, 31);
            this.rjTextBox4.TabIndex = 42;
            this.rjTextBox4.Texts = "LOTE";
            this.rjTextBox4.UnderlinedStyle = false;
            // 
            // lbltipo
            // 
            this.lbltipo.BackColor = System.Drawing.SystemColors.Window;
            this.lbltipo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.lbltipo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lbltipo.BorderSize = 2;
            this.lbltipo.Enabled = false;
            this.lbltipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.ForeColor = System.Drawing.Color.DimGray;
            this.lbltipo.Location = new System.Drawing.Point(258, 39);
            this.lbltipo.Margin = new System.Windows.Forms.Padding(4);
            this.lbltipo.Multiline = false;
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Padding = new System.Windows.Forms.Padding(7);
            this.lbltipo.PasswordChar = false;
            this.lbltipo.Size = new System.Drawing.Size(160, 31);
            this.lbltipo.TabIndex = 48;
            this.lbltipo.Texts = "";
            this.lbltipo.UnderlinedStyle = false;
            // 
            // rjTextBox3
            // 
            this.rjTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox3.BorderSize = 2;
            this.rjTextBox3.Enabled = false;
            this.rjTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox3.Location = new System.Drawing.Point(13, 78);
            this.rjTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox3.Multiline = false;
            this.rjTextBox3.Name = "rjTextBox3";
            this.rjTextBox3.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox3.PasswordChar = false;
            this.rjTextBox3.Size = new System.Drawing.Size(85, 31);
            this.rjTextBox3.TabIndex = 40;
            this.rjTextBox3.Texts = "CLIENTE";
            this.rjTextBox3.UnderlinedStyle = false;
            // 
            // lblorden
            // 
            this.lblorden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblorden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblorden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorden.Location = new System.Drawing.Point(176, 0);
            this.lblorden.Name = "lblorden";
            this.lblorden.Size = new System.Drawing.Size(530, 30);
            this.lblorden.TabIndex = 25;
            this.lblorden.Text = "DATOS ORDEN";
            this.lblorden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmverorden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 165);
            this.Controls.Add(this.lblcant);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.rjTextBox6);
            this.Controls.Add(this.lblkgnetos);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.rjTextBox8);
            this.Controls.Add(this.rjTextBox5);
            this.Controls.Add(this.rjTextBox10);
            this.Controls.Add(this.lbllote);
            this.Controls.Add(this.rjTextBox4);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.rjTextBox3);
            this.Controls.Add(this.panel_Superior);
            this.Name = "frmverorden";
            this.Text = "frmverorden";
            this.Load += new System.EventHandler(this.frmverorden_Load);
            this.panel_Superior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Superior;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button BtnCerrar;
        private CustomControls.RJControls.RJTextBox lblcant;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private CustomControls.RJControls.RJTextBox lblfecha;
        private CustomControls.RJControls.RJTextBox lblcliente;
        private CustomControls.RJControls.RJTextBox rjTextBox6;
        private CustomControls.RJControls.RJTextBox lblkgnetos;
        private CustomControls.RJControls.RJTextBox lblstatus;
        private CustomControls.RJControls.RJTextBox rjTextBox8;
        private CustomControls.RJControls.RJTextBox rjTextBox5;
        private CustomControls.RJControls.RJTextBox rjTextBox10;
        private CustomControls.RJControls.RJTextBox lbllote;
        private CustomControls.RJControls.RJTextBox rjTextBox4;
        private CustomControls.RJControls.RJTextBox lbltipo;
        private CustomControls.RJControls.RJTextBox rjTextBox3;
        private System.Windows.Forms.Label lblorden;
    }
}