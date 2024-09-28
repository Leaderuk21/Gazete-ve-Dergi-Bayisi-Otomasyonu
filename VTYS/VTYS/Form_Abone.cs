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
    public partial class Form_Abone : Form
    {
        public Form_Abone()
        {
            InitializeComponent();
        }
        DataTable dt_Abone = new DataTable();
        ArrayList aboneliste = Face.Abone.AboneListele();
        Entity.Abone abone = new Entity.Abone();
        bool isinsertable = false, isupgradable = false, isdeletaible = false;

        private void Form_Abone_Load(object sender, EventArgs e)
        {
            dt_Abone.Columns.Add("Musteri_ID", typeof(Int32));
            dt_Abone.Columns.Add("Ad", typeof(string));
            dt_Abone.Columns.Add("Soyad", typeof(string));
            dt_Abone.Columns.Add("Tel_No", typeof(string));
            dt_Abone.Columns.Add("Mail", typeof(string));
            dt_Abone.Columns.Add("Adres", typeof(string));
            dt_Abone.Columns.Add("Kayit_Tarihi", typeof(DateTime));
            aboneListele();
        }

        private void aboneListele()
        {
            dt_Abone.Rows.Clear();
            foreach (Entity.Abone abone in aboneliste)
            {
                DataRow dataRow = dt_Abone.NewRow();
                dataRow[0] = abone.Musteri_ID;
                dataRow[1] = abone.Ad;
                dataRow[2] = abone.Soyad;
                dataRow[3] = abone.Tel_NO;
                dataRow[4] = abone.Mail;
                dataRow[5] = abone.Adres;
                dataRow[6] = abone.Kayit_Tarihi;
                dt_Abone.Rows.Add(dataRow);
            }
            dtGrid_Abone.DataSource = dt_Abone;
        }

        private void Form_Abone_SizeChanged(object sender, EventArgs e)
        {
            Face.Util.panelListele(pnl_Abone_Bottom);
            Face.Util.panelListele(pnl_Abone_Top);
        }

        private void dtGrid_Abone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            abone.Musteri_ID = Convert.ToInt32(dtGrid_Abone.CurrentRow.Cells[0].Value);
            abone.Ad = Convert.ToString(dtGrid_Abone.CurrentRow.Cells[1].Value);
            abone.Soyad = Convert.ToString(dtGrid_Abone.CurrentRow.Cells[2].Value);
            abone.Tel_NO = Convert.ToString(dtGrid_Abone.CurrentRow.Cells[3].Value);
            abone.Mail = Convert.ToString(dtGrid_Abone.CurrentRow.Cells[4].Value);
            abone.Adres = Convert.ToString(dtGrid_Abone.CurrentRow.Cells[5].Value);
            abone.Kayit_Tarihi = Convert.ToDateTime(dtGrid_Abone.CurrentRow.Cells[6].Value);
            tx_Abone_Ad.Text = abone.Ad;
            tx_Abone_Soyad.Text = abone.Soyad;
            tx_Abone_Tel_No.Text = abone.Tel_NO;
            tx_Abone_Mail.Text = abone.Mail;
            tx_Abone_Adres.Text = abone.Adres;
            dtp_Abone_Kayit_Tarihi.Value = abone.Kayit_Tarihi;
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

        private void btn_Abone_Ekle_Click(object sender, EventArgs e)
        {
            if (isinsertable)
            {
                Entity.Abone abonechild = new Entity.Abone();
                abonechild.Ad = tx_Abone_Ad.Text;
                abonechild.Soyad = tx_Abone_Soyad.Text;
                abonechild.Tel_NO = tx_Abone_Tel_No.Text;
                abonechild.Mail = tx_Abone_Mail.Text;
                abonechild.Adres = tx_Abone_Adres.Text;
                abonechild.Kayit_Tarihi = dtp_Abone_Kayit_Tarihi.Value;
                Face.Abone.AboneEkle(abonechild);
                aboneListele();
                isinsertable = false;
                isupgradable = false;
                isdeletaible = false;
            }
        }

        private void btn_Abone_Guncelle_Click(object sender, EventArgs e)
        {
            if (isupgradable)
            {
                Entity.Abone abonechild = new Entity.Abone();
                abonechild.Ad = tx_Abone_Ad.Text;
                abonechild.Soyad = tx_Abone_Soyad.Text;
                abonechild.Tel_NO = tx_Abone_Tel_No.Text;
                abonechild.Mail = tx_Abone_Mail.Text;
                abonechild.Adres = tx_Abone_Adres.Text;
                abonechild.Kayit_Tarihi = dtp_Abone_Kayit_Tarihi.Value;
                Face.Abone.AboneGuncelle(abonechild);
                aboneListele();
                isinsertable = false;
                isupgradable = false;
                isdeletaible = true;
            }
        }

        private void btn_Abone_Sil_Click(object sender, EventArgs e)
        {
            if (isdeletaible)
            {
                Face.Abone.AboneSil(abone);
                isinsertable = true;
                isupgradable = false;
                isdeletaible = false;
                aboneListele();
            }
        }

        private void btn_Abone_Raporla_Click(object sender, EventArgs e)
        {
            sfd_Abone.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            sfd_Abone.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası|*.xls";
            sfd_Abone.ShowDialog();
            if (sfd_Abone.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = sfd_Abone.FileName;
                Face.Util.ExportDataToExcel(dt_Abone, DosyaYolu);
                return;
            }
        }
    }
}
