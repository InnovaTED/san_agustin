namespace SwJugueriaAgustin.Formularios
{
    partial class frmCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblCodCompra = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvDeatalle = new System.Windows.Forms.DataGridView();
            this.cnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnAgregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb2 = new System.Windows.Forms.Label();
            this.lblcliente = new System.Windows.Forms.Label();
            this.gbxCliente = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcontacto = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCambio = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.TextBox();
            this.lblIGV = new System.Windows.Forms.TextBox();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.cbAlmacen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeatalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbxCliente.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(17, 9);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(541, 30);
            this.txtProducto.TabIndex = 0;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            this.txtProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProducto_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cod. Compra";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Calisto MT", 10F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(294, 3);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(222, 23);
            this.dtpFecha.TabIndex = 6;
            // 
            // lblCodCompra
            // 
            this.lblCodCompra.AutoSize = true;
            this.lblCodCompra.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCompra.ForeColor = System.Drawing.Color.Blue;
            this.lblCodCompra.Location = new System.Drawing.Point(108, 17);
            this.lblCodCompra.Name = "lblCodCompra";
            this.lblCodCompra.Size = new System.Drawing.Size(65, 24);
            this.lblCodCompra.TabIndex = 10;
            this.lblCodCompra.Text = "00000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(227, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha:";
            // 
            // txtnum
            // 
            this.txtnum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.ForeColor = System.Drawing.Color.Blue;
            this.txtnum.Location = new System.Drawing.Point(74, 347);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(114, 25);
            this.txtnum.TabIndex = 24;
            this.txtnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnum_KeyDown);
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.ForeColor = System.Drawing.Color.Blue;
            this.txtSerie.Location = new System.Drawing.Point(74, 316);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(114, 25);
            this.txtSerie.TabIndex = 23;
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSerie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerie_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calisto MT", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 350);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 18);
            this.label15.TabIndex = 22;
            this.label15.Text = "Num:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calisto MT", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 319);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 18);
            this.label14.TabIndex = 21;
            this.label14.Text = "Serie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Efectivo:";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivo.ForeColor = System.Drawing.Color.Blue;
            this.txtEfectivo.Location = new System.Drawing.Point(74, 378);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(114, 25);
            this.txtEfectivo.TabIndex = 18;
            this.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
            this.txtEfectivo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEfectivo_KeyDown);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegistrar.BackColor = System.Drawing.Color.Red;
            this.btnRegistrar.Font = new System.Drawing.Font("Calisto MT", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(4, 517);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(186, 66);
            this.btnRegistrar.TabIndex = 30;
            this.btnRegistrar.Text = ".: Registrar Compra :.";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgvDeatalle
            // 
            this.dgvDeatalle.AllowUserToAddRows = false;
            this.dgvDeatalle.AllowUserToDeleteRows = false;
            this.dgvDeatalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeatalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeatalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDeatalle.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDeatalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeatalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDeatalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeatalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnCodigo,
            this.cnProducto,
            this.cnCantidad,
            this.cnPrecio,
            this.cnSubTotal,
            this.cnAgregar,
            this.cnEliminar});
            this.dgvDeatalle.EnableHeadersVisualStyles = false;
            this.dgvDeatalle.Location = new System.Drawing.Point(12, 367);
            this.dgvDeatalle.Name = "dgvDeatalle";
            this.dgvDeatalle.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeatalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDeatalle.RowHeadersVisible = false;
            this.dgvDeatalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDeatalle.Size = new System.Drawing.Size(940, 264);
            this.dgvDeatalle.TabIndex = 29;
            this.dgvDeatalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeatalle_CellClick);
            // 
            // cnCodigo
            // 
            this.cnCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cnCodigo.HeaderText = "Cod. Produc.";
            this.cnCodigo.Name = "cnCodigo";
            this.cnCodigo.ReadOnly = true;
            this.cnCodigo.Width = 120;
            // 
            // cnProducto
            // 
            this.cnProducto.HeaderText = "Producto";
            this.cnProducto.Name = "cnProducto";
            this.cnProducto.ReadOnly = true;
            // 
            // cnCantidad
            // 
            this.cnCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cnCantidad.HeaderText = "Cantidad";
            this.cnCantidad.Name = "cnCantidad";
            this.cnCantidad.ReadOnly = true;
            // 
            // cnPrecio
            // 
            this.cnPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cnPrecio.HeaderText = "Costo Promedio";
            this.cnPrecio.Name = "cnPrecio";
            this.cnPrecio.ReadOnly = true;
            // 
            // cnSubTotal
            // 
            this.cnSubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cnSubTotal.HeaderText = "SubTotal";
            this.cnSubTotal.Name = "cnSubTotal";
            this.cnSubTotal.ReadOnly = true;
            // 
            // cnAgregar
            // 
            this.cnAgregar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cnAgregar.HeaderText = "Agregar";
            this.cnAgregar.Name = "cnAgregar";
            this.cnAgregar.ReadOnly = true;
            this.cnAgregar.Text = "+";
            this.cnAgregar.UseColumnTextForButtonValue = true;
            this.cnAgregar.Width = 70;
            // 
            // cnEliminar
            // 
            this.cnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cnEliminar.HeaderText = "Eliminar";
            this.cnEliminar.Name = "cnEliminar";
            this.cnEliminar.ReadOnly = true;
            this.cnEliminar.Text = "x";
            this.cnEliminar.UseColumnTextForButtonValue = true;
            this.cnEliminar.Width = 70;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.Location = new System.Drawing.Point(18, 187);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(934, 150);
            this.dgvProductos.TabIndex = 28;
            this.dgvProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProductos_KeyDown);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(188, 20);
            this.txtNombre.TabIndex = 23;
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nombres";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "Telefono";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(122, 3);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(188, 20);
            this.txtNumero.TabIndex = 21;
            this.txtNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero_KeyDown);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(122, 47);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(188, 20);
            this.txtTelefono.TabIndex = 25;
            this.txtTelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefono_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "RUC/DNI + Enter";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(122, 91);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDireccion.Size = new System.Drawing.Size(188, 41);
            this.txtDireccion.TabIndex = 28;
            this.txtDireccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDireccion_KeyDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calisto MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 340);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(167, 24);
            this.label16.TabIndex = 11;
            this.label16.Text = "Detalle de Compra";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.RoyalBlue;
            this.label11.Font = new System.Drawing.Font("Calisto MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(15, 9);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(4);
            this.label11.Size = new System.Drawing.Size(186, 23);
            this.label11.TabIndex = 41;
            this.label11.Text = "        .: DATOS COMPRA :.        ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.cbAlmacen);
            this.panel3.Controls.Add(this.dtpFecha);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblCodCompra);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(15, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(523, 60);
            this.panel3.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 99);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4);
            this.label2.Size = new System.Drawing.Size(255, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "        .: BUSCADOR DE PRODUCTOS :.        ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtProducto);
            this.panel1.Controls.Add(this.lb2);
            this.panel1.Location = new System.Drawing.Point(15, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 49);
            this.panel1.TabIndex = 44;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.Color.Maroon;
            this.lb2.Location = new System.Drawing.Point(558, 16);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(21, 15);
            this.lb2.TabIndex = 29;
            this.lb2.Text = "F2";
            this.lb2.Visible = false;
            // 
            // lblcliente
            // 
            this.lblcliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcliente.AutoSize = true;
            this.lblcliente.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblcliente.Font = new System.Drawing.Font("Calisto MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.ForeColor = System.Drawing.Color.White;
            this.lblcliente.Location = new System.Drawing.Point(609, 9);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Padding = new System.Windows.Forms.Padding(4);
            this.lblcliente.Size = new System.Drawing.Size(210, 23);
            this.lblcliente.TabIndex = 45;
            this.lblcliente.Text = "        .: DATOS PROVEEDOR :.        ";
            this.lblcliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxCliente
            // 
            this.gbxCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gbxCliente.Controls.Add(this.label9);
            this.gbxCliente.Controls.Add(this.txtcontacto);
            this.gbxCliente.Controls.Add(this.lb1);
            this.gbxCliente.Controls.Add(this.txtDireccion);
            this.gbxCliente.Controls.Add(this.label13);
            this.gbxCliente.Controls.Add(this.txtNumero);
            this.gbxCliente.Controls.Add(this.txtNombre);
            this.gbxCliente.Controls.Add(this.label12);
            this.gbxCliente.Controls.Add(this.label1);
            this.gbxCliente.Controls.Add(this.txtTelefono);
            this.gbxCliente.Controls.Add(this.label7);
            this.gbxCliente.Location = new System.Drawing.Point(609, 32);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Size = new System.Drawing.Size(343, 139);
            this.gbxCliente.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "Contacto";
            // 
            // txtcontacto
            // 
            this.txtcontacto.Location = new System.Drawing.Point(122, 69);
            this.txtcontacto.Name = "txtcontacto";
            this.txtcontacto.Size = new System.Drawing.Size(188, 20);
            this.txtcontacto.TabIndex = 29;
            this.txtcontacto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcontacto_KeyDown);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.Maroon;
            this.lb1.Location = new System.Drawing.Point(312, 7);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(21, 15);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "F1";
            this.lb1.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkGray;
            this.label10.Font = new System.Drawing.Font("Calisto MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(4, 197);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(4);
            this.label10.Size = new System.Drawing.Size(186, 23);
            this.label10.TabIndex = 47;
            this.label10.Text = "                  .: TOTAL :.                 ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblCambio);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.lblSubTotal);
            this.panel2.Controls.Add(this.lblIGV);
            this.panel2.Controls.Add(this.lb4);
            this.panel2.Controls.Add(this.lb3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnRegistrar);
            this.panel2.Controls.Add(this.txtnum);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtSerie);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txtEfectivo);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(1000, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 606);
            this.panel2.TabIndex = 49;
            // 
            // lblCambio
            // 
            this.lblCambio.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCambio.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Bold);
            this.lblCambio.ForeColor = System.Drawing.Color.Red;
            this.lblCambio.Location = new System.Drawing.Point(7, 447);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(181, 64);
            this.lblCambio.TabIndex = 54;
            this.lblCambio.Text = "0.00";
            this.lblCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTotal.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(7, 223);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(181, 64);
            this.lblTotal.TabIndex = 53;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSubTotal.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Bold);
            this.lblSubTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblSubTotal.Location = new System.Drawing.Point(7, 128);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(181, 64);
            this.lblSubTotal.TabIndex = 52;
            this.lblSubTotal.Text = "0.00";
            this.lblSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIGV
            // 
            this.lblIGV.BackColor = System.Drawing.Color.Gainsboro;
            this.lblIGV.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Bold);
            this.lblIGV.ForeColor = System.Drawing.Color.Blue;
            this.lblIGV.Location = new System.Drawing.Point(7, 35);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(181, 64);
            this.lblIGV.TabIndex = 51;
            this.lblIGV.Text = "0.00";
            this.lblIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.ForeColor = System.Drawing.Color.Maroon;
            this.lb4.Location = new System.Drawing.Point(6, 583);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(21, 15);
            this.lb4.TabIndex = 50;
            this.lb4.Text = "F4";
            this.lb4.Visible = false;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.ForeColor = System.Drawing.Color.Maroon;
            this.lb3.Location = new System.Drawing.Point(51, 321);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(21, 15);
            this.lb3.TabIndex = 50;
            this.lb3.Text = "F3";
            this.lb3.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGray;
            this.label8.Font = new System.Drawing.Font("Calisto MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(53, 421);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(4);
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 49;
            this.label8.Text = ".: CAMBIO :.      ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGray;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 105);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(4);
            this.label6.Size = new System.Drawing.Size(171, 23);
            this.label6.TabIndex = 48;
            this.label6.Text = "           .: SUBTOTAL :.           ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.DarkGray;
            this.label17.Font = new System.Drawing.Font("Calisto MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(13, 13);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(4);
            this.label17.Size = new System.Drawing.Size(166, 23);
            this.label17.TabIndex = 47;
            this.label17.Text = "                  .: IGV :.                 ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.RoyalBlue;
            this.label26.Font = new System.Drawing.Font("Calisto MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(1000, 9);
            this.label26.Name = "label26";
            this.label26.Padding = new System.Windows.Forms.Padding(4);
            this.label26.Size = new System.Drawing.Size(198, 23);
            this.label26.TabIndex = 48;
            this.label26.Text = " .: FACTURACIÓN COMPRA :.   ";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label18.Location = new System.Drawing.Point(227, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 15);
            this.label18.TabIndex = 12;
            this.label18.Text = "Almacén:";
            // 
            // cbAlmacen
            // 
            this.cbAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlmacen.Font = new System.Drawing.Font("Calisto MT", 10F);
            this.cbAlmacen.FormattingEnabled = true;
            this.cbAlmacen.Location = new System.Drawing.Point(294, 30);
            this.cbAlmacen.Name = "cbAlmacen";
            this.cbAlmacen.Size = new System.Drawing.Size(222, 23);
            this.cbAlmacen.TabIndex = 11;
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1220, 664);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.gbxCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dgvDeatalle);
            this.Controls.Add(this.dgvProductos);
            this.Name = "frmCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Registro de Compra :.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeatalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblCodCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvDeatalle;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnSubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn cnAgregar;
        private System.Windows.Forms.DataGridViewButtonColumn cnEliminar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Panel gbxCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.TextBox lblCambio;
        private System.Windows.Forms.TextBox lblTotal;
        private System.Windows.Forms.TextBox lblSubTotal;
        private System.Windows.Forms.TextBox lblIGV;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcontacto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbAlmacen;
    }
}