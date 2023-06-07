namespace SinemaOtomasyon
{
    partial class YeniKayit
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
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.cmb_telefonTuru = new System.Windows.Forms.ComboBox();
            this.lbl_tur = new System.Windows.Forms.Label();
            this.grd_telefonlar = new System.Windows.Forms.DataGridView();
            this.numara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_telefonlar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(51, 57);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(20, 13);
            this.lbl_ad.TabIndex = 0;
            this.lbl_ad.Text = "Ad";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(51, 107);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(37, 13);
            this.lbl_soyad.TabIndex = 1;
            this.lbl_soyad.Text = "Soyad";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(119, 57);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ad.TabIndex = 2;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(119, 104);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_soyad.TabIndex = 3;
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(119, 147);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(100, 20);
            this.txt_telefon.TabIndex = 4;
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Location = new System.Drawing.Point(54, 153);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(43, 13);
            this.lbl_telefon.TabIndex = 5;
            this.lbl_telefon.Text = "Telefon";
            // 
            // cmb_telefonTuru
            // 
            this.cmb_telefonTuru.FormattingEnabled = true;
            this.cmb_telefonTuru.Items.AddRange(new object[] {
            "Cep",
            "Ev",
            "Ofis"});
            this.cmb_telefonTuru.Location = new System.Drawing.Point(119, 196);
            this.cmb_telefonTuru.Name = "cmb_telefonTuru";
            this.cmb_telefonTuru.Size = new System.Drawing.Size(121, 21);
            this.cmb_telefonTuru.TabIndex = 6;
            // 
            // lbl_tur
            // 
            this.lbl_tur.AutoSize = true;
            this.lbl_tur.Location = new System.Drawing.Point(57, 196);
            this.lbl_tur.Name = "lbl_tur";
            this.lbl_tur.Size = new System.Drawing.Size(23, 13);
            this.lbl_tur.TabIndex = 7;
            this.lbl_tur.Text = "Tür";
            // 
            // grd_telefonlar
            // 
            this.grd_telefonlar.AllowUserToAddRows = false;
            this.grd_telefonlar.AllowUserToDeleteRows = false;
            this.grd_telefonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_telefonlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numara,
            this.tur});
            this.grd_telefonlar.Location = new System.Drawing.Point(266, 67);
            this.grd_telefonlar.Name = "grd_telefonlar";
            this.grd_telefonlar.ReadOnly = true;
            this.grd_telefonlar.Size = new System.Drawing.Size(240, 150);
            this.grd_telefonlar.TabIndex = 8;
            // 
            // numara
            // 
            this.numara.HeaderText = "Numara";
            this.numara.Name = "numara";
            this.numara.ReadOnly = true;
            // 
            // tur
            // 
            this.tur.HeaderText = "Tür";
            this.tur.Name = "tur";
            this.tur.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(620, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // YeniKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grd_telefonlar);
            this.Controls.Add(this.lbl_tur);
            this.Controls.Add(this.cmb_telefonTuru);
            this.Controls.Add(this.lbl_telefon);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Name = "YeniKayit";
            this.Text = "YeniKayit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YeniKayit_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grd_telefonlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.ComboBox cmb_telefonTuru;
        private System.Windows.Forms.Label lbl_tur;
        private System.Windows.Forms.DataGridView grd_telefonlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn numara;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}