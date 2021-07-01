namespace kütüphanem
{
    partial class satislistele
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
            this.goster = new System.Windows.Forms.DataGridView();
            this.bunifuTileButton13 = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.goster)).BeginInit();
            this.SuspendLayout();
            // 
            // goster
            // 
            this.goster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goster.Location = new System.Drawing.Point(1, 47);
            this.goster.Name = "goster";
            this.goster.Size = new System.Drawing.Size(341, 276);
            this.goster.TabIndex = 0;
            this.goster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.goster_CellContentClick);
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
            this.bunifuTileButton13.LabelPosition = 35;
            this.bunifuTileButton13.LabelText = "ANA SAYFA";
            this.bunifuTileButton13.Location = new System.Drawing.Point(171, 9);
            this.bunifuTileButton13.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.bunifuTileButton13.Name = "bunifuTileButton13";
            this.bunifuTileButton13.Size = new System.Drawing.Size(171, 33);
            this.bunifuTileButton13.TabIndex = 27;
            this.bunifuTileButton13.Click += new System.EventHandler(this.bunifuTileButton13_Click);
            // 
            // satislistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 323);
            this.Controls.Add(this.bunifuTileButton13);
            this.Controls.Add(this.goster);
            this.Name = "satislistele";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView goster;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton13;
    }
}