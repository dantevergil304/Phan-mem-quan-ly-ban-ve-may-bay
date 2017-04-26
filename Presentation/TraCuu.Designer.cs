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
            this.QUAYLAIButton = new System.Windows.Forms.Button();
            this.XemChiTietButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.XemTatCaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRA CỨU CHUYẾN BAY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sân bay đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày bay";
            this.label4.Visible = false;
            // 
            // SBDIBox
            // 
            this.SBDIBox.FormattingEnabled = true;
            this.SBDIBox.Location = new System.Drawing.Point(144, 84);
            this.SBDIBox.Name = "SBDIBox";
            this.SBDIBox.Size = new System.Drawing.Size(152, 21);
            this.SBDIBox.TabIndex = 4;
            // 
            // SBDENBox
            // 
            this.SBDENBox.FormattingEnabled = true;
            this.SBDENBox.Location = new System.Drawing.Point(144, 124);
            this.SBDENBox.Name = "SBDENBox";
            this.SBDENBox.Size = new System.Drawing.Size(152, 21);
            this.SBDENBox.TabIndex = 5;
            // 
            // NGBAYDate
            // 
            this.NGBAYDate.Location = new System.Drawing.Point(144, 171);
            this.NGBAYDate.Name = "NGBAYDate";
            this.NGBAYDate.Size = new System.Drawing.Size(200, 20);
            this.NGBAYDate.TabIndex = 6;
            this.NGBAYDate.Visible = false;
            // 
            // TIMCBButton
            // 
            this.TIMCBButton.BackColor = System.Drawing.Color.LimeGreen;
            this.TIMCBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIMCBButton.Location = new System.Drawing.Point(144, 209);
            this.TIMCBButton.Name = "TIMCBButton";
            this.TIMCBButton.Size = new System.Drawing.Size(158, 36);
            this.TIMCBButton.TabIndex = 7;
            this.TIMCBButton.Text = "Tìm chuyến bay";
            this.TIMCBButton.UseVisualStyleBackColor = false;
            this.TIMCBButton.Click += new System.EventHandler(this.TIMCBButton_Click);
            this.TIMCBButton.MouseLeave += new System.EventHandler(this.TIMCBButton_MouseLeave);
            this.TIMCBButton.MouseHover += new System.EventHandler(this.TIMCBButton_MouseHover);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(356, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(589, 424);
            this.dataGridView1.TabIndex = 8;
            // 
            // QUAYLAIButton
            // 
            this.QUAYLAIButton.BackColor = System.Drawing.Color.Magenta;
            this.QUAYLAIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QUAYLAIButton.ForeColor = System.Drawing.Color.White;
            this.QUAYLAIButton.Location = new System.Drawing.Point(200, 451);
            this.QUAYLAIButton.Name = "QUAYLAIButton";
            this.QUAYLAIButton.Size = new System.Drawing.Size(102, 35);
            this.QUAYLAIButton.TabIndex = 9;
            this.QUAYLAIButton.Text = "Quay lại";
            this.QUAYLAIButton.UseVisualStyleBackColor = false;
            this.QUAYLAIButton.Click += new System.EventHandler(this.QUAYLAIButton_Click);
            this.QUAYLAIButton.MouseLeave += new System.EventHandler(this.QUAYLAIButton_MouseLeave);
            this.QUAYLAIButton.MouseHover += new System.EventHandler(this.QUAYLAIButton_MouseHover);
            // 
            // XemChiTietButton
            // 
            this.XemChiTietButton.BackColor = System.Drawing.Color.Magenta;
            this.XemChiTietButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XemChiTietButton.ForeColor = System.Drawing.Color.White;
            this.XemChiTietButton.Location = new System.Drawing.Point(12, 451);
            this.XemChiTietButton.Name = "XemChiTietButton";
            this.XemChiTietButton.Size = new System.Drawing.Size(168, 35);
            this.XemChiTietButton.TabIndex = 10;
            this.XemChiTietButton.Text = "Xem chi tiết chuyến bay";
            this.XemChiTietButton.UseVisualStyleBackColor = false;
            this.XemChiTietButton.Visible = false;
            this.XemChiTietButton.MouseHover += new System.EventHandler(this.XemChiTietButton_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(141, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "* Không có chuyến bay nào";
            this.label5.Visible = false;
            // 
            // XemTatCaButton
            // 
            this.XemTatCaButton.BackColor = System.Drawing.Color.Magenta;
            this.XemTatCaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XemTatCaButton.ForeColor = System.Drawing.Color.White;
            this.XemTatCaButton.Location = new System.Drawing.Point(777, 451);
            this.XemTatCaButton.Name = "XemTatCaButton";
            this.XemTatCaButton.Size = new System.Drawing.Size(168, 35);
            this.XemTatCaButton.TabIndex = 12;
            this.XemTatCaButton.Text = "Xem tất cả chuyến bay";
            this.XemTatCaButton.UseVisualStyleBackColor = false;
            this.XemTatCaButton.Click += new System.EventHandler(this.XemTatCaButton_Click);
            // 
            // TraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(957, 498);
            this.ControlBox = false;
            this.Controls.Add(this.XemTatCaButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.XemChiTietButton);
            this.Controls.Add(this.QUAYLAIButton);
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
            this.Name = "TraCuu";
            this.Text = "Tra cứu";
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
        private System.Windows.Forms.Button QUAYLAIButton;
        private System.Windows.Forms.Button XemChiTietButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button XemTatCaButton;
    }
}