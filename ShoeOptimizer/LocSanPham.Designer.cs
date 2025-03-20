namespace ShoeOptimizer
{
    partial class LocSanPham
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
            this.cbo_thieu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgv_dsdc = new System.Windows.Forms.DataGridView();
            this.dtgv_dssp = new System.Windows.Forms.DataGridView();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btn_chontoiuu = new System.Windows.Forms.Button();
            this.cbo_size = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.lbl_tongchiphi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoGiaThapNhat = new System.Windows.Forms.RadioButton();
            this.rdoGiaCaoNhat = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dsdc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dssp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_thieu
            // 
            this.cbo_thieu.FormattingEnabled = true;
            this.cbo_thieu.Items.AddRange(new object[] {
            "Nike",
            "Adidas",
            "Gucci",
            "MLB",
            "Puma",
            "Mira",
            "Convert"});
            this.cbo_thieu.Location = new System.Drawing.Point(598, 66);
            this.cbo_thieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_thieu.Name = "cbo_thieu";
            this.cbo_thieu.Size = new System.Drawing.Size(155, 24);
            this.cbo_thieu.TabIndex = 31;
            this.cbo_thieu.SelectedIndexChanged += new System.EventHandler(this.cbo_thieu_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 29);
            this.label6.TabIndex = 30;
            this.label6.Text = "Danh sách được chọn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "Danh sách sản phẩm";
            // 
            // dtgv_dsdc
            // 
            this.dtgv_dsdc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_dsdc.Location = new System.Drawing.Point(61, 408);
            this.dtgv_dsdc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_dsdc.Name = "dtgv_dsdc";
            this.dtgv_dsdc.RowHeadersWidth = 62;
            this.dtgv_dsdc.RowTemplate.Height = 28;
            this.dtgv_dsdc.Size = new System.Drawing.Size(977, 151);
            this.dtgv_dsdc.TabIndex = 28;
            // 
            // dtgv_dssp
            // 
            this.dtgv_dssp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_dssp.Location = new System.Drawing.Point(61, 204);
            this.dtgv_dssp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_dssp.Name = "dtgv_dssp";
            this.dtgv_dssp.RowHeadersWidth = 62;
            this.dtgv_dssp.RowTemplate.Height = 28;
            this.dtgv_dssp.Size = new System.Drawing.Size(977, 151);
            this.dtgv_dssp.TabIndex = 27;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(900, 506);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(44, 16);
            this.lblTotalCost.TabIndex = 26;
            this.lblTotalCost.Text = "label5";
            // 
            // btn_chontoiuu
            // 
            this.btn_chontoiuu.Location = new System.Drawing.Point(865, 107);
            this.btn_chontoiuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_chontoiuu.Name = "btn_chontoiuu";
            this.btn_chontoiuu.Size = new System.Drawing.Size(173, 46);
            this.btn_chontoiuu.TabIndex = 25;
            this.btn_chontoiuu.Text = "Chọn Tối Uu";
            this.btn_chontoiuu.UseVisualStyleBackColor = true;
            this.btn_chontoiuu.Click += new System.EventHandler(this.btn_chontoiuu_Click);
            // 
            // cbo_size
            // 
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
            this.cbo_size.Location = new System.Drawing.Point(903, 66);
            this.cbo_size.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_size.Name = "cbo_size";
            this.cbo_size.Size = new System.Drawing.Size(136, 24);
            this.cbo_size.TabIndex = 24;
            this.cbo_size.SelectedIndexChanged += new System.EventHandler(this.cbo_size_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(783, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Chọn Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Chọn Thương Hiệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nhập Ngân Sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 39);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tìm Kiếm Tối Uu Theo Ngân Sách";
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(198, 66);
            this.txtBudget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(240, 22);
            this.txtBudget.TabIndex = 19;
            // 
            // lbl_tongchiphi
            // 
            this.lbl_tongchiphi.AutoSize = true;
            this.lbl_tongchiphi.Location = new System.Drawing.Point(751, 378);
            this.lbl_tongchiphi.Name = "lbl_tongchiphi";
            this.lbl_tongchiphi.Size = new System.Drawing.Size(14, 16);
            this.lbl_tongchiphi.TabIndex = 33;
            this.lbl_tongchiphi.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoGiaCaoNhat);
            this.groupBox1.Controls.Add(this.rdoGiaThapNhat);
            this.groupBox1.Location = new System.Drawing.Point(558, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 100);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "chọn theo giá cao hoặc giá thấp";
            // 
            // rdoGiaThapNhat
            // 
            this.rdoGiaThapNhat.AutoSize = true;
            this.rdoGiaThapNhat.Location = new System.Drawing.Point(28, 33);
            this.rdoGiaThapNhat.Name = "rdoGiaThapNhat";
            this.rdoGiaThapNhat.Size = new System.Drawing.Size(103, 20);
            this.rdoGiaThapNhat.TabIndex = 0;
            this.rdoGiaThapNhat.TabStop = true;
            this.rdoGiaThapNhat.Text = "radioButton1";
            this.rdoGiaThapNhat.UseVisualStyleBackColor = true;
            // 
            // rdoGiaCaoNhat
            // 
            this.rdoGiaCaoNhat.AutoSize = true;
            this.rdoGiaCaoNhat.Location = new System.Drawing.Point(28, 59);
            this.rdoGiaCaoNhat.Name = "rdoGiaCaoNhat";
            this.rdoGiaCaoNhat.Size = new System.Drawing.Size(103, 20);
            this.rdoGiaCaoNhat.TabIndex = 1;
            this.rdoGiaCaoNhat.TabStop = true;
            this.rdoGiaCaoNhat.Text = "radioButton2";
            this.rdoGiaCaoNhat.UseVisualStyleBackColor = true;
            // 
            // LocSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 578);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_tongchiphi);
            this.Controls.Add(this.cbo_thieu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgv_dsdc);
            this.Controls.Add(this.dtgv_dssp);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.btn_chontoiuu);
            this.Controls.Add(this.cbo_size);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBudget);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LocSanPham";
            this.Text = "LocSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dsdc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dssp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_thieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgv_dsdc;
        private System.Windows.Forms.DataGridView dtgv_dssp;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btn_chontoiuu;
        private System.Windows.Forms.ComboBox cbo_size;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.Label lbl_tongchiphi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoGiaCaoNhat;
        private System.Windows.Forms.RadioButton rdoGiaThapNhat;
    }
}