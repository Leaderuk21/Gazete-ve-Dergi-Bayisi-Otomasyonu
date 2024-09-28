namespace VTYS
{
    partial class Form_Abone
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
            dtGrid_Abone = new DataGridView();
            btn_Abone_Ekle = new Button();
            pnl_Abone_Main = new Panel();
            pnl_Abone_Top = new Panel();
            tx_Abone_Ad = new TextBox();
            tx_Abone_Soyad = new TextBox();
            tx_Abone_Tel_No = new TextBox();
            tx_Abone_Mail = new TextBox();
            tx_Abone_Adres = new TextBox();
            dtp_Abone_Kayit_Tarihi = new DateTimePicker();
            pnl_Abone_Bottom = new Panel();
            btn_Abone_Guncelle = new Button();
            btn_Abone_Sil = new Button();
            btn_Abone_Raporla = new Button();
            sfd_Abone = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dtGrid_Abone).BeginInit();
            pnl_Abone_Main.SuspendLayout();
            pnl_Abone_Top.SuspendLayout();
            pnl_Abone_Bottom.SuspendLayout();
            SuspendLayout();
            // 
            // dtGrid_Abone
            // 
            dtGrid_Abone.AllowUserToAddRows = false;
            dtGrid_Abone.AllowUserToDeleteRows = false;
            dtGrid_Abone.AllowUserToResizeColumns = false;
            dtGrid_Abone.AllowUserToResizeRows = false;
            dtGrid_Abone.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGrid_Abone.BackgroundColor = Color.FromArgb(31, 30, 68);
            dtGrid_Abone.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_Abone.Dock = DockStyle.Fill;
            dtGrid_Abone.GridColor = Color.LightGray;
            dtGrid_Abone.Location = new Point(0, 0);
            dtGrid_Abone.MultiSelect = false;
            dtGrid_Abone.Name = "dtGrid_Abone";
            dtGrid_Abone.ReadOnly = true;
            dtGrid_Abone.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dtGrid_Abone.RowTemplate.Height = 25;
            dtGrid_Abone.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGrid_Abone.Size = new Size(759, 306);
            dtGrid_Abone.TabIndex = 0;
            dtGrid_Abone.CellContentClick += dtGrid_Abone_CellContentClick;
            // 
            // btn_Abone_Ekle
            // 
            btn_Abone_Ekle.Location = new Point(12, 6);
            btn_Abone_Ekle.Name = "btn_Abone_Ekle";
            btn_Abone_Ekle.Size = new Size(75, 23);
            btn_Abone_Ekle.TabIndex = 1;
            btn_Abone_Ekle.Text = "Abone Ekle";
            btn_Abone_Ekle.UseVisualStyleBackColor = true;
            btn_Abone_Ekle.Click += btn_Abone_Ekle_Click;
            // 
            // pnl_Abone_Main
            // 
            pnl_Abone_Main.BackColor = Color.FromArgb(31, 30, 68);
            pnl_Abone_Main.Controls.Add(pnl_Abone_Top);
            pnl_Abone_Main.Controls.Add(pnl_Abone_Bottom);
            pnl_Abone_Main.Dock = DockStyle.Bottom;
            pnl_Abone_Main.ForeColor = SystemColors.ControlText;
            pnl_Abone_Main.Location = new Point(0, 206);
            pnl_Abone_Main.Name = "pnl_Abone_Main";
            pnl_Abone_Main.Size = new Size(759, 100);
            pnl_Abone_Main.TabIndex = 2;
            // 
            // pnl_Abone_Top
            // 
            pnl_Abone_Top.Controls.Add(tx_Abone_Ad);
            pnl_Abone_Top.Controls.Add(tx_Abone_Soyad);
            pnl_Abone_Top.Controls.Add(tx_Abone_Tel_No);
            pnl_Abone_Top.Controls.Add(tx_Abone_Mail);
            pnl_Abone_Top.Controls.Add(tx_Abone_Adres);
            pnl_Abone_Top.Controls.Add(dtp_Abone_Kayit_Tarihi);
            pnl_Abone_Top.Dock = DockStyle.Fill;
            pnl_Abone_Top.Location = new Point(0, 0);
            pnl_Abone_Top.Name = "pnl_Abone_Top";
            pnl_Abone_Top.Size = new Size(759, 61);
            pnl_Abone_Top.TabIndex = 3;
            // 
            // tx_Abone_Ad
            // 
            tx_Abone_Ad.Location = new Point(12, 32);
            tx_Abone_Ad.Name = "tx_Abone_Ad";
            tx_Abone_Ad.Size = new Size(100, 23);
            tx_Abone_Ad.TabIndex = 0;
            tx_Abone_Ad.Text = "Ad";
            tx_Abone_Ad.TextChanged += flagswitch;
            // 
            // tx_Abone_Soyad
            // 
            tx_Abone_Soyad.Location = new Point(156, 32);
            tx_Abone_Soyad.Name = "tx_Abone_Soyad";
            tx_Abone_Soyad.Size = new Size(100, 23);
            tx_Abone_Soyad.TabIndex = 1;
            tx_Abone_Soyad.Text = "Soyad";
            tx_Abone_Soyad.TextChanged += flagswitch;
            // 
            // tx_Abone_Tel_No
            // 
            tx_Abone_Tel_No.Location = new Point(294, 32);
            tx_Abone_Tel_No.Name = "tx_Abone_Tel_No";
            tx_Abone_Tel_No.Size = new Size(100, 23);
            tx_Abone_Tel_No.TabIndex = 2;
            tx_Abone_Tel_No.Text = "Tel No";
            tx_Abone_Tel_No.TextChanged += flagswitch;
            // 
            // tx_Abone_Mail
            // 
            tx_Abone_Mail.Location = new Point(411, 32);
            tx_Abone_Mail.Name = "tx_Abone_Mail";
            tx_Abone_Mail.Size = new Size(100, 23);
            tx_Abone_Mail.TabIndex = 3;
            tx_Abone_Mail.Text = "Mail";
            tx_Abone_Mail.TextChanged += flagswitch;
            // 
            // tx_Abone_Adres
            // 
            tx_Abone_Adres.Location = new Point(530, 32);
            tx_Abone_Adres.Name = "tx_Abone_Adres";
            tx_Abone_Adres.Size = new Size(100, 23);
            tx_Abone_Adres.TabIndex = 4;
            tx_Abone_Adres.Text = "Adres";
            tx_Abone_Adres.TextChanged += flagswitch;
            // 
            // dtp_Abone_Kayit_Tarihi
            // 
            dtp_Abone_Kayit_Tarihi.Format = DateTimePickerFormat.Short;
            dtp_Abone_Kayit_Tarihi.Location = new Point(643, 32);
            dtp_Abone_Kayit_Tarihi.Name = "dtp_Abone_Kayit_Tarihi";
            dtp_Abone_Kayit_Tarihi.Size = new Size(116, 23);
            dtp_Abone_Kayit_Tarihi.TabIndex = 5;
            dtp_Abone_Kayit_Tarihi.ValueChanged += flagswitch;
            // 
            // pnl_Abone_Bottom
            // 
            pnl_Abone_Bottom.Controls.Add(btn_Abone_Ekle);
            pnl_Abone_Bottom.Controls.Add(btn_Abone_Guncelle);
            pnl_Abone_Bottom.Controls.Add(btn_Abone_Sil);
            pnl_Abone_Bottom.Controls.Add(btn_Abone_Raporla);
            pnl_Abone_Bottom.Dock = DockStyle.Bottom;
            pnl_Abone_Bottom.Location = new Point(0, 61);
            pnl_Abone_Bottom.Name = "pnl_Abone_Bottom";
            pnl_Abone_Bottom.Size = new Size(759, 39);
            pnl_Abone_Bottom.TabIndex = 2;
            // 
            // btn_Abone_Guncelle
            // 
            btn_Abone_Guncelle.Location = new Point(156, 6);
            btn_Abone_Guncelle.Name = "btn_Abone_Guncelle";
            btn_Abone_Guncelle.Size = new Size(75, 23);
            btn_Abone_Guncelle.TabIndex = 2;
            btn_Abone_Guncelle.Text = "Abone Güncelle";
            btn_Abone_Guncelle.UseVisualStyleBackColor = true;
            btn_Abone_Guncelle.Click += btn_Abone_Guncelle_Click;
            // 
            // btn_Abone_Sil
            // 
            btn_Abone_Sil.Location = new Point(319, 6);
            btn_Abone_Sil.Name = "btn_Abone_Sil";
            btn_Abone_Sil.Size = new Size(75, 23);
            btn_Abone_Sil.TabIndex = 3;
            btn_Abone_Sil.Text = "Abone Sil";
            btn_Abone_Sil.UseVisualStyleBackColor = true;
            btn_Abone_Sil.Click += btn_Abone_Sil_Click;
            // 
            // btn_Abone_Raporla
            // 
            btn_Abone_Raporla.Location = new Point(476, 6);
            btn_Abone_Raporla.Name = "btn_Abone_Raporla";
            btn_Abone_Raporla.Size = new Size(75, 23);
            btn_Abone_Raporla.TabIndex = 4;
            btn_Abone_Raporla.Text = "Raporla";
            btn_Abone_Raporla.UseVisualStyleBackColor = true;
            btn_Abone_Raporla.Click += btn_Abone_Raporla_Click;
            // 
            // Form_Abone
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 306);
            Controls.Add(pnl_Abone_Main);
            Controls.Add(dtGrid_Abone);
            Name = "Form_Abone";
            Text = "Form_Abone";
            Load += Form_Abone_Load;
            SizeChanged += Form_Abone_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)dtGrid_Abone).EndInit();
            pnl_Abone_Main.ResumeLayout(false);
            pnl_Abone_Top.ResumeLayout(false);
            pnl_Abone_Top.PerformLayout();
            pnl_Abone_Bottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtGrid_Abone;
        private Button btn_Abone_Ekle;
        private Panel pnl_Abone_Main;
        private Panel pnl_Abone_Bottom;
        private Panel pnl_Abone_Top;
        private Button btn_Abone_Raporla;
        private Button btn_Abone_Sil;
        private Button btn_Abone_Guncelle;
        private DateTimePicker dtp_Abone_Kayit_Tarihi;
        private TextBox tx_Abone_Adres;
        private TextBox tx_Abone_Mail;
        private TextBox tx_Abone_Tel_No;
        private TextBox tx_Abone_Soyad;
        private TextBox tx_Abone_Ad;
        private SaveFileDialog sfd_Abone;
    }
}