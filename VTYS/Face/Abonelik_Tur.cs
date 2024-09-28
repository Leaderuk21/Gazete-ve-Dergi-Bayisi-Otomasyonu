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
    public class Abonelik_Tur
    {
        public static ArrayList AbonelikTurListele()
        {
            ArrayList abonelikturliste = new ArrayList();
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("Select * From Abonelik_Tur ", cnn);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Entity.Abonelik_Tur aboneliktur =new Entity.Abonelik_Tur();
                    aboneliktur.Abonelik_Tur_ID = Convert.ToInt32(rdr["Abonelik_Tur_ID"]);
                    aboneliktur.Abonelik_Adi = Convert.ToString(rdr["Abonelik_Adi"]);
                    aboneliktur.Katsayi = Convert.ToDecimal(rdr["Katsayi"]);
                    aboneliktur.Sure = Convert.ToByte(rdr["Sure"]);
                    abonelikturliste.Add(aboneliktur);
                }
                rdr.Close();
            }
            catch (Exception ex) { string message = ex.Message; }
            finally { cnn.Close(); }
            return abonelikturliste;
        }

        public static Entity.Abonelik_Tur AbonelikTurAra(int id)
        {
            Entity.Abonelik_Tur aboneliktur = null;
            SqlConnection cnn = new SqlConnection(Util.cnnstring);
            SqlCommand cmd = new SqlCommand("AbonelikTurAra", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Abonelik_Tur_ID", id);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                aboneliktur = new Entity.Abonelik_Tur();
                aboneliktur.Abonelik_Tur_ID = Convert.ToInt32(rdr["Abonelik_Tur_ID"]);
                aboneliktur.Abonelik_Adi = Convert.ToString(rdr["Abonelik_Adi"]);
                aboneliktur.Katsayi = Convert.ToDecimal(rdr["Katsayi"]);
                aboneliktur.Sure = Convert.ToByte(rdr["Sure"]);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return aboneliktur;
        }
    }
}
