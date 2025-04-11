namespace Proyecto_CRUD_Basico.Forms
{
    partial class UserForms
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
            chkActivo = new CheckBox();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            btnGuardar = new Button();
            npdId = new NumericUpDown();
            dataGridView1 = new DataGridView();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnActualizarTabla = new Button();
            menuStrip1 = new MenuStrip();
            gestionarProductosToolStripMenuItem = new ToolStripMenuItem();
            gestionarCategoriaToolStripMenuItem = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)npdId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblId.Location = new Point(14, 50);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 17);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblNombre.Location = new Point(176, 50);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(61, 17);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            chkActivo.Location = new Point(14, 191);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(65, 21);
            chkActivo.TabIndex = 2;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(176, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(461, 25);
            txtNombre.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(14, 153);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(295, 25);
            txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblEmail.Location = new Point(14, 133);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(43, 17);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(326, 153);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(272, 25);
            txtPassword.TabIndex = 8;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblPassword.Location = new Point(326, 133);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(69, 17);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password:";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnGuardar.Location = new Point(40, 232);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 42);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // npdId
            // 
            npdId.Location = new Point(14, 70);
            npdId.Name = "npdId";
            npdId.Size = new Size(137, 25);
            npdId.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 297);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(652, 240);
            dataGridView1.TabIndex = 11;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnBuscar.Location = new Point(154, 232);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 42);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnModificar.Location = new Point(266, 232);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 42);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnEliminar.Location = new Point(384, 232);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 42);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnLimpiar.Location = new Point(504, 232);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 42);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnActualizarTabla
            // 
            btnActualizarTabla.Location = new Point(553, 12);
            btnActualizarTabla.Name = "btnActualizarTabla";
            btnActualizarTabla.Size = new Size(126, 36);
            btnActualizarTabla.TabIndex = 16;
            btnActualizarTabla.Text = "Actualizar Tabla";
            btnActualizarTabla.UseVisualStyleBackColor = true;
            btnActualizarTabla.Click += btnActualizarTabla_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionarProductosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(691, 24);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestionarProductosToolStripMenuItem
            // 
            gestionarProductosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionarCategoriaToolStripMenuItem, categoriaToolStripMenuItem });
            gestionarProductosToolStripMenuItem.Name = "gestionarProductosToolStripMenuItem";
            gestionarProductosToolStripMenuItem.Size = new Size(69, 20);
            gestionarProductosToolStripMenuItem.Text = "Gestionar";
            // 
            // gestionarCategoriaToolStripMenuItem
            // 
            gestionarCategoriaToolStripMenuItem.Name = "gestionarCategoriaToolStripMenuItem";
            gestionarCategoriaToolStripMenuItem.Size = new Size(180, 22);
            gestionarCategoriaToolStripMenuItem.Text = "Productos";
            gestionarCategoriaToolStripMenuItem.Click += gestionarCategoriaToolStripMenuItem_Click;
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(180, 22);
            categoriaToolStripMenuItem.Text = "Categoria";
            categoriaToolStripMenuItem.Click += categoriaToolStripMenuItem_Click;
            // 
            // UserForms
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 549);
            Controls.Add(btnActualizarTabla);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(dataGridView1);
            Controls.Add(npdId);
            Controls.Add(btnGuardar);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtNombre);
            Controls.Add(chkActivo);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Name = "UserForms";
            Text = "Gestion de Usuarios";
            ((System.ComponentModel.ISupportInitialize)npdId).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNombre;
        private CheckBox chkActivo;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnGuardar;
        private NumericUpDown npdId;
        private DataGridView dataGridView1;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnActualizarTabla;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestionarProductosToolStripMenuItem;
        private ToolStripMenuItem gestionarCategoriaToolStripMenuItem;
        private ToolStripMenuItem categoriaToolStripMenuItem;
    }
}