using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            for (int i = 1; i <= 12; i++)
                ThangCombobox.Items.Add(i);
            ThangCombobox.SelectedIndex = 0;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            XemButton.BackColor = Color.White;
            XemButton.ForeColor = Color.Black;
        }

        private void XemButton_MouseLeave(object sender, EventArgs e)
        {
            XemButton.BackColor = Color.Blue;
            XemButton.ForeColor = Color.White;
        }
        

        private void XemButton_Click(object sender, EventArgs e)
        {

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

        private void Xem2Button_Click(object sender, EventArgs e)
        {

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
