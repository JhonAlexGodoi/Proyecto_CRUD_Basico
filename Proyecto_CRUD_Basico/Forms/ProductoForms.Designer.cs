namespace Proyecto_CRUD_Basico.Forms
{
    partial class ProductoForms
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
            lblId = new Label();
            lblNombre = new Label();
            lblCodigoBarra = new Label();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            lblCategoria = new Label();
            lblBarra = new Label();
            npdId = new NumericUpDown();
            txtNombre = new TextBox();
            txtCodigoBarra = new TextBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            cmbCategoria = new ComboBox();
            rtxtDescripcion = new RichTextBox();
            dataGridView1 = new DataGridView();
            btnActualizarTabla = new Button();
            btnGuardar = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)npdId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblId.Location = new Point(16, 51);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 17);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblNombre.Location = new Point(189, 51);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(61, 17);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblCodigoBarra
            // 
            lblCodigoBarra.AutoSize = true;
            lblCodigoBarra.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblCodigoBarra.Location = new Point(467, 51);
            lblCodigoBarra.Name = "lblCodigoBarra";
            lblCodigoBarra.Size = new Size(112, 17);
            lblCodigoBarra.TabIndex = 2;
            lblCodigoBarra.Text = "Código de Barras";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblDescripcion.Location = new Point(342, 110);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(77, 17);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripción";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblPrecio.Location = new Point(16, 143);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(45, 17);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblCategoria.Location = new Point(189, 143);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(66, 17);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoría";
            // 
            // lblBarra
            // 
            lblBarra.AutoSize = true;
            lblBarra.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblBarra.Location = new Point(686, 51);
            lblBarra.Name = "lblBarra";
            lblBarra.Size = new Size(41, 17);
            lblBarra.TabIndex = 6;
            lblBarra.Text = "Stock";
            // 
            // npdId
            // 
            npdId.Location = new Point(16, 72);
            npdId.Name = "npdId";
            npdId.Size = new Size(137, 25);
            npdId.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(189, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 25);
            txtNombre.TabIndex = 8;
            // 
            // txtCodigoBarra
            // 
            txtCodigoBarra.Location = new Point(467, 72);
            txtCodigoBarra.Name = "txtCodigoBarra";
            txtCodigoBarra.Size = new Size(189, 25);
            txtCodigoBarra.TabIndex = 9;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(686, 72);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(81, 25);
            txtStock.TabIndex = 10;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(16, 163);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(159, 25);
            txtPrecio.TabIndex = 11;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(189, 163);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 25);
            cmbCategoria.TabIndex = 12;
            // 
            // rtxtDescripcion
            // 
            rtxtDescripcion.Location = new Point(333, 130);
            rtxtDescripcion.Name = "rtxtDescripcion";
            rtxtDescripcion.Size = new Size(394, 58);
            rtxtDescripcion.TabIndex = 13;
            rtxtDescripcion.Text = "";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 255);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(751, 243);
            dataGridView1.TabIndex = 14;
            // 
            // btnActualizarTabla
            // 
            btnActualizarTabla.Location = new Point(653, 12);
            btnActualizarTabla.Name = "btnActualizarTabla";
            btnActualizarTabla.Size = new Size(125, 28);
            btnActualizarTabla.TabIndex = 15;
            btnActualizarTabla.Text = "Actualizar Tabla";
            btnActualizarTabla.UseVisualStyleBackColor = true;
            btnActualizarTabla.Click += btnActualizarTabla_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(96, 194);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 41);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(216, 194);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 41);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(336, 194);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 41);
            btnModificar.TabIndex = 18;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(456, 194);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 41);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(576, 194);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 41);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // ProductoForms
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 510);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(btnGuardar);
            Controls.Add(btnActualizarTabla);
            Controls.Add(dataGridView1);
            Controls.Add(rtxtDescripcion);
            Controls.Add(cmbCategoria);
            Controls.Add(txtPrecio);
            Controls.Add(txtStock);
            Controls.Add(txtCodigoBarra);
            Controls.Add(txtNombre);
            Controls.Add(npdId);
            Controls.Add(lblBarra);
            Controls.Add(lblCategoria);
            Controls.Add(lblPrecio);
            Controls.Add(lblDescripcion);
            Controls.Add(lblCodigoBarra);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Name = "ProductoForms";
            Text = "Gestion de Productos";
            ((System.ComponentModel.ISupportInitialize)npdId).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        // Add the missing event handler method for label6_Click  

        #endregion

        private Label lblId;
        private Label lblNombre;
        private Label lblCodigoBarra;
        private Label lblDescripcion;
        private Label lblPrecio;
        private Label lblCategoria;
        private Label lblBarra;
        private NumericUpDown npdId;
        private TextBox txtNombre;
        private TextBox txtCodigoBarra;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private ComboBox cmbCategoria;
        private RichTextBox rtxtDescripcion;
        private DataGridView dataGridView1;
        private Button btnActualizarTabla;
        private Button btnGuardar;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
    }
}