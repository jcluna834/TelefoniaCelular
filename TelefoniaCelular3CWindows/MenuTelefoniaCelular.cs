using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL.BL;
using Oracle.DataAccess.Client;

namespace TelefoniaCelular3CWindows
{
    public partial class MenuTelefoniaCelular : Form
    {
        public MenuTelefoniaCelular()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string opcion;
            opcion = comInsetar.Text;

            switch (opcion)
            {
                case "Ciudad":
                    InsertCiudad frm1 = new InsertCiudad();
                    frm1.Show();
                    break;
                case "Cliente":
                    InsertCliente frm2 = new InsertCliente();
                    frm2.Show();
                    break;
                   
            }
        }

        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string opcion;
            opcion = comEliminar.Text;

            switch (opcion)
            {
                    
                    case "Ciudad":
                    try
                    {
                    int rta;
                    CiudadBL objCiudadBL = new CiudadBL();
                    objCiudadBL.idCiudad = int.Parse(txtEliminar.Text);
                    rta = objCiudadBL.Eliminar(int.Parse(txtEliminar.Text));
                    if (rta >0)
                        lblerror.Text = "se eliminó correctamente";
                    else
                        lblerror.Text = "no se eliminó correctamente";
                        }
                    catch (Exception ex)
                    {
                        lblerror.Text = ex.Message;
                    }
                    
                    break;

                case "Cliente":
                    try
                    {
                     int rta1;
                    ClienteBL objClienteBL = new ClienteBL();
                    objClienteBL.idCliente = int.Parse(txtEliminar.Text);
                    rta1 = objClienteBL.Eliminar(int.Parse(txtEliminar.Text));
                    if (rta1 >0)
                        lblerror.Text = "se eliminó correctamente";
                    else
                        lblerror.Text = "no se eliminó correctamente";
                    }
                    catch (Exception ex)
                    {
                        lblerror.Text = ex.Message;
                    }
                   
                    break;

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string opcion;
            opcion = comConsultar.Text;

            switch (opcion)
            {
                case "Ciudad":
                 try
                 {
                    CiudadBL objCiudadBL = new CiudadBL();
                    DataTable objCiudad = objCiudadBL.Consultar();
                    if (objCiudad != null)
                    {

                        dvgDatos.DataSource = objCiudad;
                        
                    }
                    else
                        lblerror.Text = "No hay datos";
                 }
                 catch (Exception ex)
                 {
                     lblerror.Text = ex.Message;
                 }

                    break;

                case "Cliente":
                    try
                    {
                     ClienteBL objClienteBL = new ClienteBL();
                     DataTable objCliente = objClienteBL.Consultar();
                    if (objCliente != null)
                    {

                        dvgDatos.DataSource = objCliente;
                        
                    }
                    else
                        lblerror.Text = "No hay datos";
                    }
                    catch (Exception ex)
                    {
                        lblerror.Text = ex.Message;
                    }
                    break;



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

           FUNCIONES frm = new FUNCIONES();
            frm.Show();
           
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            CONSULTAS frm = new CONSULTAS();
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}



