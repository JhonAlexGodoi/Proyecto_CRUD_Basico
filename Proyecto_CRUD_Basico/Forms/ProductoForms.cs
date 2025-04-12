using Proyecto_CRUD_Basico.Controllers;
using Proyecto_CRUD_Basico.Model.Entities;
using Proyecto_CRUD_Basico.Model.Services;

namespace Proyecto_CRUD_Basico.Forms
{
    public partial class ProductoForms : Form
    {
        private readonly ProductoServices _productoServices;
        private readonly ProductoControllers _productoController;

        public ProductoForms()
        {
            InitializeComponent();
            _productoServices = new ProductoServices();
            _productoController = new ProductoControllers();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            var newProducto = new Producto()
            {
                Id = Convert.ToInt32(npdId.Value),
                Nombre = txtNombre.Text,
                CodigoBarra = txtCodigoBarra.Text,
                Descripcion = rtxtDescripcion.Text,
                Precio = Convert.ToInt32(txtPrecio.Text),
                Categoria = cmbCategoria.Text,
                Stock = Convert.ToInt32(txtStock.Text),
            };
            bool result = _productoController.CreateProducto(newProducto);

            if (result)
            {
                MessageBox.Show("Producto creado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = null; // ← Limpia la tabla
                dataGridView1.DataSource = _productoController.GetAllProductos(); // ← Asigna la nueva lista
                dataGridView1.Refresh(); // ← Refresca
            }
            else
            {
                MessageBox.Show("Error al crear el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (npdId.Value > 0) // Asegurarse de que el valor del NumericUpDown sea válido
            {
                int productoToSearch = (int)npdId.Value;
                var producto = _productoController.GetProductoById(productoToSearch);
                if (producto != null)
                {
                    txtNombre.Text = producto.Nombre;
                    txtCodigoBarra.Text = producto.CodigoBarra;
                    rtxtDescripcion.Text = producto.Descripcion;
                    txtPrecio.Text = producto.Precio.ToString();
                    cmbCategoria.Text = producto.Categoria;
                    txtStock.Text = producto.Stock.ToString();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var updatedProducto = new Producto()
            {
                Id = Convert.ToInt32(npdId.Value),
                Nombre = txtNombre.Text,
                CodigoBarra = txtCodigoBarra.Text,
                Descripcion = rtxtDescripcion.Text,
                Precio = Convert.ToInt32(txtPrecio.Text),
                Categoria = cmbCategoria.Text,
                Stock = Convert.ToInt32(txtStock.Text),
            };
            bool result = _productoController.UpdateProducto(updatedProducto);
            if (result)
            {
                MessageBox.Show("Producto actualizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = null; // ← Limpia la tabla
                dataGridView1.DataSource = _productoController.GetAllProductos(); // ← Asigna la nueva lista
                dataGridView1.Refresh(); // ← Refresca
            }
            else
            {
                MessageBox.Show("Error al actualizar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (npdId.Value > 0) // Asegurarse de que el valor del NumericUpDown sea válido
            {
                int productoToDelete = (int)npdId.Value;
                bool result = _productoController.DeleteProducto(productoToDelete);
                if (result)
                {
                    MessageBox.Show("Producto eliminado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null; // ← Limpia la tabla
                    dataGridView1.DataSource = _productoController.GetAllProductos(); // ← Asigna la nueva lista
                    dataGridView1.Refresh(); // ← Refresca
                }
                else
                {
                    MessageBox.Show("Error al eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            npdId.Value = 0;
            txtNombre.Clear();
            txtCodigoBarra.Clear();
            rtxtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbCategoria.Text = string.Empty;

        }

        private void btnActualizarTabla_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // ← Limpia la tabla
            dataGridView1.DataSource = _productoController.GetAllProductos();
            dataGridView1.Refresh(); // ← Refresca
        }
    }
}
