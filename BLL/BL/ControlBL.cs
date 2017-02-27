using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.BD;
namespace BLL.BL
{
    public class ControlBL
    {
        ProxyBD objProxy = new ProxyBD();

        public int funMinutosCliente (int idCliente)
        {
            string[] nombres = new string[1];
            string[] valores = new string[1];
            nombres[0] = "idcli";
            valores[0] = idCliente.ToString();
            return int.Parse(objProxy.ejecutarFuncion("tminutos", valores, nombres));
        }

        public int funclieCiudadMas(int IdCiudad)
        {
            string[] nombres = new string[1];
            string[] valores = new string[1];
            nombres[0] = "IdCiudad";
            valores[0] = IdCiudad.ToString();
            return int.Parse(objProxy.ejecutarFuncion("cliCiudadMasMinutos", valores, nombres));
        }

        public int funclieTotRecargas(int IdCliente)
        {
            string[] nombres = new string[1];
            string[] valores = new string[1];
            nombres[0] = "idcli";
            valores[0] = IdCliente.ToString();
            return int.Parse(objProxy.ejecutarFuncion("tDinero", valores, nombres));
        }


        public void ProEliminarLlamada(int Idllam)
        {
            string[] nombres = new string[1];
            string[] valores = new string[1];
            nombres[0] = "Idllam";
            valores[0] = Idllam.ToString();
            objProxy.EjecutarProcedimiento("ProEliminarLlamada", valores, nombres);
        }

       /* public int ProEliminarLlamada(int Idllam)
        {
            string[] nombres = new string[1];
            string[] valores = new string[1];
            nombres[0] = "Idllam";
            valores[0] = Idllam.ToString();
            return objProxy.EjecutarProcedimiento1("ProEliminarLlamada", valores, nombres);
        }*/
      
        public System.Data.DataTable Reporte1()
        {
            ControlBD objControlBD = new ControlBD();
            return objControlBD.Reporte1();

        }

        public System.Data.DataTable Reporte2()
        {
            ControlBD objControlBD = new ControlBD();
            return objControlBD.Reporte2();

        }
    }
}
