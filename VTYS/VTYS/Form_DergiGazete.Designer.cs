namespace VTYS
{
    partial class Form_DergiGazete
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
            pnl_Dergi_Main = new Panel();
            pnl_Dergi_Top = new Panel();
            tx_Dergi_Ad = new TextBox();
            tx_Dergi_Yayin_Evi = new TextBox();
            tx_Dergi_Tur = new TextBox();
            tx_Dergi_Ucret = new TextBox();
            pnl_Dergi_Bottom = new Panel();
            btn_Dergi_Ekle = new Button();
            btn_Dergi_Guncelle = new Button();
            btn_Dergi_Sil = new Button();
            btn_Dergi_Raporla = new Button();
            btn_Dergi_Import = new Button();
            dtg_Dergi = new DataGridView();
            ofd_Import = new OpenFileDialog();
            sfd_Export = new SaveFileDialog();
            pnl_Dergi_Main.SuspendLayout();
            pnl_Dergi_Top.SuspendLayout();
            pnl_Dergi_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Dergi).BeginInit();
            SuspendLayout();
            // 
            // pnl_Dergi_Main
            // 
            pnl_Dergi_Main.Controls.Add(pnl_Dergi_Top);
            pnl_Dergi_Main.Controls.Add(pnl_Dergi_Bottom);
            pnl_Dergi_Main.Dock = DockStyle.Bottom;
            pnl_Dergi_Main.Location = new Point(0, 236);
            pnl_Dergi_Main.Name = "pnl_Dergi_Main";
            pnl_Dergi_Main.Size = new Size(742, 100);
            pnl_Dergi_Main.TabIndex = 1;
            // 
            // pnl_Dergi_Top
            // 
            pnl_Dergi_Top.Controls.Add(tx_Dergi_Ad);
            pnl_Dergi_Top.Controls.Add(tx_Dergi_Yayin_Evi);
            pnl_Dergi_Top.Controls.Add(tx_Dergi_Tur);
            pnl_Dergi_Top.Controls.Add(tx_Dergi_Ucret);
            pnl_Dergi_Top.Dock = DockStyle.Fill;
            pnl_Dergi_Top.Location = new Point(0, 0);
            pnl_Dergi_Top.Name = "pnl_Dergi_Top";
            pnl_Dergi_Top.Size = new Size(742, 51);
            pnl_Dergi_Top.TabIndex = 1;
            // 
            // tx_Dergi_Ad
            // 
            tx_Dergi_Ad.Location = new Point(12, 11);
            tx_Dergi_Ad.Name = "tx_Dergi_Ad";
            tx_Dergi_Ad.Size = new Size(100, 23);
            tx_Dergi_Ad.TabIndex = 0;
            tx_Dergi_Ad.Text = "Dergi Adı";
            tx_Dergi_Ad.TextChanged += flagswitch;
            // 
            // tx_Dergi_Yayin_Evi
            // 
            tx_Dergi_Yayin_Evi.Location = new Point(137, 11);
            tx_Dergi_Yayin_Evi.Name = "tx_Dergi_Yayin_Evi";
            tx_Dergi_Yayin_Evi.Size = new Size(100, 23);
            tx_Dergi_Yayin_Evi.TabIndex = 1;
            tx_Dergi_Yayin_Evi.Text = "Yayın Evi";
            tx_Dergi_Yayin_Evi.TextChanged += flagswitch;
            // 
            // tx_Dergi_Tur
            // 
            tx_Dergi_Tur.Location = new Point(277, 11);
            tx_Dergi_Tur.Name = "tx_Dergi_Tur";
            tx_Dergi_Tur.Size = new Size(100, 23);
            tx_Dergi_Tur.TabIndex = 2;
            tx_Dergi_Tur.Text = "Dergi Türü";
            tx_Dergi_Tur.TextChanged += flagswitch;
            // 
            // tx_Dergi_Ucret
            // 
            tx_Dergi_Ucret.Location = new Point(421, 11);
            tx_Dergi_Ucret.Name = "tx_Dergi_Ucret";
            tx_Dergi_Ucret.Size = new Size(100, 23);
            tx_Dergi_Ucret.TabIndex = 2;
            tx_Dergi_Ucret.Text = "Ücret";
            tx_Dergi_Ucret.TextChanged += flagswitch;
            tx_Dergi_Ucret.KeyPress += tx_Dergi_Ucret_KeyPress;
            // 
            // pnl_Dergi_Bottom
            // 
            pnl_Dergi_Bottom.Controls.Add(btn_Dergi_Ekle);
            pnl_Dergi_Bottom.Controls.Add(btn_Dergi_Guncelle);
            pnl_Dergi_Bottom.Controls.Add(btn_Dergi_Sil);
            pnl_Dergi_Bottom.Controls.Add(btn_Dergi_Raporla);
            pnl_Dergi_Bottom.Controls.Add(btn_Dergi_Import);
            pnl_Dergi_Bottom.Dock = DockStyle.Bottom;
            pnl_Dergi_Bottom.Location = new Point(0, 51);
            pnl_Dergi_Bottom.Name = "pnl_Dergi_Bottom";
            pnl_Dergi_Bottom.Size = new Size(742, 49);
            pnl_Dergi_Bottom.TabIndex = 0;
            // 
            // btn_Dergi_Ekle
            // 
            btn_Dergi_Ekle.Location = new Point(12, 13);
            btn_Dergi_Ekle.Name = "btn_Dergi_Ekle";
            btn_Dergi_Ekle.Size = new Size(75, 23);
            btn_Dergi_Ekle.TabIndex = 3;
            btn_Dergi_Ekle.Text = "Dergi Ekle";
            btn_Dergi_Ekle.UseVisualStyleBackColor = true;
            btn_Dergi_Ekle.Click += btn_Dergi_Ekle_Click;
            // 
            // btn_Dergi_Guncelle
            // 
            btn_Dergi_Guncelle.Location = new Point(137, 13);
            btn_Dergi_Guncelle.Name = "btn_Dergi_Guncelle";
            btn_Dergi_Guncelle.Size = new Size(75, 23);
            btn_Dergi_Guncelle.TabIndex = 2;
            btn_Dergi_Guncelle.Text = "Dergi Güncelle";
            btn_Dergi_Guncelle.UseVisualStyleBackColor = true;
            btn_Dergi_Guncelle.Click += btn_Dergi_Guncelle_Click;
            // 
            // btn_Dergi_Sil
            // 
            btn_Dergi_Sil.Location = new Point(277, 13);
            btn_Dergi_Sil.Name = "btn_Dergi_Sil";
            btn_Dergi_Sil.Size = new Size(75, 23);
            btn_Dergi_Sil.TabIndex = 1;
            btn_Dergi_Sil.Text = "Dergi Sil";
            btn_Dergi_Sil.UseVisualStyleBackColor = true;
            btn_Dergi_Sil.Click += btn_Dergi_Sil_Click;
            // 
            // btn_Dergi_Raporla
            // 
            btn_Dergi_Raporla.Location = new Point(421, 13);
            btn_Dergi_Raporla.Name = "btn_Dergi_Raporla";
            btn_Dergi_Raporla.Size = new Size(75, 23);
            btn_Dergi_Raporla.TabIndex = 0;
            btn_Dergi_Raporla.Text = "Raporla";
            btn_Dergi_Raporla.UseVisualStyleBackColor = true;
            btn_Dergi_Raporla.Click += btn_Dergi_Raporla_Click;
            // 
            // btn_Dergi_Import
            // 
            btn_Dergi_Import.Location = new Point(554, 14);
            btn_Dergi_Import.Name = "btn_Dergi_Import";
            btn_Dergi_Import.Size = new Size(75, 23);
            btn_Dergi_Import.TabIndex = 4;
            btn_Dergi_Import.Text = "İmport";
            btn_Dergi_Import.UseVisualStyleBackColor = true;
            btn_Dergi_Import.Click += btn_Dergi_Import_Click;
            // 
            // dtg_Dergi
            // 
            dtg_Dergi.AllowUserToAddRows = false;
            dtg_Dergi.AllowUserToDeleteRows = false;
            dtg_Dergi.AllowUserToResizeColumns = false;
            dtg_Dergi.AllowUserToResizeRows = false;
            dtg_Dergi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Dergi.BackgroundColor = Color.FromArgb(31, 30, 68);
            dtg_Dergi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Dergi.Dock = DockStyle.Fill;
            dtg_Dergi.GridColor = Color.LightGray;
            dtg_Dergi.Location = new Point(0, 0);
            dtg_Dergi.MultiSelect = false;
            dtg_Dergi.Name = "dtg_Dergi";
            dtg_Dergi.ReadOnly = true;
            dtg_Dergi.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dtg_Dergi.RowTemplate.Height = 25;
            dtg_Dergi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_Dergi.Size = new Size(742, 236);
            dtg_Dergi.TabIndex = 7;
            dtg_Dergi.CellContentClick += dtg_Dergi_CellContentClick;
            // 
            // ofd_Import
            // 
            ofd_Import.FileName = "openFileDialog1";
            // 
            // Form_DergiGazete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 68);
            ClientSize = new Size(742, 336);
            Controls.Add(dtg_Dergi);
            Controls.Add(pnl_Dergi_Main);
            Name = "Form_DergiGazete";
            Text = "Form_DergiGazete";
            Load += Form_DergiGazete_Load;
            SizeChanged += Form_DergiGazete_SizeChanged;
            pnl_Dergi_Main.ResumeLayout(false);
            pnl_Dergi_Top.ResumeLayout(false);
            pnl_Dergi_Top.PerformLayout();
            pnl_Dergi_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_Dergi).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnl_Dergi_Main;
        private Panel pnl_Dergi_Bottom;
        private Panel pnl_Dergi_Top;
        private DataGridView dtg_Dergi;
        private TextBox tx_Dergi_Ucret;
        private TextBox tx_Dergi_Tur;
        private TextBox tx_Dergi_Yayin_Evi;
        private TextBox tx_Dergi_Ad;
        private Button btn_Dergi_Ekle;
        private Button btn_Dergi_Guncelle;
        private Button btn_Dergi_Sil;
        private Button btn_Dergi_Raporla;
        private Button btn_Dergi_Import;
        private OpenFileDialog ofd_Import;
        private SaveFileDialog sfd_Export;
    }
}