using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using ListView = System.Windows.Forms.ListView;

namespace RestoranUygulaması
{
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz? ", "UYARI !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmMasalar frm = new frmMasalar();
            this.Close(); frm.Show();
        }
        //Hesap İşlemi
        void islem(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "btn1":
                    txtAdet.Text += (1).ToString();
                    break;
                case "btn2":
                    txtAdet.Text += (2).ToString();
                    break;
                case "btn3":
                    txtAdet.Text += (3).ToString();
                    break;
                case "btn4":
                    txtAdet.Text += (4).ToString();
                    break;
                case "btn5":
                    txtAdet.Text += (5).ToString();
                    break;
                case "btn6":
                    txtAdet.Text += (6).ToString();
                    break;
                case "btn7":
                    txtAdet.Text += (7).ToString();
                    break;
                case "btn8":
                    txtAdet.Text += (8).ToString();
                    break;
                case "btn9":
                    txtAdet.Text += (9).ToString();
                    break;
                case "btn0":
                    txtAdet.Text += (0).ToString();
                    break;
                default:
                    MessageBox.Show("Sayı Gir!");
                    break;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtAdet.Clear();
        }
        cGenel gnl = new cGenel();
        //Ürünlerin Listelenmesi
        public void UrunlerListele(ListView Cesitler, Button btn)
        {
            Cesitler.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.constring);
            SqlCommand cmd = new SqlCommand("SELECT ID,UrunAd,Fiyat FROM Urunler WHERE Kategori=@Kategori", conn);

            string aa = btn.Name;
            int uzunluk = aa.Length;

            cmd.Parameters.Add("@KATEGORİ", SqlDbType.NVarChar).Value = aa.Substring(3, uzunluk - 3);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                Cesitler.Items.Add(dr["UrunAd"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["Fiyat"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;
            }
            dr.Close();
            conn.Dispose();
            conn.Close();
        }

        #region Çeşitleri Göster
        private void btnAnaYemek_Click(object sender, EventArgs e)
        {
            UrunlerListele(lvMenu, btnAnaYemek);
        }

        private void btnIcecekler_Click(object sender, EventArgs e)
        {
            UrunlerListele(lvMenu, btnIcecekler);
        }

        private void btnTatlilar_Click(object sender, EventArgs e)
        {
            UrunlerListele(lvMenu, btnTatlilar);
        }

        private void btnMakarna_Click(object sender, EventArgs e)
        {
            UrunlerListele(lvMenu, btnMakarna);
        }

        private void btnFastFood_Click(object sender, EventArgs e)
        {
            UrunlerListele(lvMenu, btnFastFood);
        }

        private void btnCorba_Click(object sender, EventArgs e)
        {
            UrunlerListele(lvMenu, btnCorba);
        }
        #endregion

        int sayac = 0;
        private void lvMenu_DoubleClick(object sender, EventArgs e)
        {
            if (txtAdet.Text == "")
            {
                txtAdet.Text = "1";
            }
            if (lvMenu.Items.Count > 0)
            {
                sayac = lvSiparis.Items.Count;
                lvSiparis.Items.Add(lvMenu.SelectedItems[0].Text);
                lvSiparis.Items[sayac].SubItems.Add(txtAdet.Text);
                lvSiparis.Items[sayac].SubItems.Add((Convert.ToInt16(lvMenu.SelectedItems[0].SubItems[1].Text) * Convert.ToInt16(txtAdet.Text)).ToString());
                lvSiparis.Items[sayac].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
                lvSiparis.Items[sayac].SubItems.Add("0");
                lvSiparis.Items[sayac].SubItems.Add(sayac.ToString());

                txtAdet.Text = "";
            }
        }

        //txtAra ile Hızlı Arama
        public void HizliArama(ListView Cesitler, int txt)
        {
            Cesitler.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.constring);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Urunler WHERE ID=@ID", conn);
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = txt;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                Cesitler.Items.Add(dr["UrunAd"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["Fiyat"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;
            }
            dr.Close();
            conn.Dispose();
            conn.Close();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAra.Text == "")
                txtAra.Text = "";
            else
                HizliArama(lvMenu, Convert.ToInt32(txtAra.Text));
        }

        private void frmSiparis_Load(object sender, EventArgs e)
        {
            frmPaketServis frm = new frmPaketServis();
            if (frmPaketServis.tiklama1 == 1)
            {

                frmPaketServis.tiklama1 = 0;
            }
            else
            {
                lblMasaNo.Text = "";
                lblMasaNo.Text = cGenel.ButtonValue;
            }
            cMasalar ms = new cMasalar();
            cHesaplar hsp = new cHesaplar();
            cSiparisler orders = new cSiparisler();

            #region Hesap İşlemi
            btn1.Click += new EventHandler(islem);
            btn2.Click += new EventHandler(islem);
            btn3.Click += new EventHandler(islem);
            btn4.Click += new EventHandler(islem);
            btn5.Click += new EventHandler(islem);
            btn6.Click += new EventHandler(islem);
            btn7.Click += new EventHandler(islem);
            btn8.Click += new EventHandler(islem);
            btn9.Click += new EventHandler(islem);
            btn0.Click += new EventHandler(islem);
            #endregion
        }
        int no; int no1;
        private void btnOdeme_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(gnl.constring);
            SqlCommand cmd = new SqlCommand("Select Top 1 SiparisNo From Hesaplar Order By SiparisNo Desc", conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                no = Convert.ToInt16(dr["SiparisNo"]);
            } 
            ++no;

            frmPaketServis frm = new frmPaketServis();

            if (frmPaketServis.tiklama2 == 1)
            {
                cGenel.ButtonName = "Paket Servis";
                SqlConnection conn1 = new SqlConnection(gnl.constring);
                SqlCommand cmd1 = new SqlCommand("INSERT INTO PaketServisler (SiparisNo,AdSoyad,Telefon,Adres) values (@SiparisNo,@AdSoyad,@Telefon,@Adres)", conn1);
                if (conn1.State == ConnectionState.Closed)
                {
                    conn1.Open();
                }
                cmd1.Parameters.AddWithValue("@SiparisNo", no.ToString());
                cmd1.Parameters.AddWithValue("@AdSoyad", frmPaketServis.a.ToString());
                cmd1.Parameters.AddWithValue("@Telefon", frmPaketServis.b.ToString());
                cmd1.Parameters.AddWithValue("@Adres", frmPaketServis.c.ToString());
                cmd1.ExecuteNonQuery();
                if (conn1.State == ConnectionState.Closed)
                {
                    conn1.Open();
                }
                //frmPaketServis.tiklama2 = 0;
            }

            cMasalar ms = new cMasalar();
            if (frmPaketServis.tiklama2 == 0)
            {
                int TableId = ms.MasaNoGetir(cGenel.ButtonName);
                if (ms.MasaDurumGetir(TableId, 1) == true)
                {
                    ms.MasaDurumDegistirme(cGenel.ButtonName, 2);

                    if (lvSiparis.Items.Count > 0)
                    {
                        for (int i = 0; i < lvSiparis.Items.Count; i++)
                        {
                            SqlConnection conn2 = new SqlConnection(gnl.constring);
                            SqlCommand cmd2 = new SqlCommand("INSERT INTO Siparisler (SiparisNo,UrunID,Adet) values(@SiparisNo,@UrunID,@Adet)", conn2);
                            if (conn2.State == ConnectionState.Closed)
                            {
                                conn2.Open();
                            }
                            cmd2.Parameters.AddWithValue("@SiparisNo", no.ToString());
                            cmd2.Parameters.AddWithValue("@UrunID", Convert.ToInt16(lvSiparis.Items[i].SubItems[3].Text));
                            cmd2.Parameters.AddWithValue("@Adet", Convert.ToInt16(lvSiparis.Items[i].SubItems[1].Text));
                            cmd2.ExecuteNonQuery();
                            conn2.Close();
                        }
                    }
                }
            }

            // Siparişlerin Tutarını Hesaplama
            int toplam = 0;
            int[] topla = new int[lvSiparis.Items.Count];
            for (int i = 0; i < lvSiparis.Items.Count; i++)
            {
                topla[i] = Convert.ToInt16(lvSiparis.Items[i].SubItems[2].Text.ToString());
                toplam += topla[i];
            }
            lblTutar.Text = ("Toplam Tutar: " + Convert.ToString(toplam) + " TL");

            btnNakit.Visible = true;
            btnKart.Visible = true;
            lblTutar.Visible = true;
            a = lblTutar.Text;
        }

        public static string a;

        cHesaplar odeme = new cHesaplar();
        private void btnKart_Click(object sender, EventArgs e)
        {
            if (frmPaketServis.tiklama2 == 1)
            {
                cGenel.ButtonName = "Masa10";
                odeme.HesapAc(btnKart.Name);
            }
            else
                odeme.HesapAc(btnKart.Name);
        }

        private void btnNakit_Click(object sender, EventArgs e)
        {
            if (frmPaketServis.tiklama2 == 1)
            {
                cGenel.ButtonName = "Masa10";
                odeme.HesapAc(btnKart.Name);
            }
            else
                odeme.HesapAc(btnNakit.Name);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            txtAdet.Text = "";
            txtAra.Text = "";
            btnKart.Visible = false;
            btnNakit.Visible = false;
            lblTutar.Visible = false;      
            lvMenu.Items.Clear();
            lvSiparis.Items.Clear();
        }
        cMasalar ms = new cMasalar();
        private void btnMasaBosalt_Click(object sender, EventArgs e)
        {
            ms.MasaDurumDegistirme(cGenel.ButtonName, 1);
        }
    }
}
