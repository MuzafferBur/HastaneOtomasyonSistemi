﻿using System;
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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl=new SqlBaglantisi();
        private void LnkUyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit fr =new FrmHastaKayit();
            fr.Show();
        }

        private void BtnGirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Select * From Tbl_Hastalar Where HastaTC=@p1 and HastaSifre=@p2", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", MskTckn.Text);
            kmt.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            if(dr.Read())
            {
                FrmHastaDetay fr = new FrmHastaDetay();
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
