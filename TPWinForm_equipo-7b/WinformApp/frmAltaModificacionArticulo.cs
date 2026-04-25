using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinformApp
{
    public partial class frmAltaModificacionArticulo : Form
    {
        private Articulo articulo = null;
        private ArticuloNegocio articuloNegocio;

        public frmAltaModificacionArticulo()
        {
            InitializeComponent();
        }

        public frmAltaModificacionArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();

            try
            {
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cmbxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cmbxCategoria.SelectedItem;
                articulo.Precio = float.Parse(txtPrecio.Text);

                List<Imagen> imagenes = new List<Imagen>();
                foreach (var item in listboxImagenesUrl.Items)
                {
                    imagenes.Add(new Imagen { ImagenUrl = item.ToString() });
                }
                articulo.Imagenes = imagenes;

                articuloNegocio.Crear(articulo);

                MessageBox.Show("Agregado Exitosamente");
                Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                if (this.articulo == null)
                {
                    //Crear articulo
                    cmbxMarca.DataSource = marcaNegocio.Listar();
                    cmbxMarca.ValueMember = "Id";
                    cmbxMarca.DisplayMember = "Descripcion";

                    cmbxCategoria.DataSource = categoriaNegocio.Listar();
                    cmbxCategoria.ValueMember = "Id";
                    cmbxCategoria.DisplayMember = "Descripcion";
                }
                else
                {
                    //Actualizar articulo
                    txtCodigo.Text = articulo.Codigo.ToString();
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();

                    if (articulo.Imagenes != null && articulo.Imagenes.Count > 0)
                    {
                        cargarImagen(articulo.Imagenes[0].ImagenUrl);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(imagen))
                {
                    pcbxImagen.Load(imagen);
                }
                else
                {
                    CargarPlaceHolderImagen();
                }
            }
            catch (Exception)
            {
                CargarPlaceHolderImagen();
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            listboxImagenesUrl.Items.Add(txtImagenUrl.Text);
            txtImagenUrl.Text = "";
        }

        private void listboxImagenesUrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxImagenesUrl.SelectedItem != null)
            {
                cargarImagen(listboxImagenesUrl.SelectedItem.ToString());
            }
        }

        private void CargarPlaceHolderImagen()
        {
            pcbxImagen.Load("https://redthread.uoregon.edu/files/original/affd16fd5264cab9197da4cd1a996f820e601ee4.png");
        }

        private void btnVistaPrev_Click(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }
    }
}
