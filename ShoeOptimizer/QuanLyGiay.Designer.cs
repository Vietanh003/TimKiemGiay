namespace ShoeOptimizer
{
    partial class QuanLyGiay
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.cbo_size = new System.Windows.Forms.ComboBox();
            this.cbo_thieu = new System.Windows.Forms.ComboBox();
            this.dtgv_dssp = new System.Windows.Forms.DataGridView();
            this.Thêm = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.txt_hinh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_chonhinh = new System.Windows.Forms.Button();
            this.picanhsp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dssp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picanhsp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TÊN SẢN PHẨM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "GIÁ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "KÍCH THƯỚC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "THƯƠNG HIỆU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "SỐ LƯỢNG";
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(269, 101);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(293, 26);
            this.txt_tensp.TabIndex = 6;
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(269, 166);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(293, 26);
            this.txt_gia.TabIndex = 7;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(269, 346);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(293, 26);
            this.txt_soluong.TabIndex = 8;
            // 
            // cbo_size
            // 
            this.cbo_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_size.FormattingEnabled = true;
            this.cbo_size.Items.AddRange(new object[] {
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34"});
            this.cbo_size.Location = new System.Drawing.Point(268, 230);
            this.cbo_size.Name = "cbo_size";
            this.cbo_size.Size = new System.Drawing.Size(294, 28);
            this.cbo_size.TabIndex = 9;
            // 
            // cbo_thieu
            // 
            this.cbo_thieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_thieu.FormattingEnabled = true;
            this.cbo_thieu.Items.AddRange(new object[] {
            "Nike",
            "Adidas",
            "Gucci",
            "MLB",
            "Puma",
            "Mira",
            "Convert"});
            this.cbo_thieu.Location = new System.Drawing.Point(269, 286);
            this.cbo_thieu.Name = "cbo_thieu";
            this.cbo_thieu.Size = new System.Drawing.Size(294, 28);
            this.cbo_thieu.TabIndex = 10;
            // 
            // dtgv_dssp
            // 
            this.dtgv_dssp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_dssp.Location = new System.Drawing.Point(60, 470);
            this.dtgv_dssp.Name = "dtgv_dssp";
            this.dtgv_dssp.RowHeadersWidth = 62;
            this.dtgv_dssp.RowTemplate.Height = 28;
            this.dtgv_dssp.Size = new System.Drawing.Size(810, 261);
            this.dtgv_dssp.TabIndex = 11;
            this.dtgv_dssp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_dssp_CellClick);
            // 
            // Thêm
            // 
            this.Thêm.Location = new System.Drawing.Point(625, 96);
            this.Thêm.Name = "Thêm";
            this.Thêm.Size = new System.Drawing.Size(115, 43);
            this.Thêm.TabIndex = 12;
            this.Thêm.Text = "Thêm";
            this.Thêm.UseVisualStyleBackColor = true;
            this.Thêm.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(1050, 94);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(115, 45);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(772, 96);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(115, 43);
            this.btn_sua.TabIndex = 14;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Location = new System.Drawing.Point(914, 96);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(115, 43);
            this.btn_quaylai.TabIndex = 15;
            this.btn_quaylai.Text = "Quay Lại";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // txt_hinh
            // 
            this.txt_hinh.Location = new System.Drawing.Point(270, 404);
            this.txt_hinh.Name = "txt_hinh";
            this.txt_hinh.Size = new System.Drawing.Size(293, 26);
            this.txt_hinh.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "HÌNH ẢNH";
            // 
            // btn_chonhinh
            // 
            this.btn_chonhinh.Location = new System.Drawing.Point(596, 388);
            this.btn_chonhinh.Name = "btn_chonhinh";
            this.btn_chonhinh.Size = new System.Drawing.Size(120, 44);
            this.btn_chonhinh.TabIndex = 18;
            this.btn_chonhinh.Text = "Chọn Hình";
            this.btn_chonhinh.UseVisualStyleBackColor = true;
            this.btn_chonhinh.Click += new System.EventHandler(this.btn_chonhinh_Click);
            // 
            // picanhsp
            // 
            this.picanhsp.Location = new System.Drawing.Point(625, 186);
            this.picanhsp.Name = "picanhsp";
            this.picanhsp.Size = new System.Drawing.Size(404, 196);
            this.picanhsp.TabIndex = 19;
            this.picanhsp.TabStop = false;
            // 
            // QuanLyGiay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 743);
            this.Controls.Add(this.picanhsp);
            this.Controls.Add(this.btn_chonhinh);
            this.Controls.Add(this.txt_hinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_quaylai);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.Thêm);
            this.Controls.Add(this.dtgv_dssp);
            this.Controls.Add(this.cbo_thieu);
            this.Controls.Add(this.cbo_size);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.txt_gia);
            this.Controls.Add(this.txt_tensp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyGiay";
            this.Text = "QuanLyGiay";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dssp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picanhsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.ComboBox cbo_size;
        private System.Windows.Forms.ComboBox cbo_thieu;
        private System.Windows.Forms.DataGridView dtgv_dssp;
        private System.Windows.Forms.Button Thêm;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.TextBox txt_hinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_chonhinh;
        private System.Windows.Forms.PictureBox picanhsp;
    }
}