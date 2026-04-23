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
        // esto lo hago mañana en categorias y marcas
        private void frmAdministrarCategorias_Load(object sender, EventArgs e)
        {

        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaCategorias alta = new FrmAltaCategorias();
            alta.ShowDialog(); 
        }


       
    }
}
