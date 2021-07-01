namespace kütüphanem
{
    partial class kitapcs
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Kitapekle = new System.Windows.Forms.ToolStripMenuItem();
            this.cbkategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbyazar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnkategori = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnyazar = new MaterialSkin.Controls.MaterialFlatButton();
            this.cbyayinevi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.numsayfa = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.numbasim = new System.Windows.Forms.NumericUpDown();
            this.numadet = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.goster = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.tbkitapadi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.numfiyat = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.kid = new MaterialSkin.Controls.MaterialLabel();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numsayfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbasim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numadet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numfiyat)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Kitapekle});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(126, 26);
            this.menu.Opening += new System.ComponentModel.CancelEventHandler(this.menu_Opening);
            // 
            // Kitapekle
            // 
            this.Kitapekle.Name = "Kitapekle";
            this.Kitapekle.Size = new System.Drawing.Size(125, 22);
            this.Kitapekle.Text = "Kitap ekle";
            this.Kitapekle.Click += new System.EventHandler(this.Kitapekle_Click);
            // 
            // cbkategori
            // 
            this.cbkategori.FormattingEnabled = true;
            this.cbkategori.Location = new System.Drawing.Point(126, 54);
            this.cbkategori.Name = "cbkategori";
            this.cbkategori.Size = new System.Drawing.Size(115, 21);
            this.cbkategori.TabIndex = 0;
            this.cbkategori.Click += new System.EventHandler(this.cbkategori_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kateegori :";
            // 
            // cbyazar
            // 
            this.cbyazar.FormattingEnabled = true;
            this.cbyazar.Location = new System.Drawing.Point(126, 81);
            this.cbyazar.Name = "cbyazar";
            this.cbyazar.Size = new System.Drawing.Size(115, 21);
            this.cbyazar.TabIndex = 3;
            this.cbyazar.Click += new System.EventHandler(this.cbyazar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yazar :";
            // 
            // btnkategori
            // 
            this.btnkategori.AutoSize = true;
            this.btnkategori.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnkategori.Depth = 0;
            this.btnkategori.Location = new System.Drawing.Point(253, 45);
            this.btnkategori.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnkategori.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnkategori.Name = "btnkategori";
            this.btnkategori.Primary = false;
            this.btnkategori.Size = new System.Drawing.Size(112, 36);
            this.btnkategori.TabIndex = 5;
            this.btnkategori.Text = "Kategori ekle";
            this.btnkategori.UseVisualStyleBackColor = true;
            this.btnkategori.Click += new System.EventHandler(this.btnkategori_Click);
            // 
            // btnyazar
            // 
            this.btnyazar.AutoSize = true;
            this.btnyazar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnyazar.Depth = 0;
            this.btnyazar.Location = new System.Drawing.Point(253, 83);
            this.btnyazar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnyazar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnyazar.Name = "btnyazar";
            this.btnyazar.Primary = false;
            this.btnyazar.Size = new System.Drawing.Size(90, 36);
            this.btnyazar.TabIndex = 6;
            this.btnyazar.Text = "yazar ekle";
            this.btnyazar.UseVisualStyleBackColor = true;
            this.btnyazar.Click += new System.EventHandler(this.btnyazar_Click);
            // 
            // cbyayinevi
            // 
            this.cbyayinevi.FormattingEnabled = true;
            this.cbyayinevi.Location = new System.Drawing.Point(126, 108);
            this.cbyayinevi.Name = "cbyayinevi";
            this.cbyayinevi.Size = new System.Drawing.Size(115, 21);
            this.cbyayinevi.TabIndex = 8;
            this.cbyayinevi.Click += new System.EventHandler(this.cbyayinevi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Yayın evi :";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(253, 119);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(110, 36);
            this.materialFlatButton1.TabIndex = 10;
            this.materialFlatButton1.Text = "yayın evi ekle";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // numsayfa
            // 
            this.numsayfa.Location = new System.Drawing.Point(126, 161);
            this.numsayfa.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numsayfa.Name = "numsayfa";
            this.numsayfa.Size = new System.Drawing.Size(120, 20);
            this.numsayfa.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Adet :";
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(165, 273);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(8, 8);
            this.bunifuCustomDataGrid1.TabIndex = 17;
            // 
            // numbasim
            // 
            this.numbasim.Location = new System.Drawing.Point(126, 186);
            this.numbasim.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numbasim.Name = "numbasim";
            this.numbasim.Size = new System.Drawing.Size(120, 20);
            this.numbasim.TabIndex = 18;
            // 
            // numadet
            // 
            this.numadet.Location = new System.Drawing.Point(126, 135);
            this.numadet.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numadet.Name = "numadet";
            this.numadet.Size = new System.Drawing.Size(120, 20);
            this.numadet.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Basım yılı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Sayfa sayısı";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.goster);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 189);
            this.panel2.TabIndex = 22;
            // 
            // goster
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.goster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.goster.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.goster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.goster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.goster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goster.DoubleBuffered = true;
            this.goster.EnableHeadersVisualStyles = false;
            this.goster.HeaderBgColor = System.Drawing.Color.Honeydew;
            this.goster.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.goster.Location = new System.Drawing.Point(0, 0);
            this.goster.Name = "goster";
            this.goster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.goster.Size = new System.Drawing.Size(757, 189);
            this.goster.TabIndex = 0;
            this.goster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.goster_CellContentClick);
            this.goster.MouseClick += new System.Windows.Forms.MouseEventHandler(this.goster_MouseClick);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(253, 161);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(63, 36);
            this.materialFlatButton2.TabIndex = 23;
            this.materialFlatButton2.Text = "Kaydet";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // tbkitapadi
            // 
            this.tbkitapadi.Depth = 0;
            this.tbkitapadi.Hint = "";
            this.tbkitapadi.Location = new System.Drawing.Point(115, 9);
            this.tbkitapadi.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbkitapadi.Name = "tbkitapadi";
            this.tbkitapadi.PasswordChar = '\0';
            this.tbkitapadi.SelectedText = "";
            this.tbkitapadi.SelectionLength = 0;
            this.tbkitapadi.SelectionStart = 0;
            this.tbkitapadi.Size = new System.Drawing.Size(126, 23);
            this.tbkitapadi.TabIndex = 24;
            this.tbkitapadi.Text = "Kategori Adı";
            this.tbkitapadi.UseSystemPasswordChar = false;
            this.tbkitapadi.TextChanged += new System.EventHandler(this.tbkitapadi_TextChanged);
            // 
            // numfiyat
            // 
            this.numfiyat.Location = new System.Drawing.Point(126, 212);
            this.numfiyat.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numfiyat.Name = "numfiyat";
            this.numfiyat.Size = new System.Drawing.Size(120, 20);
            this.numfiyat.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Fiyatı";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.kid);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.numfiyat);
            this.panel1.Controls.Add(this.tbkitapadi);
            this.panel1.Controls.Add(this.materialFlatButton2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numadet);
            this.panel1.Controls.Add(this.numbasim);
            this.panel1.Controls.Add(this.bunifuCustomDataGrid1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numsayfa);
            this.panel1.Controls.Add(this.materialFlatButton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbyayinevi);
            this.panel1.Controls.Add(this.btnyazar);
            this.panel1.Controls.Add(this.btnkategori);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbyazar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbkategori);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 420);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(497, 25);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(71, 19);
            this.materialLabel1.TabIndex = 27;
            this.materialLabel1.Text = "Kitap id : ";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // kid
            // 
            this.kid.AutoSize = true;
            this.kid.Depth = 0;
            this.kid.Font = new System.Drawing.Font("Roboto", 11F);
            this.kid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kid.Location = new System.Drawing.Point(565, 25);
            this.kid.MouseState = MaterialSkin.MouseState.HOVER;
            this.kid.Name = "kid";
            this.kid.Size = new System.Drawing.Size(0, 19);
            this.kid.TabIndex = 28;
            // 
            // kitapcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "kitapcs";
            this.Size = new System.Drawing.Size(757, 420);
            this.Load += new System.EventHandler(this.kitapcs_Load);
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numsayfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbasim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numadet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.goster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numfiyat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem Kitapekle;
        public System.Windows.Forms.ComboBox cbkategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbyazar;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialFlatButton btnkategori;
        private MaterialSkin.Controls.MaterialFlatButton btnyazar;
        private System.Windows.Forms.ComboBox cbyayinevi;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.NumericUpDown numsayfa;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.NumericUpDown numbasim;
        private System.Windows.Forms.NumericUpDown numadet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid goster;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbkitapadi;
        private System.Windows.Forms.NumericUpDown numfiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel kid;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
