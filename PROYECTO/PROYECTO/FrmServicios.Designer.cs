namespace PROYECTO
{
    partial class FrmServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServicios));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtgvFacturas = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleDescription = "c";
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(771, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AccessibleDescription = "c";
            this.btnActualizar.BackColor = System.Drawing.Color.Navy;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(702, 329);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(103, 37);
            this.btnActualizar.TabIndex = 80;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AccessibleDescription = "c";
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(702, 422);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 37);
            this.btnEliminar.TabIndex = 78;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgvFacturas
            // 
            this.dtgvFacturas.AccessibleDescription = "c";
            this.dtgvFacturas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.dtgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFacturas.Location = new System.Drawing.Point(12, 239);
            this.dtgvFacturas.Name = "dtgvFacturas";
            this.dtgvFacturas.Size = new System.Drawing.Size(673, 220);
            this.dtgvFacturas.TabIndex = 77;
            this.dtgvFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvFacturas_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleDescription = "c";
            this.btnGuardar.BackColor = System.Drawing.Color.Navy;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(702, 239);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 37);
            this.btnGuardar.TabIndex = 76;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtValor
            // 
            this.txtValor.AccessibleDescription = "c";
            this.txtValor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(508, 161);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(159, 21);
            this.txtValor.TabIndex = 75;
            // 
            // cbCliente
            // 
            this.cbCliente.AccessibleDescription = "c";
            this.cbCliente.DisplayMember = "Nombre";
            this.cbCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(112, 147);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(159, 24);
            this.cbCliente.TabIndex = 72;
            this.cbCliente.ValueMember = "Nombre";
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.AccessibleDescription = "c";
            this.cbEmpleado.DisplayMember = "Nombre";
            this.cbEmpleado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(112, 107);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(159, 24);
            this.cbEmpleado.TabIndex = 71;
            this.cbEmpleado.ValueMember = "Nombre";
            // 
            // label7
            // 
            this.label7.AccessibleDescription = "c";
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(35, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 70;
            this.label7.Text = "FECHA:";
            // 
            // label6
            // 
            this.label6.AccessibleDescription = "c";
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(410, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 69;
            this.label6.Text = "VALOR:";
            // 
            // label3
            // 
            this.label3.AccessibleDescription = "c";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(410, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "CANTIDAD (kg):";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = "c";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(410, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 67;
            this.label2.Text = "PRODUCTO:";
            // 
            // dateTime
            // 
            this.dateTime.AccessibleDescription = "c";
            this.dateTime.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dateTime.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Location = new System.Drawing.Point(112, 192);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(225, 21);
            this.dateTime.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AccessibleDescription = "c";
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(35, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 65;
            this.label5.Text = "CLIENTE:";
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "c";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(35, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "LO ATENDIÓ:";
            // 
            // txtId
            // 
            this.txtId.AccessibleDescription = "c";
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(112, 69);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(159, 21);
            this.txtId.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AccessibleDescription = "c";
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(35, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 62;
            this.label4.Text = "ID FACTURA:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(527, 465);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(159, 21);
            this.txtTotal.TabIndex = 85;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label8.Location = new System.Drawing.Point(459, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 84;
            this.label8.Text = "TOTAL:";
            // 
            // txtProducto
            // 
            this.txtProducto.AccessibleDescription = "c";
            this.txtProducto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(508, 64);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(159, 21);
            this.txtProducto.TabIndex = 86;
            // 
            // txtCantidad
            // 
            this.txtCantidad.AccessibleDescription = "c";
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(508, 101);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(159, 21);
            this.txtCantidad.TabIndex = 87;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.AccessibleDescription = "c";
            this.txtValorUnitario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorUnitario.Location = new System.Drawing.Point(508, 130);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(159, 21);
            this.txtValorUnitario.TabIndex = 89;
            // 
            // label10
            // 
            this.label10.AccessibleDescription = "c";
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label10.Location = new System.Drawing.Point(410, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 16);
            this.label10.TabIndex = 88;
            this.label10.Text = "VALOR UNITARIO:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.AccessibleDescription = "c";
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(673, 123);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(42, 37);
            this.btnCalcular.TabIndex = 90;
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label9.Location = new System.Drawing.Point(306, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 24);
            this.label9.TabIndex = 91;
            this.label9.Text = "SERVICIOS";
            // 
            // FrmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(817, 532);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dtgvFacturas);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.cbEmpleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmServicios";
            this.Text = "FrmServicos";
            this.Load += new System.EventHandler(this.FrmServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.DataGridView dtgvFacturas;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtProducto;
        public System.Windows.Forms.TextBox txtCantidad;
        public System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label9;
    }
}