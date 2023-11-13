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
using System.Security.Cryptography;

namespace HastaneOtomasyonSistemi
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string tcno;
        SqlBaglantisi bgl =new SqlBaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tcno;

            //ad soyad
            SqlCommand kmt = new SqlCommand("Select SekreterAdSoyad from Tbl_sekreter Where SekreterTc=@p1",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", tcno);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                LblAdsoyad.Text = dr[0].ToString();
            }

            //Branslari Datagrid e aktarma
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BransAd From Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //doktorlari datagrid e aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar' ,DoktorBrans from Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //combox a branslari getirme
            SqlCommand kmt2 = new SqlCommand("select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = kmt2.ExecuteReader();   
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kmtguncelle = new SqlCommand("Insert into Tbl_Randevular (RandevuTarih, RandevuSaat,RandevuBrans, RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            kmtguncelle.Parameters.AddWithValue("@r1", MskTarih.Text);
            kmtguncelle.Parameters.AddWithValue("@r2", MskSaat.Text);
            kmtguncelle.Parameters.AddWithValue("@r3", CmbBrans.Text);
            kmtguncelle.Parameters.AddWithValue("@r4", CmbDoktor.Text);
            kmtguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Olusturuldu!");
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            CmbDoktor.Text= string.Empty;

            SqlCommand kmt3 = new SqlCommand("select DoktorAd, DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            kmt3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr3 = kmt3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0]+ " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand kmt4 = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)", bgl.baglanti());
            kmt4.Parameters.AddWithValue("@d1",RchDuyuru.Text);
            kmt4.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Olusturuldu!");
        }

        private void BtnDoktor_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli drp = new FrmDoktorPaneli();
            drp.Show();
        }

        //private void BtnGuncelle_Click(object sender, EventArgs e)
        //{
        //    SqlCommand kmtguncelle = new SqlCommand("update Tbl_Randevular set RandevuTarih=@p1, RandevuSaat=@p2,RandevuBrans=@p3, RandevuDoktor=@p4 where randevuid=@p5", bgl.baglanti());
        //    kmtguncelle.Parameters.AddWithValue("@p1", MskTarih.Text);
        //    kmtguncelle.Parameters.AddWithValue("@p2", MskSaat.Text);
        //    kmtguncelle.Parameters.AddWithValue("@p3", CmbBrans.Text);
        //    kmtguncelle.Parameters.AddWithValue("@p4", CmbDoktor.Text);
        //    kmtguncelle.Parameters.AddWithValue("@p5", TxtId.Text);
        //    kmtguncelle.ExecuteNonQuery();
        //    bgl.baglanti().Close();
        //    MessageBox.Show("Randevu Olusturuldu!");
        //}

        private void BtnBrans_Click(object sender, EventArgs e)
        {
            FrmBransPaneli fr = new FrmBransPaneli();
            fr.Show();
        }

        private void BtnRandevu_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi fr = new FrmRandevuListesi();
            fr.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }
    }
}
