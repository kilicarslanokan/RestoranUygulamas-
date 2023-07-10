using System;
using System.Drawing;
using System.Windows.Forms;

namespace RestoranUygulaması
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }
        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {}
        private void frmAnaSayfa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
        private void btnYonetici_Click(object sender, EventArgs e)
        {
            frmYoneticiGiris frm = new frmYoneticiGiris();
            frm.Show(); this.Hide();
        }
        public void btnPersonel_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.btnHesapveGecmisSiparisler.Visible=false;
            frm.BtnRezervasyon.Width= (170);
            frm.BtnRezervasyon.Height = (95);
            frm.BtnCikis.Width = (170);
            frm.BtnCikis.Height = (95);
            frm.BtnCikis.Location = new Point(403,311);
            frm.Show(); this.Hide();
        }
    }
}
