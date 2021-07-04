using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace TP_Programacion_3
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();

            Sucursal suc = new Sucursal();
            
           
            
            try
            {
                if (suc.EstadoConexion())
                {
                    


                    DataTable dt1 = suc.CargarComboBox();
                    c_caja_sucursal.DataSource = dt1.DefaultView;
                    c_caja_sucursal.ValueMember = "id";
                    c_caja_sucursal.DisplayMember = "nombre";

                }
                else
                {
                    Funciones.MError(this, suc.Mensaje);
                    this.Close();
                }
            }
            catch (Exception)
            {

                Funciones.MError(this, "No existe conexion con la base de datos o no se puede inicializar el login");
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void boton_entrar_Click(object sender, EventArgs e)
        {
            string nombre = caja_nombre.Text.Trim();
            string contrasena = caja_contrasena.Text.Trim();
            int trabajandoen = Convert.ToInt32(c_caja_sucursal.SelectedValue);



            if (trabajandoen > 0)
            {
                if (nombre == contrasena)
                {
                    Funciones.MOK(this, "Bienvenido al sistema");
                    string sucursal = c_caja_sucursal.Text.Trim();
                    Contenedor frm = new Contenedor();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    Funciones.MError(this, "Contraseña y usuario no coinciden");
                    caja_nombre.Focus();
                }
            }
            else
            {
                Funciones.MError(this, " Debe seleccionar una Sucursal de trabajo");
                caja_nombre.Focus();
            }
        }

        private void caja_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                if (caja_nombre.Text.Trim().Length >= 5)
                {

                    caja_contrasena.Focus();
                }
                else
                {

                    Funciones.MError(this, "Debe ingresar el usuario el cual tienen mas de 5 o +caracteres");
                }
            }
        }

        private void caja_contrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                if (caja_contrasena.Text.Trim().Length >= 8)
                {
                    c_caja_sucursal.Focus();
                }
                else
                {
                    Funciones.MError(this, "Debe ingresar el password el cual tienen mas de 8 o + caracteres");
                }
            }
        }

        private void c_caja_sucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                boton_entrar.Focus();
            }
        }
    }
}
