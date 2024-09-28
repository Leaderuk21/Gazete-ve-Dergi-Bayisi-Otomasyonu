using System;
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
    public partial class Kullanici_Giris : Form
    {
        public Kullanici_Giris()
        {
            InitializeComponent();
        }

        private void btn_Kullanici_Giris_Click(object sender, EventArgs e)
        {
            Entity.Kullanici giris = new Entity.Kullanici();
            giris.Kullanici_Adi = Face.Kontrol.Temizle(tx_Kullanici_Adi.Text);
            giris.Kullanici_Parola = Face.Kontrol.Temizle(tx_Kullanici_Parola.Text);
            Entity.Kullanici kullanici = Face.Kullanici.KullaniciAra(giris.Kullanici_Adi, giris.Kullanici_Parola);
            if (kullanici != null)
            {
                VTYS_Main.kullanici = kullanici;
                this.DialogResult = DialogResult.OK;
                VTYS_Main vTYS_Main = new VTYS_Main();
                vTYS_Main.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Kullanıcı Adı veya Parola Hatalı Girilmiştir.", "Kullanıcı bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void Kullanici_Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
