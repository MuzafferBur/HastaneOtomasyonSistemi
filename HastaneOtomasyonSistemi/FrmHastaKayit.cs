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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl =new SqlBaglantisi();
        private void BtnKayitol_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert into Tbl_Hastalar(HastaAd,HastaSoyad,HastaTC,HastaTel,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", TxtAd.Text);
            kmt.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            kmt.Parameters.AddWithValue("@p3", MskTckn.Text);
            kmt.Parameters.AddWithValue("@p4", MskTel.Text);
            kmt.Parameters.AddWithValue("@p5", TxtSifre.Text);
            kmt.Parameters.AddWithValue("@p6", CmbCinsiyet.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydiniz Gerceklesmistir Sifreniz: " + TxtSifre.Text, "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
