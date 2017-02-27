using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.BD
{
    public class ControlBD
    {
        public System.Data.DataTable Reporte1()
        {
            string sqlConsultar =
                string.Format("select lin.CLIE_ID CEDULA, cl.CLIE_NOMBRES NOMBRE,  sum(ll.LLAM_DURACION * t.TARIF_VALOR) AS \"TOTAL GASTADO\" from LLamada ll  " +
                            " inner join Linea lin on lin.LIN_NUM_CEL=ll.LIN_NUM_CEL " +
                            " inner join cliente cl on cl.CLIE_ID=lin.CLIE_ID " +
                            " inner join pospago pos on pos.LIN_NUM_CEL=lin.LIN_NUM_CEL " +
                            " inner join plan p on p.PLAN_ID=pos.PLAN_ID " +
                            " inner join tarifas_pos t on t.PLAN_ID=p.PLAN_ID " +
                            " group by lin.CLIE_ID,cl.CLIE_NOMBRES " +
                            " order by sum(ll.LLAM_DURACION * t.TARIF_VALOR) desc ");
            return ProxyBD.ejecutarSelect(sqlConsultar);

        }

        public System.Data.DataTable Reporte2()
        {
            string sqlConsultar =
                string.Format(" select li.LIN_NUM_CEL NUMERO, count(*) AS \"CANTIDAD DE MSJ\"  from linea li " +
                            " inner join msn ms on li.LIN_NUM_CEL=ms.LIN_NUM_CEL and ms.MSN_TIPO='saliente' " +
                            " inner join pospago pos on pos.LIN_NUM_CEL=li.LIN_NUM_CEL " +
                            " group by li.LIN_NUM_CEL " +
                            " having count(*)in(select  max(count(*))from linea l " +
                            " inner join msn m on l.LIN_NUM_CEL=m.LIN_NUM_CEL and m.MSN_TIPO='saliente' " +
                            " inner join pospago p on p.LIN_NUM_CEL=l.LIN_NUM_CEL " +
                            " group by l.LIN_NUM_CEL)");

            return ProxyBD.ejecutarSelect(sqlConsultar);
        }
    }
}
