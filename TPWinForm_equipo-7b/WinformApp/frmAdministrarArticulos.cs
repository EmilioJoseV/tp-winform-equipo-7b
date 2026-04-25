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
            listaArticulos = articuloNegocio.Listar();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarArticulos(listaArticulos);
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
                CargarImagen(seleccionado.Imagenes.Count > 0 ? seleccionado.Imagenes[0].ImagenUrl : null);
            }
        }

        private void CargarArticulos(List<Articulo> articulos)
        {
            try
            {
                dgvArticulo.DataSource = null;
                dgvArticulo.DataSource = articulos;

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
                        CargarImagen(listaArticulos[0].Imagenes[0].ImagenUrl);
                    }
                    else
                    {
                        CargarPlaceholder();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                if (!string.IsNullOrEmpty(imagen))
                    pcbxArticulos.Load(imagen);
                else
                    CargarPlaceholder();
            }
            catch (Exception)
            {
                CargarPlaceholder();
            }
        }

        private void CargarPlaceholder()
        {
            pcbxArticulos.Load("https://redthread.uoregon.edu/files/original/affd16fd5264cab9197da4cd1a996f820e601ee4.png");
        }

      
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            CargarArticulosConFiltros();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;

            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            CargarArticulosConFiltros();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {         
            CargarArticulosConFiltros();
        }

        private void CargarArticulosConFiltros()
        {
            try
            {
                if (cboCampo.SelectedIndex < 0)
                {
                    CargarArticulos(articuloNegocio.Listar());
                    return;
                }

                if (cboCriterio.SelectedIndex < 0)
                {
                    MessageBox.Show("Ingrese un criterio");
                    return;
                }

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = cboFiltro.Text;

                CargarArticulos(articuloNegocio.Listar(campo, criterio, filtro));
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
            CargarArticulosConFiltros();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Pedir confirmacioon para eliminar
            DialogResult dialogResult = MessageBox.Show("Seguro de eliminar...?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                Articulo articuloSeleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                articuloNegocio.Eliminar(articuloSeleccionado);
                CargarArticulosConFiltros();
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            frmDetalleArticulo frmDetalleArticulo = new frmDetalleArticulo(articuloSeleccionado);
            frmDetalleArticulo.ShowDialog();
        }

        private void pcbxArticulos_Click(object sender, EventArgs e)
        {

        }

        private void cboFiltroRapido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> articulosFiltroRapido = new List<Articulo>();

            if (txtFiltroRapido.Text.Length >= 3)
            {
                articulosFiltroRapido = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(txtFiltroRapido.Text.ToUpper())
                || x.Codigo.ToUpper().Contains(txtFiltroRapido.Text.ToUpper())
                || x.Descripcion.ToUpper().Contains(txtFiltroRapido.Text.ToUpper())
                || x.Marca.Descripcion.ToUpper().Contains(txtFiltroRapido.Text.ToUpper())
                || x.Categoria.Descripcion.ToUpper().Contains(txtFiltroRapido.Text.ToUpper()));

                CargarArticulos(articulosFiltroRapido);
            } else
            {
                CargarArticulos(listaArticulos);
            }
        }
    }
}
