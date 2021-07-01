using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphanem
{
    public partial class satislistele : Form
    {
        public satislistele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=ktp_vrtb;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        DataTable dt;
        private void Form2_Load(object sender, EventArgs e)
        {
            listele();
            }
        void listele()
        {
            // and kit.kitap_id=s.kitap_id  and  kit.yazar_id=yaz.yazar_id and kit.yayinevi_id=yay.yayinevi_id
            komut = new SqlCommand("select satis_id,tarihsaat,t_fiyat from satis ", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            goster.DataSource = dt;
            //goster.Columns[0].HeaderText = "İD";
            //goster.Columns[0].Width = 50;
            //goster.Columns[1].HeaderText = "KATEGORİ";
            //goster.Columns[1].Width = 127;
            baglanti.Close();

        }

        private void bunifuTileButton13_Click(object sender, EventArgs e)
        {
            p_anasayfa fr = new p_anasayfa();
            fr.Show();
            this.Hide();
        }

        private void goster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
