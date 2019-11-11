using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MODELO
{
    public class ClsDatos
    {
        #region Declaración de variables
        SqlConnection cnnConexion = null;
        SqlCommand cmdComando = null;
        SqlDataAdapter daAdaptador = null;
        DataTable Dtt = null;
        String cadenaConexion = string.Empty;
        #endregion

        #region constructor
        public ClsDatos()
        {
            this.cadenaConexion = @"Data Source=FAMILY-PC;Initial Catalog=BDBar;Integrated Security=True";
        }
        #endregion

        public DataTable RetornaTabla(SqlParameter[] Parametros, string parTSQL)
        {
            Dtt = null;
            try
            {
                Dtt = new DataTable();
                cnnConexion = new SqlConnection(cadenaConexion);
                cmdComando = new SqlCommand();
                cmdComando.Connection = cnnConexion;
                cmdComando.CommandType = CommandType.StoredProcedure;
                cmdComando.CommandText = parTSQL;
                if (Parametros != null)
                {
                    cmdComando.Parameters.AddRange(Parametros);
                }

                daAdaptador = new SqlDataAdapter(cmdComando);
                daAdaptador.Fill(Dtt);
            }
            catch (Exception e)
            {
                Exception exception = new Exception();
                throw exception;
            }
            finally
            {
                cnnConexion.Dispose();
                cmdComando.Dispose();
                daAdaptador.Dispose();
            }

            return Dtt;

        }

        public void EjecutarSP(SqlParameter[] parametros, string spNombre)
        {
            try
            {
                cnnConexion = new SqlConnection(cadenaConexion);
                cmdComando = new SqlCommand();
                cmdComando.Connection = cnnConexion;
                cnnConexion.Open();
                cmdComando.CommandType = CommandType.StoredProcedure;
                cmdComando.CommandText = spNombre;
                cmdComando.Parameters.AddRange(parametros);
                cmdComando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cnnConexion.Dispose();
                cmdComando.Dispose();
            }
        }
    }
}
