using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class EditForm : Form
    {
        string path;
        public EditForm(String path)
        {
            InitializeComponent();
            this.path = path;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            Mp3Lib.Mp3File file = new Mp3Lib.Mp3File(path);
            textBox1.Text = file.TagHandler.Title;
            textBox2.Text = file.TagHandler.Artist;
            textBox3.Text = file.TagHandler.Year;
            textBox4.Text = file.TagHandler.Genre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var tfile = TagLib.File.Create(path);
                tfile.Tag.Title = textBox1.Text;
                tfile.Tag.Year = Convert.ToUInt32(textBox3.Text);
                tfile.Save();
                this.Hide();
            }
            catch {
                MessageBox.Show("The changes can't saved");
            }
        }
    }
}
