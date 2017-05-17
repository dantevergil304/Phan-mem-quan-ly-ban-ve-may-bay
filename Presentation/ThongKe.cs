using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicTier;

namespace Presentation
{
    public partial class ThongKe : Form
    {
        private ThongkeBUS ThongKeDoanhThu;
        public ThongKe()
        {
            InitializeComponent();
            ThongKeDoanhThu = new ThongkeBUS();          
        }

        private void setDoanhThuThangDataSource(DataTable table)
        {
            dataGridView1.Enabled = true;
            clearDataGridView(dataGridView1);
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.ValueType = typeof(Int32);
            col.HeaderText = "STT";
            dataGridView1.Columns.Add(col);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[1].HeaderText = "Chuyến bay";
            dataGridView1.Columns[2].HeaderText = "Số vé";
            dataGridView1.Columns[3].HeaderText = "Doanh thu";
            dataGridView1.Columns[4].HeaderText = "Tỷ lệ";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            dataGridView1.Enabled = false;
                
        }

        private void clearDataGridView(DataGridView dgv)
        {
            dgv.DataSource = null;
            if (dgv.Columns.Count >= 1)
                dgv.Columns.RemoveAt(0);
            dgv.Rows.Clear();
            dgv.Refresh();
        }

        private void setDoanhThuNamDataSource(DataTable table)
        {
            dataGridView2.Enabled = true;
            clearDataGridView(dataGridView2);
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.ValueType = typeof(Int32);
            col.HeaderText = "STT";
            dataGridView2.Columns.Add(col);
            dataGridView2.DataSource = table;
            dataGridView2.Columns[1].HeaderText = "Tháng";
            dataGridView2.Columns[2].HeaderText = "Số chuyến bay";
            dataGridView2.Columns[3].HeaderText = "Doanh thu";
            dataGridView2.Columns[4].HeaderText = "Tỷ lệ";
            for (int i = 0; i < dataGridView2.Rows.Count ; i++)
                dataGridView2.Rows[i].Cells[0].Value = i + 1;            
            dataGridView2.Enabled = false;
        }       
        
        //Xử lý biến cố của các control


        private void ThongKe_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy";
            dateTimePicker1.CustomFormat = "yyyy";
            //dateTimePicker1.ShowUpDown = true;
            //dateTimePicker1.ShowCheckBox = true;
            //dateTimePicker2.ShowUpDown = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;

            for (int i = 1; i <= 12; i++)
                ThangCombobox.Items.Add(i);
            ThangCombobox.SelectedIndex = 0;

            label9.Text = "";
            label10.Text = "";
        }
        

        private void XemButton_Click(object sender, EventArgs e)
        {
            DataTable table = ThongKeDoanhThu.LayDoanhThuThang((int)ThangCombobox.Items[ThangCombobox.SelectedIndex], (int)dateTimePicker1.Value.Year);
            label10.Text = ((int)ThangCombobox.Items[ThangCombobox.SelectedIndex]).ToString() + " năm " + ((int)dateTimePicker1.Value.Year).ToString();
            if (table.Rows.Count == 0)
            {
                label6.Visible = true;
                clearDataGridView(dataGridView1);
            }
            else
            {
                label6.Visible = false;
                setDoanhThuThangDataSource(table);
            }            
        }

        private void Xem2Button_Click(object sender, EventArgs e)
        {
            DataTable table = ThongKeDoanhThu.LayDoanhThuNam((int)dateTimePicker2.Value.Year);
            label9.Text = dateTimePicker2.Value.Year.ToString();
            if (table.Rows.Count == 0)
            {
                label4.Visible = true;
                clearDataGridView(dataGridView2);
            }
            else
            {
                label4.Visible = false;
                setDoanhThuNamDataSource(table);
            }
        }
        //Xử lý hiển thị GUI
        private void XemButton_MouseHover(object sender, EventArgs e)
        {
            XemButton.BackColor = Color.White;
            XemButton.ForeColor = Color.Black;
        }

        private void XemButton_MouseLeave(object sender, EventArgs e)
        {
            XemButton.BackColor = Color.Blue;
            XemButton.ForeColor = Color.White;
        }
        

        private void ThangButton_Click(object sender, EventArgs e)
        {
            ThangButton.BackColor = Color.White;
            ThangButton.ForeColor = Color.Black;
            NamButton.BackColor = Color.DeepSkyBlue;
            NamButton.ForeColor = Color.White;
            panel1.Visible = true;
            panel2.Visible = false;            

        }

        private void NamButton_Click(object sender, EventArgs e)
        {
            ThangButton.BackColor = Color.DeepSkyBlue;
            ThangButton.ForeColor = Color.White;
            NamButton.BackColor = Color.White;
            NamButton.ForeColor = Color.Black;
            panel1.Visible = false;
            panel2.Visible = true;
         
        }
       
        private void Xem2Button_MouseHover(object sender, EventArgs e)
        {
            Xem2Button.BackColor = Color.White;
            Xem2Button.ForeColor = Color.Black;
        }

        private void Xem2Button_MouseLeave(object sender, EventArgs e)
        {
            Xem2Button.BackColor = Color.Blue;
            Xem2Button.ForeColor = Color.White;
        }
              
    }
}
