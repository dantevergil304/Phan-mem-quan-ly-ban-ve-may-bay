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
    public partial class BanVe : Form
    {
        private Label[] warning;
        public Form RefToHome { get; set; }
        public BanVe()
        {
            InitializeComponent();
            warning = new Label[5];
            warning[0] = label11;
            warning[1] = label14;
            warning[2] = label13;
            warning[3] = label12;
            warning[4] = label15;
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

        private void InveButton_Click(object sender, EventArgs e)
        {
            if (!validation())
            {

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

        private void InveButton_MouseHover(object sender, EventArgs e)
        {
            InveButton.BackColor = Color.White;
            InveButton.ForeColor = Color.Black;
        }

        private void InveButton_MouseLeave(object sender, EventArgs e)
        {
            InveButton.BackColor = Color.Magenta;
            InveButton.ForeColor = Color.White;
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
               

       
    }
}
