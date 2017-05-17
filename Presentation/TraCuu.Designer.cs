namespace Presentation
{
    partial class TraCuu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SBDIBox = new System.Windows.Forms.ComboBox();
            this.SBDENBox = new System.Windows.Forms.ComboBox();
            this.NGBAYDate = new System.Windows.Forms.DateTimePicker();
            this.TIMCBButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.XemTatCaButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(360, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRA CỨU CHUYẾN BAY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sân bay đi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(367, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sân bay đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(737, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày bay";
            // 
            // SBDIBox
            // 
            this.SBDIBox.FormattingEnabled = true;
            this.SBDIBox.Location = new System.Drawing.Point(127, 82);
            this.SBDIBox.Name = "SBDIBox";
            this.SBDIBox.Size = new System.Drawing.Size(195, 21);
            this.SBDIBox.TabIndex = 4;
            // 
            // SBDENBox
            // 
            this.SBDENBox.FormattingEnabled = true;
            this.SBDENBox.Location = new System.Drawing.Point(506, 82);
            this.SBDENBox.Name = "SBDENBox";
            this.SBDENBox.Size = new System.Drawing.Size(195, 21);
            this.SBDENBox.TabIndex = 5;
            // 
            // NGBAYDate
            // 
            this.NGBAYDate.CustomFormat = "dd/MM/yyyy";
            this.NGBAYDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NGBAYDate.Location = new System.Drawing.Point(849, 81);
            this.NGBAYDate.Name = "NGBAYDate";
            this.NGBAYDate.Size = new System.Drawing.Size(152, 20);
            this.NGBAYDate.TabIndex = 6;
            // 
            // TIMCBButton
            // 
            this.TIMCBButton.BackColor = System.Drawing.Color.LimeGreen;
            this.TIMCBButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.TIMCBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TIMCBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIMCBButton.Location = new System.Drawing.Point(439, 142);
            this.TIMCBButton.Name = "TIMCBButton";
            this.TIMCBButton.Size = new System.Drawing.Size(153, 36);
            this.TIMCBButton.TabIndex = 7;
            this.TIMCBButton.Text = "Tìm chuyến bay";
            this.TIMCBButton.UseVisualStyleBackColor = false;
            this.TIMCBButton.Click += new System.EventHandler(this.TIMCBButton_Click);
            this.TIMCBButton.MouseLeave += new System.EventHandler(this.TIMCBButton_MouseLeave);
            this.TIMCBButton.MouseHover += new System.EventHandler(this.TIMCBButton_MouseHover);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1000, 149);
            this.dataGridView1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(608, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "* Không có chuyến bay nào";
            this.label5.Visible = false;
            // 
            // XemTatCaButton
            // 
            this.XemTatCaButton.BackColor = System.Drawing.Color.Blue;
            this.XemTatCaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XemTatCaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XemTatCaButton.ForeColor = System.Drawing.Color.White;
            this.XemTatCaButton.Location = new System.Drawing.Point(393, 198);
            this.XemTatCaButton.Name = "XemTatCaButton";
            this.XemTatCaButton.Size = new System.Drawing.Size(245, 35);
            this.XemTatCaButton.TabIndex = 12;
            this.XemTatCaButton.Text = "Xem tất cả chuyến bay";
            this.XemTatCaButton.UseVisualStyleBackColor = false;
            this.XemTatCaButton.Click += new System.EventHandler(this.XemTatCaButton_Click);
            this.XemTatCaButton.MouseLeave += new System.EventHandler(this.XemTatCaButton_MouseLeave);
            this.XemTatCaButton.MouseHover += new System.EventHandler(this.XemTatCaButton_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(388, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "THÔNG TIN CHUYẾN BAY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(608, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "* Sân bay không được trùng nhau";
            this.label7.Visible = false;
            // 
            // TraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 490);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.XemTatCaButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TIMCBButton);
            this.Controls.Add(this.NGBAYDate);
            this.Controls.Add(this.SBDENBox);
            this.Controls.Add(this.SBDIBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.HelpButton = true;
            this.Name = "TraCuu";
            this.Text = "Tra cứu";
            this.Load += new System.EventHandler(this.TraCuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SBDIBox;
        private System.Windows.Forms.ComboBox SBDENBox;
        private System.Windows.Forms.DateTimePicker NGBAYDate;
        private System.Windows.Forms.Button TIMCBButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button XemTatCaButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}