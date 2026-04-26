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

        private Categoria categoria = null;

        public FrmAltaCategorias(Categoria seleccionado)
        {
            InitializeComponent();
            this.categoria = seleccionado;
            Text = "Modificar Categoría";
        }
        public FrmAltaCategorias()
        {
            InitializeComponent();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

      /*  private void btnBuscar_Click(object sender, EventArgs e)
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
            CategoriaNegocio negocio = new CategoriaNegocio();

            string texto = txtCategoria.Text;

            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("El campo no puede estar vacío.");
                return;
            }

            foreach (char caracter in texto)
            {
                if (!char.IsLetter(caracter) && !char.IsWhiteSpace(caracter))
                {
                    MessageBox.Show("Error: La categoría solo puede contener letras.");
                    return;
                }
            }

            try
            {
                if (categoria == null)
                    categoria = new Categoria();

                categoria.Descripcion = txtCategoria.Text;

                if (categoria.Id != 0)
                {
                    negocio.ActualizarCategoria(categoria);
                    MessageBox.Show("Modificado Exitosamente");
                }
                else
                {
                    negocio.Agregar(categoria);
                    MessageBox.Show("Agregado Exitosamente");
                }

                
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la categoría: " + ex.ToString());
            }
        }
    }
}
