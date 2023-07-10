using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranUygulaması
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void BtnMasa_Click(object sender, EventArgs e)
        {
            frmMasalar frm = new frmMasalar();
            frm.Show();
        }
        private void BtnRezervasyon_Click(object sender, EventArgs e)
        {
            frmRezervasyon frm = new frmRezervasyon();
            frm.Show();
        }
        private void BtnPaketServis_Click(object sender, EventArgs e)
        {
            frmPaketServis frm = new frmPaketServis();
            frm.Show();
        }
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz? ", "UYARI !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
        private void frmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                frmAnaSayfa frm = new frmAnaSayfa();
                this.Close(); frm.Show();
            }
        }
        private void btnHesapveGecmisSiparisler_Click(object sender, EventArgs e)
        {
            frmHesapveGecmisSiparisler frm = new frmHesapveGecmisSiparisler();
            frm.Show();
        }
    }
}