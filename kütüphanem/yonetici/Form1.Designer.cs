namespace kütüphanem
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.tbadmin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbsifre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btngiris = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.tbadmin);
            this.bunifuGradientPanel1.Controls.Add(this.tbsifre);
            this.bunifuGradientPanel1.Controls.Add(this.btngiris);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(12, 49);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(584, 239);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // tbadmin
            // 
            this.tbadmin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbadmin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbadmin.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbadmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbadmin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbadmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbadmin.HintForeColor = System.Drawing.Color.Empty;
            this.tbadmin.HintText = "";
            this.tbadmin.isPassword = false;
            this.tbadmin.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbadmin.LineIdleColor = System.Drawing.Color.Gray;
            this.tbadmin.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbadmin.LineThickness = 3;
            this.tbadmin.Location = new System.Drawing.Point(371, 57);
            this.tbadmin.Margin = new System.Windows.Forms.Padding(4);
            this.tbadmin.MaxLength = 32767;
            this.tbadmin.Name = "tbadmin";
            this.tbadmin.Size = new System.Drawing.Size(181, 33);
            this.tbadmin.TabIndex = 3;
            this.tbadmin.Text = "Admin";
            this.tbadmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbadmin.OnValueChanged += new System.EventHandler(this.tbadmin_OnValueChanged);
            // 
            // tbsifre
            // 
            this.tbsifre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbsifre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbsifre.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbsifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbsifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbsifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbsifre.HintForeColor = System.Drawing.Color.Empty;
            this.tbsifre.HintText = "";
            this.tbsifre.isPassword = false;
            this.tbsifre.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbsifre.LineIdleColor = System.Drawing.Color.Gray;
            this.tbsifre.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbsifre.LineThickness = 3;
            this.tbsifre.Location = new System.Drawing.Point(371, 98);
            this.tbsifre.Margin = new System.Windows.Forms.Padding(4);
            this.tbsifre.MaxLength = 32767;
            this.tbsifre.Name = "tbsifre";
            this.tbsifre.Size = new System.Drawing.Size(181, 33);
            this.tbsifre.TabIndex = 2;
            this.tbsifre.Text = "Şifre";
            this.tbsifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btngiris
            // 
            this.btngiris.ActiveBorderThickness = 1;
            this.btngiris.ActiveCornerRadius = 20;
            this.btngiris.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btngiris.ActiveForecolor = System.Drawing.Color.White;
            this.btngiris.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btngiris.BackColor = System.Drawing.Color.LightGray;
            this.btngiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btngiris.BackgroundImage")));
            this.btngiris.ButtonText = "Giriş";
            this.btngiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngiris.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngiris.ForeColor = System.Drawing.Color.SeaGreen;
            this.btngiris.IdleBorderThickness = 1;
            this.btngiris.IdleCornerRadius = 20;
            this.btngiris.IdleFillColor = System.Drawing.Color.White;
            this.btngiris.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btngiris.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btngiris.Location = new System.Drawing.Point(371, 149);
            this.btngiris.Margin = new System.Windows.Forms.Padding(5);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(181, 41);
            this.btngiris.TabIndex = 0;
            this.btngiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 5;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 0;
            this.bunifuTileButton1.LabelText = "";
            this.bunifuTileButton1.Location = new System.Drawing.Point(554, 7);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(43, 33);
            this.bunifuTileButton1.TabIndex = 1;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(612, 299);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 btngiris;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbadmin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbsifre;
    }
}

