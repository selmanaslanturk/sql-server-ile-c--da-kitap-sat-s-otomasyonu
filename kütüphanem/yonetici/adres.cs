using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kütüphanem
{
    public partial class adres : UserControl
    {
        public adres()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=ktp_vrtb;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        DataTable dt;
        int kont;
        void kontrol()
        {
            kont = -1;
            baglanti.Close();
            komut = new SqlCommand("select count(i.ilce_id) as sayi from sehir as s,ilce as i where s.sehir_id=i.sehir_id and  i.ilce_adi ='"+tbilce.Text+"'", baglanti);
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                kont = Convert.ToInt32(dr["sayi"].ToString());
            }
        }
        private void sehir_Click(object sender, EventArgs e)
        {
            sehircs fm = new sehircs();
            fm.Show();
           
        }
     public void combo()
        {
            da= new SqlDataAdapter("Select * from sehir order by sehir_adi", baglanti);
            dt = new DataTable();
            da.Fill(dt);

            comboBox1.DisplayMember = "sehir_adi"; // Combobox ta görünecek olan hücre
            comboBox1.ValueMember = "sehir_id"; // Arka Planda tutulacak olan hücre
            comboBox1.DataSource = dt;
        }
        void listele()
        {
            komut = new SqlCommand("select ilce.ilce_id,sehir.sehir_adi,ilce.ilce_adi from sehir ,ilce  where sehir.sehir_id=ilce.sehir_id ", baglanti);
            da = new SqlDataAdapter(komut);
            dt= new DataTable();
            da.Fill(dt);
            goster.DataSource = dt;
            goster.Columns[0].HeaderText = "İD";
            goster.Columns[0].Width = 50;
            goster.Columns[1].HeaderText = "ŞEHİR";
            goster.Columns[1].Width = 150;
            goster.Columns[2].HeaderText = "İLÇE";
            goster.Columns[2].Width = 150;
            baglanti.Close();
        }

        private void adres_Load(object sender, EventArgs e)
        {
            listele();
            combo();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            listele();
            combo();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            kontrol();
            if (kont == 0)
            {
                baglanti.Close();
                baglanti.Open();
                komut = new SqlCommand("insert into  ilce(ilce_adi,sehir_id) values ('" + tbilce.Text + "'," + comboBox1.SelectedValue + ")", baglanti);
                komut.ExecuteNonQuery();
                listele();
            }
            else
                MessageBox.Show("kayt var");
        }
    }
}
