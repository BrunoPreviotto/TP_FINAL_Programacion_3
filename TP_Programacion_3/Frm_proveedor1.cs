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
using Negocios;

namespace TP_Programacion_3
{
    public partial class Frm_proveedor1 : Form
    {
        public Frm_proveedor1()
        {
            InitializeComponent();

            dgv_proveedor.DataSource = Proveedor.TraerTodos();
        }

        private void boton_agregar_Click(object sender, EventArgs e)
        {
            string nombre = caja_nombre.Text.Trim();
            string direccion = caja_direccion.Text.Trim();
            string telefonos = caja_telefonos.Text.Trim() ;
            int id = Int32.Parse(caja_id_proveedor.Text.Trim());
            string tipo = cb_tipo_proveedor.Text;
           
            
            bool estado;

            if (cb_tipo_proveedor.Text.Equals("Minorista"))
            {
                int dni = Convert.ToInt32(caja_dni.Text.Trim());
                Proveedor_Minorista proveedor_Minorista = new Proveedor_Minorista(id, nombre, direccion, telefonos, dni);
                estado = proveedor_Minorista.Guardar();
                if (estado)
                {
                    Funciones.MOK(this, proveedor_Minorista.Mensaje);
                    caja_nombre.Text = "";
                    caja_direccion.Text = "";
                    caja_telefonos.Text = "";
                    caja_dni.Text = "";
                    caja_id_proveedor.Text = "0";
                }
                else
                {
                    Funciones.MError(this, proveedor_Minorista.Mensaje);
                    caja_nombre.Text = "";
                    caja_direccion.Text = "";
                    caja_telefonos.Text = "";
                    caja_dni.Text = "";
                    caja_id_proveedor.Text = "0";
                }
            }
            else
            {
                int cuit = Convert.ToInt32(caja_cuit.Text.Trim());
                int nro_ibb = Convert.ToInt32(caja_nro_ibb.Text.Trim());
                Proveedor_Mayorista proveedor_Mayorista = new Proveedor_Mayorista(id, nombre, direccion, telefonos, cuit, nro_ibb);
                estado = proveedor_Mayorista.Guardar();
                if (estado)
                {
                    Funciones.MOK(this, proveedor_Mayorista.Mensaje);
                    caja_nombre.Text = "";
                    caja_direccion.Text = "";
                    caja_telefonos.Text = "";
                    caja_cuit.Text = "";
                    caja_nro_ibb.Text = "";
                    caja_id_proveedor.Text = "0";
                }
                else
                {
                    Funciones.MError(this, proveedor_Mayorista.Mensaje);
                    caja_nombre.Text = "";
                    caja_direccion.Text = "";
                    caja_telefonos.Text = "";
                    caja_cuit.Text = "";
                    caja_nro_ibb.Text = "";
                    caja_id_proveedor.Text = "0";
                }
            }
            
           
            

            
        }


        private void boton_agregar_producto_Click(object sender, EventArgs e)
        {
            string[] id_producto = caja_id_productos.Text.Trim().Split(' ');
            string id_proveedor = caja_id_proveedor_producto.Text.Trim();

            Proveedor_Producto pp = new Proveedor_Producto(int.Parse(id_proveedor), id_producto, cb_agregar_pp.Text.Trim());
            bool estado = pp.Guardar();

            if (estado)
            {
                Funciones.MOK(this, pp.Mensaje);
                caja_id_proveedor_producto.Text = "";
                caja_id_productos.Text = "";
            }
            else
            {
                Funciones.MError(this, pp.Mensaje);
                caja_id_productos.Text = "";
                caja_id_proveedor_producto.Text = "";
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

        private void boton_limpiar_Click(object sender, EventArgs e)
        {
            caja_nombre.Text = "";
            caja_direccion.Text = "";
            caja_telefonos.Text = "";
            caja_dni.Text = "";
            caja_cuit.Text = "";
            caja_nro_ibb.Text = "";
            caja_id_productos.Text = "";
            caja_id_proveedor_producto.Text = "";
        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
