using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneOtomasyonSistemi
{
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        public string tckn;
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTckn.Text = tckn;

            SqlCommand kmt = new SqlCommand("Select * from tbl_Doktorlar where doktortc=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", MskTckn.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                CmbBrans.Text = dr[3].ToString();
                TxtSifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt2 = new SqlCommand("update tbl_Doktorlar set doktorad=@p1, doktorsoyad=@p2, doktorbrans=@p3, doktorsifre=@p4 where doktortc=@p5", bgl.baglanti());
            kmt2.Parameters.AddWithValue("@p1", TxtAd.Text);
            kmt2.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            kmt2.Parameters.AddWithValue("@p3", CmbBrans.Text);
            kmt2.Parameters.AddWithValue("@p4", TxtSifre.Text);
            kmt2.Parameters.AddWithValue("@p5", MskTckn.Text);
            kmt2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Guncellendi!");

        }
    }
}
