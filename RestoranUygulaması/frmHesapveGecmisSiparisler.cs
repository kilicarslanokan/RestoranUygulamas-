using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranUygulaması
{
    public partial class frmHesapveGecmisSiparisler : Form
    {
        cGenel gnl=new cGenel();
        public frmHesapveGecmisSiparisler()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            SqlConnection baglanti = new SqlConnection(gnl.constring);
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * From Hesaplar", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        } 

        private void frmHesapveGecmisSiparisler_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                frmMenu frm=new frmMenu();
                this.Close();  frm.Show();
            }
        }

        private void frmHesapveGecmisSiparisler_Load(object sender, EventArgs e)
        {
            Listele();
            SqlConnection conn = new SqlConnection(gnl.constring);
            conn.Open();
            SqlCommand komut = new SqlCommand("SELECT SUM(Tutar) FROM Hesaplar", conn);
            int toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            lblCiro.Text = toplam.ToString();



            conn.Close();
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

        private void lblCiroGoster_Click(object sender, EventArgs e)
        {
            lblCiro.Visible = true;
        }
    }
}
