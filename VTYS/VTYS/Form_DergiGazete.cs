using System.Collections;
using System.Data;

namespace VTYS
{
    public partial class Form_DergiGazete : Form
    {
        public Form_DergiGazete()
        {
            InitializeComponent();
        }
        DataTable dt_Dergi = new DataTable();
        ArrayList dergilist = Face.DergiGazete.DergiGazeteListele();
        Entity.DergiGazete dergi = new Entity.DergiGazete();
        bool isinsertable = false, isupgradable = false, isdeletaible = false;

        private void Form_DergiGazete_Load(object sender, EventArgs e)
        {
            dt_Dergi.Columns.Add("Barkod_ID", typeof(Int32));
            dt_Dergi.Columns.Add("Ad", typeof(string));
            dt_Dergi.Columns.Add("Yayin_Evi", typeof(string));
            dt_Dergi.Columns.Add("Tur", typeof(string));
            dt_Dergi.Columns.Add("Ucret", typeof(decimal));
            dergiListele();
        }

        private void dergiListele()
        {
            dt_Dergi.Rows.Clear();
            foreach (Entity.DergiGazete dergi in dergilist)
            {
                DataRow dataRow = dt_Dergi.NewRow();
                dataRow[0] = dergi.Barkod_ID;
                dataRow[1] = dergi.Ad;
                dataRow[2] = dergi.Yayin_Evi;
                dataRow[3] = dergi.Tur;
                dataRow[4] = dergi.Ucret;
                dt_Dergi.Rows.Add(dataRow);
            }
            dtg_Dergi.DataSource = dt_Dergi;
        }

        private void Form_DergiGazete_SizeChanged(object sender, EventArgs e)
        {
            Face.Util.panelListele(pnl_Dergi_Bottom);
            Face.Util.panelListele(pnl_Dergi_Top);
        }

        private void dtg_Dergi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dergi.Barkod_ID = Convert.ToInt32(dtg_Dergi.CurrentRow.Cells[0].Value);
            dergi.Ad = Convert.ToString(dtg_Dergi.CurrentRow.Cells[1].Value);
            dergi.Yayin_Evi = Convert.ToString(dtg_Dergi.CurrentRow.Cells[2].Value);
            dergi.Tur = Convert.ToString(dtg_Dergi.CurrentRow.Cells[3].Value);
            dergi.Ucret = Convert.ToDecimal(dtg_Dergi.CurrentRow.Cells[4].Value);
            tx_Dergi_Ad.Text = dergi.Ad;
            tx_Dergi_Yayin_Evi.Text = dergi.Yayin_Evi;
            tx_Dergi_Tur.Text = dergi.Tur;
            tx_Dergi_Ucret.Text = Convert.ToString(dergi.Ucret);
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
        private void tx_Dergi_Ucret_KeyPress(object sender, KeyPressEventArgs args)
        {
            const int BACKSPACE = 8;
            const int DECIMAL_POINT = 46;
            const int ZERO = 48;
            const int NINE = 57;
            const int NOT_FOUND = -1;

            int keyvalue = (int)args.KeyChar; // not really necessary to cast to int

            if ((keyvalue == BACKSPACE) ||
            ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;
            // Allow the first (but only the first) decimal point
            if ((keyvalue == DECIMAL_POINT) &&
            (tx_Dergi_Ucret.Text.IndexOf(".") == NOT_FOUND)) return;
            // Allow nothing else
            args.Handled = true;
        }

        private void btn_Dergi_Ekle_Click(object sender, EventArgs e)
        {
            if (isinsertable)
            {
                Entity.DergiGazete dergichild = new Entity.DergiGazete();
                dergichild.Ad = tx_Dergi_Ad.Text;
                dergichild.Yayin_Evi = tx_Dergi_Yayin_Evi.Text;
                dergichild.Tur = tx_Dergi_Tur.Text;
                dergichild.Ucret = Convert.ToDecimal(tx_Dergi_Ucret.Text);
                Face.DergiGazete.DergiGazeteEkle(dergichild);
                dergiListele();
                isinsertable = false;
                isupgradable = false;
                isdeletaible = false;
            }
        }

        private void btn_Dergi_Guncelle_Click(object sender, EventArgs e)
        {
            if (isupgradable)
            {
                Entity.DergiGazete dergichild = new Entity.DergiGazete();
                dergichild.Ad = tx_Dergi_Ad.Text;
                dergichild.Yayin_Evi = tx_Dergi_Yayin_Evi.Text;
                dergichild.Tur = tx_Dergi_Tur.Text;
                dergichild.Ucret = Convert.ToDecimal(tx_Dergi_Ucret.Text);
                Face.DergiGazete.DergiGazeteGuncelle(dergichild);
                dergiListele();
                isinsertable = false;
                isupgradable = false;
                isdeletaible = true;
            }
        }

        private void btn_Dergi_Sil_Click(object sender, EventArgs e)
        {
            if (isdeletaible)
            {
                Face.DergiGazete.DergiGazeteSil(dergi);
                isinsertable = true;
                isupgradable = false;
                isdeletaible = false;
                dergiListele();
            }
        }

        private void btn_Dergi_Raporla_Click(object sender, EventArgs e)
        {
            sfd_Export.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            sfd_Export.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası|*.xls";
            sfd_Export.ShowDialog();
            if (sfd_Export.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = sfd_Export.FileName;
                Face.Util.ExportDataToExcel(dt_Dergi, DosyaYolu);
                return;
            }
        }

        private void btn_Dergi_Import_Click(object sender, EventArgs e)
        {
            ofd_Import.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd_Import.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası|*.xls";
            ofd_Import.ShowDialog();
            if (ofd_Import.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = ofd_Import.FileName;
                DataTable dtable = Face.Util.ImportDataFromExcel(DosyaYolu);
                return;
            }
        }
    }
}
