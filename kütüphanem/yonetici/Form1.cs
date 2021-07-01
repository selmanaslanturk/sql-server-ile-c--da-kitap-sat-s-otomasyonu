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

namespace kütüphanem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=ktp_vrtb;Integrated Security=True");
        SqlCommand komut;
        int kont,yetkilendirme;
        void kontrol()
        {
            kont = -1;
            baglanti.Close();
            komut = new SqlCommand("Select count(admin_id) as sayi From  admin", baglanti);
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
               kont = Convert.ToInt32(dr["sayi"].ToString());
            }
        }
        void yetki()
        {
            yetkilendirme = -1;
            baglanti.Close();
            komut = new SqlCommand("Select yetki From  admin where kullaniciadi=@1 and sifre=@2 ", baglanti);
            komut.Parameters.AddWithValue("@1", tbadmin.Text);
            komut.Parameters.AddWithValue("@2", tbsifre.Text);
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                yetkilendirme= Convert.ToInt32(dr["yetki"].ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            kontrol();
     
           
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbadmin_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            Anasayfacs frm = new Anasayfacs();
            kontrol();
            if (kont == 0)
            {
                string admin = "admin", sifre = "123";

                if (tbadmin.Text == admin && sifre == tbsifre.Text)
                {
                    frm.Show();
                    this.Hide();
                }
                else MessageBox.Show(" Yeni kulanıcı giriş Admin = { 'admin' sifresi '123'} ");
            }
            else 
            {
                yetki();
                baglanti.Close();
                baglanti.Open();
                
                komut = new SqlCommand("Select *From admin where kullaniciadi=@1 and sifre=@2", baglanti);
                komut.Parameters.AddWithValue("@1", tbadmin.Text);
                komut.Parameters.AddWithValue("@2", tbsifre.Text);

                SqlDataReader dr1 = komut.ExecuteReader();
                while (dr1.Read())
                {
                    if(yetkilendirme==1)
                    {
                        
                        frm.Show();
                        this.Hide();
                        kont = -1;
                    }
                    else
                    {
                       
                        p_anasayfa fr= new p_anasayfa();
                        fr.Show();
                        this.Hide();
                        kont = -1;
                    }        
                }
                if (kont != -1)
                    MessageBox.Show(" Yanliş şifre ");
            }
            baglanti.Close();

        }
    }
}
