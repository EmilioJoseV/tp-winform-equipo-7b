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
    public partial class frmAdministrarMarcas : Form
    {
        public frmAdministrarMarcas()
        {
            InitializeComponent();
        }

        private void frmAdministrarMarcas_Load(object sender, EventArgs e)
           

        {
            cargar();
          
         
            
         
        }



        private void dgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaMarca alta = new FrmAltaMarca();
            alta.ShowDialog();
        }
        private void cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                List<Marca> ListaMarcas = negocio.Listar();
                dgvMarcas.DataSource = ListaMarcas;

                if (dgvMarcas.Columns["ImagenUrl"] != null)
                    dgvMarcas.Columns["ImagenUrl"].Visible = false;

                if (dgvMarcas.Columns["IdMarca"] != null)
                    dgvMarcas.Columns["IdMarca"].Visible = false;

                if (dgvMarcas.Columns["IdCategoria"] != null)
                    dgvMarcas.Columns["IdCategoria"].Visible = false;



                if (dgvMarcas.Columns["Id"] != null)
                    dgvMarcas.Columns["Id"].Visible = false;




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();

           
            try
            {
                if (dgvMarcas.CurrentRow == null)
                {
                    MessageBox.Show("seleccione una opcion para eliminar");
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Seguro quieres eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    Marca marcaSeleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    negocio.eliminar(marcaSeleccionado);
                    cargar();
                   
                }
            }
            catch (Exception ex)
            { 
               MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {


            if (dgvMarcas.CurrentRow == null)
            {
                MessageBox.Show("favor, seleccione una marca de la lista para modificar");
                return;
            }
            try
            {
                Marca seleccionado;
                seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

                FrmAltaMarca modificar = new FrmAltaMarca(seleccionado);
                modificar.ShowDialog();
                cargar();
            }
            catch (Exception ex)

            {

                MessageBox.Show("Ocurrio un intentar modificar" + ex.ToString());
            }



           
        }
        
    }
}
