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

namespace SecimIstatistik
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        /*
         * GOOGLE DA IYI ARASTIR (HER TURDEN KELIMEYLE)
         * ILK CHATGPTDEN SENIOR .NET DEVELOPER OLMASINI ISTE
         * SONRA ATTIGIN KODU DAHA IYI HALE GETIRMESINI VE SANA KODU ANLATSIN
         */

        private SqlConnection baglanti = new SqlConnection(@"Data Source=MERYEM\SQLEXPRESS;Initial Catalog=DBSECİMPROJE;Integrated Security=True");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLILCE(ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI)VALUES(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtIlceAd.Text);
            komut.Parameters.AddWithValue("@p2", txtA.Text);
            komut.Parameters.AddWithValue("@p3", txtB.Text);
            komut.Parameters.AddWithValue("@p4", txtC.Text);
            komut.Parameters.AddWithValue("@p5", txtD.Text);
            komut.Parameters.AddWithValue("@p6", txtE.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Gerçekleşti");

        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
         

        }

        public int sayiKarsilastir(int sayi) => sayi > 10 ? sayi : 10;

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler(); 
            fr.Show();
        }
    }
}
