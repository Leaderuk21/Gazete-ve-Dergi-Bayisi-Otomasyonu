using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Abonelik_Tur
    {
        private int _Abonelik_Tur_ID;
        private string _Abonelik_Adi;
        private decimal _Katsayi;
        private int _Sure;

        public int Abonelik_Tur_ID { get => _Abonelik_Tur_ID; set => _Abonelik_Tur_ID = value; }
        public string Abonelik_Adi { get => _Abonelik_Adi; set => _Abonelik_Adi = value; }
        public decimal Katsayi { get => _Katsayi; set => _Katsayi = value; }
        public int Sure { get => _Sure; set => _Sure = value; }

        public Abonelik_Tur() { }

        public Abonelik_Tur(int abonelik_Tur_ID, string abonelik_Adi, decimal katsayi, int sure)
        {
            this.Abonelik_Tur_ID = abonelik_Tur_ID;
            this.Abonelik_Adi = abonelik_Adi;
            this.Katsayi = katsayi;
            this.Sure = sure;
        }

        public override string ToString()
        {
            return Abonelik_Adi.ToString();
        }
    }
}
