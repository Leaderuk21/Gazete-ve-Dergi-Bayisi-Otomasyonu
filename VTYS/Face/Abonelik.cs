using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face
{
    public class Abonelik
    {
        public static ArrayList AbonelikListele()
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Select * from Abonelik ",cnn);
            ArrayList abonelikliste = new ArrayList();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Entity.Abonelik abonelik = new Entity.Abonelik();
                    abonelik.Abonelik_ID = Convert.ToInt32(rdr["Abonelik_ID"]);
                    abonelik.Abonelik_Tur_ID = Convert.ToInt32(rdr["Abonelik_Tur_ID"]);
                    abonelik.Barkod_ID = Convert.ToInt32(rdr["Barkod_ID"]);
                    abonelik.Musteri_ID = Convert.ToInt32(rdr["Musteri_ID"]);
                    abonelik.Baslangic_Tarihi = Convert.ToDateTime(rdr["Baslangic_tarih"]);
                    abonelik.Bitis_Tarihi = Convert.ToDateTime(rdr["Bitis_Tarihi"]);
                    abonelik.Tutar = Convert.ToDecimal(rdr["Tutar"]);
                    abonelikliste.Add(abonelik);
                }
                rdr.Close();
            }
            catch (SqlException ex) { string message = ex.Message; }
            finally { cnn.Close(); }
            return abonelikliste;
        }

        public static ArrayList AbonelikAra(string ata,string dta,string da,string aa)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("AbonelikAra", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AbonelikTurAdi", ata);
            cmd.Parameters.AddWithValue("@DergiTurAdi", dta);
            cmd.Parameters.AddWithValue("@DergiAdi", da);
            cmd.Parameters.AddWithValue("@AboneAdi", aa);
            ArrayList abonelikliste = new ArrayList();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Entity.Abonelik abonelik = new Entity.Abonelik();
                    abonelik.Abonelik_ID = Convert.ToInt32(rdr["Abonelik_ID"]);
                    abonelik.Abonelik_Tur_ID = Convert.ToInt32(rdr["Abonelik_Tur_ID"]);
                    abonelik.Barkod_ID = Convert.ToInt32(rdr["Barkod_ID"]);
                    abonelik.Musteri_ID = Convert.ToInt32(rdr["Musteri_ID"]);
                    abonelik.Baslangic_Tarihi = Convert.ToDateTime(rdr["Baslangic_Tarihi"]);
                    abonelik.Bitis_Tarihi = Convert.ToDateTime(rdr["Bitis_Tarihi"]);
                    abonelik.Tutar = Convert.ToDecimal(rdr["Tutar"]);
                    abonelikliste.Add(abonelik);
                }

            }
            catch (SqlException ex)
            {
                string message = ex.Message;
            }
            finally { cnn.Close(); }
            return abonelikliste;
        }

        public static int AbonelikEkle(Entity.Abonelik abonelik)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("AbonelikEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Abone_Tur_ID", abonelik.Abonelik_Tur_ID);
            cmd.Parameters.AddWithValue("@Barkod_ID", abonelik.Barkod_ID);
            cmd.Parameters.AddWithValue("@Musteri_ID", abonelik.Musteri_ID);
            cmd.Parameters.AddWithValue("@Baslangic_Tarih", abonelik.Baslangic_Tarihi);
            return Util.Yurut(cmd);
        }

        public static int AbonelikGuncelle(Entity.Abonelik abonelik) {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("AbonelikGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Abonelik_ID", abonelik.Abonelik_ID);
            cmd.Parameters.AddWithValue("@Abonelik_Tur_ID", abonelik.Abonelik_Tur_ID);
            cmd.Parameters.AddWithValue("@Barkod_ID", abonelik.Barkod_ID);
            cmd.Parameters.AddWithValue("@Musteri_ID", abonelik.Musteri_ID);
            cmd.Parameters.AddWithValue("@Baslangic_Tarih", abonelik.Baslangic_Tarihi);
            return Util.Yurut(cmd);
        }

        public static int AbonelikSil(Entity.Abonelik abonelik)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("AbonelikSil", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Abonelik_ID", abonelik.Abonelik_ID);
            return Util.Yurut(cmd);
        }
    }
}
