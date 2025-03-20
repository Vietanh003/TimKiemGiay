namespace ShoeOptimizer
{
    partial class TimKiem
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
            this.cb_TenGiay = new System.Windows.Forms.ComboBox();
            this.cb_KichThuoc = new System.Windows.Forms.ComboBox();
            this.cb_ThuongHieu = new System.Windows.Forms.ComboBox();
            this.txt_SoLuongToiThieu = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.dgv_KetQua = new System.Windows.Forms.DataGridView();
            this.btn_ChonGiay = new System.Windows.Forms.Button();
            this.grp_Gia = new System.Windows.Forms.GroupBox();
            this.rb_Tren5000k = new System.Windows.Forms.RadioButton();
            this.rb_500k_3000k = new System.Windows.Forms.RadioButton();
            this.rb_Duoi500k = new System.Windows.Forms.RadioButton();
            this.btn_XemTatCa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KetQua)).BeginInit();
            this.grp_Gia.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_TenGiay
            // 
            this.cb_TenGiay.FormattingEnabled = true;
            this.cb_TenGiay.Location = new System.Drawing.Point(33, 36);
            this.cb_TenGiay.Name = "cb_TenGiay";
            this.cb_TenGiay.Size = new System.Drawing.Size(121, 24);
            this.cb_TenGiay.TabIndex = 0;
            // 
            // cb_KichThuoc
            // 
            this.cb_KichThuoc.FormattingEnabled = true;
            this.cb_KichThuoc.Location = new System.Drawing.Point(225, 36);
            this.cb_KichThuoc.Name = "cb_KichThuoc";
            this.cb_KichThuoc.Size = new System.Drawing.Size(121, 24);
            this.cb_KichThuoc.TabIndex = 4;
            // 
            // cb_ThuongHieu
            // 
            this.cb_ThuongHieu.FormattingEnabled = true;
            this.cb_ThuongHieu.Location = new System.Drawing.Point(225, 75);
            this.cb_ThuongHieu.Name = "cb_ThuongHieu";
            this.cb_ThuongHieu.Size = new System.Drawing.Size(121, 24);
            this.cb_ThuongHieu.TabIndex = 5;
            // 
            // txt_SoLuongToiThieu
            // 
            this.txt_SoLuongToiThieu.Location = new System.Drawing.Point(516, 228);
            this.txt_SoLuongToiThieu.Name = "txt_SoLuongToiThieu";
            this.txt_SoLuongToiThieu.Size = new System.Drawing.Size(100, 22);
            this.txt_SoLuongToiThieu.TabIndex = 6;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(540, 268);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 7;
            this.btn_TimKiem.Text = "button1";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // dgv_KetQua
            // 
            this.dgv_KetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KetQua.Location = new System.Drawing.Point(12, 328);
            this.dgv_KetQua.Name = "dgv_KetQua";
            this.dgv_KetQua.RowHeadersWidth = 51;
            this.dgv_KetQua.RowTemplate.Height = 24;
            this.dgv_KetQua.Size = new System.Drawing.Size(1316, 301);
            this.dgv_KetQua.TabIndex = 8;
            this.dgv_KetQua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KetQua_CellContentClick);
            this.dgv_KetQua.SelectionChanged += new System.EventHandler(this.dgv_KetQua_SelectionChanged);
            // 
            // btn_ChonGiay
            // 
            this.btn_ChonGiay.Location = new System.Drawing.Point(541, 297);
            this.btn_ChonGiay.Name = "btn_ChonGiay";
            this.btn_ChonGiay.Size = new System.Drawing.Size(75, 23);
            this.btn_ChonGiay.TabIndex = 9;
            this.btn_ChonGiay.Text = "button1";
            this.btn_ChonGiay.UseVisualStyleBackColor = true;
            // 
            // grp_Gia
            // 
            this.grp_Gia.Controls.Add(this.rb_Tren5000k);
            this.grp_Gia.Controls.Add(this.rb_500k_3000k);
            this.grp_Gia.Controls.Add(this.rb_Duoi500k);
            this.grp_Gia.Location = new System.Drawing.Point(73, 185);
            this.grp_Gia.Name = "grp_Gia";
            this.grp_Gia.Size = new System.Drawing.Size(352, 137);
            this.grp_Gia.TabIndex = 10;
            this.grp_Gia.TabStop = false;
            this.grp_Gia.Text = "groupBox1";
            // 
            // rb_Tren5000k
            // 
            this.rb_Tren5000k.AutoSize = true;
            this.rb_Tren5000k.Location = new System.Drawing.Point(6, 59);
            this.rb_Tren5000k.Name = "rb_Tren5000k";
            this.rb_Tren5000k.Size = new System.Drawing.Size(103, 20);
            this.rb_Tren5000k.TabIndex = 13;
            this.rb_Tren5000k.TabStop = true;
            this.rb_Tren5000k.Text = "radioButton3";
            this.rb_Tren5000k.UseVisualStyleBackColor = true;
            // 
            // rb_500k_3000k
            // 
            this.rb_500k_3000k.AutoSize = true;
            this.rb_500k_3000k.Location = new System.Drawing.Point(6, 33);
            this.rb_500k_3000k.Name = "rb_500k_3000k";
            this.rb_500k_3000k.Size = new System.Drawing.Size(103, 20);
            this.rb_500k_3000k.TabIndex = 12;
            this.rb_500k_3000k.TabStop = true;
            this.rb_500k_3000k.Text = "radioButton2";
            this.rb_500k_3000k.UseVisualStyleBackColor = true;
            // 
            // rb_Duoi500k
            // 
            this.rb_Duoi500k.AutoSize = true;
            this.rb_Duoi500k.Location = new System.Drawing.Point(6, 7);
            this.rb_Duoi500k.Name = "rb_Duoi500k";
            this.rb_Duoi500k.Size = new System.Drawing.Size(103, 20);
            this.rb_Duoi500k.TabIndex = 11;
            this.rb_Duoi500k.TabStop = true;
            this.rb_Duoi500k.Text = "radioButton1";
            this.rb_Duoi500k.UseVisualStyleBackColor = true;
            // 
            // btn_XemTatCa
            // 
            this.btn_XemTatCa.Location = new System.Drawing.Point(664, 268);
            this.btn_XemTatCa.Name = "btn_XemTatCa";
            this.btn_XemTatCa.Size = new System.Drawing.Size(75, 23);
            this.btn_XemTatCa.TabIndex = 12;
            this.btn_XemTatCa.Text = "button1";
            this.btn_XemTatCa.UseVisualStyleBackColor = true;
            this.btn_XemTatCa.Click += new System.EventHandler(this.btn_XemTatCa_Click);
            // 
            // TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 676);
            this.Controls.Add(this.btn_XemTatCa);
            this.Controls.Add(this.grp_Gia);
            this.Controls.Add(this.btn_ChonGiay);
            this.Controls.Add(this.dgv_KetQua);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_SoLuongToiThieu);
            this.Controls.Add(this.cb_ThuongHieu);
            this.Controls.Add(this.cb_KichThuoc);
            this.Controls.Add(this.cb_TenGiay);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TimKiem";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KetQua)).EndInit();
            this.grp_Gia.ResumeLayout(false);
            this.grp_Gia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_TenGiay;
        private System.Windows.Forms.ComboBox cb_KichThuoc;
        private System.Windows.Forms.ComboBox cb_ThuongHieu;
        private System.Windows.Forms.TextBox txt_SoLuongToiThieu;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridView dgv_KetQua;
        private System.Windows.Forms.Button btn_ChonGiay;
        private System.Windows.Forms.GroupBox grp_Gia;
        private System.Windows.Forms.RadioButton rb_Tren5000k;
        private System.Windows.Forms.RadioButton rb_500k_3000k;
        private System.Windows.Forms.RadioButton rb_Duoi500k;
        private System.Windows.Forms.Button btn_XemTatCa;
    }
}

