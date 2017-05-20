namespace Presentation
{
    partial class QuanLyChuyenBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyChuyenBay));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CapNhapButton = new System.Windows.Forms.Button();
            this.XoaButton = new System.Windows.Forms.Button();
            this.ThemButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(299, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ CHUYẾN BAY";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(174, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(798, 254);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CapNhapButton);
            this.groupBox1.Controls.Add(this.XoaButton);
            this.groupBox1.Controls.Add(this.ThemButton);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 279);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // CapNhapButton
            // 
            this.CapNhapButton.BackColor = System.Drawing.Color.Aquamarine;
            this.CapNhapButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.CapNhapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CapNhapButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapNhapButton.ForeColor = System.Drawing.Color.Blue;
            this.CapNhapButton.Image = ((System.Drawing.Image)(resources.GetObject("CapNhapButton.Image")));
            this.CapNhapButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CapNhapButton.Location = new System.Drawing.Point(16, 215);
            this.CapNhapButton.Name = "CapNhapButton";
            this.CapNhapButton.Size = new System.Drawing.Size(113, 47);
            this.CapNhapButton.TabIndex = 2;
            this.CapNhapButton.Text = "Cập nhập";
            this.CapNhapButton.UseVisualStyleBackColor = false;
            this.CapNhapButton.Click += new System.EventHandler(this.CapNhapButton_Click);
            this.CapNhapButton.MouseLeave += new System.EventHandler(this.CapNhapButton_MouseLeave);
            this.CapNhapButton.MouseHover += new System.EventHandler(this.CapNhapButton_MouseHover);
            // 
            // XoaButton
            // 
            this.XoaButton.BackColor = System.Drawing.Color.Aquamarine;
            this.XoaButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.XoaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XoaButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaButton.ForeColor = System.Drawing.Color.Blue;
            this.XoaButton.Image = ((System.Drawing.Image)(resources.GetObject("XoaButton.Image")));
            this.XoaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XoaButton.Location = new System.Drawing.Point(16, 121);
            this.XoaButton.Name = "XoaButton";
            this.XoaButton.Size = new System.Drawing.Size(113, 47);
            this.XoaButton.TabIndex = 1;
            this.XoaButton.Text = "Hủy";
            this.XoaButton.UseVisualStyleBackColor = false;
            this.XoaButton.Click += new System.EventHandler(this.XoaButton_Click);
            this.XoaButton.MouseLeave += new System.EventHandler(this.XoaButton_MouseLeave);
            this.XoaButton.MouseHover += new System.EventHandler(this.XoaButton_MouseHover);
            // 
            // ThemButton
            // 
            this.ThemButton.BackColor = System.Drawing.Color.Aquamarine;
            this.ThemButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ThemButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.ThemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemButton.ForeColor = System.Drawing.Color.Blue;
            this.ThemButton.Image = ((System.Drawing.Image)(resources.GetObject("ThemButton.Image")));
            this.ThemButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemButton.Location = new System.Drawing.Point(16, 30);
            this.ThemButton.Name = "ThemButton";
            this.ThemButton.Size = new System.Drawing.Size(113, 47);
            this.ThemButton.TabIndex = 0;
            this.ThemButton.Text = "Thêm";
            this.ThemButton.UseVisualStyleBackColor = false;
            this.ThemButton.Click += new System.EventHandler(this.ThemButton_Click);
            this.ThemButton.MouseLeave += new System.EventHandler(this.ThemButton_MouseLeave);
            this.ThemButton.MouseHover += new System.EventHandler(this.ThemButton_MouseHover);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(174, 448);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(798, 135);
            this.dataGridView2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(174, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tìm mã chuyến bay : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(371, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.Location = new System.Drawing.Point(578, 95);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(32, 23);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(173, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chi tiết chuyến bay";
            // 
            // QuanLyChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 608);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyChuyenBay";
            this.Text = "QuanLyChuyenBay";
            this.Load += new System.EventHandler(this.QuanLyChuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CapNhapButton;
        private System.Windows.Forms.Button XoaButton;
        private System.Windows.Forms.Button ThemButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchButton;
        protected System.Windows.Forms.Label label3;

    }
}