namespace Proyecto_CRUD_Basico.Forms
{
    partial class CategoriaForms
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
            npdId = new NumericUpDown();
            txtNombre = new TextBox();
            chkActivo = new CheckBox();
            dataGridView1 = new DataGridView();
            btnGuardar = new Button();
            btnActualizarTabla = new Button();
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
            lblId.Location = new Point(12, 50);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 17);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblNombre.Location = new Point(149, 49);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(61, 17);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // npdId
            // 
            npdId.Location = new Point(12, 70);
            npdId.Name = "npdId";
            npdId.Size = new Size(120, 23);
            npdId.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(149, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(148, 23);
            txtNombre.TabIndex = 4;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(322, 69);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 5;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 161);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(437, 240);
            dataGridView1.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(40, 117);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizarTabla
            // 
            btnActualizarTabla.Location = new Point(353, 12);
            btnActualizarTabla.Name = "btnActualizarTabla";
            btnActualizarTabla.Size = new Size(101, 23);
            btnActualizarTabla.TabIndex = 8;
            btnActualizarTabla.Text = "Actualizar Tabla";
            btnActualizarTabla.UseVisualStyleBackColor = true;
            btnActualizarTabla.Click += btnActualizarTabla_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(121, 117);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(202, 117);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(283, 117);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(364, 117);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // CategoriaForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 413);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(btnActualizarTabla);
            Controls.Add(btnGuardar);
            Controls.Add(dataGridView1);
            Controls.Add(chkActivo);
            Controls.Add(txtNombre);
            Controls.Add(npdId);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Name = "CategoriaForms";
            Text = "CategoriaForms";
            ((System.ComponentModel.ISupportInitialize)npdId).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNombre;
        private Label lblActivo;
        private NumericUpDown npdId;
        private TextBox txtNombre;
        private CheckBox chkActivo;
        private DataGridView dataGridView1;
        private Button btnGuardar;
        private Button btnActualizarTabla;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
    }
}