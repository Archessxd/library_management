using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kutuphane
{
    public partial class formOgrenciIslemleri : Form
    {
        VTislemleri veritabaniislemi = new VTislemleri();
        OleDbConnection baglanti;
        OleDbCommand komut;
        string komutcumlesi;
            
        public formOgrenciIslemleri()
        {
            InitializeComponent();
        }

        private void formOgrenciIslemleri_Load(object sender, EventArgs e)
        {
            listele();
        }

        void listele()
        {
            try 
            {
                baglanti = veritabaniislemi.Baglan();
                komutcumlesi = "SELECT * FROM ogrenciler";
                OleDbDataAdapter da = new OleDbDataAdapter(komutcumlesi,baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridOgrenci.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"HATA OLUŞTU",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void gridOgrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNo.Text = gridOgrenci.CurrentRow.Cells["ogrenci_no"].Value.ToString();
            txtAd.Text = gridOgrenci.CurrentRow.Cells["ad"].Value.ToString();
            txtSoyad.Text = gridOgrenci.CurrentRow.Cells["soyad"].Value.ToString();
            txtTelefon.Text = gridOgrenci.CurrentRow.Cells["telefon"].Value.ToString();
            comboSinif.SelectedItem = gridOgrenci.CurrentRow.Cells["sinif"].Value.ToString();
            comboCinsiyet.SelectedItem = gridOgrenci.CurrentRow.Cells["cinsiyet"].Value.ToString();
        }

        void temizle()
        {
            txtAd.Text = null;
            txtSoyad.Text = null;
            txtNo.Text = null;
            txtTelefon.Text = null;
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                komutcumlesi = "INSERT INTO ogrenciler(ogrenci_no,ad,soyad,sinif,cinsiyet,telefon) VALUES(@no,@ad,@soyad,@sinif,@cinsiyet,@tel)";
                komut = new OleDbCommand(komutcumlesi,baglanti);
                komut.Parameters.AddWithValue("@no",int.Parse(txtNo.Text));
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@sinif", comboSinif.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@tel", txtTelefon.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
                MessageBox.Show("kayıt başarıyla eklendi", "MESAJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA OLUŞTU", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                DialogResult cevap = MessageBox.Show(txtAd.Text + " " + txtSoyad.Text+" "+ "isimli kaydı silmek istediğinize emin misiniz (BU İŞLEM BİLGİLERİ KALICI OLARAK SİLECEKTİR)","UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            
                if(cevap==DialogResult.Yes)
                {
                    komutcumlesi = "DELETE * FROM ogrenciler WHERE ogrenci_no=@no";
                    komut = new OleDbCommand(komutcumlesi,baglanti);
                    komut.Parameters.AddWithValue("@no", gridOgrenci.CurrentRow.Cells["ogrenci_no"].Value.ToString());
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    listele();
                    MessageBox.Show("kayıt başarıyla silindi", "MESAJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                }
                else if (cevap==DialogResult.No)
                {
                    MessageBox.Show("Silme işlemi iptal edildi.","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    temizle();
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA OLUŞTU", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {

                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                DialogResult cevap = MessageBox.Show($"{txtAd.Text} {txtSoyad.Text} Güncellemek istediğinize emin misiniz", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (cevap == DialogResult.OK)
                {
                    komutcumlesi = "UPDATE ogrenciler SET ad=@ad,soyad=@soyad,sinif=@sinif,cinsiyet=@cins,telefon=@tel WHERE ogrenci_no=@no";
                    komut = new OleDbCommand(komutcumlesi,baglanti);

                    
                    komut.Parameters.AddWithValue("@ad", txtAd.Text);
                    komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@sinif", comboSinif.SelectedItem.ToString());
                    komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.SelectedItem.ToString());
                    komut.Parameters.AddWithValue("@tel", txtTelefon.Text);
                    komut.Parameters.AddWithValue("@no", int.Parse(txtNo.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    listele();
                    MessageBox.Show("kayıt başarıyla güncellendi", "MESAJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                }
                else if (cevap == DialogResult.Cancel)
                {
                    MessageBox.Show("İşlem iptal edildi", "MESAJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA OLUŞTU", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txtOgrenciAra_TextChanged(object sender, EventArgs e)
        {
            OgrenciArama(txtOgrenciAra.Text);
        }

        public void OgrenciArama(string aranacakkelime)
        {
            try
            {

                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                komut = new OleDbCommand();
                komut.Connection = baglanti;
                komutcumlesi = "SELECT * FROM ogrenciler WHERE ad LIKE '" + txtOgrenciAra.Text + "%'";
                komut.CommandText = komutcumlesi;

                OleDbDataAdapter adapter = new OleDbDataAdapter(komut);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                baglanti.Close();
                gridOgrenci.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA OLUŞTU", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
