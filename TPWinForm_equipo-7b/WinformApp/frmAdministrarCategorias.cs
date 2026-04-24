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




    }
}
