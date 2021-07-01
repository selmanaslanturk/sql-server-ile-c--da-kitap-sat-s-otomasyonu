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
    public partial class admin : UserControl
    {
        public admin()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=ktp_vrtb;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        DataTable dt;
        int kont;
        string cins;
        void kontrol()
        {
            kont = -1;
            baglanti.Close();
            komut = new SqlCommand("select count(admin_id) as sayi from admin where kullaniciadi='"+tbadmin.Text+"'", baglanti);
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                kont = Convert.ToInt32(dr["sayi"].ToString());
            }
        }

         void combo()
        {
            da = new SqlDataAdapter("Select * from sehir order by sehir_adi", baglanti);
            dt = new DataTable();
            da.Fill(dt);

            cbsehir.DisplayMember = "sehir_adi"; // Combobox ta görünecek olan hücre
            cbsehir.ValueMember = "sehir_id"; // Arka Planda tutulacak olan hücre
            cbsehir.DataSource = dt;
        }
        void ilce()
        {
            da = new SqlDataAdapter("Select * from ilce where sehir_id="+cbsehir.SelectedValue, baglanti);
            dt = new DataTable();
            da.Fill(dt);

            cbilce.ValueMember = "ilce_id"; // Combobox ta görünecek olan hücre
            cbilce.DisplayMember = "ilce_adi"; // Arka Planda tutulacak olan hücre
            cbilce.DataSource = dt;
        }
        void listele()
        {
            komut = new SqlCommand("select * from admin,ilce,sehir where admin.sehir=ilce.ilce_id and ilce.sehir_id=sehir.sehir_id ", baglanti);
            da = new SqlDataAdapter(komut);
            dt = new DataTable();
            da.Fill(dt);
            goster.DataSource = dt;
            goster.Columns[0].HeaderText = "İD";
            goster.Columns[0].Width = 20;
            
            baglanti.Close();
        }
        void cinsiyet()
        {
            cins = "";
            if (bay.Checked == true)
                cins = bay.Text;
            else
                cins = bayan.Text;
        }
        private void admin_Load(object sender, EventArgs e)
        {
            listele();
            combo();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            kontrol();
            if (kont == 0)
            {
                int yet ;

                if (yetki.Checked == true)
                    yet = 1;
                else
                yet = 0;

                cinsiyet();
                baglanti.Close();
                baglanti.Open();
                komut = new SqlCommand("insert into  admin(adi,soyadi,kullaniciadi,sifre,cinsiyeti,adres,telefon,eposta,sehir,yetki) values ('" + tbadi.Text + "','" + tbsoyadi.Text + "','" + tbadmin.Text + "','" + tbsifre.Text + "','" + cins + "','" + tbadres.Text + "','" + tbtelefon.Text + "','" + tbeposta.Text + "'," + cbilce.SelectedValue + ","+yet+")", baglanti);
                komut.ExecuteNonQuery();
                listele();
            }
            else
                MessageBox.Show("kayıt var");
        }

        private void textBox1adres_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbsehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilce();
        }

        private void goster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbadi_OnValueChanged(object sender, EventArgs e)
        {
            tbadi.Text = "";
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
