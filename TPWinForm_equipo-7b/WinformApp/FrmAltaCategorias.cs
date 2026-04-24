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
    public partial class FrmAltaCategorias : Form
    {
        public FrmAltaCategorias()
        {
            InitializeComponent();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

      /*  private void button1_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();  
            try
            {
               // categoria.
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }*/
         
        private void btnCancelar_Click(object sender, EventArgs e)
        {
                Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                
             // categoria.Descripcion = textBox1.Text;
                categoria.Descripcion = textBox1.Text;
                negocio.Agregar(categoria);
                MessageBox.Show("Agregado Exitosamente");

                categoria.Descripcion=txtDescripcion.Text;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
