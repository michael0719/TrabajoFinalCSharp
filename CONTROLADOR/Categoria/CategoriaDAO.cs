using System;
using MODELO;
using System.Data;
using System.Data.SqlClient;

namespace CONTROLADOR.Categoria
{
    public class CategoriaDAO
    {
        ClsDatos clsDatos = null;
        readonly CategoriaDTO categoriaDTO = null;
        DataTable listaDatos = null;

        public CategoriaDAO(CategoriaDTO categoriaDTO)
        {
            this.categoriaDTO = categoriaDTO;
        }

        public void GuardarProducto()
        {
            try
            {
                clsDatos = new ClsDatos();
                SqlParameter[] parameters = new SqlParameter[2];

                parameters[0] = new SqlParameter();
                parameters[0].ParameterName = "@nombre";
                parameters[0].SqlDbType = SqlDbType.VarChar;
                parameters[0].Size = 50;
                parameters[0].Value = categoriaDTO.nombre;


                parameters[1] = new SqlParameter();
                parameters[1].ParameterName = "@descripcion";
                parameters[1].SqlDbType = SqlDbType.VarChar;
                parameters[1].Size = 200;
                parameters[1].Value = categoriaDTO.descripcion;

                clsDatos.EjecutarSP(parameters, "SPGuardarCategoria");

            }
            catch (Exception e)
            {
                Exception exception = new Exception(e.Message);
                throw exception;
            }
        }

        public DataTable ListarCategorias()
        {
            listaDatos = new DataTable();
            try
            {
                clsDatos = new ClsDatos();
                SqlParameter[] parameters = null;
                listaDatos = clsDatos.RetornaTabla(parameters, "SPListarCategoria");
            }
            catch (Exception e)
            {
                Exception exception = new Exception(e.Message);
                throw exception;
            }

            return listaDatos;
        }

        public void EliminarCategoria()
        {
            try
            {
                clsDatos = new ClsDatos();
                SqlParameter[] parameters = new SqlParameter[1];

                parameters[0] = new SqlParameter();
                parameters[0].ParameterName = "@codigo";
                parameters[0].SqlDbType = SqlDbType.Int;
                parameters[0].Value = categoriaDTO.codigo;

                clsDatos.EjecutarSP(parameters, "SPEliminarCategoria");

            }
            catch (Exception e)
            {
                Exception exception = new Exception(e.Message);
                throw exception;
            }
        }
    }
}
