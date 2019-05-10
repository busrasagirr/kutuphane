namespace Kutuphane
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpbox_kullanicigiris = new System.Windows.Forms.GroupBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.txt_kullanicisifre = new System.Windows.Forms.TextBox();
            this.txt_kullaniciadi = new System.Windows.Forms.TextBox();
            this.lbl_kullanicisifre = new System.Windows.Forms.Label();
            this.lbl_kullaniciadi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpbox_kullanicigiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbox_kullanicigiris
            // 
            this.grpbox_kullanicigiris.Controls.Add(this.btn_giris);
            this.grpbox_kullanicigiris.Controls.Add(this.txt_kullanicisifre);
            this.grpbox_kullanicigiris.Controls.Add(this.txt_kullaniciadi);
            this.grpbox_kullanicigiris.Controls.Add(this.lbl_kullanicisifre);
            this.grpbox_kullanicigiris.Controls.Add(this.lbl_kullaniciadi);
            this.grpbox_kullanicigiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbox_kullanicigiris.ForeColor = System.Drawing.Color.Maroon;
            this.grpbox_kullanicigiris.Location = new System.Drawing.Point(140, 120);
            this.grpbox_kullanicigiris.Name = "grpbox_kullanicigiris";
            this.grpbox_kullanicigiris.Size = new System.Drawing.Size(316, 154);
            this.grpbox_kullanicigiris.TabIndex = 7;
            this.grpbox_kullanicigiris.TabStop = false;
            this.grpbox_kullanicigiris.Text = "Kullanıcı Girişi";
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(181, 106);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(74, 42);
            this.btn_giris.TabIndex = 4;
            this.btn_giris.Text = "GİRİŞ";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // txt_kullanicisifre
            // 
            this.txt_kullanicisifre.Location = new System.Drawing.Point(124, 80);
            this.txt_kullanicisifre.Name = "txt_kullanicisifre";
            this.txt_kullanicisifre.PasswordChar = '*';
            this.txt_kullanicisifre.Size = new System.Drawing.Size(186, 20);
            this.txt_kullanicisifre.TabIndex = 3;
            // 
            // txt_kullaniciadi
            // 
            this.txt_kullaniciadi.Location = new System.Drawing.Point(124, 23);
            this.txt_kullaniciadi.Name = "txt_kullaniciadi";
            this.txt_kullaniciadi.Size = new System.Drawing.Size(186, 20);
            this.txt_kullaniciadi.TabIndex = 2;
            // 
            // lbl_kullanicisifre
            // 
            this.lbl_kullanicisifre.AutoSize = true;
            this.lbl_kullanicisifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullanicisifre.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_kullanicisifre.Location = new System.Drawing.Point(3, 87);
            this.lbl_kullanicisifre.Name = "lbl_kullanicisifre";
            this.lbl_kullanicisifre.Size = new System.Drawing.Size(85, 13);
            this.lbl_kullanicisifre.TabIndex = 1;
            this.lbl_kullanicisifre.Text = "Kullanıcı Şifre";
            // 
            // lbl_kullaniciadi
            // 
            this.lbl_kullaniciadi.AutoSize = true;
            this.lbl_kullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullaniciadi.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_kullaniciadi.Location = new System.Drawing.Point(3, 30);
            this.lbl_kullaniciadi.Name = "lbl_kullaniciadi";
            this.lbl_kullaniciadi.Size = new System.Drawing.Size(77, 13);
            this.lbl_kullaniciadi.TabIndex = 0;
            this.lbl_kullaniciadi.Text = "Kullanıcı Adı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(589, 388);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(589, 388);
            this.Controls.Add(this.grpbox_kullanicigiris);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş Ekranı";
            this.grpbox_kullanicigiris.ResumeLayout(false);
            this.grpbox_kullanicigiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbox_kullanicigiris;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.TextBox txt_kullanicisifre;
        private System.Windows.Forms.TextBox txt_kullaniciadi;
        private System.Windows.Forms.Label lbl_kullanicisifre;
        private System.Windows.Forms.Label lbl_kullaniciadi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

