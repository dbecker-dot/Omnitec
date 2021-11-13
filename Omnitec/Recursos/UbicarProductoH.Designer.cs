
namespace Omnitec.Recursos
{
    partial class UbicarProductoH
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
            this.btnubicar = new FontAwesome.Sharp.IconButton();
            this.progressBarubic = new System.Windows.Forms.ProgressBar();
            this.panelcontenedor = new System.Windows.Forms.TableLayoutPanel();
            this.panelcontenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblrackpasillo
            // 
            this.lblrackpasillo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblrackpasillo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblrackpasillo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblrackpasillo.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrackpasillo.Location = new System.Drawing.Point(4, 0);
            this.lblrackpasillo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrackpasillo.Name = "lblrackpasillo";
            this.lblrackpasillo.Size = new System.Drawing.Size(21, 25);
            this.lblrackpasillo.TabIndex = 166;
            this.lblrackpasillo.Text = "-";
            this.lblrackpasillo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnubicar
            // 
            this.btnubicar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnubicar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnubicar.IconColor = System.Drawing.Color.Black;
            this.btnubicar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnubicar.IconSize = 15;
            this.btnubicar.Location = new System.Drawing.Point(91, 3);
            this.btnubicar.Name = "btnubicar";
            this.btnubicar.Size = new System.Drawing.Size(24, 19);
            this.btnubicar.TabIndex = 167;
            this.btnubicar.UseVisualStyleBackColor = true;
            this.btnubicar.Click += new System.EventHandler(this.btnubicar_Click);
            // 
            // progressBarubic
            // 
            this.progressBarubic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarubic.Location = new System.Drawing.Point(32, 3);
            this.progressBarubic.Name = "progressBarubic";
            this.progressBarubic.Size = new System.Drawing.Size(53, 19);
            this.progressBarubic.TabIndex = 168;
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelcontenedor.ColumnCount = 3;
            this.panelcontenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelcontenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelcontenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelcontenedor.Controls.Add(this.lblrackpasillo, 0, 0);
            this.panelcontenedor.Controls.Add(this.btnubicar, 2, 0);
            this.panelcontenedor.Controls.Add(this.progressBarubic, 1, 0);
            this.panelcontenedor.Location = new System.Drawing.Point(0, 3);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.RowCount = 1;
            this.panelcontenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelcontenedor.Size = new System.Drawing.Size(118, 25);
            this.panelcontenedor.TabIndex = 169;
            // 
            // UbicarProductoH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelcontenedor);
            this.MaximumSize = new System.Drawing.Size(200, 30);
            this.MinimumSize = new System.Drawing.Size(120, 30);
            this.Name = "UbicarProductoH";
            this.Size = new System.Drawing.Size(120, 30);
            this.panelcontenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblrackpasillo;
        private System.Windows.Forms.ProgressBar progressBarubic;
        private System.Windows.Forms.TableLayoutPanel panelcontenedor;
        public FontAwesome.Sharp.IconButton btnubicar;
    }
}
