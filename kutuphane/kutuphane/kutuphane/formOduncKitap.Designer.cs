
namespace kutuphane
{
    partial class formOduncKitap
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKitapAl = new System.Windows.Forms.Button();
            this.btnKitapVer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboKitapAdi = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOgrenciAra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gridOduncKitaplar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOduncKitaplar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKitapAl);
            this.groupBox3.Controls.Add(this.btnKitapVer);
            this.groupBox3.Location = new System.Drawing.Point(366, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(533, 146);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // btnKitapAl
            // 
            this.btnKitapAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapAl.Image = global::kutuphane.Properties.Resources.kitap;
            this.btnKitapAl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKitapAl.Location = new System.Drawing.Point(395, 19);
            this.btnKitapAl.Name = "btnKitapAl";
            this.btnKitapAl.Size = new System.Drawing.Size(97, 98);
            this.btnKitapAl.TabIndex = 4;
            this.btnKitapAl.TabStop = false;
            this.btnKitapAl.Text = "Kitap Al";
            this.btnKitapAl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitapAl.UseVisualStyleBackColor = true;
            this.btnKitapAl.Click += new System.EventHandler(this.btnKitapAl_Click);
            // 
            // btnKitapVer
            // 
            this.btnKitapVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapVer.Image = global::kutuphane.Properties.Resources.kitapver;
            this.btnKitapVer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKitapVer.Location = new System.Drawing.Point(60, 19);
            this.btnKitapVer.Name = "btnKitapVer";
            this.btnKitapVer.Size = new System.Drawing.Size(87, 98);
            this.btnKitapVer.TabIndex = 2;
            this.btnKitapVer.TabStop = false;
            this.btnKitapVer.Text = "KİTAP VER";
            this.btnKitapVer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitapVer.UseVisualStyleBackColor = true;
            this.btnKitapVer.Click += new System.EventHandler(this.btnKitapVer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Öğrenci No";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(69, 13);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 20);
            this.txtNo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kitap Adı";
            // 
            // comboKitapAdi
            // 
            this.comboKitapAdi.FormattingEnabled = true;
            this.comboKitapAdi.Location = new System.Drawing.Point(69, 46);
            this.comboKitapAdi.Name = "comboKitapAdi";
            this.comboKitapAdi.Size = new System.Drawing.Size(121, 21);
            this.comboKitapAdi.TabIndex = 7;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(632, 11);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(255, 52);
            this.txtAciklama.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Açıklama";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOgrenciAra);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 146);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ara";
            // 
            // txtOgrenciAra
            // 
            this.txtOgrenciAra.Location = new System.Drawing.Point(75, 72);
            this.txtOgrenciAra.Name = "txtOgrenciAra";
            this.txtOgrenciAra.Size = new System.Drawing.Size(100, 20);
            this.txtOgrenciAra.TabIndex = 1;
            this.txtOgrenciAra.TextChanged += new System.EventHandler(this.txtOgrenciAra_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Öğrenci Adı";
            // 
            // gridOduncKitaplar
            // 
            this.gridOduncKitaplar.AllowUserToAddRows = false;
            this.gridOduncKitaplar.AllowUserToDeleteRows = false;
            this.gridOduncKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOduncKitaplar.Location = new System.Drawing.Point(12, 272);
            this.gridOduncKitaplar.Name = "gridOduncKitaplar";
            this.gridOduncKitaplar.ReadOnly = true;
            this.gridOduncKitaplar.Size = new System.Drawing.Size(893, 363);
            this.gridOduncKitaplar.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboKitapAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(893, 78);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgi Girişi";
            // 
            // formOduncKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 647);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridOduncKitaplar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formOduncKitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödünç Kitap İşlemleri";
            this.Load += new System.EventHandler(this.formOduncKitap_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOduncKitaplar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKitapAl;
        private System.Windows.Forms.Button btnKitapVer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboKitapAdi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOgrenciAra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gridOduncKitaplar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}