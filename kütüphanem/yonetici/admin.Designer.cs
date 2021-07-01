namespace kütüphanem
{
    partial class admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bayan = new System.Windows.Forms.RadioButton();
            this.bay = new System.Windows.Forms.RadioButton();
            this.yetki = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.goster = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.tbadres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.cbilce = new System.Windows.Forms.ComboBox();
            this.cbsehir = new System.Windows.Forms.ComboBox();
            this.tbeposta = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbtelefon = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbsifre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbadmin = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbsoyadi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbadi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.rbpersonel = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.rbpersonel);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.yetki);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbadres);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.materialFlatButton1);
            this.panel1.Controls.Add(this.cbilce);
            this.panel1.Controls.Add(this.cbsehir);
            this.panel1.Controls.Add(this.tbeposta);
            this.panel1.Controls.Add(this.tbtelefon);
            this.panel1.Controls.Add(this.tbsifre);
            this.panel1.Controls.Add(this.tbadmin);
            this.panel1.Controls.Add(this.tbsoyadi);
            this.panel1.Controls.Add(this.tbadi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 420);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bayan);
            this.groupBox1.Controls.Add(this.bay);
            this.groupBox1.Location = new System.Drawing.Point(607, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 38);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "cinsiyet";
            // 
            // bayan
            // 
            this.bayan.AutoSize = true;
            this.bayan.Location = new System.Drawing.Point(0, 15);
            this.bayan.Name = "bayan";
            this.bayan.Size = new System.Drawing.Size(52, 17);
            this.bayan.TabIndex = 10;
            this.bayan.TabStop = true;
            this.bayan.Text = "Kadın";
            this.bayan.UseVisualStyleBackColor = true;
            // 
            // bay
            // 
            this.bay.AutoSize = true;
            this.bay.Location = new System.Drawing.Point(58, 15);
            this.bay.Name = "bay";
            this.bay.Size = new System.Drawing.Size(53, 17);
            this.bay.TabIndex = 9;
            this.bay.TabStop = true;
            this.bay.Text = "Erkek";
            this.bay.UseVisualStyleBackColor = true;
            // 
            // yetki
            // 
            this.yetki.AutoSize = true;
            this.yetki.Location = new System.Drawing.Point(528, 145);
            this.yetki.Name = "yetki";
            this.yetki.Size = new System.Drawing.Size(63, 17);
            this.yetki.TabIndex = 17;
            this.yetki.TabStop = true;
            this.yetki.Text = "Yönetici";
            this.yetki.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.goster);
            this.panel2.Controls.Add(this.bunifuCustomDataGrid1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 245);
            this.panel2.TabIndex = 16;
            // 
            // goster
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.goster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.goster.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.goster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.goster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.goster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goster.DoubleBuffered = true;
            this.goster.EnableHeadersVisualStyles = false;
            this.goster.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.goster.HeaderForeColor = System.Drawing.SystemColors.ButtonFace;
            this.goster.Location = new System.Drawing.Point(0, 0);
            this.goster.Name = "goster";
            this.goster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.goster.Size = new System.Drawing.Size(757, 245);
            this.goster.TabIndex = 1;
            this.goster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.goster_CellContentClick);
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(110, 68);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(240, 150);
            this.bunifuCustomDataGrid1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Adress";
            // 
            // tbadres
            // 
            this.tbadres.Location = new System.Drawing.Point(610, 78);
            this.tbadres.Multiline = true;
            this.tbadres.Name = "tbadres";
            this.tbadres.Size = new System.Drawing.Size(121, 45);
            this.tbadres.TabIndex = 14;
            this.tbadres.TextChanged += new System.EventHandler(this.textBox1adres_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "İlçe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Şehir";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(458, 130);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(63, 36);
            this.materialFlatButton1.TabIndex = 11;
            this.materialFlatButton1.Text = "Kaydet";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // cbilce
            // 
            this.cbilce.FormattingEnabled = true;
            this.cbilce.Location = new System.Drawing.Point(610, 51);
            this.cbilce.Name = "cbilce";
            this.cbilce.Size = new System.Drawing.Size(121, 21);
            this.cbilce.TabIndex = 8;
            // 
            // cbsehir
            // 
            this.cbsehir.FormattingEnabled = true;
            this.cbsehir.Location = new System.Drawing.Point(610, 24);
            this.cbsehir.Name = "cbsehir";
            this.cbsehir.Size = new System.Drawing.Size(121, 21);
            this.cbsehir.TabIndex = 7;
            this.cbsehir.SelectedIndexChanged += new System.EventHandler(this.cbsehir_SelectedIndexChanged);
            // 
            // tbeposta
            // 
            this.tbeposta.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbeposta.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbeposta.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbeposta.BorderThickness = 3;
            this.tbeposta.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbeposta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbeposta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbeposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbeposta.isPassword = false;
            this.tbeposta.Location = new System.Drawing.Point(359, 76);
            this.tbeposta.Margin = new System.Windows.Forms.Padding(4);
            this.tbeposta.MaxLength = 32767;
            this.tbeposta.Name = "tbeposta";
            this.tbeposta.Size = new System.Drawing.Size(162, 44);
            this.tbeposta.TabIndex = 6;
            this.tbeposta.Text = "E-posta";
            this.tbeposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbtelefon
            // 
            this.tbtelefon.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbtelefon.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbtelefon.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbtelefon.BorderThickness = 3;
            this.tbtelefon.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbtelefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbtelefon.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbtelefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbtelefon.isPassword = false;
            this.tbtelefon.Location = new System.Drawing.Point(359, 24);
            this.tbtelefon.Margin = new System.Windows.Forms.Padding(4);
            this.tbtelefon.MaxLength = 32767;
            this.tbtelefon.Name = "tbtelefon";
            this.tbtelefon.Size = new System.Drawing.Size(162, 44);
            this.tbtelefon.TabIndex = 5;
            this.tbtelefon.Text = "Telefon";
            this.tbtelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbsifre
            // 
            this.tbsifre.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbsifre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbsifre.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbsifre.BorderThickness = 3;
            this.tbsifre.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbsifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbsifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbsifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbsifre.isPassword = false;
            this.tbsifre.Location = new System.Drawing.Point(189, 76);
            this.tbsifre.Margin = new System.Windows.Forms.Padding(4);
            this.tbsifre.MaxLength = 32767;
            this.tbsifre.Name = "tbsifre";
            this.tbsifre.Size = new System.Drawing.Size(162, 44);
            this.tbsifre.TabIndex = 4;
            this.tbsifre.Text = "Şifre";
            this.tbsifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbadmin
            // 
            this.tbadmin.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbadmin.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbadmin.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbadmin.BorderThickness = 3;
            this.tbadmin.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbadmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbadmin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbadmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbadmin.isPassword = false;
            this.tbadmin.Location = new System.Drawing.Point(189, 24);
            this.tbadmin.Margin = new System.Windows.Forms.Padding(4);
            this.tbadmin.MaxLength = 32767;
            this.tbadmin.Name = "tbadmin";
            this.tbadmin.Size = new System.Drawing.Size(162, 44);
            this.tbadmin.TabIndex = 3;
            this.tbadmin.Text = "Kullanıcı adı:";
            this.tbadmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbsoyadi
            // 
            this.tbsoyadi.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbsoyadi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbsoyadi.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbsoyadi.BorderThickness = 3;
            this.tbsoyadi.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbsoyadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbsoyadi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbsoyadi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbsoyadi.isPassword = false;
            this.tbsoyadi.Location = new System.Drawing.Point(19, 76);
            this.tbsoyadi.Margin = new System.Windows.Forms.Padding(4);
            this.tbsoyadi.MaxLength = 32767;
            this.tbsoyadi.Name = "tbsoyadi";
            this.tbsoyadi.Size = new System.Drawing.Size(162, 44);
            this.tbsoyadi.TabIndex = 2;
            this.tbsoyadi.Text = "Soyadi";
            this.tbsoyadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbadi
            // 
            this.tbadi.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbadi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbadi.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbadi.BorderThickness = 3;
            this.tbadi.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbadi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbadi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbadi.isPassword = false;
            this.tbadi.Location = new System.Drawing.Point(19, 24);
            this.tbadi.Margin = new System.Windows.Forms.Padding(4);
            this.tbadi.MaxLength = 32767;
            this.tbadi.Name = "tbadi";
            this.tbadi.Size = new System.Drawing.Size(162, 44);
            this.tbadi.TabIndex = 1;
            this.tbadi.Text = "Adi";
            this.tbadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbadi.OnValueChanged += new System.EventHandler(this.tbadi_OnValueChanged);
            // 
            // rbpersonel
            // 
            this.rbpersonel.AutoSize = true;
            this.rbpersonel.Location = new System.Drawing.Point(528, 122);
            this.rbpersonel.Name = "rbpersonel";
            this.rbpersonel.Size = new System.Drawing.Size(66, 17);
            this.rbpersonel.TabIndex = 19;
            this.rbpersonel.TabStop = true;
            this.rbpersonel.Text = "Personel";
            this.rbpersonel.UseVisualStyleBackColor = true;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "admin";
            this.Size = new System.Drawing.Size(757, 420);
            this.Load += new System.EventHandler(this.admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.goster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbadi;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbeposta;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbtelefon;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbsifre;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbadmin;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbsoyadi;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid goster;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbadres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.RadioButton bayan;
        private System.Windows.Forms.RadioButton bay;
        private System.Windows.Forms.ComboBox cbilce;
        private System.Windows.Forms.ComboBox cbsehir;
        private System.Windows.Forms.RadioButton yetki;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbpersonel;
    }
}
