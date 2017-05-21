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
using System.Text.RegularExpressions;

namespace Presentation
{
    public partial class QuanLySanBayVaTuyenBay : Form
    {
        private QuanlysanbayvatuyenbayBUS QuanLy;

        private int flag; //Insert or update
        private int flag2;
        public QuanLySanBayVaTuyenBay()
        {         
            InitializeComponent();
            panel3.Visible = false;
            panel4.Visible = false;                        
            QuanLy = new QuanlysanbayvatuyenbayBUS();           
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;                      
        }

        private void QuanLySanBayVaTuyenBay_Load(object sender, EventArgs e)
        {
            setSanBayDataSource();
            setTuyenBayDataSource();
            SBDiComboBox.DataSource = QuanLy.LayDanhSachSanBay();
            SBDiComboBox.DisplayMember = "TENSANBAY";
            SBDiComboBox.ValueMember = "MASANBAY";
            SBDenComboBox.DataSource = QuanLy.LayDanhSachSanBay();
            SBDenComboBox.DisplayMember = "TENSANBAY";
            SBDenComboBox.ValueMember = "MASANBAY";
            MaSBtextBox.Text = ((int)dataGridView1.Rows[0].Cells[1].Value).ToString();
            MaTBtextBox.Text = ((int)dataGridView2.Rows[0].Cells[1].Value).ToString();
            flag = -1;
            flag2 = -1;
            dataGridView1.ReadOnly = true;
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

        private void setSanBayDataSource()
        {            
            clearDataGridView(dataGridView1);
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = "STT";
            col.ValueType = typeof(Int32);
            col.DefaultCellStyle.BackColor = Color.White;
            col.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns.Add(col);
            dataGridView1.DataSource = QuanLy.LayDanhSachSanBay();
            dataGridView1.Columns[1].HeaderText = "Mã sân bay";
            dataGridView1.Columns[2].HeaderText = "Tên sân bay";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }            
        }

        private void setTuyenBayDataSource()
        {            
            clearDataGridView(dataGridView2);
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = "STT";
            col.ValueType = typeof(Int32);
            dataGridView2.Columns.Add(col);
            col.DefaultCellStyle.BackColor = Color.White;
            col.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView2.DataSource = QuanLy.LayDanhSachTuyenBay();
            dataGridView2.Columns[1].HeaderText = "Mã tuyến bay";
            dataGridView2.Columns[2].HeaderText = "Sân bay đi";
            dataGridView2.Columns[3].HeaderText = "Sân bay đến";
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = i + 1;
            }            
        }

        private bool KiemTraTinhHopLeCuaInput(string pattern, string input)
        {
            Regex reg = new Regex(pattern);
            if (reg.IsMatch(input))
                return true;
            return false;
        }

        private bool validation1()
        {
            bool check = true;
            if (string.IsNullOrWhiteSpace(MaSBtextBox.Text))
            {
                label25.Visible = true;
                label10.Visible = false;
                check = false;
            }

            else if (!KiemTraTinhHopLeCuaInput(@"[A-Z0-9]", MaSBtextBox.Text))
            {
                label25.Visible = false;
                label10.Visible = true;
                check = false;
            }

            if (string.IsNullOrWhiteSpace(TenSBtextBox.Text))
            {
                label8.Visible = true;
                label11.Visible = false;
                check = false;
            }
           
            else if (!KiemTraTinhHopLeCuaInput(@"^[A-ZÁÀẠÃẢÂẤẦẨẪẬĂẮẰẲẴẶƯỨỪỬỮỰÉÈẸẺẼÚÙỤỦŨÍÌỊĨỈÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÊẾỀỆỂỄĐ\s]*$", TenSBtextBox.Text))
            {
                label11.Visible = false;
                label8.Visible = true;
                check = false;
            }

            return check;
        }

        private bool validation2()
        {
            bool check = true;
            if (string.IsNullOrWhiteSpace(MaTBtextBox.Text))
            {
                label12.Visible = false;
                label9.Visible = true;
                check = false; ;
            }
            else if (!KiemTraTinhHopLeCuaInput("^[A-Z0-9]*$", MaTBtextBox.Text))
            {
                label12.Visible = true;
                label9.Visible = false;
                check = false;
            }

            return check;
        }
      
        //Xử lý hiển thị của các control
        private void ThemButton_MouseHover(object sender, EventArgs e)
        {
            SBThemButton.BackColor = Color.White;
        }

        private void ThemButton_MouseLeave(object sender, EventArgs e)
        {
            SBThemButton.BackColor = Color.Aquamarine;
        }

        private void XoaButton_MouseHover(object sender, EventArgs e)
        {
            SBXoaButton.BackColor = Color.White;
        }

        private void XoaButton_MouseLeave(object sender, EventArgs e)
        {
            SBXoaButton.BackColor = Color.Aquamarine;
        }

        private void CapNhapButton_MouseHover(object sender, EventArgs e)
        {
            SBCapNhapButton.BackColor = Color.White;
        }

        private void CapNhapButton_MouseLeave(object sender, EventArgs e)
        {
            SBCapNhapButton.BackColor = Color.Aquamarine;
        }

        private void TBThemButton_MouseHover(object sender, EventArgs e)
        {
            TBThemButton.BackColor = Color.White;
        }

        private void TBThemButton_MouseLeave(object sender, EventArgs e)
        {
            TBThemButton.BackColor = Color.Aquamarine;
            TBThemButton.ForeColor = Color.Blue;
        }

        private void TBXoaButton_MouseHover(object sender, EventArgs e)
        {
            TBXoaButton.BackColor = Color.White;
        }

        private void TBXoaButton_MouseLeave(object sender, EventArgs e)
        {
            TBXoaButton.BackColor = Color.Aquamarine;
            TBXoaButton.ForeColor = Color.Blue;
        }

        private void TBCapNhapButton_MouseHover(object sender, EventArgs e)
        {
            TBCapNhapButton.BackColor = Color.White;
        }

        private void TBCapNhapButton_MouseLeave(object sender, EventArgs e)
        {
            TBCapNhapButton.BackColor = Color.Aquamarine;
        }

        private void SBLuubutton_MouseHover(object sender, EventArgs e)
        {
            SBLuubutton.BackColor = Color.White;
        }

        private void SBLuubutton_MouseLeave(object sender, EventArgs e)
        {
            SBLuubutton.BackColor = Color.Aquamarine;
        }

        private void TBLuubutton_MouseHover(object sender, EventArgs e)
        {
            TBLuubutton.BackColor = Color.White;
        }

        private void TBLuubutton_MouseLeave(object sender, EventArgs e)
        {
            TBLuubutton.BackColor = Color.Aquamarine;
        }

        //Xử lý các biến cố của các control
        private void XoaButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SBThemButton_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            MaSBtextBox.ReadOnly = false;            
            SBControlReset();
            flag = 0;  
        }

        private void SBCapNhapButton_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;            
            MaSBtextBox.ReadOnly = true;
            flag = 1;
        }

        private void TBThemButton_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            MaTBtextBox.ReadOnly = false;
            TBControlReset();
            flag2 = 0;
        }

        private void TBCapNhapButton_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            MaTBtextBox.ReadOnly = true;
            flag2 = 1;
        }
       
        private void SBLuubutton_Click(object sender, EventArgs e)
        {
            if (validation1())
            {
                if (flag == 0)
                {
                    QuanLy.ThemSanBay(new SanBay(Int32.Parse(MaSBtextBox.Text),TenSBtextBox.Text));
                    setSanBayDataSource();
                    MessageBox.Show("Thêm sân bay thành công");
                    SBControlReset();
                }
            }
        }

        private void TBLuubutton_Click(object sender, EventArgs e)
        {
            if (validation2())
            {
                if (flag2 == 0)
                {
                    QuanLy.ThemTuyenBay(new TuyenBay(Int32.Parse(MaTBtextBox.Text),(int)SBDiComboBox.SelectedValue,(int)SBDenComboBox.SelectedValue));
                    setTuyenBayDataSource();
                    MessageBox.Show("Thêm tuyến bay thành công");
                    TBControlReset();
                }
            }
        }


        private void SBControlReset()
        {
            MaSBtextBox.Text = "";
            TenSBtextBox.Text = "";
        }

        private void TBControlReset()
        {
            MaTBtextBox.Text = "";
        }
     
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
            MaSBtextBox.Text = ((int)dataGridView1.Rows[e.RowIndex].Cells[1].Value).ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MaTBtextBox.Text = ((int)dataGridView2.Rows[e.RowIndex].Cells[1].Value).ToString();     
        }

        private void MaSBtextBox_TextChanged(object sender, EventArgs e)
        {
            label25.Visible = false;
            label10.Visible = false;
        }

        private void TenSBtextBox_TextChanged(object sender, EventArgs e)
        {
            label8.Visible = false;
            label11.Visible = false;
        }

        private void MaTBtextBox_TextChanged(object sender, EventArgs e)
        {
            label12.Visible = false;
            label9.Visible = false;
        }              
    }
}
