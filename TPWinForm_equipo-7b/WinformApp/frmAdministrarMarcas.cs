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
        // ESTO  LO HAGO MAÑANA
        private void frmAdministrarMarcas_Load(object sender, EventArgs e)
        {

        }

       

        private void dgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaMarca alta = new FrmAltaMarca(); 
            alta.ShowDialog();
        }
    }
}
