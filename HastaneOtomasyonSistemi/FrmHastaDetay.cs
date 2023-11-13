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
using System.Data.Common;

namespace HastaneOtomasyonSistemi
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;
        
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            LblTc.Text = tc;
            //ad soyad cekme
            SqlCommand kmt = new SqlCommand("select hastaad, hastasoyad from tbl_hastalar where hastatc=@p1",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = kmt.ExecuteReader();
            while(dr.Read())
            {
                LblAdsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //randevu gecmisi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular Where HastaTC=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //branslari cekme
            SqlCommand kmt2 = new SqlCommand("Select BransAd From Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2 = kmt2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktorlar.Items.Clear();
            SqlCommand kmt3 = new SqlCommand("select doktorad, doktorsoyad from tbl_doktorlar where doktorbrans=@p1", bgl.baglanti());
            kmt3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr3 = kmt3.ExecuteReader();
            while(dr3.Read())
            {
                CmbDoktorlar.Items.Add(dr3[0]+" " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select  * from tbl_randevular where randevubrans='" + CmbBrans.Text + "'" + " and RandevuDoktor='" + CmbDoktorlar.Text + "' and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void LnkBilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr =new FrmBilgiDuzenle();
            fr.TCno = LblTc.Text;
            fr.Show();
        }

        private void BtnRandevual_Click(object sender, EventArgs e)
        {
            SqlCommand kmt4 = new SqlCommand("Update Tbl_Randevular set RandevuDurum=1, HastaTC=@p1, HastaSikayet=@p2 where RandevuId=@p3", bgl.baglanti());
            kmt4.Parameters.AddWithValue("@p1", LblTc.Text);
            kmt4.Parameters.AddWithValue("@p2", RchSikayet.Text);
            kmt4.Parameters.AddWithValue("@p3", TxtId.Text);
            kmt4.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevunuz Olusturuldu!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
