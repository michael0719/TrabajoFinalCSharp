using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALCHARP_VISTA_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listar listar = new Listar();
            listar.Show();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            GuardarCategoria guardarCategoria = new GuardarCategoria();
            guardarCategoria.Show();
            this.Hide();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            EliminarCategoria eliminar = new EliminarCategoria();
            eliminar.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            ActulizarInventario actulizar = new ActulizarInventario();
            actulizar.Show();
            this.Hide();
        }
    }
}
