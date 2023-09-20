using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class belajar : Form
    {
        public belajar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lagu = {"balonku ada 5", "pelangi pelagi", "topi saya bundar", "bintang kecil"};
            foreach  (string item in lagu)
            {
                Console.WriteLine(item);
            }
        }
    }
}
