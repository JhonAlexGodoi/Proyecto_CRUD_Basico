using Proyecto_CRUD_Basico.Controllers;
using Proyecto_CRUD_Basico.Model.Entities;
using Proyecto_CRUD_Basico.Model.Services;

namespace Proyecto_CRUD_Basico.Forms
{
    public partial class UserForms : Form
    {
        private readonly UserServices _userServices;
        private readonly UserControllers _userControllers;

        public UserForms()
        {
            InitializeComponent();
            _userServices = new UserServices();
            _userControllers = new UserControllers();
        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            var newUser = new User()
            {
                Id = Convert.ToInt32(npdId.Value),
                Nombre = txtNombre.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                IsActive = chkActivo.Checked,
            };

            bool result = _userControllers.CreateUser(newUser);

            if (result)
            {
                MessageBox.Show("Usuario creado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = null; // ← Limpia la tabla
                dataGridView1.DataSource = _userControllers.GetAllUsers(); // ← Asigna la nueva lista
                dataGridView1.Refresh(); // ← Refresca

            }
            else
            {
                MessageBox.Show("Contraseña muy debil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (npdId.Value > 0) // Asegurarse de que el valor del NumericUpDown sea válido
            {
                int userToSearch = (int)npdId.Value;

                // Llamar a tu servicio para obtener el usuario por ID
                User usuarioEncontrado = _userControllers.GetUserById(userToSearch);

                if (usuarioEncontrado != null)
                {
                    // Crear una nueva lista que contenga solo el usuario encontrado
                    List<User> listaUsuarioEncontrado = new List<User>();
                    listaUsuarioEncontrado.Add(usuarioEncontrado);

                    // Asignar esta nueva lista como DataSource del DataGridView
                    dataGridView1.DataSource = null; // Limpiar el DataSource anterior
                    dataGridView1.DataSource = listaUsuarioEncontrado;
                    dataGridView1.Refresh();
                }
                else
                {
                    // Mostrar un mensaje si no se encontró ningún usuario con ese ID
                    MessageBox.Show($"No se encontró ningún usuario con el ID: {userToSearch}", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Opcional: Puedes limpiar el DataGridView si no se encuentra el usuario
                    dataGridView1.DataSource = null;
                }
            }
            else
            {
                // Mostrar un mensaje si el ID ingresado no es válido
                MessageBox.Show("Por favor, ingrese un ID válido para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            npdId.Value = 0;
            chkActivo.Checked = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var userToUpdate = new User()
            {
                Id = Convert.ToInt32(npdId.Value),
                Nombre = txtNombre.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                IsActive = chkActivo.Checked
            };

            bool result = _userServices.UpdateUser(userToUpdate);

            if (!result)
            {
                MessageBox.Show("Usuario actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _userControllers.GetAllUsers();
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarTabla_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // ← Limpia la tabla
            dataGridView1.DataSource = _userControllers.GetAllUsers(); // ← Asigna la nueva lista
            dataGridView1.Refresh(); // ← Refresca
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int userToDelete = (int)npdId.Value;

            if (userToDelete <= 0)
            {
                MessageBox.Show("Por favor, ingrese un ID válido para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show($"¿Estás seguro de eliminar el usuario con ID {userToDelete}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                bool resultado = _userControllers.DeleteUser(userToDelete);

                if (resultado)
                {
                    MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = _userControllers.GetAllUsers();
                    dataGridView1.Refresh();
                    btnLimpiar.PerformClick(); // Opcional: limpia campos después de borrar
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gestionarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formularioProductos = new ProductoForms();
            formularioProductos.Show(); // o .ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formularioCategoria = new CategoriaForms();
            formularioCategoria.Show(); // o .ShowDialog();
        }
    }

}
