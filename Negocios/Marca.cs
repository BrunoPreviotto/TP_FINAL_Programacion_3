using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocios
{
    public class Marca
    {
        private int id_marca;
        private string nombre;
        private string descripcion;
        private string mensaje;

        public string Mensaje { get => mensaje; set => mensaje = value; }



        public Marca(string nombre)
        {
            this.nombre = nombre;
        }

        public Marca(string nombre, string descripcion, int id_marca)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.id_marca = id_marca;
        }

        public Marca(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public override string ToString()
        {
            return $"Marca: {nombre}, id: {id_marca},";
        }
        public bool Guardar()
        {
            int resultado = 0;
            Marca_m marca_m = new Marca_m();

            if (this.id_marca == 0)
            {
                resultado = marca_m.Guardar(id_marca, nombre, descripcion);
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
