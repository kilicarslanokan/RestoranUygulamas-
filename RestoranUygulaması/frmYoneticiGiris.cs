using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranUygulaması
{
    public partial class frmYoneticiGiris : Form
    {
        public frmYoneticiGiris()
        {
            InitializeComponent();
        }
        public static string ad;
        public static string soyad;
        public static string kullanici_adi;
        public static string sifre;

        cGenel gnl = new cGenel();
        public void Getir()
        {
            SqlConnection con = new SqlConnection(gnl.constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From PersonelGirisTablosu Where Kullanici_Adi like'" + txtKullaniciAdi.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ad = dr["FirstName"].ToString();
                soyad = dr["LastName"].ToString();
                kullanici_adi = dr["Kullanici_Adi"].ToString();
                sifre = dr["Password"].ToString();
            }
            con.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Getir();
            SqlConnection con = new SqlConnection(gnl.constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM PersonelGirisTablosu ", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (txtKullaniciAdi.Text == dr["Kullanici_Adi"].ToString() && txtSifre.Text == dr["Password"].ToString())
                {
                    frmMenu frm=new frmMenu();
                    frm.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bilgileri yanlış girdiniz", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            dr.Close();
            con.Close();

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSifre.Focus();
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGiris.PerformClick();
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
            }
        }
        private void YoneticiGiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                frmAnaSayfa frm = new frmAnaSayfa();
                this.Close(); frm.Show();
            }
        }

        private void frmYoneticiGiris_Load(object sender, EventArgs e)
        {
            txtKullaniciAdi.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmSifreSıfırla sifre = new frmSifreSıfırla();
            sifre.Show();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmAnaSayfa frm=new frmAnaSayfa();
            this.Close(); frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz? ", "UYARI !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
