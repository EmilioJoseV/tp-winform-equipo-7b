using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionArticulosCatalogoApp
{
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listar();
            dgvArticulo.DataSource = listaArticulos;
            dgvArticulo.Columns["Imagenes"].Visible = false;
            pcbxArticulos.Load(listaArticulos[0].Imagenes.ImagenUrl);
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulo.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagenes?.ImagenUrl);
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
    }
}
