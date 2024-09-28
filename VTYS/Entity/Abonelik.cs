using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Abonelik
    {
        private int _Abonelik_ID;
        private int _Abonelik_Tur_ID;
        private int _Barkod_ID;
        private int _Musteri_ID;
        private DateTime _Baslangic_Tarihi;
        private DateTime _Bitis_Tarihi;
        private decimal _Tutar;

        public int Abonelik_ID { get => _Abonelik_ID; set => _Abonelik_ID = value; }
        public int Abonelik_Tur_ID { get => _Abonelik_Tur_ID; set => _Abonelik_Tur_ID = value; }
        public int Barkod_ID { get => _Barkod_ID; set => _Barkod_ID = value; }
        public int Musteri_ID { get => _Musteri_ID; set => _Musteri_ID = value; }
        public DateTime Baslangic_Tarihi { get => _Baslangic_Tarihi; set => _Baslangic_Tarihi = value; }
        public DateTime Bitis_Tarihi { get => _Bitis_Tarihi; set => _Bitis_Tarihi = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }

        public Abonelik() { }

        public Abonelik(int abonelik_ID, int abonelik_Tur_ID, int barkod_ID, int musteri_ID, DateTime baslangic_Tarihi, DateTime bitis_Tarihi, decimal tutar)
        {
            this.Abonelik_ID = abonelik_ID;
            this.Abonelik_Tur_ID = abonelik_Tur_ID;
            this.Barkod_ID = barkod_ID;
            this.Musteri_ID = musteri_ID;
            this.Baslangic_Tarihi = baslangic_Tarihi;
            this.Bitis_Tarihi = bitis_Tarihi;
            this.Tutar = tutar;
        }

        public override string ToString()
        {
            return Abonelik_ID.ToString() + " " + Abonelik_Tur_ID.ToString() + " " + Musteri_ID.ToString();
        }
    }
}
