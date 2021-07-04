using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Negocios.Proveedores
{
    public class Proveedor
    {
        protected int id_proveedor;
        protected string nombre;
        protected string direccion;
        protected string[] telefonos;
        protected string mensaje;

        public string Mensaje { get => mensaje; set => mensaje = value; }

        public Proveedor(int id_proveedor, string nombre, string direccion, string[] telefonos)
        {
            this.id_proveedor = id_proveedor;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefonos = telefonos;
        }
    }
}
