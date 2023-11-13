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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void BtnGirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("select * from Tbl_doktorlar where doktortc=@p1 and doktorsifre=@p2",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", MskTckn.Text);
            kmt.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay fr = new FrmDoktorDetay();
                fr.tc=MskTckn.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali Giris!");
            }
            bgl.baglanti().Close(); 

        }
    }
}
