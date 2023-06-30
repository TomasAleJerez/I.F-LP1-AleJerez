using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I.F_LP1_AleJerez
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }
        int intentos = 0;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Administrador" && txtClave.Text == "adm12345")
            { 
                this.Hide();
                frmPrincipal f = new frmPrincipal();
                f.Text = txtUsuario.Text;
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("datos incorrectos. Acceso denegado");
                intentos++;
                if (intentos == 3) 
                {
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
