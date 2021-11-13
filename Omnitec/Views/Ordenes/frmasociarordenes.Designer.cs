
namespace Omnitec.Views.Ordenes
{
    partial class frmasociarordenes
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
            this.lblote = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.listViewnoasoc = new System.Windows.Forms.ListView();
            this.lotenoasoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantnoasoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kgnoasoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idnoasoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewordasoc = new System.Windows.Forms.ListView();
            this.clote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idordenasoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.lblordennoasoc = new CustomControls.RJControls.RJTextBox();
            this.panel_Superior.SuspendLayout();
            this.panel_contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Superior
            // 
            this.panel_Superior.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_Superior.Controls.Add(this.lblote);
            this.panel_Superior.Controls.Add(this.label19);
            this.panel_Superior.Controls.Add(this.BtnCerrar);
            this.panel_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Superior.Location = new System.Drawing.Point(0, 0);
            this.panel_Superior.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel_Superior.Name = "panel_Superior";
            this.panel_Superior.Size = new System.Drawing.Size(800, 30);
            this.panel_Superior.TabIndex = 13;
            // 
            // lblote
            // 
            this.lblote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblote.Location = new System.Drawing.Point(183, 0);
            this.lblote.Name = "lblote";
            this.lblote.Size = new System.Drawing.Size(420, 30);
            this.lblote.TabIndex = 25;
            this.lblote.Text = "ASOCIAR ORDENES";
            this.lblote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label19.Text = "ASOCIAR ORDENES";
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
            // panel_contenedor
            // 
            this.panel_contenedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_contenedor.Controls.Add(this.listViewnoasoc);
            this.panel_contenedor.Controls.Add(this.listViewordasoc);
            this.panel_contenedor.Controls.Add(this.rjTextBox1);
            this.panel_contenedor.Controls.Add(this.lblordennoasoc);
            this.panel_contenedor.Location = new System.Drawing.Point(0, 38);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(788, 312);
            this.panel_contenedor.TabIndex = 36;
            // 
            // listViewnoasoc
            // 
            this.listViewnoasoc.AllowDrop = true;
            this.listViewnoasoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lotenoasoc,
            this.cantnoasoc,
            this.kgnoasoc,
            this.idnoasoc});
            this.listViewnoasoc.HideSelection = false;
            this.listViewnoasoc.Location = new System.Drawing.Point(4, 56);
            this.listViewnoasoc.Name = "listViewnoasoc";
            this.listViewnoasoc.Size = new System.Drawing.Size(361, 238);
            this.listViewnoasoc.TabIndex = 108;
            this.listViewnoasoc.UseCompatibleStateImageBehavior = false;
            this.listViewnoasoc.View = System.Windows.Forms.View.Details;
            this.listViewnoasoc.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewnoasoc_DragDrop);
            this.listViewnoasoc.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewnoasoc_DragEnter);
            this.listViewnoasoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewnoasoc_MouseDown);
            // 
            // lotenoasoc
            // 
            this.lotenoasoc.Text = "LOTE";
            this.lotenoasoc.Width = 169;
            // 
            // cantnoasoc
            // 
            this.cantnoasoc.Text = "CANT";
            this.cantnoasoc.Width = 145;
            // 
            // kgnoasoc
            // 
            this.kgnoasoc.Text = "KG";
            // 
            // idnoasoc
            // 
            this.idnoasoc.Text = "ID";
            // 
            // listViewordasoc
            // 
            this.listViewordasoc.AllowDrop = true;
            this.listViewordasoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clote,
            this.ctipo,
            this.idordenasoc});
            this.listViewordasoc.HideSelection = false;
            this.listViewordasoc.Location = new System.Drawing.Point(385, 56);
            this.listViewordasoc.Name = "listViewordasoc";
            this.listViewordasoc.Size = new System.Drawing.Size(361, 238);
            this.listViewordasoc.TabIndex = 107;
            this.listViewordasoc.UseCompatibleStateImageBehavior = false;
            this.listViewordasoc.View = System.Windows.Forms.View.Details;
            this.listViewordasoc.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewordasoc_DragDrop);
            this.listViewordasoc.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewordasoc_DragEnter);
            this.listViewordasoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewordasoc_MouseDown);
            // 
            // clote
            // 
            this.clote.Text = "LOTE";
            this.clote.Width = 169;
            // 
            // ctipo
            // 
            this.ctipo.Text = "TIPO";
            this.ctipo.Width = 145;
            // 
            // idordenasoc
            // 
            this.idordenasoc.Text = "ID";
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Enabled = false;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox1.Location = new System.Drawing.Point(385, 18);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.Size = new System.Drawing.Size(361, 31);
            this.rjTextBox1.TabIndex = 106;
            this.rjTextBox1.Texts = "ORDENES ASOCIADAS";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // lblordennoasoc
            // 
            this.lblordennoasoc.BackColor = System.Drawing.SystemColors.Window;
            this.lblordennoasoc.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.lblordennoasoc.BorderFocusColor = System.Drawing.Color.HotPink;
            this.lblordennoasoc.BorderSize = 2;
            this.lblordennoasoc.Enabled = false;
            this.lblordennoasoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblordennoasoc.ForeColor = System.Drawing.Color.DimGray;
            this.lblordennoasoc.Location = new System.Drawing.Point(4, 18);
            this.lblordennoasoc.Margin = new System.Windows.Forms.Padding(4);
            this.lblordennoasoc.Multiline = false;
            this.lblordennoasoc.Name = "lblordennoasoc";
            this.lblordennoasoc.Padding = new System.Windows.Forms.Padding(7);
            this.lblordennoasoc.PasswordChar = false;
            this.lblordennoasoc.Size = new System.Drawing.Size(361, 31);
            this.lblordennoasoc.TabIndex = 105;
            this.lblordennoasoc.Texts = "ORDENES NO ASOCIADAS";
            this.lblordennoasoc.UnderlinedStyle = false;
            // 
            // frmasociarordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.panel_Superior);
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.Name = "frmasociarordenes";
            this.Text = "frmasociarordenes";
            this.Load += new System.EventHandler(this.frmasociarordenes_Load);
            this.panel_Superior.ResumeLayout(false);
            this.panel_contenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Superior;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel panel_contenedor;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private CustomControls.RJControls.RJTextBox lblordennoasoc;
        private System.Windows.Forms.ListView listViewordasoc;
        private System.Windows.Forms.ColumnHeader clote;
        private System.Windows.Forms.ColumnHeader ctipo;
        private System.Windows.Forms.ColumnHeader idordenasoc;
        private System.Windows.Forms.ListView listViewnoasoc;
        private System.Windows.Forms.ColumnHeader lotenoasoc;
        private System.Windows.Forms.ColumnHeader cantnoasoc;
        private System.Windows.Forms.ColumnHeader kgnoasoc;
        private System.Windows.Forms.ColumnHeader idnoasoc;
        public System.Windows.Forms.Label lblote;
    }
}