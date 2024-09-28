namespace VTYS
{
    partial class Form_Abonelik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmb_MusteriAdi = new ComboBox();
            pnl_Abonelik = new Panel();
            cmb_DergiAdi = new ComboBox();
            cmb_AbonelikAdi = new ComboBox();
            dT_Baslangic = new DateTimePicker();
            btn_AbonelikRaporla = new Button();
            btn_AbonelikSil = new Button();
            btn_AbonelikGuncelle = new Button();
            btn_AbonelikEkle = new Button();
            pnl_btns_Abonelik = new Panel();
            panel1 = new Panel();
            dtGrid_Abonelik = new DataGridView();
            sfd_Abonelik = new SaveFileDialog();
            pnl_Abonelik.SuspendLayout();
            pnl_btns_Abonelik.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGrid_Abonelik).BeginInit();
            SuspendLayout();
            // 
            // cmb_MusteriAdi
            // 
            cmb_MusteriAdi.BackColor = Color.FromArgb(31, 30, 68);
            cmb_MusteriAdi.ForeColor = Color.LightGray;
            cmb_MusteriAdi.FormattingEnabled = true;
            cmb_MusteriAdi.Location = new Point(12, 6);
            cmb_MusteriAdi.Name = "cmb_MusteriAdi";
            cmb_MusteriAdi.Size = new Size(121, 23);
            cmb_MusteriAdi.TabIndex = 1;
            cmb_MusteriAdi.SelectedIndexChanged += flagswitch;
            // 
            // pnl_Abonelik
            // 
            pnl_Abonelik.Controls.Add(cmb_MusteriAdi);
            pnl_Abonelik.Controls.Add(cmb_DergiAdi);
            pnl_Abonelik.Controls.Add(cmb_AbonelikAdi);
            pnl_Abonelik.Controls.Add(dT_Baslangic);
            pnl_Abonelik.Dock = DockStyle.Fill;
            pnl_Abonelik.Location = new Point(0, 0);
            pnl_Abonelik.Name = "pnl_Abonelik";
            pnl_Abonelik.Size = new Size(718, 52);
            pnl_Abonelik.TabIndex = 9;
            // 
            // cmb_DergiAdi
            // 
            cmb_DergiAdi.BackColor = Color.FromArgb(31, 30, 68);
            cmb_DergiAdi.ForeColor = Color.LightGray;
            cmb_DergiAdi.FormattingEnabled = true;
            cmb_DergiAdi.Location = new Point(150, 6);
            cmb_DergiAdi.Name = "cmb_DergiAdi";
            cmb_DergiAdi.Size = new Size(121, 23);
            cmb_DergiAdi.TabIndex = 2;
            cmb_DergiAdi.SelectedIndexChanged += flagswitch;
            // 
            // cmb_AbonelikAdi
            // 
            cmb_AbonelikAdi.BackColor = Color.FromArgb(31, 30, 68);
            cmb_AbonelikAdi.ForeColor = Color.LightGray;
            cmb_AbonelikAdi.FormattingEnabled = true;
            cmb_AbonelikAdi.Location = new Point(271, 6);
            cmb_AbonelikAdi.Name = "cmb_AbonelikAdi";
            cmb_AbonelikAdi.Size = new Size(121, 23);
            cmb_AbonelikAdi.TabIndex = 3;
            cmb_AbonelikAdi.SelectedIndexChanged += flagswitch;
            // 
            // dT_Baslangic
            // 
            dT_Baslangic.Format = DateTimePickerFormat.Short;
            dT_Baslangic.Location = new Point(398, 6);
            dT_Baslangic.Name = "dT_Baslangic";
            dT_Baslangic.Size = new Size(128, 23);
            dT_Baslangic.TabIndex = 4;
            dT_Baslangic.Value = new DateTime(2024, 1, 4, 3, 59, 52, 0);
            dT_Baslangic.ValueChanged += flagswitch;
            // 
            // btn_AbonelikRaporla
            // 
            btn_AbonelikRaporla.Location = new Point(392, 5);
            btn_AbonelikRaporla.Name = "btn_AbonelikRaporla";
            btn_AbonelikRaporla.Size = new Size(128, 31);
            btn_AbonelikRaporla.TabIndex = 8;
            btn_AbonelikRaporla.Text = "Raporla";
            btn_AbonelikRaporla.UseVisualStyleBackColor = true;
            btn_AbonelikRaporla.Click += btn_AbonelikRaporla_Click;
            // 
            // btn_AbonelikSil
            // 
            btn_AbonelikSil.Location = new Point(271, 5);
            btn_AbonelikSil.Name = "btn_AbonelikSil";
            btn_AbonelikSil.Size = new Size(121, 31);
            btn_AbonelikSil.TabIndex = 7;
            btn_AbonelikSil.Text = "Abonelik Sil";
            btn_AbonelikSil.UseVisualStyleBackColor = true;
            btn_AbonelikSil.Click += btn_AbonelikSil_Click;
            // 
            // btn_AbonelikGuncelle
            // 
            btn_AbonelikGuncelle.Location = new Point(150, 5);
            btn_AbonelikGuncelle.Name = "btn_AbonelikGuncelle";
            btn_AbonelikGuncelle.Size = new Size(121, 31);
            btn_AbonelikGuncelle.TabIndex = 6;
            btn_AbonelikGuncelle.Text = "Abonelik Güncelle";
            btn_AbonelikGuncelle.UseVisualStyleBackColor = true;
            btn_AbonelikGuncelle.Click += btn_AbonelikGuncelle_Click;
            // 
            // btn_AbonelikEkle
            // 
            btn_AbonelikEkle.Location = new Point(5, 5);
            btn_AbonelikEkle.Name = "btn_AbonelikEkle";
            btn_AbonelikEkle.Size = new Size(145, 31);
            btn_AbonelikEkle.TabIndex = 5;
            btn_AbonelikEkle.Text = "Abonelik Ekle";
            btn_AbonelikEkle.UseVisualStyleBackColor = true;
            btn_AbonelikEkle.Click += btn_AbonelikEkle_Click;
            // 
            // pnl_btns_Abonelik
            // 
            pnl_btns_Abonelik.Controls.Add(btn_AbonelikEkle);
            pnl_btns_Abonelik.Controls.Add(btn_AbonelikGuncelle);
            pnl_btns_Abonelik.Controls.Add(btn_AbonelikSil);
            pnl_btns_Abonelik.Controls.Add(btn_AbonelikRaporla);
            pnl_btns_Abonelik.Dock = DockStyle.Bottom;
            pnl_btns_Abonelik.Location = new Point(0, 52);
            pnl_btns_Abonelik.Name = "pnl_btns_Abonelik";
            pnl_btns_Abonelik.Padding = new Padding(5);
            pnl_btns_Abonelik.Size = new Size(718, 48);
            pnl_btns_Abonelik.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(pnl_Abonelik);
            panel1.Controls.Add(pnl_btns_Abonelik);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 292);
            panel1.Name = "panel1";
            panel1.Size = new Size(718, 100);
            panel1.TabIndex = 5;
            // 
            // dtGrid_Abonelik
            // 
            dtGrid_Abonelik.AllowUserToAddRows = false;
            dtGrid_Abonelik.AllowUserToDeleteRows = false;
            dtGrid_Abonelik.AllowUserToResizeColumns = false;
            dtGrid_Abonelik.AllowUserToResizeRows = false;
            dtGrid_Abonelik.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGrid_Abonelik.BackgroundColor = Color.FromArgb(31, 30, 68);
            dtGrid_Abonelik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_Abonelik.Dock = DockStyle.Fill;
            dtGrid_Abonelik.GridColor = Color.LightGray;
            dtGrid_Abonelik.Location = new Point(0, 0);
            dtGrid_Abonelik.MultiSelect = false;
            dtGrid_Abonelik.Name = "dtGrid_Abonelik";
            dtGrid_Abonelik.ReadOnly = true;
            dtGrid_Abonelik.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dtGrid_Abonelik.RowTemplate.Height = 25;
            dtGrid_Abonelik.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGrid_Abonelik.Size = new Size(718, 292);
            dtGrid_Abonelik.TabIndex = 6;
            dtGrid_Abonelik.CellContentClick += dtGrid_Abonelik_CellContentClick;
            // 
            // Form_Abonelik
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 68);
            ClientSize = new Size(718, 392);
            Controls.Add(dtGrid_Abonelik);
            Controls.Add(panel1);
            Name = "Form_Abonelik";
            Text = "Form_Abonelik";
            Load += Form_Abonelik_Load;
            SizeChanged += Form_Abonelik_SizeChanged;
            pnl_Abonelik.ResumeLayout(false);
            pnl_btns_Abonelik.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGrid_Abonelik).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cmb_MusteriAdi;
        private Panel pnl_Abonelik;
        private ComboBox cmb_AbonelikAdi;
        private ComboBox cmb_DergiAdi;
        private DateTimePicker dT_Baslangic;
        private Panel pnl_btns_Abonelik;
        private Button btn_AbonelikEkle;
        private Button btn_AbonelikGuncelle;
        private Button btn_AbonelikSil;
        private Button btn_AbonelikRaporla;
        private Panel panel1;
        private DataGridView dtGrid_Abonelik;
        private SaveFileDialog sfd_Abonelik;
    }
}