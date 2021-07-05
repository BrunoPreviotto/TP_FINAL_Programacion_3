using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;

namespace Negocios
{
    public class Proveedor_Producto
    {

        private int id_proveedor;
        private string[] id_productos;
        private string tipo_proveedor;
        private string mensaje;

        public string Mensaje { get => mensaje; set => mensaje = value; }

        public Proveedor_Producto(int id_proveedor, string [] id_producto, string tipo_proveedor) 
        {
            this.id_proveedor = id_proveedor;
            this.id_productos = id_producto;
            this.tipo_proveedor = tipo_proveedor;
        }

        public bool Guardar()
        {
            int resultado = Proveedor_Producto_m.Guardar(id_proveedor, id_productos, tipo_proveedor);


            if (resultado > 0)
            {
                this.mensaje = "Se guardo correctamente en la base de datos";
                return true;
            }
            else
            {
                this.mensaje = "No de pudo guardar, revice los datos";
                return false;
            }
        }
    }
}
