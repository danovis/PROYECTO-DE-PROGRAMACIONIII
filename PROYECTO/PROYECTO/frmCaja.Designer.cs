namespace PROYECTO
{
    partial class frmCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaja));
            this.btnActualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgvFacturas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DTFiltro = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.btnPDF = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Navy;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(106, 433);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(111, 51);
            this.btnActualizar.TabIndex = 31;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(477, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 50);
            this.button1.TabIndex = 29;
            this.button1.Text = "ELIMINAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgvFacturas
            // 
            this.dtgvFacturas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.dtgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFacturas.Location = new System.Drawing.Point(12, 190);
            this.dtgvFacturas.Name = "dtgvFacturas";
            this.dtgvFacturas.Size = new System.Drawing.Size(790, 237);
            this.dtgvFacturas.TabIndex = 28;
            this.dtgvFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvFacturas_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(19, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "BUSCAR POR:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(214, 160);
            this.txtFiltro.Multiline = true;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(107, 21);
            this.txtFiltro.TabIndex = 55;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(337, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 57;
            this.label1.Text = "FACTURAS";
            // 
            // DTFiltro
            // 
            this.DTFiltro.Location = new System.Drawing.Point(477, 157);
            this.DTFiltro.Name = "DTFiltro";
            this.DTFiltro.Size = new System.Drawing.Size(213, 20);
            this.DTFiltro.TabIndex = 58;
            this.DTFiltro.ValueChanged += new System.EventHandler(this.DTFiltro_ValueChanged);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleDescription = "c";
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(783, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 32);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 82;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(352, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 83;
            this.label3.Text = "BUSCAR POR FECHA:";
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "ID",
            "CLIENTE",
            "EMPLEADO"});
            this.cbxFiltro.Location = new System.Drawing.Point(106, 160);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(102, 21);
            this.cbxFiltro.TabIndex = 84;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.White;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.Black;
            this.btnPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnPDF.Image")));
            this.btnPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPDF.Location = new System.Drawing.Point(648, 434);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(42, 49);
            this.btnPDF.TabIndex = 85;
            this.btnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // frmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 507);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.cbxFiltro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.DTFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgvFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCaja";
            this.Text = "frmCaja";
            this.Load += new System.EventHandler(this.frmCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dtgvFacturas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTFiltro;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}