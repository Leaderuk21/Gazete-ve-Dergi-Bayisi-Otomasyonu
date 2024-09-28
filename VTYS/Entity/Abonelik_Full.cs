using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Abonelik_Full
    {
        private int _Abonelik_ID;
        private string _Abone_Ad;
        private string _Dergi_Ad;
        private string _Abonelik_Adi;
        private DateTime _Baslangic;
        private DateTime _Bitis;
        private decimal _Tutar;

        public Abonelik_Full() { }

        public Abonelik_Full(int abonelik_ID,string abone_Ad,string dergi_Ad,string abonelik_Adi,DateTime baslangic,DateTime bitis,decimal tutar)
        {
            this._Abonelik_ID = abonelik_ID;
            this._Abone_Ad = abone_Ad;
            this._Dergi_Ad = dergi_Ad;
            this._Abonelik_Adi = abonelik_Adi;
            this._Baslangic = baslangic;
            this._Bitis = bitis;
            this._Tutar = tutar;
        }

        public int Abonelik_ID { get => _Abonelik_ID; set => _Abonelik_ID = value; }
        public string Abone_Ad { get => _Abone_Ad; set => _Abone_Ad = value; }
        public string Dergi_Ad { get => _Dergi_Ad; set => _Dergi_Ad = value; }
        public string Abonelik_Adi { get => _Abonelik_Adi; set => _Abonelik_Adi = value; }
        public DateTime Baslangic { get => _Baslangic; set => _Baslangic = value; }
        public DateTime Bitis { get => _Bitis; set => _Bitis = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }

        public override string ToString()
        {
            return this.Abone_Ad + " " + this.Dergi_Ad + " " + this.Abonelik_Adi;
        }
    }
}
