using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphanem
{
    public partial class Anasayfacs : Form
    {
        public Anasayfacs()
        {
            InitializeComponent();
        }

        private void Anasayfacs_Load(object sender, EventArgs e)
        {

        }

        private void menuclick_Click(object sender, EventArgs e)
        {
            if(menu.Width==220)
            {
               
                menu.Width = 48;
                panel1.Width += 172;


            }
            else
            {
                menu.Width = 220;
                panel1.Width -= 172;
            }
        }

        private void btnadres_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            adres fm = new adres();
            fm.Dock = DockStyle.Fill;
            panel1.Controls.Add(fm);
        }

        private void menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            admin fm = new admin();
            fm.Dock = DockStyle.Fill;
            panel1.Controls.Add(fm);
        }

        private void btnkitap_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            kitapcs fm = new kitapcs();
            fm.Dock = DockStyle.Fill;
            panel1.Controls.Add(fm);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           kategori frm = new kategori();
            frm.Show();

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            satislistele fr = new satislistele();
            fr.Show();
            this.Hide();
        }
    }
}
