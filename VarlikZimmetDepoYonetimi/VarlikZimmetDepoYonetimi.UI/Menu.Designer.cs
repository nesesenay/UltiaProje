namespace VarlikZimmetDepoYonetimi.UI
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.varlikLİstelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zimmetAtaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tüketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.varlikLİstelemeToolStripMenuItem,
            this.varlikToolStripMenuItem,
            this.zimmetAtaToolStripMenuItem,
            this.tüketToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1277, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // varlikLİstelemeToolStripMenuItem
            // 
            this.varlikLİstelemeToolStripMenuItem.Name = "varlikLİstelemeToolStripMenuItem";
            this.varlikLİstelemeToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.varlikLİstelemeToolStripMenuItem.Text = "Varlık Lİsteleme";
            this.varlikLİstelemeToolStripMenuItem.Click += new System.EventHandler(this.varlikLİstelemeToolStripMenuItem_Click);
            // 
            // varlikToolStripMenuItem
            // 
            this.varlikToolStripMenuItem.Name = "varlikToolStripMenuItem";
            this.varlikToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.varlikToolStripMenuItem.Text = "Varlık";
            this.varlikToolStripMenuItem.Click += new System.EventHandler(this.varlikToolStripMenuItem_Click);
            // 
            // zimmetAtaToolStripMenuItem
            // 
            this.zimmetAtaToolStripMenuItem.Name = "zimmetAtaToolStripMenuItem";
            this.zimmetAtaToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.zimmetAtaToolStripMenuItem.Text = "Zimmet Ata";
            this.zimmetAtaToolStripMenuItem.Click += new System.EventHandler(this.zimmetAtaToolStripMenuItem_Click);
            // 
            // tüketToolStripMenuItem
            // 
            this.tüketToolStripMenuItem.Name = "tüketToolStripMenuItem";
            this.tüketToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.tüketToolStripMenuItem.Text = "Tüket";
            this.tüketToolStripMenuItem.Click += new System.EventHandler(this.tüketToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 711);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem varlikLİstelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varlikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zimmetAtaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tüketToolStripMenuItem;
    }
}