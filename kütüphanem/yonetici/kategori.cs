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
    public partial class kategori : Form
    {
        public kategori()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=ktp_vrtb;Integrated Security=True");
        SqlCommand komut;
        int kont;
        void kontrol()
        {
            kont = -1;
            baglanti.Close();
            komut = new SqlCommand("select count(kategori_id) as sayi from kategori where kategori_adi LIKE'%" + tbkategori.Text + "%'", baglanti);
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                kont = Convert.ToInt32(dr["sayi"].ToString());
            }
        }
        void listele()
        {
            komut = new SqlCommand("select *from kategori ORDER BY(kategori_adi) ", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            goster.DataSource = dt;
            goster.Columns[0].HeaderText = "İD";
            goster.Columns[0].Width = 50;
            goster.Columns[1].HeaderText = "KATEGORİ";
            goster.Columns[1].Width = 127;
            baglanti.Close();
        }
        void ara()
        {
            baglanti.Close();
            komut = new SqlCommand("select *from kategori where kategori_adi LIKE'%" + tbkategori.Text + "%' ORDER BY(kategori_adi)", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            goster.DataSource = dt;
            goster.Columns[0].HeaderText = "İD";
            goster.Columns[0].Width = 50;
            goster.Columns[1].HeaderText = "KATEGORİ";
            goster.Columns[1].Width = 127;
            baglanti.Close();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            kontrol();
            if (kont == 0)
            {
                baglanti.Close();
                baglanti.Open();
                komut = new SqlCommand("insert into  kategori(kategori_adi) values ('" + tbkategori.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                listele();
                //kitapcs fm = new kitapcs();
                //fm.fonkategori(Update());
            }
            else
                MessageBox.Show("kayt var");

        }
        private void tbkategori_TextChanged(object sender, EventArgs e)
        {
            ara();
        }

        private void kategori_Load(object sender, EventArgs e)
        {
            listele();
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
        void sil(int id)
        {
            baglanti.Close();
            baglanti.Open();
            komut = new SqlCommand("delete from kategori where (kategori_id=" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idisi;
            foreach (DataGridViewRow drow in goster.SelectedRows)  //Seçili Satırları Silme
            {
                idisi = Convert.ToInt32(drow.Cells[0].Value.ToString());
                sil(idisi);
                MessageBox.Show("silindi  ");
                listele();
            }
        }

        private void kategori_FormClosed(object sender, FormClosedEventArgs e)
        {


            adres fm = new adres();
            fm.combo();
            fm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void goster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
