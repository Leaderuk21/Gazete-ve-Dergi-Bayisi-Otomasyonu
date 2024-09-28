using Entity;
using Face;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS
{
    public partial class Form_Abonelik : Form
    {
        public Form_Abonelik()
        {
            InitializeComponent();
        }

        DataTable dTable_Abonelik = new DataTable();
        ArrayList abonelikList = Face.Abonelik.AbonelikListele();
        ArrayList aboneList = Face.Abone.AboneListele();
        ArrayList dergiList = Face.DergiGazete.DergiGazeteListele();
        ArrayList abonelikturList = Face.Abonelik_Tur.AbonelikTurListele();
        int abonelikID, aboneID, dergiID, abonelikturID;
        int abonelikInd, aboneInd, dergiInd, abonelikturInd;
        bool abonelikinsertFlag = false, abonelikupdateFlag = false, abonelikdeleteFlag = false;
        private void Form_Abonelik_Load(object sender, EventArgs e)
        {
            dTable_Abonelik.Columns.Add("Abonelik_ID", typeof(int));
            dTable_Abonelik.Columns.Add("Abone_Ad", typeof(string));
            dTable_Abonelik.Columns.Add("Dergi_Ad", typeof(string));
            dTable_Abonelik.Columns.Add("Abonelik_Adi", typeof(string));
            dTable_Abonelik.Columns.Add("Baslangic", typeof(DateTime));
            dTable_Abonelik.Columns.Add("Bitis", typeof(DateTime));
            dTable_Abonelik.Columns.Add("Tutar", typeof(decimal));
            AbonelikListele();
            comboListele();
            dT_Baslangic.Value = DateTime.Now;
        }

        private void Form_Abonelik_SizeChanged(object sender, EventArgs e)
        {
            Face.Util.panelListele(pnl_Abonelik);
            Face.Util.panelListele(pnl_btns_Abonelik);
        }

        private void AbonelikListele()
        {
            dTable_Abonelik.Rows.Clear();
            foreach (Entity.Abonelik_Full abonelikFull in Face.Abonelik_Full.AbonelikFullListele())
            {
                DataRow dataRow = dTable_Abonelik.NewRow();
                dataRow[0] = abonelikFull.Abonelik_ID;
                dataRow[1] = abonelikFull.Abone_Ad;
                dataRow[2] = abonelikFull.Dergi_Ad;
                dataRow[3] = abonelikFull.Abonelik_Adi;
                dataRow[4] = abonelikFull.Baslangic;
                dataRow[5] = abonelikFull.Bitis;
                dataRow[6] = abonelikFull.Tutar;
                dTable_Abonelik.Rows.Add(dataRow);
            }
            dtGrid_Abonelik.DataSource = dTable_Abonelik;
        }

        private void comboListele()
        {
            cmb_MusteriAdi.Items.Clear();
            foreach (Entity.Abone abone in aboneList)
                cmb_MusteriAdi.Items.Add(abone);

            cmb_DergiAdi.Items.Clear();
            foreach (Entity.DergiGazete dergigazete in dergiList)
                cmb_DergiAdi.Items.Add(dergigazete);

            cmb_AbonelikAdi.Items.Clear();
            foreach (Entity.Abonelik_Tur aboneliktur in abonelikturList)
                cmb_AbonelikAdi.Items.Add(aboneliktur);
        }

        private void dtGrid_Abonelik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            abonelikID = Convert.ToInt32(dtGrid_Abonelik.CurrentRow.Cells[0].Value);
            dT_Baslangic.Value = Convert.ToDateTime(dtGrid_Abonelik.CurrentRow.Cells[4].Value);
            int i = 0;
            foreach (Entity.Abonelik abonelik in abonelikList)
            {
                if (abonelik.Abonelik_ID == abonelikID)
                {
                    abonelikInd = i;
                    i = 0;
                    aboneID = abonelik.Musteri_ID;
                    dergiID = abonelik.Barkod_ID;
                    abonelikturID = abonelik.Abonelik_Tur_ID;
                    foreach (Entity.Abone abone in aboneList)
                    {
                        if (abone.Musteri_ID == aboneID)
                        {
                            aboneInd = i;
                            i = 0;
                            cmb_MusteriAdi.SelectedIndex = aboneInd;
                            break;
                        }
                        i++;
                    }
                    i = 0;
                    foreach (Entity.DergiGazete dergi in dergiList)
                    {
                        if (dergi.Barkod_ID == dergiID)
                        {
                            dergiInd = i;
                            i = 0;
                            cmb_DergiAdi.SelectedIndex = dergiInd;
                            break;
                        }
                        i++;
                    }
                    i = 0;
                    foreach (Entity.Abonelik_Tur aboneliktur in abonelikturList)
                    {
                        if (aboneliktur.Abonelik_Tur_ID == abonelikturID)
                        {
                            abonelikturInd = i;
                            i = 0;
                            cmb_AbonelikAdi.SelectedIndex = abonelikturInd;
                            break;
                        }
                        i++;
                    }
                    break;
                }
                i++;
            }
            abonelikinsertFlag = false;
            abonelikupdateFlag = true;
            abonelikdeleteFlag = true;
        }

        private void flagswitch(object sender, EventArgs e)
        {
            abonelikinsertFlag = true;
            abonelikupdateFlag = true;
            abonelikdeleteFlag = false;
        }

        private void btn_AbonelikEkle_Click(object sender, EventArgs e)
        {
            if (abonelikinsertFlag && cmb_AbonelikAdi.SelectedItem != null && cmb_DergiAdi.SelectedItem != null && cmb_MusteriAdi.SelectedItem != null)
            {
                Entity.Abonelik abonelik = new Entity.Abonelik();
                abonelik.Musteri_ID = ((Entity.Abone)cmb_MusteriAdi.SelectedItem).Musteri_ID;
                abonelik.Barkod_ID = ((Entity.DergiGazete)cmb_DergiAdi.SelectedItem).Barkod_ID;
                abonelik.Abonelik_Tur_ID = ((Entity.Abonelik_Tur)cmb_AbonelikAdi.SelectedItem).Abonelik_Tur_ID;
                abonelik.Baslangic_Tarihi = dT_Baslangic.Value.Date;
                Face.Abonelik.AbonelikEkle(abonelik);
                AbonelikListele();
                abonelikinsertFlag = false;
                abonelikupdateFlag = false;
                abonelikdeleteFlag = false;
            }
        }

        private void btn_AbonelikGuncelle_Click(object sender, EventArgs e)
        {
            if (abonelikupdateFlag && cmb_AbonelikAdi.SelectedItem != null && cmb_DergiAdi.SelectedItem != null && cmb_MusteriAdi.SelectedItem != null)
            {
                Entity.Abonelik abonelik = (Entity.Abonelik)abonelikList[abonelikInd];
                abonelik.Musteri_ID = ((Entity.Abone)cmb_MusteriAdi.SelectedItem).Musteri_ID;
                abonelik.Barkod_ID = ((Entity.DergiGazete)cmb_DergiAdi.SelectedItem).Barkod_ID;
                abonelik.Abonelik_Tur_ID = ((Entity.Abonelik_Tur)cmb_AbonelikAdi.SelectedItem).Abonelik_Tur_ID;
                abonelik.Baslangic_Tarihi = dT_Baslangic.Value.Date;
                Face.Abonelik.AbonelikGuncelle(abonelik);
                AbonelikListele();
                abonelikinsertFlag = false;
                abonelikupdateFlag = false;
                abonelikdeleteFlag = true;
            }

        }

        private void btn_AbonelikSil_Click(object sender, EventArgs e)
        {
            if (abonelikdeleteFlag && cmb_AbonelikAdi.SelectedItem != null && cmb_DergiAdi.SelectedItem != null && cmb_MusteriAdi.SelectedItem != null)
            {
                Face.Abonelik.AbonelikSil((Entity.Abonelik)abonelikList[abonelikInd]);
                AbonelikListele();
                abonelikinsertFlag = true;
                abonelikupdateFlag = false;
                abonelikdeleteFlag = false;
            }
        }

        private void btn_AbonelikRaporla_Click(object sender, EventArgs e)
        {
            sfd_Abonelik.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            sfd_Abonelik.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası|*.xls";
            sfd_Abonelik.ShowDialog();
            if (sfd_Abonelik.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = sfd_Abonelik.FileName;
                Face.Util.ExportDataToExcel(dTable_Abonelik, DosyaYolu);
                return;
            }
        }
    }
}
