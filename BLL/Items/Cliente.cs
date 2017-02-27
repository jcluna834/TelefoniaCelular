using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Items
{
    public class Cliente
    {
        int _idCliente;
        int _idCiudad;
        string _nomCliente;
        string _apeCliente;
        string _emailCliente;
        string _fecNacCliente;

        public int idCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }

        }
        public int idCiudad
        {
            get { return _idCiudad; }
            set { _idCiudad = value; }

        }
        public string nomCliente
        {
            get { return _nomCliente; }
            set { _nomCliente = value; }

        }
        public string apeCliente
        {
            get { return _apeCliente; }
            set { _apeCliente = value; }

        }
        public string emailCliente
        {
            get { return _emailCliente; }
            set { _emailCliente = value; }

        }
        public string fecNacCliente
        {
            get { return _fecNacCliente; }
            set { _fecNacCliente = value; }

        }
             

    }
}
