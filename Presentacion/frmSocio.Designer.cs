namespace Presentacion
{
    partial class frmSocio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDatosSocios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblAPellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIDSocio = new System.Windows.Forms.TextBox();
            this.txtDNIBusq = new System.Windows.Forms.TextBox();
            this.lblNomYApeBusq = new System.Windows.Forms.Label();
            this.lblDNIBusq = new System.Windows.Forms.Label();
            this.txtNomYApeBusq = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.btnGenerarCuotas = new System.Windows.Forms.Button();
            this.txtFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.txtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cbxLocalidad = new ControlesPersonalizados.cbxComboSinModif();
            this.cbxActivo = new ControlesPersonalizados.cbxComboSinModif();
            this.txtDNI = new ControlesPersonalizados.txtSoloNumeros();
            this.txtTelContacto = new ControlesPersonalizados.txtSoloNumeros();
            this.txtTelefono = new ControlesPersonalizados.txtSoloNumeros();
            this.txtApellido = new ControlesPersonalizados.txtSoloLetrasSinEspacios();
            this.txtNombre = new ControlesPersonalizados.txtSoloLetrasSinEspacios();
            this.dgvActXSocio = new System.Windows.Forms.DataGridView();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.lblActividad = new System.Windows.Forms.Label();
            this.cbxActividades = new ControlesPersonalizados.cbxComboSinModif();
            this.btnActXSoc = new System.Windows.Forms.Button();
            this.btnVerReporteSocXAct = new System.Windows.Forms.Button();
            this.cbxActReporte = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActXSocio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatosSocios
            // 
            this.dgvDatosSocios.AllowUserToAddRows = false;
            this.dgvDatosSocios.AllowUserToDeleteRows = false;
            this.dgvDatosSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgvDatosSocios.Location = new System.Drawing.Point(12, 66);
            this.dgvDatosSocios.Name = "dgvDatosSocios";
            this.dgvDatosSocios.ReadOnly = true;
            this.dgvDatosSocios.Size = new System.Drawing.Size(703, 576);
            this.dgvDatosSocios.TabIndex = 0;
            this.dgvDatosSocios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosSocios_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IDSocio";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apellido";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DNI";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Correo Electronico";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Telefono";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Telefono Contacto";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Fecha Alta";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Fecha Nac";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Activo";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Direccion";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Localidad";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(183, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 34);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnGuardar.FlatAppearance.BorderSize = 3;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(839, 623);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(193, 40);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(805, 86);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 9;
            this.lblDNI.Text = "DNI";
            // 
            // lblAPellido
            // 
            this.lblAPellido.AutoSize = true;
            this.lblAPellido.Location = new System.Drawing.Point(805, 50);
            this.lblAPellido.Name = "lblAPellido";
            this.lblAPellido.Size = new System.Drawing.Size(44, 13);
            this.lblAPellido.TabIndex = 8;
            this.lblAPellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(805, 14);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // txtIDSocio
            // 
            this.txtIDSocio.BackColor = System.Drawing.SystemColors.Control;
            this.txtIDSocio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDSocio.Location = new System.Drawing.Point(865, 47);
            this.txtIDSocio.Name = "txtIDSocio";
            this.txtIDSocio.Size = new System.Drawing.Size(33, 13);
            this.txtIDSocio.TabIndex = 15;
            this.txtIDSocio.Visible = false;
            // 
            // txtDNIBusq
            // 
            this.txtDNIBusq.Location = new System.Drawing.Point(68, 3);
            this.txtDNIBusq.Name = "txtDNIBusq";
            this.txtDNIBusq.Size = new System.Drawing.Size(100, 20);
            this.txtDNIBusq.TabIndex = 16;
            // 
            // lblNomYApeBusq
            // 
            this.lblNomYApeBusq.AutoSize = true;
            this.lblNomYApeBusq.Location = new System.Drawing.Point(9, 26);
            this.lblNomYApeBusq.Name = "lblNomYApeBusq";
            this.lblNomYApeBusq.Size = new System.Drawing.Size(49, 26);
            this.lblNomYApeBusq.TabIndex = 18;
            this.lblNomYApeBusq.Text = "Nombre/\r\nApellido";
            // 
            // lblDNIBusq
            // 
            this.lblDNIBusq.AutoSize = true;
            this.lblDNIBusq.Location = new System.Drawing.Point(9, 6);
            this.lblDNIBusq.Name = "lblDNIBusq";
            this.lblDNIBusq.Size = new System.Drawing.Size(26, 13);
            this.lblDNIBusq.TabIndex = 17;
            this.lblDNIBusq.Text = "DNI";
            // 
            // txtNomYApeBusq
            // 
            this.txtNomYApeBusq.Location = new System.Drawing.Point(68, 30);
            this.txtNomYApeBusq.Name = "txtNomYApeBusq";
            this.txtNomYApeBusq.Size = new System.Drawing.Size(100, 20);
            this.txtNomYApeBusq.TabIndex = 19;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3});
            this.shapeContainer1.Size = new System.Drawing.Size(1083, 694);
            this.shapeContainer1.TabIndex = 20;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 752;
            this.lineShape4.X2 = 754;
            this.lineShape4.Y1 = 0;
            this.lineShape4.Y2 = 648;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 749;
            this.lineShape3.X2 = 751;
            this.lineShape3.Y1 = 0;
            this.lineShape3.Y2 = 647;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(805, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Fecha Alta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(805, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fecha Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(805, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(805, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Correo Electronico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(805, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Telefono Contacto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(805, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Activo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(805, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Direccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(805, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Localidad";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(911, 335);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(121, 20);
            this.txtDireccion.TabIndex = 41;
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(721, 11);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(10, 10);
            this.btnModificar.TabIndex = 43;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(911, 263);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(121, 20);
            this.txtCorreoElectronico.TabIndex = 44;
            // 
            // btnGenerarCuotas
            // 
            this.btnGenerarCuotas.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGenerarCuotas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenerarCuotas.FlatAppearance.BorderSize = 2;
            this.btnGenerarCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarCuotas.Location = new System.Drawing.Point(617, 6);
            this.btnGenerarCuotas.Name = "btnGenerarCuotas";
            this.btnGenerarCuotas.Size = new System.Drawing.Size(98, 40);
            this.btnGenerarCuotas.TabIndex = 45;
            this.btnGenerarCuotas.Text = "GENERAR CUOTAS";
            this.btnGenerarCuotas.UseVisualStyleBackColor = false;
            this.btnGenerarCuotas.Click += new System.EventHandler(this.btnGenerarCuotas_Click);
            // 
            // txtFechaAlta
            // 
            this.txtFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaAlta.Location = new System.Drawing.Point(911, 119);
            this.txtFechaAlta.Name = "txtFechaAlta";
            this.txtFechaAlta.Size = new System.Drawing.Size(121, 20);
            this.txtFechaAlta.TabIndex = 46;
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaNac.Location = new System.Drawing.Point(911, 155);
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(121, 20);
            this.txtFechaNac.TabIndex = 47;
            // 
            // cbxLocalidad
            // 
            this.cbxLocalidad.FormattingEnabled = true;
            this.cbxLocalidad.Location = new System.Drawing.Point(911, 371);
            this.cbxLocalidad.Name = "cbxLocalidad";
            this.cbxLocalidad.Size = new System.Drawing.Size(121, 21);
            this.cbxLocalidad.TabIndex = 42;
            // 
            // cbxActivo
            // 
            this.cbxActivo.FormattingEnabled = true;
            this.cbxActivo.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cbxActivo.Location = new System.Drawing.Point(911, 299);
            this.cbxActivo.Name = "cbxActivo";
            this.cbxActivo.Size = new System.Drawing.Size(121, 21);
            this.cbxActivo.TabIndex = 40;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(911, 83);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(121, 20);
            this.txtDNI.TabIndex = 37;
            // 
            // txtTelContacto
            // 
            this.txtTelContacto.Location = new System.Drawing.Point(911, 230);
            this.txtTelContacto.MaxLength = 15;
            this.txtTelContacto.Name = "txtTelContacto";
            this.txtTelContacto.Size = new System.Drawing.Size(121, 20);
            this.txtTelContacto.TabIndex = 36;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(911, 194);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 20);
            this.txtTelefono.TabIndex = 34;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(911, 47);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(121, 20);
            this.txtApellido.TabIndex = 38;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(911, 11);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 39;
            // 
            // dgvActXSocio
            // 
            this.dgvActXSocio.AllowUserToAddRows = false;
            this.dgvActXSocio.AllowUserToDeleteRows = false;
            this.dgvActXSocio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvActXSocio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvActXSocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActXSocio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column13,
            this.Column14});
            this.dgvActXSocio.Enabled = false;
            this.dgvActXSocio.Location = new System.Drawing.Point(808, 435);
            this.dgvActXSocio.Name = "dgvActXSocio";
            this.dgvActXSocio.ReadOnly = true;
            this.dgvActXSocio.Size = new System.Drawing.Size(224, 149);
            this.dgvActXSocio.TabIndex = 48;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Actividad";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 76;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Activo";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 43;
            // 
            // btnAlta
            // 
            this.btnAlta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAlta.FlatAppearance.BorderSize = 3;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlta.Location = new System.Drawing.Point(1037, 471);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(42, 25);
            this.btnAlta.TabIndex = 49;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnBaja.FlatAppearance.BorderSize = 3;
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.Location = new System.Drawing.Point(1037, 534);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(42, 26);
            this.btnBaja.TabIndex = 50;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(805, 411);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(51, 13);
            this.lblActividad.TabIndex = 52;
            this.lblActividad.Text = "Actividad";
            // 
            // cbxActividades
            // 
            this.cbxActividades.FormattingEnabled = true;
            this.cbxActividades.Location = new System.Drawing.Point(911, 408);
            this.cbxActividades.Name = "cbxActividades";
            this.cbxActividades.Size = new System.Drawing.Size(121, 21);
            this.cbxActividades.TabIndex = 51;
            // 
            // btnActXSoc
            // 
            this.btnActXSoc.Location = new System.Drawing.Point(315, 8);
            this.btnActXSoc.Name = "btnActXSoc";
            this.btnActXSoc.Size = new System.Drawing.Size(80, 35);
            this.btnActXSoc.TabIndex = 53;
            this.btnActXSoc.Text = "Actividades del Socio";
            this.btnActXSoc.UseVisualStyleBackColor = true;
            this.btnActXSoc.Click += new System.EventHandler(this.btnActXSoc_Click);
            // 
            // btnVerReporteSocXAct
            // 
            this.btnVerReporteSocXAct.Location = new System.Drawing.Point(438, 37);
            this.btnVerReporteSocXAct.Name = "btnVerReporteSocXAct";
            this.btnVerReporteSocXAct.Size = new System.Drawing.Size(75, 23);
            this.btnVerReporteSocXAct.TabIndex = 56;
            this.btnVerReporteSocXAct.Text = "Ver reporte";
            this.btnVerReporteSocXAct.UseVisualStyleBackColor = true;
            this.btnVerReporteSocXAct.Click += new System.EventHandler(this.btnVerReporteSocXAct_Click);
            // 
            // cbxActReporte
            // 
            this.cbxActReporte.FormattingEnabled = true;
            this.cbxActReporte.Location = new System.Drawing.Point(415, 16);
            this.cbxActReporte.Name = "cbxActReporte";
            this.cbxActReporte.Size = new System.Drawing.Size(121, 21);
            this.cbxActReporte.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(421, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Socios Por Actividad";
            // 
            // frmSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 694);
            this.Controls.Add(this.btnVerReporteSocXAct);
            this.Controls.Add(this.cbxActReporte);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnActXSoc);
            this.Controls.Add(this.lblActividad);
            this.Controls.Add(this.cbxActividades);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.dgvActXSocio);
            this.Controls.Add(this.txtFechaNac);
            this.Controls.Add(this.txtFechaAlta);
            this.Controls.Add(this.txtCorreoElectronico);
            this.Controls.Add(this.cbxLocalidad);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.cbxActivo);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtTelContacto);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblAPellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnGenerarCuotas);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtNomYApeBusq);
            this.Controls.Add(this.lblNomYApeBusq);
            this.Controls.Add(this.lblDNIBusq);
            this.Controls.Add(this.txtDNIBusq);
            this.Controls.Add(this.txtIDSocio);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvDatosSocios);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socios";
            this.Load += new System.EventHandler(this.frmSocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActXSocio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosSocios;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblAPellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIDSocio;
        private System.Windows.Forms.TextBox txtDNIBusq;
        private System.Windows.Forms.Label lblNomYApeBusq;
        private System.Windows.Forms.Label lblDNIBusq;
        private System.Windows.Forms.TextBox txtNomYApeBusq;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private ControlesPersonalizados.txtSoloNumeros txtTelefono;
        private ControlesPersonalizados.txtSoloNumeros txtTelContacto;
        private ControlesPersonalizados.txtSoloNumeros txtDNI;
        private ControlesPersonalizados.txtSoloLetrasSinEspacios txtApellido;
        private ControlesPersonalizados.txtSoloLetrasSinEspacios txtNombre;
        private ControlesPersonalizados.cbxComboSinModif cbxActivo;
        private System.Windows.Forms.TextBox txtDireccion;
        private ControlesPersonalizados.cbxComboSinModif cbxLocalidad;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Button btnGenerarCuotas;
        private System.Windows.Forms.DateTimePicker txtFechaAlta;
        private System.Windows.Forms.DateTimePicker txtFechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridView dgvActXSocio;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Label lblActividad;
        private ControlesPersonalizados.cbxComboSinModif cbxActividades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column14;
        private System.Windows.Forms.Button btnActXSoc;
        private System.Windows.Forms.Button btnVerReporteSocXAct;
        private System.Windows.Forms.ComboBox cbxActReporte;
        private System.Windows.Forms.Label label9;
    }
}

