using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL.Items;
using DAL.BD;

namespace BLL.BL
{
    public class CiudadBL : Ciudad
    {
        public int Guardar()
        {

            CiudadBD objCiudadBD = new CiudadBD();
            return objCiudadBD.Guardar(idCiudad, nomCiudad);
        }

        public int Eliminar(int idCiudad)
        {
            CiudadBD objCiudadBD = new CiudadBD();
            return objCiudadBD.Eliminar(idCiudad);

        }

        public int Actualizar()
        {
            CiudadBD objCiudadBD = new CiudadBD();
            return objCiudadBD.Actualizar(idCiudad, nomCiudad);

        }

        public System.Data.DataTable Consultar()
        {
            CiudadBD objCiudadBD = new CiudadBD();
            return objCiudadBD.Consultar();

        }

    }
}
