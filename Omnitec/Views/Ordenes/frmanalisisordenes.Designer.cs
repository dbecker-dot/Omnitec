
namespace Omnitec.Views.Ordenes
{
    partial class frmanalisisordenes
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
            this.panel_Superior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Superior
            // 
            this.panel_Superior.BackColor = System.Drawing.Color.RoyalBlue;
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
            this.label19.Text = "REGISTRAR ANALISIS";
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
            // frmanalisisordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_Superior);
            this.Name = "frmanalisisordenes";
            this.Text = "frmanalisisordenes";
            this.panel_Superior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Superior;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button BtnCerrar;
    }
}