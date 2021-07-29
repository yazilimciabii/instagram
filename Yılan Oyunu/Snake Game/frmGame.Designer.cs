namespace Snake_Game
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniOyunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.duraklatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.pbGame = new System.Windows.Forms.PictureBox();
            this.tmrGoSnake = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(511, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniOyunToolStripMenuItem,
            this.spToolStripMenuItem,
            this.duraklatToolStripMenuItem,
            this.spToolStripMenuItem1});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.dosyaToolStripMenuItem.Text = "Oyun";
            // 
            // yeniOyunToolStripMenuItem
            // 
            this.yeniOyunToolStripMenuItem.Name = "yeniOyunToolStripMenuItem";
            this.yeniOyunToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniOyunToolStripMenuItem.Text = "Yeni Oyun";
            this.yeniOyunToolStripMenuItem.Click += new System.EventHandler(this.yeniOyunToolStripMenuItem_Click);
            // 
            // spToolStripMenuItem
            // 
            this.spToolStripMenuItem.Name = "spToolStripMenuItem";
            this.spToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // duraklatToolStripMenuItem
            // 
            this.duraklatToolStripMenuItem.Name = "duraklatToolStripMenuItem";
            this.duraklatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.duraklatToolStripMenuItem.Text = "Duraklat";
            this.duraklatToolStripMenuItem.Click += new System.EventHandler(this.duraklatToolStripMenuItem_Click);
            // 
            // spToolStripMenuItem1
            // 
            this.spToolStripMenuItem1.Name = "spToolStripMenuItem1";
            this.spToolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // pbGame
            // 
            this.pbGame.BackColor = System.Drawing.Color.RoyalBlue;
            this.pbGame.Location = new System.Drawing.Point(16, 42);
            this.pbGame.Name = "pbGame";
            this.pbGame.Size = new System.Drawing.Size(480, 480);
            this.pbGame.TabIndex = 1;
            this.pbGame.TabStop = false;
            // 
            // tmrGoSnake
            // 
            this.tmrGoSnake.Tick += new System.EventHandler(this.tmrGoSnake_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.Location = new System.Drawing.Point(336, 6);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(55, 13);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score : 0";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 16);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(496, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 496);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 480);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(512, 16);
            this.label4.TabIndex = 6;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(511, 537);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbGame);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGame";
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGame_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniOyunToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator spToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duraklatToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator spToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pbGame;
        private System.Windows.Forms.Timer tmrGoSnake;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

