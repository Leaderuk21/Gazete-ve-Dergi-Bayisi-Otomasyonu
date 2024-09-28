using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Kullanici
    {
        private string _Kullanici_Adi;
        private string _Kullanici_Parola;
        private string _Yetki_Adi;
        private int _Yetki_Seviyesi;

        public string Kullanici_Adi { get => _Kullanici_Adi; set => _Kullanici_Adi = value; }
        public string Kullanici_Parola { get => _Kullanici_Parola; set => _Kullanici_Parola = value; }
        public int Yetki_Seviyesi { get => _Yetki_Seviyesi; set => _Yetki_Seviyesi = value; }
        public string Yetki_Adi { get => _Yetki_Adi; set => _Yetki_Adi = value; }

        public Kullanici() { }

        public Kullanici(string kullanici_Adi, string kullanici_Parola, int yetki_Seviyesi, string yetki_Adi)
        {
            this.Kullanici_Adi = kullanici_Adi;
            this.Kullanici_Parola = kullanici_Parola;
            this.Yetki_Seviyesi = yetki_Seviyesi;
            this.Yetki_Adi = yetki_Adi;
        }

        public override string ToString()
        {
            return this.Kullanici_Adi + " " + this.Yetki_Adi;
        }
    }
}
