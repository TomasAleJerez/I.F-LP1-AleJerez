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
    public partial class frmCargaDeProducto : Form
    {
        public frmCargaDeProducto()
        {
            InitializeComponent();
        }
        bool edit = false;
        int id = 1;
        

        private void frmCargaDeProducto_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            edit = false;
            btnRegistrar.Enabled = true;

        }
       

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                int x = dtgConsulta.Rows.Add();
                CargaP CargaP = new CargaP();

                CargaP.ID1 = id;
                CargaP.Producto1 = txtProductos.Text;
                CargaP.Fecha1 = dtpFecha.Text;

                dtgConsulta.Rows[x].Cells[0].Value = CargaP.Producto1;
                dtgConsulta.Rows[x].Cells[1].Value = CargaP.ID1;
                dtgConsulta.Rows[x].Cells[2].Value = CargaP.Fecha1;

            }
        }
    }
}
