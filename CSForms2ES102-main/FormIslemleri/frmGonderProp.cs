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
    public partial class frmGonderProp : Form
    {
        public frmGonderProp()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            NORTHWNDEntities db = new NORTHWNDEntities();
            frmAlProp frm = new frmAlProp();
            frm.elist = db.Employees.Select(x => new ModelKisi
            {
                Ad = x.FirstName,
                Soyad = x.LastName
            }).ToList();
            frm.Show();
        }
    }
}
