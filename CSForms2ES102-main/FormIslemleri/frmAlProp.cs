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
    public partial class frmAlProp : Form
    {
        public List<ModelKisi> elist { set { dataGridView1.DataSource = value; } }
        public frmAlProp()
        {
            InitializeComponent();
        }

        private void frmAlProp_Load(object sender, EventArgs e)
        {

        }
    }
}
