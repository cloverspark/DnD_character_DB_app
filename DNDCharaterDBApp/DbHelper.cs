using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DNDCharaterDBApp
{
    class DbHelper
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=DnD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            return con;
        }
    }
}
