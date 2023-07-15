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
    public partial class formOduncKitap : Form
    {
        VTislemleri veritabaniislemi = new VTislemleri();
        OleDbConnection baglanti;
        string komutcumlesi;
        OleDbCommand komut;
        DataTable tablo;
        OleDbDataReader dr;
        int ogrencino;
        public formOduncKitap()
        {
            InitializeComponent();
        }

        private void formOduncKitap_Load(object sender, EventArgs e)
        {
            listele();
            KitapYukle();
        }

        void KitapYukle()
        {
            try
            {
                
                komutcumlesi = "SELECT * FROM kitaplar WHERE kitap_id NOT IN(SELECT kitap_id FROM odunc_kitaplar WHERE teslim_tarihi is null)";
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(komutcumlesi,baglanti);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);

                comboKitapAdi.DataSource = dt;
                comboKitapAdi.ValueMember = "kitap_id";
                comboKitapAdi.DisplayMember = "kitap_adi";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA OLUŞTU", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void listele()
        {
            try
            {
                baglanti = veritabaniislemi.Baglan();
                komutcumlesi = "SELECT id,ogrenci_no,ad,soyad,kitap_adi,verilis_tarihi,teslim_tarihi,aciklama FROM kitaplar,ogrenciler,odunc_kitaplar WHERE ogr_no=ogrenci_no and kitaplar.kitap_id=odunc_kitaplar.kitap_id";
                OleDbDataAdapter da = new OleDbDataAdapter(komutcumlesi, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridOduncKitaplar.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA OLUŞTU", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKitapVer_Click(object sender, EventArgs e)
        {
            try 
            { 
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                komutcumlesi = "INSERT INTO odunc_kitaplar(ogr_no,kitap_id,verilis_tarihi,aciklama) VALUES(@ogrno,@kitapid,@verilistarih,@aciklama)";
                komut = new OleDbCommand(komutcumlesi,baglanti);
                komut.Parameters.AddWithValue("@ogrno", int.Parse(txtNo.Text));
                komut.Parameters.AddWithValue("@kitapid",int.Parse(comboKitapAdi.SelectedValue.ToString()));
                komut.Parameters.AddWithValue("@verilistarih",DateTime.Now.ToString("dd/MM/yyyy"));
                komut.Parameters.AddWithValue("@aciklama",txtAciklama.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("İşlem Başarılı","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                KitapYukle();
                listele();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKitapAl_Click(object sender, EventArgs e)
        {
            baglanti = veritabaniislemi.Baglan();
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                komut = new OleDbCommand("UPDATE odunc_kitaplar SET teslim_tarihi=@tarih WHERE id=@id",baglanti);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString("dd/MM/yyyy"));
                komut.Parameters.AddWithValue("@id", gridOduncKitaplar.CurrentRow.Cells[0].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("İşlem Başarılı , kitap teslim alındı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                KitapYukle();
                listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA OLUŞTU", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtOgrenciAra_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT id,ogrenci_no,ad,soyad,kitap_adi,verilis_tarihi,teslim_tarihi,aciklama FROM kitaplar,ogrenciler,odunc_kitaplar WHERE ogr_no=ogrenci_no and kitaplar.kitap_id=odunc_kitaplar.kitap_id AND ad LIKE '" + txtOgrenciAra.Text + "%'", baglanti);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            gridOduncKitaplar.DataSource = tablo;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }
    }
}
