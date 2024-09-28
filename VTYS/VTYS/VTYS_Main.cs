namespace VTYS
{
    public partial class VTYS_Main : Form
    {
        public VTYS_Main()
        {
            InitializeComponent();
        }
        private Form aktif_form = new Form();
        public static Entity.Kullanici kullanici = null;
        private void yetkiislemleri()
        {
            if (kullanici.Yetki_Seviyesi < 2)
            {
                menu_Abone.Visible = true;
                menu_Dergi.Visible = true;
            }
            if (kullanici.Yetki_Seviyesi == 0)
            {
                menu_Kullanici.Visible = true;
            }
        }

        private void VTYS_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            aktif_form.Close();
            Application.Exit();
        }

        private void VTYS_Main_Load(object sender, EventArgs e)
        {
            yetkiislemleri();
            Form_Goster(new Form_Abonelik());
        }

        private void menu_Cikis_Click(object sender, EventArgs e)
        {
            kullanici = null;
            this.Hide();
            Kullanici_Giris kullanici_Giris = new Kullanici_Giris();
            kullanici_Giris.Show();
        }

        private void Form_Goster(Form frm)
        {
            if (aktif_form.GetType() != frm.GetType())
            {
                aktif_form.Close();
                aktif_form = frm;
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Anchor = AnchorStyles.None;
                frm.Dock = DockStyle.Fill;
                panel1.Controls.Add(frm);
                panel1.Tag = frm;
                frm.BringToFront();
                frm.Show();
            }
        }

        private void menu_Abonelik_Click(object sender, EventArgs e)
        {
            Form_Goster(new Form_Abonelik());
        }

        private void menu_Abone_Click(object sender, EventArgs e)
        {
            Form_Goster(new Form_Abone());
        }

        private void menu_Dergi_Click(object sender, EventArgs e)
        {
            Form_Goster(new Form_DergiGazete());
        }

        private void menu_Kullanici_Click(object sender, EventArgs e)
        {
            Form_Goster(new Form_Kullanici());
        }
    }
}