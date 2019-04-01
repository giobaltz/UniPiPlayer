using Music_Player.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        Panel settings,management;
        string music_path;
        bool move = false;
        bool play = false;
        bool set = false,man = false;
        int moveX, moveY, music_number;
        TextBox t;
        Random r = new Random();
        ComboBox Colors,Actions;
        Button apply, reset, okey;
        List<string> paths = new List<string>();
        List<int> song_number = new List<int>();
        List<int> durations = new List<int>();
        WMPLib.WindowsMediaPlayer Player;

        private void MovementPanel_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            moveX = e.X;
            moveY = e.Y;
        }

        private void MovementPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X-moveX,MousePosition.Y-moveY);
            }
        }

        private void MovementPanel_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Play_Pause_Click(object sender, EventArgs e)
        {
            if(Next.Enabled == false)
            {
                Next.Enabled = true;
                Back.Enabled = true;
            }
            if (play)
            {
                Player.controls.pause();
                ProgressTimer.Stop();
                Play_Pause.BackgroundImage = Resources.play;
                play = false;
            }
            else
            {
                if (music_path == null)
                {
                    if (listView1.Items.Count!= 0)
                    {
                        fun_play(true);
                    }
                    else
                    {
                        MessageBox.Show("There is no music!\n Please select from Explore");
                        Next.Enabled = false;
                        Back.Enabled = false;
                    }
                }
                else
                {
                    Player.controls.play();
                    ProgressTimer.Start();
                    Mp3Lib.Mp3File file = new Mp3Lib.Mp3File(music_path);
                    if (file.TagHandler.Picture == null)
                    {
                        pictureBox1.Image = Resources.Music_icon;
                    }
                    else
                    {
                        pictureBox1.Image = file.TagHandler.Picture;
                    }
                    Play_Pause.BackgroundImage = Resources.pause;
                    Title_Label.Text = Path.GetFileNameWithoutExtension(music_path);
                    play = true;
                }
            }
        }

        private void fun_play(bool flag)
        {
            int num;
            if (flag)
            {
                num = 0;
            }
            else
            {
                num = r.Next(0, paths.Count);
            }
            music_path = paths[num];
            music_number = num;
            PlayFile(music_path);
            Mp3Lib.Mp3File file = new Mp3Lib.Mp3File(music_path);
            if (file.TagHandler.Picture == null)
            {
                pictureBox1.Image = Resources.Music_icon;
            }
            else
            {
                pictureBox1.Image = file.TagHandler.Picture;
            }
            Player.controls.play();
            var tfile = TagLib.File.Create(music_path);
            label1.Text = tfile.Properties.Duration.ToString(@"mm\:ss");
            Title_Label.Text = Path.GetFileNameWithoutExtension(music_path);
            progressBar1.Maximum = durations[paths.IndexOf(music_path)];
            ProgressTimer.Start();
            Play_Pause.BackgroundImage = Resources.pause;
            play = true;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Resources.Music_icon;
                Player.controls.stop();
                play = false;
                Play_Pause.BackgroundImage = Resources.play;
                ProgressTimer.Stop();
                progressBar1.Value = 0;
                Title_Label.Text = "Select Song";
                label1.Text = "00:00";
                label2.Text = "00:00";
            }
            catch { }
        }

        private void Random_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count != 0)
            {
                if(Random.ForeColor == Color.Red)
                {
                    Random.ForeColor = Color.Green;
                }
                else
                {
                    Random.ForeColor = Color.Red;
                }
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Search.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshLoad();
            panel3.Height = Play.Height;
            panel3.Top = Play.Top;
            Next.Enabled = false;
            Back.Enabled = false;
        }

        public void PlayFile(String url)
        {
            Player = new WMPLib.WindowsMediaPlayer();
            Player.MediaError += new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
            Player.URL = url;
            Player.controls.play();
        }

        private void refreshLoad()
        {
            try
            {
                listView1.Items.Clear();
                paths.Clear();
                String dir = Application.StartupPath + @"\Music";
                String[] members = Directory.GetFiles(dir, "*.mp3");
                int i = 1;
                foreach (String s in members)
                {
                    paths.Add(s);
                    Mp3Lib.Mp3File file = new Mp3Lib.Mp3File(s);
                    string title = file.TagHandler.Title;
                    if (title == "")
                    {
                        title = Path.GetFileName(s);
                    }
                    string artist = file.TagHandler.Artist;
                    var tfile = TagLib.File.Create(s);
                    string length = tfile.Properties.Duration.ToString(@"hh\:mm\:ss");
                    TimeSpan time = tfile.Properties.Duration;
                    durations.Add((int)time.TotalSeconds);
                    string year = file.TagHandler.Year;
                    string language = "";
                    string kind_of_mysic = file.TagHandler.Genre;
                    string[] row = { i.ToString(), title, artist, length, year, language, kind_of_mysic };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    i++;
                }
            }
            catch
            {
                Directory.CreateDirectory(Application.StartupPath + @"\Music");
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            try
            {

                if (Next.Enabled == false)
                {
                    Next.Enabled = true;
                    Back.Enabled = true;
                }
                ListViewItem item = listView1.FocusedItem;
                int index = int.Parse(item.SubItems[0].Text);
                index--;
                int counter = 0;
                String dir = Application.StartupPath + @"\Music";
                String[] members = Directory.GetFiles(dir, "*.mp3");
                foreach (String s in members)
                {
                    if (index == counter)
                    {
                        music_path = s;
                        music_number = index;
                        try
                        {
                            Player.controls.stop();
                        }
                        catch { }
                        PlayFile(music_path);
                        Mp3Lib.Mp3File file = new Mp3Lib.Mp3File(music_path);
                        if (file.TagHandler.Picture == null)
                        {
                            pictureBox1.Image = Resources.Music_icon;
                        }
                        else
                        {
                            pictureBox1.Image = file.TagHandler.Picture;
                        }
                        Play_Pause.BackgroundImage = Resources.pause;
                        Title_Label.Text = Path.GetFileNameWithoutExtension(music_path);
                        progressBar1.Maximum = durations[paths.IndexOf(music_path)];
                        ProgressTimer.Start();
                        var tfile = TagLib.File.Create(music_path);
                        label1.Text = tfile.Properties.Duration.ToString(@"mm\:ss");
                        play = true;
                    }
                    counter++;
                }
            }
            catch
            {
                refreshLoad();
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if(Search.Focused == true)
            {
                Add();
                if(Search.Text != "")
                {
                    foreach (ListViewItem itemRow in this.listView1.Items)
                    {
                        if (itemRow.SubItems[0].Text.ToLower().Contains(Search.Text.ToLower())|| itemRow.SubItems[1].Text.ToLower().Contains(Search.Text.ToLower())|| itemRow.SubItems[2].Text.ToLower().Contains(Search.Text.ToLower())|| itemRow.SubItems[3].Text.ToLower().Contains(Search.Text.ToLower())|| itemRow.SubItems[4].Text.ToLower().Contains(Search.Text.ToLower())|| itemRow.SubItems[5].Text.ToLower().Contains(Search.Text.ToLower())|| itemRow.SubItems[6].Text.ToLower().Contains(Search.Text.ToLower()))
                        {
                            itemRow.SubItems[0].BackColor = Color.FromArgb(64, 64, 64);
                            itemRow.SubItems[0].ForeColor = Color.FromArgb(0, 172, 233);
                        }
                        else
                        {
                            listView1.Items.Remove(itemRow);
                        }
                    }
                }
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            panel3.Height = Play.Height;
            panel3.Top = Play.Top;
            panel4.Visible = false;
            set = false;
            man = false;
            listView1.Controls.Remove(settings);
            listView1.Controls.Remove(management);
            refreshLoad();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            man = false;
            listView1.Controls.Remove(management);
            panel3.Height = Settings.Height;
            panel3.Top = Settings.Top;
            if (!set) {
                //Create panel
                settings = new Panel();
                settings.Location = new Point(0,0);
                settings.Size = new Size(767, 433);
                //Create label
                Label l = new Label();
                l.Location = new Point(35,7);
                l.AutoSize = true;
                l.Font=new Font("Corbel",Font.Size);
                l.Text = "Select:";
                //Create Combobox
                Colors = new ComboBox();
                Colors.FlatStyle = FlatStyle.Flat;
                Colors.Location = new Point(40, 46);
                Colors.Size = new Size(131, 34);
                Colors.Items.Add("Black");
                Colors.Items.Add("White");
                Colors.Items.Add("Red");
                Colors.Items.Add("Blue");
                //Create Buttons
                apply = new Button();
                apply.BackColor = Color.Transparent;
                apply.FlatStyle = FlatStyle.Flat;
                if (this.BackColor == Color.FromArgb(72, 72, 72))
                {
                    apply.ForeColor = Color.White;
                }
                else
                {
                    apply.ForeColor = Color.Black;
                }
                apply.Text = "Apply";
                apply.Location = new Point(40, 80);
                apply.Size = new Size(100, 30);

                reset = new Button();
                reset.BackColor = Color.Transparent;
                reset.FlatStyle = FlatStyle.Flat;
                if (this.BackColor == Color.FromArgb(72, 72, 72))
                {
                    reset.ForeColor = Color.White;
                }
                else {
                    reset.ForeColor = Color.Black;
                }
                reset.Text = "Reset";
                reset.Location = new Point(150, 80);
                reset.Size = new Size(100, 30);
                //Set everything
                listView1.Controls.Add(settings);
                panel4.Visible = true;
                panel4.Controls.Add(l);
                settings.Controls.Add(Colors);
                settings.Controls.Add(apply);
                settings.Controls.Add(reset);
                apply.Click += apply_Click;
                reset.Click += reset_Click;
                set = true;
            }
        }

        private void apply_Click(object sender, EventArgs e)
        {
            switch (Colors.SelectedItem)
            {
                case "Black":
                    this.BackColor =Color.FromArgb(72,72,72);
                    listView1.BackColor = Color.FromArgb(72, 72, 72);
                    Search.BackColor = Color.FromArgb(72, 72, 72);
                    settings.BackColor = Color.FromArgb(72, 72, 72);

                    Play_Pause.ForeColor = Color.FromArgb(95, 95, 95);
                    Back.ForeColor = Color.FromArgb(95, 95, 95);
                    Next.ForeColor = Color.FromArgb(95, 95, 95);
                    Stop.ForeColor = Color.FromArgb(95, 95, 95);
                    Random.BackColor = Color.FromArgb(95, 95, 95);
                    pictureBox1.BackColor = Color.FromArgb(95, 95, 95);
                    panel1.BackColor= Color.FromArgb(95, 95, 95);
                    listView1.ForeColor = Color.Snow;
                    panel3.BackColor = Color.Red;

                    Play.ForeColor = Color.White;
                    Management.ForeColor = Color.White;
                    Settings.ForeColor = Color.White;
                    Search.ForeColor = Color.White;
                    Title_Label.ForeColor = Color.White;
                    apply.ForeColor = Color.White;
                    reset.ForeColor = Color.White;
                    Exit.BackColor = Color.Red;
                    Exit.ForeColor = Color.Black;
                    Minimize.BackColor = Color.Yellow;
                    break;
                case "White":
                    this.BackColor = Color.FromArgb(238, 238, 238);
                    listView1.BackColor = Color.FromArgb(238, 238, 238);
                    Search.BackColor = Color.FromArgb(238, 238, 238);
                    settings.BackColor = Color.FromArgb(238, 238, 238);

                    Play_Pause.ForeColor = Color.FromArgb(224, 224, 224);
                    Back.ForeColor = Color.FromArgb(224, 224, 224);
                    Next.ForeColor = Color.FromArgb(224, 224, 224);
                    Stop.ForeColor = Color.FromArgb(224, 224, 224);
                    Random.BackColor = Color.FromArgb(224, 224, 224);
                    pictureBox1.BackColor = Color.FromArgb(224, 224, 224);
                    panel1.BackColor = Color.FromArgb(224, 224, 224);
                    listView1.ForeColor = Color.Black;
                    panel3.BackColor= Color.Black;

                    Play.ForeColor = Color.Black;
                    Management.ForeColor = Color.Black;
                    Settings.ForeColor = Color.Black;
                    Search.ForeColor = Color.Black;
                    Title_Label.ForeColor = Color.Black;
                    apply.ForeColor = Color.Black;
                    reset.ForeColor = Color.Black;
                    Exit.BackColor = Color.Black;
                    Exit.ForeColor = Color.White;
                    Minimize.BackColor = Color.White;
                    break;
                case "Red":
                    this.BackColor = Color.FromArgb(244, 67, 54);
                    listView1.BackColor = Color.FromArgb(244, 67, 54);
                    Search.BackColor = Color.FromArgb(244, 67, 54);
                    settings.BackColor = Color.FromArgb(244, 67, 54);

                    Play_Pause.ForeColor = Color.FromArgb(183, 28, 28);
                    Back.ForeColor = Color.FromArgb(183, 28, 28);
                    Next.ForeColor = Color.FromArgb(183, 28, 28);
                    Stop.ForeColor = Color.FromArgb(183, 28, 28);
                    Random.BackColor = Color.FromArgb(183, 28, 28);
                    pictureBox1.BackColor = Color.FromArgb(183, 28, 28);
                    panel1.BackColor = Color.FromArgb(183, 28, 28);
                    listView1.ForeColor = Color.Snow;
                    panel3.BackColor = Color.FromArgb(183, 28, 28);

                    Play.ForeColor = Color.Black;
                    Management.ForeColor = Color.Black;
                    Settings.ForeColor = Color.Black;
                    Search.ForeColor = Color.Black;
                    Title_Label.ForeColor = Color.Black;
                    apply.ForeColor = Color.Black;
                    reset.ForeColor = Color.Black;
                    Exit.BackColor = Color.Red;
                    Exit.ForeColor = Color.Black;
                    Minimize.BackColor = Color.Yellow;
                    break;
                case "Blue":
                    this.BackColor = Color.SteelBlue;
                    listView1.BackColor = Color.SteelBlue;
                    Search.BackColor = Color.SteelBlue;
                    settings.BackColor = Color.SteelBlue;

                    Play_Pause.ForeColor = Color.FromArgb(21, 101, 192);
                    Back.ForeColor = Color.FromArgb(21, 101, 192);
                    Next.ForeColor = Color.FromArgb(21, 101, 192);
                    Stop.ForeColor = Color.FromArgb(21, 101, 192);
                    Random.BackColor = Color.FromArgb(21, 101, 192);
                    pictureBox1.BackColor = Color.FromArgb(21, 101, 192);
                    panel1.BackColor = Color.FromArgb(21, 101, 192);
                    listView1.ForeColor = Color.Snow;
                    panel3.BackColor = Color.FromArgb(21, 101, 192);

                    Play.ForeColor = Color.Black;
                    Management.ForeColor = Color.Black;
                    Settings.ForeColor = Color.Black;
                    Search.ForeColor = Color.Black;
                    Title_Label.ForeColor = Color.Black;
                    apply.ForeColor = Color.Black;
                    reset.ForeColor = Color.Black;
                    Exit.BackColor = Color.SteelBlue;
                    Exit.ForeColor = Color.Black;
                    Minimize.BackColor = Color.FromArgb(227,242,253);
                    break;
                default:
                    MessageBox.Show("Please select a color");
                    break;
            }
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = (int)Player.controls.currentPosition;
            TimeSpan time=TimeSpan.FromSeconds((int)Player.controls.currentPosition);
            label2.Text = time.ToString("mm':'ss");
            if (progressBar1.Maximum <= progressBar1.Value+2)
            {
                ProgressTimer.Stop();
                Stop.PerformClick();
                if(Random.ForeColor == Color.Red)
                {
                    Next.PerformClick();
                }
                else
                {
                    fun_play(false);
                }
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            try
            {
                if (Random.ForeColor == Color.Red)
                {
                    if (music_number < listView1.Items.Count - 1)
                    {
                        music_number += 1;
                    }
                    else
                    {
                        music_number = 0;
                    }
                    music_path = paths[music_number];
                    Player.controls.stop();
                    PlayFile(music_path);
                    Mp3Lib.Mp3File file = new Mp3Lib.Mp3File(music_path);
                    Title_Label.Text = Path.GetFileNameWithoutExtension(music_path);
                    if (file.TagHandler.Picture == null)
                    {
                        pictureBox1.Image = Resources.Music_icon;
                    }
                    else
                    {
                        pictureBox1.Image = file.TagHandler.Picture;
                    }
                    Player.controls.play();
                    ProgressTimer.Start();
                    Play_Pause.BackgroundImage = Resources.pause;
                    var tfile = TagLib.File.Create(music_path);
                    label1.Text = tfile.Properties.Duration.ToString(@"mm\:ss");
                    play = true;
                }
                else
                {
                    Player.controls.stop();
                    fun_play(false);
                }
            }
            catch { }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            try
            {
                if(Random.ForeColor == Color.Red)
                {
                    if (music_number > 0)
                    {
                        music_number -= 1;
                    }
                    else
                    {
                        music_number = listView1.Items.Count - 1;
                    }
                    music_path = paths[music_number];
                    Player.controls.stop();
                    PlayFile(music_path);
                    Mp3Lib.Mp3File file = new Mp3Lib.Mp3File(music_path);
                    Title_Label.Text = Path.GetFileNameWithoutExtension(music_path);
                    if (file.TagHandler.Picture == null)
                    {
                        pictureBox1.Image = Resources.Music_icon;
                    }
                    else
                    {
                        pictureBox1.Image = file.TagHandler.Picture;
                    }
                    Player.controls.play();
                    ProgressTimer.Start();
                    Play_Pause.BackgroundImage = Resources.pause;
                    var tfile = TagLib.File.Create(music_path);
                    label1.Text = tfile.Properties.Duration.ToString(@"mm\:ss");
                    play = true;
                }
                else
                {
                    Player.controls.stop();
                    fun_play(false);
                }
                
            }
            catch { }
        }

        private void Search_Leave(object sender, EventArgs e)
        {
            Search.Text = "Search";
        }

        private void Management_Click(object sender, EventArgs e)
        {
            set = false;
            listView1.Controls.Remove(settings);
            panel3.Height = Management.Height;
            panel3.Top = Management.Top;
            if (!man)
            {
                //Create panel
                management = new Panel();
                management.BackColor = listView1.BackColor;
                management.Location = new Point(0, 0);
                management.Size = new Size(767, 433);
                //Create label
                Label l2 = new Label();
                l2.Location = new Point(35, 7);
                l2.AutoSize = true;
                l2.Font = new Font("Corbel", Font.Size);
                l2.Text = "Select:";
                //Create Combobox
                Actions = new ComboBox();
                Actions.FlatStyle = FlatStyle.Flat;
                Actions.Location = new Point(40, 46);
                Actions.Size = new Size(131, 34);
                Actions.Items.Add("Add");
                Actions.Items.Add("Edit");
                Actions.Items.Add("Remove/Delete");
                //Create Buttons
                okey = new Button();
                okey.BackColor = Color.Transparent;
                okey.FlatStyle = FlatStyle.Flat;
                if (this.BackColor == Color.FromArgb(72, 72, 72))
                {
                    okey.ForeColor = Color.White;
                }
                else
                {
                    okey.ForeColor = Color.Black;
                }
                okey.Text = "OK";
                okey.Location = new Point(40, 80);
                okey.Size = new Size(100, 30);
                //Create textbox
                t = new TextBox();
                t.Text = "Song Number";
                t.Location=new Point(174, 46);
                //Set everything
                listView1.Controls.Add(management);
                panel4.Visible = true;
                panel4.Controls.Add(l2);
                management.Controls.Add(Actions);
                management.Controls.Add(t);
                management.Controls.Add(okey);
                okey.Click += okey_Click;
                man = true;
            }
            refreshLoad();
        }
        private void okey_Click(object sender, EventArgs e)
        {
            Management m = new Management(listView1, paths);
            switch (Actions.SelectedItem)
            {
                case ("Add"):
                    m.Add();
                    break;
                case ("Edit"):
                    try
                    {
                        m.Edit(int.Parse(t.Text));
                    }
                    catch {
                        MessageBox.Show("Give the song number");
                        t.Text = "";
                    }
                    break;
                case ("Remove/Delete"):
                    try {
                        m.Delete(int.Parse(t.Text));
                        MessageBox.Show("The song removed");
                        Play.PerformClick();
                    }
                    catch
                    {
                        MessageBox.Show("Give the song number");
                        t.Text = "";
                    }
                    break;
                default:
                    break;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Colors.SelectedItem ="Black";
            apply.PerformClick();
        }

        private void Add() {
            listView1.Items.Clear();
            paths.Clear();
            String dir = Application.StartupPath + @"\Music";
            String[] members = Directory.GetFiles(dir, "*.mp3");
            int i = 1;
            foreach (String s in members)
            {
                paths.Add(s);
                Mp3Lib.Mp3File file = new Mp3Lib.Mp3File(s);
                string title = file.TagHandler.Title;
                if (title == "")
                {
                    title = Path.GetFileName(s);
                }
                string artist = file.TagHandler.Artist;
                var tfile = TagLib.File.Create(s);
                string length = tfile.Properties.Duration.ToString(@"hh\:mm\:ss");
                TimeSpan time = tfile.Properties.Duration;
                durations.Add((int)time.TotalSeconds);
                string year = file.TagHandler.Year;
                string language = "";
                string kind_of_mysic = file.TagHandler.Genre;
                string[] row = { i.ToString(), title, artist, length, year, language, kind_of_mysic };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                i++;
            }
        }

        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show("Cannot play media file.");
            this.Close();
        }
    }
}
