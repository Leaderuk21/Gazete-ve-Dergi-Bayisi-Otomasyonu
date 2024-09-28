using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Face
{
    public class Kullanici
    {
        public static Entity.Kullanici KullaniciAra(string ad,string parola)
        {
            Entity.Kullanici kullanici = null;
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("KullaniciAra", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Kullanici_Adi", ad);
            cmd.Parameters.AddWithValue("@Kullanici_Parola", parola);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    kullanici = new Entity.Kullanici();
                    kullanici.Kullanici_Adi = Convert.ToString(rdr["Kullanici_Adi"]);
                    kullanici.Kullanici_Parola = Convert.ToString(rdr["Kullanici_Parola"]);
                    kullanici.Yetki_Seviyesi = Convert.ToSByte(rdr["Yetki_Seviyesi"]);
                    kullanici.Yetki_Adi = yetkiBul(kullanici.Yetki_Seviyesi);
                }
                rdr.Close();
            }
            catch (SqlException ex) { string message = ex.Message; }
            finally { cnn.Close(); }
            return kullanici;
        }

        public static ArrayList KullaniciListele()
        {
            ArrayList list = new ArrayList();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Select * From Kullanici",cnn);
            try
            {
                if(cnn.State==ConnectionState.Closed)
                    cnn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Entity.Kullanici kullanici = new Entity.Kullanici();
                    kullanici.Kullanici_Adi = Convert.ToString(rdr["Kullanici_Adi"]);
                    kullanici.Kullanici_Parola = Convert.ToString(rdr["Kullanici_Parola"]);
                    kullanici.Yetki_Seviyesi = Convert.ToSByte(rdr["Yetki_Seviyesi"]);
                    kullanici.Yetki_Adi = yetkiBul(kullanici.Yetki_Seviyesi);
                    list.Add(kullanici);
                }
                rdr.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { cnn.Close(); }
            return list;
        }

        public static int KullaniciEkle(Entity.Kullanici kullanici)
        {
            SqlConnection cnn=new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("KullaniciEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Kullanici_Adi", kullanici.Kullanici_Adi);
            cmd.Parameters.AddWithValue("@Kullanici_Parola", kullanici.Kullanici_Parola);
            cmd.Parameters.AddWithValue("@Yetki_Seviyesi", kullanici.Yetki_Seviyesi);
            return Util.Yurut(cmd);
        }

        public static int KullaniciGuncelle(Entity.Kullanici kullanici)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("KullaniciGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Kullanici_Adi", kullanici.Kullanici_Adi);
            cmd.Parameters.AddWithValue("@Kullanici_Parola", kullanici.Kullanici_Parola);
            cmd.Parameters.AddWithValue("@Yetki_Seviyesi", kullanici.Yetki_Seviyesi);
            return Util.Yurut(cmd);
        }

        public static int KullaniciSil(Entity.Kullanici kullanici)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Kullanicisil", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Kullanici_Adi", kullanici.Kullanici_Adi);
            return Util.Yurut(cmd);
        }

        public static string yetkiBul(int yetki_Seviyesi)
        {
            if (yetki_Seviyesi == 0) return "Yönetici";
            else if (yetki_Seviyesi == 1) return "Müdür";
            return "Çalışan";
        }

        public static sbyte yetkiVer(string yetki_adi)
        {
            if (yetki_adi == "Yönetici") return 0;
            else if (yetki_adi == "Müdür") return 1;
            return 2;
        }
    }
}
