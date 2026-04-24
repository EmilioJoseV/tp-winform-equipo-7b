using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformApp
{
    public partial class frmDetalleArticulo : Form
    {
        private Dominio.Articulo articulo;
        private int indiceImagen = 0;
        public frmDetalleArticulo(Dominio.Articulo articulo)
        {
            InitializeComponent();
            this.lblIndiceImagenes.Text = "0 / 0";
            this.articulo = articulo;
        }

        private void frmDetalleArticulo_Load(object sender, EventArgs e)
        {
            lblIdTexto.Text = articulo.Id.ToString();
            lblDescripcionTexto.Text = articulo.Descripcion;
            lblCategoriaTexto.Text = articulo.Categoria.Descripcion;
            lblMarcaTexto.Text = articulo.Marca.Descripcion;
            lblCategoriaTexto.Text = articulo.Categoria.Descripcion;
            lblCodigoTexto.Text = articulo.Codigo;
            lblNombreTexto.Text = articulo.Nombre;
            lblPrecioTexto.Text = articulo.Precio.ToString();
            RenderizarImagenes(articulo);
        }

        private void RenderizarImagenes(Articulo articulo)
        {
            if (articulo.Imagenes != null || articulo.Imagenes.Count > 0)
            {
                CargarImagenes();
            } else
            {
                RenderizarPlaceholder();
            }
        }

        private void CargarImagenes()
        {
            try
            {
                pcbxImagenes.Load(articulo.Imagenes[indiceImagen].ImagenUrl);
            }
            catch
            {
                RenderizarPlaceholder();
            }

            lblIndiceImagenes.Text = $"{indiceImagen + 1} / {articulo.Imagenes.Count}";
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void lblImagenes_Click(object sender, EventArgs e)
        {

        }

        private void lblImagenes_Click_1(object sender, EventArgs e)
        {

        }

        private void pbxImagenes_Click(object sender, EventArgs e)
        {

        }
        private void RenderizarPlaceholder()
        {
            pcbxImagenes.Load("https://redthread.uoregon.edu/files/original/affd16fd5264cab9197da4cd1a996f820e601ee4.png");
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (articulo.Imagenes.Count == 0) return;

            indiceImagen--;

            if (indiceImagen < 0)
                indiceImagen = articulo.Imagenes.Count - 1;

            CargarImagenes();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            {
                if (articulo.Imagenes.Count == 0) return;

                indiceImagen++;

                if (indiceImagen >= articulo.Imagenes.Count)
                    indiceImagen = 0;

                CargarImagenes();
            }
        }
    }
}
