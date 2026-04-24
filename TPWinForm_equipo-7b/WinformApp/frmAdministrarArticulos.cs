using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinformApp
{
    public partial class frmAdministrarArticulos : Form
    {
        private ArticuloNegocio articuloNegocio;
        private List<Articulo> listaArticulos;

        public frmAdministrarArticulos()
        {
            articuloNegocio = new ArticuloNegocio();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();
            //Precargar opciones de filtrado
            cboCampo.Items.Add("Codigo");
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripcion");
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulo.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagenes.Count > 0 ? seleccionado.Imagenes[0].ImagenUrl : null);
            }
        }

        private void Cargar()
        {
            try
            {
                if(listaArticulos == null)
                    listaArticulos = articuloNegocio.Listar();

                dgvArticulo.DataSource = listaArticulos;

                if (dgvArticulo.Columns["ImagenUrl"] != null)
                    dgvArticulo.Columns["ImagenUrl"].Visible = false;

                if (dgvArticulo.Columns["IdMarca"] != null)
                    dgvArticulo.Columns["IdMarca"].Visible = false;

                if (dgvArticulo.Columns["IdCategoria"] != null)
                    dgvArticulo.Columns["IdCategoria"].Visible = false;

                if (dgvArticulo.Columns["Id"] != null)
                    dgvArticulo.Columns["Id"].Visible = false;

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
            Cargar();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;

            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            Cargar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {         
            try
            {
                if(cboCampo.SelectedIndex < 0)
                {
                   listaArticulos = articuloNegocio.Listar();
                   Cargar();
                   return;
                }

                if(cboCriterio.SelectedIndex < 0)
                {
                    MessageBox.Show("Ingrese un criterio");
                    return;
                }

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = cboFiltro.Text;

                listaArticulos  = articuloNegocio.ListarConFiltros(campo, criterio, filtro);
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( cboCampo.SelectedIndex < 0)
            {
                cboCriterio.Items.Clear();
                cboFiltro.Text = "";
                return;
            }

            string opcion = cboCampo.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                // Aca colocamos la lógica para filtrar por codigo
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor que");
                cboCriterio.Items.Add("Menor que");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }
        private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
    
        }

        private void dgvArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            cboCampo.SelectedIndex = -1;
            cboCriterio.SelectedIndex = -1;
            cboFiltro.Text = "";
            Cargar();
        }
    }
}
