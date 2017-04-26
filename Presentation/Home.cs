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

        private void NHAPLICHBox_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            NhapThongTinChuyenBay f = new NhapThongTinChuyenBay();
            f.RefToHome = this;
            f.Show();
        }

        private void BANVEBox_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BanVe f = new BanVe();
            f.RefToHome = this;
            f.Show();
        }

        private void DATVEBox_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DatVe f = new DatVe();
            f.RefToHome = this;
            f.Show();
        }

        private void TRACUUBox_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TraCuu f = new TraCuu();
            f.RefToHome = this;
            f.Show();
        }

        private void BAOCAOBox_Click(object sender, EventArgs e)
        {

        }

        private void THAYDOIBoX_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        
        
    }
}
