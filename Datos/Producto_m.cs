using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Datos
{
    public class Producto_m
    {



        public int Guardar(int pid, string pmarca, string pnombre, string pdescripcion, Double pprecio, char pbaja = 'N')
        {
            if (pid == 0)
            {
                string sql = "INSERT INTO Productos (marca, nombre, descripcion, precio, baja) VALUES (@marca, @nombre, @descripcion, @precio, @baja)";
                try
                {
                    Conexion cx = new Conexion();
                    cx.SetCommandText();
                    cx.SetSql(sql);

                    cx.sqlCmd.Parameters.Add("@marca", DbType.String);

                    cx.sqlCmd.Parameters.Add("@nombre", DbType.String);

                    cx.sqlCmd.Parameters.Add("@descripcion", DbType.String);

                    cx.sqlCmd.Parameters.Add("@precio", DbType.Double);

                    cx.sqlCmd.Parameters.Add("@baja", DbType.String);

                    cx.sqlCmd.Parameters[0].Value = pmarca;

                    cx.sqlCmd.Parameters[1].Value = pnombre;

                    cx.sqlCmd.Parameters[2].Value = pdescripcion;

                    cx.sqlCmd.Parameters[3].Value = pprecio;

                    cx.sqlCmd.Parameters[4].Value = pbaja;

                    cx.Abrir();
                    int nro = cx.sqlCmd.ExecuteNonQuery();
                    cx.Cerrar();
                    return nro;


                }
                catch (Exception)
                {
                    return 0;
                }
            }
            else
            {
                return Modificar(pid, pmarca, pnombre, pdescripcion, pprecio, pbaja);
            }
        }


        private static int Modificar(int pid, string pmarca, string pnombre, string pdescripcion, Double pprecio, char pbaja)
        {
            string sql = "Update Productos SET @marca = marca, nombre = @nombre, descripcion = @descripcion, @precio = precio, baja = @baja Where id = @id";
            try
            {
                Conexion cx = new Conexion();
                cx.SetCommandText();
                cx.SetSql(sql);

                cx.sqlCmd.Parameters.Add("@marca", DbType.String);
                cx.sqlCmd.Parameters.Add("@nombre", DbType.String);
                cx.sqlCmd.Parameters.Add("@descripcion", DbType.String);
                cx.sqlCmd.Parameters.Add("@precio", DbType.Double);
                cx.sqlCmd.Parameters.Add("@baja", DbType.String);
                cx.sqlCmd.Parameters.Add("@id", DbType.Int32);

                cx.sqlCmd.Parameters[0].Value = pmarca;
                cx.sqlCmd.Parameters[1].Value = pnombre;
                cx.sqlCmd.Parameters[2].Value = pdescripcion;
                cx.sqlCmd.Parameters[3].Value = pprecio;
                cx.sqlCmd.Parameters[4].Value = pbaja;
                cx.sqlCmd.Parameters[5].Value = pid;

                cx.Abrir();
                int nro = cx.sqlCmd.ExecuteNonQuery();
                cx.Cerrar();
                return nro;
            }
            catch (Exception)
            {
                return 0;
            }
        }







        









        public bool ValidarMarca(string marca)
        {
            bool existe = false;
            string val = "";
            string sql = $"SELECT nombre FROM Marcas where nombre = '{marca}' ";
            try
            {
                Conexion Cx = new Conexion();
                Cx.SetCommandText();
                Cx.SetSql(sql);
                int count = Convert.ToInt32(Cx.Comando().ExecuteScalar());
                existe = count == 0;
            }
            catch (Exception)
            {
                existe = false;    
            }

            return existe;

        }
    }
}
