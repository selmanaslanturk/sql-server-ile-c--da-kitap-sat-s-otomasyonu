namespace kütüphanem
{
    partial class yayinevi
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
            this.goster = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbkategori = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnkaydet = new MaterialSkin.Controls.MaterialFlatButton();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.goster)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // goster
            // 
            this.goster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goster.Location = new System.Drawing.Point(0, 0);
            this.goster.Name = "goster";
            this.goster.Size = new System.Drawing.Size(220, 140);
            this.goster.TabIndex = 0;
            this.goster.MouseClick += new System.Windows.Forms.MouseEventHandler(this.goster_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.tbkategori);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnkaydet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 140);
            this.panel1.TabIndex = 2;
            // 
            // tbkategori
            // 
            this.tbkategori.Depth = 0;
            this.tbkategori.Hint = "";
            this.tbkategori.Location = new System.Drawing.Point(12, 26);
            this.tbkategori.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbkategori.Name = "tbkategori";
            this.tbkategori.PasswordChar = '\0';
            this.tbkategori.SelectedText = "";
            this.tbkategori.SelectionLength = 0;
            this.tbkategori.SelectionStart = 0;
            this.tbkategori.Size = new System.Drawing.Size(126, 23);
            this.tbkategori.TabIndex = 1;
            this.tbkategori.Text = "Yayınevi";
            this.tbkategori.UseSystemPasswordChar = false;
            this.tbkategori.TextChanged += new System.EventHandler(this.tbkategori_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.goster);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(183, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 140);
            this.panel2.TabIndex = 5;
            // 
            // btnkaydet
            // 
            this.btnkaydet.AutoSize = true;
            this.btnkaydet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnkaydet.Depth = 0;
            this.btnkaydet.Location = new System.Drawing.Point(103, 58);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnkaydet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Primary = false;
            this.btnkaydet.Size = new System.Drawing.Size(63, 36);
            this.btnkaydet.TabIndex = 4;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(86, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.silToolStripMenuItem.Text = "sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // yayinevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 140);
            this.Controls.Add(this.panel1);
            this.Name = "yayinevi";
            this.Text = "yayinevi";
            this.Load += new System.EventHandler(this.kategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goster)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView goster;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbkategori;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialFlatButton btnkaydet;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}