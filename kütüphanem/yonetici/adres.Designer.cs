namespace kütüphanem
{
    partial class adres
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbilce = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.sehirclik = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.goster = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnkaydet = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goster)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.goster);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 238);
            this.panel1.TabIndex = 1;
            // 
            // tbilce
            // 
            this.tbilce.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbilce.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbilce.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbilce.BorderThickness = 3;
            this.tbilce.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbilce.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbilce.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbilce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbilce.isPassword = false;
            this.tbilce.Location = new System.Drawing.Point(30, 69);
            this.tbilce.Margin = new System.Windows.Forms.Padding(4);
            this.tbilce.MaxLength = 32767;
            this.tbilce.Name = "tbilce";
            this.tbilce.Size = new System.Drawing.Size(162, 44);
            this.tbilce.TabIndex = 2;
            this.tbilce.Text = "İlçe";
            this.tbilce.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sehirclik
            // 
            this.sehirclik.AutoSize = true;
            this.sehirclik.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sehirclik.Depth = 0;
            this.sehirclik.Location = new System.Drawing.Point(255, 23);
            this.sehirclik.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sehirclik.MouseState = MaterialSkin.MouseState.HOVER;
            this.sehirclik.Name = "sehirclik";
            this.sehirclik.Primary = false;
            this.sehirclik.Size = new System.Drawing.Size(85, 36);
            this.sehirclik.TabIndex = 4;
            this.sehirclik.Text = "Şehir ekle";
            this.sehirclik.UseVisualStyleBackColor = true;
            this.sehirclik.Click += new System.EventHandler(this.sehir_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(255, 77);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(57, 36);
            this.materialFlatButton1.TabIndex = 5;
            this.materialFlatButton1.Text = "Yenile";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // goster
            // 
            this.goster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goster.Location = new System.Drawing.Point(0, 0);
            this.goster.Name = "goster";
            this.goster.Size = new System.Drawing.Size(757, 238);
            this.goster.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // btnkaydet
            // 
            this.btnkaydet.AutoSize = true;
            this.btnkaydet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnkaydet.Depth = 0;
            this.btnkaydet.Location = new System.Drawing.Point(159, 137);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnkaydet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Primary = false;
            this.btnkaydet.Size = new System.Drawing.Size(63, 36);
            this.btnkaydet.TabIndex = 7;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // adres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.sehirclik);
            this.Controls.Add(this.tbilce);
            this.Controls.Add(this.panel1);
            this.Name = "adres";
            this.Size = new System.Drawing.Size(757, 420);
            this.Load += new System.EventHandler(this.adres_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.goster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbilce;
        private MaterialSkin.Controls.MaterialFlatButton sehirclik;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.DataGridView goster;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialFlatButton btnkaydet;
    }
}
