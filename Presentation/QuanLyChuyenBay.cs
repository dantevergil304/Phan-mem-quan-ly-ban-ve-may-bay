using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BusinessLogicTier;

namespace Presentation
{
    public partial class QuanLyChuyenBay : Form
    {
        private QuanlychuyenbayBUS QuanlychuyenbayBUS;
        public QuanLyChuyenBay()
        {
            InitializeComponent();
            QuanlychuyenbayBUS = new QuanlychuyenbayBUS();
        }

        private void setColumnHeaderWithDataSource1(DataTable table){
            dataGridView1.DataSource = table;
        }

        private void setColumnHeaderWithDataSource2(DataTable table)
        {
            dataGridView2.DataSource = table;
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            NhapThongTinChuyenBay f = new NhapThongTinChuyenBay();
            f.ShowDialog();
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyChuyenBay_Load(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        
    }
}
