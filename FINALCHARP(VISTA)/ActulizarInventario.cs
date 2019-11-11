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
using CONTROLADOR.Productos;

namespace FINALCHARP_VISTA_
{
    public partial class ActulizarInventario : Form
    {
        CategoriaDAO categoriaDAO = null;
        CategoriaDTO categoriaDTO = null;
        InventarioDAO inventarioDAO = null;
        InventarioDTO inventarioDTO = null;
        DataTable DttCategoria = null;
        DataTable DttProductos = null;
        public ActulizarInventario()
        {
            InitializeComponent();
            ListarCategorias();
            cbcategoria.SelectedIndex = 0;
            ListarProductos();
            btnguardarcambios.Enabled = false;
            btneliminar.Enabled = false;
            btncancelar.Enabled = false;
        }

        private void ListarCategorias()
        {
            categoriaDTO = new CategoriaDTO();
            categoriaDAO = new CategoriaDAO(categoriaDTO);
            DttCategoria = new DataTable();
            DttCategoria = categoriaDAO.ListarCategorias();
            if (DttCategoria.Rows.Count > 0)
            {
                cbcategoria.DataSource = DttCategoria;
                DataRow dataRow = DttCategoria.NewRow();
                dataRow["nombre"] = "Seleccione";
                DttCategoria.Rows.InsertAt(dataRow, 0);
                cbcategoria.DisplayMember = "nombre";
                cbcategoria.ValueMember = "Id_categoria";
            }
        }

        private void GuardarProducto()
        {
            if (cbcategoria.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione una categoria");
            }
            else
            {
                inventarioDTO = new InventarioDTO();
                inventarioDTO.nombre = txtnombre.Text;
                inventarioDTO.precio = int.Parse(txtprecio.Text);
                inventarioDTO.cantidad = int.Parse(txtcantidad.Text);
                inventarioDTO.idcategoria =cbcategoria.SelectedIndex;
                inventarioDTO.estado = 1;

                inventarioDAO = new InventarioDAO(inventarioDTO);
                inventarioDAO.GuardarProducto();
                MessageBox.Show("Producto Guardado con exito");
            }
        }

        private void ListarProductos()
        {
            inventarioDTO = new InventarioDTO();
            inventarioDAO = new InventarioDAO(inventarioDTO);

            DttProductos = new DataTable();
            DttProductos = inventarioDAO.ListarProductos();

            if(DttProductos.Rows.Count > 0)
            {
                dgvproductos.DataSource = DttProductos;
            }
            else
            {
                MessageBox.Show("No hay productos registrados");
            }
        }

        private void LimpiaDatos()
        {
            txtcodigo.Clear();
            txtnombre.Clear();
            cbcategoria.SelectedIndex = 0;
            txtprecio.Clear();
            txtcantidad.Clear();
        }

        private void EliminarProducto()
        {
            inventarioDTO = new InventarioDTO();
            inventarioDTO.id = Convert.ToInt32(txtcodigo.Text);
            inventarioDAO = new InventarioDAO(inventarioDTO);
            inventarioDAO.EliminarProducto();
            MessageBox.Show("Producto Eliminado");
        }

        private void Ocultarcampos()
        {
            lblcodigo.Visible = false;
            txtcodigo.Visible = false;
        }

        private void Mostrarcampos()
        {
            lblcodigo.Visible = true;
            txtcodigo.Visible = true;
        }
        private void Acciones()
        {
            ListarProductos();
            ListarCategorias();
            LimpiaDatos();
            Ocultarcampos();
            cbcategoria.SelectedIndex = 0;
        }

        private void ActualizarCC()
        {
            inventarioDTO = new InventarioDTO();
            inventarioDTO.id = int.Parse(txtcodigo.Text);
            inventarioDTO.nombre = txtnombre.Text;
            inventarioDTO.precio = int.Parse(txtprecio.Text);
            inventarioDTO.cantidad = int.Parse(txtcantidad.Text);
            inventarioDTO.idcategoria = int.Parse(cbcategoria.SelectedValue.ToString());
            inventarioDTO.estado = 1;

            inventarioDAO = new InventarioDAO(inventarioDTO);
            inventarioDAO.GuardarConCategoria();
            MessageBox.Show("Producto Actualizado");
        }

        private void ActualizarSC()
        {
            inventarioDTO = new InventarioDTO();
            inventarioDTO.id = int.Parse(txtcodigo.Text);
            inventarioDTO.nombre = txtnombre.Text;
            inventarioDTO.precio = int.Parse(txtprecio.Text);
            inventarioDTO.cantidad = int.Parse(txtcantidad.Text);
            inventarioDTO.estado = 1;

            inventarioDAO = new InventarioDAO(inventarioDTO);
            inventarioDAO.GuardarCambiosSinCategoria();
            MessageBox.Show("Producto Actualizado");
        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            GuardarProducto();
            ListarProductos();
            Acciones();
        }

        private void btnguardarcambios_Click(object sender, EventArgs e)
        {
            if (cbcategoria.SelectedIndex == 0)
            {
                ActualizarSC();
            }
            else
            {
                ActualizarCC();
            }

            btnregistrar.Enabled = true;
            btnguardarcambios.Enabled = false;
            btneliminar.Enabled = false;
            btncancelar.Enabled = false;
            categoriaactual.Visible = false;
            Acciones();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto();
            btnguardarcambios.Enabled = false;
            btnregistrar.Enabled = true;
            btneliminar.Enabled = false;
            btncancelar.Enabled = false;
            categoriaactual.Visible = false;
            Acciones();
            Ocultarcampos();
            ListarProductos();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            btnregistrar.Enabled = true;
            btnguardarcambios.Enabled = false;
            btneliminar.Enabled=false;
            btncancelar.Enabled = false;
            categoriaactual.Visible = false;
            Acciones();
            Ocultarcampos();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void dgvproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Mostrarcampos();
            txtcodigo.Text = dgvproductos.Rows[dgvproductos.CurrentRow.Index].Cells[0].Value.ToString();
            txtnombre.Text = dgvproductos.Rows[dgvproductos.CurrentRow.Index].Cells[1].Value.ToString();
            txtprecio.Text = dgvproductos.Rows[dgvproductos.CurrentRow.Index].Cells[2].Value.ToString();
            txtcantidad.Text = dgvproductos.Rows[dgvproductos.CurrentRow.Index].Cells[3].Value.ToString();
            categoriaactual.Text = "Categoria: "+ dgvproductos.Rows[dgvproductos.CurrentRow.Index].Cells[4].Value.ToString();
            txtcodigo.Enabled = false;
            btnguardarcambios.Enabled = true;
            btncancelar.Enabled = true;
            categoriaactual.Visible = true;
            btneliminar.Enabled = true;
            ListarProductos();

        }

        private void ActulizarInventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }
    }
}
