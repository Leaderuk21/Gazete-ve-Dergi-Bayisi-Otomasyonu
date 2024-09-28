using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DergiGazete
    {
        private int _Barkod_ID;
        private string _Ad;
        private string _Yayin_Evi;
        private string _Tur;
        private decimal _Ucret;

        public int Barkod_ID { get => _Barkod_ID; set => _Barkod_ID = value; }
        public string Ad { get => _Ad; set => _Ad = value; }
        public string Yayin_Evi { get => _Yayin_Evi; set => _Yayin_Evi = value; }
        public string Tur { get => _Tur; set => _Tur = value; }
        public decimal Ucret { get => _Ucret; set => _Ucret = value; }

        public DergiGazete() { }

        public DergiGazete(int barkod_ID, string ad, string yayin_Evi, string tur, decimal ucret)
        {
            Barkod_ID = barkod_ID;
            Ad = ad;
            Yayin_Evi = yayin_Evi;
            Tur = tur;
            Ucret = ucret;
        }

        public override string ToString()
        {
            return Ad.ToString() + " " + Yayin_Evi.ToString();
        }
    }
}
