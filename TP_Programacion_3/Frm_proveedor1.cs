using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios.Proveedores;
using System.Collections;

namespace TP_Programacion_3
{
    public partial class Frm_proveedor1 : Form
    {
        public Frm_proveedor1()
        {
            InitializeComponent();
        }

        private void boton_agregar_Click(object sender, EventArgs e)
        {
            string nombre = caja_nombre.Text.Trim();
            string direccion = caja_direccion.Text.Trim();
            string[] telefonos = caja_telefonos.Text.Split(' ');
            int id = Int32.Parse(caja_id_proveedor.Text.Trim());
            string tipo = cb_tipo_proveedor.Text;
            int dni = Convert.ToInt32(caja_dni.Text.Trim());
            int cuit = Convert.ToInt32(caja_cuit.Text.Trim());
            int nro_ibb = Convert.ToInt32(caja_nro_ibb.Text.Trim());

            if (cb_tipo_proveedor.Text.Equals("Minorista"))
            {
                Proveedor_Minorista proveedor_Minorista = new Proveedor_Minorista(id, nombre, direccion, telefonos, dni);
                bool estado = proveedor_Minorista.Guardar();
            }
            else
            {
                Proveedor_Mayorista proveedor_Mayorista = new Proveedor_Mayorista(id, nombre, direccion, telefonos, cuit, nro_ibb);
                bool estado = proveedor_Mayorista.Guardar();
            }
            
           
            

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

        private void cb_tipo_proveedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (cb_tipo_proveedor.SelectedIndex)
            {
                case 0:
                    etiqueta_cuit.Visible = false;
                    caja_cuit.Visible = false;
                    etiqueta_nro_ibb.Visible = false;
                    caja_nro_ibb.Visible = false;
                    etiqueta_dni.Visible = true;
                    caja_dni.Visible = true;
                    break;
                case 1:
                    etiqueta_dni.Visible = false;
                    caja_dni.Visible = false;
                    etiqueta_cuit.Visible = true;
                    caja_cuit.Visible = true;
                    etiqueta_nro_ibb.Visible = true;
                    caja_nro_ibb.Visible = true;
                    break;
            }
        }
    }
}
