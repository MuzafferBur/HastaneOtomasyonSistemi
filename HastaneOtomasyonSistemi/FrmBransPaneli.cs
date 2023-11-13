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
    public partial class FrmBransPaneli : Form
    {
        public FrmBransPaneli()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmBransPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select  * from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert into tbl_Branslar (BransAd) values (@p1)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", TxtBransAd.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni Brans Dali Eklenmistir!", "Bilgilendime", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtBransAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand kmt2 = new SqlCommand("delete from tbl_Branslar where Bransid=@b1",bgl.baglanti());
            kmt2.Parameters.AddWithValue("@b1", TxtId.Text);
            kmt2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Brans Kaydi Silinmistir!", "Uyari!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt3 = new SqlCommand("update tbl_branslar set bransad=@p1 where bransid=@p2", bgl.baglanti());
            kmt3.Parameters.AddWithValue("@p2", TxtId.Text);
            kmt3.Parameters.AddWithValue("@p1", TxtBransAd.Text);
            kmt3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayit Guncellendi!", "Bilgilendime", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
