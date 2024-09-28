using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face
{
    public class Kontrol
    {
        public Kontrol() { }

        public static string Temizle(string metin)
        {
            metin = metin.Replace(" ", "");
            metin = metin.Replace("'", "");
            metin = metin.Replace("?", "");
            metin = metin.Replace("[", "");
            metin = metin.Replace("]", "");
            metin = metin.Replace("(", "");
            metin = metin.Replace(")", "");
            metin = metin.Replace(":", "");
            metin = metin.Replace(";", "");
            metin = metin.Replace(",", "");
            metin = metin.Replace(".", "");
            return metin;
        }
    }
}
