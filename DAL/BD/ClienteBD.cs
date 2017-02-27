using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.BD
{
    public class ClienteBD
    {
        public int Guardar(int idCliente, int idCiudad, string nomCliente, string apeCliente, string emailCliente, string fecNacCliente)
        {
            string sqlInsert =
                string.Format("INSERT INTO CLIENTE VALUES ({0},'{1}','{2}','{3}','{4}','{5}')",
                idCliente, idCiudad, nomCliente, apeCliente, emailCliente, fecNacCliente);
            return ProxyBD.ejecutarComandoSQL(sqlInsert);

        }

        public int Eliminar(int idCliente)
        {
            string sqlEliminar =
                string.Format("DELETE FROM CLIENTE WHERE clie_id={0}",
                idCliente);
            return ProxyBD.ejecutarComandoSQL(sqlEliminar);
        }

        public int Actualizar(int idCliente, int idCiudad, string nomCliente, string apeCliente, string emailCliente, string fecNacCliente)
        {
            string sqlActualizar =
                string.Format("UPDATE CLIENTE SET clie_nombres='{1}',clie_apellidos='{2}',clie_email='{3}',clie_fecha_naci='{4}' WHERE clie_id={0}",
                idCliente, nomCliente, apeCliente, emailCliente, fecNacCliente);
            return ProxyBD.ejecutarComandoSQL(sqlActualizar);
        }

        public System.Data.DataTable Consultar()
        {
            string sqlConsultar =
                string.Format("SELECT * FROM CLIENTE");
            return ProxyBD.ejecutarSelect(sqlConsultar);

        }


    }
}
