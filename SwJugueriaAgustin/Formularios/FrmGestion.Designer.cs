namespace SwJugueriaAgustin.Formularios
{
    partial class FrmGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestion));
            this.cbxAlmacenEmisor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAlmacenEmisor = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvAlmacenReceptor = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxAlmacenReceptor = new System.Windows.Forms.ComboBox();
            this.cnREliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cnRAgregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cnRStockMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnRStockMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnRCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnRUniMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnRPorducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacenEmisor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacenReceptor)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxAlmacenEmisor
            // 
            this.cbxAlmacenEmisor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxAlmacenEmisor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxAlmacenEmisor.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAlmacenEmisor.FormattingEnabled = true;
            this.cbxAlmacenEmisor.Location = new System.Drawing.Point(6, 28);
            this.cbxAlmacenEmisor.Name = "cbxAlmacenEmisor";
            this.cbxAlmacenEmisor.Size = new System.Drawing.Size(634, 25);
            this.cbxAlmacenEmisor.TabIndex = 0;
            this.cbxAlmacenEmisor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxAlmacenEmisor_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxAlmacenEmisor);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 71);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Almacen Emisor";
            // 
            // dgvAlmacenEmisor
            // 
            this.dgvAlmacenEmisor.AllowUserToAddRows = false;
            this.dgvAlmacenEmisor.AllowUserToDeleteRows = false;
            this.dgvAlmacenEmisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlmacenEmisor.Location = new System.Drawing.Point(28, 166);
            this.dgvAlmacenEmisor.MultiSelect = false;
            this.dgvAlmacenEmisor.Name = "dgvAlmacenEmisor";
            this.dgvAlmacenEmisor.ReadOnly = true;
            this.dgvAlmacenEmisor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlmacenEmisor.Size = new System.Drawing.Size(644, 301);
            this.dgvAlmacenEmisor.TabIndex = 3;
            this.dgvAlmacenEmisor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAlmacenEmisor_KeyDown);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(28, 134);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(644, 26);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresar Producto";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1313, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = ".:: Guardar Traslado ::.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvAlmacenReceptor
            // 
            this.dgvAlmacenReceptor.AllowUserToAddRows = false;
            this.dgvAlmacenReceptor.AllowUserToDeleteRows = false;
            this.dgvAlmacenReceptor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlmacenReceptor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvAlmacenReceptor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlmacenReceptor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnRPorducto,
            this.cnRUniMedida,
            this.cnRCantidad,
            this.cnRStockMin,
            this.cnRStockMax,
            this.cnRAgregar,
            this.cnREliminar});
            this.dgvAlmacenReceptor.Location = new System.Drawing.Point(690, 166);
            this.dgvAlmacenReceptor.MultiSelect = false;
            this.dgvAlmacenReceptor.Name = "dgvAlmacenReceptor";
            this.dgvAlmacenReceptor.ReadOnly = true;
            this.dgvAlmacenReceptor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlmacenReceptor.Size = new System.Drawing.Size(651, 301);
            this.dgvAlmacenReceptor.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxAlmacenReceptor);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(690, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 71);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Almacen Receptor";
            // 
            // cbxAlmacenReceptor
            // 
            this.cbxAlmacenReceptor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxAlmacenReceptor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxAlmacenReceptor.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAlmacenReceptor.FormattingEnabled = true;
            this.cbxAlmacenReceptor.Location = new System.Drawing.Point(7, 28);
            this.cbxAlmacenReceptor.Name = "cbxAlmacenReceptor";
            this.cbxAlmacenReceptor.Size = new System.Drawing.Size(638, 25);
            this.cbxAlmacenReceptor.TabIndex = 2;
            this.cbxAlmacenReceptor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxAlmacenReceptor_KeyDown);
            // 
            // cnREliminar
            // 
            this.cnREliminar.FillWeight = 77.16119F;
            this.cnREliminar.HeaderText = "Eliminar";
            this.cnREliminar.Name = "cnREliminar";
            this.cnREliminar.ReadOnly = true;
            this.cnREliminar.Text = "x";
            this.cnREliminar.UseColumnTextForButtonValue = true;
            // 
            // cnRAgregar
            // 
            this.cnRAgregar.FillWeight = 80.49499F;
            this.cnRAgregar.HeaderText = "Agregar";
            this.cnRAgregar.Name = "cnRAgregar";
            this.cnRAgregar.ReadOnly = true;
            this.cnRAgregar.Text = "+";
            this.cnRAgregar.UseColumnTextForButtonValue = true;
            // 
            // cnRStockMax
            // 
            this.cnRStockMax.FillWeight = 71.94203F;
            this.cnRStockMax.HeaderText = "Stock Max.";
            this.cnRStockMax.Name = "cnRStockMax";
            this.cnRStockMax.ReadOnly = true;
            // 
            // cnRStockMin
            // 
            this.cnRStockMin.FillWeight = 88.70235F;
            this.cnRStockMin.HeaderText = "Stock Min.";
            this.cnRStockMin.Name = "cnRStockMin";
            this.cnRStockMin.ReadOnly = true;
            // 
            // cnRCantidad
            // 
            this.cnRCantidad.FillWeight = 210.2263F;
            this.cnRCantidad.HeaderText = "Cantidad";
            this.cnRCantidad.Name = "cnRCantidad";
            this.cnRCantidad.ReadOnly = true;
            // 
            // cnRUniMedida
            // 
            this.cnRUniMedida.FillWeight = 113.2967F;
            this.cnRUniMedida.HeaderText = "Uni Medida";
            this.cnRUniMedida.Name = "cnRUniMedida";
            this.cnRUniMedida.ReadOnly = true;
            // 
            // cnRPorducto
            // 
            this.cnRPorducto.FillWeight = 102.158F;
            this.cnRPorducto.HeaderText = "Producto";
            this.cnRPorducto.Name = "cnRPorducto";
            this.cnRPorducto.ReadOnly = true;
            // 
            // FrmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 560);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvAlmacenReceptor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvAlmacenEmisor);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGestion";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.FrmGestion_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacenEmisor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacenReceptor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxAlmacenEmisor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAlmacenEmisor;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvAlmacenReceptor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxAlmacenReceptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnRPorducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnRUniMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnRCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnRStockMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnRStockMax;
        private System.Windows.Forms.DataGridViewButtonColumn cnRAgregar;
        private System.Windows.Forms.DataGridViewButtonColumn cnREliminar;
    }
}