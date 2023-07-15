using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane
{
    public partial class formAnasayfa : Form
    {
        public formAnasayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKitap_Click(object sender, EventArgs e)
        {
            formKitap kitap = new formKitap();
            kitap.ShowDialog();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            formOgrenciIslemleri o = new formOgrenciIslemleri();
            o.ShowDialog();
        }

        private void btnTur_Click(object sender, EventArgs e)
        {
            formKitapTur tur = new formKitapTur();
            tur.ShowDialog();
        }

        private void btnOdunc_Click(object sender, EventArgs e)
        {
            formOduncKitap k = new formOduncKitap();
            k.ShowDialog();
        }
    }
}
