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
using System.Globalization;

namespace Presentation
{
    public partial class DatVe : Form
    {
        private Label[] warning;
        public Form RefToHome { get; set; }
        private DatveBUS datveBUS;
        private HanhKhachBUS hanhkhachBUS;
        public DatVe()
        {
            InitializeComponent();
            datveBUS = new DatveBUS();
            hanhkhachBUS = new HanhKhachBUS();
            label10.Text = DateTime.Now.ToShortDateString();            
            warning = new Label[5];
            warning[0] = label11;
            warning[1] = label14;
            warning[2] = label13;
            warning[3] = label12;
            warning[4] = label15;
            HVComboBox.DataSource = datveBUS.LayHangVe();
            HVComboBox.DisplayMember = "TENHANGVE";
            HVComboBox.ValueMember = "MAHANGVE";
        }

        private void QuaylaiButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToHome.Show();
        }

        private bool validation()
        {
            bool check = true;
            if (string.IsNullOrWhiteSpace(TENTextbox.Text))
            {
                warning[0].Visible = true;
                check = false;
            }
            if (string.IsNullOrWhiteSpace(CMNDTexbox.Text))
            {
                warning[1].Visible = true;
                check = false;
            }
            if (string.IsNullOrWhiteSpace(SĐTTexbox.Text))
            {
                warning[2].Visible = true;
                check = false;
            }

            if (string.IsNullOrWhiteSpace(MACBTextBox.Text))
            {
                warning[3].Visible = true;
                check = false;
            }

            if (HVComboBox.SelectedIndex == -1)
            {
                warning[4].Visible = true;
                check = false;
            }
            return check;
        }

        
        private void DatveButton_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                HanhKhach hanhkhach = new HanhKhach(TENTextbox.Text, CMNDTexbox.Text, SĐTTexbox.Text);
                PhieuDatCho phieu = new PhieuDatCho(MACBTextBox.Text, hanhkhach.MaHanhKhach, (string)HVComboBox.SelectedValue, int.Parse(label8.Text,NumberStyles.AllowThousands));                
                if (hanhkhachBUS.KiemTraCMND(CMNDTexbox.Text))
                {
                    hanhkhachBUS.ThemHanhKhach(hanhkhach);
                }
                else 
                { 
                    hanhkhach.MaHanhKhach = hanhkhachBUS.LayMaHanhKhachTheoCMND(CMNDTexbox.Text);
                    phieu.MaHanhKhach = hanhkhach.MaHanhKhach;
                }
                try
                {
                    datveBUS.ThemThongTinDatCho(phieu);
                    MessageBox.Show("Đặt vé thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\nĐặt vé thất bại");
                }

            }
            
        }

        private void TENTextbox_TextChanged(object sender, EventArgs e)
        {            
                warning[0].Visible = false;
        }

        private void CMNDTexbox_TextChanged(object sender, EventArgs e)
        {            
                warning[1].Visible = false;
        }

        private void SĐTTexbox_TextChanged(object sender, EventArgs e)
        {            
                warning[2].Visible = false;
        }

        private void MACBTextBox_TextChanged(object sender, EventArgs e)
        {            
                warning[3].Visible = false;
        }

        private void HVComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {            
                warning[4].Visible = false;
        }

        private void QuaylaiButton_MouseHover(object sender, EventArgs e)
        {
            QuaylaiButton.BackColor = Color.White;
            QuaylaiButton.ForeColor = Color.Black;
        }

        private void QuaylaiButton_MouseLeave(object sender, EventArgs e)
        {
            QuaylaiButton.BackColor = Color.Magenta;
            QuaylaiButton.ForeColor = Color.White;
        }

        private void DatveButton_MouseHover(object sender, EventArgs e)
        {
            DatveButton.BackColor = Color.White;
            DatveButton.ForeColor = Color.Black;
        }

        private void DatveButton_MouseLeave(object sender, EventArgs e)
        {
            DatveButton.BackColor = Color.Magenta;
            DatveButton.ForeColor = Color.White;
        }
        private void ResetControl()
        {
            CMNDTexbox.Text = "";
            TENTextbox.Text = "";
            SĐTTexbox.Text = "";
            MACBTextBox.Text = "";
        }

          
    }
}
