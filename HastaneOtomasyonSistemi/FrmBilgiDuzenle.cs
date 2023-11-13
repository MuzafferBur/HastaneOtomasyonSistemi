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

namespace HastaneOtomasyonSistemi
{
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string TCno;
        SqlBaglantisi bgl= new SqlBaglantisi();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTckn.Text = TCno;
            SqlCommand kmt = new SqlCommand("select * from tbl_hastalar where hastatc=@p1",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", MskTckn.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                MskTel.Text = dr[4].ToString();
                TxtSifre.Text = dr[5].ToString();
                CmbCinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt2 = new SqlCommand("update tbl_hastalar set hastaad=@p1,hastasoyad=@p2,hastatel=@p3,hastasifre=@p4,hastacinsiyet=@p5 where hastatc=@p6", bgl.baglanti());
            kmt2.Parameters.AddWithValue("@p1", TxtAd.Text);
            kmt2.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            kmt2.Parameters.AddWithValue("@p3", MskTel.Text);
            kmt2.Parameters.AddWithValue("@p4", TxtSifre.Text);
            kmt2.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
            kmt2.Parameters.AddWithValue("@p6", MskTckn.Text);
            kmt2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydiniz Basariyla Guncellenmistir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
