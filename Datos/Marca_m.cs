using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Marca_m
    {



        public int Guardar(int pid, string pnombre, string pdescripcion, char pbaja = 'N')
        {
            if (pid == 0)
            {
                string sql = "INSERT INTO Marcas (nombre, descripcion, baja) VALUES (@nombre, @descripcion, @baja)";
                try
                {
                    Conexion cx = new Conexion();
                    cx.SetCommandText();
                    cx.SetSql(sql);

                    cx.sqlCmd.Parameters.Add("@nombre", DbType.String);

                    cx.sqlCmd.Parameters.Add("@descripcion", DbType.String);

                    cx.sqlCmd.Parameters.Add("@baja", DbType.String);

                    cx.sqlCmd.Parameters[0].Value = pnombre;

                    cx.sqlCmd.Parameters[1].Value = pdescripcion;

                    cx.sqlCmd.Parameters[2].Value = pbaja;

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
                return Modificar(pid, pnombre, pdescripcion, pbaja);
            }
        }

        private static int Modificar(int pid, string pnombre, string pdescripcion, char pbaja)
        {
            string sql = "Update Marcas SET nombre = @nombre, descripcion = @descripcion, baja = @baja Where id = @id";
            try
            {
                Conexion cx = new Conexion();
                cx.SetCommandText();
                cx.SetSql(sql);

                cx.sqlCmd.Parameters.Add("@nombre", DbType.String);
                cx.sqlCmd.Parameters.Add("@descripcion", DbType.String);
                cx.sqlCmd.Parameters.Add("@baja", DbType.String);
                cx.sqlCmd.Parameters.Add("@id", DbType.Int32);

                cx.sqlCmd.Parameters[0].Value = pnombre;
                cx.sqlCmd.Parameters[1].Value = pdescripcion;
                cx.sqlCmd.Parameters[2].Value = pbaja;
                cx.sqlCmd.Parameters[3].Value = pid;

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



    }
}
