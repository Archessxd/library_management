
namespace kutuphane
{
    partial class formKitap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.cbKitapTur = new System.Windows.Forms.ComboBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtYayinEvi = new System.Windows.Forms.TextBox();
            this.numSayfaSayisi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSayfaSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numSayfaSayisi);
            this.groupBox1.Controls.Add(this.txtYayinEvi);
            this.groupBox1.Controls.Add(this.txtYazar);
            this.groupBox1.Controls.Add(this.cbKitapTur);
            this.groupBox1.Controls.Add(this.txtKitapAd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgileri";
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(93, 66);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(100, 20);
            this.txtKitapAd.TabIndex = 1;
            // 
            // cbKitapTur
            // 
            this.cbKitapTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKitapTur.FormattingEnabled = true;
            this.cbKitapTur.Location = new System.Drawing.Point(93, 29);
            this.cbKitapTur.Name = "cbKitapTur";
            this.cbKitapTur.Size = new System.Drawing.Size(100, 21);
            this.cbKitapTur.TabIndex = 2;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(93, 106);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(100, 20);
            this.txtYazar.TabIndex = 3;
            // 
            // txtYayinEvi
            // 
            this.txtYayinEvi.Location = new System.Drawing.Point(93, 157);
            this.txtYayinEvi.Name = "txtYayinEvi";
            this.txtYayinEvi.Size = new System.Drawing.Size(100, 20);
            this.txtYayinEvi.TabIndex = 4;
            // 
            // numSayfaSayisi
            // 
            this.numSayfaSayisi.Location = new System.Drawing.Point(93, 200);
            this.numSayfaSayisi.Name = "numSayfaSayisi";
            this.numSayfaSayisi.Size = new System.Drawing.Size(100, 20);
            this.numSayfaSayisi.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tür";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kitap Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yazar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Yayınevi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sayfa Sayısı";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(298, 302);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // formKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 363);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formKitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap İşlemleri";
            this.Load += new System.EventHandler(this.formKitap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSayfaSayisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbKitapTur;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.NumericUpDown numSayfaSayisi;
        private System.Windows.Forms.TextBox txtYayinEvi;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
    }
}