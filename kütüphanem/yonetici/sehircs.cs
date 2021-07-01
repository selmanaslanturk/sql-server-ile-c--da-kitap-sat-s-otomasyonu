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
    public partial class sehircs : Form
    {
        public sehircs()
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
            komut = new SqlCommand("select count(sehir_id) as sayi from sehir where sehir_adi LIKE'%" + tbsehir.Text + "%'", baglanti);
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                kont = Convert.ToInt32(dr["sayi"].ToString());
            }
        }
        void listele()
        {
            komut = new SqlCommand("select *from sehir ORDER BY(sehir_adi) ", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            goster.DataSource = dt;
            goster.Columns[0].HeaderText = "İD";
            goster.Columns[0].Width = 50;
            goster.Columns[1].HeaderText = "ŞEHİR";
            goster.Columns[1].Width = 127;
            baglanti.Close();
        }
        void ara()
        {
            baglanti.Close();
            komut = new SqlCommand("select *from sehir where sehir_adi LIKE'%" + tbsehir.Text + "%' ORDER BY(sehir_adi)", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            goster.DataSource = dt;
            goster.Columns[0].HeaderText = "İD";
            goster.Columns[0].Width = 50;
            goster.Columns[1].HeaderText = "ŞEHİR";
            goster.Columns[1].Width = 127;
            baglanti.Close();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            kontrol();
            if (kont ==0)
            {
                baglanti.Close();
                baglanti.Open();
                komut = new SqlCommand("insert into  sehir(sehir_adi) values ('" + tbsehir.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                listele();
            }
            else
                MessageBox.Show("kayt var");
           
        }
        private void tbsehir_TextChanged(object sender, EventArgs e)
        {
            ara();
        }

        private void sehircs_Load_1(object sender, EventArgs e)
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
        void sil( int id)
        {
            baglanti.Close();
            baglanti.Open();
            komut = new SqlCommand("delete from sehir where (sehir_id=" + id + ")", baglanti);
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

        private void sehircs_FormClosed(object sender, FormClosedEventArgs e)
        {

           
            adres fm = new adres();
            fm.combo();
            fm.Show();
            this.Hide();
        }

        private void goster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
