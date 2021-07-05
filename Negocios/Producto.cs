using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Negocios.Proveedores;
using Datos;
using System.Data;


namespace Negocios
{
    public class Producto
    {
        private int id_producto;
        private string nombre;
        private string descripcion;
        private string marca;
       
        private Double precio;
        private string mensaje;


        public string Mensaje { get => mensaje; set => mensaje = value; }

        public Producto(int id_producto, string nombre, string descripcion, string marca, Double precio)
        {
            this.id_producto = id_producto;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.marca = marca;
            this.precio = precio;
        }


        public static DataTable TraerTodos()
        {
            return Producto_m.TraerTodos();
        }

        public bool Guardar()
        {
            int resultado = 0;

            Producto_m producto_m = new Producto_m();
            if (this.id_producto == 0)
            {
                resultado = producto_m.Guardar(id_producto, marca, nombre, descripcion, precio);
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
