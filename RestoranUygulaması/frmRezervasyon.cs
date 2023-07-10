using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranUygulaması
{
    public partial class frmRezervasyon : Form
    {
        public frmRezervasyon()
        {
            InitializeComponent();
        }
        private void frmRezervasyon_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(gnl.constring);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Masalar WHERE Durum='1'", conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbMasaNo.Items.Add("Masa" + dr["MasaNo"]);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz? ", "UYARI !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
        cGenel gnl = new cGenel();
        public static int tiklandi = 0; public static int tiklandi1 = 0;
        
        private void bunibtnRezerveEt_Click(object sender, EventArgs e)
        {
            tiklandi = 1;

            if (txtAdSoyad.Text == "" || txtSaat.Text == "" || txtTelefon.Text == "" || cmbMasaNo.Text == "")
            {
                MessageBox.Show("Lütfen gerekli bilgileri doldurunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(gnl.constring);
                    SqlCommand cmd = new SqlCommand("INSERT INTO Rezervasyonlar(AdSoyad,TelefonNo,MasaNo,Saat) values (@AdSoyad,@TelefonNo,@MasaNo,@Saat)", conn);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text.ToString());
                    cmd.Parameters.AddWithValue("@TelefonNo", txtTelefon.Text.ToString());
                    cmd.Parameters.AddWithValue("@MasaNo", cmbMasaNo.Text.ToString());
                    cmd.Parameters.AddWithValue("@Saat", txtSaat.Text.ToString());
                    cmd.ExecuteNonQuery();
                    conn.Close();    
                }
                catch (SqlException ex)
                {
                    string hata = ex.Message;
                    throw;
                }
                
                cMasalar durum = new cMasalar();
                
                cGenel.ButtonName = "btnmasa1";
                durum.MasaDurumDegistirme(cmbMasaNo.Text, 3);
                this.Hide();
                
            }
            
        }
    }
}
