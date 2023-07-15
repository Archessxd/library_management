
namespace kutuphane
{
    partial class formAnasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOdunc = new System.Windows.Forms.Button();
            this.btnTur = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnKitap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOdunc
            // 
            this.btnOdunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdunc.Image = global::kutuphane.Properties.Resources.kitapver;
            this.btnOdunc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOdunc.Location = new System.Drawing.Point(344, 186);
            this.btnOdunc.Name = "btnOdunc";
            this.btnOdunc.Size = new System.Drawing.Size(112, 109);
            this.btnOdunc.TabIndex = 3;
            this.btnOdunc.TabStop = false;
            this.btnOdunc.Text = "Ödünç Kitap İşlemleri";
            this.btnOdunc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOdunc.UseVisualStyleBackColor = true;
            this.btnOdunc.Click += new System.EventHandler(this.btnOdunc_Click);
            // 
            // btnTur
            // 
            this.btnTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTur.Image = global::kutuphane.Properties.Resources.islem;
            this.btnTur.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTur.Location = new System.Drawing.Point(12, 186);
            this.btnTur.Name = "btnTur";
            this.btnTur.Size = new System.Drawing.Size(112, 109);
            this.btnTur.TabIndex = 2;
            this.btnTur.TabStop = false;
            this.btnTur.Text = "Kitap Silme";
            this.btnTur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTur.UseVisualStyleBackColor = true;
            this.btnTur.Click += new System.EventHandler(this.btnTur_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenci.Image = global::kutuphane.Properties.Resources.kisi;
            this.btnOgrenci.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOgrenci.Location = new System.Drawing.Point(344, 17);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(112, 109);
            this.btnOgrenci.TabIndex = 1;
            this.btnOgrenci.TabStop = false;
            this.btnOgrenci.Text = "Ogrenci İşlemleri";
            this.btnOgrenci.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnKitap
            // 
            this.btnKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitap.Image = global::kutuphane.Properties.Resources.kitap;
            this.btnKitap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKitap.Location = new System.Drawing.Point(12, 17);
            this.btnKitap.Name = "btnKitap";
            this.btnKitap.Size = new System.Drawing.Size(112, 109);
            this.btnKitap.TabIndex = 0;
            this.btnKitap.TabStop = false;
            this.btnKitap.Text = "Kitap Ekleme";
            this.btnKitap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitap.UseVisualStyleBackColor = true;
            this.btnKitap.Click += new System.EventHandler(this.btnKitap_Click);
            // 
            // formAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 307);
            this.Controls.Add(this.btnOdunc);
            this.Controls.Add(this.btnTur);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnKitap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKitap;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnTur;
        private System.Windows.Forms.Button btnOdunc;
    }
}

