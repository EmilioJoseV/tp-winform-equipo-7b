using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WinformApp
{
    public partial class frmAdministrarArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public frmAdministrarArticulos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*ArticuloNegocio negocio = new ArticuloNegocio();
             try
             {
                 listaArticulos = negocio.Listar();
                 dgvArticulo.DataSource = listaArticulos;
                 //dgvArticulo.Columns["Imagen"].Visible = false;
                 //pcbxArticulos.Load(listaArticulos[0].Imagenes[0].ImagenUrl);
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());

             }

             */

            cargar();
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulo.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagenes.Count > 0 ? seleccionado.Imagenes[0].ImagenUrl : null);
            }
        }



        /*private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.Listar();
                dgvArticulo.DataSource = listaArticulos;
                dgvArticulo.Columns["ImagenUrl"].Visible = false;
                pcbxArticulos.Load(listaArticulos[0].Imagenes[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }*/
        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.Listar();
                dgvArticulo.DataSource = listaArticulos;

                if (dgvArticulo.Columns["Imagenes"] != null)
                    dgvArticulo.Columns["Imagenes"].Visible = false;

                if (dgvArticulo.Columns["IdMarca"] != null)
                    dgvArticulo.Columns["IdMarca"].Visible = false;

                if (dgvArticulo.Columns["IdCategoria"] != null)
                    dgvArticulo.Columns["IdCategoria"].Visible = false;

                if (listaArticulos != null && listaArticulos.Count > 0)
                {
                    if (listaArticulos[0].Imagenes != null && listaArticulos[0].Imagenes.Count > 0)
                    {
                        cargarImagen(listaArticulos[0].Imagenes[0].ImagenUrl);
                    }
                    else
                    {
                        cargarPlaceholder();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                if (!string.IsNullOrEmpty(imagen))
                    pcbxArticulos.Load(imagen);
                else
                    cargarPlaceholder();
            }
            catch (Exception)
            {
                cargarPlaceholder();
            }
        }

        private void cargarPlaceholder()
        {
            pcbxArticulos.Load("https://redthread.uoregon.edu/files/original/affd16fd5264cab9197da4cd1a996f820e601ee4.png");
        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        

        
    }
}
