using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL.Items;
using DAL.BD;


namespace BLL.BL
{
    public class ClienteBL:Cliente
    {
        public int Guardar()
        {

            ClienteBD objClienteBD = new ClienteBD();
            return objClienteBD.Guardar(idCliente, idCiudad, nomCliente, apeCliente, emailCliente,fecNacCliente);
        }

        public int Eliminar(int idCliente)
        {
            ClienteBD objClienteBD = new ClienteBD();
            return objClienteBD.Eliminar(idCliente);

        }

        public int Actualizar()
        {
            ClienteBD objClienteBD = new ClienteBD();
            return objClienteBD.Actualizar(idCliente, idCiudad, nomCliente, apeCliente, emailCliente, fecNacCliente);

        }

        public System.Data.DataTable Consultar()
        {
            ClienteBD objClienteBD = new ClienteBD();
            return objClienteBD.Consultar();

        }
    }
}
