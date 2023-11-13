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
using System.Security.Cryptography.X509Certificates;

namespace HastaneOtomasyonSistemi
{
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        public string tc;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;

            //ad soyad
            SqlCommand kmt2 = new SqlCommand("select doktorad, doktorsoyad from tbl_doktorlar where doktortc=@p1",bgl.baglanti());
            kmt2.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr2 = kmt2.ExecuteReader();
            while (dr2.Read())
            {
               LblAdsoyad.Text = dr2[0]+ " " + dr2[1];
            }
            bgl.baglanti().Close();

            //rndevular 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_Randevular Where randevudoktor='"+LblAdsoyad.Text+"'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt; 
        }

        private void BtnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle frb = new FrmDoktorBilgiDuzenle();
            frb.tckn = LblTC.Text;
            frb.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frd = new FrmDuyurular();
            frd.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
