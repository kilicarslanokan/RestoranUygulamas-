using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranUygulaması
{
    internal class cMasalar
    {
        #region Fields
        private int MasaNo;
        private int Durum;
        #endregion
        #region Properties
        public int MasaNo1 { get => MasaNo; set => MasaNo = value; }
        public int Durum1 { get => Durum; set => Durum = value; }
        #endregion
        cGenel gnl = new cGenel();
        // Masa Nosu Getirme
        public int MasaNoGetir(string TableValue)
        {
            if (cGenel.ButtonName.Length <= 8)
            {
                string aa = TableValue;
                int uzunluk = aa.Length;
                return Convert.ToInt16(aa.Substring(uzunluk - 1, 1));
            }
            else
            {
                string aa = TableValue;
                int uzunluk = aa.Length;
                return Convert.ToInt16(aa.Substring(uzunluk - 2, 2));

            }

        }
        // Masa Durumu Getirme
        public bool MasaDurumGetir(int ButtonName, int state)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(gnl.constring);
            SqlCommand cmd = new SqlCommand("SELECT Durum FROM Masalar WHERE MasaNo=@TableId and Durum=@state", conn);

            cmd.Parameters.AddWithValue("@TableId", ButtonName);
            cmd.Parameters.AddWithValue("@state", state);

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                //throw;
            }
            finally { conn.Dispose(); conn.Close(); }
            return result;
        }
        // Masa Durum Değiştirme
        public void MasaDurumDegistirme(string ButtonName, int state)
        {
            frmRezervasyon frm = new frmRezervasyon();
            if (frmRezervasyon.tiklandi1 == 0)
            {

                SqlConnection conn = new SqlConnection(gnl.constring);
                SqlCommand cmd = new SqlCommand("UPDATE Masalar SET Durum=@Durum WHERE MasaNo=@MasaNo", conn);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                if (cGenel.ButtonName.Length<=8)
                {
                    string aa = ButtonName;
                    int uzunluk = aa.Length;

                    cmd.Parameters.AddWithValue("@Durum", state);
                    cmd.Parameters.AddWithValue("@MasaNo", aa.Substring(uzunluk - 1, 1));
                    cmd.ExecuteNonQuery();
                    conn.Dispose();
                    conn.Close();
                }
                else
                {
                    string aa = ButtonName;
                    int uzunluk = aa.Length;

                    cmd.Parameters.AddWithValue("@Durum", state);
                    cmd.Parameters.AddWithValue("@MasaNo", aa.Substring(uzunluk - 2, 2));
                    cmd.ExecuteNonQuery();
                    conn.Dispose();
                    conn.Close();
                }
            }
            else
            {
                frmRezervasyon rez = new frmRezervasyon();

                SqlConnection conn = new SqlConnection(gnl.constring);
                SqlCommand cmd = new SqlCommand("UPDATE Masalar SET Durum=@Durum WHERE MasaNo=@MasaNo", conn);

                
                
                frmRezervasyon.tiklandi = 0;

                string aa = ButtonName;
                int uzunluk = aa.Length;

                cmd.Parameters.AddWithValue("@Durum", state);
                cmd.Parameters.AddWithValue("@MasaNo", cGenel.ButtonName.Substring(uzunluk - 2, 2));
                rez.cmbMasaNo.Text = cGenel.ButtonName;
                cmd.ExecuteNonQuery();
                conn.Dispose();
                conn.Close();
            }
        }
    }
}
