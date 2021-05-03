
namespace LightsStorage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.въвежданеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вСкладToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вОсветителниТелаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.безНамалениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сНамалениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(809, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.въвежданеToolStripMenuItem,
            this.справкиToolStripMenuItem,
            this.изходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // въвежданеToolStripMenuItem
            // 
            this.въвежданеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вСкладToolStripMenuItem,
            this.вОсветителниТелаToolStripMenuItem});
            this.въвежданеToolStripMenuItem.Name = "въвежданеToolStripMenuItem";
            this.въвежданеToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.въвежданеToolStripMenuItem.Text = "Въвеждане";
            // 
            // вСкладToolStripMenuItem
            // 
            this.вСкладToolStripMenuItem.Name = "вСкладToolStripMenuItem";
            this.вСкладToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вСкладToolStripMenuItem.Text = "В склад";
            this.вСкладToolStripMenuItem.Click += new System.EventHandler(this.вСкладToolStripMenuItem_Click);
            // 
            // вОсветителниТелаToolStripMenuItem
            // 
            this.вОсветителниТелаToolStripMenuItem.Name = "вОсветителниТелаToolStripMenuItem";
            this.вОсветителниТелаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вОсветителниТелаToolStripMenuItem.Text = "В осветителни тела";
            this.вОсветителниТелаToolStripMenuItem.Click += new System.EventHandler(this.вОсветителниТелаToolStripMenuItem_Click);
            // 
            // справкиToolStripMenuItem
            // 
            this.справкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.безНамалениеToolStripMenuItem,
            this.сНамалениеToolStripMenuItem});
            this.справкиToolStripMenuItem.Name = "справкиToolStripMenuItem";
            this.справкиToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.справкиToolStripMenuItem.Text = "Справки";
            // 
            // изходToolStripMenuItem
            // 
            this.изходToolStripMenuItem.Name = "изходToolStripMenuItem";
            this.изходToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.изходToolStripMenuItem.Text = "Изход";
            // 
            // безНамалениеToolStripMenuItem
            // 
            this.безНамалениеToolStripMenuItem.Name = "безНамалениеToolStripMenuItem";
            this.безНамалениеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.безНамалениеToolStripMenuItem.Text = "Без намаление";
            this.безНамалениеToolStripMenuItem.Click += new System.EventHandler(this.безНамалениеToolStripMenuItem_Click);
            // 
            // сНамалениеToolStripMenuItem
            // 
            this.сНамалениеToolStripMenuItem.Name = "сНамалениеToolStripMenuItem";
            this.сНамалениеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сНамалениеToolStripMenuItem.Text = "С намаление";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem въвежданеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вСкладToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вОсветителниТелаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem безНамалениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сНамалениеToolStripMenuItem;
    }
}