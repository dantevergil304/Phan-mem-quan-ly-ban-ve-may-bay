namespace Presentation
{
    partial class ThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ThangButton = new System.Windows.Forms.Button();
            this.NamButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ThangCombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.XemButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Xem2Button = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(667, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ DOANH THU BÁN VÉ MÁY BAY";
            // 
            // ThangButton
            // 
            this.ThangButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ThangButton.FlatAppearance.BorderSize = 0;
            this.ThangButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThangButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThangButton.Location = new System.Drawing.Point(20, 71);
            this.ThangButton.Name = "ThangButton";
            this.ThangButton.Size = new System.Drawing.Size(483, 77);
            this.ThangButton.TabIndex = 2;
            this.ThangButton.Text = "Thống kê doanh thu tháng";
            this.ThangButton.UseVisualStyleBackColor = true;
            this.ThangButton.Click += new System.EventHandler(this.ThangButton_Click);
            // 
            // NamButton
            // 
            this.NamButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.NamButton.FlatAppearance.BorderSize = 0;
            this.NamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamButton.ForeColor = System.Drawing.Color.White;
            this.NamButton.Location = new System.Drawing.Point(503, 71);
            this.NamButton.Name = "NamButton";
            this.NamButton.Size = new System.Drawing.Size(485, 77);
            this.NamButton.TabIndex = 3;
            this.NamButton.Text = "Thống kê doanh thu năm";
            this.NamButton.UseVisualStyleBackColor = false;
            this.NamButton.Click += new System.EventHandler(this.NamButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ThangCombobox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.XemButton);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(20, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 359);
            this.panel1.TabIndex = 4;
            // 
            // ThangCombobox
            // 
            this.ThangCombobox.FormattingEnabled = true;
            this.ThangCombobox.Location = new System.Drawing.Point(459, 83);
            this.ThangCombobox.Name = "ThangCombobox";
            this.ThangCombobox.Size = new System.Drawing.Size(65, 21);
            this.ThangCombobox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tháng";
            // 
            // XemButton
            // 
            this.XemButton.BackColor = System.Drawing.Color.Blue;
            this.XemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XemButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XemButton.ForeColor = System.Drawing.Color.White;
            this.XemButton.Location = new System.Drawing.Point(431, 116);
            this.XemButton.Name = "XemButton";
            this.XemButton.Size = new System.Drawing.Size(121, 39);
            this.XemButton.TabIndex = 5;
            this.XemButton.Text = "Xem doanh thu";
            this.XemButton.UseVisualStyleBackColor = false;
            this.XemButton.Click += new System.EventHandler(this.XemButton_Click);
            this.XemButton.MouseLeave += new System.EventHandler(this.XemButton_MouseLeave);
            this.XemButton.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(961, 189);
            this.dataGridView1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(459, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(65, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(381, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = " Năm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Xem2Button);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(20, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 359);
            this.panel2.TabIndex = 8;
            // 
            // Xem2Button
            // 
            this.Xem2Button.BackColor = System.Drawing.Color.Blue;
            this.Xem2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Xem2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xem2Button.ForeColor = System.Drawing.Color.White;
            this.Xem2Button.Location = new System.Drawing.Point(413, 83);
            this.Xem2Button.Name = "Xem2Button";
            this.Xem2Button.Size = new System.Drawing.Size(121, 39);
            this.Xem2Button.TabIndex = 5;
            this.Xem2Button.Text = "Xem doanh thu";
            this.Xem2Button.UseVisualStyleBackColor = false;
            this.Xem2Button.Click += new System.EventHandler(this.Xem2Button_Click);
            this.Xem2Button.MouseLeave += new System.EventHandler(this.Xem2Button_MouseLeave);
            this.Xem2Button.MouseHover += new System.EventHandler(this.Xem2Button_MouseHover);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 161);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(961, 189);
            this.dataGridView2.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(441, 40);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(65, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(366, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = " Năm";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 509);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.NamButton);
            this.Controls.Add(this.ThangButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ThongKe";
            this.Text = "Thống kê doanh thu";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ThangButton;
        private System.Windows.Forms.Button NamButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button XemButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ThangCombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Xem2Button;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
    }
}