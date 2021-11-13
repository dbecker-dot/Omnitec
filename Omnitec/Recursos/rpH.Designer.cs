
namespace Omnitec.Recursos
{
    partial class rpH
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblrackpasillo
            // 
            this.lblrackpasillo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblrackpasillo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblrackpasillo.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrackpasillo.Location = new System.Drawing.Point(0, 0);
            this.lblrackpasillo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrackpasillo.Name = "lblrackpasillo";
            this.lblrackpasillo.Size = new System.Drawing.Size(20, 20);
            this.lblrackpasillo.TabIndex = 167;
            this.lblrackpasillo.Text = "A11";
            this.lblrackpasillo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(40, 20);
            this.progressBar1.TabIndex = 168;
            // 
            // rpH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblrackpasillo);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "rpH";
            this.Size = new System.Drawing.Size(63, 22);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblrackpasillo;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
