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
    internal class cSiparisler
    {
        #region Fields
        private int SiparisNo;
        private int UrunID;
        private int Adet;
        #endregion
        #region Properties
        public int SiparisNo1 { get => SiparisNo; set => SiparisNo = value; }
        public int UrunID1 { get => UrunID; set => UrunID = value; }
        public int Adet1 { get => Adet; set => Adet = value; }
        #endregion

        cGenel gnl=new cGenel();
        // Siparişleri Getirir
        //public void SiparisGetir(ListView lv, int SiparisNo)
        //{
        //    SqlConnection conn = new SqlConnection(gnl.constring);
        //    SqlCommand cmd = new SqlCommand("SELECT SiparisNo,UrunID,Adet FROM Siparisler INNER JOIN Urunler ON Siparisler.UrunID=Urunler.ID WHERE SiparisNo=@SiparisNo", conn);
        //    SqlDataReader dr = null;
        //    cmd.Parameters.Add("SiparisNo", SqlDbType.Int).Value = SiparisNo;
        //    try
        //    {
        //        if (conn.State == ConnectionState.Closed)
        //        {
        //            conn.Open();
        //        }
        //        dr = cmd.ExecuteReader();
        //        int i = 0;
        //        while (dr.Read())
        //        {
        //            lv.Items.Add(dr["UrunAd"].ToString());
        //            lv.Items[i].SubItems.Add(dr["Adet"].ToString());
        //            lv.Items[i].SubItems.Add((Convert.ToString(Convert.ToInt16(dr["Fiyat"]) * Convert.ToInt16(dr["Adet"])).ToString()));
        //            lv.Items[i].SubItems.Add(dr["UrunID"].ToString());
        //            i++;
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        string hata = ex.Message;
        //        throw; 
        //    }
        //    finally { dr.Dispose(); conn.Dispose(); conn.Close(); }
        //}

        // Sipariş Numarasını Getirir
        //public int SiparisNoGetir(int MasaNo)
        //{
        //    SqlConnection conn = new SqlConnection(gnl.constring);
        //    SqlCommand cmd = new SqlCommand("SELECT TOP 1 SiparisNo FROM Siparisler WHERE MasaNo=@MasaNo ORDER BY MasaNo DESC", conn);

        //    cmd.Parameters.Add("@MasaNo", SqlDbType.Int).Value = MasaNo;

        //    try
        //    {
        //        if (conn.State == ConnectionState.Closed)
        //        {
        //            conn.Open();
        //        }
        //        MasaNo = Convert.ToInt16(cmd.ExecuteScalar());
        //    }
        //    catch (SqlException ex)
        //    {
        //        string hata = ex.Message;
        //        //throw;
        //    }
        //    finally { conn.Close(); }
        //    return MasaNo;
        //}

        // Siparişleri Kaydeder
        //public bool SiparisleriKaydet(cSiparisler Bilgiler)
        //{
        //    cHesaplar hsp = new cHesaplar();
        //    bool sonuc = false;
        //    SqlConnection conn = new SqlConnection(gnl.constring);
        //    SqlCommand cmd = new SqlCommand("INSERT INTO Hesaplar(SiparisNo,MasaNo,Odeme,Tutar,Tarih) values(@SiparisNo,@MasaNo,@Odeme,@Tutar,@Tarih)", conn);

        //    try
        //    {
        //        if (conn.State == ConnectionState.Closed)
        //        {
        //            conn.Open();
        //        }
        //        cmd.Parameters.AddWithValue("@SiparisNo", hsp.SiparisNo);
        //        cmd.Parameters.AddWithValue("@MasaNo", hsp.MasaNo);
        //        cmd.Parameters.AddWithValue("@Odeme", hsp.Odeme);
        //        cmd.Parameters.AddWithValue("@Tutar", hsp.Tutar);
        //        cmd.Parameters.AddWithValue("@Tarih",hsp.Tarih);
        //        sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
        //    }
        //    catch (SqlException ex)
        //    {
        //        string hata = ex.Message;
        //        //throw;
        //    }
        //    finally { conn.Dispose(); conn.Close(); }
        //    return sonuc;
        //}
        
    }
}
