namespace SinemaOtomasyon
{
    partial class AnaPencere
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
            this.grd_kisiler = new System.Windows.Forms.DataGridView();
            this.btn_yenikayit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_kisiler)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_kisiler
            // 
            this.grd_kisiler.AllowUserToAddRows = false;
            this.grd_kisiler.AllowUserToDeleteRows = false;
            this.grd_kisiler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_kisiler.BackgroundColor = System.Drawing.Color.White;
            this.grd_kisiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_kisiler.Location = new System.Drawing.Point(12, 78);
            this.grd_kisiler.Name = "grd_kisiler";
            this.grd_kisiler.ReadOnly = true;
            this.grd_kisiler.Size = new System.Drawing.Size(776, 360);
            this.grd_kisiler.TabIndex = 0;
            // 
            // btn_yenikayit
            // 
            this.btn_yenikayit.Location = new System.Drawing.Point(12, 23);
            this.btn_yenikayit.Name = "btn_yenikayit";
            this.btn_yenikayit.Size = new System.Drawing.Size(75, 23);
            this.btn_yenikayit.TabIndex = 1;
            this.btn_yenikayit.Text = "Yeni kayit";
            this.btn_yenikayit.UseVisualStyleBackColor = true;
            this.btn_yenikayit.Click += new System.EventHandler(this.btn_yenikayit_Click);
            // 
            // AnaPencere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_yenikayit);
            this.Controls.Add(this.grd_kisiler);
            this.Name = "AnaPencere";
            this.Text = "AnaPencere";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaPencere_closed);
            this.Load += new System.EventHandler(this.yuklendi);
            ((System.ComponentModel.ISupportInitialize)(this.grd_kisiler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_kisiler;
        private System.Windows.Forms.Button btn_yenikayit;
    }
}