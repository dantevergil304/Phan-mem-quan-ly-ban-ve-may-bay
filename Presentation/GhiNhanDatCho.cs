using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;
using BusinessLogicTier;
using DTO;

namespace Presentation
{
    public partial class GhiNhanDatCho : Form
    {
        private BanvevadatveBUS BanVeVaDatVeBUS;
        public GhiNhanDatCho()
        {
            InitializeComponent();
            BanVeVaDatVeBUS = new BanvevadatveBUS();
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

            if (HVComboBox.SelectedIndex == -1)
            {
                warningLabels[4].Visible = true;
                check = false;
            }
            return check;
        }

        private void DatChoPanel_Paint(object sender, PaintEventArgs e)
        {
            HVComboBox.DataSource = BanVeVaDatVeBUS.LayHangVe();
            HVComboBox.DisplayMember = "TENHANGVE";
            HVComboBox.ValueMember = "MAHANGVE";
        }
    }
}
