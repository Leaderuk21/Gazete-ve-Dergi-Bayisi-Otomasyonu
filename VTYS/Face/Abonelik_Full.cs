using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Face
{
    public class Abonelik_Full
    {
        public static ArrayList AbonelikFullListele()
        {
            ArrayList view = new ArrayList();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("SELECT A.Abonelik_ID,Ab.Ad As Abone_Ad,D.Ad As Dergi_Ad," +
                "ATU.Abonelik_Adi,A.Baslangic_Tarih,A.Bitis_Tarihi,A.Tutar  " +
                "FROM Abonelik AS A  " +
                "INNER JOIN Abonelik_Tur AS ATU ON A.Abonelik_Tur_ID = ATU.Abonelik_Tur_ID  " +
                "INNER JOIN DergiGazete AS D ON A.Barkod_ID = D.Barkod_ID  " +
                "INNER JOIN Abone AS Ab ON A.Musteri_ID = Ab.Musteri_ID", cnn);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Entity.Abonelik_Full full_abone = new Entity.Abonelik_Full();
                    full_abone.Abonelik_ID = Convert.ToInt32(rdr["Abonelik_ID"]);
                    full_abone.Abone_Ad = Convert.ToString(rdr["Abone_Ad"]);
                    full_abone.Dergi_Ad = Convert.ToString(rdr["Dergi_Ad"]);
                    full_abone.Abonelik_Adi = Convert.ToString(rdr["Abonelik_Adi"]);
                    full_abone.Baslangic = Convert.ToDateTime(rdr["Baslangic_Tarih"]);
                    full_abone.Bitis = Convert.ToDateTime(rdr["Bitis_Tarihi"]);
                    full_abone.Tutar = Convert.ToDecimal(rdr["Tutar"]);
                    view.Add(full_abone);
                }
                rdr.Close();
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally { cnn.Close(); }
            return view;
        }
    }
}
