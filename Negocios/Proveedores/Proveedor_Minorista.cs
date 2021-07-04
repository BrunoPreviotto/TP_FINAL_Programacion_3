using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Datos;

namespace Negocios.Proveedores
{
    public class Proveedor_Minorista : Proveedor
    {
        private int dni;
        private const int VALOR_DE_GANACIA = 5;


       
        public Proveedor_Minorista(int id_proveedor, string nombre, string direccion, string[] telefonos, int dni) : base(id_proveedor, nombre, direccion, telefonos)
        {
            this.dni = dni;
        }
        
    }
}
