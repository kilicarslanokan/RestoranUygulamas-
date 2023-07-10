using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System.Windows.Forms;

namespace RestoranUygulaması
{
    public class cHesaplar
    {
        #region Fields
        private int HesapNo;
        private int siparisNo;
        private int masaNo;
        private string odeme;
        private int tutar;
        private int tarih;
        #endregion

        #region Properties
        public int HesapNo1 { get => HesapNo; set => HesapNo = value; }
        public int SiparisNo { get => siparisNo; set => siparisNo = value; }
        public int MasaNo { get => masaNo; set => masaNo = value; }
        public string Odeme { get => odeme; set => odeme = value; }
        public int Tutar { get => tutar; set => tutar = value; }
        public int Tarih { get => tarih; set => tarih = value; }
        #endregion

        cGenel gnl = new cGenel();
        int no,no1;
        public void HesapAc(string ButtonName)
        {
           
            if (frmPaketServis.tiklama3 == 0)
            {
                cMasalar ms = new cMasalar();
                int TableId = ms.MasaNoGetir(cGenel.ButtonName);

                frmSiparis frmSiparis = new frmSiparis();
                string a = frmSiparis.a;
                MessageBox.Show(a);
                SqlConnection conn2 = new SqlConnection(gnl.constring);
                SqlCommand cmd2 = new SqlCommand("Select SiparisNo From Siparisler", conn2);
                if (conn2.State == ConnectionState.Closed)
                {
                    conn2.Open();
                }
                SqlDataReader dr = cmd2.ExecuteReader();
                while (dr.Read())
                {
                    no = Convert.ToInt16(dr["SiparisNo"]);
                }

                SqlConnection conn = new SqlConnection(gnl.constring);
                SqlCommand cmd = new SqlCommand("INSERT INTO Hesaplar(SiparisNo,MasaNo,Odeme,Tutar) values (@SiparisNo,@MasaNo,@OdemeTuru,@Tutar)", conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd.Parameters.AddWithValue("@MasaNo", TableId.ToString());
                int k = frmSiparis.a.Length;
                cmd.Parameters.AddWithValue("@Tutar", frmSiparis.a.Substring(14, k - 17));
                cmd.Parameters.AddWithValue("@SiparisNo", no.ToString());
                string aa = ButtonName;
                int uzunluk = aa.Length;
                cmd.Parameters.AddWithValue("@OdemeTuru", aa.Substring(3, uzunluk - 3));
                cmd.ExecuteNonQuery();
                conn.Dispose();
                conn.Close();
            }


            else
            {
                cMasalar ms = new cMasalar();
                int TableId = ms.MasaNoGetir(cGenel.ButtonName);

                frmSiparis frmSiparis = new frmSiparis();
                string a = frmSiparis.a;
                MessageBox.Show(a);
                SqlConnection conn2 = new SqlConnection(gnl.constring);
                SqlCommand cmd2 = new SqlCommand("Select SiparisNo From PaketServisler", conn2);
                if (conn2.State == ConnectionState.Closed)
                {
                    conn2.Open();
                }
                SqlDataReader dr = cmd2.ExecuteReader();
                while (dr.Read())
                {
                    no = Convert.ToInt16(dr["SiparisNo"]);
                }

                SqlConnection conn = new SqlConnection(gnl.constring);
                SqlCommand cmd = new SqlCommand("INSERT INTO Hesaplar(SiparisNo,MasaNo,Odeme,Tutar) values (@SiparisNo,@MasaNo,@OdemeTuru,@Tutar)", conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd.Parameters.AddWithValue("@MasaNo","Paket Servis");  
                int k = frmSiparis.a.Length;
                cmd.Parameters.AddWithValue("@Tutar", frmSiparis.a.Substring(14, k - 17));
                cmd.Parameters.AddWithValue("@SiparisNo", no.ToString());
                string aa = ButtonName;
                int uzunluk = aa.Length;
                cmd.Parameters.AddWithValue("@OdemeTuru", aa.Substring(3, uzunluk - 3));
                cmd.ExecuteNonQuery();
                conn.Dispose();
                conn.Close();
               
            }
        }
        /*public bool HesapAç(Button buttonName)
        {
            frmSiparis frm = new frmSiparis();
            bool sonuc=false;
            SqlConnection conn=new SqlConnection(gnl.constring);
            SqlCommand cmd = new SqlCommand("INSERT INTO Hesaplar(SiparisNo,MasaNo,Odeme,Tutar) values(@SiparisNo,@MasaNo,@Odeme,@Tutar)", conn);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd.Parameters.AddWithValue("@SiparisNo", frm.lvSiparis.Items[0].SubItems[4].Text);
                cmd.Parameters.AddWithValue("@MasaNo", frm.lblMasaNo);
                cmd.Parameters.AddWithValue("@Odeme", buttonName);

                string aa = frm.lblTutar.Text; int uzunluk = aa.Length;
                cmd.Parameters.AddWithValue("@Tutar", frm.lblTutar.Text.Substring(13,uzunluk-17));
                sonuc=Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally { conn.Close(); }
            return sonuc;
        }*/

    }
}
