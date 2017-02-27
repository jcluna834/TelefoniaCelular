using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using System.Data;

namespace DAL.BD
{
    public /*static*/ class ProxyBD
    {
        static OracleConnection conexion;
        internal static int ejecutarComandoSQL(string sqlInsert)
        {
            int rta;
            try
            {
                Conectar();
                OracleCommand objComando = new OracleCommand(sqlInsert, conexion);
                rta = objComando.ExecuteNonQuery();
                Desconectar();
            }
            catch
            {
                rta = -1;
            }
            return rta;
        }

        internal static System.Data.DataTable ejecutarSelect(string strConsulta)
        {
            Conectar();
            OracleDataAdapter oAdapter;
            DataSet oContenido = new DataSet();
            DataTable oResultado;
            oAdapter = new OracleDataAdapter(strConsulta, conexion);
            oAdapter.Fill(oContenido);
            oResultado = oContenido.Tables[0];
            Desconectar();
            return oResultado;
        }
        private static void Desconectar()
        {
            conexion.Close();
        }

        private static void Conectar()
        {
            if (conexion == null)
            {
                conexion = new OracleConnection("Data Source = localhost ; User ID=JCLUNA ;password = America834");
            }
            conexion.Open();
        }


       public  void EjecutarProcedimiento(
            string strNombre,
            Array oParametros,
            Array oNombresParametros)
        {
            Conectar();
            OracleCommand oComando = new OracleCommand();
            oComando.CommandType = CommandType.StoredProcedure;
            oComando.CommandText = strNombre;
            oComando.Connection = conexion;
            for (int i = 0; i < oParametros.Length; i++)
            {
                OracleParameter oParametro =
                    new OracleParameter(
                        oNombresParametros.GetValue(i).ToString(),
                        oParametros.GetValue(i));
                oComando.Parameters.Add(oParametro);
            }

            oComando.ExecuteNonQuery();
            Desconectar();
        }

       public int EjecutarProcedimiento1(
          string strNombre,
          Array oParametros,
          Array oNombresParametros)
       {
           Conectar();
           OracleCommand oComando = new OracleCommand();
           oComando.CommandType = CommandType.StoredProcedure;
           oComando.CommandText = strNombre;
           oComando.Connection = conexion;
           if (oParametros != null)
           {
               for (int i = 0; i < oParametros.Length; i++)
               {
                   OracleParameter oParametro =
                       new OracleParameter(
                           oNombresParametros.GetValue(i).ToString(),
                           oParametros.GetValue(i));
                   oComando.Parameters.Add(oParametro);
               }
           }
           int rta = oComando.ExecuteNonQuery();
           Desconectar();
           return rta;
       }

        public  string ejecutarFuncion(string strNombre, string[] oParametros, string[] oNombresParametros)
        {
            string resultado;
            try
            {
            Conectar();
            OracleCommand oComando = new OracleCommand();
            oComando.Connection = conexion;
            oComando.CommandType = CommandType.StoredProcedure;
            oComando.CommandText = strNombre;
            oComando.Parameters.Add("return_value", OracleDbType.Double, ParameterDirection.ReturnValue);
            for (int i = 0; i < oParametros.Length; i++)
            {
                oComando.Parameters.Add(oNombresParametros[i], oParametros[i]);
            }
            oComando.ExecuteNonQuery();
            resultado = oComando.Parameters["return_value"].Value.ToString();
            Desconectar();
            }
            catch (Exception exe)
            {
                resultado = "ocurrió error" + exe.Message;

            }
            return resultado;
        }

        
    }
}
