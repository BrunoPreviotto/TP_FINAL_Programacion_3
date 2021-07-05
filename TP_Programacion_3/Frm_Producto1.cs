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

        }
    }
}
