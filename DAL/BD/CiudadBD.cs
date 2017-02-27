using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.BD
{
    public class CiudadBD
    {
        public int Guardar(int idCiudad, string nomCiudad)
        {
            string sqlInsert =
                string.Format("INSERT INTO CIUDAD VALUES ({0},'{1}')",
                idCiudad, nomCiudad);
            return ProxyBD.ejecutarComandoSQL(sqlInsert);

        }

        public int Eliminar(int idCiudad)
        {
            string sqlEliminar =
                string.Format("DELETE FROM CIUDAD WHERE ciu_id={0}",
                idCiudad);
            return ProxyBD.ejecutarComandoSQL(sqlEliminar);
        }

        public int Actualizar(int idCiudad, string nomCiudad)
        {
            string sqlActualizar =
                string.Format("UPDATE CIUDAD SET ciu_nombre='{0}' WHERE ciu_id={1}",
                nomCiudad, idCiudad);
            return ProxyBD.ejecutarComandoSQL(sqlActualizar);
        }

        public System.Data.DataTable Consultar()
        {
            string sqlConsultar =
                string.Format("SELECT * FROM CIUDAD");
            return ProxyBD.ejecutarSelect(sqlConsultar);

        }


    }
}
