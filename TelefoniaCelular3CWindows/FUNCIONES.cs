using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL.BL;

namespace TelefoniaCelular3CWindows
{
    public partial class FUNCIONES : Form
    {
        public FUNCIONES()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlBL objControl = new ControlBL();
            int num=objControl.funMinutosCliente(int.Parse(textBox1.Text));
            txtResutlF1.Text = num.ToString();

        }

        private void btnEjecF2_Click(object sender, EventArgs e)
        {
            ControlBL objControl = new ControlBL();
            int num = objControl.funclieCiudadMas(int.Parse(txtidCiudad.Text));
            txtResutlF2.Text = num.ToString();
        }

        private void btnEjecF3_Click(object sender, EventArgs e)
        {
            ControlBL objControl = new ControlBL();
            int num = objControl.funclieTotRecargas(int.Parse(txtidCliente.Text));
            txtResutlF3.Text = num.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void button2_Click(object sender, EventArgs e)
        {
            ControlBL objControl = new ControlBL();
            objControl.ProEliminarLlamada(int.Parse(textBox2.Text));
        }*/

       /* private void button2_Click_1(object sender, EventArgs e)
        {
            ControlBL objControl = new ControlBL();
            int rta = objControl.ProEliminarLlamada(int.Parse(textBox2.Text));
            if (rta == -1)
            {
                lblerror.Text = "Se elimino la llamada";
            }
            else
            {
                lblerror.Text = "no se pudo eliminar la llamada";
            }
        }*/
              
    }
}
