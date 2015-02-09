namespace Mp3PlayerForms
{
    partial class Form1
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
            this.listBoxGenres = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxArtists = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Albums = new System.Windows.Forms.Label();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxGenres
            // 
            this.listBoxGenres.FormattingEnabled = true;
            this.listBoxGenres.Location = new System.Drawing.Point(30, 40);
            this.listBoxGenres.Name = "listBoxGenres";
            this.listBoxGenres.Size = new System.Drawing.Size(120, 238);
            this.listBoxGenres.TabIndex = 0;
            this.listBoxGenres.SelectedIndexChanged += new System.EventHandler(this.listBoxGenres_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Genres";
            // 
            // listBoxArtists
            // 
            this.listBoxArtists.FormattingEnabled = true;
            this.listBoxArtists.Location = new System.Drawing.Point(167, 40);
            this.listBoxArtists.Name = "listBoxArtists";
            this.listBoxArtists.Size = new System.Drawing.Size(178, 238);
            this.listBoxArtists.TabIndex = 2;
            this.listBoxArtists.SelectedIndexChanged += new System.EventHandler(this.listBoxArtists_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Artists";
            // 
            // Albums
            // 
            this.Albums.AutoSize = true;
            this.Albums.Location = new System.Drawing.Point(434, 24);
            this.Albums.Name = "Albums";
            this.Albums.Size = new System.Drawing.Size(41, 13);
            this.Albums.TabIndex = 4;
            this.Albums.Text = "Albums";
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(365, 40);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(188, 238);
            this.listBoxAlbums.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 355);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.Albums);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxArtists);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxGenres);
            this.Name = "Form1";
            this.Text = "Mp3Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGenres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxArtists;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Albums;
        private System.Windows.Forms.ListBox listBoxAlbums;

    }
}

