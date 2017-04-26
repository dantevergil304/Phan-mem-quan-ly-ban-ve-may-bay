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
using DataAccessTier;

namespace Presentation
{
    public partial class TraCuu : Form
    {
        private TracuuBUS tracuuBUS;
        private DataTable DanhSachSanBayDi;
        private DataTable DanhSachSanBayDen;
        public Form RefToHome { get; set; }
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
        private void QUAYLAIButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToHome.Show();
        }       
        private string validation()
        {
            StringBuilder warning = new StringBuilder();
            if (SBDIBox.SelectedIndex == -1)
                warning.AppendLine("Chưa chọn sân bay đến");
            if (SBDENBox.SelectedIndex == -1)
                warning.AppendLine("Chưa chọn sân bay đi");
            if (SBDIBox.SelectedValue == SBDENBox.SelectedValue && SBDENBox.SelectedIndex != -1 && SBDIBox.SelectedIndex != -1)
                warning.AppendLine("Sân bay đến và sân bay đi không thể trùng nhau");
            return warning.ToString(); ;
        }

        private void TIMCBButton_Click(object sender, EventArgs e)
        {
            string warning = this.validation();
            if (!string.IsNullOrWhiteSpace(warning))
                MessageBox.Show(warning);
            else
            {
                TuyenBay tuyenbay = new TuyenBay(SBDIBox.SelectedValue as string,SBDENBox.SelectedValue as string);
                dataGridView1.DataSource = tracuuBUS.LayThongTinChuyenBayTheoTuyenBay(tuyenbay);
                if (dataGridView1.RowCount == 1)
                    label5.Visible = true;
                else
                    label5.Visible = false;
            }
        }

        private void XemChiTietButton_MouseHover(object sender, EventArgs e)
        {
            XemChiTietButton.BackColor = Color.White;
            XemChiTietButton.ForeColor = Color.Black;
        }

        private void QUAYLAIButton_MouseHover(object sender, EventArgs e)
        {
            QUAYLAIButton.BackColor = Color.White;
            QUAYLAIButton.ForeColor = Color.Black;
        }

        private void QUAYLAIButton_MouseLeave(object sender, EventArgs e)
        {
            QUAYLAIButton.BackColor = Color.Magenta;
            QUAYLAIButton.ForeColor = Color.White;
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
            dataGridView1.DataSource = tracuuBUS.LayThongTinTatCaChuyenBay();
            
        }          
    }
}
