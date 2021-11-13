
namespace Omnitec.Views
{
    partial class frmadmusuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadmusuarios));
            this.panel_Superior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvusuarios = new System.Windows.Forms.DataGridView();
            this.btnagregarusuario = new Soporte.Recursos.CustomButtons();
            this.txtbuscar = new CustomControls.RJControls.RJTextBox();
            this.txttituloform = new CustomControls.RJControls.RJTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panel_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).BeginInit();
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
            this.panel_Superior.Size = new System.Drawing.Size(800, 42);
            this.panel_Superior.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "BUSCAR USUARIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvusuarios
            // 
            this.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuarios.Location = new System.Drawing.Point(12, 91);
            this.dgvusuarios.Name = "dgvusuarios";
            this.dgvusuarios.Size = new System.Drawing.Size(776, 337);
            this.dgvusuarios.TabIndex = 3;
            this.dgvusuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusuarios_CellContentClick);
            // 
            // btnagregarusuario
            // 
            this.btnagregarusuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnagregarusuario.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnagregarusuario.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnagregarusuario.BorderColor = System.Drawing.Color.Black;
            this.btnagregarusuario.BorderColor1 = System.Drawing.Color.Black;
            this.btnagregarusuario.BorderRadius = 25;
            this.btnagregarusuario.BorderRadius1 = 25;
            this.btnagregarusuario.BorderSize = 2;
            this.btnagregarusuario.BorderSize1 = 2;
            this.btnagregarusuario.FlatAppearance.BorderSize = 0;
            this.btnagregarusuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnagregarusuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnagregarusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarusuario.ForeColor = System.Drawing.Color.White;
            this.btnagregarusuario.Location = new System.Drawing.Point(638, 44);
            this.btnagregarusuario.Name = "btnagregarusuario";
            this.btnagregarusuario.Size = new System.Drawing.Size(150, 40);
            this.btnagregarusuario.TabIndex = 4;
            this.btnagregarusuario.Text = "NUEVO";
            this.btnagregarusuario.TextColor = System.Drawing.Color.White;
            this.btnagregarusuario.UseVisualStyleBackColor = false;
            this.btnagregarusuario.Click += new System.EventHandler(this.btnagregarusuario_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.SystemColors.Window;
            this.txtbuscar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbuscar.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbuscar.BorderSize = 2;
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.ForeColor = System.Drawing.Color.DimGray;
            this.txtbuscar.Location = new System.Drawing.Point(214, 53);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtbuscar.Multiline = false;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Padding = new System.Windows.Forms.Padding(7);
            this.txtbuscar.PasswordChar = false;
            this.txtbuscar.Size = new System.Drawing.Size(401, 31);
            this.txtbuscar.TabIndex = 2;
            this.txtbuscar.Texts = "";
            this.txtbuscar.UnderlinedStyle = false;
            this.txtbuscar._TextChanged += new System.EventHandler(this.txtbuscar__TextChanged);
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
            this.BtnCerrar.Location = new System.Drawing.Point(757, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(43, 43);
            this.BtnCerrar.TabIndex = 23;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // frmadmusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnagregarusuario);
            this.Controls.Add(this.dgvusuarios);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Superior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmadmusuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmadmusuarios";
            this.Load += new System.EventHandler(this.frmadmusuarios_Load);
            this.panel_Superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Superior;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCerrar;
        private CustomControls.RJControls.RJTextBox txttituloform;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txtbuscar;
        private System.Windows.Forms.DataGridView dgvusuarios;
        private Soporte.Recursos.CustomButtons btnagregarusuario;
    }
}