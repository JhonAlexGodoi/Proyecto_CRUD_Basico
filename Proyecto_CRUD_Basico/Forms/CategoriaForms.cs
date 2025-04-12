using Proyecto_CRUD_Basico.Controllers;
using Proyecto_CRUD_Basico.Model.Entities;

namespace Proyecto_CRUD_Basico.Forms
{
    public partial class CategoriaForms : Form
    {
        private readonly CategoriaControllers _categoriaController;
        public CategoriaForms()
        {
            InitializeComponent();
            _categoriaController = new CategoriaControllers();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var newCategoria = new Categoria()
            {
                //Id = Convert.ToInt32(npdId.Value),
                Nombre = txtNombre.Text,
                IsActive = chkActivo.Checked,
            };
            bool result = _categoriaController.CreateCategoria(newCategoria);
            if (result)
            {
                MessageBox.Show("Categoria creada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = null; // ← Limpia la tabla
                dataGridView1.DataSource = _categoriaController.GetAllCategorias(); // ← Asigna la nueva lista
                dataGridView1.Refresh(); // ← Refresca
            }
            else
            {
                MessageBox.Show("Error al crear la categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (npdId.Value > 0) // Asegurarse de que el valor del NumericUpDown sea válido
            {
                int categoriaToSearch = (int)npdId.Value;
                var categoria = _categoriaController.GetCategoriaById(categoriaToSearch);
                if (categoria != null)
                {
                    txtNombre.Text = categoria.Nombre;
                    chkActivo.Checked = categoria.IsActive;
                }
                else
                {
                    MessageBox.Show("Categoria no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var newCategoria = new Categoria()
            {
                Id = Convert.ToInt32(npdId.Value),
                Nombre = txtNombre.Text,
                IsActive = chkActivo.Checked,
            };
            bool result = _categoriaController.UpdateCategoria(newCategoria);
            if (result)
            {
                MessageBox.Show("Categoria actualizda con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = null; // ← Limpia la tabla
                dataGridView1.DataSource = _categoriaController.GetAllCategorias(); // ← Asigna la nueva lista
                dataGridView1.Refresh(); // ← Refresca
            }
            else
            {
                MessageBox.Show("Error al actualizar la categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (npdId.Value > 0) // Asegurarse de que el valor del NumericUpDown sea válido
            {
                int categoriaToDelete = (int)npdId.Value;
                var categoria = _categoriaController.GetCategoriaById(categoriaToDelete);
                if (categoria != null)
                {
                    _categoriaController.DeleteCategoria(categoriaToDelete);
                    MessageBox.Show("Categoria eliminada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Categoria no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            npdId.TextAlign = 0;
            txtNombre.Text = string.Empty;
            chkActivo.Checked = false;
        }

        private void btnActualizarTabla_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // ← Limpia la tabla
            dataGridView1.DataSource = _categoriaController.GetAllCategorias(); // ← Asigna la nueva lista
            dataGridView1.Refresh(); // ← Refresca
        }
    }


}
