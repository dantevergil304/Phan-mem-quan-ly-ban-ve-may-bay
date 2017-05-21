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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.ReadOnly = true;            
        }
        private void clearDataGridView(DataGridView dgv)
        {
            dgv.DataSource = null;
            if (dgv.Columns.Count >= 1)
                dgv.Columns.RemoveAt(0);
            dgv.Rows.Clear();
            dgv.Refresh();
        }

        private void setDataSourceToThongTinChuyenBay(DataTable table)
        {
            dataGridView1.Enabled = true;
            clearDataGridView(dataGridView1);
            DataGridViewTextBoxColumn stt = new DataGridViewTextBoxColumn();
            stt.ValueType = typeof(Int32);
            stt.HeaderText = "STT";
            dataGridView1.Columns.Add(stt);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[1].HeaderText = "Mã chuyến bay";
            dataGridView1.Columns[2].HeaderText = "Tuyến bay";
            dataGridView1.Columns[3].HeaderText = "Ngày giờ bay";
            dataGridView1.Columns[4].HeaderText = "Thời gian bay";
            dataGridView1.Columns[5].HeaderText = "Số lượng ghế hạng 1";
            dataGridView1.Columns[6].HeaderText = "Số lượng ghế hạng 2";            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
            dataGridView1.Enabled = false;
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
            ActiveControl = SearchTextBox;
            setDataSourceToThongTinChuyenBay(QuanlychuyenbayBUS.LayThongTinTatCaChuyenBay());
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
