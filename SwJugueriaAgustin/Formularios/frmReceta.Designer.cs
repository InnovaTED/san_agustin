namespace SwJugueriaAgustin.Formularios
{
    partial class frmReceta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProductoPrimo = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvRecetaProducto = new System.Windows.Forms.DataGridView();
            this.cnIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnUniMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoPrimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(18, 138);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(393, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // lblProducto
            // 
            this.lblProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProducto.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.Red;
            this.lblProducto.Location = new System.Drawing.Point(106, 22);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(285, 28);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "_______________________________________________";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPresentacion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblProducto);
            this.groupBox1.Font = new System.Drawing.Font("Calisto MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Receta";
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPresentacion.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentacion.ForeColor = System.Drawing.Color.Red;
            this.lblPresentacion.Location = new System.Drawing.Point(106, 57);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(285, 28);
            this.lblPresentacion.TabIndex = 4;
            this.lblPresentacion.Text = "__________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Presentación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ingresa Producto Primo:";
            // 
            // dgvProductoPrimo
            // 
            this.dgvProductoPrimo.AllowUserToAddRows = false;
            this.dgvProductoPrimo.AllowUserToDeleteRows = false;
            this.dgvProductoPrimo.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvProductoPrimo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductoPrimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductoPrimo.Location = new System.Drawing.Point(18, 162);
            this.dgvProductoPrimo.MultiSelect = false;
            this.dgvProductoPrimo.Name = "dgvProductoPrimo";
            this.dgvProductoPrimo.ReadOnly = true;
            this.dgvProductoPrimo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductoPrimo.Size = new System.Drawing.Size(393, 92);
            this.dgvProductoPrimo.TabIndex = 6;
            this.dgvProductoPrimo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProductoPrimo_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Receta del Producto";
            // 
            // dgvRecetaProducto
            // 
            this.dgvRecetaProducto.AllowUserToAddRows = false;
            this.dgvRecetaProducto.AllowUserToDeleteRows = false;
            this.dgvRecetaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecetaProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRecetaProducto.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvRecetaProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecetaProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecetaProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecetaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecetaProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnIDProducto,
            this.cnProducto,
            this.cnCantidad,
            this.cnUniMedida,
            this.cnEliminar});
            this.dgvRecetaProducto.EnableHeadersVisualStyles = false;
            this.dgvRecetaProducto.Location = new System.Drawing.Point(12, 286);
            this.dgvRecetaProducto.Name = "dgvRecetaProducto";
            this.dgvRecetaProducto.ReadOnly = true;
            this.dgvRecetaProducto.Size = new System.Drawing.Size(625, 214);
            this.dgvRecetaProducto.TabIndex = 8;
            this.dgvRecetaProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecetaProducto_CellClick);
            // 
            // cnIDProducto
            // 
            this.cnIDProducto.FillWeight = 102.3199F;
            this.cnIDProducto.HeaderText = "IdProducto";
            this.cnIDProducto.Name = "cnIDProducto";
            this.cnIDProducto.ReadOnly = true;
            // 
            // cnProducto
            // 
            this.cnProducto.FillWeight = 181.5006F;
            this.cnProducto.HeaderText = "Producto";
            this.cnProducto.Name = "cnProducto";
            this.cnProducto.ReadOnly = true;
            // 
            // cnCantidad
            // 
            this.cnCantidad.FillWeight = 58.84423F;
            this.cnCantidad.HeaderText = "Cantidad";
            this.cnCantidad.Name = "cnCantidad";
            this.cnCantidad.ReadOnly = true;
            // 
            // cnUniMedida
            // 
            this.cnUniMedida.FillWeight = 69.41505F;
            this.cnUniMedida.HeaderText = "Uni Medida";
            this.cnUniMedida.Name = "cnUniMedida";
            this.cnUniMedida.ReadOnly = true;
            // 
            // cnEliminar
            // 
            this.cnEliminar.FillWeight = 43.74575F;
            this.cnEliminar.HeaderText = "Eliminar";
            this.cnEliminar.Name = "cnEliminar";
            this.cnEliminar.ReadOnly = true;
            this.cnEliminar.Text = "X";
            this.cnEliminar.UseColumnTextForButtonValue = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(477, 193);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 61);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(477, 126);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 61);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.Maroon;
            this.lb1.Location = new System.Drawing.Point(603, 151);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(21, 15);
            this.lb1.TabIndex = 12;
            this.lb1.Text = "F1";
            this.lb1.Visible = false;
            // 
            // frmReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 524);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvRecetaProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvProductoPrimo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBuscar);
            this.Name = "frmReceta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".::Receta de Producto::.";
            this.Load += new System.EventHandler(this.frmReceta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoPrimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetaProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvProductoPrimo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvRecetaProducto;
        public System.Windows.Forms.Label lblProducto;
        public System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnUniMedida;
        private System.Windows.Forms.DataGridViewButtonColumn cnEliminar;
        private System.Windows.Forms.Label lb1;
    }
}