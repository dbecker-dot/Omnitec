
namespace Omnitec.Views
{
    partial class frmodel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmodel));
            this.panelsuperior = new Guna.UI.WinForms.GunaGradientPanel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panelprincipal = new Guna.UI.WinForms.GunaPanel();
            this.panelmenulateralizquierdo = new Guna.UI.WinForms.GunaGradientPanel();
            this.btnMenuizquierdo = new System.Windows.Forms.PictureBox();
            this.panelmenulateralderecho = new Guna.UI.WinForms.GunaGradientPanel();
            this.btnMenuderecho = new System.Windows.Forms.PictureBox();
            this.panelcontenedor = new Guna.UI.WinForms.GunaGradientPanel();
            this.tmExpandirMenuiz = new System.Windows.Forms.Timer(this.components);
            this.tmContraerMenuiz = new System.Windows.Forms.Timer(this.components);
            this.tmExpandirMenuder = new System.Windows.Forms.Timer(this.components);
            this.tmContraerMenuder = new System.Windows.Forms.Timer(this.components);
            this.panelsuperior.SuspendLayout();
            this.panelprincipal.SuspendLayout();
            this.panelmenulateralizquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuizquierdo)).BeginInit();
            this.panelmenulateralderecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuderecho)).BeginInit();
            this.SuspendLayout();
            // 
            // panelsuperior
            // 
            this.panelsuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelsuperior.BackgroundImage")));
            this.panelsuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelsuperior.Controls.Add(this.BtnCerrar);
            this.panelsuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsuperior.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelsuperior.GradientColor2 = System.Drawing.Color.Gray;
            this.panelsuperior.GradientColor3 = System.Drawing.Color.Silver;
            this.panelsuperior.GradientColor4 = System.Drawing.Color.White;
            this.panelsuperior.Location = new System.Drawing.Point(0, 0);
            this.panelsuperior.Name = "panelsuperior";
            this.panelsuperior.Size = new System.Drawing.Size(800, 29);
            this.panelsuperior.TabIndex = 0;
            this.panelsuperior.Text = "gunaGradientPanel1";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::Omnitec.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(762, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(38, 29);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panelprincipal
            // 
            this.panelprincipal.Controls.Add(this.panelcontenedor);
            this.panelprincipal.Controls.Add(this.panelmenulateralderecho);
            this.panelprincipal.Controls.Add(this.panelmenulateralizquierdo);
            this.panelprincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelprincipal.Location = new System.Drawing.Point(0, 29);
            this.panelprincipal.Name = "panelprincipal";
            this.panelprincipal.Size = new System.Drawing.Size(800, 421);
            this.panelprincipal.TabIndex = 1;
            // 
            // panelmenulateralizquierdo
            // 
            this.panelmenulateralizquierdo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelmenulateralizquierdo.BackgroundImage")));
            this.panelmenulateralizquierdo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelmenulateralizquierdo.Controls.Add(this.btnMenuizquierdo);
            this.panelmenulateralizquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenulateralizquierdo.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelmenulateralizquierdo.GradientColor2 = System.Drawing.Color.White;
            this.panelmenulateralizquierdo.GradientColor3 = System.Drawing.Color.White;
            this.panelmenulateralizquierdo.GradientColor4 = System.Drawing.Color.White;
            this.panelmenulateralizquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelmenulateralizquierdo.Name = "panelmenulateralizquierdo";
            this.panelmenulateralizquierdo.Size = new System.Drawing.Size(200, 421);
            this.panelmenulateralizquierdo.TabIndex = 0;
            this.panelmenulateralizquierdo.Text = "gunaGradientPanel1";
            // 
            // btnMenuizquierdo
            // 
            this.btnMenuizquierdo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenuizquierdo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuizquierdo.Image = global::Omnitec.Properties.Resources.menu2;
            this.btnMenuizquierdo.Location = new System.Drawing.Point(157, 0);
            this.btnMenuizquierdo.Name = "btnMenuizquierdo";
            this.btnMenuizquierdo.Size = new System.Drawing.Size(43, 37);
            this.btnMenuizquierdo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMenuizquierdo.TabIndex = 12;
            this.btnMenuizquierdo.TabStop = false;
            this.btnMenuizquierdo.Click += new System.EventHandler(this.btnMenuizquierdo_Click);
            // 
            // panelmenulateralderecho
            // 
            this.panelmenulateralderecho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelmenulateralderecho.BackgroundImage")));
            this.panelmenulateralderecho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelmenulateralderecho.Controls.Add(this.btnMenuderecho);
            this.panelmenulateralderecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelmenulateralderecho.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelmenulateralderecho.GradientColor2 = System.Drawing.Color.White;
            this.panelmenulateralderecho.GradientColor3 = System.Drawing.Color.White;
            this.panelmenulateralderecho.GradientColor4 = System.Drawing.Color.White;
            this.panelmenulateralderecho.Location = new System.Drawing.Point(600, 0);
            this.panelmenulateralderecho.Name = "panelmenulateralderecho";
            this.panelmenulateralderecho.Size = new System.Drawing.Size(200, 421);
            this.panelmenulateralderecho.TabIndex = 1;
            this.panelmenulateralderecho.Text = "gunaGradientPanel1";
            // 
            // btnMenuderecho
            // 
            this.btnMenuderecho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuderecho.Image = global::Omnitec.Properties.Resources.menu2;
            this.btnMenuderecho.Location = new System.Drawing.Point(0, 0);
            this.btnMenuderecho.Name = "btnMenuderecho";
            this.btnMenuderecho.Size = new System.Drawing.Size(43, 37);
            this.btnMenuderecho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMenuderecho.TabIndex = 13;
            this.btnMenuderecho.TabStop = false;
            this.btnMenuderecho.Click += new System.EventHandler(this.btnMenuderecho_Click);
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelcontenedor.BackgroundImage")));
            this.panelcontenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.GradientColor1 = System.Drawing.Color.Silver;
            this.panelcontenedor.GradientColor2 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor3 = System.Drawing.Color.White;
            this.panelcontenedor.GradientColor4 = System.Drawing.Color.White;
            this.panelcontenedor.Location = new System.Drawing.Point(200, 0);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(400, 421);
            this.panelcontenedor.TabIndex = 2;
            this.panelcontenedor.Text = "gunaGradientPanel1";
            // 
            // tmExpandirMenuiz
            // 
            this.tmExpandirMenuiz.Interval = 15;
            this.tmExpandirMenuiz.Tick += new System.EventHandler(this.tmExpandirMenuiz_Tick);
            // 
            // tmContraerMenuiz
            // 
            this.tmContraerMenuiz.Interval = 15;
            this.tmContraerMenuiz.Tick += new System.EventHandler(this.tmContraerMenuiz_Tick);
            // 
            // tmExpandirMenuder
            // 
            this.tmExpandirMenuder.Interval = 15;
            // 
            // tmContraerMenuder
            // 
            this.tmContraerMenuder.Interval = 15;
            // 
            // frmodel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelprincipal);
            this.Controls.Add(this.panelsuperior);
            this.Name = "frmodel";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmodel_Load);
            this.panelsuperior.ResumeLayout(false);
            this.panelprincipal.ResumeLayout(false);
            this.panelmenulateralizquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuizquierdo)).EndInit();
            this.panelmenulateralderecho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuderecho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel panelsuperior;
        private System.Windows.Forms.Button BtnCerrar;
        private Guna.UI.WinForms.GunaPanel panelprincipal;
        private Guna.UI.WinForms.GunaGradientPanel panelmenulateralizquierdo;
        private Guna.UI.WinForms.GunaGradientPanel panelmenulateralderecho;
        private System.Windows.Forms.PictureBox btnMenuderecho;
        private System.Windows.Forms.PictureBox btnMenuizquierdo;
        private Guna.UI.WinForms.GunaGradientPanel panelcontenedor;
        private System.Windows.Forms.Timer tmExpandirMenuiz;
        private System.Windows.Forms.Timer tmContraerMenuiz;
        private System.Windows.Forms.Timer tmExpandirMenuder;
        private System.Windows.Forms.Timer tmContraerMenuder;
    }
}