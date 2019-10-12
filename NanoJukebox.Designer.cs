namespace Nano_Jukebox
{
    partial class NanoJukebox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NanoJukebox));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_LibrarySong = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Label_LibrarySongArtist = new System.Windows.Forms.Label();
            this.Label_LibrarySongTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label_LibraryPage = new System.Windows.Forms.Label();
            this.Button_LibraryNext = new System.Windows.Forms.PictureBox();
            this.Button_LibraryPrev = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Progress_NowPlaying = new System.Windows.Forms.ProgressBar();
            this.Label_NowPlayingArtist = new System.Windows.Forms.Label();
            this.Label_NowPlayingTitle = new System.Windows.Forms.Label();
            this.Image_NowPlaying = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.Panel_LibrarySong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_LibraryNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_LibraryPrev)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_NowPlaying)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Panel_LibrarySong);
            this.panel1.Controls.Add(this.Label_LibraryPage);
            this.panel1.Controls.Add(this.Button_LibraryNext);
            this.panel1.Controls.Add(this.Button_LibraryPrev);
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 286);
            this.panel1.TabIndex = 2;
            // 
            // Panel_LibrarySong
            // 
            this.Panel_LibrarySong.Controls.Add(this.label4);
            this.Panel_LibrarySong.Controls.Add(this.pictureBox3);
            this.Panel_LibrarySong.Controls.Add(this.Label_LibrarySongArtist);
            this.Panel_LibrarySong.Controls.Add(this.Label_LibrarySongTitle);
            this.Panel_LibrarySong.Controls.Add(this.pictureBox2);
            this.Panel_LibrarySong.Location = new System.Drawing.Point(0, 0);
            this.Panel_LibrarySong.Name = "Panel_LibrarySong";
            this.Panel_LibrarySong.Size = new System.Drawing.Size(190, 100);
            this.Panel_LibrarySong.TabIndex = 3;
            this.Panel_LibrarySong.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nunito Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Play With";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Nano_Jukebox.Properties.Resources.nano_mark;
            this.pictureBox3.Location = new System.Drawing.Point(76, 55);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(96, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // Label_LibrarySongArtist
            // 
            this.Label_LibrarySongArtist.AutoSize = true;
            this.Label_LibrarySongArtist.Font = new System.Drawing.Font("Nunito Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_LibrarySongArtist.ForeColor = System.Drawing.Color.White;
            this.Label_LibrarySongArtist.Location = new System.Drawing.Point(59, 25);
            this.Label_LibrarySongArtist.Name = "Label_LibrarySongArtist";
            this.Label_LibrarySongArtist.Size = new System.Drawing.Size(71, 18);
            this.Label_LibrarySongArtist.TabIndex = 2;
            this.Label_LibrarySongArtist.Text = "Song Artist";
            // 
            // Label_LibrarySongTitle
            // 
            this.Label_LibrarySongTitle.AutoSize = true;
            this.Label_LibrarySongTitle.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_LibrarySongTitle.ForeColor = System.Drawing.Color.White;
            this.Label_LibrarySongTitle.Location = new System.Drawing.Point(60, 4);
            this.Label_LibrarySongTitle.Name = "Label_LibrarySongTitle";
            this.Label_LibrarySongTitle.Size = new System.Drawing.Size(82, 21);
            this.Label_LibrarySongTitle.TabIndex = 1;
            this.Label_LibrarySongTitle.Text = "Song Title";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Label_LibraryPage
            // 
            this.Label_LibraryPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_LibraryPage.AutoSize = true;
            this.Label_LibraryPage.Font = new System.Drawing.Font("Nunito Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_LibraryPage.ForeColor = System.Drawing.Color.White;
            this.Label_LibraryPage.Location = new System.Drawing.Point(75, 265);
            this.Label_LibraryPage.Name = "Label_LibraryPage";
            this.Label_LibraryPage.Size = new System.Drawing.Size(49, 18);
            this.Label_LibraryPage.TabIndex = 2;
            this.Label_LibraryPage.Text = "Page 1";
            // 
            // Button_LibraryNext
            // 
            this.Button_LibraryNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_LibraryNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_LibraryNext.Image = global::Nano_Jukebox.Properties.Resources.next;
            this.Button_LibraryNext.Location = new System.Drawing.Point(39, 253);
            this.Button_LibraryNext.Name = "Button_LibraryNext";
            this.Button_LibraryNext.Size = new System.Drawing.Size(30, 30);
            this.Button_LibraryNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Button_LibraryNext.TabIndex = 1;
            this.Button_LibraryNext.TabStop = false;
            // 
            // Button_LibraryPrev
            // 
            this.Button_LibraryPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_LibraryPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_LibraryPrev.Image = global::Nano_Jukebox.Properties.Resources.prev;
            this.Button_LibraryPrev.Location = new System.Drawing.Point(3, 253);
            this.Button_LibraryPrev.Name = "Button_LibraryPrev";
            this.Button_LibraryPrev.Size = new System.Drawing.Size(30, 30);
            this.Button_LibraryPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Button_LibraryPrev.TabIndex = 0;
            this.Button_LibraryPrev.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nunito", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Now Playing";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.Progress_NowPlaying);
            this.panel2.Controls.Add(this.Label_NowPlayingArtist);
            this.panel2.Controls.Add(this.Label_NowPlayingTitle);
            this.panel2.Controls.Add(this.Image_NowPlaying);
            this.panel2.Location = new System.Drawing.Point(13, 429);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 160);
            this.panel2.TabIndex = 5;
            // 
            // Progress_NowPlaying
            // 
            this.Progress_NowPlaying.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Progress_NowPlaying.Location = new System.Drawing.Point(171, 109);
            this.Progress_NowPlaying.Name = "Progress_NowPlaying";
            this.Progress_NowPlaying.Size = new System.Drawing.Size(499, 23);
            this.Progress_NowPlaying.TabIndex = 8;
            // 
            // Label_NowPlayingArtist
            // 
            this.Label_NowPlayingArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_NowPlayingArtist.AutoSize = true;
            this.Label_NowPlayingArtist.Font = new System.Drawing.Font("Nunito Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NowPlayingArtist.ForeColor = System.Drawing.Color.White;
            this.Label_NowPlayingArtist.Location = new System.Drawing.Point(165, 51);
            this.Label_NowPlayingArtist.Name = "Label_NowPlayingArtist";
            this.Label_NowPlayingArtist.Size = new System.Drawing.Size(150, 36);
            this.Label_NowPlayingArtist.TabIndex = 7;
            this.Label_NowPlayingArtist.Text = "Song Artist";
            // 
            // Label_NowPlayingTitle
            // 
            this.Label_NowPlayingTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_NowPlayingTitle.AutoSize = true;
            this.Label_NowPlayingTitle.Font = new System.Drawing.Font("Nunito", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NowPlayingTitle.ForeColor = System.Drawing.Color.White;
            this.Label_NowPlayingTitle.Location = new System.Drawing.Point(163, 3);
            this.Label_NowPlayingTitle.Name = "Label_NowPlayingTitle";
            this.Label_NowPlayingTitle.Size = new System.Drawing.Size(178, 48);
            this.Label_NowPlayingTitle.TabIndex = 6;
            this.Label_NowPlayingTitle.Text = "Song Title";
            // 
            // Image_NowPlaying
            // 
            this.Image_NowPlaying.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Image_NowPlaying.Location = new System.Drawing.Point(3, 3);
            this.Image_NowPlaying.Name = "Image_NowPlaying";
            this.Image_NowPlaying.Size = new System.Drawing.Size(154, 154);
            this.Image_NowPlaying.TabIndex = 0;
            this.Image_NowPlaying.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(614, 674);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Powered by";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Nano_Jukebox.Properties.Resources.nano_full_white;
            this.pictureBox1.Location = new System.Drawing.Point(735, 657);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(875, 725);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Nano Jukebox";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Panel_LibrarySong.ResumeLayout(false);
            this.Panel_LibrarySong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_LibraryNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_LibraryPrev)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_NowPlaying)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar Progress_NowPlaying;
        private System.Windows.Forms.Label Label_NowPlayingArtist;
        private System.Windows.Forms.Label Label_NowPlayingTitle;
        private System.Windows.Forms.PictureBox Image_NowPlaying;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_LibraryPage;
        private System.Windows.Forms.PictureBox Button_LibraryNext;
        private System.Windows.Forms.PictureBox Button_LibraryPrev;
        private System.Windows.Forms.Panel Panel_LibrarySong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Label_LibrarySongArtist;
        private System.Windows.Forms.Label Label_LibrarySongTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

