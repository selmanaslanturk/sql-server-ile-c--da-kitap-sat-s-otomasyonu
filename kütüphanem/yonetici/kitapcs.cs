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
using Microsoft.VisualBasic;


namespace kütüphanem
{
    public partial class kitapcs : UserControl
    {
        public kitapcs()
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
            komut = new SqlCommand("select count(kitap_id) as sayi from kitap where kitap_adi LIKE'%" + tbkitapadi.Text + "%'", baglanti);
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                kont = Convert.ToInt32(dr["sayi"].ToString());
            }
        }
        private void goster_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (DataGridViewRow drow in goster.SelectedRows)  //Seçili Satırları Silme
            {
                if ("" != drow.Cells[0].Value.ToString())
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        menu.Show(goster, new Point(e.X, e.Y));
                    }
                }
            }
        }

        void listele()
        {
           
            komut = new SqlCommand("select kit.kitap_id,kit.kitap_adi, yaz.yazar_adi,ka.kategori_adi,yay.yayinevi_adi ,kit.sayfasayisi,kit.basimyili ,s.adet, kit.fiyat from kitap as kit,kategori as ka,yazar as yaz ,yayinevi as yay ,stok as s where kit.kategori_id=ka.kategori_id  and  kit.yazar_id=yaz.yazar_id  and kit.yayinevi_id=yay.yayinevi_id and kit.kitap_id=s.kitap_id ", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            goster.DataSource = dt;
          
            baglanti.Close();
        }
        void ara()
        {
            baglanti.Close();
            baglanti.Open();
            komut = new SqlCommand("select kit.kitap_id,kit.kitap_adi, yaz.yazar_adi,ka.kategori_adi,yay.yayinevi_adi ,sayfasayisi,kit.basimyili ,s.adet, kit.fiyat from kitap as kit,kategori as ka,yazar as yaz ,yayinevi as yay ,stok as s where kit.kategori_id=ka.kategori_id  and  kit.yazar_id=yaz.yazar_id  and kit.yayinevi_id=yay.yayinevi_id and kit.kitap_id=s.kitap_id and kit.kitap_adi  LIKE'%" + tbkitapadi.Text + "%' ORDER BY(kategori_adi)", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            goster.DataSource = dt;
           
        }

        public void fonkategori()
        {
            da = new SqlDataAdapter("Select * from kategori order by kategori_adi", baglanti);
            dt = new DataTable();
            da.Fill(dt);

            cbkategori.DisplayMember = "kategori_adi"; // Combobox ta görünecek olan hücre
            cbkategori.ValueMember = "kategori_id"; // Arka Planda tutulacak olan hücre
            cbkategori.DataSource = dt;
        }

        public void fonkyazar()
        {
            da = new SqlDataAdapter("Select * from yazar order by yazar_adi", baglanti);
            dt = new DataTable();
            da.Fill(dt);

            cbyazar.DisplayMember = "yazar_adi"; // Combobox ta görünecek olan hücre
            cbyazar.ValueMember = "yazar_id"; // Arka Planda tutulacak olan hücre
            cbyazar.DataSource = dt;
        }
        public void fonkyayinevi()
        {
            da = new SqlDataAdapter("Select * from yayinevi order by yayinevi_adi", baglanti);
            dt = new DataTable();
            da.Fill(dt);

            cbyayinevi.DisplayMember = "yayinevi_adi"; // Combobox ta görünecek olan hücre
            cbyayinevi.ValueMember = "yayinevi_id"; // Arka Planda tutulacak olan hücre
            cbyayinevi.DataSource = dt;
        }


        private void kitapcs_Load(object sender, EventArgs e)
        {
            listele();
            fonkategori();
            fonkyayinevi();
            fonkyazar();
        }

        private void btnkategori_Click(object sender, EventArgs e)
        {
            kategori fm = new kategori();
            fm.Show();
        }

        private void cbkategori_Click(object sender, EventArgs e)
        {
            fonkategori();
        }

        private void btnyazar_Click(object sender, EventArgs e)
        {
            yazar
                fm = new yazar();
            fm.Show();
        }

        private void cbyazar_Click(object sender, EventArgs e)
        {
            fonkyazar();
        }

        private void cbyayinevi_Click(object sender, EventArgs e)
        {
            fonkyayinevi();

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            yayinevi fm = new yayinevi();
            fm.Show();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {

            try
            {
                kontrol();
                if (kont == 0)
                {
                    int id = 0;
                    baglanti.Close();
                    baglanti.Open();
                    komut = new SqlCommand("insert into  kitap(kitap_adi,yazar_id,yayinevi_id,kategori_id,sayfasayisi,basimyili,fiyat) values ('" + tbkitapadi.Text + "'," + cbyazar.SelectedValue + "," + cbyayinevi.SelectedValue + "," + cbkategori.SelectedValue + "," + numsayfa.Value + "," + numbasim.Value + "," + numfiyat.Value + ")", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    komut = new SqlCommand("select kitap_id from kitap where kitap_adi LIKE'%" + tbkitapadi.Text + "%'", baglanti);
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        id = Convert.ToInt32(dr["kitap_id"].ToString());
                    }
                    baglanti.Close();
                    baglanti.Open();
                    komut = new SqlCommand("insert into  stok(kitap_id,adet) values (" + id + "," + numadet.Value + ")", baglanti);
                    komut.ExecuteNonQuery();
                    listele();
                   
                }
                else
                    MessageBox.Show("kayt var");
            }
            catch
            {

            }
        }

        private void tbkitapadi_TextChanged(object sender, EventArgs e)
        {
            ara();
        }

        private void Kitapekle_Click(object sender, EventArgs e)
        {
            try {
                kid.Text = goster.SelectedCells[0].Value.ToString();
                numfiyat.Value = Convert.ToInt32(goster.SelectedCells[8].Value.ToString());
                cbyazar.Text = goster.SelectedCells[2].Value.ToString();
                cbkategori.Text = goster.SelectedCells[3].Value.ToString();
                cbyayinevi.Text = goster.SelectedCells[4].Value.ToString();
                numsayfa.Value = Convert.ToInt32(goster.SelectedCells[5].Value.ToString());
                numbasim.Value = Convert.ToInt32(goster.SelectedCells[6].Value.ToString());
                numadet.Value = Convert.ToInt32(goster.SelectedCells[7].Value.ToString());
                tbkitapadi.Text = goster.SelectedCells[1].Value.ToString();
                int adet = Convert.ToInt32(Interaction.InputBox("Adet Sayisini girin ").ToString());
                SqlCommand komut = new SqlCommand("update stok set adet=@adet where kitap_id=@id", baglanti);
                komut.Parameters.AddWithValue("@id", Convert.ToInt32(kid.Text));
                komut.Parameters.AddWithValue("@adet", numadet.Value + adet);
                baglanti.Close();
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
            }
            catch { }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void goster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}

