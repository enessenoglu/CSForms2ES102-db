﻿using CSForms2ES102_main.OkulIslemleri.Entity;
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
    public partial class frmOgrenciler : Form
    {
        readonly OkulDbEntities odb = new OkulDbEntities();
        public int IdBolum = -1;
        public int IdSehir = -1;
        public frmOgrenciler()
        {
            InitializeComponent();
        }

        private void frmOgrenciler_Load(object sender, EventArgs e)
        {
            listele();
            SehirListele();
            BolumListele();

        }
        private void SehirListele()
        {
            var lst = (from s in odb.tblSehirler select s).ToList();
            foreach (var item in lst)
            {
                cbSehir.Items.Add(item.sehir);
            }
        }
        private void BolumListele()
        {
            var lst = (from s in odb.tblBolumler select s).ToList();
            foreach (var item in lst)
            {
                cbBolum.Items.Add(item.BolumAdi);
            }
        }
        private void listele()
        {
            ogrenciListe.Rows.Clear();
            int i = 0;
            
            if (rbHepsi.Checked==true)
            {
                var lst = (from s in odb.tblOgrenciler select s).ToList();
                
                foreach (var k in lst)
                {
                    var lstseh = (from s in odb.tblSehirler where s.id ==k.SehirId  select s).ToList();
                    var lstbol = (from b in odb.tblBolumler where b.Id ==k.BolumId  select b).ToList();
                    ogrenciListe.Rows.Add();

                    ogrenciListe.Rows[i].Cells[0].Value = k.Ad;
                    ogrenciListe.Rows[i].Cells[1].Value = k.Soyadi;
                    ogrenciListe.Rows[i].Cells[2].Value = k.TcNo;
                    ogrenciListe.Rows[i].Cells[3].Value = k.OgrNo;
                    foreach (var l in lstbol)
                    {
                        ogrenciListe.Rows[i].Cells[5].Value = l.BolumAdi;
                    }

                    
                    ogrenciListe.Rows[i].Cells[6].Value = k.IsActive;
                    ogrenciListe.Rows[i].Cells[7].Value = k.Dtarihi;
                    foreach (var j in lstseh)
                    {
                        ogrenciListe.Rows[i].Cells[4].Value = j.sehir;
                    }

                    i++;
                } 
            }
            else if (rbActive.Checked==true)
            {
                var lst = (from s in odb.tblOgrenciler where s.IsActive==true select s).ToList();
              
                foreach (var k in lst)
                {
                    ogrenciListe.Rows.Add();
                    var lstseh = (from s in odb.tblSehirler where s.id == k.SehirId select s).ToList();
                    var lstbol = (from b in odb.tblBolumler where b.Id == k.BolumId select b).ToList();
                    ogrenciListe.Rows[i].Cells[0].Value = k.Ad;
                    ogrenciListe.Rows[i].Cells[1].Value = k.Soyadi;
                    ogrenciListe.Rows[i].Cells[2].Value = k.TcNo;
                    ogrenciListe.Rows[i].Cells[3].Value = k.OgrNo;
                    foreach (var l in lstbol)
                    {
                        ogrenciListe.Rows[i].Cells[5].Value = l.BolumAdi;
                    }

                  
                    ogrenciListe.Rows[i].Cells[6].Value = k.IsActive;
                    ogrenciListe.Rows[i].Cells[7].Value = k.Dtarihi;

                    foreach (var j in lstseh)
                    {
                        ogrenciListe.Rows[i].Cells[4].Value = j.sehir;
                    }
                    i++;
                }

            }
            else if (rbPasif.Checked == true)
            {
                var lst = (from s in odb.tblOgrenciler where s.IsActive == false select s).ToList();
                
                foreach (var k in lst)
                {
                    ogrenciListe.Rows.Add();
                    var lstseh = (from s in odb.tblSehirler where s.id == k.SehirId select s).ToList();
                    var lstbol = (from b in odb.tblBolumler where b.Id == k.BolumId select b).ToList();
                    ogrenciListe.Rows[i].Cells[0].Value = k.Ad;
                    ogrenciListe.Rows[i].Cells[1].Value = k.Soyadi;
                    ogrenciListe.Rows[i].Cells[2].Value = k.TcNo;
                    ogrenciListe.Rows[i].Cells[3].Value = k.OgrNo;
                    foreach (var j in lstseh)
                    {
                        ogrenciListe.Rows[i].Cells[4].Value = j.sehir; 
                    }
                    foreach (var l in lstbol)
                    {
                        ogrenciListe.Rows[i].Cells[5].Value = l.BolumAdi;
                    }
                    
                    ogrenciListe.Rows[i].Cells[6].Value = k.IsActive;
                    ogrenciListe.Rows[i].Cells[7].Value = k.Dtarihi;

                    i++;
                }

            }
            ogrenciListe.AllowUserToAddRows = false;
        }

        private void rbHepsi_CheckedChanged(object sender, EventArgs e)
        {
            listele();
        }

        private void rbActive_CheckedChanged(object sender, EventArgs e)
        {
            listele();
        }

        private void rbPasif_CheckedChanged(object sender, EventArgs e)
        {
            listele();
        }

        private void cbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {

         
            IdSehir = odb.tblSehirler.First(x => x.sehir == cbSehir.Text).id;
        }

        private void cbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            IdBolum = odb.tblBolumler.First(x => x.BolumAdi == cbBolum.Text).Id;
           
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }
        private void YeniKayit()
        {
            //string sehirAdi, bolumAdi;
            try
            {

                if (txtAd.Text != "")
                {
                   // sehirAdi= odb.tblSehirler.First(x => x.id == IdSehir).sehir;
                   // sehirAdi = odb.tblSehirler.First(x => x.id == IdSehir).sehir;
                    tblOgrenciler ogr = new tblOgrenciler();
                    //tblSehirler seh = new tblSehirler();
                   //tblBolumler bol = new tblBolumler();
                    ogr.Ad = txtAd.Text;
                    ogr.Soyadi = txtSoyad.Text;
                    ogr.TcNo = txtTcNo.Text;
                    ogr.OgrNo = txtOgrNo.Text;
                    ogr.BolumId = IdBolum;
                    ogr.SehirId = IdSehir;
                    //seh.sehir = sehirAdi;
                    ogr.IsActive = true;
                    odb.tblOgrenciler.Add(ogr);
                    odb.SaveChanges();
                   // mesajlar.YeniKayit("Yeni kayıt oluşturuldu...");
                    MessageBox.Show("Yeni kayıt oluşturuldu...");
                    listele();
                    IdSehir = -1;
                    IdBolum = -1;
                    
                }
                else
                {
                    //label1.ForeColor = Color.Coral;
                    //label1.Text = label1.Text + " *";
                    //mesajlar.YeniKayit("Lütfen geçerli bir bölüm adı giriniz.");
                    MessageBox.Show("Lütfen Alanları düzgün doldurun");
                }
            }
            catch (Exception e)
            {
               // mesajlar.YeniKayit("Hata : " + e);
                MessageBox.Show("Hata : " + e);
            }
        }
    }
}
