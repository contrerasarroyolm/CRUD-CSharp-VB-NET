using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CRUD_CSharp
{
    public class Conexion
    {
        public SqlConnection GetConexion()
        {
            string cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MyDbContext;Integrated Security=True;";
            SqlConnection con = new SqlConnection(cadena);
            con.Open();
            return con;
        }
    }
}
