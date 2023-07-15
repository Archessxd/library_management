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
    public partial class formKitap : Form
    {
        VTislemleri vt = new VTislemleri();
        OleDbConnection con;
        OleDbCommand komut;
        OleDbDataAdapter adapter;
        DataTable tablo;

        public formKitap()
        {
            InitializeComponent();
        }

        void comboBoxGuncelle()
        {
            adapter = new OleDbDataAdapter("SELECT * FROM kitap_turleri ORDER BY tur_adi ASC",con);
            tablo = new DataTable();
            adapter.Fill(tablo);
            cbKitapTur.DisplayMember = "tur_adi";
            cbKitapTur.ValueMember = "tur_id";
            cbKitapTur.DataSource = tablo;
        }

        private void formKitap_Load(object sender, EventArgs e)
        {
            con = vt.Baglan();
            comboBoxGuncelle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                komut = new OleDbCommand("INSERT INTO kitaplar(tur_id,kitap_adi,yazar,yayinevi,sayfa_sayisi) VALUES (@turid,@kitapadi,@yazar,@yayinevi,@sayfa)",con);
                komut.Parameters.AddWithValue("@turid", cbKitapTur.SelectedValue);
                komut.Parameters.AddWithValue("@kitapadi", txtKitapAd.Text);
                komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
                komut.Parameters.AddWithValue("@yayinevi", txtYayinEvi.Text);
                komut.Parameters.AddWithValue("@sayfa",Convert.ToInt32(numSayfaSayisi.Value));
                komut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Ekleme İşlemi Başarılı", "UYARI",MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach(Control item in this.Controls)
                {
                    if (item.GetType().ToString() == "System.Windows.Forms.TextBox")
                        item.Text = null;
                }

            }
            catch
            {
                MessageBox.Show("bir hata ile karşılaşıldı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
