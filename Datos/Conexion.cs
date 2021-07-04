using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Datos
{
    class Conexion
    {
        public SqlCommand sqlCmd;
        private SqlConnection sqlCon;

        public Conexion()
        {

            //Data Source = DESKTOP-AOQBFDJ; Initial Catalog = MiAplicacion; Integrated Security = True
            string servidor = ConfigurationManager.AppSettings["server"];
            string ddbb = ConfigurationManager.AppSettings["ddbb"];

            sqlCon = new SqlConnection();
            sqlCon.ConnectionString = "Data source =" + servidor + "; Initial Catalog =" + ddbb + "; Integrated Security = True";

            sqlCmd = new SqlCommand();

            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandTimeout = 0;
        }

        public void Abrir()
        {
            sqlCon.Open();
        }

        public void Cerrar()
        {
            sqlCon.Close();
        }

        public void SetCommandText()
        {
            sqlCmd.CommandType = CommandType.Text;
        }

        public void SetSql(string query)
        {
            sqlCmd.CommandText = query;
        }

        public SqlCommand Comando()
        {
            return sqlCmd;
        }
    }
}
