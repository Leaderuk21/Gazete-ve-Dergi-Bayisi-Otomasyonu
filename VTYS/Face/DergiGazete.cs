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
    public class DergiGazete
    {
        public static ArrayList DergiGazeteListele()
        {
            ArrayList dergigazeteliste = new ArrayList();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Select * From DergiGazete",cnn);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Entity.DergiGazete dergigazete = new Entity.DergiGazete();
                    dergigazete.Barkod_ID = Convert.ToInt32(rdr["Barkod_ID"]);
                    dergigazete.Tur = Convert.ToString(rdr["Tur"]);
                    dergigazete.Ucret = Convert.ToDecimal(rdr["Ucret"]);
                    dergigazete.Ad = Convert.ToString(rdr["Ad"]);
                    dergigazete.Yayin_Evi = Convert.ToString(rdr["Yayin_evi"]);
                    dergigazeteliste.Add(dergigazete);
                }
                rdr.Close();
            }
            catch (SqlException ex)
            {
                string message = ex.Message;
            }
            finally { cnn.Close(); }
            return dergigazeteliste;
        }

        public static ArrayList DergiGazeteAra(string ak,string tur)
        {
            ArrayList dergigazeteliste = new ArrayList();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("DergiAra", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@aranan_kelime", ak);
            cmd.Parameters.AddWithValue("@tur", tur);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Entity.DergiGazete dergigazete = new Entity.DergiGazete();
                    dergigazete.Barkod_ID = Convert.ToInt32(rdr["Barkod_ID"]);
                    dergigazete.Tur = Convert.ToString(rdr["Tur"]);
                    dergigazete.Ucret = Convert.ToDecimal(rdr["Ucret"]);
                    dergigazete.Ad = Convert.ToString(rdr["Ad"]);
                    dergigazete.Yayin_Evi = Convert.ToString(rdr["Yayin_evi"]);
                    dergigazeteliste.Add(dergigazete);
                }
                rdr.Close();
            }
            catch (SqlException ex)
            {
                string message = ex.Message;
            }
            finally { cnn.Close(); }
            return dergigazeteliste;
        }

        public static int DergiGazeteEkle(Entity.DergiGazete dergigazete)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("DergiEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Barkod_ID", dergigazete.Barkod_ID);
            cmd.Parameters.AddWithValue("@Tur", dergigazete.Tur);
            cmd.Parameters.AddWithValue("@Ucret", dergigazete.Ucret);
            cmd.Parameters.AddWithValue("@Ad", dergigazete.Ad);
            cmd.Parameters.AddWithValue("@Yayin_Evi", dergigazete.Yayin_Evi);
            return Util.Yurut(cmd);
        }

        public static int DergiGazeteGuncelle(Entity.DergiGazete dergigazete)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("DergiDuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Barkod_ID", dergigazete.Barkod_ID);
            cmd.Parameters.AddWithValue("@Tur", dergigazete.Tur);
            cmd.Parameters.AddWithValue("@Ucret", dergigazete.Ucret);
            cmd.Parameters.AddWithValue("@Ad", dergigazete.Ad);
            cmd.Parameters.AddWithValue("@Yayin_Evi", dergigazete.Yayin_Evi);
            return Util.Yurut(cmd);
        }

        public static int DergiGazeteSil(Entity.DergiGazete dergigazete)
        {
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("DergiSil", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Barkod_ID", dergigazete.Barkod_ID);
            return Util.Yurut(cmd);
        }
    }
}
