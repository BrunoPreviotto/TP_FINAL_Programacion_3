using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Proveedor_Producto
    {

        private int id_proveedor;
        private string[] id_productos;
        private string mensaje;

        public string Mensaje { get => mensaje; set => mensaje = value; }

        public Proveedor_Producto(int id_proveedor, string [] id_producto) 
        {
            this.id_proveedor = id_proveedor;
            this.id_productos = id_producto;
        }

        public bool Guardar()
        {
            int resultado = ;


            if (this.id_suc == 0 && Sucursal_m.ValidarNombre(this.nombre))
            {
                resultado = Sucursal_m.Guardar(id_suc, nombre);
            }

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
