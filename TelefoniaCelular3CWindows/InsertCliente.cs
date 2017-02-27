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
    public partial class InsertCliente : Form
    {
        public InsertCliente()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
            int rta;
            ClienteBL objClienteBL = new ClienteBL();
            objClienteBL.idCliente = int.Parse(txtCedula.Text);
            objClienteBL.nomCliente = txtNombreC.Text;
            objClienteBL.apeCliente = txtApellidoC.Text;
            objClienteBL.emailCliente = txtEmailC.Text;
            objClienteBL.fecNacCliente = txtFecN.Text;
            objClienteBL.idCiudad = int.Parse(txtIdCiudad.Text);
            
            rta = objClienteBL.Guardar();
            if (rta >0)
                lblerrorE.Text = "se insertó correctamente";
            else
                lblerrorE.Text = "no se insertó correctamente";
            }
            catch (Exception ex)
            {
                lblerrorE.Text = ex.Message;
            }
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            try
            {
            int rta;
            ClienteBL objClienteBL = new ClienteBL();
            objClienteBL.idCliente = int.Parse(txtCedula.Text);
            objClienteBL.nomCliente = txtNombreC.Text;
            objClienteBL.apeCliente = txtApellidoC.Text;
            objClienteBL.emailCliente = txtEmailC.Text;
            objClienteBL.fecNacCliente = txtFecN.Text;
            objClienteBL.idCiudad = int.Parse(txtIdCiudad.Text);


            rta = objClienteBL.Actualizar();

            if (rta >0)
                lblerrorE.Text = "se Actualizó correctamente";
            else
                lblerrorE.Text = "no se Actualizó correctamente";
            }
            catch (Exception ex)
            {
                lblerrorE.Text = ex.Message;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
