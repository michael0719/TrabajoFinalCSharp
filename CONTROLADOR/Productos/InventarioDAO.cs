using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using System.Data.SqlClient;
using System.Data;

namespace CONTROLADOR.Productos
{
    public class InventarioDAO
    {
        ClsDatos clsDatos = null;
        InventarioDTO inventarioDTO = null;
        DataTable listaDatos = null;

        public InventarioDAO(InventarioDTO inventarioDTO)
        {
            this.inventarioDTO = inventarioDTO;
        }

        public void GuardarProducto()
        {
            try
            {
                clsDatos = new ClsDatos();
                SqlParameter[] parameters = new SqlParameter[5];

                parameters[0] = new SqlParameter();
                parameters[0].ParameterName = "@nombre";
                parameters[0].SqlDbType = SqlDbType.VarChar;
                parameters[0].Size = 50;
                parameters[0].Value = inventarioDTO.nombre;

                parameters[1] = new SqlParameter();
                parameters[1].ParameterName = "@precio";
                parameters[1].SqlDbType = SqlDbType.Int;
                parameters[1].Value = inventarioDTO.precio;

                parameters[2] = new SqlParameter();
                parameters[2].ParameterName = "@cantidad";
                parameters[2].SqlDbType = SqlDbType.Int;
                parameters[2].Value = inventarioDTO.cantidad;

                parameters[3] = new SqlParameter();
                parameters[3].ParameterName = "@estado";
                parameters[3].SqlDbType = SqlDbType.Int;
                parameters[3].Value = inventarioDTO.estado;

                parameters[4] = new SqlParameter();
                parameters[4].ParameterName = "@idcategoria";
                parameters[4].SqlDbType = SqlDbType.Int;
                parameters[4].Value = inventarioDTO.idcategoria;

                clsDatos.EjecutarSP(parameters, "SPGuardarProducto");

            }
            catch (Exception e)
            {
                Exception exception = new Exception(e.Message);
                throw exception;
            }
        }

        public DataTable ListarProductos()
        {
            listaDatos = new DataTable();
            try
            {
                clsDatos = new ClsDatos();
                SqlParameter[] parameters = null;
                listaDatos = clsDatos.RetornaTabla(parameters, "SPListarProductos");
            }
            catch (Exception e)
            {
                Exception exception = new Exception(e.Message);
                throw exception;
            }

            return listaDatos;
        }


        public void GuardarConCategoria()
        {
            try
            {
                clsDatos = new ClsDatos();
                SqlParameter[] parameters = new SqlParameter[5];

                parameters[0] = new SqlParameter();
                parameters[0].ParameterName = "@nombre";
                parameters[0].SqlDbType = SqlDbType.VarChar;
                parameters[0].Size = 50;
                parameters[0].Value = inventarioDTO.nombre;

                parameters[1] = new SqlParameter();
                parameters[1].ParameterName = "@precio";
                parameters[1].SqlDbType = SqlDbType.Int;
                parameters[1].Value = inventarioDTO.precio;

                parameters[2] = new SqlParameter();
                parameters[2].ParameterName = "@cantidad";
                parameters[2].SqlDbType = SqlDbType.Int;
                parameters[2].Value = inventarioDTO.cantidad;

                parameters[3] = new SqlParameter();
                parameters[3].ParameterName = "@idcategoria";
                parameters[3].SqlDbType = SqlDbType.Int;
                parameters[3].Value = inventarioDTO.idcategoria;

                parameters[4] = new SqlParameter();
                parameters[4].ParameterName = "@codigo";
                parameters[4].SqlDbType = SqlDbType.Int;
                parameters[4].Value = inventarioDTO.id;

                clsDatos.EjecutarSP(parameters, "SPGuardarProductoCC");

            }
            catch (Exception e)
            {
                Exception exception = new Exception(e.Message);
                throw exception;
            }
        }


        public void GuardarCambiosSinCategoria()
        {
            try
            {
                clsDatos = new ClsDatos();
                SqlParameter[] parameters = new SqlParameter[4];

                parameters[0] = new SqlParameter();
                parameters[0].ParameterName = "@nombre";
                parameters[0].SqlDbType = SqlDbType.VarChar;
                parameters[0].Size = 50;
                parameters[0].Value = inventarioDTO.nombre;

                parameters[1] = new SqlParameter();
                parameters[1].ParameterName = "@precio";
                parameters[1].SqlDbType = SqlDbType.Int;
                parameters[1].Value = inventarioDTO.precio;

                parameters[2] = new SqlParameter();
                parameters[2].ParameterName = "@cantidad";
                parameters[2].SqlDbType = SqlDbType.Int;
                parameters[2].Value = inventarioDTO.cantidad;

                parameters[3] = new SqlParameter();
                parameters[3].ParameterName = "@codigo";
                parameters[3].SqlDbType = SqlDbType.Int;
                parameters[3].Value = inventarioDTO.id;

                clsDatos.EjecutarSP(parameters, "SPGuardarProductoSC");

            }
            catch (Exception e)
            {
                Exception exception = new Exception(e.Message);
                throw exception;
            }
        }

        public void EliminarProducto()
        {
            try
            {
                clsDatos = new ClsDatos();
                SqlParameter[] parameters = new SqlParameter[1];

                parameters[0] = new SqlParameter();
                parameters[0].ParameterName = "@codigo";
                parameters[0].SqlDbType = SqlDbType.Int;
                parameters[0].Value = inventarioDTO.id;

                clsDatos.EjecutarSP(parameters, "SPEliminarProducto");

            }
            catch (Exception e)
            {
                Exception exception = new Exception(e.Message);
                throw exception;
            }
        }
    }
}
