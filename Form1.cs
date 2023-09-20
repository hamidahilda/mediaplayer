using AxWMPLib;
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

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        List<string> path = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {

        }

        private void bunifuButton3_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            indikator.Top = bunifuButton1.Top + 0;
        }

        private void bunifuButton3_Click_2(object sender, EventArgs e)
        {
            indikator.Top = bunifuButton1.Top + 60;

            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "All Files | *.*";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    path.Add(openFileDialog1.FileNames[i]);
                    Playlist.Items.Add(Path.GetFileNameWithoutExtension(openFileDialog1.FileNames[i]));       
                }
               axWindowsMediaPlayer1.URL = openFileDialog1.FileNames[0];
            }
           
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            indikator.Top = bunifuButton1.Top + 113;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            indikator.Top = bunifuButton1.Top + 170;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.URL = path[Playlist.SelectedIndex];
            }
            catch (Exception e3) {
                MessageBox.Show(e3.Message);
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void indikator_ShapeChanged(object sender, Bunifu.UI.WinForms.BunifuShapes.ShapeChangedEventArgs e)
        {

        }
    }
}
