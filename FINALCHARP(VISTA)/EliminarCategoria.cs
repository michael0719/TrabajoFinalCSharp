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
    public partial class EliminarCategoria : Form
    {
        CategoriaDAO categoriaDAO = null;
        CategoriaDTO categoriaDTO = null;
        DataTable DttCategoria = null;
        public EliminarCategoria()
        {
            InitializeComponent();
            ListarCategoria();
        }

        public void ListarCategoria()
        {
            categoriaDTO = new CategoriaDTO();
            categoriaDAO = new CategoriaDAO(categoriaDTO);
            DttCategoria = new DataTable();
            DttCategoria = categoriaDAO.ListarCategorias();

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
            if (txtnombre.Text.Trim().Length > 0 && txtdescripcion.Text.Trim().Length > 0)
            {
                Guardar();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Llene la informacion correspondiente");
            }
            
        }

        private void dgvcategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Visible = true;
            lblCodigo.Visible = true;
            txtCodigo.Text = dgvcategorias.Rows[dgvcategorias.CurrentRow.Index].Cells[0].Value.ToString();
            txtnombre.Text = dgvcategorias.Rows[dgvcategorias.CurrentRow.Index].Cells[1].Value.ToString();
            txtdescripcion.Text = dgvcategorias.Rows[dgvcategorias.CurrentRow.Index].Cells[2].Value.ToString();
            btnguardar.Enabled = false;
            btneliminar.Enabled = true;
            btncancelar.Enabled = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            btnguardar.Enabled = true;
            btneliminar.Enabled = false;
            btncancelar.Enabled = false;
            txtCodigo.Visible = false;
            lblCodigo.Visible = false;
            txtnombre.Clear();
            txtdescripcion.Clear();
        }

        private void Eliminar()
        {
            categoriaDTO = new CategoriaDTO();
            categoriaDTO.codigo =int.Parse(txtCodigo.Text);
            categoriaDAO = new CategoriaDAO(categoriaDTO);
            categoriaDAO.EliminarCategoria();
            MessageBox.Show("Categoria eliminada exitosamente");
        }

        private void Acciones()
        {
            ListarCategoria();
            LimpiarCampos();
            btncancelar.Enabled = true;
            btnguardar.Enabled = true;
            txtCodigo.Visible = false;
            txtCodigo.Clear();
            lblCodigo.Visible = false;
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            Acciones();
            btneliminar.Enabled = false;
            btncancelar.Enabled = false;
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void EliminarCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
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
