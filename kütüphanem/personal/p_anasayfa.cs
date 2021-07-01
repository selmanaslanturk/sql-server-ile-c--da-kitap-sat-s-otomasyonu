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
    public partial class p_anasayfa : Form
    {
        public p_anasayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=ktp_vrtb;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        DataTable dt;
        void listele()
        {
            
            komut = new SqlCommand("select kit.kitap_id,kit.kitap_adi, yaz.yazar_adi,ka.kategori_adi,s.adet, kit.fiyat from kitap as kit,kategori as ka,yazar as yaz ,yayinevi as yay ,stok as s where kit.kategori_id=ka.kategori_id  and  kit.yazar_id=yaz.yazar_id  and kit.yayinevi_id=yay.yayinevi_id and kit.kitap_id=s.kitap_id ", baglanti);
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
            komut = new SqlCommand("select kit.kitap_id,kit.kitap_adi, yaz.yazar_adi,ka.kategori_adi ,s.adet, kit.fiyat from kitap as kit,kategori as ka,yazar as yaz ,yayinevi as yay ,stok as s where kit.kategori_id=ka.kategori_id  and  kit.yazar_id=yaz.yazar_id  and kit.yayinevi_id=yay.yayinevi_id and kit.kitap_id=s.kitap_id and kit.kitap_adi  LIKE'%" + tbkitapadi.Text + "%' ORDER BY(kitap_adi)", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            goster.DataSource = dt;
           
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void p_anasayfa_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void tbkitapadi_TextChanged(object sender, EventArgs e)
        {
            ara();
        }
        
        private void goster_MouseClick(object sender, MouseEventArgs e)
        {
            //dataGridView1.Rows.Clear();
            try
            {
                int topadet = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Adet Sayisini girin ").ToString());
                

                int id = Convert.ToInt32(goster.SelectedCells[0].Value);
                if (topadet <= Convert.ToInt32(goster.SelectedCells[4].Value)&&topadet>0)
                {
                    dataGridView1.ColumnCount = 5;
                    dataGridView1.Columns[0].Name = "KİTAP ID";
                    dataGridView1.Columns[2].Name = "FİYAT";
                    dataGridView1.Columns[1].Name = "KİTAP ADI";
                    dataGridView1.Columns[3].Name = "ADET";
                    dataGridView1.Columns[4].Name = "TOPLAM ÜCRET";
                    int yenistok = Convert.ToInt32(goster.SelectedCells[4].Value) - topadet;

                    baglanti.Close();
                    baglanti.Open();
                    komut.Connection = baglanti;
                    komut.CommandText = "update stok set adet=" + yenistok + "where kitap_id=" + id + "";
                    komut.ExecuteNonQuery();
             
                    baglanti.Close();


                    kont = 1;
                    if (dataGridView1.RowCount > 2)
                    {
                        int i = dataGridView1.RowCount;
                        dataGridView1.Rows.RemoveAt(i -= 2);
                    }
                    int birimfiyat = Convert.ToInt32(goster.SelectedCells[5].Value);

                    int topucret = topadet * Convert.ToInt32(goster.SelectedCells[5].Value);
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (Convert.ToInt32(goster.SelectedCells[0].Value) == Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value))
                        {
                            topucret = (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) + topadet) * birimfiyat;
                            dataGridView1.Rows[i].Cells[3].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) + topadet;
                            dataGridView1.Rows[i].Cells[0].Value = goster.SelectedCells[0].Value;
                            dataGridView1.Rows[i].Cells[4].Value = topucret;
                            kont = 2;
                            break;
                        }
                    }

                    if (kont != 2)
                    {
                        topucret = 0;
                        topucret = topadet * birimfiyat;
                        dataGridView1.Rows.Add(goster.SelectedCells[0].Value, goster.SelectedCells[1].Value, birimfiyat, topadet, topucret);
                    }
                    topucret = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {

                        topucret += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                    }
                    dataGridView1.Rows.Add("", "", "", "Toplam ucret :", topucret.ToString());
                }
                if(topadet<=0)
                    MessageBox.Show("adeti 0 veya 0dan küçük giremezsiniz");

               if( Convert.ToInt32(goster.SelectedCells[4].Value)<topadet|| Convert.ToInt32(goster.SelectedCells[4].Value)==  0)

                    MessageBox.Show("yeterli ürün yoktur");

                listele();
            }
            catch
            {

            }
        }
        int kont ;
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

        private void tbkitapadi_KeyDown(object sender, KeyEventArgs e)
        {
         
            if (e.KeyCode==Keys.Enter)
            {

                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "KİTAP ID";
                dataGridView1.Columns[2].Name = "BİRİM FİYAT";
                dataGridView1.Columns[1].Name = "KİTAP ADI";
                dataGridView1.Columns[3].Name = "ADET";
                dataGridView1.Columns[4].Name = "TOPLAM ÜCRET";


                kontrol();
               
                if (kont == 1)
                {
                    int topucret = 0, birimfiyat = Convert.ToInt32(goster.Rows[0].Cells[5].Value);
                    int topadet = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Adet Sayisini girin ").ToString());
                    if (dataGridView1.RowCount > 2)
                    {
                        int i = dataGridView1.RowCount;
                        dataGridView1.Rows.RemoveAt(i-=2);
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if(Convert.ToInt32(goster.Rows[0].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value))
                        {
                            topucret = (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) + topadet) * birimfiyat;
                            dataGridView1.Rows[i].Cells[3].Value=Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value)+topadet;
                            dataGridView1.Rows[i].Cells[0].Value = goster.Rows[0].Cells[0].Value;
                            dataGridView1.Rows[i].Cells[4].Value = topucret;
                            kont = 2;
                            break;
                        }
                    }
                    if(kont!=2)
                    {
                        topucret = 0;
                     topucret = topadet * birimfiyat;
                    dataGridView1.Rows.Add(goster.Rows[0].Cells[0].Value, goster.Rows[0].Cells[1].Value, birimfiyat, topadet,topucret); 
                     }
                    topucret = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        
                        topucret += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                    }
                    dataGridView1.Rows.Add("", "", "", "Toplam ucret :", topucret.ToString());

                }
                else
                    MessageBox.Show("kitap adı girmediniz");
                
            }
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            int top=0,satid=0;
            for (int i = 0; i < dataGridView1.Rows.Count-2; ++i)
            {

                top += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            DateTime tarih = DateTime.Now;
            string ekle = "insert into satis(tarihsaat,t_fiyat) values (@1,@2)";
            SqlCommand komut = new SqlCommand(ekle, baglanti);
            komut.Parameters.AddWithValue("@1",tarih );
            komut.Parameters.AddWithValue("@2", top);
            baglanti.Close();
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            komut = new SqlCommand("Select *From satis where tarihsaat=@1 ", baglanti);
            komut.Parameters.AddWithValue("@1", tarih);

            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                satid = Convert.ToInt32(dr["satis_id"].ToString());
            }
           


            for (int i = 0; i < dataGridView1.Rows.Count - 2; ++i)
            {
                string ekle1 = "insert into satisbilgi(satis_id,kitap_id,fiyat,adet,t_fiyat) values (@1,@2,@3,@4,@5)";
                SqlCommand komut1 = new SqlCommand(ekle1, baglanti);
                komut1.Parameters.AddWithValue("@1", satid);
                komut1.Parameters.AddWithValue("@2", dataGridView1.Rows[i].Cells[0].Value);
                komut1.Parameters.AddWithValue("@3", dataGridView1.Rows[i].Cells[2].Value);
                komut1.Parameters.AddWithValue("@4", dataGridView1.Rows[i].Cells[3].Value);
                komut1.Parameters.AddWithValue("@5", dataGridView1.Rows[i].Cells[4].Value);
                baglanti.Close();
                baglanti.Open();
                komut1.ExecuteNonQuery();
                baglanti.Close();
              
            }
            dataGridView1.Rows.Clear();

          
        }

        private void bunifuTileButton13_Click(object sender, EventArgs e)
        {
            satislistele fr = new satislistele();
            fr.Show();
            this.Hide();
        }

        private void goster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            {
                if ("" != drow.Cells[0].Value.ToString())
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        menu.Show(dataGridView1, new Point(e.X, e.Y));
                    }
                }
            }
        }

        private void Kitapekle_Click(object sender, EventArgs e)
        {
          
            int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
            MessageBox.Show(id.ToString());
            for (int i = 0; i < goster.Rows.Count; i++)
            {
                if (Convert.ToInt32(goster.Rows[i].Cells[0].Value) == id)
                {
                    MessageBox.Show(Convert.ToInt32(goster.Rows[i].Cells[4].Value).ToString());
                    int yenistok = Convert.ToInt32(goster.Rows[i].Cells[4].Value)+ Convert.ToInt32(dataGridView1.SelectedCells[3].Value);
                    MessageBox.Show(yenistok.ToString());

                    baglanti.Close();
                    baglanti.Open();
                    komut.Connection = baglanti;
                    komut.CommandText = "update stok set adet=" + yenistok + "where kitap_id=" + id + "";
                    komut.ExecuteNonQuery();
                    listele();
                    baglanti.Close();
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
               

            }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
             frm.Show();
            this.Hide();

        }
    }
}
