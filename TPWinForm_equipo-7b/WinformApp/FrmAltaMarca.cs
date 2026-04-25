using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {

                if (this.marca == null)
                { // si la marca es nula crea una marca
                    this.marca = new Marca();
                    //que esta vacia se le pone una descripcion q va a ser igual a la descripcion del textbox
                    marca.Descripcion = textBox2.Text;
                    negocio.Agregar(marca);
                }
                else
                {
                    marca.Descripcion = textBox2.Text;

                    negocio.ActualizarMarca(marca);

                    MessageBox.Show("Agregado Exitosamente");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void FrmAltaMarca_Load(object sender, EventArgs e)
        {
            if (this.marca != null) {
                textBox2.Text = marca.Descripcion;
            }
           /* MarcaNegocio marca = new MarcaNegocio();

            
            if (marca = !null)
            {
                textBox1.Text = marca.Descripcion;
            }*/

        }
    }
}



    

