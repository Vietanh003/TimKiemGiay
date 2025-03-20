namespace ShoeOptimizer
{
    partial class DangNhap
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.btn_dangky = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_confirmPass = new System.Windows.Forms.Label();
            this.txt_confirmPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(312, 124);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(317, 26);
            this.txt_name.TabIndex = 0;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(312, 215);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(317, 26);
            this.txt_pass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật Khẩu";
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_xacnhan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xacnhan.Location = new System.Drawing.Point(362, 365);
            this.btn_xacnhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(220, 60);
            this.btn_xacnhan.TabIndex = 4;
            this.btn_xacnhan.Text = "Xác Nhận";
            this.btn_xacnhan.UseVisualStyleBackColor = false;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // btn_dangky
            // 
            this.btn_dangky.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_dangky.Location = new System.Drawing.Point(548, 446);
            this.btn_dangky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dangky.Name = "btn_dangky";
            this.btn_dangky.Size = new System.Drawing.Size(194, 44);
            this.btn_dangky.TabIndex = 5;
            this.btn_dangky.Text = "Đăng Ký";
            this.btn_dangky.UseVisualStyleBackColor = false;
            this.btn_dangky.Click += new System.EventHandler(this.btn_dangky_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(290, 26);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(292, 52);
            this.lbl_title.TabIndex = 6;
            this.lbl_title.Text = "ĐĂNG NHẬP";
            // 
            // lbl_confirmPass
            // 
            this.lbl_confirmPass.AutoSize = true;
            this.lbl_confirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmPass.Location = new System.Drawing.Point(30, 298);
            this.lbl_confirmPass.Name = "lbl_confirmPass";
            this.lbl_confirmPass.Size = new System.Drawing.Size(241, 29);
            this.lbl_confirmPass.TabIndex = 8;
            this.lbl_confirmPass.Text = "Xác Nhận Mật Khẩu";
            // 
            // txt_confirmPass
            // 
            this.txt_confirmPass.Location = new System.Drawing.Point(312, 298);
            this.txt_confirmPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_confirmPass.Name = "txt_confirmPass";
            this.txt_confirmPass.Size = new System.Drawing.Size(317, 26);
            this.txt_confirmPass.TabIndex = 7;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 528);
            this.Controls.Add(this.lbl_confirmPass);
            this.Controls.Add(this.txt_confirmPass);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_dangky);
            this.Controls.Add(this.btn_xacnhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_xacnhan;
        private System.Windows.Forms.Button btn_dangky;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_confirmPass;
        private System.Windows.Forms.TextBox txt_confirmPass;
    }
}