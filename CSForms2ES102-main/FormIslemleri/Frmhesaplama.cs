using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSForms2ES102_main.FormIslemleri
{
    public partial class Frmhesaplama : Form
    {
        public Frmhesaplama()
        {
            InitializeComponent();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            frmcevap cevap = new frmcevap();
            int fiyat, kdv;
            double totalKdv, totalFiyat;
            string urunAdi;
            fiyat = Convert.ToInt32(txtFiyat.Text);
            kdv = Convert.ToInt32(txtKDV.Text);
            urunAdi = txtAd.Text;
            totalKdv = (fiyat * kdv) / 100;
            totalFiyat = fiyat + ((fiyat * kdv)/ 100);
            cevap.lblad.Text = urunAdi;
            cevap.lblfiyat.Text = totalFiyat.ToString();
            cevap.lblkdv.Text = totalKdv.ToString();
            cevap.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
