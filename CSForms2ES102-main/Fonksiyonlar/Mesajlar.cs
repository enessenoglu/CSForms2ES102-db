using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSForms2ES102_main.Fonksiyonlar
{
    class Mesajlar
    {
        public void YeniKayit(string mesaj)
        {
            MessageBox.Show(mesaj, "Yeni Kayit Giriş", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        public void YeniKayit(Exception e)
        {
            MessageBox.Show(e.ToString(), "Hata var !!!", MessageBoxButtons.OK,
                MessageBoxIcon.Information) ;
        }
        public DialogResult Guncelle()
        {

            return MessageBox.Show("Secili olan kayıt güncellenecektir \n güncelleme işlemini onaylıyor musunuz?" ,
                "Güncelleme işlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question) ;
        }
    }
}
