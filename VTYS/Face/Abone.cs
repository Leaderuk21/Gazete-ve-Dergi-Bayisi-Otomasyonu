using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face
{
    public class Abone
    {
        public static ArrayList AboneListele()
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Select * from Abone", cnn);
            ArrayList aboneliste = new ArrayList();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Entity.Abone abone = new Entity.Abone();
                    abone.Musteri_ID = Convert.ToInt32(rdr["Musteri_ID"]);
                    abone.Mail = Convert.ToString(rdr["Mail"]);
                    abone.Tel_NO = Convert.ToString(rdr["Tel_No"]);
                    abone.Ad = Convert.ToString(rdr["Ad"]);
                    abone.Soyad = Convert.ToString(rdr["Soyad"]);
                    abone.Adres = Convert.ToString(rdr["Adres"]);
                    abone.Kayit_Tarihi = Convert.ToDateTime(rdr["Kayit_Tarihi"]);
                    aboneliste.Add(abone);
                }
                rdr.Close();
            }
            catch (SqlException ex)
            {
                string message = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return aboneliste;
        }

        public static ArrayList AboneAra(string arama)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("AboneAra", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@aranan_kelime", arama);
            ArrayList aboneliste = new ArrayList();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Entity.Abone abone = new Entity.Abone();
                    abone.Musteri_ID = Convert.ToInt32(rdr["Musteri_ID"]);
                    abone.Mail = Convert.ToString(rdr["Mail"]);
                    abone.Tel_NO = Convert.ToString(rdr["Tel_No"]);
                    abone.Ad = Convert.ToString(rdr["Ad"]);
                    abone.Soyad = Convert.ToString(rdr["Soyad"]);
                    abone.Adres = Convert.ToString(rdr["Adres"]);
                    abone.Kayit_Tarihi = Convert.ToDateTime(rdr["Kayit_Tarihi"]);
                    aboneliste.Add(abone);
                }
                rdr.Close();
            }
            catch (SqlException ex)
            {
                string msg = ex.Message;
            }
            finally { cnn.Close(); }
            return aboneliste;
        }

        public static int AboneEkle(Entity.Abone abone)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("AboneEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Mail", abone.Mail);
            cmd.Parameters.AddWithValue("@Tel_No", abone.Tel_NO);
            cmd.Parameters.AddWithValue("@Ad", abone.Ad);
            cmd.Parameters.AddWithValue("@Soyad", abone.Soyad);
            cmd.Parameters.AddWithValue("@Kayit_Tarihi", abone.Kayit_Tarihi);
            cmd.Parameters.AddWithValue("@Adres", abone.Adres);
            return Util.Yurut(cmd);
        }
        public static int AboneGuncelle(Entity.Abone abone)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("AboneGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Musteri_ID", abone.Musteri_ID);
            cmd.Parameters.AddWithValue("@Mail", abone.Mail);
            cmd.Parameters.AddWithValue("@Tel_No", abone.Tel_NO);
            cmd.Parameters.AddWithValue("@Ad", abone.Ad);
            cmd.Parameters.AddWithValue("@Soyad", abone.Soyad);
            cmd.Parameters.AddWithValue("@Kayit_Tarihi", abone.Kayit_Tarihi);
            cmd.Parameters.AddWithValue("@Adres", abone.Adres);
            return Util.Yurut(cmd);
        }

        public static int AboneSil(Entity.Abone abone)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("AboneSil", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Musteri_ID", abone.Musteri_ID);
            return Util.Yurut(cmd);
        }
    }
}
