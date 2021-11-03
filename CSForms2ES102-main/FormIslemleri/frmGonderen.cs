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
    public partial class frmGonderen : Form
    {
       
        public frmGonderen()
        {
            InitializeComponent();
        }

        private void frmGonderen_FormClosing(object sender, FormClosingEventArgs e)
        {

            AnaSayfa.ctrl = false;
        }

        private void frmGonderen_Load(object sender, EventArgs e)
        {
            //AnaSayfa.ctrl = true;
        }
        void temizle()
        {
            txtad.Clear();
            txtSoyad.Clear();
            txtAdres.Clear();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            frmAlan frmal = new frmAlan();
            frmal.lblAd.Text = txtad.Text;
            frmal.lblAdres.Text = txtAdres.Text;
            frmal.lblSoyad.Text = txtSoyad.Text;
            temizle();
            frmal.ShowDialog();

        }
    }
}
