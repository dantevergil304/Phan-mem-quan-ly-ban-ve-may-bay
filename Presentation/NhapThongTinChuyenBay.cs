using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DTO;
using DataAccessTier;
using BusinessLogicTier;
namespace Presentation
{
    public partial class NhapThongTinChuyenBay : Form
    {       
        private Label[] warning;
        private QuanlysanbayvatuyenbayBUS quanlyBUS;
        private QuyDinhBUS quydinhBUS;
        private QuyDinh QuyDinh;
        public NhapThongTinChuyenBay()
        {
            InitializeComponent();
            quanlyBUS = new QuanlysanbayvatuyenbayBUS();
            quydinhBUS = new QuyDinhBUS();
            QuyDinh = quydinhBUS.LayDanhSachQuyDinh();
                       
        }

        private bool KiemTraTinhHopLeCuaInput(string pattern, string input)
        {
            Regex reg = new Regex(pattern);
            if (reg.IsMatch(input))
                return true;
            return false;
        }

        private bool KiemTraInputChiTietChuyenBay()
        {
            bool check = true;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewCell cell = dataGridView1.Rows[i].Cells[2];
                if (string.IsNullOrWhiteSpace(cell.Value as string))
                {
                    warning[13].Visible = true;
                    warning[9].Visible = false;
                    warning[12].Visible = false;
                    cell.Style.BackColor = Color.Red;
                    cell.Style.ForeColor = Color.White;
                    check = false;
                }
                else if (!KiemTraTinhHopLeCuaInput("^[0-9]*$", cell.Value as string))
                {
                    warning[9].Visible = true;
                    warning[12].Visible = false;
                    warning[13].Visible = false;
                    cell.Style.BackColor = Color.Red;
                    cell.Style.ForeColor = Color.White;
                    check = false;
                }
                else if (Int32.Parse(cell.Value as string) < QuyDinh.ThoiGianDungToiThieu || Int32.Parse(cell.Value as string) > QuyDinh.SoSanBayTrungGianToiDa)
                {
                    warning[9].Visible = false;
                    warning[13].Visible = false;
                    warning[12].Visible = true;
                    cell.Style.BackColor = Color.Red;
                    cell.Style.ForeColor = Color.White;
                    check = false;
                }
            }
            return check;
        }

        private bool KiemTraInput()
        {
            bool check = true;

            if (string.IsNullOrWhiteSpace(MACBTexBox.Text))
            {
                warning[0].Visible = true;
                warning[8].Visible = false;
                check = false;
            }
            else if (!KiemTraTinhHopLeCuaInput(@"^[0-9A-Z]*$", MACBTexBox.Text))
            {
                warning[0].Visible = false;
                warning[8].Visible = true;
                check = false;
            }

            if (string.IsNullOrWhiteSpace(GVTextBox.Text))
            {
                warning[5].Visible = true;
                warning[10].Visible = false;
                check = false;
            }
            else if (!KiemTraTinhHopLeCuaInput("^[0-9]*$", GVTextBox.Text))
            {
                warning[5].Visible = false;
                warning[10].Visible = true;
                check = false;
            }

            if ((int)TENSBComboBox1.SelectedValue == (int)TENSBComboBox2.SelectedValue)
            {
                warning[7].Visible = true;
                check = false;
            }

            if (SLGH1NumericUpDown.Value == 0)
            {
                warning[3].Visible = true;
                check = false;
            }
            if (SLGH2NumericUpDown.Value == 0)
            {
                warning[4].Visible = true;
                check = false;
            }

            if (TimeNumericUpDown.Value < QuyDinh.ThoiGianBayToiThieu)
            {
                warning[11].Visible = true;
                check = false;
            }

            if (!KiemTraInputChiTietChuyenBay())
            {
                check = false;
            }

            return check;
        }

        
        //Xử lý các biến cố của control
        private void NhapThongTinChuyenBay_Load(object sender, EventArgs e)
        {
            warning = new Label[14];
            warning[0] = label11;
            warning[3] = label14;
            warning[4] = label15;
            warning[5] = label16;
            warning[7] = label18;
            warning[8] = label17;
            warning[9] = label12;
            warning[10] = label19;
            warning[11] = label20;
            warning[12] = label21;
            warning[13] = label22;

            warning[12].Text = "Thời gian dừng phải nằm trong khoảng từ " + QuyDinh.ThoiGianDungToiThieu + " đến " + QuyDinh.ThoiGianDungToiDa + " phút";

            TENSBComboBox1.DataSource = quanlyBUS.LayDanhSachSanBay();
            TENSBComboBox2.DataSource = quanlyBUS.LayDanhSachSanBay();
            TENSBComboBox1.DisplayMember = "TENSANBAY";
            TENSBComboBox1.ValueMember = "MASANBAY";
            TENSBComboBox2.DisplayMember = "TENSANBAY";
            TENSBComboBox2.ValueMember = "MASANBAY";

            DataGridViewComboBoxColumn col = dataGridView1.Columns[1] as DataGridViewComboBoxColumn;
            col.DataSource = quanlyBUS.LayDanhSachSanBay();
            col.DisplayMember = "TENSANBAY";
            col.ValueMember = "MASANBAY";            
            
        }
             
        private void LưuButton_Click(object sender, EventArgs e)
        {            
            if (KiemTraInput())                            
            {                     
            }
        }


        //Xử lý hiển thị GUI của các control
        private void resetControl()
        {
            MACBTexBox.Text = "";
            GVTextBox.Text = "";                        
            TENSBComboBox1.SelectedIndex = 0;
            TENSBComboBox2.SelectedIndex = 0;
        } 
     
        private void LưuButton_MouseHover(object sender, EventArgs e)
        {
            LưuButton.BackColor = Color.White;
            LưuButton.ForeColor = Color.Black;
        }

        private void LưuButton_MouseLeave(object sender, EventArgs e)
        {
            LưuButton.BackColor = Color.Blue;
            LưuButton.ForeColor = Color.White;
        }

        private void MACBTexBox_TextChanged(object sender, EventArgs e)
        {
            warning[0].Visible = false;
            warning[8].Visible = false;
        }     
  

        private void GVTextBox_TextChanged(object sender, EventArgs e)
        {
            warning[5].Visible = false;
            warning[10].Visible = false;
        }

     
       
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1);
            if (dataGridView1.Rows.Count == QuyDinh.SoSanBayTrungGianToiDa + 1)
                dataGridView1.AllowUserToAddRows = false;         
        }

        private void SLGH2NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            warning[4].Visible = false;
        }

        private void SLGH1NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            warning[3].Visible = false;
        }

        private void TENSBComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            warning[7].Visible = false;
        }

        private void TENSBComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            warning[7].Visible = false;
        }

        private void TimeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            warning[11].Visible = false;
        }

      
                                            
        
    }
}
