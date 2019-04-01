using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    class Management : Form
    {
        WMPLib.WindowsMediaPlayer Player;
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        Form1 form1 = new Form1();
        ListView list;
        List<String> paths;
        public Management(ListView l, List<String> paths)
        {
            list = l;
            this.paths = paths;
        }

        public void Add() {
            try
            {
                openFileDialog1.Filter = "(mp3)|*.mp3;";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string dir = Path.Combine(Application.StartupPath, @"Music\");
                    File.Copy(openFileDialog1.FileName, dir + Path.GetFileName(openFileDialog1.FileName));
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong with the file or the folder");
            }
        }

        public void Delete(int i)
        {
            if (System.IO.File.Exists(paths[i - 1]))
            {
                try
                {
                    System.IO.File.Delete(paths[i - 1]);
                }
                catch (System.IO.IOException e)
                {
                    MessageBox.Show("File does not exist!");
                }
            }
        }
        public void Edit(int i)
        {
            try
            {
                EditForm ed = new EditForm(paths[i - 1]);
                ed.Show();
            }
            catch {
                MessageBox.Show("This song does not exist!");
            }
        }
    }
}
