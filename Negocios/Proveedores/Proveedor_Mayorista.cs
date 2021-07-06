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

        public Proveedor_Mayorista(int id_proveedor, string nombre, string direccion, string telefonos, int cuit, int nro_IBB) : base(id_proveedor, nombre, direccion, telefonos)
        {
            this.cuit = cuit;
            this.nro_IBB = nro_IBB;
        }

        public Proveedor_Mayorista() { }
        public override string ToString()
        {
            return $"Proveedor: {nombre}, id: {id_proveedor}, direccion: {direccion}, telefonos: {telefonos}, cuit: {cuit}, numero ibb: {nro_IBB}";
        }

        public bool Guardar()
        {
            int resultado = 0;


            if (this.id_proveedor == 0)
            {
                resultado = Proveedor_m.GuardarMayorista(id_proveedor, nombre, direccion, telefonos, cuit, nro_IBB);
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
