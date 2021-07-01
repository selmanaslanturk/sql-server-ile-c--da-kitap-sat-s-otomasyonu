namespace kütüphanem
{
    partial class yazar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbyazar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.goster = new System.Windows.Forms.DataGridView();
            this.btnkaydet = new MaterialSkin.Controls.MaterialFlatButton();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goster)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.tbyazar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnkaydet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 139);
            this.panel1.TabIndex = 1;
            // 
            // tbyazar
            // 
            this.tbyazar.Depth = 0;
            this.tbyazar.Hint = "";
            this.tbyazar.Location = new System.Drawing.Point(12, 26);
            this.tbyazar.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbyazar.Name = "tbyazar";
            this.tbyazar.PasswordChar = '\0';
            this.tbyazar.SelectedText = "";
            this.tbyazar.SelectionLength = 0;
            this.tbyazar.SelectionStart = 0;
            this.tbyazar.Size = new System.Drawing.Size(126, 23);
            this.tbyazar.TabIndex = 1;
            this.tbyazar.Text = "Yazar";
            this.tbyazar.UseSystemPasswordChar = false;
            this.tbyazar.TextChanged += new System.EventHandler(this.tbyazar_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.goster);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(173, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 139);
            this.panel2.TabIndex = 5;
            // 
            // goster
            // 
            this.goster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goster.Location = new System.Drawing.Point(0, 0);
            this.goster.Name = "goster";
            this.goster.Size = new System.Drawing.Size(220, 139);
            this.goster.TabIndex = 0;
            this.goster.MouseClick += new System.Windows.Forms.MouseEventHandler(this.goster_MouseClick);
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
            // yazar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 139);
            this.Controls.Add(this.panel1);
            this.Name = "yazar";
            this.Text = "yazar";
            this.Load += new System.EventHandler(this.yazar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.goster)).EndInit();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbyazar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView goster;
        private MaterialSkin.Controls.MaterialFlatButton btnkaydet;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}