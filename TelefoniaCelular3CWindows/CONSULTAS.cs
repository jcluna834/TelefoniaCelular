using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using BLL.BL;
namespace TelefoniaCelular3CWindows
{
    public partial class CONSULTAS : Form
    {
        public CONSULTAS()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
             string opcion;
            opcion = comOpcion.Text;

            switch (opcion)
            {

                case "valor gastado por cada cliente pospago ordenados de menor a mayor":

                    ControlBL objControlBL = new ControlBL();
                    DataTable objControl = objControlBL.Reporte1();;
                    if (objControl != null)
                    {

                        dgvDatos.DataSource = objControl;
                        
                    }
                   
                    break;

                case "linea pospago que han enviado mensajes y cuantos":

                    ControlBL objControlBL1 = new ControlBL();
                    DataTable objControl1 = objControlBL1.Reporte2(); ;
                    if (objControl1 != null)
                    {

                        dgvDatos.DataSource = objControl1;

                    }

                    break;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
