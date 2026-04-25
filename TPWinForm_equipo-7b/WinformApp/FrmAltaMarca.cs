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
    public partial class FrmAltaMarca : Form
    {
        private Marca marca = null;


        public FrmAltaMarca()
        {
            InitializeComponent();
        }


        public FrmAltaMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;

        }


















        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                marca.Descripcion = textBox2.Text;
                negocio.Agregar(marca);
                MessageBox.Show("Agregado Exitosamente");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}



    

