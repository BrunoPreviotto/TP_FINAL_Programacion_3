using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Proveedor_m
    {

        public static int GuardarMinorista(int pid, string pnombre, string pdireccion, string ptelefonos, int pdni, char pbaja = 'N')
        {
            if (pid == 0)
            {
                string sql = "INSERT INTO Proveedores (nombre, direccion, telefono, dni_minorista, baja) VALUES (@nombre, @direccion, @telefono, @dni_minorista, @baja)";
                try
                {
                    Conexion cx = new Conexion();
                    cx.SetCommandText();
                    cx.SetSql(sql);

                    cx.sqlCmd.Parameters.Add("@nombre", DbType.String);

                    cx.sqlCmd.Parameters.Add("@direccion", DbType.String);

                    cx.sqlCmd.Parameters.Add("@telefono", DbType.String);

                    cx.sqlCmd.Parameters.Add("@dni_minorista", DbType.Int32);

                    cx.sqlCmd.Parameters.Add("@baja", DbType.String);

                    cx.sqlCmd.Parameters[0].Value = pnombre;

                    cx.sqlCmd.Parameters[1].Value = pdireccion;

                    cx.sqlCmd.Parameters[2].Value = ptelefonos;

                    cx.sqlCmd.Parameters[3].Value = pdni;

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
                return ModificarMinorista(pid, pnombre, pdireccion, ptelefonos, pdni, pbaja);
            }
        }

       

        private static int ModificarMinorista(int pid, string pnombre, string pdireccion, string ptelefonos, int pdni, char pbaja)
        {
            string sql = "Update Sucursales SET nombre = @nombre, direccion = @direccion, telefono = @telefono, dni_minorista = @dni_minorista, baja = @baja Where id = @id";
            try
            {
                Conexion cx = new Conexion();
                cx.SetCommandText();
                cx.SetSql(sql);

                cx.sqlCmd.Parameters.Add("@nombre", DbType.String);
                cx.sqlCmd.Parameters.Add("@direccion", DbType.String);
                cx.sqlCmd.Parameters.Add("@telefono", DbType.String);
                cx.sqlCmd.Parameters.Add("@dni_minorista", DbType.Int32);
                cx.sqlCmd.Parameters.Add("@baja", DbType.String);
                cx.sqlCmd.Parameters.Add("@id", DbType.Int32);

                cx.sqlCmd.Parameters[0].Value = pnombre;
                cx.sqlCmd.Parameters[1].Value = pdireccion;
                cx.sqlCmd.Parameters[2].Value = ptelefonos;
                cx.sqlCmd.Parameters[3].Value = pdni;
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







        public static int GuardarMayorista(int pid, string pnombre, string pdireccion, string ptelefonos, int pcuit, int pnro_IBB, char pbaja = 'N')
        {
            if (pid == 0)
            {
                string sql = "INSERT INTO Proveedores (nombre, direccion, telefono, cuit_mayorista, ibb_mayorista, baja) VALUES (@nombre, @direccion, @telefono, @cuit_mayorista, @ibb_mayorista, @baja)";
                try
                {
                    Conexion cx = new Conexion();
                    cx.SetCommandText();
                    cx.SetSql(sql);

                    cx.sqlCmd.Parameters.Add("@nombre", DbType.String);

                    cx.sqlCmd.Parameters.Add("@direccion", DbType.String);

                    cx.sqlCmd.Parameters.Add("@telefono", DbType.String);

                    cx.sqlCmd.Parameters.Add("@cuit_mayorista", DbType.Int32);

                    cx.sqlCmd.Parameters.Add("@ibb_mayorista", DbType.Int32);

                    cx.sqlCmd.Parameters.Add("@baja", DbType.String);

                    cx.sqlCmd.Parameters[0].Value = pnombre;

                    cx.sqlCmd.Parameters[1].Value = pdireccion;

                    cx.sqlCmd.Parameters[2].Value = ptelefonos;

                    cx.sqlCmd.Parameters[3].Value = pcuit;

                    cx.sqlCmd.Parameters[4].Value = pnro_IBB;

                    cx.sqlCmd.Parameters[5].Value = pbaja;

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
                return ModificarMayorista(pid, pnombre, pdireccion, ptelefonos, pcuit, pnro_IBB, pbaja);
            }
        }

        private static int ModificarMayorista(int pid, string pnombre, string pdireccion, string ptelefonos, int pcuit, int pnro_IBB, char pbaja)
        {
            string sql = "Update Sucursales SET nombre = @nombre, direccion = @direccion, telefono = @telefono, cuit_mayorista = @cuit_mayorista, ibb_mayorista = @ibb_mayorista, baja = @baja Where id = @id";
            try
            {
                Conexion cx = new Conexion();
                cx.SetCommandText();
                cx.SetSql(sql);

                cx.sqlCmd.Parameters.Add("@nombre", DbType.String);
                cx.sqlCmd.Parameters.Add("@direccion", DbType.String);
                cx.sqlCmd.Parameters.Add("@telefono", DbType.String);
                cx.sqlCmd.Parameters.Add("@cuit_mayorista", DbType.Int32);
                cx.sqlCmd.Parameters.Add("@ibb_mayorista", DbType.Int32);
                cx.sqlCmd.Parameters.Add("@baja", DbType.String);
                cx.sqlCmd.Parameters.Add("@id", DbType.Int32);

                cx.sqlCmd.Parameters[0].Value = pnombre;
                cx.sqlCmd.Parameters[1].Value = pdireccion;
                cx.sqlCmd.Parameters[2].Value = ptelefonos;
                cx.sqlCmd.Parameters[3].Value = pcuit;
                cx.sqlCmd.Parameters[4].Value = pnro_IBB;
                cx.sqlCmd.Parameters[5].Value = pbaja;
                cx.sqlCmd.Parameters[6].Value = pid;

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
            string sql = "SELECT id , nombre FROM Proveedores where baja = 'N' ";
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

    }
}
