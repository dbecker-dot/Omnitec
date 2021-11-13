
namespace Omnitec.Views
{
    partial class frmRepStock
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepStock));
            this.chartstkxcliente = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartstkxgrano = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltotconfiteria = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltotindustria = new System.Windows.Forms.Label();
            this.lbltotblanchado = new System.Windows.Forms.Label();
            this.lbltotrechazoseleccion = new System.Windows.Forms.Label();
            this.panel_Superior = new System.Windows.Forms.Panel();
            this.txttituloform = new CustomControls.RJControls.RJTextBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartstkxcliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartstkxgrano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // chartstkxcliente
            // 
            this.chartstkxcliente.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chartstkxcliente.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartstkxcliente.Legends.Add(legend1);
            this.chartstkxcliente.Location = new System.Drawing.Point(3, 189);
            this.chartstkxcliente.Name = "chartstkxcliente";
            this.chartstkxcliente.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.BorderColor = System.Drawing.Color.Lime;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartstkxcliente.Series.Add(series1);
            this.chartstkxcliente.Size = new System.Drawing.Size(560, 348);
            this.chartstkxcliente.TabIndex = 0;
            this.chartstkxcliente.Text = "chart1";
            // 
            // chartstkxgrano
            // 
            this.chartstkxgrano.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.chartstkxgrano.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartstkxgrano.Legends.Add(legend2);
            this.chartstkxgrano.Location = new System.Drawing.Point(578, 189);
            this.chartstkxgrano.Name = "chartstkxgrano";
            this.chartstkxgrano.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.BackSecondaryColor = System.Drawing.SystemColors.Control;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Color = System.Drawing.SystemColors.Control;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            series2.Name = "Series1";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chartstkxgrano.Series.Add(series2);
            this.chartstkxgrano.Size = new System.Drawing.Size(332, 348);
            this.chartstkxgrano.TabIndex = 1;
            this.chartstkxgrano.Text = "chart2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 67);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Omnitec.Properties.Resources.logo_pafsa_20;
            this.pictureBox2.Location = new System.Drawing.Point(12, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "CONFITERIA";
            // 
            // lbltotconfiteria
            // 
            this.lbltotconfiteria.AutoSize = true;
            this.lbltotconfiteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotconfiteria.Location = new System.Drawing.Point(25, 120);
            this.lbltotconfiteria.Name = "lbltotconfiteria";
            this.lbltotconfiteria.Size = new System.Drawing.Size(25, 25);
            this.lbltotconfiteria.TabIndex = 5;
            this.lbltotconfiteria.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(191, 87);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(145, 67);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(374, 87);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(145, 67);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(550, 87);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(192, 67);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Omnitec.Properties.Resources.logo_pafsa_20;
            this.pictureBox6.Location = new System.Drawing.Point(191, 63);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(55, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Omnitec.Properties.Resources.logo_pafsa_20;
            this.pictureBox7.Location = new System.Drawing.Point(374, 63);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(55, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Omnitec.Properties.Resources.logo_pafsa_20;
            this.pictureBox8.Location = new System.Drawing.Point(550, 63);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(55, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 11;
            this.pictureBox8.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "INDUSTRIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "BLANCHADO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(611, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "RECHAZO SELECCION";
            // 
            // lbltotindustria
            // 
            this.lbltotindustria.AutoSize = true;
            this.lbltotindustria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotindustria.Location = new System.Drawing.Point(204, 120);
            this.lbltotindustria.Name = "lbltotindustria";
            this.lbltotindustria.Size = new System.Drawing.Size(25, 25);
            this.lbltotindustria.TabIndex = 15;
            this.lbltotindustria.Text = "0";
            // 
            // lbltotblanchado
            // 
            this.lbltotblanchado.AutoSize = true;
            this.lbltotblanchado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotblanchado.Location = new System.Drawing.Point(382, 120);
            this.lbltotblanchado.Name = "lbltotblanchado";
            this.lbltotblanchado.Size = new System.Drawing.Size(25, 25);
            this.lbltotblanchado.TabIndex = 16;
            this.lbltotblanchado.Text = "0";
            // 
            // lbltotrechazoseleccion
            // 
            this.lbltotrechazoseleccion.AutoSize = true;
            this.lbltotrechazoseleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotrechazoseleccion.Location = new System.Drawing.Point(558, 120);
            this.lbltotrechazoseleccion.Name = "lbltotrechazoseleccion";
            this.lbltotrechazoseleccion.Size = new System.Drawing.Size(25, 25);
            this.lbltotrechazoseleccion.TabIndex = 17;
            this.lbltotrechazoseleccion.Text = "0";
            // 
            // panel_Superior
            // 
            this.panel_Superior.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_Superior.Controls.Add(this.txttituloform);
            this.panel_Superior.Controls.Add(this.pictureBox9);
            this.panel_Superior.Controls.Add(this.BtnCerrar);
            this.panel_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Superior.Location = new System.Drawing.Point(0, 0);
            this.panel_Superior.Name = "panel_Superior";
            this.panel_Superior.Size = new System.Drawing.Size(922, 42);
            this.panel_Superior.TabIndex = 18;
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
            this.txttituloform.Size = new System.Drawing.Size(163, 31);
            this.txttituloform.TabIndex = 24;
            this.txttituloform.Texts = "REPORTE DE STOCKS";
            this.txttituloform.UnderlinedStyle = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Omnitec.Properties.Resources.logo_pafsa_20;
            this.pictureBox9.Location = new System.Drawing.Point(0, 0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(47, 42);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::Omnitec.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(879, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(43, 43);
            this.BtnCerrar.TabIndex = 23;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // frmRepStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(922, 567);
            this.Controls.Add(this.panel_Superior);
            this.Controls.Add(this.lbltotrechazoseleccion);
            this.Controls.Add(this.lbltotblanchado);
            this.Controls.Add(this.lbltotindustria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbltotconfiteria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chartstkxgrano);
            this.Controls.Add(this.chartstkxcliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRepStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmRepStock";
            this.Load += new System.EventHandler(this.frmRepStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartstkxcliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartstkxgrano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel_Superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartstkxcliente;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartstkxgrano;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltotconfiteria;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltotindustria;
        private System.Windows.Forms.Label lbltotblanchado;
        private System.Windows.Forms.Label lbltotrechazoseleccion;
        private System.Windows.Forms.Panel panel_Superior;
        private CustomControls.RJControls.RJTextBox txttituloform;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button BtnCerrar;
    }
}