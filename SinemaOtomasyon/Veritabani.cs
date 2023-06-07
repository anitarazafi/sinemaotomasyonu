using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.SqlServer.Server;

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

        public static void telefonKaydet(string numara, string tur)
        {

            string sorgu = "SELECT max(id) +1 FROM telefonlar";

            SqlCommand cmd = new SqlCommand(sorgu, SqlConnection);

            int id = (int)cmd.ExecuteScalar();

            sorgu = "INSERT INTO telefonlar (id,numara, tur, aktif) VALUES (@id, @numara, @tur, 1)";

            cmd = new SqlCommand(sorgu, SqlConnection);
            SqlParameter idParameter = new SqlParameter("@id", System.Data.SqlDbType.Int);
            idParameter.Value = id;
            SqlParameter numaraParameter = new SqlParameter("@numara", System.Data.SqlDbType.VarChar);
            numaraParameter.Value = numara;
            SqlParameter turParameter = new SqlParameter("@tur", System.Data.SqlDbType.VarChar);
            turParameter.Value = tur;

            cmd.Parameters.Add(idParameter);
            cmd.Parameters.Add(numaraParameter);
            cmd.Parameters.Add(turParameter);

            cmd.ExecuteNonQuery();
        }

        public static void kisiKaydet()
        {
            //@telefon_id @adres_id


        }
    }
}
