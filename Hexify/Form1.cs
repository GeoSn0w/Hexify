using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hexify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Hooks to make the form movable. Thanks to https://www.codeproject.com/script/Membership/View.aspx?mid=99719
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Nada
        }

        private void hexify_Click(object sender, EventArgs e)
        {
            var StringGod = new StringBuilder();

            var bytes = Encoding.Unicode.GetBytes(stringFeed.Text);
            foreach (var eb in bytes)
            {
                StringGod.Append("0x" + eb.ToString("X2") + " ");
            }

            stringFeed.Text = StringGod.ToString();
        }

        private void unhexify_Click(object sender, EventArgs e)
        {
            string hexSource = stringFeed.Text;
            hexSource = hexSource.Replace("0x", "");
            hexSource = hexSource.Replace(" ", "");
            hexSource = hexSource.Replace("-", "");
            hexSource = hexSource.Replace("0X", "");

            byte[] textify = new byte[hexSource.Length / 2];
            for (int c = 0; c < textify.Length; c++)
            {
                textify[c] = Convert.ToByte(hexSource.Substring(c * 2, 2), 16);
            }
            stringFeed.Text = Encoding.Unicode.GetString(textify);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            AllowDrop = true;
            DragEnter += new DragEventHandler(Form1_DragEnter);
            DragDrop += new DragEventHandler(Form1_DragDrop);
        }
        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            stringFeed.Clear();
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files) {
                using (var streamReader = new StreamReader(file, Encoding.UTF8))
                {
                    stringFeed.Text = streamReader.ReadToEnd();
                }
            };
        }

        private void saveContentsToFile_Click(object sender, EventArgs e)
        {
            if (dumpMeup.ShowDialog() == DialogResult.OK && dumpMeup.FileName != "")
            {
                using (StreamWriter WriteMe = new StreamWriter(dumpMeup.OpenFile()))
                {
                    WriteMe.Write(stringFeed.Text);
                }
            }
        }

        private void stringFeed_Click(object sender, EventArgs e)
        {
           if (stringFeed.Text == "Gimme hex, gimme file, gimme that which I desire!")
            {
                stringFeed.Clear();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void clearTextFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stringFeed.Clear();
        }

        private void iconcreds_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The icon of the application is provided for free by Freepik on https://www.flaticon.com/free-icon/update_202459#term=update&page=1&position=48", "Icon Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void urlToME_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/FCE365");
        }
    }
}
