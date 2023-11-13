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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl =new SqlBaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Doktorlar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //combox a branslari getirme
            SqlCommand kmt4 = new SqlCommand("select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = kmt4.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt =new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@p1,@p2,@p3,@p4,@p5)",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", TxtAd.Text);
            kmt.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            kmt.Parameters.AddWithValue("@p3", CmbBrans.Text);
            kmt.Parameters.AddWithValue("@p4", MskTC.Text);
            kmt.Parameters.AddWithValue("@p5", TxtSifre.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //buraya bidaha bakarsin tam olmadi gibi
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand kmt2 = new SqlCommand("delete from tbl_doktorlar where doktortc=@p1",bgl.baglanti());    
            kmt2.Parameters.AddWithValue("@p1",MskTC.Text);
            kmt2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayit Silindi!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt3 = new SqlCommand("update tbl_doktorlar set doktorsifre=@d1 where doktortc=@d2", bgl.baglanti());
            kmt3.Parameters.AddWithValue("@d1", TxtSifre.Text);
            kmt3.Parameters.AddWithValue("@d2", MskTC.Text);
            kmt3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Degisiklikler Basariyla Kaydedildi!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
