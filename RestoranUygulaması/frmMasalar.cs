using DevExpress.Utils.Extensions;
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
    public partial class frmMasalar : Form
    {
        public frmMasalar()
        {
            InitializeComponent();
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz? ", "UYARI !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
        private void frmMasalar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1)
            {
                btnMasa1.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                btnMasa2.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad3)
            {
                btnMasa3.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad4)
            {
                btnMasa4.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad5)
            {
                btnMasa5.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad6)
            {
                btnMasa6.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad7)
            {
                btnMasa7.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad8)
            {
                btnMasa8.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad9)
            {
                btnMasa9.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad0)
            {
                btnMasa10.PerformClick();
            }
        }

        #region TableButtons
        private void btnMasa1_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa1.Text.Length;
            cGenel.ButtonValue = btnMasa1.Text.Substring(uzunluk - 6, 6);
            cGenel.ButtonName = btnMasa1.Name;
            this.Close(); frm.Show();
        }
        private void btnMasa2_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa2.Text.Length;
            cGenel.ButtonValue = btnMasa2.Text.Substring(uzunluk - 6, 6);
            cGenel.ButtonName = btnMasa2.Name;
            this.Close(); frm.Show();
        }

        private void btnMasa3_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa3.Text.Length;
            cGenel.ButtonValue = btnMasa3.Text.Substring(uzunluk - 6, 6);
            cGenel.ButtonName = btnMasa3.Name;
            this.Close(); frm.Show();
        }

        private void btnMasa4_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa4.Text.Length;
            cGenel.ButtonValue = btnMasa4.Text.Substring(uzunluk - 6, 6);
            cGenel.ButtonName = btnMasa4.Name;
            this.Close(); frm.Show();
        }

        private void btnMasa5_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa5.Text.Length;
            cGenel.ButtonValue = btnMasa5.Text.Substring(uzunluk - 6, 6);
            cGenel.ButtonName = btnMasa5.Name;
            this.Close(); frm.Show();
        }

        private void btnMasa6_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa6.Text.Length;
            cGenel.ButtonValue = btnMasa6.Text.Substring(uzunluk - 6, 6);
            cGenel.ButtonName = btnMasa6.Name;
            this.Close(); frm.Show();
        }

        private void btnMasa7_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa7.Text.Length;
            cGenel.ButtonValue = btnMasa7.Text.Substring(uzunluk - 6, 6);
            cGenel.ButtonName = btnMasa7.Name;
            this.Close(); frm.Show();
        }

        private void btnMasa8_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa8.Text.Length;
            cGenel.ButtonValue = btnMasa8.Text.Substring(uzunluk - 6, 6);
            cGenel.ButtonName = btnMasa8.Name;
            this.Close(); frm.Show();
        }

        private void btnMasa9_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa9.Text.Length;
            cGenel.ButtonValue = btnMasa9.Text.Substring(uzunluk - 6, 6);
            cGenel.ButtonName = btnMasa9.Name;
            this.Close(); frm.Show();
        }

        private void btnMasa10_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa10.Text.Length;
            cGenel.ButtonValue = btnMasa10.Text.Substring(uzunluk - 7, 7);
            cGenel.ButtonName = btnMasa10.Name;
            this.Close(); frm.Show();
        } 
        #endregion

        cGenel gnl=new cGenel();
        cMasalar ms=new cMasalar();
        private void frmMasalar_Load(object sender, EventArgs e)
        {
            frmRezervasyon rez=new frmRezervasyon();
            if (frmRezervasyon.tiklandi == 1)
            {
                rez.cmbMasaNo.Text = cGenel.ButtonName;
                ms.MasaDurumDegistirme(cGenel.ButtonName, 3);
                frmRezervasyon.tiklandi = 0;
            }
            else
            {
                SqlConnection conn = new SqlConnection(gnl.constring);
                SqlCommand cmd = new SqlCommand("SELECT MasaNo,Durum FROM Masalar", conn);
                SqlDataReader dr;

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    foreach (Control item in this.Controls)
                    {
                        if (item is Button)
                        {
                            if (item.Name == "btnMasa" + dr["MasaNo"].ToString() && dr["Durum"].ToString() == "1")
                            {
                                item.BackgroundImage = Properties.Resources.GreenColor;
                            }
                            else if (item.Name == "btnMasa" + dr["MasaNo"].ToString() && dr["Durum"].ToString() == "2")
                            {
                                item.BackgroundImage = Properties.Resources.RedColor;
                            }
                            else if (item.Name == "btnMasa" + dr["MasaNo"].ToString() && dr["Durum"].ToString() == "3")
                            {
                                item.BackgroundImage = Properties.Resources.BlueColor;
                            }
                        }
                    }
                } dr.Close(); conn.Close();
            }
        }
    }
}
