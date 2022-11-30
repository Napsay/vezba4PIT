using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace vezba4PIT
{
    class Autor
    {
        public int AutorID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }

        public string PunoIme
        {
            get { return this.Ime + " " + this.Prezime; }
        }

        public void InicijalizujPolja(DataRow dr)
        {
            this.AutorID = (int)dr["AutorID"];
            this.Ime = (string)dr["Ime"];
            this.Prezime = (string)dr["Prezime"];
            if (dr["DatumRodjenja"] != DBNull.Value) 
                this.DatumRodjenja = Convert.ToDateTime(dr["DatumRodjenja"]);
        }
        public Autor()
        {
            
        }

        public Autor(DataRow dr)
        {
            this.InicijalizujPolja(dr);
        }

        public static List<Autor> UcitajSve()
        {
            SqlCommand cmd = Konekcija.GetCommand();
            cmd.CommandText = "usp_AutorUcitaj";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            List<Autor> lista = new List<Autor>();

            try 
            {
                cmd.Connection.Open();
                da.Fill(dt);
                if(dt.Rows.Count>0)
                {
                    foreach (DataRow dr in dt.Rows) 
                        lista.Add(new Autor(dr));
                    return lista;

                }
                else
                {
                    Console.WriteLine("Podaci nisu nadjeni.");
                    return null;

                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            finally
            {
                cmd.Connection.Close();
            }

        }

        public bool Obrisi()
        {
            SqlCommand cmd = Konekcija.GetCommand();
            cmd.CommandText = "usp_AutorBrisi";

            cmd.Parameters.AddWithValue("@sifra", this.AutorID);


            try
            {
                cmd.Connection.Open();
                int ok = cmd.ExecuteNonQuery();
                if (ok == 1)
                {

                    Console.WriteLine("Uspesno brisanje");
                    return true;
                }
                else
                {
                    Console.WriteLine("Brisanje nije izvrseno.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "Konekcija nije uspostavljena.");
                return false;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
    

    }
}
