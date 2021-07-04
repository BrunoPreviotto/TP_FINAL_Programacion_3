using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Sucursal_m
    {

        public static bool Acceso()
        {
            try
            {
                Conexion cx = new Conexion();
                cx.Abrir();

                cx.Cerrar();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public static bool ValidarNombre(string nombre)
        {
            return true;
            
        }

        public static int Guardar(int pid, string pnombre, char pbaja = 'N')
        {
            if(pid == 0)
            {
                string sql = "INSERT INTO Sucursales (nombre, baja) VALUES (@nombre, @baja)";
                try
                {
                    Conexion cx = new Conexion();
                    cx.SetCommandText();
                    cx.SetSql(sql);

                    cx.sqlCmd.Parameters.Add("@nombre", DbType.String);

                    cx.sqlCmd.Parameters.Add("@baja", DbType.String);

                    cx.sqlCmd.Parameters[0].Value = pnombre;

                    cx.sqlCmd.Parameters[1].Value = pbaja;

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
                return Modificar(pid, pnombre, pbaja);
            }
        }

        private static int Modificar(int pid, string pnombre, char pbaja) 
        {
            string sql = "Update Sucursales SET nombre = @nombre, baja = @baja Where id = @id";
            try
            {
                Conexion cx = new Conexion();
                cx.SetCommandText();
                cx.SetSql(sql);

                cx.sqlCmd.Parameters.Add("@nombre", DbType.String);
                cx.sqlCmd.Parameters.Add("@baja", DbType.String);
                cx.sqlCmd.Parameters.Add("@id", DbType.Int32);

                cx.sqlCmd.Parameters[0].Value = pnombre;
                cx.sqlCmd.Parameters[1].Value = pbaja;
                cx.sqlCmd.Parameters[2].Value = pid;

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

        public static DataTable TraerTodos()
        {
            DataTable dtListaAll = new DataTable("Sucursales");
            string sql = "SELECT id , nombre FROM sucursales where baja = 'N' ";
            try
            {
                Conexion Cx = new Conexion();
                Cx.SetCommandText();
                Cx.SetSql(sql);
                SqlDataAdapter sqlData = new SqlDataAdapter(Cx.Comando());
                sqlData.Fill(dtListaAll);

            }
            catch (Exception)
            {
                dtListaAll = null;

            }

            return dtListaAll;

        }

        public static DataTable CargarcomboBox()
        {
            DataTable ds = new DataTable();

            string sql = "SELECT 0 as id, 'Seleccione....' as nombre Union " +
                         "SELECT id , nombre FROM sucursales where baja = 'N'  ";
            try
            {
                Conexion Cx = new Conexion();
                Cx.SetCommandText();
                Cx.SetSql(sql);
                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.Comando());
                sqlDat.Fill(ds);//colocamos un DataTable


            }
            catch (Exception)
            {
                ds = null;
            }
            return ds;
        }



    }
}
