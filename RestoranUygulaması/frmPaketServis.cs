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
    public partial class frmPaketServis : Form
    {
        public frmPaketServis()
        {
            InitializeComponent();
        }
        private void frmPaketServis_Load(object sender, EventArgs e)
        {

        }
        public static string a;
        public static string b;
        public static string c;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz? ", "UYARI !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void txtAdres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnPaketSiparisAl_Click_1(this, new EventArgs());
            }
        }

        public static int tiklama1 = 0; public static int tiklama2 = 0; public static int tiklama3 = 0; public static int tiklama4 = 0;
        private void btnPaketSiparisAl_Click_1(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text == "" || txtTelNo.Text == "" || txtAdres.Text == "")
            {
                MessageBox.Show("Lütfen gerekli bilgileri doldurunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tiklama1 = 1; tiklama2 = 1; tiklama3 = 1; tiklama4 = 1;
                frmSiparis frm = new frmSiparis();
                frm.lblMasaNo.Text = "Paket Servis";
                a = txtAdSoyad.Text;
                b = txtTelNo.Text;
                c = txtAdres.Text;
                this.Hide(); frm.Show();
            }
        }
    }
}
