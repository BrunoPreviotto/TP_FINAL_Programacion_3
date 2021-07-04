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
    public partial class Frm_Sucursal : Form
    {
        public Frm_Sucursal()
        {
            InitializeComponent();
            caja_nro_sucursal.Enabled = false;

            dgv_suscursales.DataSource = Sucursal.TraerTodos();
        }

        
        private void boton_guardar_Click(object sender, EventArgs e)
        {
            string nombre = caja_nombre.Text.Trim();
            int id = Int32.Parse(caja_nro_sucursal.Text.Trim());

            Sucursal suc = new Sucursal(id, nombre);
            bool estado = suc.Guardar();

            if (estado)
            {
                Funciones.MOK(this, suc.Mensaje);
                caja_nombre.Text = "";
                caja_nro_sucursal.Text = "0";
            }
            else
            {
                Funciones.MError(this, suc.Mensaje);
                caja_nombre.Text = "";
                caja_nro_sucursal.Text = "0";
            }
        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modificar(object sender, DataGridViewCellMouseEventArgs e)
        {
            caja_nro_sucursal.Text = Convert.ToString(this.dgv_suscursales.CurrentRow.Cells["id"].Value);
            caja_nombre.Text = Convert.ToString(this.dgv_suscursales.CurrentRow.Cells["nombre"].Value);

        }

        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.dgv_suscursales.CurrentRow.Cells["id"].Value);
                string nombre = Convert.ToString(this.dgv_suscursales.CurrentRow.Cells["nombre"].Value);


                Sucursal suc = new Sucursal(id, nombre);
                bool estado = suc.Eliminar();

                if (estado)
                {
                    Funciones.MOK(this, suc.Mensaje);
                    caja_nombre.Text = "";
                    caja_nro_sucursal.Text = "0";

                    dgv_suscursales.DataSource = Sucursal.TraerTodos();

                }
                else
                {
                    Funciones.MError(this, suc.Mensaje);
                    caja_nombre.Text = "";
                    caja_nro_sucursal.Text = "0";
                }
            }
            catch (Exception)
            {
                Funciones.MError(this, "Seleccione en la grilla la fila a eliminar");
            }

        }

        private void boton_limpiar_Click(object sender, EventArgs e)
        {
            caja_nombre.Text = "";
            caja_nro_sucursal.Text = "0";
        }
    }
}
