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
    public partial class Frm_Marca : Form
    {
        public Frm_Marca()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void boton_agregar_Click(object sender, EventArgs e)
        {
            string nombre = caja_nombre.Text.Trim();
            string descripcion = caja_descripcion.Text.Trim();
            int id = Int32.Parse(caja_id_marca.Text.Trim());

             
            Marca marca = new Marca(nombre, descripcion, id);
            bool estado = marca.Guardar();

            if (estado)
            {
                Funciones.MOK(this, marca.Mensaje);
                caja_nombre.Text = "";
                caja_descripcion.Text = "";
                caja_id_marca.Text = "0";
            }
            else
            {
                Funciones.MError(this, marca.Mensaje);
                caja_nombre.Text = "";
                caja_descripcion.Text = ""; 
                caja_id_marca.Text = "0";
            }
        }
    }
}
