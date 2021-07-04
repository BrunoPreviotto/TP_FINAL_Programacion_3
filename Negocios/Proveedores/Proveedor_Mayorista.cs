using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Collections;

namespace Negocios.Proveedores
{
    public class Proveedor_Mayorista : Proveedor
    {
        private int cuit;
        private int nro_IBB;

        public Proveedor_Mayorista(int id_proveedor, string nombre, string direccion, string[] telefonos, int cuit, int nro_IBB) : base(id_proveedor, nombre, direccion, telefonos)
        {
            this.cuit = cuit;
            this.nro_IBB = nro_IBB;
        }
    }
}
