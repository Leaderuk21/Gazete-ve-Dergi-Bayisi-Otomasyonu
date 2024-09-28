using Face;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS
{
    public partial class Form_Kullanici : Form
    {
        public Form_Kullanici()
        {
            InitializeComponent();
        }
        DataTable dt_Kullanici = new DataTable();
        ArrayList kullanicilist = Face.Kullanici.KullaniciListele();
        Entity.Kullanici kullanici = new Entity.Kullanici();
        bool isinsertable = false, isupgradable = false, isdeletaible = false;

        private void Form_Kullanici_Load(object sender, EventArgs e)
        {
            dt_Kullanici.Columns.Add("Kullanici_Adi", typeof(string));
            dt_Kullanici.Columns.Add("Kullanici_Parola", typeof(string));
            dt_Kullanici.Columns.Add("Yetki_Seviyesi", typeof(sbyte));
            dt_Kullanici.Columns.Add("Yetki_Adi", typeof(string));
            kullaniciListele();
        }

        private void kullaniciListele()
        {
            dt_Kullanici.Rows.Clear();
            foreach (Entity.Kullanici kullanici in kullanicilist)
            {
                DataRow dataRow = dt_Kullanici.NewRow();
                dataRow[0] = kullanici.Kullanici_Adi;
                dataRow[1] = kullanici.Kullanici_Parola;
                dataRow[2] = kullanici.Yetki_Seviyesi;
                dataRow[3] = kullanici.Yetki_Adi;
                dt_Kullanici.Rows.Add(dataRow);
            }
            dtg_Dergi.DataSource = dt_Kullanici;
        }

        private void Form_Kullanici_SizeChanged(object sender, EventArgs e)
        {
            Face.Util.panelListele(pnl_Dergi_Bottom);
            Face.Util.panelListele(pnl_Dergi_Top);
        }

        private void dtg_Dergi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kullanici.Kullanici_Adi = Convert.ToString(dtg_Dergi.CurrentRow.Cells[0].Value);
            kullanici.Kullanici_Parola = Convert.ToString(dtg_Dergi.CurrentRow.Cells[1].Value);
            kullanici.Yetki_Seviyesi = Convert.ToSByte(dtg_Dergi.CurrentRow.Cells[2].Value);
            kullanici.Yetki_Adi = Convert.ToString(dtg_Dergi.CurrentRow.Cells[3].Value);
            tx_Kullanici_Adi.Text = kullanici.Kullanici_Adi;
            tx_Kullanici_Parola.Text = kullanici.Kullanici_Parola;
            cmb_Kullanici_Yetki.SelectedIndex = kullanici.Yetki_Seviyesi;
            isinsertable = false;
            isupgradable = true;
            isdeletaible = true;
        }

        private void flagswitch(object sender, EventArgs e)
        {
            isinsertable = true;
            isupgradable = true;
            isdeletaible = false;
        }

        private void btn_Kullanici_Ekle_Click(object sender, EventArgs e)
        {
            if (isinsertable)
            {
                Entity.Kullanici kullanicichild = new Entity.Kullanici();
                kullanicichild.Kullanici_Adi = tx_Kullanici_Adi.Text;
                kullanicichild.Kullanici_Parola = tx_Kullanici_Parola.Text;
                kullanicichild.Yetki_Adi = cmb_Kullanici_Yetki.SelectedItem.ToString();
                kullanicichild.Yetki_Seviyesi = cmb_Kullanici_Yetki.SelectedIndex;
                Face.Kullanici.KullaniciEkle(kullanicichild);
                kullaniciListele();
                isinsertable = false;
                isupgradable = false;
                isdeletaible = false;
            }
        }

        private void btn_Kullanici_Guncelle_Click(object sender, EventArgs e)
        {
            if (isupgradable)
            {
                Entity.Kullanici kullanicichild = new Entity.Kullanici();
                kullanicichild.Kullanici_Adi = tx_Kullanici_Adi.Text;
                kullanicichild.Kullanici_Parola = tx_Kullanici_Parola.Text;
                kullanicichild.Yetki_Adi = cmb_Kullanici_Yetki.SelectedItem.ToString();
                kullanicichild.Yetki_Seviyesi = cmb_Kullanici_Yetki.SelectedIndex;
                Face.Kullanici.KullaniciGuncelle(kullanicichild);
                kullaniciListele();
                isinsertable = false;
                isupgradable = false;
                isdeletaible = false;
            }
        }

        private void btn_Kullanici_Sil_Click(object sender, EventArgs e)
        {
            if (isdeletaible)
            {
                Face.Kullanici.KullaniciSil(kullanici);
                isinsertable = true;
                isupgradable = false;
                isdeletaible = false;
                kullaniciListele();
            }
        }
    }
}
