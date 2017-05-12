﻿using System;
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
using DataAccessTier;

namespace Presentation
{
    public partial class TraCuu : Form
    {
        private TracuuBUS tracuuBUS;
        private DataTable DanhSachSanBayDi;
        private DataTable DanhSachSanBayDen;        
        public TraCuu()
        {
            InitializeComponent();
            tracuuBUS = new TracuuBUS();
            DanhSachSanBayDen = tracuuBUS.LayDanhSachSanBay();
            DanhSachSanBayDi = tracuuBUS.LayDanhSachSanBay();

            SBDIBox.DataSource = DanhSachSanBayDi;
            SBDIBox.DisplayMember = "TENSANBAY";
            SBDIBox.ValueMember = "MASANBAY";

            SBDENBox.DataSource = DanhSachSanBayDen;
            SBDENBox.DisplayMember = "TENSANBAY";
            SBDENBox.ValueMember = "MASANBAY";
            
            
        }
        private void clearDataGridView(DataGridView dgv)
        {
            dgv.DataSource = null;
            if (dgv.Columns.Count >= 1)
                dgv.Columns.RemoveAt(0);
            dgv.Rows.Clear();
            dgv.Refresh();
        }
        
        private void setDataSourceToDataGridView(DataTable table){
            dataGridView1.Enabled = true;
            clearDataGridView(dataGridView1);
            DataGridViewTextBoxColumn stt = new DataGridViewTextBoxColumn();
            stt.ValueType = typeof(Int32);
            stt.HeaderText = "STT";
            dataGridView1.Columns.Add(stt);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[1].HeaderText = "Mã chuyến bay";
            dataGridView1.Columns[2].HeaderText = "Sân bay đi";
            dataGridView1.Columns[3].HeaderText = "Sân bay đến";
            dataGridView1.Columns[4].HeaderText = "Ngày khởi hành";
            dataGridView1.Columns[5].HeaderText = "Thời gian bay";
            dataGridView1.Columns[6].HeaderText = "Số ghế trống";
            dataGridView1.Columns[7].HeaderText = "Số ghế đã đặt";
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
            dataGridView1.Enabled = false;
        }
        

        private void TIMCBButton_Click(object sender, EventArgs e)
        {
                TuyenBay tuyenbay = new TuyenBay(SBDIBox.SelectedValue as string,SBDENBox.SelectedValue as string);
                DataTable table = tracuuBUS.LayThongTinChuyenBayTheoTuyenBay(tuyenbay, NGBAYDate.Value);
                if (table.Rows.Count == 0)
                {                                        
                    label5.Visible = true;
                    clearDataGridView(dataGridView1);
                }
                else
                {                                                            
                    label5.Visible = false;
                    setDataSourceToDataGridView(table);                    
                }
        }        

        private void TIMCBButton_MouseHover(object sender, EventArgs e)
        {
            TIMCBButton.BackColor = Color.White;            
        }

        private void TIMCBButton_MouseLeave(object sender, EventArgs e)
        {
            TIMCBButton.BackColor = Color.LimeGreen;
        }

        private void XemTatCaButton_Click(object sender, EventArgs e)
        {            
            setDataSourceToDataGridView(tracuuBUS.LayThongTinTatCaChuyenBay());            
        }

        private void XemTatCaButton_MouseHover(object sender, EventArgs e)
        {
            XemTatCaButton.BackColor = Color.White;
            XemTatCaButton.ForeColor = Color.Black;
        }

        private void XemTatCaButton_MouseLeave(object sender, EventArgs e)
        {
            XemTatCaButton.BackColor = Color.Blue;
            XemTatCaButton.ForeColor = Color.White;
        }        
    }
}
