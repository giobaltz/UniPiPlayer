namespace Music_Player
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MovementPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Exit = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Random = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Title_Label = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Stop = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Play_Pause = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Language = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kind_Of_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Settings = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.TextBox();
            this.Play = new System.Windows.Forms.Button();
            this.Management = new System.Windows.Forms.Button();
            this.Search_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.MovementPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MovementPanel
            // 
            this.MovementPanel.BackColor = System.Drawing.Color.Transparent;
            this.MovementPanel.Controls.Add(this.Exit);
            this.MovementPanel.Controls.Add(this.Minimize);
            this.MovementPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovementPanel.Location = new System.Drawing.Point(0, 0);
            this.MovementPanel.Name = "MovementPanel";
            this.MovementPanel.Size = new System.Drawing.Size(919, 34);
            this.MovementPanel.TabIndex = 0;
            this.MovementPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovementPanel_MouseDown);
            this.MovementPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovementPanel_MouseMove);
            this.MovementPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MovementPanel_MouseUp);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Exit.Location = new System.Drawing.Point(3, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(34, 31);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Yellow;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.Location = new System.Drawing.Point(43, 3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(37, 31);
            this.Minimize.TabIndex = 1;
            this.Minimize.Text = "_";
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Random);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.Title_Label);
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Controls.Add(this.Stop);
            this.panel1.Controls.Add(this.Next);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.Play_Pause);
            this.panel1.Location = new System.Drawing.Point(152, 489);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 55);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(41, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "00:00";
            // 
            // Random
            // 
            this.Random.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.Random.BackgroundImage = global::Music_Player.Properties.Resources.random;
            this.Random.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Random.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Random.ForeColor = System.Drawing.Color.Red;
            this.Random.Location = new System.Drawing.Point(728, 26);
            this.Random.Margin = new System.Windows.Forms.Padding(5);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(27, 25);
            this.Random.TabIndex = 4;
            this.Random.UseVisualStyleBackColor = false;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(706, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "00:00";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(105, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(595, 17);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 7;
            // 
            // Title_Label
            // 
            this.Title_Label.ForeColor = System.Drawing.Color.White;
            this.Title_Label.Location = new System.Drawing.Point(178, 26);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(522, 26);
            this.Title_Label.TabIndex = 6;
            this.Title_Label.Text = "Select Song";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(207, 42);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(0, 0);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // Stop
            // 
            this.Stop.BackgroundImage = global::Music_Player.Properties.Resources.stop;
            this.Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.Stop.Location = new System.Drawing.Point(105, 26);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(24, 26);
            this.Stop.TabIndex = 3;
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Next
            // 
            this.Next.BackgroundImage = global::Music_Player.Properties.Resources.next;
            this.Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.Next.Location = new System.Drawing.Point(135, 26);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(25, 26);
            this.Next.TabIndex = 2;
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Back
            // 
            this.Back.BackgroundImage = global::Music_Player.Properties.Resources.back;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.Back.Location = new System.Drawing.Point(73, 26);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(26, 26);
            this.Back.TabIndex = 1;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Play_Pause
            // 
            this.Play_Pause.BackgroundImage = global::Music_Player.Properties.Resources.play;
            this.Play_Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Play_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play_Pause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.Play_Pause.Location = new System.Drawing.Point(6, 17);
            this.Play_Pause.Name = "Play_Pause";
            this.Play_Pause.Size = new System.Drawing.Size(33, 35);
            this.Play_Pause.TabIndex = 0;
            this.Play_Pause.UseVisualStyleBackColor = true;
            this.Play_Pause.Click += new System.EventHandler(this.Play_Pause_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(152, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 433);
            this.panel2.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.Title,
            this.Artist,
            this.Length,
            this.Year,
            this.Language,
            this.Kind_Of_Music});
            this.listView1.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.listView1.ForeColor = System.Drawing.Color.Snow;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(767, 433);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // Number
            // 
            this.Number.Text = "#";
            this.Number.Width = 27;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 100;
            // 
            // Artist
            // 
            this.Artist.Text = "Artist";
            this.Artist.Width = 127;
            // 
            // Length
            // 
            this.Length.Text = "Length";
            this.Length.Width = 127;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            this.Year.Width = 127;
            // 
            // Language
            // 
            this.Language.Text = "Language";
            this.Language.Width = 127;
            // 
            // Kind_Of_Music
            // 
            this.Kind_Of_Music.Text = "Kind of Music";
            this.Kind_Of_Music.Width = 127;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Settings.ForeColor = System.Drawing.Color.White;
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.Location = new System.Drawing.Point(0, 307);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(152, 72);
            this.Settings.TabIndex = 0;
            this.Settings.Text = "Settings";
            this.Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(3, 57);
            this.Search.Name = "Search";
            this.Search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Search.Size = new System.Drawing.Size(103, 40);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            this.Search.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play.FlatAppearance.BorderSize = 0;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Play.ForeColor = System.Drawing.Color.White;
            this.Play.Image = ((System.Drawing.Image)(resources.GetObject("Play.Image")));
            this.Play.Location = new System.Drawing.Point(0, 160);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(152, 72);
            this.Play.TabIndex = 11;
            this.Play.Text = "Play";
            this.Play.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Management
            // 
            this.Management.BackColor = System.Drawing.Color.Transparent;
            this.Management.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Management.FlatAppearance.BorderSize = 0;
            this.Management.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Management.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Management.ForeColor = System.Drawing.Color.White;
            this.Management.Image = ((System.Drawing.Image)(resources.GetObject("Management.Image")));
            this.Management.Location = new System.Drawing.Point(0, 229);
            this.Management.Name = "Management";
            this.Management.Size = new System.Drawing.Size(152, 72);
            this.Management.TabIndex = 10;
            this.Management.Text = "Management";
            this.Management.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Management.UseVisualStyleBackColor = false;
            this.Management.Click += new System.EventHandler(this.Management_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.BackgroundImage = global::Music_Player.Properties.Resources.search;
            this.Search_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Search_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Search_Button.Location = new System.Drawing.Point(106, 57);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(40, 33);
            this.Search_Button.TabIndex = 0;
            this.Search_Button.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 402);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(142, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 63);
            this.panel3.TabIndex = 1;
            // 
            // ProgressTimer
            // 
            this.ProgressTimer.Interval = 1000;
            this.ProgressTimer.Tick += new System.EventHandler(this.ProgressTimer_Tick);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(152, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(767, 46);
            this.panel4.TabIndex = 1;
            this.panel4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(919, 543);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Management);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MovementPanel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MovementPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MovementPanel;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Management;
        private System.Windows.Forms.Button Play_Pause;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Random;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Next;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Artist;
        private System.Windows.Forms.ColumnHeader Length;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader Language;
        private System.Windows.Forms.ColumnHeader Kind_Of_Music;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer ProgressTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
    }
}

