using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WinformApp
{
    public partial class frmAppPrincipal : Form
    {
        private List<Articulo> listaArticulos;
        public frmAppPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listar();
            dgvArticulo.DataSource = listaArticulos;
//            dgvArticulo.Columns["Imagen"].Visible = false;
            pcbxArticulos.Load(listaArticulos[0].Imagenes[0].ImagenUrl);
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulo.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagenes?[0]?.ImagenUrl);
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

        private void pcbxArticulos_Click(object sender, EventArgs e)
        {

        }
    }
}
