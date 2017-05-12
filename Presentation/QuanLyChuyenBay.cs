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

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ThemButton_MouseHover(object sender, EventArgs e)
        {
            ThemButton.BackColor = Color.White;            
        }

        private void CapNhapButton_Click(object sender, EventArgs e)
        {

        }

        private void XemChiTietButton_Click(object sender, EventArgs e)
        {

        }

        private void ThemButton_MouseLeave(object sender, EventArgs e)
        {
            ThemButton.BackColor = Color.Aquamarine;         
        }

        private void XoaButton_MouseHover(object sender, EventArgs e)
        {
            XoaButton.BackColor = Color.White;
        }

        private void XoaButton_MouseLeave(object sender, EventArgs e)
        {
            XoaButton.BackColor = Color.Aquamarine;
        }

        private void CapNhapButton_MouseLeave(object sender, EventArgs e)
        {
            CapNhapButton.BackColor = Color.Aquamarine;
        }

        private void CapNhapButton_MouseHover(object sender, EventArgs e)
        {
            CapNhapButton.BackColor = Color.White;
        }
              
    }
}
