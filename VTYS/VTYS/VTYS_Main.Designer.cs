namespace VTYS
{
    partial class VTYS_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menu_Abonelik = new ToolStripMenuItem();
            menu_Abone = new ToolStripMenuItem();
            menu_Dergi = new ToolStripMenuItem();
            menu_Kullanici = new ToolStripMenuItem();
            menu_Cikis = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menu_Abonelik, menu_Abone, menu_Dergi, menu_Kullanici, menu_Cikis });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(859, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu_Abonelik
            // 
            menu_Abonelik.Name = "menu_Abonelik";
            menu_Abonelik.Size = new Size(66, 20);
            menu_Abonelik.Text = "Abonelik";
            menu_Abonelik.Click += menu_Abonelik_Click;
            // 
            // menu_Abone
            // 
            menu_Abone.Name = "menu_Abone";
            menu_Abone.Size = new Size(54, 20);
            menu_Abone.Text = "Abone";
            menu_Abone.Visible = false;
            menu_Abone.Click += menu_Abone_Click;
            // 
            // menu_Dergi
            // 
            menu_Dergi.Name = "menu_Dergi";
            menu_Dergi.Size = new Size(87, 20);
            menu_Dergi.Text = "Dergi/Gazete";
            menu_Dergi.Visible = false;
            menu_Dergi.Click += menu_Dergi_Click;
            // 
            // menu_Kullanici
            // 
            menu_Kullanici.Name = "menu_Kullanici";
            menu_Kullanici.Size = new Size(64, 20);
            menu_Kullanici.Text = "Kullanıcı";
            menu_Kullanici.Visible = false;
            menu_Kullanici.Click += menu_Kullanici_Click;
            // 
            // menu_Cikis
            // 
            menu_Cikis.Name = "menu_Cikis";
            menu_Cikis.Size = new Size(44, 20);
            menu_Cikis.Text = "Çıkış";
            menu_Cikis.Click += menu_Cikis_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(859, 353);
            panel1.TabIndex = 2;
            // 
            // VTYS_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 68);
            ClientSize = new Size(859, 377);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "VTYS_Main";
            Text = "Main";
            FormClosing += VTYS_Main_FormClosing;
            Load += VTYS_Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menu_Abonelik;
        private ToolStripMenuItem menu_Abone;
        private ToolStripMenuItem menu_Dergi;
        private ToolStripMenuItem menu_Kullanici;
        private ToolStripMenuItem menu_Cikis;
        private Panel panel1;
    }
}