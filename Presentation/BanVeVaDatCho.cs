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
using System.Text.RegularExpressions;

namespace Presentation
{
    public partial class BanVeVaDatCho : Form
    {
        private Label[] warningLabels;        
        private BanvevadatveBUS BanVeVaDatVeBUS;
        private HanhkhachBUS HanhKhachBUS;

        private List<Panel> panels;        
        public BanVeVaDatCho()
        {
            InitializeComponent();          
            BanVeVaDatVeBUS = new BanvevadatveBUS();
            HanhKhachBUS = new HanhkhachBUS();
            QuanLyDatChoPanel.BringToFront();
            BanVePanel.BringToFront();
            DatChoPanel.BringToFront();
            panels = new List<Panel>();
            
        }

        private bool KiemTraTinhHopLeCuaInput(string pattern, string input)
        {
            Regex reg = new Regex(pattern);
            if (reg.IsMatch(input))
                return true;
            return false;
        }

        private bool KiemTraInputDatCho()
        {
            bool check = true;
            if (string.IsNullOrWhiteSpace(TENTextbox.Text))
            {
                warningLabels[0].Visible = true;
                warningLabels[10].Visible = false;
                check = false;
            }
            else if (!KiemTraTinhHopLeCuaInput(@"^[A-ZÁÀẠÃẢÂẤẦẨẪẬĂẮẰẲẴẶƯỨỪỬỮỰÉÈẸẺẼÚÙỤỦŨÍÌỊĨỈÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÊẾỀỆỂỄĐ\s]*$", TENTextbox.Text))
            {
                warningLabels[0].Visible = false;
                warningLabels[10].Visible = true;
                check = false;
            }
           
            if (string.IsNullOrWhiteSpace(CMNDTextbox.Text))
            {
                warningLabels[1].Visible = true;
                warningLabels[11].Visible = false;
                check = false;
            }

            else if (!KiemTraTinhHopLeCuaInput("^[0-9]*$", CMNDTextbox.Text))
            {
                warningLabels[1].Visible = false;
                warningLabels[11].Visible = true;
                check = false;
            }
            if (string.IsNullOrWhiteSpace(SĐTTextbox.Text))
            {
                warningLabels[2].Visible = true;
                warningLabels[12].Visible = false;
                check = false;
            }

            else if (!KiemTraTinhHopLeCuaInput("^[0-9]*$", SĐTTextbox.Text))
            {
                warningLabels[2].Visible = false;
                warningLabels[12].Visible = true;
                check = false;
            }

            if (string.IsNullOrWhiteSpace(MACBTextbox.Text))
            {
                warningLabels[3].Visible = true;
                warningLabels[13].Visible = false;
                check = false;
            }

            else if (!KiemTraTinhHopLeCuaInput("^[0-9A-Z]*$", MACBTextbox.Text))
            {
                warningLabels[3].Visible = false;
                warningLabels[13].Visible = true;
                check = false;
            }          
            return check;
        }

        private bool KiemTraInputBanVe()
        {
            bool check = true;
            if (string.IsNullOrWhiteSpace(BVTenTextbox.Text))
            {
                warningLabels[5].Visible = true;
                warningLabels[14].Visible = false;
                check = false;
            }

            else if (!KiemTraTinhHopLeCuaInput(@"^[A-ZÁÀẠÃẢÂẤẦẨẪẬĂẮẰẲẴẶƯỨỪỬỮỰÉÈẸẺẼÚÙỤỦŨÍÌỊĨỈÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÊẾỀỆỂỄĐ\s]*$", BVTenTextbox.Text))
            {
                warningLabels[5].Visible = false;
                warningLabels[14].Visible = true;
                check = false;
            }

            if (string.IsNullOrWhiteSpace(BVCMNDTextbox.Text))
            {
                warningLabels[6].Visible = true;
                warningLabels[15].Visible = false;
                check = false;
            }

            else if (!KiemTraTinhHopLeCuaInput("^[0-9]*$", BVCMNDTextbox.Text))
            {
                warningLabels[6].Visible = false;
                warningLabels[15].Visible = true;
                check = false;
            }

            if (string.IsNullOrWhiteSpace(BVSĐTTextbox.Text))
            {
                warningLabels[7].Visible = true;
                warningLabels[16].Visible = false;
                check = false;
            }

            else if (!KiemTraTinhHopLeCuaInput("^[0-9]*$", BVSĐTTextbox.Text))
            {
                warningLabels[7].Visible = false;
                warningLabels[16].Visible = true;
                check = false;
            }

            if (string.IsNullOrWhiteSpace(BVMACBTextbox.Text))
            {
                warningLabels[8].Visible = true;
                warningLabels[17].Visible = false;
                check = false;
            }

            else if (!KiemTraTinhHopLeCuaInput("^[0-9A-Z]*$", BVMACBTextbox.Text))
            {
                warningLabels[8].Visible = false;
                warningLabels[17].Visible = true;
                check = false;
            }                                                     
            return check;
        }

        private void DatChoControlsReset()
        {
            CMNDTextbox.Text = "";
            TENTextbox.Text = "";
            SĐTTextbox.Text = "";
            MACBTextbox.Text = "";
            for (int i = 0; i < 5; i++)
                if (i != 4)
                    warningLabels[i].Visible = false;
            for (int i = 10; i < 14; i++)
                warningLabels[i].Visible = false;
        }

        private void BanVeControlsReset()
        {
            BVCMNDTextbox.Text = "";
            BVTenTextbox.Text = "";
            BVSĐTTextbox.Text = "";
            BVMACBTextbox.Text = "";
            for (int i = 5; i < 10; i++)
                if (i != 9)
                    warningLabels[i].Visible = false;
            for (int i = 14; i < 18; i++)
                warningLabels[i].Visible = false;
        }
                
        //Xử lý các biến cố       
        private void BanVeVaDatCho_Load(object sender, EventArgs e)
        {
            warningLabels = new Label[18];
            warningLabels[0] = label11;
            warningLabels[1] = label14;
            warningLabels[2] = label13;
            warningLabels[3] = label12;
            warningLabels[5] = label25;
            warningLabels[6] = label22;
            warningLabels[7] = label23;
            warningLabels[8] = label24;
            warningLabels[10] = label40;
            warningLabels[11] = label39;
            warningLabels[12] = label38;
            warningLabels[13] = label37;
            warningLabels[14] = label26;
            warningLabels[15] = label34;
            warningLabels[16] = label35;
            warningLabels[17] = label36;

            HVComboBox.DataSource = BanVeVaDatVeBUS.LayHangVe();
            HVComboBox.DisplayMember = "TENHANGVE";
            HVComboBox.ValueMember = "MAHANGVE";

            BVHVCombobox.DataSource = BanVeVaDatVeBUS.LayHangVe();
            BVHVCombobox.DisplayMember = "TENHANGVE";
            BVHVCombobox.ValueMember = "MAHANGVE";

            QuanLyDatChoButton.BackColor = Color.White;
            label10.Text = DateTime.Now.ToShortDateString().ToString();

            panels.Add(QuanLyDatChoPanel);
            panels.Add(BanVePanel);
            panels.Add(DatChoPanel);
            panels[0].BringToFront();
        }
      
        private void InVeButton_Click(object sender, EventArgs e)
        {
            if (KiemTraInputBanVe())
            {

            }            
        }

        private void DatveButton_Click(object sender, EventArgs e)
        {
            if (KiemTraInputDatCho())
            {
            
            }            
        }

        private void HuyDatChoButton_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Taomoi1Button_Click(object sender, EventArgs e)
        {
            DatChoControlsReset();
        }

        private void Taomoi2Button_Click(object sender, EventArgs e)
        {
            BanVeControlsReset();
        }

        private void HuyDatChoButton_Click(object sender, EventArgs e)
        {

        }

        private void CapNhapDatChoButton_Click(object sender, EventArgs e)
        {

        }


        //Xử lý hiển thị GUI
                          
        private void QuanLyDatChoButton_Click(object sender, EventArgs e)
        {
            QuanLyDatChoButton.BackColor = Color.White;
            BanVeButton.BackColor = Color.DeepSkyBlue;
            panels[0].BringToFront();            
        }

        private void BanVeButton_Click(object sender, EventArgs e)
        {
            QuanLyDatChoButton.BackColor = Color.Yellow;
            BanVeButton.BackColor = Color.White;
            panels[1].BringToFront();            
            BanVeControlsReset();
        }

        private void BVTenTextbox_TextChanged(object sender, EventArgs e)
        {
            warningLabels[5].Visible = false;
            warningLabels[14].Visible = false;
        }

        private void BVCMNDTextbox_TextChanged(object sender, EventArgs e)
        {
            warningLabels[6].Visible = false;
            warningLabels[15].Visible = false;
        }

        private void BVSĐTTextbox_TextChanged(object sender, EventArgs e)
        {
            warningLabels[7].Visible = false;
            warningLabels[16].Visible = false;
        }

        private void BVMACBTextbox_TextChanged(object sender, EventArgs e)
        {
            warningLabels[8].Visible = false;
            warningLabels[17].Visible = false;
        }
  
        private void TENTextbox_TextChanged(object sender, EventArgs e)
        {
            warningLabels[0].Visible = false;
            warningLabels[10].Visible = false;
        }

        private void CMNDTextbox_TextChanged(object sender, EventArgs e)
        {
            warningLabels[1].Visible = false;
            warningLabels[11].Visible = false;
        }

        private void SĐTTextbox_TextChanged(object sender, EventArgs e)
        {
            warningLabels[2].Visible = false;
            warningLabels[12].Visible = false;
        }

        private void MACBTextbox_TextChanged(object sender, EventArgs e)
        {
            warningLabels[3].Visible = false;
            warningLabels[13].Visible = false;
        }
  
        private void ThemDatChoButton_Click(object sender, EventArgs e)
        {
            panels[2].BringToFront();
            DatChoControlsReset();
            
        }

        private void QuayLaiQLDCButton_Click(object sender, EventArgs e)
        {            
            panels[0].BringToFront();
        }
    
        private void SetColorForMouseHover(Button button)
        {
            button.BackColor = Color.White;
            button.ForeColor = Color.Black;
        }

        private void SetColorForMouseLeave(Button button)
        {
            button.BackColor = Color.Blue;
            button.ForeColor = Color.White;
        }

        private void InVeButton_MouseHover(object sender, EventArgs e)
        {
            SetColorForMouseHover(InVeButton);
        }

        private void InVeButton_MouseLeave(object sender, EventArgs e)
        {
            SetColorForMouseLeave(InVeButton);
        }

        private void Taomoi2Button_MouseHover(object sender, EventArgs e)
        {
            SetColorForMouseHover(Taomoi2Button);
        }

        private void Taomoi2Button_MouseLeave(object sender, EventArgs e)
        {
            SetColorForMouseLeave(Taomoi2Button);
        }

        private void DatveButton_MouseHover(object sender, EventArgs e)
        {
            SetColorForMouseHover(DatveButton);
        }

        private void DatveButton_MouseLeave(object sender, EventArgs e)
        {
            SetColorForMouseLeave(DatveButton);
        }

        private void Taomoi1Button_MouseHover(object sender, EventArgs e)
        {
            SetColorForMouseHover(Taomoi1Button);
        }

        private void Taomoi1Button_MouseLeave(object sender, EventArgs e)
        {
            SetColorForMouseLeave(Taomoi1Button);
        }

        private void QuayLaiQLDCButton_MouseHover(object sender, EventArgs e)
        {
            SetColorForMouseHover(QuayLaiQLDCButton);
        }

        private void QuayLaiQLDCButton_MouseLeave(object sender, EventArgs e)
        {
            SetColorForMouseLeave(QuayLaiQLDCButton);
        }     

        private void ThemDatChoButton_MouseHover(object sender, EventArgs e)
        {
            SetColorForMouseHover(ThemDatChoButton);
        }

        private void ThemDatChoButton_MouseLeave(object sender, EventArgs e)
        {
            SetColorForMouseLeave(ThemDatChoButton);
        }
       
        private void CapNhapDatChoButton_MouseHover(object sender, EventArgs e)
        {
            SetColorForMouseHover(CapNhapDatChoButton);
        }

        private void CapNhapDatChoButton_MouseLeave(object sender, EventArgs e)
        {
            SetColorForMouseLeave(CapNhapDatChoButton);
        }
    
        private void HuyDatChoButton_MouseHover(object sender, EventArgs e)
        {
            SetColorForMouseHover(HuyDatChoButton);
        }

        private void HuyDatChoButton_MouseLeave(object sender, EventArgs e)
        {
            SetColorForMouseLeave(HuyDatChoButton);
        }                       
    
    }
}
