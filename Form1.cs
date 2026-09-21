using System.Drawing.Imaging;
using System.Windows.Forms;

namespace EjemploSProyBD
{
    public partial class Form1 : Form
    {
        private List<Producto> listaProductos;
        private Dictionary<string, object> myProducto = new Dictionary<string, object>();
        private int idSeleccionado = 0;
        int idProducto;
        bool todoOk = true;
        List<(TextBox txt, IValidatorCampo validador)> camposValidar = new();

        public Form1()
        {
            InitializeComponent();
            listaProductos = new List<Producto>();
            dgvProductos.Columns.Add("id", "ID");
            dgvProductos.Columns.Add("Producto", "Producto");
            dgvProductos.Columns.Add("Precio", "Precio");
            dgvProductos.Columns.Add("Cantidad", "Cantidad");

            DataGridViewImageColumn imagenColumn = new DataGridViewImageColumn();
            imagenColumn.Name = "Imagen";
            imagenColumn.HeaderText = "Imagen";
            imagenColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvProductos.Columns.Add(imagenColumn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void cargarProductos(string filtro = "")
        {
            dgvProductos.Rows.Clear();
            listaProductos = Conexion.GetProductos(filtro);

            foreach (var prod in listaProductos)
            {
                Image img = null;
                if (prod.Imagen != null && prod.Imagen.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(prod.Imagen))
                    {
                        using (Bitmap bmp = new Bitmap(ms))
                        {
                            img = new Bitmap(bmp);
                        }
                    }
                }
                dgvProductos.Rows.Add(prod.Id, prod.Nombre, prod.Precio, prod.Cantidad, img);
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            cargarProductos(txtBusqueda.Text.Trim());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccionar imagen del producto";
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private bool datosCorrectos()
        {
            camposValidar.Add((txtNombre, new ValidadorTexto()));
            camposValidar.Add((txtPrecio, new ValidadorDecimal()));
            camposValidar.Add((txtCantidad, new ValidadorEntero()));

            foreach (var item in camposValidar)
            {
                if (!item.validador.EsValido(item.txt.Text))
                {
                    errorProvider1.SetError(item.txt, item.validador.MensajeError);
                    todoOk = false;
                    break;
                }
                else
                {
                    errorProvider1.SetError(item.txt, string.Empty);
                    todoOk = true;
                }
            }
            return todoOk;
        }

        private void CargarDatosProductos()
        {
            myProducto.Clear();
            myProducto["nombre"] = txtNombre.Text.Trim();
            myProducto["precio"] = decimal.Parse(txtPrecio.Text.Trim());
            myProducto["cantidad"] = int.Parse(txtCantidad.Text.Trim());
            myProducto["imagen"] = ImageToByteArray(pictureBox1.Image);
        }

        private byte[] ImageToByteArray(Image image)
        {
            if (image == null) return null;

            using (MemoryStream mMemoryStream = new MemoryStream())
            {
                image.Save(mMemoryStream, ImageFormat.Png);
                return mMemoryStream.ToArray();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos()) return;

            CargarDatosProductos();

            if (Conexion.InsertSeguro("productos", myProducto))
            {
                MessageBox.Show("Se ha guardado satisfactoriamente el registro");
                limpiarCampos();
                cargarProductos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto de la lista primero");
                return;
            }
            if (!datosCorrectos()) return;

            CargarDatosProductos();

            if (Conexion.UpdateSeguro(idSeleccionado, myProducto))
            {
                MessageBox.Show("Se ha modificado el registro");
                limpiarCampos();
                cargarProductos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto de la lista primero");
                return;
            }

            if (MessageBox.Show("¿Seguro que desea eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Conexion.EliminarProducto(idSeleccionado))
                {
                    MessageBox.Show("Producto eliminado");
                    limpiarCampos();
                    cargarProductos();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            pictureBox1.Image = null;
            idSeleccionado = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(row.Cells["id"].Value);
                txtNombre.Text = row.Cells["Producto"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
                txtCantidad.Text = row.Cells["Cantidad"].Value.ToString();

                if (row.Cells["Imagen"].Value != null && row.Cells["Imagen"].Value != DBNull.Value)
                {
                    pictureBox1.Image = (Image)row.Cells["Imagen"].Value;
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }
    }
}
