
namespace Omnitec.Views.Depositos
{
    partial class frmubicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmubicaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Superior = new System.Windows.Forms.Panel();
            this.txttituloform = new CustomControls.RJControls.RJTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panel_ubicaciones = new System.Windows.Forms.Panel();
            this.panel_editubicaciones = new System.Windows.Forms.Panel();
            this.numericUpDowncapacidad = new System.Windows.Forms.NumericUpDown();
            this.btneliminareserva = new Soporte.Recursos.CustomButtons();
            this.lblreserva = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox6 = new CustomControls.RJControls.RJTextBox();
            this.cmbcliente = new System.Windows.Forms.ComboBox();
            this.chubicactiva = new System.Windows.Forms.CheckBox();
            this.btnmodificarcapacidad = new Soporte.Recursos.CustomButtons();
            this.rjTextBox5 = new CustomControls.RJControls.RJTextBox();
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            this.lblrackpasilloubic = new CustomControls.RJControls.RJTextBox();
            this.lblubicacion = new CustomControls.RJControls.RJTextBox();
            this.lblbloqueubic = new CustomControls.RJControls.RJTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjTextBox4 = new CustomControls.RJControls.RJTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btncerrareditubicaciones = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnexportaexcelubicaciones = new Soporte.Recursos.CustomButtons();
            this.lbldeposelect = new CustomControls.RJControls.RJTextBox();
            this.cmbdeposito = new System.Windows.Forms.ComboBox();
            this.rjTextBox3 = new CustomControls.RJControls.RJTextBox();
            this.dgvubicaciones = new System.Windows.Forms.DataGridView();
            this.panel_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_ubicaciones.SuspendLayout();
            this.panel_editubicaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowncapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvubicaciones)).BeginInit();
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
            this.panel_Superior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Superior.Name = "panel_Superior";
            this.panel_Superior.Size = new System.Drawing.Size(891, 60);
            this.panel_Superior.TabIndex = 10;
            // 
            // txttituloform
            // 
            this.txttituloform.BackColor = System.Drawing.Color.Lime;
            this.txttituloform.BorderColor = System.Drawing.Color.Black;
            this.txttituloform.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txttituloform.BorderSize = 2;
            this.txttituloform.Enabled = false;
            this.txttituloform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttituloform.ForeColor = System.Drawing.Color.DimGray;
            this.txttituloform.Location = new System.Drawing.Point(81, 11);
            this.txttituloform.Margin = new System.Windows.Forms.Padding(6);
            this.txttituloform.Multiline = false;
            this.txttituloform.Name = "txttituloform";
            this.txttituloform.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.txttituloform.PasswordChar = false;
            this.txttituloform.Size = new System.Drawing.Size(747, 43);
            this.txttituloform.TabIndex = 24;
            this.txttituloform.Texts = "UBICACIONES";
            this.txttituloform.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Omnitec.Properties.Resources.logo_pafsa_20;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 64);
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
            this.BtnCerrar.Location = new System.Drawing.Point(827, -2);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(64, 66);
            this.BtnCerrar.TabIndex = 23;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panel_ubicaciones
            // 
            this.panel_ubicaciones.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel_ubicaciones.Controls.Add(this.panel_editubicaciones);
            this.panel_ubicaciones.Controls.Add(this.pictureBox3);
            this.panel_ubicaciones.Controls.Add(this.btnexportaexcelubicaciones);
            this.panel_ubicaciones.Controls.Add(this.lbldeposelect);
            this.panel_ubicaciones.Controls.Add(this.cmbdeposito);
            this.panel_ubicaciones.Controls.Add(this.rjTextBox3);
            this.panel_ubicaciones.Controls.Add(this.dgvubicaciones);
            this.panel_ubicaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ubicaciones.Location = new System.Drawing.Point(0, 60);
            this.panel_ubicaciones.Name = "panel_ubicaciones";
            this.panel_ubicaciones.Size = new System.Drawing.Size(891, 390);
            this.panel_ubicaciones.TabIndex = 38;
            // 
            // panel_editubicaciones
            // 
            this.panel_editubicaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_editubicaciones.Controls.Add(this.numericUpDowncapacidad);
            this.panel_editubicaciones.Controls.Add(this.btneliminareserva);
            this.panel_editubicaciones.Controls.Add(this.lblreserva);
            this.panel_editubicaciones.Controls.Add(this.rjTextBox6);
            this.panel_editubicaciones.Controls.Add(this.cmbcliente);
            this.panel_editubicaciones.Controls.Add(this.chubicactiva);
            this.panel_editubicaciones.Controls.Add(this.btnmodificarcapacidad);
            this.panel_editubicaciones.Controls.Add(this.rjTextBox5);
            this.panel_editubicaciones.Controls.Add(this.pictureBoxQR);
            this.panel_editubicaciones.Controls.Add(this.lblrackpasilloubic);
            this.panel_editubicaciones.Controls.Add(this.lblubicacion);
            this.panel_editubicaciones.Controls.Add(this.lblbloqueubic);
            this.panel_editubicaciones.Controls.Add(this.panel1);
            this.panel_editubicaciones.Location = new System.Drawing.Point(116, 79);
            this.panel_editubicaciones.Name = "panel_editubicaciones";
            this.panel_editubicaciones.Size = new System.Drawing.Size(616, 274);
            this.panel_editubicaciones.TabIndex = 30;
            this.panel_editubicaciones.Visible = false;
            // 
            // numericUpDowncapacidad
            // 
            this.numericUpDowncapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDowncapacidad.Location = new System.Drawing.Point(355, 90);
            this.numericUpDowncapacidad.Name = "numericUpDowncapacidad";
            this.numericUpDowncapacidad.Size = new System.Drawing.Size(43, 26);
            this.numericUpDowncapacidad.TabIndex = 37;
            // 
            // btneliminareserva
            // 
            this.btneliminareserva.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btneliminareserva.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btneliminareserva.BorderColor = System.Drawing.Color.Lime;
            this.btneliminareserva.BorderColor1 = System.Drawing.Color.Lime;
            this.btneliminareserva.BorderRadius = 15;
            this.btneliminareserva.BorderRadius1 = 15;
            this.btneliminareserva.BorderSize = 5;
            this.btneliminareserva.BorderSize1 = 5;
            this.btneliminareserva.FlatAppearance.BorderSize = 0;
            this.btneliminareserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminareserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminareserva.ForeColor = System.Drawing.Color.White;
            this.btneliminareserva.Location = new System.Drawing.Point(357, 231);
            this.btneliminareserva.Name = "btneliminareserva";
            this.btneliminareserva.Size = new System.Drawing.Size(252, 40);
            this.btneliminareserva.TabIndex = 36;
            this.btneliminareserva.Text = "ANULAR RESERVA";
            this.btneliminareserva.TextColor = System.Drawing.Color.White;
            this.btneliminareserva.UseVisualStyleBackColor = false;
            this.btneliminareserva.Click += new System.EventHandler(this.btneliminareserva_Click);
            // 
            // lblreserva
            // 
            this.lblreserva.BackColor = System.Drawing.SystemColors.Window;
            this.lblreserva.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.lblreserva.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lblreserva.BorderSize = 2;
            this.lblreserva.Enabled = false;
            this.lblreserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreserva.ForeColor = System.Drawing.Color.DimGray;
            this.lblreserva.Location = new System.Drawing.Point(344, 167);
            this.lblreserva.Margin = new System.Windows.Forms.Padding(4);
            this.lblreserva.Multiline = false;
            this.lblreserva.Name = "lblreserva";
            this.lblreserva.Padding = new System.Windows.Forms.Padding(7);
            this.lblreserva.PasswordChar = false;
            this.lblreserva.Size = new System.Drawing.Size(263, 31);
            this.lblreserva.TabIndex = 35;
            this.lblreserva.Texts = "";
            this.lblreserva.UnderlinedStyle = false;
            // 
            // rjTextBox6
            // 
            this.rjTextBox6.BackColor = System.Drawing.Color.Lime;
            this.rjTextBox6.BorderColor = System.Drawing.Color.Black;
            this.rjTextBox6.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox6.BorderSize = 2;
            this.rjTextBox6.Enabled = false;
            this.rjTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox6.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox6.Location = new System.Drawing.Point(255, 167);
            this.rjTextBox6.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox6.Multiline = false;
            this.rjTextBox6.Name = "rjTextBox6";
            this.rjTextBox6.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox6.PasswordChar = false;
            this.rjTextBox6.Size = new System.Drawing.Size(87, 31);
            this.rjTextBox6.TabIndex = 34;
            this.rjTextBox6.Texts = "RESERVA";
            this.rjTextBox6.UnderlinedStyle = false;
            // 
            // cmbcliente
            // 
            this.cmbcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.Location = new System.Drawing.Point(255, 201);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.Size = new System.Drawing.Size(352, 28);
            this.cmbcliente.TabIndex = 33;
            this.cmbcliente.SelectedIndexChanged += new System.EventHandler(this.cmbcliente_SelectedIndexChanged);
            // 
            // chubicactiva
            // 
            this.chubicactiva.AutoSize = true;
            this.chubicactiva.BackColor = System.Drawing.Color.Lime;
            this.chubicactiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chubicactiva.ForeColor = System.Drawing.Color.White;
            this.chubicactiva.Location = new System.Drawing.Point(515, 91);
            this.chubicactiva.Name = "chubicactiva";
            this.chubicactiva.Size = new System.Drawing.Size(92, 24);
            this.chubicactiva.TabIndex = 32;
            this.chubicactiva.Text = "ACTIVA";
            this.chubicactiva.UseVisualStyleBackColor = false;
            // 
            // btnmodificarcapacidad
            // 
            this.btnmodificarcapacidad.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnmodificarcapacidad.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnmodificarcapacidad.BorderColor = System.Drawing.Color.Lime;
            this.btnmodificarcapacidad.BorderColor1 = System.Drawing.Color.Lime;
            this.btnmodificarcapacidad.BorderRadius = 15;
            this.btnmodificarcapacidad.BorderRadius1 = 15;
            this.btnmodificarcapacidad.BorderSize = 5;
            this.btnmodificarcapacidad.BorderSize1 = 5;
            this.btnmodificarcapacidad.FlatAppearance.BorderSize = 0;
            this.btnmodificarcapacidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificarcapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificarcapacidad.ForeColor = System.Drawing.Color.White;
            this.btnmodificarcapacidad.Location = new System.Drawing.Point(253, 120);
            this.btnmodificarcapacidad.Name = "btnmodificarcapacidad";
            this.btnmodificarcapacidad.Size = new System.Drawing.Size(252, 40);
            this.btnmodificarcapacidad.TabIndex = 31;
            this.btnmodificarcapacidad.Text = "MODIFICAR CAPACIDAD";
            this.btnmodificarcapacidad.TextColor = System.Drawing.Color.White;
            this.btnmodificarcapacidad.UseVisualStyleBackColor = false;
            // 
            // rjTextBox5
            // 
            this.rjTextBox5.BackColor = System.Drawing.Color.Lime;
            this.rjTextBox5.BorderColor = System.Drawing.Color.Black;
            this.rjTextBox5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox5.BorderSize = 2;
            this.rjTextBox5.Enabled = false;
            this.rjTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox5.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox5.Location = new System.Drawing.Point(254, 88);
            this.rjTextBox5.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox5.Multiline = false;
            this.rjTextBox5.Name = "rjTextBox5";
            this.rjTextBox5.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox5.PasswordChar = false;
            this.rjTextBox5.Size = new System.Drawing.Size(99, 31);
            this.rjTextBox5.TabIndex = 29;
            this.rjTextBox5.Texts = "CAPACIDAD";
            this.rjTextBox5.UnderlinedStyle = false;
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.Location = new System.Drawing.Point(4, 88);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(243, 183);
            this.pictureBoxQR.TabIndex = 28;
            this.pictureBoxQR.TabStop = false;
            // 
            // lblrackpasilloubic
            // 
            this.lblrackpasilloubic.BackColor = System.Drawing.Color.Lime;
            this.lblrackpasilloubic.BorderColor = System.Drawing.Color.Black;
            this.lblrackpasilloubic.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lblrackpasilloubic.BorderSize = 2;
            this.lblrackpasilloubic.Enabled = false;
            this.lblrackpasilloubic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrackpasilloubic.ForeColor = System.Drawing.Color.DimGray;
            this.lblrackpasilloubic.Location = new System.Drawing.Point(310, 49);
            this.lblrackpasilloubic.Margin = new System.Windows.Forms.Padding(4);
            this.lblrackpasilloubic.Multiline = false;
            this.lblrackpasilloubic.Name = "lblrackpasilloubic";
            this.lblrackpasilloubic.Padding = new System.Windows.Forms.Padding(7);
            this.lblrackpasilloubic.PasswordChar = false;
            this.lblrackpasilloubic.Size = new System.Drawing.Size(49, 31);
            this.lblrackpasilloubic.TabIndex = 27;
            this.lblrackpasilloubic.Texts = "";
            this.lblrackpasilloubic.UnderlinedStyle = false;
            // 
            // lblubicacion
            // 
            this.lblubicacion.BackColor = System.Drawing.Color.Lime;
            this.lblubicacion.BorderColor = System.Drawing.Color.Black;
            this.lblubicacion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lblubicacion.BorderSize = 2;
            this.lblubicacion.Enabled = false;
            this.lblubicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblubicacion.ForeColor = System.Drawing.Color.DimGray;
            this.lblubicacion.Location = new System.Drawing.Point(4, 49);
            this.lblubicacion.Margin = new System.Windows.Forms.Padding(4);
            this.lblubicacion.Multiline = false;
            this.lblubicacion.Name = "lblubicacion";
            this.lblubicacion.Padding = new System.Windows.Forms.Padding(7);
            this.lblubicacion.PasswordChar = false;
            this.lblubicacion.Size = new System.Drawing.Size(243, 31);
            this.lblubicacion.TabIndex = 26;
            this.lblubicacion.Texts = "MODIFICAR UBICACIONES";
            this.lblubicacion.UnderlinedStyle = false;
            // 
            // lblbloqueubic
            // 
            this.lblbloqueubic.BackColor = System.Drawing.Color.Lime;
            this.lblbloqueubic.BorderColor = System.Drawing.Color.Black;
            this.lblbloqueubic.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lblbloqueubic.BorderSize = 2;
            this.lblbloqueubic.Enabled = false;
            this.lblbloqueubic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbloqueubic.ForeColor = System.Drawing.Color.DimGray;
            this.lblbloqueubic.Location = new System.Drawing.Point(255, 49);
            this.lblbloqueubic.Margin = new System.Windows.Forms.Padding(4);
            this.lblbloqueubic.Multiline = false;
            this.lblbloqueubic.Name = "lblbloqueubic";
            this.lblbloqueubic.Padding = new System.Windows.Forms.Padding(7);
            this.lblbloqueubic.PasswordChar = false;
            this.lblbloqueubic.Size = new System.Drawing.Size(50, 31);
            this.lblbloqueubic.TabIndex = 25;
            this.lblbloqueubic.Texts = "";
            this.lblbloqueubic.UnderlinedStyle = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.rjTextBox4);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.btncerrareditubicaciones);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 42);
            this.panel1.TabIndex = 10;
            // 
            // rjTextBox4
            // 
            this.rjTextBox4.BackColor = System.Drawing.Color.Lime;
            this.rjTextBox4.BorderColor = System.Drawing.Color.Black;
            this.rjTextBox4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox4.BorderSize = 2;
            this.rjTextBox4.Enabled = false;
            this.rjTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox4.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox4.Location = new System.Drawing.Point(54, 7);
            this.rjTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox4.Multiline = false;
            this.rjTextBox4.Name = "rjTextBox4";
            this.rjTextBox4.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox4.PasswordChar = false;
            this.rjTextBox4.Size = new System.Drawing.Size(284, 31);
            this.rjTextBox4.TabIndex = 24;
            this.rjTextBox4.Texts = "MODIFICAR UBICACIONES";
            this.rjTextBox4.UnderlinedStyle = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // btncerrareditubicaciones
            // 
            this.btncerrareditubicaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrareditubicaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrareditubicaciones.FlatAppearance.BorderSize = 0;
            this.btncerrareditubicaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrareditubicaciones.Image = global::Omnitec.Properties.Resources.Close;
            this.btncerrareditubicaciones.Location = new System.Drawing.Point(571, -1);
            this.btncerrareditubicaciones.Name = "btncerrareditubicaciones";
            this.btncerrareditubicaciones.Size = new System.Drawing.Size(43, 43);
            this.btncerrareditubicaciones.TabIndex = 23;
            this.btncerrareditubicaciones.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // btnexportaexcelubicaciones
            // 
            this.btnexportaexcelubicaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexportaexcelubicaciones.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnexportaexcelubicaciones.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnexportaexcelubicaciones.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnexportaexcelubicaciones.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnexportaexcelubicaciones.BorderRadius = 0;
            this.btnexportaexcelubicaciones.BorderRadius1 = 0;
            this.btnexportaexcelubicaciones.BorderSize = 0;
            this.btnexportaexcelubicaciones.BorderSize1 = 0;
            this.btnexportaexcelubicaciones.FlatAppearance.BorderSize = 0;
            this.btnexportaexcelubicaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexportaexcelubicaciones.ForeColor = System.Drawing.Color.White;
            this.btnexportaexcelubicaciones.Image = global::Omnitec.Properties.Resources.excel;
            this.btnexportaexcelubicaciones.Location = new System.Drawing.Point(847, 5);
            this.btnexportaexcelubicaciones.Name = "btnexportaexcelubicaciones";
            this.btnexportaexcelubicaciones.Size = new System.Drawing.Size(41, 40);
            this.btnexportaexcelubicaciones.TabIndex = 32;
            this.btnexportaexcelubicaciones.TextColor = System.Drawing.Color.White;
            this.btnexportaexcelubicaciones.UseVisualStyleBackColor = false;
            // 
            // lbldeposelect
            // 
            this.lbldeposelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldeposelect.BackColor = System.Drawing.Color.Lime;
            this.lbldeposelect.BorderColor = System.Drawing.Color.Black;
            this.lbldeposelect.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lbldeposelect.BorderSize = 2;
            this.lbldeposelect.Enabled = false;
            this.lbldeposelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeposelect.ForeColor = System.Drawing.Color.DimGray;
            this.lbldeposelect.Location = new System.Drawing.Point(427, 9);
            this.lbldeposelect.Margin = new System.Windows.Forms.Padding(4);
            this.lbldeposelect.Multiline = false;
            this.lbldeposelect.Name = "lbldeposelect";
            this.lbldeposelect.Padding = new System.Windows.Forms.Padding(7);
            this.lbldeposelect.PasswordChar = false;
            this.lbldeposelect.Size = new System.Drawing.Size(241, 31);
            this.lbldeposelect.TabIndex = 29;
            this.lbldeposelect.Texts = "";
            this.lbldeposelect.UnderlinedStyle = false;
            // 
            // cmbdeposito
            // 
            this.cmbdeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdeposito.FormattingEnabled = true;
            this.cmbdeposito.Location = new System.Drawing.Point(158, 12);
            this.cmbdeposito.Name = "cmbdeposito";
            this.cmbdeposito.Size = new System.Drawing.Size(260, 28);
            this.cmbdeposito.TabIndex = 28;
            this.cmbdeposito.SelectedIndexChanged += new System.EventHandler(this.cmbdeposito_SelectedIndexChanged);
            // 
            // rjTextBox3
            // 
            this.rjTextBox3.BackColor = System.Drawing.Color.Lime;
            this.rjTextBox3.BorderColor = System.Drawing.Color.Black;
            this.rjTextBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox3.BorderSize = 2;
            this.rjTextBox3.Enabled = false;
            this.rjTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox3.Location = new System.Drawing.Point(58, 12);
            this.rjTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox3.Multiline = false;
            this.rjTextBox3.Name = "rjTextBox3";
            this.rjTextBox3.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox3.PasswordChar = false;
            this.rjTextBox3.Size = new System.Drawing.Size(93, 31);
            this.rjTextBox3.TabIndex = 27;
            this.rjTextBox3.Texts = "DEPOSITO";
            this.rjTextBox3.UnderlinedStyle = false;
            // 
            // dgvubicaciones
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvubicaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvubicaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvubicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvubicaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.dgvubicaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvubicaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvubicaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvubicaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvubicaciones.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvubicaciones.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvubicaciones.EnableHeadersVisualStyles = false;
            this.dgvubicaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dgvubicaciones.Location = new System.Drawing.Point(3, 88);
            this.dgvubicaciones.Name = "dgvubicaciones";
            this.dgvubicaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvubicaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvubicaciones.Size = new System.Drawing.Size(872, 288);
            this.dgvubicaciones.TabIndex = 26;
            this.dgvubicaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvubicaciones_CellContentClick);
            // 
            // frmubicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.panel_ubicaciones);
            this.Controls.Add(this.panel_Superior);
            this.Name = "frmubicaciones";
            this.Text = "frmubicaciones";
            this.Load += new System.EventHandler(this.frmubicaciones_Load);
            this.panel_Superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_ubicaciones.ResumeLayout(false);
            this.panel_editubicaciones.ResumeLayout(false);
            this.panel_editubicaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowncapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvubicaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Superior;
        private CustomControls.RJControls.RJTextBox txttituloform;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel panel_ubicaciones;
        private System.Windows.Forms.Panel panel_editubicaciones;
        private System.Windows.Forms.NumericUpDown numericUpDowncapacidad;
        private Soporte.Recursos.CustomButtons btneliminareserva;
        private CustomControls.RJControls.RJTextBox lblreserva;
        private CustomControls.RJControls.RJTextBox rjTextBox6;
        private System.Windows.Forms.ComboBox cmbcliente;
        private System.Windows.Forms.CheckBox chubicactiva;
        private Soporte.Recursos.CustomButtons btnmodificarcapacidad;
        private CustomControls.RJControls.RJTextBox rjTextBox5;
        private System.Windows.Forms.PictureBox pictureBoxQR;
        private CustomControls.RJControls.RJTextBox lblrackpasilloubic;
        private CustomControls.RJControls.RJTextBox lblubicacion;
        private CustomControls.RJControls.RJTextBox lblbloqueubic;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJTextBox rjTextBox4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btncerrareditubicaciones;
        private Soporte.Recursos.CustomButtons btnexportaexcelubicaciones;
        private CustomControls.RJControls.RJTextBox lbldeposelect;
        private System.Windows.Forms.ComboBox cmbdeposito;
        private CustomControls.RJControls.RJTextBox rjTextBox3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dgvubicaciones;
    }
}