using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Programacion_3
{
    public partial class Contenedor : Form
    {
        public Contenedor()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Usuarios);
            if (form != null)
            {
                form.BringToFront();
                return;
            }
            else
            {
                form = new Frm_Usuarios();
                form.MdiParent = this;
                form.Show();
                form.WindowState = FormWindowState.Normal;
            }
        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Sucursal);
            if (form != null)
            {
                form.BringToFront();
                return;
            }
            else
            {
                form = new Frm_Sucursal();
                form.MdiParent = this;
                form.Show();
                form.WindowState = FormWindowState.Normal;
            }
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Marca);
            if (form != null)
            {
                form.BringToFront();
                return;
            }
            else
            {
                form = new Frm_Marca();
                form.MdiParent = this;
                form.Show();
                form.WindowState = FormWindowState.Normal;
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Producto1);
            if (form != null)
            {
                form.BringToFront();
                return;
            }
            else
            {
                form = new Frm_Producto1();
                form.MdiParent = this;
                form.Show();
                form.WindowState = FormWindowState.Normal;
            }
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_proveedor1);
            if (form != null)
            {
                form.BringToFront();
                return;
            }
            else
            {
                form = new Frm_proveedor1();
                form.MdiParent = this;
                form.Show();
                form.WindowState = FormWindowState.Normal;
            }
        }
    }
}
