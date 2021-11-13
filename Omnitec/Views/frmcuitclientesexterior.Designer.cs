
namespace Omnitec.Views
{
    partial class frmcuitclientesexterior
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lbltituloform = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.txtbusquedacuit = new CustomControls.RJControls.RJTextBox();
            this.lblbusqueda = new CustomControls.RJControls.RJTextBox();
            this.dgvcuitpais = new System.Windows.Forms.DataGridView();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuitpais)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BarraTitulo.Controls.Add(this.lbltituloform);
            this.BarraTitulo.Controls.Add(this.BtnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(426, 38);
            this.BarraTitulo.TabIndex = 4;
            // 
            // lbltituloform
            // 
            this.lbltituloform.AutoSize = true;
            this.lbltituloform.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloform.ForeColor = System.Drawing.Color.White;
            this.lbltituloform.Location = new System.Drawing.Point(8, 9);
            this.lbltituloform.Name = "lbltituloform";
            this.lbltituloform.Size = new System.Drawing.Size(375, 17);
            this.lbltituloform.TabIndex = 15;
            this.lbltituloform.Text = "ADMINISTRACION CUIT CLIENTES DEL EXTERIOR";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::Omnitec.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(388, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(38, 38);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // txtbusquedacuit
            // 
            this.txtbusquedacuit.BackColor = System.Drawing.SystemColors.Window;
            this.txtbusquedacuit.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbusquedacuit.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbusquedacuit.BorderSize = 2;
            this.txtbusquedacuit.Enabled = false;
            this.txtbusquedacuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusquedacuit.ForeColor = System.Drawing.Color.DimGray;
            this.txtbusquedacuit.Location = new System.Drawing.Point(116, 45);
            this.txtbusquedacuit.Margin = new System.Windows.Forms.Padding(4);
            this.txtbusquedacuit.Multiline = false;
            this.txtbusquedacuit.Name = "txtbusquedacuit";
            this.txtbusquedacuit.Padding = new System.Windows.Forms.Padding(7);
            this.txtbusquedacuit.PasswordChar = false;
            this.txtbusquedacuit.Size = new System.Drawing.Size(297, 31);
            this.txtbusquedacuit.TabIndex = 35;
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
            this.lblbusqueda.Location = new System.Drawing.Point(11, 45);
            this.lblbusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.lblbusqueda.Multiline = false;
            this.lblbusqueda.Name = "lblbusqueda";
            this.lblbusqueda.Padding = new System.Windows.Forms.Padding(7);
            this.lblbusqueda.PasswordChar = false;
            this.lblbusqueda.Size = new System.Drawing.Size(97, 31);
            this.lblbusqueda.TabIndex = 34;
            this.lblbusqueda.Texts = "CUIT / PAIS";
            this.lblbusqueda.UnderlinedStyle = false;
            // 
            // dgvcuitpais
            // 
            this.dgvcuitpais.AllowUserToAddRows = false;
            this.dgvcuitpais.AllowUserToDeleteRows = false;
            this.dgvcuitpais.AllowUserToOrderColumns = true;
            this.dgvcuitpais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.dgvcuitpais.Location = new System.Drawing.Point(11, 83);
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
            this.dgvcuitpais.Size = new System.Drawing.Size(403, 238);
            this.dgvcuitpais.TabIndex = 36;
            this.dgvcuitpais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcuitpais_CellContentClick);
            // 
            // frmcuitclientesexterior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 333);
            this.Controls.Add(this.dgvcuitpais);
            this.Controls.Add(this.txtbusquedacuit);
            this.Controls.Add(this.lblbusqueda);
            this.Controls.Add(this.BarraTitulo);
            this.Name = "frmcuitclientesexterior";
            this.Text = "frmcuitclientesexterior";
            this.Load += new System.EventHandler(this.frmcuitclientesexterior_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuitpais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label lbltituloform;
        private System.Windows.Forms.Button BtnCerrar;
        private CustomControls.RJControls.RJTextBox txtbusquedacuit;
        private CustomControls.RJControls.RJTextBox lblbusqueda;
        private System.Windows.Forms.DataGridView dgvcuitpais;
    }
}