using CSForms2ES102_main.FormIslemleri;
using CSForms2ES102_main.OkulIslemleri;
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
        void paneller()
        {
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
        }            
        private void btn1_Click(object sender, EventArgs e)
        {
            gbSol.Text = btn1.Text;
            paneller();
            collapsUstbutton();
            pnl1.Visible = true;
           
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            gbSol.Text = btn2.Text;
            paneller();
            collapsUstbutton();
            pnl2.Visible = true;
          
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            gbSol.Text = btn3.Text;
            paneller();
            collapsUstbutton();
            pnl3.Visible = true;
           
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            gbSol.Text = btn4.Text;
            paneller();
            collapsUstbutton();
            pnl4.Visible = true;
          
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            gbSol.Text = btn5.Text;
            paneller();
            collapsUstbutton();
            pnl5.Visible = true;
           
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            gbSol.Text = btn6.Text;
            paneller();
            collapsUstbutton();
            pnl6.Visible = true;
          
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            gbSol.Text = btn7.Text;
            paneller();
            collapsUstbutton();
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
        void collaps()
        {
            if (gbSol.Visible == true)
            {
                gbSol.Visible = false;
                btncollaps.Text = "GOSTER";
            }
            else if (gbSol.Visible == false)
            {
                gbSol.Visible = true;
                btncollaps.Text = "GIZLE";
            }
        }
        void collapsUstbutton()
        {
            if (gbSol.Visible==false)
            {
                gbSol.Visible = true;
                btncollaps.Text = "GOSTER";
            }
        }
        private void btncollaps_Click(object sender, EventArgs e)
        {
            collaps();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            Frmhesaplama frmhes = new Frmhesaplama();
            frmhes.Show();
        }

        private void pnlUst_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBolumGiris_Click(object sender, EventArgs e)
        {
            frmBolumler frm = new frmBolumler();
            frm.ShowDialog();
        }

        private void btnogr_Click(object sender, EventArgs e)
        {
            frmOgrenciler frmOgr = new frmOgrenciler();
            frmOgr.ShowDialog();
        }
    }
}
