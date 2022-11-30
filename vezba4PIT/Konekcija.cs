using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace vezba4PIT
{
    class Konekcija
    {
        static string connStr = @"Data Source=DESKTOP-CC5SU2C\SQLEXPRESS; Initial Catalog=StefanKaracA2; integrated security=true";

        public static SqlCommand GetCommand()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection(connStr);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;

        }
    }
}
