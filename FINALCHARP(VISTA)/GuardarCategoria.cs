using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADOR.Categoria;

namespace FINALCHARP_VISTA_
{
    public partial class GuardarCategoria : Form
    {
        CategoriaDAO categoriaDAO = null;
        CategoriaDTO categoriaDTO = null;
        DataTable DttCategoria = null;
        public GuardarCategoria()
        {
            InitializeComponent();
            ListarCategoria();
        }

        public void ListarCategoria()
        {
            categoriaDTO = new CategoriaDTO();
            categoriaDAO = new CategoriaDAO(categoriaDTO);
            DttCategoria = new DataTable();
            DttCategoria=categoriaDAO.ListarCategorias();

            if (DttCategoria.Rows.Count > 0)
            {
                dgvcategorias.DataSource = DttCategoria;
            }
        }

        public void Guardar()
        {
            categoriaDTO = new CategoriaDTO();
            categoriaDTO.nombre = txtnombre.Text;
            categoriaDTO.descripcion = txtdescripcion.Text;
            categoriaDAO = new CategoriaDAO(categoriaDTO);
            categoriaDAO.GuardarProducto();
            MessageBox.Show("Categoria registrada.");
            ListarCategoria();
            LimpiarCampos();
            
        }

        public void LimpiarCampos()
        {
            txtnombre.Clear();
            txtdescripcion.Clear();
            txtnombre.Focus();
        }


        private void btnguardar_Click(object sender, EventArgs e)
        {
            Guardar();
            LimpiarCampos();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void GuardarCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }
    }
}
