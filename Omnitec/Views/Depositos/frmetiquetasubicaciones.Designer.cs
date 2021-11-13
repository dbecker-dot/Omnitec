
namespace Omnitec.Views.Depositos
{
    partial class frmetiquetasubicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmetiquetasubicaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Superior = new System.Windows.Forms.Panel();
            this.txttituloform = new CustomControls.RJControls.RJTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panel_etubicaciones = new System.Windows.Forms.Panel();
            this.btnvistapreiminar = new Soporte.Recursos.CustomButtons();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnimprimiretiquetas = new Soporte.Recursos.CustomButtons();
            this.lblselectdepet = new CustomControls.RJControls.RJTextBox();
            this.cmbdepoetiquetas = new System.Windows.Forms.ComboBox();
            this.rjTextBox15 = new CustomControls.RJControls.RJTextBox();
            this.dgvetiquetas = new System.Windows.Forms.DataGridView();
            this.imprime = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QR = new System.Windows.Forms.DataGridViewImageColumn();
            this.ptretiquetasubicacion = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.panel_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_etubicaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvetiquetas)).BeginInit();
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
            this.panel_Superior.Size = new System.Drawing.Size(1200, 60);
            this.panel_Superior.TabIndex = 9;
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
            this.txttituloform.Texts = "ETIQUETAS UBICACIONES";
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
            this.BtnCerrar.Location = new System.Drawing.Point(1136, -2);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(64, 66);
            this.BtnCerrar.TabIndex = 23;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panel_etubicaciones
            // 
            this.panel_etubicaciones.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel_etubicaciones.Controls.Add(this.btnvistapreiminar);
            this.panel_etubicaciones.Controls.Add(this.pictureBox7);
            this.panel_etubicaciones.Controls.Add(this.btnimprimiretiquetas);
            this.panel_etubicaciones.Controls.Add(this.lblselectdepet);
            this.panel_etubicaciones.Controls.Add(this.cmbdepoetiquetas);
            this.panel_etubicaciones.Controls.Add(this.rjTextBox15);
            this.panel_etubicaciones.Controls.Add(this.dgvetiquetas);
            this.panel_etubicaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_etubicaciones.Location = new System.Drawing.Point(0, 60);
            this.panel_etubicaciones.Name = "panel_etubicaciones";
            this.panel_etubicaciones.Size = new System.Drawing.Size(1200, 632);
            this.panel_etubicaciones.TabIndex = 37;
            // 
            // btnvistapreiminar
            // 
            this.btnvistapreiminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnvistapreiminar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnvistapreiminar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnvistapreiminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnvistapreiminar.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnvistapreiminar.BorderRadius = 0;
            this.btnvistapreiminar.BorderRadius1 = 0;
            this.btnvistapreiminar.BorderSize = 0;
            this.btnvistapreiminar.BorderSize1 = 0;
            this.btnvistapreiminar.FlatAppearance.BorderSize = 0;
            this.btnvistapreiminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvistapreiminar.ForeColor = System.Drawing.Color.White;
            this.btnvistapreiminar.Image = global::Omnitec.Properties.Resources.print_document;
            this.btnvistapreiminar.Location = new System.Drawing.Point(1112, 4);
            this.btnvistapreiminar.Name = "btnvistapreiminar";
            this.btnvistapreiminar.Size = new System.Drawing.Size(41, 41);
            this.btnvistapreiminar.TabIndex = 33;
            this.btnvistapreiminar.TextColor = System.Drawing.Color.White;
            this.btnvistapreiminar.UseVisualStyleBackColor = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(3, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(47, 42);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            // 
            // btnimprimiretiquetas
            // 
            this.btnimprimiretiquetas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnimprimiretiquetas.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnimprimiretiquetas.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnimprimiretiquetas.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnimprimiretiquetas.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnimprimiretiquetas.BorderRadius = 0;
            this.btnimprimiretiquetas.BorderRadius1 = 0;
            this.btnimprimiretiquetas.BorderSize = 0;
            this.btnimprimiretiquetas.BorderSize1 = 0;
            this.btnimprimiretiquetas.FlatAppearance.BorderSize = 0;
            this.btnimprimiretiquetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimiretiquetas.ForeColor = System.Drawing.Color.White;
            this.btnimprimiretiquetas.Image = global::Omnitec.Properties.Resources.impresora_qr;
            this.btnimprimiretiquetas.Location = new System.Drawing.Point(1159, 5);
            this.btnimprimiretiquetas.Name = "btnimprimiretiquetas";
            this.btnimprimiretiquetas.Size = new System.Drawing.Size(38, 40);
            this.btnimprimiretiquetas.TabIndex = 32;
            this.btnimprimiretiquetas.TextColor = System.Drawing.Color.White;
            this.btnimprimiretiquetas.UseVisualStyleBackColor = false;
            this.btnimprimiretiquetas.Click += new System.EventHandler(this.btnimprimiretiquetas_Click);
            // 
            // lblselectdepet
            // 
            this.lblselectdepet.BackColor = System.Drawing.Color.Lime;
            this.lblselectdepet.BorderColor = System.Drawing.Color.Black;
            this.lblselectdepet.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lblselectdepet.BorderSize = 2;
            this.lblselectdepet.Enabled = false;
            this.lblselectdepet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselectdepet.ForeColor = System.Drawing.Color.DimGray;
            this.lblselectdepet.Location = new System.Drawing.Point(638, 4);
            this.lblselectdepet.Margin = new System.Windows.Forms.Padding(4);
            this.lblselectdepet.Multiline = false;
            this.lblselectdepet.Name = "lblselectdepet";
            this.lblselectdepet.Padding = new System.Windows.Forms.Padding(7);
            this.lblselectdepet.PasswordChar = false;
            this.lblselectdepet.Size = new System.Drawing.Size(241, 31);
            this.lblselectdepet.TabIndex = 29;
            this.lblselectdepet.Texts = "";
            this.lblselectdepet.UnderlinedStyle = false;
            // 
            // cmbdepoetiquetas
            // 
            this.cmbdepoetiquetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdepoetiquetas.FormattingEnabled = true;
            this.cmbdepoetiquetas.Location = new System.Drawing.Point(323, 4);
            this.cmbdepoetiquetas.Name = "cmbdepoetiquetas";
            this.cmbdepoetiquetas.Size = new System.Drawing.Size(308, 32);
            this.cmbdepoetiquetas.TabIndex = 28;
            this.cmbdepoetiquetas.SelectedIndexChanged += new System.EventHandler(this.cmbdepoetiquetas_SelectedIndexChanged);
            // 
            // rjTextBox15
            // 
            this.rjTextBox15.BackColor = System.Drawing.Color.Lime;
            this.rjTextBox15.BorderColor = System.Drawing.Color.Black;
            this.rjTextBox15.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox15.BorderSize = 2;
            this.rjTextBox15.Enabled = false;
            this.rjTextBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox15.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox15.Location = new System.Drawing.Point(57, 4);
            this.rjTextBox15.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox15.Multiline = false;
            this.rjTextBox15.Name = "rjTextBox15";
            this.rjTextBox15.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox15.PasswordChar = false;
            this.rjTextBox15.Size = new System.Drawing.Size(259, 35);
            this.rjTextBox15.TabIndex = 27;
            this.rjTextBox15.Texts = "SELECCIONAR DEPOSITO";
            this.rjTextBox15.UnderlinedStyle = false;
            // 
            // dgvetiquetas
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dgvetiquetas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvetiquetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvetiquetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvetiquetas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.dgvetiquetas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvetiquetas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvetiquetas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvetiquetas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvetiquetas.ColumnHeadersHeight = 30;
            this.dgvetiquetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imprime,
            this.QR});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvetiquetas.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvetiquetas.EnableHeadersVisualStyles = false;
            this.dgvetiquetas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dgvetiquetas.Location = new System.Drawing.Point(3, 51);
            this.dgvetiquetas.Name = "dgvetiquetas";
            this.dgvetiquetas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvetiquetas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvetiquetas.Size = new System.Drawing.Size(1181, 567);
            this.dgvetiquetas.TabIndex = 26;
            // 
            // imprime
            // 
            this.imprime.HeaderText = "Imprimir";
            this.imprime.Name = "imprime";
            this.imprime.Width = 70;
            // 
            // QR
            // 
            this.QR.HeaderText = "QR";
            this.QR.Name = "QR";
            this.QR.Width = 38;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // frmetiquetasubicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel_etubicaciones);
            this.Controls.Add(this.panel_Superior);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmetiquetasubicaciones";
            this.Text = "frmppaldepositos";
            this.Load += new System.EventHandler(this.frmetiquetasubicaciones_Load);
            this.panel_Superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_etubicaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvetiquetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Superior;
        private CustomControls.RJControls.RJTextBox txttituloform;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel panel_etubicaciones;
        private Soporte.Recursos.CustomButtons btnvistapreiminar;
        private System.Windows.Forms.PictureBox pictureBox7;
        private Soporte.Recursos.CustomButtons btnimprimiretiquetas;
        private CustomControls.RJControls.RJTextBox lblselectdepet;
        private System.Windows.Forms.ComboBox cmbdepoetiquetas;
        private CustomControls.RJControls.RJTextBox rjTextBox15;
        private System.Windows.Forms.DataGridView dgvetiquetas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn imprime;
        private System.Windows.Forms.DataGridViewImageColumn QR;
        private System.Drawing.Printing.PrintDocument ptretiquetasubicacion;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}