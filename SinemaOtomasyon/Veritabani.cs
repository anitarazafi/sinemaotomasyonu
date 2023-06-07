using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SinemaOtomasyon
{
    public static class Veritabani
    {
        public static SqlConnection SqlConnection;

        public static string SqlConnectionString = ""; //TODO: add real string

        //TODO: connect every time the main form loads.
        public static bool connect()
        {
            bool result = false;

            try
            {
                SqlConnection = new SqlConnection(SqlConnectionString);
                SqlConnection.Open();
                result = true;
            } catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public static void disconnect()
        {
            if(SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }

        public static bool giris(string kullaniciadi, string sifre)
        {
            bool result = false;

            try
            {
                string sqlQuery = "SELECT count(*) AS adet FROM kullanicilar k WHERE k.kullaniciadi = '" + kullaniciadi + "';";

                SqlCommand cmd = new SqlCommand(sqlQuery, SqlConnection);
                int queryResult = (int)cmd.ExecuteScalar();
                result = (queryResult >= 1) ? true : false;

            } catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static DataTable kisiListele()
        {
            DataTable dt = new DataTable();

            try
            {
                string sorgu = "select k.id as 'Id', k.ad as 'Ad' from kisiler k left join telefonlar t on t.id=k.telefon_id and t.aktif=1";
                SqlCommand cmd = new SqlCommand(sorgu, SqlConnection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd); //komuttan gelen sonuclarin veri tiplerin bilinmedigi icin

                adapter.Fill(dt);


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return dt;
        }
    }
}
