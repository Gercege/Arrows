namespace Arrows
{
    partial class Arrows
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arrows));
            upa = new PictureBox();
            righta = new PictureBox();
            downa = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            scorea = new Label();
            timetext = new Label();
            timea = new Label();
            scoretext = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            Left = new Label();
            lefta = new PictureBox();
            menuStrip1 = new MenuStrip();
            easyToolStripMenuItem = new ToolStripMenuItem();
            easyToolStripMenuItem1 = new ToolStripMenuItem();
            mediumToolStripMenuItem1 = new ToolStripMenuItem();
            hardToolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)upa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)righta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)downa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lefta).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // upa
            // 
            upa.Image = (Image)resources.GetObject("upa.Image");
            upa.Location = new Point(191, 84);
            upa.Name = "upa";
            upa.Size = new Size(100, 100);
            upa.SizeMode = PictureBoxSizeMode.StretchImage;
            upa.TabIndex = 1;
            upa.TabStop = false;
            // 
            // righta
            // 
            righta.Image = (Image)resources.GetObject("righta.Image");
            righta.Location = new Point(297, 190);
            righta.Name = "righta";
            righta.Size = new Size(100, 100);
            righta.SizeMode = PictureBoxSizeMode.StretchImage;
            righta.TabIndex = 2;
            righta.TabStop = false;
            // 
            // downa
            // 
            downa.Image = (Image)resources.GetObject("downa.Image");
            downa.Location = new Point(191, 296);
            downa.Name = "downa";
            downa.Size = new Size(100, 100);
            downa.SizeMode = PictureBoxSizeMode.StretchImage;
            downa.TabIndex = 3;
            downa.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 375;
            timer1.Tick += timer1_Tick;
            // 
            // scorea
            // 
            scorea.AutoSize = true;
            scorea.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            scorea.Location = new Point(288, 24);
            scorea.Name = "scorea";
            scorea.Size = new Size(29, 32);
            scorea.TabIndex = 5;
            scorea.Text = "0";
            // 
            // timetext
            // 
            timetext.AutoSize = true;
            timetext.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            timetext.Location = new Point(201, 188);
            timetext.Name = "timetext";
            timetext.Size = new Size(81, 32);
            timetext.TabIndex = 7;
            timetext.Text = "Time";
            // 
            // timea
            // 
            timea.AutoSize = true;
            timea.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            timea.Location = new Point(222, 252);
            timea.Name = "timea";
            timea.Size = new Size(29, 32);
            timea.TabIndex = 8;
            timea.Text = "0";
            // 
            // scoretext
            // 
            scoretext.AutoSize = true;
            scoretext.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            scoretext.Location = new Point(112, 24);
            scoretext.Name = "scoretext";
            scoretext.Size = new Size(90, 32);
            scoretext.TabIndex = 10;
            scoretext.Text = "Score";
            // 
            // timer2
            // 
            timer2.Interval = 250;
            timer2.Tick += timer2_Tick;
            // 
            // Left
            // 
            Left.AutoSize = true;
            Left.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Left.Location = new Point(209, 220);
            Left.Name = "Left";
            Left.Size = new Size(64, 32);
            Left.TabIndex = 14;
            Left.Text = "Left";
            // 
            // lefta
            // 
            lefta.Image = (Image)resources.GetObject("lefta.Image");
            lefta.Location = new Point(85, 190);
            lefta.Name = "lefta";
            lefta.Size = new Size(100, 100);
            lefta.SizeMode = PictureBoxSizeMode.StretchImage;
            lefta.TabIndex = 15;
            lefta.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { easyToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(484, 24);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // easyToolStripMenuItem
            // 
            easyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { easyToolStripMenuItem1, mediumToolStripMenuItem1, hardToolStripMenuItem1 });
            easyToolStripMenuItem.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            easyToolStripMenuItem.Size = new Size(47, 20);
            easyToolStripMenuItem.Text = "Start";
            // 
            // easyToolStripMenuItem1
            // 
            easyToolStripMenuItem1.Name = "easyToolStripMenuItem1";
            easyToolStripMenuItem1.Size = new Size(119, 22);
            easyToolStripMenuItem1.Text = "Easy";
            easyToolStripMenuItem1.Click += easyToolStripMenuItem1_Click;
            // 
            // mediumToolStripMenuItem1
            // 
            mediumToolStripMenuItem1.Name = "mediumToolStripMenuItem1";
            mediumToolStripMenuItem1.Size = new Size(119, 22);
            mediumToolStripMenuItem1.Text = "Medium";
            mediumToolStripMenuItem1.Click += mediumToolStripMenuItem1_Click;
            // 
            // hardToolStripMenuItem1
            // 
            hardToolStripMenuItem1.Name = "hardToolStripMenuItem1";
            hardToolStripMenuItem1.Size = new Size(119, 22);
            hardToolStripMenuItem1.Text = "Hard";
            hardToolStripMenuItem1.Click += hardToolStripMenuItem1_Click;
            // 
            // Arrows
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(484, 461);
            Controls.Add(menuStrip1);
            Controls.Add(lefta);
            Controls.Add(Left);
            Controls.Add(scoretext);
            Controls.Add(timea);
            Controls.Add(timetext);
            Controls.Add(scorea);
            Controls.Add(downa);
            Controls.Add(righta);
            Controls.Add(upa);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "Arrows";
            Text = "Arrows";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)upa).EndInit();
            ((System.ComponentModel.ISupportInitialize)righta).EndInit();
            ((System.ComponentModel.ISupportInitialize)downa).EndInit();
            ((System.ComponentModel.ISupportInitialize)lefta).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox upa;
        private PictureBox righta;
        private PictureBox downa;
        private System.Windows.Forms.Timer timer1;
        private Label scorea;
        private Label timetext;
        private Label timea;
        private Label scoretext;
        private System.Windows.Forms.Timer timer2;
        private Label Left;
        private PictureBox lefta;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem easyToolStripMenuItem;
        private ToolStripMenuItem easyToolStripMenuItem1;
        private ToolStripMenuItem mediumToolStripMenuItem1;
        private ToolStripMenuItem hardToolStripMenuItem1;
    }
}