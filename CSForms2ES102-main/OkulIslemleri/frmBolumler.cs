using CSForms2ES102_main.Fonksiyonlar;
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
        readonly OkulDbEntities odb = new OkulDbEntities();
        Mesajlar m = new Mesajlar();
        public int IdBul = -1;
        public bool edit = false;
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
            int i = 0;
            liste.Rows.Clear();
            if (rbHepsi.Checked == true)
            {


                var lst = (from s in odb.tblBolumler select s).ToList();
                foreach (var k in lst)
                {
                    liste.Rows.Add();
                    liste.Rows[i].Cells[0].Value = k.Id;
                    liste.Rows[i].Cells[1].Value = k.BolumAdi;
                    liste.Rows[i].Cells[2].Value = k.isActive;
                    i++;
                }
                liste.AllowUserToAddRows = false;
            }
            else if (rbActive.Checked == true)
            {
                var lst = (from s in odb.tblBolumler where s.isActive == true select s).ToList();
                foreach (var k in lst)
                {
                    liste.Rows.Add();
                    liste.Rows[i].Cells[0].Value = k.Id;
                    liste.Rows[i].Cells[1].Value = k.BolumAdi;
                    liste.Rows[i].Cells[2].Value = k.isActive;
                    i++;
                }
                liste.AllowUserToAddRows = false;
            }
            else if (rbPassive.Checked == true)
            {
                var lst = (from s in odb.tblBolumler where s.isActive == false select s).ToList();
                foreach (var k in lst)
                {
                    liste.Rows.Add();
                    liste.Rows[i].Cells[0].Value = k.Id;
                    liste.Rows[i].Cells[1].Value = k.BolumAdi;
                    liste.Rows[i].Cells[2].Value = k.isActive;
                    i++;
                }
                liste.AllowUserToAddRows = false;
            }
        }
        private void Temizle()
        {
            IdBul = -1;
            edit = false;
            txtBolumAdi.Clear();
            label1.ForeColor = Color.Aquamarine;
            label1.Text = "Bölüm Adı Giriş";
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (IdBul > 0 && edit == true && m.Guncelle() == DialogResult.Yes)
            {
                Guncelle();
            }
            else if (edit == false && VarMi(txtBolumAdi.Text)!=true)
            {
                yeniKayit();
            }
            listele();
            Temizle();
        }
        private void yeniKayit()
        {
            try
            {
                if (txtBolumAdi.Text != "" )
                {
                    tblBolumler blm = new tblBolumler();
                    blm.BolumAdi = txtBolumAdi.Text;
                    blm.isActive = true;
                    odb.tblBolumler.Add(blm);
                    //hata için yazıldı
                    // blm.Id = 234;
                    odb.SaveChanges();
                    m.YeniKayit("Yeni kayıt eklendi");
                    //MessageBox.Show("Yeni kayıt eklendi"); 
                }
                else
                {
                    //MessageBox.Show("Lütfen gerekli alanları doldurun");
                    label1.ForeColor = Color.Blue;
                    m.YeniKayit("Lütfen gerekli alanları doldurun");
                    label1.Text = "Bölüm Adı Giriş ***";
                }

            }
            catch (Exception e)
            {
                m.YeniKayit(e);
                //MessageBox.Show("Hata : "+e);
            }
        }
        private void Guncelle()
        {
            try
            {
                tblBolumler blm = odb.tblBolumler.First(x => x.Id == IdBul);
                blm.BolumAdi = txtBolumAdi.Text;
                //hata almak için 
                //blm.Id = 234;
                odb.SaveChanges();
                MessageBox.Show("Güncelleme işlemi yapıldı.");
                IdBul = -1;
                txtBolumAdi.Clear();
            }
            catch (Exception e)
            {

                MessageBox.Show("" + e);
                Close();
            }
        }

        private void liste_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (liste.CurrentRow != null)
                {

                    IdBul = int.Parse(liste.CurrentRow.Cells[0].Value.ToString());
                    // IdBul = (int)liste.CurrentRow.Cells[0].Value; objeleri inte çevirmek
                    // için kullanılır işlem yükü ağırdır.
                    txtBolumAdi.Text = liste.CurrentRow.Cells[1].Value.ToString();
                    edit = true;
                }
            }
            catch (Exception)
            {

                edit = false;
                IdBul = -1;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void Sil()
        {
            //tblBolumler blm = odb.tblBolumler.First(x => x.Id == IdBul);
            if (txtBolumAdi.Text != "")
            {
                tblBolumler blm = odb.tblBolumler.Find(IdBul);
                blm.isActive = false;
                odb.SaveChanges();
                MessageBox.Show("Kayıt geçici olarak silindi...");
            }
            else
            {
                MessageBox.Show("kaydı düzgün ekleyin");
            }
            Temizle();
            listele();

        }

        private void rbHepsi_CheckedChanged(object sender, EventArgs e)
        {
            listele();
        }

        private void rbActive_CheckedChanged(object sender, EventArgs e)
        {
            listele();
        }

        private void rbPassive_CheckedChanged(object sender, EventArgs e)
        {
            listele();
        }

        private void btnTamSil_Click(object sender, EventArgs e)
        {
            if (txtBolumAdi.Text != "")
            {
                odb.tblBolumler.Remove(odb.tblBolumler.Find(IdBul));
                odb.SaveChanges();
                MessageBox.Show("Kayıt Kalıcı olarak Silinmiştir...");
            }
           
            Temizle();
            listele();
        }
        private bool VarMi(string aranan)
        {
            var arananDeger = (from b in odb.tblBolumler
                               where b.BolumAdi == aranan
                               select b).ToList();
            bool deger;
            if (arananDeger.Count > 0)
            {
                deger = true;
                MessageBox.Show("Eklenen istediğiniz veri mevcut");
            }
            else
            {
                deger = false;
            }
            return deger;
        }

        private void liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
