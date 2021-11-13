
namespace Omnitec.Views.Reportes
{
    partial class frmstarusdeposito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmstarusdeposito));
            this.panel_Superior = new System.Windows.Forms.Panel();
            this.txttituloform = new CustomControls.RJControls.RJTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.circularProgressBardepositos = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBarrefrig = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBaralero = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBaringrefrig = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBarcrudo = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBarprod = new CircularProgressBar.CircularProgressBar();
            this.panel_Superior.SuspendLayout();
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
            this.panel_Superior.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel_Superior.Name = "panel_Superior";
            this.panel_Superior.Size = new System.Drawing.Size(948, 42);
            this.panel_Superior.TabIndex = 12;
            // 
            // txttituloform
            // 
            this.txttituloform.BackColor = System.Drawing.Color.Lime;
            this.txttituloform.BorderColor = System.Drawing.Color.Black;
            this.txttituloform.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txttituloform.BorderSize = 2;
            this.txttituloform.Enabled = false;
            this.txttituloform.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttituloform.ForeColor = System.Drawing.Color.DimGray;
            this.txttituloform.Location = new System.Drawing.Point(52, 1);
            this.txttituloform.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.txttituloform.Multiline = false;
            this.txttituloform.Name = "txttituloform";
            this.txttituloform.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txttituloform.PasswordChar = false;
            this.txttituloform.Size = new System.Drawing.Size(380, 40);
            this.txttituloform.TabIndex = 24;
            this.txttituloform.Texts = "STATUS DEPOSITOS";
            this.txttituloform.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Omnitec.Properties.Resources.logo_pafsa_20;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 41);
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
            this.BtnCerrar.Location = new System.Drawing.Point(897, -1);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(51, 39);
            this.BtnCerrar.TabIndex = 23;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // circularProgressBardepositos
            // 
            this.circularProgressBardepositos.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CircularEaseInOut;
            this.circularProgressBardepositos.AnimationSpeed = 500;
            this.circularProgressBardepositos.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBardepositos.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.circularProgressBardepositos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBardepositos.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBardepositos.InnerMargin = 2;
            this.circularProgressBardepositos.InnerWidth = -1;
            this.circularProgressBardepositos.Location = new System.Drawing.Point(346, 195);
            this.circularProgressBardepositos.MarqueeAnimationSpeed = 2000;
            this.circularProgressBardepositos.Name = "circularProgressBardepositos";
            this.circularProgressBardepositos.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBardepositos.OuterMargin = -25;
            this.circularProgressBardepositos.OuterWidth = 26;
            this.circularProgressBardepositos.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBardepositos.ProgressWidth = 25;
            this.circularProgressBardepositos.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.circularProgressBardepositos.Size = new System.Drawing.Size(283, 284);
            this.circularProgressBardepositos.StartAngle = 270;
            this.circularProgressBardepositos.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circularProgressBardepositos.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBardepositos.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBardepositos.SubscriptText = "TOTAL";
            this.circularProgressBardepositos.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBardepositos.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBardepositos.SuperscriptText = "%";
            this.circularProgressBardepositos.TabIndex = 19;
            this.circularProgressBardepositos.Text = "0";
            this.circularProgressBardepositos.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBardepositos.Value = 68;
            // 
            // circularProgressBarrefrig
            // 
            this.circularProgressBarrefrig.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarrefrig.AnimationSpeed = 500;
            this.circularProgressBarrefrig.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarrefrig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarrefrig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarrefrig.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarrefrig.InnerMargin = 2;
            this.circularProgressBarrefrig.InnerWidth = -1;
            this.circularProgressBarrefrig.Location = new System.Drawing.Point(683, 348);
            this.circularProgressBarrefrig.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarrefrig.Name = "circularProgressBarrefrig";
            this.circularProgressBarrefrig.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarrefrig.OuterMargin = -25;
            this.circularProgressBarrefrig.OuterWidth = 26;
            this.circularProgressBarrefrig.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarrefrig.ProgressWidth = 25;
            this.circularProgressBarrefrig.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.circularProgressBarrefrig.Size = new System.Drawing.Size(262, 262);
            this.circularProgressBarrefrig.StartAngle = 270;
            this.circularProgressBarrefrig.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBarrefrig.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarrefrig.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarrefrig.SubscriptText = "REFRIGERADO";
            this.circularProgressBarrefrig.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarrefrig.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarrefrig.SuperscriptText = "%";
            this.circularProgressBarrefrig.TabIndex = 3;
            this.circularProgressBarrefrig.Text = "0";
            this.circularProgressBarrefrig.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarrefrig.Value = 68;
            // 
            // circularProgressBaralero
            // 
            this.circularProgressBaralero.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBaralero.AnimationSpeed = 500;
            this.circularProgressBaralero.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBaralero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.circularProgressBaralero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBaralero.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBaralero.InnerMargin = 2;
            this.circularProgressBaralero.InnerWidth = -1;
            this.circularProgressBaralero.Location = new System.Drawing.Point(402, 50);
            this.circularProgressBaralero.MarqueeAnimationSpeed = 2000;
            this.circularProgressBaralero.Name = "circularProgressBaralero";
            this.circularProgressBaralero.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBaralero.OuterMargin = -25;
            this.circularProgressBaralero.OuterWidth = 26;
            this.circularProgressBaralero.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBaralero.ProgressWidth = 25;
            this.circularProgressBaralero.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.circularProgressBaralero.Size = new System.Drawing.Size(123, 121);
            this.circularProgressBaralero.StartAngle = 270;
            this.circularProgressBaralero.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBaralero.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBaralero.SubscriptText = "ALERO";
            this.circularProgressBaralero.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBaralero.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBaralero.SuperscriptText = "%";
            this.circularProgressBaralero.TabIndex = 2;
            this.circularProgressBaralero.Text = "0";
            this.circularProgressBaralero.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBaralero.Value = 68;
            // 
            // circularProgressBaringrefrig
            // 
            this.circularProgressBaringrefrig.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBaringrefrig.AnimationSpeed = 500;
            this.circularProgressBaringrefrig.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBaringrefrig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.circularProgressBaringrefrig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBaringrefrig.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBaringrefrig.InnerMargin = 2;
            this.circularProgressBaringrefrig.InnerWidth = -1;
            this.circularProgressBaringrefrig.Location = new System.Drawing.Point(683, 137);
            this.circularProgressBaringrefrig.MarqueeAnimationSpeed = 2000;
            this.circularProgressBaringrefrig.Name = "circularProgressBaringrefrig";
            this.circularProgressBaringrefrig.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBaringrefrig.OuterMargin = -25;
            this.circularProgressBaringrefrig.OuterWidth = 26;
            this.circularProgressBaringrefrig.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBaringrefrig.ProgressWidth = 25;
            this.circularProgressBaringrefrig.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.circularProgressBaringrefrig.Size = new System.Drawing.Size(185, 188);
            this.circularProgressBaringrefrig.StartAngle = 270;
            this.circularProgressBaringrefrig.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBaringrefrig.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBaringrefrig.SubscriptText = "ING REFRIG";
            this.circularProgressBaringrefrig.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBaringrefrig.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBaringrefrig.SuperscriptText = "%";
            this.circularProgressBaringrefrig.TabIndex = 1;
            this.circularProgressBaringrefrig.Text = "0";
            this.circularProgressBaringrefrig.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBaringrefrig.Value = 68;
            // 
            // circularProgressBarcrudo
            // 
            this.circularProgressBarcrudo.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarcrudo.AnimationSpeed = 500;
            this.circularProgressBarcrudo.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarcrudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarcrudo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarcrudo.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarcrudo.InnerMargin = 2;
            this.circularProgressBarcrudo.InnerWidth = -1;
            this.circularProgressBarcrudo.Location = new System.Drawing.Point(32, 137);
            this.circularProgressBarcrudo.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarcrudo.Name = "circularProgressBarcrudo";
            this.circularProgressBarcrudo.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarcrudo.OuterMargin = -25;
            this.circularProgressBarcrudo.OuterWidth = 26;
            this.circularProgressBarcrudo.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarcrudo.ProgressWidth = 25;
            this.circularProgressBarcrudo.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.circularProgressBarcrudo.Size = new System.Drawing.Size(225, 232);
            this.circularProgressBarcrudo.StartAngle = 270;
            this.circularProgressBarcrudo.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarcrudo.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarcrudo.SubscriptText = "CRUDO";
            this.circularProgressBarcrudo.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarcrudo.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarcrudo.SuperscriptText = "%";
            this.circularProgressBarcrudo.TabIndex = 0;
            this.circularProgressBarcrudo.Text = "0";
            this.circularProgressBarcrudo.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarcrudo.Value = 68;
            // 
            // circularProgressBarprod
            // 
            this.circularProgressBarprod.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarprod.AnimationSpeed = 500;
            this.circularProgressBarprod.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarprod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarprod.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarprod.InnerMargin = 2;
            this.circularProgressBarprod.InnerWidth = -1;
            this.circularProgressBarprod.Location = new System.Drawing.Point(134, 471);
            this.circularProgressBarprod.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarprod.Name = "circularProgressBarprod";
            this.circularProgressBarprod.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarprod.OuterMargin = -25;
            this.circularProgressBarprod.OuterWidth = 26;
            this.circularProgressBarprod.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarprod.ProgressWidth = 25;
            this.circularProgressBarprod.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarprod.Size = new System.Drawing.Size(123, 121);
            this.circularProgressBarprod.StartAngle = 270;
            this.circularProgressBarprod.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarprod.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarprod.SubscriptText = "PRODUCCION";
            this.circularProgressBarprod.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarprod.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarprod.SuperscriptText = "%";
            this.circularProgressBarprod.TabIndex = 202;
            this.circularProgressBarprod.Text = "0";
            this.circularProgressBarprod.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarprod.Value = 68;
            // 
            // frmstarusdeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(948, 642);
            this.Controls.Add(this.circularProgressBarprod);
            this.Controls.Add(this.circularProgressBaralero);
            this.Controls.Add(this.circularProgressBarrefrig);
            this.Controls.Add(this.circularProgressBaringrefrig);
            this.Controls.Add(this.circularProgressBardepositos);
            this.Controls.Add(this.circularProgressBarcrudo);
            this.Controls.Add(this.panel_Superior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmstarusdeposito";
            this.Text = "frmstarusdeposito";
            this.Load += new System.EventHandler(this.frmstarusdeposito_Load);
            this.panel_Superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Superior;
        private CustomControls.RJControls.RJTextBox txttituloform;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCerrar;
        private CircularProgressBar.CircularProgressBar circularProgressBardepositos;
        private CircularProgressBar.CircularProgressBar circularProgressBarcrudo;
        private CircularProgressBar.CircularProgressBar circularProgressBaringrefrig;
        private CircularProgressBar.CircularProgressBar circularProgressBaralero;
        private CircularProgressBar.CircularProgressBar circularProgressBarrefrig;
        private CircularProgressBar.CircularProgressBar circularProgressBarprod;
    }
}