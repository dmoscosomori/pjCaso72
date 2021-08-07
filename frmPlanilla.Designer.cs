
namespace pjCaso72
{
    partial class frmPlanilla
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.dtFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAños = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.lblGratificacion = new System.Windows.Forms.Label();
            this.lblBasico = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCooperativa = new System.Windows.Forms.Label();
            this.lblAFP = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblTotalIngresos = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTotalDescuentos = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblTotalAportaciones = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLANILLA DE PAGOS DE EMPLEADOS";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.Location = new System.Drawing.Point(27, 164);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(111, 38);
            this.btnProcesar.TabIndex = 1;
            this.btnProcesar.Text = "PROCESAR";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(147, 365);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 31);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(27, 365);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 31);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFechaActual);
            this.groupBox1.Controls.Add(this.txtAños);
            this.groupBox1.Controls.Add(this.txtMes);
            this.groupBox1.Controls.Add(this.dtFechaIngreso);
            this.groupBox1.Controls.Add(this.cboCargo);
            this.groupBox1.Controls.Add(this.txtEmpleado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 115);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMACION GENERAL DEL EMPLEADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "EMPLEADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "CARGO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "FECHA DE INGRESO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "MES CONSULTADO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(570, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "AÑOS DE SERVICIO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(570, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "FECHA DE CONSULTA";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(12, 37);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(366, 20);
            this.txtEmpleado.TabIndex = 6;
            // 
            // cboCargo
            // 
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Items.AddRange(new object[] {
            "Coordinador",
            "Jefe",
            "Capacitador",
            "Asistente"});
            this.cboCargo.Location = new System.Drawing.Point(12, 84);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(273, 21);
            this.cboCargo.TabIndex = 7;
            // 
            // dtFechaIngreso
            // 
            this.dtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIngreso.Location = new System.Drawing.Point(395, 37);
            this.dtFechaIngreso.Name = "dtFechaIngreso";
            this.dtFechaIngreso.Size = new System.Drawing.Size(135, 20);
            this.dtFechaIngreso.TabIndex = 8;
            this.dtFechaIngreso.ValueChanged += new System.EventHandler(this.dtFechaIngreso_ValueChanged);
            // 
            // txtMes
            // 
            this.txtMes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMes.Location = new System.Drawing.Point(395, 85);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(140, 20);
            this.txtMes.TabIndex = 10;
            // 
            // txtAños
            // 
            this.txtAños.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAños.Location = new System.Drawing.Point(573, 85);
            this.txtAños.Name = "txtAños";
            this.txtAños.Size = new System.Drawing.Size(140, 20);
            this.txtAños.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblComision);
            this.groupBox2.Controls.Add(this.lblGratificacion);
            this.groupBox2.Controls.Add(this.lblBasico);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(27, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 106);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INGRESOS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "SUELDO BÁSICO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "GRATIFICACION";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "COMISION";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComision.Location = new System.Drawing.Point(111, 77);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(70, 13);
            this.lblComision.TabIndex = 17;
            this.lblComision.Text = "lblComision";
            // 
            // lblGratificacion
            // 
            this.lblGratificacion.AutoSize = true;
            this.lblGratificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGratificacion.Location = new System.Drawing.Point(111, 50);
            this.lblGratificacion.Name = "lblGratificacion";
            this.lblGratificacion.Size = new System.Drawing.Size(92, 13);
            this.lblGratificacion.TabIndex = 16;
            this.lblGratificacion.Text = "lblGratificacion";
            // 
            // lblBasico
            // 
            this.lblBasico.AutoSize = true;
            this.lblBasico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasico.Location = new System.Drawing.Point(111, 27);
            this.lblBasico.Name = "lblBasico";
            this.lblBasico.Size = new System.Drawing.Size(58, 13);
            this.lblBasico.TabIndex = 15;
            this.lblBasico.Text = "lblBasico";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCooperativa);
            this.groupBox3.Controls.Add(this.lblAFP);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(273, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 106);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DESCUENTOS";
            // 
            // lblCooperativa
            // 
            this.lblCooperativa.AutoSize = true;
            this.lblCooperativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCooperativa.Location = new System.Drawing.Point(111, 68);
            this.lblCooperativa.Name = "lblCooperativa";
            this.lblCooperativa.Size = new System.Drawing.Size(88, 13);
            this.lblCooperativa.TabIndex = 16;
            this.lblCooperativa.Text = "lblCooperativa";
            // 
            // lblAFP
            // 
            this.lblAFP.AutoSize = true;
            this.lblAFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAFP.Location = new System.Drawing.Point(111, 27);
            this.lblAFP.Name = "lblAFP";
            this.lblAFP.Size = new System.Drawing.Size(43, 13);
            this.lblAFP.TabIndex = 15;
            this.lblAFP.Text = "lblAFP";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "COOPERATIVA";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "AFP";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblSeguro);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Location = new System.Drawing.Point(530, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 106);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "APORTACIONES";
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguro.Location = new System.Drawing.Point(129, 27);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(95, 13);
            this.lblSeguro.TabIndex = 15;
            this.lblSeguro.Text = "lblSeguroSocial";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(29, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "SEGURO SOCIAL";
            // 
            // lblTotalIngresos
            // 
            this.lblTotalIngresos.AutoSize = true;
            this.lblTotalIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIngresos.Location = new System.Drawing.Point(144, 329);
            this.lblTotalIngresos.Name = "lblTotalIngresos";
            this.lblTotalIngresos.Size = new System.Drawing.Size(97, 13);
            this.lblTotalIngresos.TabIndex = 19;
            this.lblTotalIngresos.Text = "lblTotalIngresos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 329);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "TOTAL INGRESOS";
            // 
            // lblTotalDescuentos
            // 
            this.lblTotalDescuentos.AutoSize = true;
            this.lblTotalDescuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDescuentos.Location = new System.Drawing.Point(384, 329);
            this.lblTotalDescuentos.Name = "lblTotalDescuentos";
            this.lblTotalDescuentos.Size = new System.Drawing.Size(116, 13);
            this.lblTotalDescuentos.TabIndex = 21;
            this.lblTotalDescuentos.Text = "lblTotalDescuentos";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(263, 329);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "TOTAL DESCUENTOS";
            // 
            // lblTotalAportaciones
            // 
            this.lblTotalAportaciones.AutoSize = true;
            this.lblTotalAportaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAportaciones.Location = new System.Drawing.Point(640, 329);
            this.lblTotalAportaciones.Name = "lblTotalAportaciones";
            this.lblTotalAportaciones.Size = new System.Drawing.Size(123, 13);
            this.lblTotalAportaciones.TabIndex = 23;
            this.lblTotalAportaciones.Text = "lblTotalAportaciones";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(505, 329);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(129, 13);
            this.label21.TabIndex = 22;
            this.label21.Text = "TOTAL APORTACIONES";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(640, 365);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 13);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "lblTotal";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(559, 365);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(75, 13);
            this.label24.TabIndex = 24;
            this.label24.Text = "TOTAL NETO";
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Location = new System.Drawing.Point(570, 40);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(77, 13);
            this.lblFechaActual.TabIndex = 12;
            this.lblFechaActual.Text = "lblFechaActual";
            // 
            // frmPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.lblTotalAportaciones);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblTotalDescuentos);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblTotalIngresos);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.label1);
            this.Name = "frmPlanilla";
            this.Text = "Control de planilla de pagos";
            this.Load += new System.EventHandler(this.frmPlanilla_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAños;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.DateTimePicker dtFechaIngreso;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label lblGratificacion;
        private System.Windows.Forms.Label lblBasico;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCooperativa;
        private System.Windows.Forms.Label lblAFP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblTotalIngresos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTotalDescuentos;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblTotalAportaciones;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblFechaActual;
    }
}

