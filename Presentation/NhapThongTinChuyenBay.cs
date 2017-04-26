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
using DataAccessTier;
using BusinessLogicTier;
namespace Presentation
{
    public partial class NhapThongTinChuyenBay : Form
    {
        public Form RefToHome { get; set; }
        private Label[] warning;
        public TracuuBUS tracuuBUS;
        public NhapThongTinChuyenBay()
        {
            InitializeComponent();
            tracuuBUS = new TracuuBUS();
            warning = new Label[8];
            warning[0] = label11;
            warning[1] = label12;
            warning[2] = label13;
            warning[3] = label14;
            warning[4] = label15;
            warning[5] = label16;
            warning[6] = label17;
            warning[7] = label18;
            TENSBComboBox1.DataSource = tracuuBUS.LayDanhSachSanBay();
            TENSBComboBox2.DataSource = tracuuBUS.LayDanhSachSanBay();
            TENSBComboBox1.DisplayMember = "TENSANBAY";
            TENSBComboBox1.ValueMember = "MASANBAY";
            TENSBComboBox2.DisplayMember = "TENSANBAY";
            TENSBComboBox2.ValueMember = "MASANBAY";

            DataGridViewComboBoxColumn col = dataGridView1.Columns[1] as DataGridViewComboBoxColumn;
            col.DataSource = tracuuBUS.LayDanhSachSanBay();
            col.DisplayMember = "TENSANBAY";
            col.ValueMember = "MASANBAY";
        }
        
       
        private void QuayLaiButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToHome.Show();
        }

        private bool validation()
        {
            bool check = true;

            if (string.IsNullOrWhiteSpace(MACBTexBox.Text))
            {
                warning[0].Visible = true;
                check = false;
            }

            if (TENSBComboBox1.SelectedIndex == -1)
            {
                warning[1].Visible = true;
                check = false;
            }

            if (TENSBComboBox2.SelectedIndex == -1)
            {
                warning[2].Visible = true;
                check = false;
            }

            if (string.IsNullOrWhiteSpace(SLGH1TextBox.Text))
            {
                warning[3].Visible = true;
                check = false;
            }

            if (string.IsNullOrWhiteSpace(SLGH2TextBox.Text))
            {
                warning[6].Visible = true;
                check = false;
            }

            if (string.IsNullOrWhiteSpace(TGBTextBox.Text))
            {
                warning[4].Visible = true;
                check = false;
            }

            if (string.IsNullOrWhiteSpace(GVTextBox.Text))
            {
                warning[5].Visible = true;
                check = false;
            }

            if ((String.Compare((string)TENSBComboBox1.SelectedValue,(string)TENSBComboBox2.SelectedValue) == 0)) 
            {
                warning[1].Visible = false;
                warning[2].Visible = false;
                warning[7].Visible = true;
                check = false;
            }
                
            return check;
        }

        private void LưuButton_Click(object sender, EventArgs e)
        {            
            if (validation())                            
            {
                ThongTinChuyenBay thongtin = new ThongTinChuyenBay();
                thongtin.MaChuyenBay = MACBTexBox.Text;
                thongtin.NgayGio = NGKHDate.Value;                
            }
        }



        private void resetControl()
        {
            MACBTexBox.Text = "";
            GVTextBox.Text = "";
            SLGH1TextBox.Text = "";
            SLGH2TextBox.Text = "";
            TGBTextBox.Text = "";
            TENSBComboBox1.SelectedIndex = 0;
            TENSBComboBox2.SelectedIndex = 0;
        }

        private void QuayLaiButton_MouseHover(object sender, EventArgs e)
        {
            QuayLaiButton.BackColor = Color.White;
            QuayLaiButton.ForeColor = Color.Black;
        }

        private void QuayLaiButton_MouseLeave(object sender, EventArgs e)
        {
            QuayLaiButton.BackColor = Color.Magenta;
            QuayLaiButton.ForeColor = Color.White;
        }

        private void LưuButton_MouseHover(object sender, EventArgs e)
        {
            LưuButton.BackColor = Color.White;
            LưuButton.ForeColor = Color.Black;
        }

        private void LưuButton_MouseLeave(object sender, EventArgs e)
        {
            LưuButton.BackColor = Color.Magenta;
            LưuButton.ForeColor = Color.White;
        }

        private void MACBTexBox_TextChanged(object sender, EventArgs e)
        {
            warning[0].Visible = false;
        }

        private void SLGH1TextBox_TextChanged(object sender, EventArgs e)
        {
            warning[3].Visible = false;
        }

        private void TGBTextBox_TextChanged(object sender, EventArgs e)
        {
            warning[4].Visible = false;
        }

        private void GVTextBox_TextChanged(object sender, EventArgs e)
        {
            warning[5].Visible = false;
        }

        private void SLGH2TextBox_TextChanged(object sender, EventArgs e)
        {
            warning[6].Visible = false;
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count == 3)
                dataGridView1.AllowUserToAddRows = false;                        
        }
              

        

       

        
    }
}
