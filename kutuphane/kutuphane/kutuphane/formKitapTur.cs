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
using System.Collections;

namespace kutuphane
{
    public partial class formKitapTur : Form
    {
        VTislemleri veritabaniislemi = new VTislemleri();
        OleDbCommand komut;
        OleDbConnection con;
        OleDbDataAdapter adapter;
        OleDbDataReader dr;
        DataTable tablo;
        bool kitapbostami = true;
        ArrayList teslimEdilmeyenKitaplar = new ArrayList();
        public formKitapTur()
        {
            InitializeComponent();
        }

        private void formKitapTur_Load(object sender, EventArgs e)
        {
            con = veritabaniislemi.Baglan();
            listele();
        }
        void listele()
        {
            try
            {
                con = veritabaniislemi.Baglan();
                adapter = new OleDbDataAdapter("SELECT kitap_id,kitap_adi, yazar, yayinevi, sayfa_sayisi, tur_adi FROM kitaplar, kitap_turleri WHERE kitaplar.tur_id = kitap_turleri.tur_id; ", con);
                tablo = new DataTable();
                adapter.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA OLUŞTU", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                //komut = new OleDbCommand("SELECT * FROM odunc_kitaplar WHERE kitap_id=@id",con);
                //komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                //dr = komut.ExecuteReader();

                //while (dr.Read()) 
                //{ 
                //    if (dr["teslim_tarihi"] is null) 
                //    {
                //        kitapbostami = false;
                //    }
                //    MessageBox.Show("asd");
                //}
                teslimEdilmeyenKitaplar.Clear();
                komut = new OleDbCommand("SELECT * FROM odunc_kitaplar WHERE teslim_tarihi is null", con);
                dr = komut.ExecuteReader();
                
                while (dr.Read())
                {
                    teslimEdilmeyenKitaplar.Add(dr["kitap_id"].ToString());
                }

                if (!teslimEdilmeyenKitaplar.Contains(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
                {
                    DialogResult cevap = MessageBox.Show($"{dataGridView1.CurrentRow.Cells[1].Value.ToString()} adlı kitabı Silmek istediğinize emin misiniz","UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                    if (cevap == DialogResult.Yes)
                    {
                        OleDbCommand komut = new OleDbCommand("DELETE * FROM kitaplar WHERE kitap_id=@id", con);
                        komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        komut.ExecuteNonQuery();
                        con.Close();
                        listele();
                    }
                    else if (cevap == DialogResult.No)
                        MessageBox.Show("işlem iptal edildi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kitap bir öğrenciye verilmiş lütfen geri alıp tekrar deneyin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Bir hata oluştu", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
