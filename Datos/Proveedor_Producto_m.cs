using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Proveedor_Producto_m
    {

        public static int Guardar(int pid_porveedor, string[] pid_producto, string tipo_proveedor)
        {
            int nro =0;
            for (int i = 0; i < pid_producto.Length; i++) {
                string sql = "INSERT INTO Pruductos_Proveedores (id_producto, id_proveedor, tipo) VALUES (@id_producto, @id_proveedor, @tipo)";
                try
                {
                    Conexion cx = new Conexion();
                    cx.SetCommandText();
                    cx.SetSql(sql);

                    cx.sqlCmd.Parameters.Add("@id_producto", DbType.Int32);

                    cx.sqlCmd.Parameters.Add("@id_proveedor", DbType.Int32);

                    cx.sqlCmd.Parameters.Add("@tipo", DbType.String);

                    cx.sqlCmd.Parameters[0].Value = Int32.Parse(pid_producto[i]);

                    cx.sqlCmd.Parameters[1].Value = pid_porveedor;

                    cx.sqlCmd.Parameters[2].Value = tipo_proveedor;

                    cx.Abrir();
                    nro = cx.sqlCmd.ExecuteNonQuery();
                    cx.Cerrar();

                    

                }
                catch (Exception)
                {
                     return 0;
                }

                
            }

            return nro;

        }

    }
}
