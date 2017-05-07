using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyChuyenBay f = new QuanLyChuyenBay();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TraCuu f = new TraCuu();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BanVeVaDatCho f = new BanVeVaDatCho();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThongKe f = new ThongKe();
            f.ShowDialog();
        }        
    }
}
