//using CsForms102_Main.Fonksiyonlar;
//using CsForms102_Main.Okulİslemler.Entity;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace CsForms102_Main.Okulİslemler
//{
//    public partial class frmBolumler : Form
//    {
//        readonly OkulDbEntities1 odb = new OkulDbEntities1();
//        public int IdBul = -1;
//        public bool Edit = false;
//        public frmBolumler()
//        {
//            InitializeComponent();
//        }

//        private void frmBolumler_Load(object sender, EventArgs e)
//        {
//            Listele();
//        }
//        private void Listele()
//        {
//            Liste.Rows.Clear();
//            int i = 0;
//            if (rbHepsi.Checked == true)
//            {
//                var lst = (from s in odb.tblBolumler select s).ToList();
//                foreach (var k in lst)
//                {
//                    Liste.Rows.Add();
//                    Liste.Rows[i].Cells[0].Value = k.Id;
//                    Liste.Rows[i].Cells[1].Value = k.BolumAdi;
//                    Liste.Rows[i].Cells[2].Value = k.IsActive;
//                    i++;
//                }
//            }
//            else if (rbAktif.Checked == true)
//            {
//                var lst = (from s in odb.tblBolumler where s.IsActive == true select s).ToList();
//                foreach (var k in lst)
//                {
//                    Liste.Rows.Add();
//                    Liste.Rows[i].Cells[0].Value = k.Id;
//                    Liste.Rows[i].Cells[1].Value = k.BolumAdi;
//                    Liste.Rows[i].Cells[2].Value = k.IsActive;
//                    i++;
//                }
//            }
//            else if (rbPasif.Checked == true)
//            {
//                var lst = (from s in odb.tblBolumler where s.IsActive == false select s).ToList();
//                foreach (var k in lst)
//                {
//                    Liste.Rows.Add();
//                    Liste.Rows[i].Cells[0].Value = k.Id;
//                    Liste.Rows[i].Cells[1].Value = k.BolumAdi;
//                    Liste.Rows[i].Cells[2].Value = k.IsActive;
//                    i++;
//                }
//            }
//            //Dışarıdan satır eklemeyi engellemek için kullanılır.
//            Liste.AllowUserToAddRows = false;
//        }
//        private void Temizle()
//        {
//            IdBul = -1;
//            Edit = false;
//            txtBolumAdi.Clear();
//            label1.ForeColor = Color.Black;
//            label1.Text = label1.Text;
//        }
//        Mesajlar mesajlar = new Mesajlar();
//        private void YeniKayit()
//        {
//            try
//            {
//                if (txtBolumAdi.Text != "")
//                {
//                    tblBolumler blm = new tblBolumler();
//                    blm.BolumAdi = txtBolumAdi.Text;
//                    blm.IsActive = true;
//                    odb.tblBolumler.Add(blm);
//                    odb.SaveChanges();
//                    mesajlar.YeniKayit("Yeni kayıt oluşturuldu...");
//                    //MessageBox.Show("Yeni kayıt oluşturuldu...");
//                    Listele();
//                }
//                else
//                {
//                    label1.ForeColor = Color.Coral;
//                    label1.Text = label1.Text + " *";
//                    mesajlar.YeniKayit("Lütfen geçerli bir bölüm adı giriniz.");
//                    //MessageBox.Show("Lütfen geçerli bir bölüm adı giriniz.");
//                }
//            }
//            catch (Exception e)
//            {
//                mesajlar.YeniKayit("Hata : " + e);
//                //MessageBox.Show("Hata : " + e);
//            }
//        }
//        private void Guncelle()
//        {
//            try
//            {
//                tblBolumler blm = odb.tblBolumler.First(x => x.Id == IdBul);
//                blm.BolumAdi = txtBolumAdi.Text;
//                //Hata almak için
//                //blm.Id = 234;
//                odb.SaveChanges();
//                MessageBox.Show("Güncelleme işlemi yapıldı.");
//                IdBul = -1;
//                txtBolumAdi.Clear();
//                Listele();
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(" " + e);
//                Close();
//            }
//        }
//        private void btnKayit_Click(object sender, EventArgs e)
//        {

//            if (IdBul > 0 && Edit == true && mesajlar.Guncelle() == DialogResult.Yes)
//            {
//                Guncelle();
//            }
//            else if (Edit == false && VarMi(txtBolumAdi.Text) != true)
//            {
//                YeniKayit();
//            }
//            Listele();
//            Temizle();
//        }

//        private void Liste_DoubleClick(object sender, EventArgs e)
//        {
//            try
//            {
//                Edit = true;
//                if (Liste.CurrentRow != null)
//                {
//                    //casting işlemi sadece object lerde kullanılabilir.
//                    IdBul = (int)Liste.CurrentRow.Cells[0].Value;
//                    //IdBul = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
//                    txtBolumAdi.Text = Liste.CurrentRow.Cells[1].Value.ToString();
//                }
//            }
//            catch (Exception)
//            {
//                Edit = false;
//                IdBul = -1;
//            }
//        }

//        private void txtBolumAdi_KeyPress(object sender, KeyPressEventArgs e)
//        {
//            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
//        }
//        private bool VarMi(string aranan)
//        {
//            var arananDeger = (from b in odb.tblBolumler where b.BolumAdi == aranan select b).ToList();
//            bool deger;
//            if (arananDeger.Count > 0)
//            {
//                deger = true;
//                MessageBox.Show("Eklenmek istenen kayıt veritabanında mevcuttur.");
//            }
//            else
//            {
//                deger = false;
//            }
//            return deger;
//        }

//        private void btnSil_Click(object sender, EventArgs e)
//        {
//            Sil();
//        }

//        private void Sil()
//        {
//            if (txtBolumAdi.Text != "")
//            {
//                //tblBolumler blm = odb.tblBolumler.First(x=>x.Id == IdBul);
//                tblBolumler blm = odb.tblBolumler.Find(IdBul);
//                blm.IsActive = false;
//                odb.SaveChanges();
//                MessageBox.Show("Kayıt geçici olarak silinmiştir.");
//            }
//            else
//            {
//                MessageBox.Show("Kayda düzgün tıklayın");
//            }
//            Temizle();
//            Listele();
//        }

//        private void rbHepsi_CheckedChanged(object sender, EventArgs e)
//        {
//            Listele();
//        }

//        private void rbAktif_CheckedChanged(object sender, EventArgs e)
//        {
//            Listele();
//        }

//        private void rbPasif_CheckedChanged(object sender, EventArgs e)
//        {
//            Listele();
//        }

//        private void btnTamSil_Click(object sender, EventArgs e)
//        {
//            if (txtBolumAdi.Text != "")
//            {
//                odb.tblBolumler.Remove(odb.tblBolumler.Find(IdBul));
//                odb.SaveChanges();
//                MessageBox.Show("Kayıt kalıcı olarak silinmiştir.");
//            }

//            Temizle();
//            Listele();
//        }
//    }
//}
