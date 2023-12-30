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


namespace SecimIstatistik
{


    public partial class FrmGrafikler : Form
    {

        public FrmGrafikler()
        {
            InitializeComponent();
        }
        private SqlConnection baglanti = new SqlConnection(@"Data Source=MERYEM\SQLEXPRESS;Initial Catalog=DBSECİMPROJE;Integrated Security=True");

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
           //ilçe adlarını combobaxa çekme
           baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT ILCEAD from TBLILCE",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                cmbIlce.Items.Add(dr[0]);
            }
            baglanti.Close();

            //grafiğe toplam sonuçları getirme
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select SUM(APARTI),SUM(BPARTI),SUM(CPARTI),SUM(DPARTI),SUM(EPARTI) FROM TBLILCE", baglanti);
            SqlDataReader dr2=komut2.ExecuteReader();
            while(dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A PARTİ", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B PARTİ", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C PARTİ", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D PARTİ", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E PARTİ", dr2[4]);

            }
            baglanti.Close();

        }

        private void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT *FROM TBLILCE where ILCEAD=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbIlce.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());

                lblA.Text = dr[2].ToString();
                lblB.Text = dr[3].ToString();
                lblC.Text = dr[4].ToString();
                lblD.Text = dr[5].ToString();
                lblE.Text = dr[6].ToString();

            }
        }
    }
}
