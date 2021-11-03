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
    public partial class frmAlan : Form
    {
        public frmAlan()
        {
            InitializeComponent();
        }

        private void frmAlan_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa.ctrlal = false;
        }

        private void frmAlan_Load(object sender, EventArgs e)
        {
          //  AnaSayfa.ctrlal = true;
        }
    }
}
