namespace Presentacion
{
    partial class frmGenerarCuotas
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
            this.dgvSociosActivos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdbGenCuotaTodosSoc = new System.Windows.Forms.RadioButton();
            this.rdbGenCuotaSocEspecif = new System.Windows.Forms.RadioButton();
            this.lblGenerarCuotas = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblNomYApeBusq = new System.Windows.Forms.Label();
            this.lblDNIBusq = new System.Windows.Forms.Label();
            this.txtNomYApeBusq = new ControlesPersonalizados.txtSoloLetrasConEspacio();
            this.txtDNIBusq = new ControlesPersonalizados.txtSoloNumeros();
            this.dgvCuotasGeneradas = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerarCuotas = new System.Windows.Forms.Button();
            this.btnConsultarCuotas = new System.Windows.Forms.Button();
            this.lblPeriodoCuota = new System.Windows.Forms.Label();
            this.txtMesCuota = new ControlesPersonalizados.txtSoloNumeros();
            this.txtAñoCuota = new ControlesPersonalizados.txtSoloNumeros();
            this.lblMesCuota = new System.Windows.Forms.Label();
            this.lblAñoCuota = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new ControlesPersonalizados.txtSoloNumeros();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFechaResumen = new System.Windows.Forms.DateTimePicker();
            this.chkFechaResumen = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSociosActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotasGeneradas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSociosActivos
            // 
            this.dgvSociosActivos.AllowUserToAddRows = false;
            this.dgvSociosActivos.AllowUserToDeleteRows = false;
            this.dgvSociosActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSociosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSociosActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvSociosActivos.Location = new System.Drawing.Point(12, 182);
            this.dgvSociosActivos.Name = "dgvSociosActivos";
            this.dgvSociosActivos.ReadOnly = true;
            this.dgvSociosActivos.Size = new System.Drawing.Size(361, 280);
            this.dgvSociosActivos.TabIndex = 5;
            this.dgvSociosActivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSociosActivos_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre y Apellido";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 107;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DNI";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 51;
            // 
            // rdbGenCuotaTodosSoc
            // 
            this.rdbGenCuotaTodosSoc.AutoSize = true;
            this.rdbGenCuotaTodosSoc.Location = new System.Drawing.Point(13, 63);
            this.rdbGenCuotaTodosSoc.Name = "rdbGenCuotaTodosSoc";
            this.rdbGenCuotaTodosSoc.Size = new System.Drawing.Size(55, 17);
            this.rdbGenCuotaTodosSoc.TabIndex = 6;
            this.rdbGenCuotaTodosSoc.TabStop = true;
            this.rdbGenCuotaTodosSoc.Text = "Todos";
            this.rdbGenCuotaTodosSoc.UseVisualStyleBackColor = true;
            // 
            // rdbGenCuotaSocEspecif
            // 
            this.rdbGenCuotaSocEspecif.AutoSize = true;
            this.rdbGenCuotaSocEspecif.Location = new System.Drawing.Point(13, 40);
            this.rdbGenCuotaSocEspecif.Name = "rdbGenCuotaSocEspecif";
            this.rdbGenCuotaSocEspecif.Size = new System.Drawing.Size(105, 17);
            this.rdbGenCuotaSocEspecif.TabIndex = 7;
            this.rdbGenCuotaSocEspecif.TabStop = true;
            this.rdbGenCuotaSocEspecif.Text = "Socio específico";
            this.rdbGenCuotaSocEspecif.UseVisualStyleBackColor = true;
            // 
            // lblGenerarCuotas
            // 
            this.lblGenerarCuotas.AutoSize = true;
            this.lblGenerarCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerarCuotas.Location = new System.Drawing.Point(13, 13);
            this.lblGenerarCuotas.Name = "lblGenerarCuotas";
            this.lblGenerarCuotas.Size = new System.Drawing.Size(74, 13);
            this.lblGenerarCuotas.TabIndex = 10;
            this.lblGenerarCuotas.Text = "Seleccione:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(175, 126);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 32);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5,
            this.lineShape3,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(904, 474);
            this.shapeContainer1.TabIndex = 14;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape5
            // 
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 408;
            this.lineShape5.X2 = 408;
            this.lineShape5.Y1 = 6;
            this.lineShape5.Y2 = 463;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 119;
            this.lineShape3.X2 = 7;
            this.lineShape3.Y1 = 98;
            this.lineShape3.Y2 = 98;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 119;
            this.lineShape1.X2 = 119;
            this.lineShape1.Y1 = 11;
            this.lineShape1.Y2 = 90;
            // 
            // lblNomYApeBusq
            // 
            this.lblNomYApeBusq.AutoSize = true;
            this.lblNomYApeBusq.Location = new System.Drawing.Point(13, 146);
            this.lblNomYApeBusq.Name = "lblNomYApeBusq";
            this.lblNomYApeBusq.Size = new System.Drawing.Size(49, 26);
            this.lblNomYApeBusq.TabIndex = 20;
            this.lblNomYApeBusq.Text = "Nombre/\r\nApellido";
            // 
            // lblDNIBusq
            // 
            this.lblDNIBusq.AutoSize = true;
            this.lblDNIBusq.Location = new System.Drawing.Point(13, 118);
            this.lblDNIBusq.Name = "lblDNIBusq";
            this.lblDNIBusq.Size = new System.Drawing.Size(26, 13);
            this.lblDNIBusq.TabIndex = 19;
            this.lblDNIBusq.Text = "DNI";
            // 
            // txtNomYApeBusq
            // 
            this.txtNomYApeBusq.Location = new System.Drawing.Point(69, 151);
            this.txtNomYApeBusq.Name = "txtNomYApeBusq";
            this.txtNomYApeBusq.Size = new System.Drawing.Size(100, 20);
            this.txtNomYApeBusq.TabIndex = 21;
            // 
            // txtDNIBusq
            // 
            this.txtDNIBusq.Location = new System.Drawing.Point(69, 118);
            this.txtDNIBusq.Name = "txtDNIBusq";
            this.txtDNIBusq.Size = new System.Drawing.Size(100, 20);
            this.txtDNIBusq.TabIndex = 22;
            // 
            // dgvCuotasGeneradas
            // 
            this.dgvCuotasGeneradas.AllowUserToAddRows = false;
            this.dgvCuotasGeneradas.AllowUserToDeleteRows = false;
            this.dgvCuotasGeneradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCuotasGeneradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuotasGeneradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column10});
            this.dgvCuotasGeneradas.Location = new System.Drawing.Point(433, 49);
            this.dgvCuotasGeneradas.MultiSelect = false;
            this.dgvCuotasGeneradas.Name = "dgvCuotasGeneradas";
            this.dgvCuotasGeneradas.ReadOnly = true;
            this.dgvCuotasGeneradas.Size = new System.Drawing.Size(446, 290);
            this.dgvCuotasGeneradas.TabIndex = 23;
            this.dgvCuotasGeneradas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuotasGeneradas_CellContentClick);
            // 
            // Column9
            // 
            this.Column9.HeaderText = "IDCuotaXSocio";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            this.Column9.Width = 105;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Periodo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 68;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Monto";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 62;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fecha Pago";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 90;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Pagar";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 41;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Entrega";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 69;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Pendiente";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 80;
            // 
            // btnGenerarCuotas
            // 
            this.btnGenerarCuotas.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGenerarCuotas.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnGenerarCuotas.FlatAppearance.BorderSize = 2;
            this.btnGenerarCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarCuotas.Location = new System.Drawing.Point(224, 11);
            this.btnGenerarCuotas.Name = "btnGenerarCuotas";
            this.btnGenerarCuotas.Size = new System.Drawing.Size(84, 32);
            this.btnGenerarCuotas.TabIndex = 24;
            this.btnGenerarCuotas.Text = "GENERAR";
            this.btnGenerarCuotas.UseVisualStyleBackColor = false;
            this.btnGenerarCuotas.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnConsultarCuotas
            // 
            this.btnConsultarCuotas.BackColor = System.Drawing.SystemColors.Control;
            this.btnConsultarCuotas.FlatAppearance.BorderSize = 0;
            this.btnConsultarCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCuotas.Location = new System.Drawing.Point(352, 20);
            this.btnConsultarCuotas.Name = "btnConsultarCuotas";
            this.btnConsultarCuotas.Size = new System.Drawing.Size(21, 15);
            this.btnConsultarCuotas.TabIndex = 25;
            this.btnConsultarCuotas.UseVisualStyleBackColor = false;
            this.btnConsultarCuotas.Click += new System.EventHandler(this.btnConsultarCuotas_Click);
            // 
            // lblPeriodoCuota
            // 
            this.lblPeriodoCuota.AutoSize = true;
            this.lblPeriodoCuota.Location = new System.Drawing.Point(131, 13);
            this.lblPeriodoCuota.Name = "lblPeriodoCuota";
            this.lblPeriodoCuota.Size = new System.Drawing.Size(56, 13);
            this.lblPeriodoCuota.TabIndex = 27;
            this.lblPeriodoCuota.Text = "PERIODO";
            // 
            // txtMesCuota
            // 
            this.txtMesCuota.Location = new System.Drawing.Point(130, 46);
            this.txtMesCuota.MaxLength = 2;
            this.txtMesCuota.Name = "txtMesCuota";
            this.txtMesCuota.Size = new System.Drawing.Size(22, 20);
            this.txtMesCuota.TabIndex = 28;
            // 
            // txtAñoCuota
            // 
            this.txtAñoCuota.Location = new System.Drawing.Point(156, 46);
            this.txtAñoCuota.MaxLength = 4;
            this.txtAñoCuota.Name = "txtAñoCuota";
            this.txtAñoCuota.ReadOnly = true;
            this.txtAñoCuota.Size = new System.Drawing.Size(37, 20);
            this.txtAñoCuota.TabIndex = 29;
            // 
            // lblMesCuota
            // 
            this.lblMesCuota.AutoSize = true;
            this.lblMesCuota.Location = new System.Drawing.Point(128, 31);
            this.lblMesCuota.Name = "lblMesCuota";
            this.lblMesCuota.Size = new System.Drawing.Size(27, 13);
            this.lblMesCuota.TabIndex = 30;
            this.lblMesCuota.Text = "Mes";
            // 
            // lblAñoCuota
            // 
            this.lblAñoCuota.AutoSize = true;
            this.lblAñoCuota.Location = new System.Drawing.Point(161, 31);
            this.lblAñoCuota.Name = "lblAñoCuota";
            this.lblAñoCuota.Size = new System.Drawing.Size(26, 13);
            this.lblAñoCuota.TabIndex = 31;
            this.lblAñoCuota.Text = "Año";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptar.FlatAppearance.BorderSize = 3;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(765, 430);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(114, 32);
            this.btnAceptar.TabIndex = 33;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(502, 23);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 34;
            this.lblMonto.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(545, 20);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(97, 20);
            this.txtMonto.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "PAGO";
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(122, 65);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 37;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnResumenDeCuentas_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkFechaResumen);
            this.panel1.Controls.Add(this.txtFechaResumen);
            this.panel1.Controls.Add(this.btnReporte);
            this.panel1.Location = new System.Drawing.Point(435, 373);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 91);
            this.panel1.TabIndex = 38;
            // 
            // txtFechaResumen
            // 
            this.txtFechaResumen.Enabled = false;
            this.txtFechaResumen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaResumen.Location = new System.Drawing.Point(100, 19);
            this.txtFechaResumen.Name = "txtFechaResumen";
            this.txtFechaResumen.Size = new System.Drawing.Size(97, 20);
            this.txtFechaResumen.TabIndex = 38;
            // 
            // chkFechaResumen
            // 
            this.chkFechaResumen.AutoSize = true;
            this.chkFechaResumen.Location = new System.Drawing.Point(3, 19);
            this.chkFechaResumen.Name = "chkFechaResumen";
            this.chkFechaResumen.Size = new System.Drawing.Size(56, 17);
            this.chkFechaResumen.TabIndex = 39;
            this.chkFechaResumen.Text = "Fecha";
            this.chkFechaResumen.UseVisualStyleBackColor = true;
            this.chkFechaResumen.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // frmGenerarCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 474);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblAñoCuota);
            this.Controls.Add(this.lblMesCuota);
            this.Controls.Add(this.txtAñoCuota);
            this.Controls.Add(this.txtMesCuota);
            this.Controls.Add(this.lblPeriodoCuota);
            this.Controls.Add(this.btnConsultarCuotas);
            this.Controls.Add(this.btnGenerarCuotas);
            this.Controls.Add(this.dgvCuotasGeneradas);
            this.Controls.Add(this.txtDNIBusq);
            this.Controls.Add(this.txtNomYApeBusq);
            this.Controls.Add(this.lblNomYApeBusq);
            this.Controls.Add(this.lblDNIBusq);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblGenerarCuotas);
            this.Controls.Add(this.rdbGenCuotaSocEspecif);
            this.Controls.Add(this.rdbGenCuotaTodosSoc);
            this.Controls.Add(this.dgvSociosActivos);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGenerarCuotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobro de Cuotas";
            this.Load += new System.EventHandler(this.frmGenerarCuotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSociosActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotasGeneradas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSociosActivos;
        private System.Windows.Forms.RadioButton rdbGenCuotaTodosSoc;
        private System.Windows.Forms.RadioButton rdbGenCuotaSocEspecif;
        private System.Windows.Forms.Label lblGenerarCuotas;
        private System.Windows.Forms.Button btnBuscar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label lblNomYApeBusq;
        private System.Windows.Forms.Label lblDNIBusq;
        private ControlesPersonalizados.txtSoloLetrasConEspacio txtNomYApeBusq;
        private ControlesPersonalizados.txtSoloNumeros txtDNIBusq;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private System.Windows.Forms.DataGridView dgvCuotasGeneradas;
        private System.Windows.Forms.Button btnGenerarCuotas;
        private System.Windows.Forms.Button btnConsultarCuotas;
        private System.Windows.Forms.Label lblPeriodoCuota;
        private ControlesPersonalizados.txtSoloNumeros txtMesCuota;
        private ControlesPersonalizados.txtSoloNumeros txtAñoCuota;
        private System.Windows.Forms.Label lblMesCuota;
        private System.Windows.Forms.Label lblAñoCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Label lblMonto;
        private ControlesPersonalizados.txtSoloNumeros txtMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker txtFechaResumen;
        private System.Windows.Forms.CheckBox chkFechaResumen;
    }
}