using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocios
{
    public class Sucursal
    {

        private int id_suc;
        private string nombre;
        private string mensaje;
        
        public string Mensaje { get => mensaje; set => mensaje = value;}

        public Sucursal(string pnombre)
        {
            this.nombre = pnombre;
        }

        public Sucursal(int pid, string pnombre)
        {
            this.id_suc = pid;
            this.nombre = pnombre;
        }

        public static DataTable TraerTodos()
        {
            return Sucursal_m.TraerTodos();
        }

        public Sucursal() { }
        public bool EstadoConexion()
        {
            if (Sucursal_m.Acceso())
            {
                return true;
            }
            else
            {
                this.Mensaje = "No se puede conectar a la DDBB";
                return false;
            }
        }

        public bool Guardar()
        {
            int resultado = 0;
            
            
            if(this.id_suc == 0 && Sucursal_m.ValidarNombre(this.nombre))
            {
                resultado = Sucursal_m.Guardar(id_suc, nombre);
            }

            if(resultado > 0)
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

        public bool Eliminar()
        {
            int resultado = 0;

            resultado = Sucursal_m.Guardar(id_suc, nombre, 'S');

            if (resultado > 0)
            {
                this.mensaje = "Se Elimino correctamenta en la Base de datos";
                return true;
            }
            else
            {
                this.mensaje = "NO Se pudo eliminar rebice los datos";
                return false;
            }
        }

        public bool ls()
        {
            return true;
        }

        public DataTable CargarComboBox()
        {
            return Sucursal_m.CargarcomboBox();
        }
    }
}
