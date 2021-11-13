
namespace Omnitec.Recursos
{
    partial class UserControl_RackPasilloVertical
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblrackpasillo = new System.Windows.Forms.Label();
            this.lbldisponible = new System.Windows.Forms.Label();
            this.lblutilizado = new System.Windows.Forms.Label();
            this.lblcapacidad = new System.Windows.Forms.Label();
            this.chselect = new System.Windows.Forms.CheckBox();
            this.btndetalle = new FontAwesome.Sharp.IconButton();
            this.ProgressBarackpasillo = new Omnitec.Recursos.ProgressBarVertical();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblrackpasillo
            // 
            this.lblrackpasillo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblrackpasillo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblrackpasillo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblrackpasillo.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrackpasillo.Location = new System.Drawing.Point(4, 0);
            this.lblrackpasillo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrackpasillo.Name = "lblrackpasillo";
            this.lblrackpasillo.Size = new System.Drawing.Size(19, 20);
            this.lblrackpasillo.TabIndex = 165;
            this.lblrackpasillo.Text = "-";
            this.lblrackpasillo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldisponible
            // 
            this.lbldisponible.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldisponible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbldisponible.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldisponible.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisponible.Location = new System.Drawing.Point(4, 91);
            this.lbldisponible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldisponible.Name = "lbldisponible";
            this.lbldisponible.Size = new System.Drawing.Size(20, 15);
            this.lbldisponible.TabIndex = 170;
            this.lbldisponible.Text = "20";
            this.lbldisponible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblutilizado
            // 
            this.lblutilizado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblutilizado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblutilizado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblutilizado.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblutilizado.Location = new System.Drawing.Point(4, 76);
            this.lblutilizado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblutilizado.Name = "lblutilizado";
            this.lblutilizado.Size = new System.Drawing.Size(20, 15);
            this.lblutilizado.TabIndex = 169;
            this.lblutilizado.Text = "20";
            this.lblutilizado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcapacidad
            // 
            this.lblcapacidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcapacidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblcapacidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcapacidad.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapacidad.Location = new System.Drawing.Point(4, 61);
            this.lblcapacidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcapacidad.Name = "lblcapacidad";
            this.lblcapacidad.Size = new System.Drawing.Size(20, 15);
            this.lblcapacidad.TabIndex = 168;
            this.lblcapacidad.Text = "00";
            this.lblcapacidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chselect
            // 
            this.chselect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chselect.AutoSize = true;
            this.chselect.Location = new System.Drawing.Point(3, 135);
            this.chselect.Name = "chselect";
            this.chselect.Size = new System.Drawing.Size(15, 14);
            this.chselect.TabIndex = 172;
            this.chselect.UseVisualStyleBackColor = true;
            // 
            // btndetalle
            // 
            this.btndetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btndetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndetalle.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btndetalle.IconColor = System.Drawing.Color.Black;
            this.btndetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndetalle.IconSize = 15;
            this.btndetalle.Location = new System.Drawing.Point(3, 109);
            this.btndetalle.Name = "btndetalle";
            this.btndetalle.Size = new System.Drawing.Size(20, 20);
            this.btndetalle.TabIndex = 171;
            this.btndetalle.UseVisualStyleBackColor = true;
            // 
            // ProgressBarackpasillo
            // 
            this.ProgressBarackpasillo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProgressBarackpasillo.Location = new System.Drawing.Point(3, 23);
            this.ProgressBarackpasillo.Name = "ProgressBarackpasillo";
            this.ProgressBarackpasillo.Size = new System.Drawing.Size(21, 35);
            this.ProgressBarackpasillo.TabIndex = 166;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.lblrackpasillo);
            this.flowLayoutPanel1.Controls.Add(this.ProgressBarackpasillo);
            this.flowLayoutPanel1.Controls.Add(this.lblcapacidad);
            this.flowLayoutPanel1.Controls.Add(this.lblutilizado);
            this.flowLayoutPanel1.Controls.Add(this.lbldisponible);
            this.flowLayoutPanel1.Controls.Add(this.btndetalle);
            this.flowLayoutPanel1.Controls.Add(this.chselect);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(30, 160);
            this.flowLayoutPanel1.TabIndex = 174;
            // 
            // UserControl_RackPasilloVertical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(40, 160);
            this.MinimumSize = new System.Drawing.Size(30, 160);
            this.Name = "UserControl_RackPasilloVertical";
            this.Size = new System.Drawing.Size(30, 160);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblrackpasillo;
        private ProgressBarVertical ProgressBarackpasillo;
        internal System.Windows.Forms.Label lbldisponible;
        internal System.Windows.Forms.Label lblutilizado;
        internal System.Windows.Forms.Label lblcapacidad;
        private System.Windows.Forms.CheckBox chselect;
        private FontAwesome.Sharp.IconButton btndetalle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
