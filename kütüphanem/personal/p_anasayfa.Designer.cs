namespace kütüphanem
{
    partial class p_anasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuTileButton4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.goster = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbkitapadi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bunifuTileButton13 = new Bunifu.Framework.UI.BunifuTileButton();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Kitapekle = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goster)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.BackColor = System.Drawing.Color.Chartreuse;
            this.bunifuTileButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTileButton4.color = System.Drawing.Color.Chartreuse;
            this.bunifuTileButton4.colorActive = System.Drawing.Color.LawnGreen;
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.Black;
            this.bunifuTileButton4.Image = null;
            this.bunifuTileButton4.ImagePosition = 0;
            this.bunifuTileButton4.ImageZoom = 0;
            this.bunifuTileButton4.LabelPosition = 45;
            this.bunifuTileButton4.LabelText = "SATIŞ ";
            this.bunifuTileButton4.Location = new System.Drawing.Point(720, 347);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(111, 50);
            this.bunifuTileButton4.TabIndex = 9;
            this.bunifuTileButton4.Click += new System.EventHandler(this.bunifuTileButton4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.goster);
            this.groupBox1.Location = new System.Drawing.Point(466, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 285);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRÜN LİSTESİ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // goster
            // 
            this.goster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goster.Location = new System.Drawing.Point(3, 20);
            this.goster.Name = "goster";
            this.goster.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.goster.Size = new System.Drawing.Size(642, 262);
            this.goster.TabIndex = 1;
            this.goster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.goster_CellContentClick);
            this.goster.MouseClick += new System.Windows.Forms.MouseEventHandler(this.goster_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 285);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ALINAN ÜRÜNLER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 262);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.materialLabel2);
            this.groupBox3.Controls.Add(this.materialLabel1);
            this.groupBox3.Location = new System.Drawing.Point(494, 339);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TUTAR BİLGİLERİ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Red;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(144, 38);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(38, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "0 TL";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Red;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 38);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(119, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "TOPLAM ÜCRET";
            // 
            // tbkitapadi
            // 
            this.tbkitapadi.Depth = 0;
            this.tbkitapadi.Hint = "";
            this.tbkitapadi.Location = new System.Drawing.Point(12, 12);
            this.tbkitapadi.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbkitapadi.Name = "tbkitapadi";
            this.tbkitapadi.PasswordChar = '\0';
            this.tbkitapadi.SelectedText = "";
            this.tbkitapadi.SelectionLength = 0;
            this.tbkitapadi.SelectionStart = 0;
            this.tbkitapadi.Size = new System.Drawing.Size(171, 23);
            this.tbkitapadi.TabIndex = 25;
            this.tbkitapadi.Text = "Kitap Adı:";
            this.tbkitapadi.UseSystemPasswordChar = false;
            this.tbkitapadi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbkitapadi_KeyDown);
            this.tbkitapadi.TextChanged += new System.EventHandler(this.tbkitapadi_TextChanged);
            // 
            // bunifuTileButton13
            // 
            this.bunifuTileButton13.BackColor = System.Drawing.Color.Cyan;
            this.bunifuTileButton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTileButton13.color = System.Drawing.Color.Cyan;
            this.bunifuTileButton13.colorActive = System.Drawing.Color.Cyan;
            this.bunifuTileButton13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton13.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuTileButton13.ForeColor = System.Drawing.Color.Black;
            this.bunifuTileButton13.Image = null;
            this.bunifuTileButton13.ImagePosition = 0;
            this.bunifuTileButton13.ImageZoom = 0;
            this.bunifuTileButton13.LabelPosition = 45;
            this.bunifuTileButton13.LabelText = "SATIŞ LİSTELE";
            this.bunifuTileButton13.Location = new System.Drawing.Point(844, 347);
            this.bunifuTileButton13.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.bunifuTileButton13.Name = "bunifuTileButton13";
            this.bunifuTileButton13.Size = new System.Drawing.Size(171, 50);
            this.bunifuTileButton13.TabIndex = 26;
            this.bunifuTileButton13.Click += new System.EventHandler(this.bunifuTileButton13_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Kitapekle});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(86, 26);
            // 
            // Kitapekle
            // 
            this.Kitapekle.Name = "Kitapekle";
            this.Kitapekle.Size = new System.Drawing.Size(180, 22);
            this.Kitapekle.Text = "sil";
            this.Kitapekle.Click += new System.EventHandler(this.Kitapekle_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Fuchsia;
            this.bunifuTileButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTileButton1.color = System.Drawing.Color.Fuchsia;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.Fuchsia;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.Black;
            this.bunifuTileButton1.Image = null;
            this.bunifuTileButton1.ImagePosition = 0;
            this.bunifuTileButton1.ImageZoom = 0;
            this.bunifuTileButton1.LabelPosition = 45;
            this.bunifuTileButton1.LabelText = "ÇIKIŞ";
            this.bunifuTileButton1.Location = new System.Drawing.Point(798, 3);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(111, 47);
            this.bunifuTileButton1.TabIndex = 27;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // p_anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 443);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.bunifuTileButton13);
            this.Controls.Add(this.tbkitapadi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuTileButton4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "p_anasayfa";
            this.Text = "p_anasayfa";
            this.Load += new System.EventHandler(this.p_anasayfa_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.goster)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView goster;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbkitapadi;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton13;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem Kitapekle;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
    }
}