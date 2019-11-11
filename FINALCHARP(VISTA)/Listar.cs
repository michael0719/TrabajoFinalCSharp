using System;
using System.Data;
using System.Windows.Forms;
using CONTROLADOR.Productos;


namespace FINALCHARP_VISTA_
{
    public partial class Listar : Form
    {

        InventarioDTO inventarioDTO = null;
        InventarioDAO inventarioDAO = null;
        DataTable DttProductos = null;

        public Listar()
        {
            InitializeComponent();
            ListarProductos();
        }

        private void ListarProductos()
        {
            inventarioDTO = new InventarioDTO();
            inventarioDAO = new InventarioDAO(inventarioDTO);
            DttProductos = new DataTable();
            DttProductos = inventarioDAO.ListarProductos();
            if (DttProductos.Rows.Count > 0)
            {
                dgvproductos.DataSource = DttProductos;
            }
            else
            {
                MessageBox.Show("No hay productos registrados");
            }
            
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void Listar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }
    }
}
