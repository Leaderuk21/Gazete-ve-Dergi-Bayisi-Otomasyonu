using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Abone
    {
        private int _Musteri_ID;
        private string _Mail;
        private string _Tel_NO;
        private string _Ad;
        private string _Soyad;
        private string _Adres;
        private DateTime _Kayit_Tarihi;

        public int Musteri_ID { get => _Musteri_ID; set => _Musteri_ID = value; }
        public string Mail { get => _Mail; set => _Mail = value; }
        public string Tel_NO { get => _Tel_NO; set => _Tel_NO = value; }
        public string Ad { get => _Ad; set => _Ad = value; }
        public string Soyad { get => _Soyad; set => _Soyad = value; }
        public string Adres { get => _Adres; set => _Adres = value; }
        public DateTime Kayit_Tarihi { get => _Kayit_Tarihi; set => _Kayit_Tarihi = value; }

        public Abone() { }

        public Abone(int musteri_ID, string mail, string tel_NO, string ad, string soyad, string adres, DateTime kayit_Tarihi)
        {
            this.Musteri_ID = musteri_ID;
            this.Mail = mail;
            this.Tel_NO = tel_NO;
            this.Ad = ad;
            this.Soyad = soyad;
            this.Adres = adres;
            this.Kayit_Tarihi = kayit_Tarihi;
        }

        public override string ToString()
        {
            return this.Ad+" "+this.Soyad;
        }
    }
}
