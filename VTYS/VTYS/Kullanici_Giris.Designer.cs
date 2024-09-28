namespace VTYS
{
    partial class Kullanici_Giris
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
            label1 = new Label();
            label2 = new Label();
            tx_Kullanici_Adi = new TextBox();
            tx_Kullanici_Parola = new TextBox();
            btn_Kullanici_Giris = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(59, 75);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(59, 119);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Parola";
            // 
            // tx_Kullanici_Adi
            // 
            tx_Kullanici_Adi.Location = new Point(59, 93);
            tx_Kullanici_Adi.Name = "tx_Kullanici_Adi";
            tx_Kullanici_Adi.Size = new Size(150, 23);
            tx_Kullanici_Adi.TabIndex = 1;
            // 
            // tx_Kullanici_Parola
            // 
            tx_Kullanici_Parola.Location = new Point(59, 137);
            tx_Kullanici_Parola.Name = "tx_Kullanici_Parola";
            tx_Kullanici_Parola.PasswordChar = '*';
            tx_Kullanici_Parola.Size = new Size(150, 23);
            tx_Kullanici_Parola.TabIndex = 2;
            // 
            // btn_Kullanici_Giris
            // 
            btn_Kullanici_Giris.FlatAppearance.BorderSize = 0;
            btn_Kullanici_Giris.FlatStyle = FlatStyle.Flat;
            btn_Kullanici_Giris.ForeColor = Color.LightGray;
            btn_Kullanici_Giris.Location = new Point(134, 175);
            btn_Kullanici_Giris.Name = "btn_Kullanici_Giris";
            btn_Kullanici_Giris.Size = new Size(75, 23);
            btn_Kullanici_Giris.TabIndex = 3;
            btn_Kullanici_Giris.Text = "Giriş";
            btn_Kullanici_Giris.UseVisualStyleBackColor = true;
            btn_Kullanici_Giris.Click += btn_Kullanici_Giris_Click;
            // 
            // Kullanici_Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 68);
            ClientSize = new Size(274, 242);
            Controls.Add(btn_Kullanici_Giris);
            Controls.Add(tx_Kullanici_Parola);
            Controls.Add(tx_Kullanici_Adi);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Kullanici_Giris";
            Text = "Kullanici_Giris";
            FormClosing += Kullanici_Giris_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tx_Kullanici_Adi;
        private TextBox tx_Kullanici_Parola;
        private Button btn_Kullanici_Giris;
    }
}