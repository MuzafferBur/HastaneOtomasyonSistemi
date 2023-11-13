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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();
        private void BtnGirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Select * from Tbl_sekreter where sekretertc=@p1 and sekretersifre=@p2", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", MskTckn.Text);
            kmt.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                FrmSekreterDetay frs = new FrmSekreterDetay();
                frs.tcno=MskTckn.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali Sifre & Tc");
            }
            bgl.baglanti().Close();
        }
    }
}
