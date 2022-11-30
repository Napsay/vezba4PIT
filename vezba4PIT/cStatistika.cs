using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace vezba4PIT
{
    class cStatistika
    {
        public static DataTable StatistikaIznajmljivanja(int god, int autor)
        {
            SqlCommand cmd = Konekcija.GetCommand();
            cmd.CommandText = "usp_Statistika";
            cmd.Parameters.AddWithValue("@godina", god);

            cmd.Parameters.AddWithValue("@autorID", autor);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                cmd.Connection.Open();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    return dt;
                }
                else
                {
                    Console.WriteLine("Za traženi vremenski period za izabranog autora nije bilo iznajmljenih knjiga.");
                    return null;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "Konekcija nije uspostavljena.");
                return null;
            }
            finally
            {
                cmd.Connection.Close();
            }

        }

    }
}
