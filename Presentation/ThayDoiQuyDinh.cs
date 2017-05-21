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
using DTO;

namespace Presentation
{
    public partial class ThayDoiQuyDinh : Form
    {
        public QuyDinhBUS quydinhBUS;
        public QuyDinh QuyDinh;
        public ThayDoiQuyDinh()
        {
            InitializeComponent();
            quydinhBUS = new QuyDinhBUS();
            QuyDinh = quydinhBUS.LayDanhSachQuyDinh();
        }

        private void ThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            SoLuongSanBayNumeric.Value = QuyDinh.SoLuongSanBayToiDa;
            ThoiGianBayNumeric.Value = QuyDinh.ThoiGianBayToiThieu;
            SoLuongSanBayTGNumeric.Value = QuyDinh.SoSanBayTrungGianToiDa;
            ThoiGianDungMinNumeric.Value = QuyDinh.ThoiGianDungToiThieu;
            ThoiGianDungMaxNumeric.Value = QuyDinh.ThoiGianDungToiDa;
            ThoiGianMinDatVeNumeric.Value = QuyDinh.ThoiGianHuyDatVe;
        }

        private void LuuButton_Click(object sender, EventArgs e)
        {

        }
       
    }
}
