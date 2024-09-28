namespace VTYS
{
    partial class Form_Kullanici
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
            dtg_Dergi = new DataGridView();
            pnl_Dergi_Main = new Panel();
            pnl_Dergi_Top = new Panel();
            cmb_Kullanici_Yetki = new ComboBox();
            tx_Kullanici_Adi = new TextBox();
            tx_Kullanici_Parola = new TextBox();
            pnl_Dergi_Bottom = new Panel();
            btn_Kullanici_Ekle = new Button();
            btn_Kullanici_Guncelle = new Button();
            btn_Kullanici_Sil = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_Dergi).BeginInit();
            pnl_Dergi_Main.SuspendLayout();
            pnl_Dergi_Top.SuspendLayout();
            pnl_Dergi_Bottom.SuspendLayout();
            SuspendLayout();
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
            dtg_Dergi.Size = new Size(756, 259);
            dtg_Dergi.TabIndex = 9;
            dtg_Dergi.CellContentClick += dtg_Dergi_CellContentClick;
            // 
            // pnl_Dergi_Main
            // 
            pnl_Dergi_Main.Controls.Add(pnl_Dergi_Top);
            pnl_Dergi_Main.Controls.Add(pnl_Dergi_Bottom);
            pnl_Dergi_Main.Dock = DockStyle.Bottom;
            pnl_Dergi_Main.Location = new Point(0, 259);
            pnl_Dergi_Main.Name = "pnl_Dergi_Main";
            pnl_Dergi_Main.Size = new Size(756, 100);
            pnl_Dergi_Main.TabIndex = 8;
            // 
            // pnl_Dergi_Top
            // 
            pnl_Dergi_Top.Controls.Add(cmb_Kullanici_Yetki);
            pnl_Dergi_Top.Controls.Add(tx_Kullanici_Adi);
            pnl_Dergi_Top.Controls.Add(tx_Kullanici_Parola);
            pnl_Dergi_Top.Dock = DockStyle.Fill;
            pnl_Dergi_Top.Location = new Point(0, 0);
            pnl_Dergi_Top.Name = "pnl_Dergi_Top";
            pnl_Dergi_Top.Size = new Size(756, 51);
            pnl_Dergi_Top.TabIndex = 1;
            // 
            // cmb_Kullanici_Yetki
            // 
            cmb_Kullanici_Yetki.FormattingEnabled = true;
            cmb_Kullanici_Yetki.Items.AddRange(new object[] { "Yönetici", "Müdür", "Çalışan" });
            cmb_Kullanici_Yetki.Location = new Point(277, 11);
            cmb_Kullanici_Yetki.Name = "cmb_Kullanici_Yetki";
            cmb_Kullanici_Yetki.Size = new Size(121, 23);
            cmb_Kullanici_Yetki.TabIndex = 2;
            cmb_Kullanici_Yetki.Text = "Yetki";
            cmb_Kullanici_Yetki.SelectedIndexChanged += flagswitch;
            // 
            // tx_Kullanici_Adi
            // 
            tx_Kullanici_Adi.Location = new Point(12, 11);
            tx_Kullanici_Adi.Name = "tx_Kullanici_Adi";
            tx_Kullanici_Adi.Size = new Size(100, 23);
            tx_Kullanici_Adi.TabIndex = 0;
            tx_Kullanici_Adi.Text = "Kullanıcı Adı";
            tx_Kullanici_Adi.TextChanged += flagswitch;
            // 
            // tx_Kullanici_Parola
            // 
            tx_Kullanici_Parola.Location = new Point(146, 11);
            tx_Kullanici_Parola.Name = "tx_Kullanici_Parola";
            tx_Kullanici_Parola.Size = new Size(100, 23);
            tx_Kullanici_Parola.TabIndex = 1;
            tx_Kullanici_Parola.Text = "Parola";
            tx_Kullanici_Parola.TextChanged += flagswitch;
            // 
            // pnl_Dergi_Bottom
            // 
            pnl_Dergi_Bottom.Controls.Add(btn_Kullanici_Ekle);
            pnl_Dergi_Bottom.Controls.Add(btn_Kullanici_Guncelle);
            pnl_Dergi_Bottom.Controls.Add(btn_Kullanici_Sil);
            pnl_Dergi_Bottom.Dock = DockStyle.Bottom;
            pnl_Dergi_Bottom.Location = new Point(0, 51);
            pnl_Dergi_Bottom.Name = "pnl_Dergi_Bottom";
            pnl_Dergi_Bottom.Size = new Size(756, 49);
            pnl_Dergi_Bottom.TabIndex = 0;
            // 
            // btn_Kullanici_Ekle
            // 
            btn_Kullanici_Ekle.Location = new Point(12, 13);
            btn_Kullanici_Ekle.Name = "btn_Kullanici_Ekle";
            btn_Kullanici_Ekle.Size = new Size(75, 23);
            btn_Kullanici_Ekle.TabIndex = 3;
            btn_Kullanici_Ekle.Text = " Kullanıcı Ekle";
            btn_Kullanici_Ekle.UseVisualStyleBackColor = true;
            btn_Kullanici_Ekle.Click += btn_Kullanici_Ekle_Click;
            // 
            // btn_Kullanici_Guncelle
            // 
            btn_Kullanici_Guncelle.Location = new Point(137, 13);
            btn_Kullanici_Guncelle.Name = "btn_Kullanici_Guncelle";
            btn_Kullanici_Guncelle.Size = new Size(75, 23);
            btn_Kullanici_Guncelle.TabIndex = 2;
            btn_Kullanici_Guncelle.Text = "Kullanıcı Güncelle";
            btn_Kullanici_Guncelle.UseVisualStyleBackColor = true;
            btn_Kullanici_Guncelle.Click += btn_Kullanici_Guncelle_Click;
            // 
            // btn_Kullanici_Sil
            // 
            btn_Kullanici_Sil.Location = new Point(277, 13);
            btn_Kullanici_Sil.Name = "btn_Kullanici_Sil";
            btn_Kullanici_Sil.Size = new Size(75, 23);
            btn_Kullanici_Sil.TabIndex = 1;
            btn_Kullanici_Sil.Text = "Kullanıcı Sil";
            btn_Kullanici_Sil.UseVisualStyleBackColor = true;
            btn_Kullanici_Sil.Click += btn_Kullanici_Sil_Click;
            // 
            // Form_Kullanici
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 68);
            ClientSize = new Size(756, 359);
            Controls.Add(dtg_Dergi);
            Controls.Add(pnl_Dergi_Main);
            Name = "Form_Kullanici";
            Text = "Form_Kullanici";
            Load += Form_Kullanici_Load;
            SizeChanged += Form_Kullanici_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)dtg_Dergi).EndInit();
            pnl_Dergi_Main.ResumeLayout(false);
            pnl_Dergi_Top.ResumeLayout(false);
            pnl_Dergi_Top.PerformLayout();
            pnl_Dergi_Bottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_Dergi;
        private Panel pnl_Dergi_Main;
        private Panel pnl_Dergi_Top;
        private TextBox tx_Kullanici_Adi;
        private TextBox tx_Kullanici_Parola;
        private Panel pnl_Dergi_Bottom;
        private Button btn_Kullanici_Ekle;
        private Button btn_Kullanici_Guncelle;
        private Button btn_Kullanici_Sil;
        private ComboBox cmb_Kullanici_Yetki;
    }
}