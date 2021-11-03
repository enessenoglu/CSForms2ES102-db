using CSForms2ES102_main.FormIslemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSForms2ES102_main
{
    public partial class AnaSayfa : Form
    {
        
        public static bool ctrl = false;
        public static bool ctrlal = false;
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            gbSol.Text = btn1.Text;
            pnl1.Visible = true;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            gbSol.Text = btn2.Text;
            pnl1.Visible = false;
            pnl2.Visible = true;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            gbSol.Text = btn3.Text;
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = true;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            gbSol.Text = btn4.Text;
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = true;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            gbSol.Text = btn5.Text;
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = true;
            pnl6.Visible = false;
            pnl7.Visible = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            gbSol.Text = btn6.Text;
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = true;
            pnl7.Visible = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            gbSol.Text = btn7.Text;
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = true;
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngonderen_Click(object sender, EventArgs e)
        {
            if (ctrl==false)
            {
                
                frmGonderen frmgon = new frmGonderen();
                frmgon.MdiParent = Form.ActiveForm;
                frmgon.WindowState = FormWindowState.Maximized;
                frmgon.Show(); 
            }
            
        }

        private void btnalan_Click(object sender, EventArgs e)
        {
            if (ctrlal==false)
            {
                frmAlan frmal = new frmAlan();
                frmal.MdiParent = Application.OpenForms["AnaSayfa"] as AnaSayfa;
                frmal.WindowState = FormWindowState.Maximized;
                frmal.Show(); 
            }
        }

        private void btnGonderProp_Click(object sender, EventArgs e)
        {
            frmGonderProp frmal = new frmGonderProp();
            frmal.MdiParent = Application.OpenForms["AnaSayfa"] as AnaSayfa;
            frmal.WindowState = FormWindowState.Maximized;
            frmal.Show();
        }
    }
}
