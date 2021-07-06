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
    public partial class Frm_AgregarProducto : Form
    {
        public Frm_AgregarProducto()
        {
            InitializeComponent();
        }

        private void boton_agregar_Click(object sender, EventArgs e)
        {
            string nombre = caja_nombre.Text.Trim();
            string descripcion = caja_descripcion.Text.Trim();
            string marca = caja_marca.Text.Trim();
            double precio = Double.Parse(caja_precio.Text.Trim());
            int id = Int32.Parse(caja_id_producto.Text.Trim());

            Producto producto = new Producto(id, nombre, descripcion, marca, precio);
            
            bool estado = producto.Guardar();

            if (estado)
            {
                Funciones.MOK(this, producto.Mensaje);
                caja_nombre.Text = "";
                caja_descripcion.Text = "";
                caja_marca.Text = "";
                caja_precio.Text = "";
                caja_id_producto.Text = "0";
            }
            else
            {
                Funciones.MError(this, producto.Mensaje);
                caja_nombre.Text = "";
                caja_descripcion.Text = "";
                caja_marca.Text = "";
                caja_precio.Text = "";
                caja_id_producto.Text = "0";
            }
        }

        private void boton_limpiar_Click(object sender, EventArgs e)
        {
            caja_descripcion.Text = "";
            caja_nombre.Text = "";
            caja_marca.Text = "";
            caja_precio.Text = "";
        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
