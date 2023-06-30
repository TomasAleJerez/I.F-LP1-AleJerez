using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I.F_LP1_AleJerez
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCargaProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCargaDeProducto f = new frmCargaDeProducto();
            f.ShowDialog();
            this.Show();
        }

        private void btnCargaVenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCargaDeVentas f = new frmCargaDeVentas();
            f.ShowDialog();
            this.Show();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListados f = new frmListados();
            f.ShowDialog();
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
