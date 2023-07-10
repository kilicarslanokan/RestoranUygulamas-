using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranUygulaması
{
    public partial class frmSifreSıfırla : Form
    {
        public frmSifreSıfırla()
        {
            InitializeComponent();
        }
        string Pass;
        cGenel gnl = new cGenel();
        public void Up()
        {
            SqlConnection con = new SqlConnection(gnl.constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update PersonelGirisTablosu set Password=@sifre where MailAdress=@mailadres", con);

            cmd.Parameters.AddWithValue("@mailadres", txtMailKontrol.Text); ;
            cmd.Parameters.AddWithValue("@sifre", Pass.ToString());
            cmd.ExecuteReader();
            con.Close();
        }
        public void Microsoft(string GondericiMail, string GondericiPass, string AliciMail)
        {

            SqlConnection con = new SqlConnection(gnl.constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM PersonelGirisTablosu ", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (txtMailKontrol.Text == dr["MailAdress"].ToString())
                {

                    Random rnd = new Random();
                    int a = rnd.Next(100000, 1000000);
                    Pass = a.ToString();
                    SmtpClient sc = new SmtpClient();
                    sc.Port = 587;
                    sc.Host = "smtp.outlook.com";
                    sc.EnableSsl = true;
                    sc.Credentials = new NetworkCredential(GondericiMail, GondericiPass);

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(GondericiMail, "Restoran Otomasyonu");
                    mail.To.Add(AliciMail);
                    mail.Subject = "Şifre Sıfırlama Talebinde Bulundunuz";
                    mail.IsBodyHtml = true;
                    mail.Body = $@"{DateTime.Now.ToString()} Tarihinde şifre sıfırlama talebinde bulundundunuz. Yeni şifreniz: {a}";

                    sc.Send(mail);

                }
                else
                {
                    MessageBox.Show("Bilgileri yanlış girdiniz", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            con.Close();
        }
        private void btnSifreSifirla_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gnl.constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM PersonelGirisTablosu ", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (txtMailKontrol.Text == dr["MailAdress"].ToString())
                {
                    Microsoft("okann057@hotmail.com", "1234okan", txtMailKontrol.Text);
                    Up();
                    MessageBox.Show("Girilen bilgiler eşleştirilir ise şifreniz yenilenecek ve mail olarak gönderilecek.", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSifreSifirla.Click -= btnSifreSifirla_Click;
                }
                else if (txtMailKontrol.Text == "")
                {
                    MessageBox.Show("Mail adresi boş bırakılamaz", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Mail adresi ile veri tabanındaki adresler uyuşmuyor", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            dr.Close();
            con.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmYoneticiGiris frm = new frmYoneticiGiris();
            this.Close(); frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz? ", "UYARI !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void frmSifreSıfırla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                frmYoneticiGiris frm = new frmYoneticiGiris();
                this.Close(); frm.Show();
            }
        }
        private void frmSifreSıfırla_Load(object sender, EventArgs e)
        {
            txtMailKontrol.Focus();
        }
    }
}
