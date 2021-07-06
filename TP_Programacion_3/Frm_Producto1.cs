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
    public partial class Frm_Producto1 : Form
    {
        
        public Producto Productofrm()
        {
            return new Producto();
        }
        
        public Frm_Producto1()
        {
            InitializeComponent();

            dgv_minorista.DataSource = Producto.TraerTodos();

            
        }

        private void Frm_Producto1_Load(object sender, EventArgs e)
        {

        }

        private void boton_buscar_Click(object sender, EventArgs e)
        {
            dgv_minorista.DataSource = Productofrm().TraerMinoristasBuscados(caja_producto.Text.Trim());
            dgv_mayorista.DataSource = Productofrm().TraerMayoristaBuscados(caja_producto.Text.Trim());
        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton_limpiar_Click(object sender, EventArgs e)
        {
            caja_producto.Text = "";
        }
    }
}
