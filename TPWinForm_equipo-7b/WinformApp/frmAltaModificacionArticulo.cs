using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinformApp
{
    public partial class frmAltaModificacionArticulo : Form
    {
        private Articulo Articulo = null;
        private readonly ArticuloNegocio ArticuloNegocio = new ArticuloNegocio();

        public frmAltaModificacionArticulo()
        {
            InitializeComponent();
        }

        public frmAltaModificacionArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.Articulo = articulo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
               if(this.Articulo == null)
                {
                    //Si es creacion de Articulo crear nuevo Articulo y poblarlo con datos del formulario
                    Articulo = new Articulo();
                    PoblarArticulo();
                    ArticuloNegocio.Crear(Articulo);
                    MessageBox.Show("Articulo creado exitosamente");
                    Close();
                }
                else
                {
                    //Si es actualizacion de Articulo poblar Articulo con datos del formulario y actualizarlo
                    PoblarArticulo();
                    ArticuloNegocio.Actualizar(Articulo);
                    MessageBox.Show("Articulo modificado exitosamente");
                    Close();
                }


                List<Imagen> imagenes = new List<Imagen>();
                
                foreach (var item in listboxImagenesUrl.Items)
                {
                    imagenes.Add(new Imagen { ImagenUrl = item.ToString() });
                }

                Articulo.Imagenes = imagenes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void PoblarArticulo()
        {
            Articulo.Codigo = txtCodigo.Text;
            Articulo.Nombre = txtNombre.Text;
            Articulo.Descripcion = txtDescripcion.Text;
            Articulo.Marca = (Marca)cmbxMarca.SelectedItem;
            Articulo.Categoria = (Categoria)cmbxCategoria.SelectedItem;
            Articulo.Precio = float.Parse(txtPrecio.Text);
            
            //Poblar imagenes
            Articulo.Imagenes = new List<Imagen>();
            
            foreach (var item in listboxImagenesUrl.Items)
            {
                Articulo.Imagenes.Add(new Imagen { ImagenUrl = item.ToString() });
            }
    }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                //Creacion y modificacion de Articulo
                cmbxCategoria.DataSource = categoriaNegocio.Listar();
                cmbxCategoria.ValueMember = "Id";
                cmbxCategoria.DisplayMember = "Descripcion";
                cmbxCategoria.SelectedValue = -1;

                cmbxMarca.DataSource = marcaNegocio.Listar();
                cmbxMarca.ValueMember = "Id";
                cmbxMarca.DisplayMember = "Descripcion";
                cmbxMarca.SelectedValue = -1;

                //Cargar imagenes
                if (Articulo != null && Articulo.Imagenes != null && Articulo.Imagenes.Count > 0)
                {
                    cargarImagen(Articulo.Imagenes[0].ImagenUrl);
                    
                    foreach (var imagen in Articulo.Imagenes)
                    {
                        listboxImagenesUrl.Items.Add(imagen.ImagenUrl);
                    }
                }
                else
                {
                    CargarPlaceHolderImagen();
                }


                if (this.Articulo != null)
                {
                    //Si es actualizacion de Articulo poblar campos con datos del Articulo
                    txtCodigo.Text = Articulo.Codigo.ToString();
                    txtNombre.Text = Articulo.Nombre;
                    txtDescripcion.Text = Articulo.Descripcion;
                    txtPrecio.Text = Articulo.Precio.ToString();
                    cmbxCategoria.SelectedValue = Articulo.Categoria.Id;
                    cmbxMarca.SelectedValue = Articulo.Marca.Id;
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

        private void btnQuitarImagen_Click(object sender, EventArgs e)
        {
            if (listboxImagenesUrl.SelectedItem != null)
            {
                listboxImagenesUrl.Items.Remove(listboxImagenesUrl.SelectedItem);
                
                if (listboxImagenesUrl.Items.Count > 0)
                {
                    cargarImagen(listboxImagenesUrl.Items[0].ToString());
                }
                else
                {
                    CargarPlaceHolderImagen();
                }
            }

        }
    }
}
