using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Items
{
    public class Ciudad
    {
        int _idCiudad;
        string _nomCiudad;

        public int idCiudad
        {
            get { return _idCiudad; }
            set { _idCiudad = value; }

        }

        public string nomCiudad
        {
            get { return _nomCiudad; }
            set { _nomCiudad = value; }

        }

    }
}
