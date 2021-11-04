using CSForms2ES102_main.OkulIslemleri.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSForms2ES102_main.OkulIslemleri
{
    public partial class frmBolumler : Form
    {
      readonly  OkulDbEntities odb = new OkulDbEntities();
        public int IdBul = -1;
        public frmBolumler()
        {
            InitializeComponent();
        }

        private void frmBolumler_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void listele()
        {
            liste.Rows.Clear();
            int i = 0;
            var lst = (from s in odb.tblBolumler select s).ToList();
            foreach (var k in lst)
            {
                liste.Rows.Add();
                liste.Rows[i].Cells[0].Value = k.Id;
                liste.Rows[i].Cells[1].Value = k.BolumAdi;
                i++;
            }
            liste.AllowUserToAddRows = false;
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (IdBul>0)
            {
                Guncelle();
            }
            else
            {
                yeniKayit();
            }
            
            listele();
        }
        private void yeniKayit()
        {
            try
            {
                tblBolumler blm = new tblBolumler();
                blm.BolumAdi = txtBolumAdi.Text;
                odb.tblBolumler.Add(blm);
                odb.SaveChanges();
                MessageBox.Show("Yeni kayıt eklendi");

            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : "+e);
            }
        }
        private void Guncelle()
        {
            tblBolumler blm = odb.tblBolumler.First(x => x.Id == IdBul);
            blm.BolumAdi = txtBolumAdi.Text;           
            odb.SaveChanges();
            IdBul = -1;
            txtBolumAdi.Clear();
        }

        private void liste_DoubleClick(object sender, EventArgs e)
        {
            IdBul = int.Parse(liste.CurrentRow.Cells[0].Value.ToString());
            txtBolumAdi.Text = liste.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
