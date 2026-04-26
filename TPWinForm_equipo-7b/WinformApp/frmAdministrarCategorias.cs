using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WinformApp
{
    public partial class frmAdministrarCategorias : Form
    {
        public frmAdministrarCategorias()
        {
            InitializeComponent();
        }
        
        private void frmAdministrarCategorias_Load(object sender, EventArgs e)
        {
            Cargar();

        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaCategorias alta = new FrmAltaCategorias();
            alta.ShowDialog();
            Cargar();
        }


        private void Cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                List<Categoria> ListaCategorias = negocio.Listar();
                dgvCategorias.DataSource = ListaCategorias;

                if (dgvCategorias.Columns["ImagenUrl"] != null)
                    dgvCategorias.Columns["ImagenUrl"].Visible = false;

                if (dgvCategorias.Columns["IdMarca"] != null)
                    dgvCategorias.Columns["IdMarca"].Visible = false;

                if (dgvCategorias.Columns["IdCategoria"] != null)
                    dgvCategorias.Columns["IdCategoria"].Visible = false;



                if (dgvCategorias.Columns["Id"] != null)
                    dgvCategorias.Columns["Id"].Visible = false;




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una categoría de la lista para modificar.");
                return; 
            }
            try
            {
                Categoria seleccionado;
                seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

                FrmAltaCategorias modificar = new FrmAltaCategorias(seleccionado);
                modificar.ShowDialog();
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar modificar: " + ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                if (dgvCategorias.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, seleccione una categoría de la grilla para eliminar.");
                    return;
                }

                Categoria seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

                DialogResult respuesta = MessageBox.Show("¿Seguro desea esta categoría?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    negocio.EliminarCategoria(seleccionado);
                    MessageBox.Show("Eliminado correctamente.");
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
