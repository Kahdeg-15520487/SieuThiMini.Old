namespace SieuThiMini.WinForm
{
    partial class ChiTietSanPham
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
            this.button_create = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.textBox_masp = new System.Windows.Forms.TextBox();
            this.textBox_tensp = new System.Windows.Forms.TextBox();
            this.textBox_soluong = new System.Windows.Forms.TextBox();
            this.textBox_dongia = new System.Windows.Forms.TextBox();
            this.textBox_xuatxu = new System.Windows.Forms.TextBox();
            this.label_er_masp = new System.Windows.Forms.Label();
            this.label_er_tensp = new System.Windows.Forms.Label();
            this.label_er_soluong = new System.Windows.Forms.Label();
            this.label_er_dongia = new System.Windows.Forms.Label();
            this.label_er_xuatxu = new System.Windows.Forms.Label();
            this.label_er_danhmuc = new System.Windows.Forms.Label();
            this.comboBox_danhMuc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Xuất xứ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Danh mục";
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(12, 177);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(120, 36);
            this.button_create.TabIndex = 6;
            this.button_create.Text = "Thêm sản phẩm";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // button_exit
            // 
            this.button_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_exit.Location = new System.Drawing.Point(188, 177);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(120, 36);
            this.button_exit.TabIndex = 7;
            this.button_exit.Text = "Thoát";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // textBox_masp
            // 
            this.textBox_masp.Location = new System.Drawing.Point(85, 6);
            this.textBox_masp.Name = "textBox_masp";
            this.textBox_masp.Size = new System.Drawing.Size(147, 20);
            this.textBox_masp.TabIndex = 8;
            // 
            // textBox_tensp
            // 
            this.textBox_tensp.Location = new System.Drawing.Point(85, 32);
            this.textBox_tensp.Name = "textBox_tensp";
            this.textBox_tensp.Size = new System.Drawing.Size(147, 20);
            this.textBox_tensp.TabIndex = 9;
            // 
            // textBox_soluong
            // 
            this.textBox_soluong.Location = new System.Drawing.Point(85, 58);
            this.textBox_soluong.Name = "textBox_soluong";
            this.textBox_soluong.Size = new System.Drawing.Size(147, 20);
            this.textBox_soluong.TabIndex = 10;
            // 
            // textBox_dongia
            // 
            this.textBox_dongia.Location = new System.Drawing.Point(85, 84);
            this.textBox_dongia.Name = "textBox_dongia";
            this.textBox_dongia.Size = new System.Drawing.Size(147, 20);
            this.textBox_dongia.TabIndex = 11;
            // 
            // textBox_xuatxu
            // 
            this.textBox_xuatxu.Location = new System.Drawing.Point(85, 110);
            this.textBox_xuatxu.Name = "textBox_xuatxu";
            this.textBox_xuatxu.Size = new System.Drawing.Size(147, 20);
            this.textBox_xuatxu.TabIndex = 12;
            // 
            // label_er_masp
            // 
            this.label_er_masp.AutoSize = true;
            this.label_er_masp.Location = new System.Drawing.Point(238, 9);
            this.label_er_masp.Name = "label_er_masp";
            this.label_er_masp.Size = new System.Drawing.Size(0, 13);
            this.label_er_masp.TabIndex = 14;
            // 
            // label_er_tensp
            // 
            this.label_er_tensp.AutoSize = true;
            this.label_er_tensp.Location = new System.Drawing.Point(238, 35);
            this.label_er_tensp.Name = "label_er_tensp";
            this.label_er_tensp.Size = new System.Drawing.Size(0, 13);
            this.label_er_tensp.TabIndex = 15;
            // 
            // label_er_soluong
            // 
            this.label_er_soluong.AutoSize = true;
            this.label_er_soluong.Location = new System.Drawing.Point(238, 61);
            this.label_er_soluong.Name = "label_er_soluong";
            this.label_er_soluong.Size = new System.Drawing.Size(0, 13);
            this.label_er_soluong.TabIndex = 16;
            // 
            // label_er_dongia
            // 
            this.label_er_dongia.AutoSize = true;
            this.label_er_dongia.Location = new System.Drawing.Point(238, 87);
            this.label_er_dongia.Name = "label_er_dongia";
            this.label_er_dongia.Size = new System.Drawing.Size(0, 13);
            this.label_er_dongia.TabIndex = 17;
            // 
            // label_er_xuatxu
            // 
            this.label_er_xuatxu.AutoSize = true;
            this.label_er_xuatxu.Location = new System.Drawing.Point(238, 113);
            this.label_er_xuatxu.Name = "label_er_xuatxu";
            this.label_er_xuatxu.Size = new System.Drawing.Size(0, 13);
            this.label_er_xuatxu.TabIndex = 18;
            // 
            // label_er_danhmuc
            // 
            this.label_er_danhmuc.AutoSize = true;
            this.label_er_danhmuc.Location = new System.Drawing.Point(238, 139);
            this.label_er_danhmuc.Name = "label_er_danhmuc";
            this.label_er_danhmuc.Size = new System.Drawing.Size(0, 13);
            this.label_er_danhmuc.TabIndex = 19;
            // 
            // comboBox_danhMuc
            // 
            this.comboBox_danhMuc.FormattingEnabled = true;
            this.comboBox_danhMuc.Location = new System.Drawing.Point(85, 139);
            this.comboBox_danhMuc.Name = "comboBox_danhMuc";
            this.comboBox_danhMuc.Size = new System.Drawing.Size(147, 21);
            this.comboBox_danhMuc.TabIndex = 20;
            // 
            // ChiTietSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 225);
            this.Controls.Add(this.comboBox_danhMuc);
            this.Controls.Add(this.label_er_danhmuc);
            this.Controls.Add(this.label_er_xuatxu);
            this.Controls.Add(this.label_er_dongia);
            this.Controls.Add(this.label_er_soluong);
            this.Controls.Add(this.label_er_tensp);
            this.Controls.Add(this.label_er_masp);
            this.Controls.Add(this.textBox_xuatxu);
            this.Controls.Add(this.textBox_dongia);
            this.Controls.Add(this.textBox_soluong);
            this.Controls.Add(this.textBox_tensp);
            this.Controls.Add(this.textBox_masp);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChiTietSanPham";
            this.Text = "ChiTietSanPham";
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
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.TextBox textBox_masp;
        private System.Windows.Forms.TextBox textBox_tensp;
        private System.Windows.Forms.TextBox textBox_soluong;
        private System.Windows.Forms.TextBox textBox_dongia;
        private System.Windows.Forms.TextBox textBox_xuatxu;
        private System.Windows.Forms.Label label_er_masp;
        private System.Windows.Forms.Label label_er_tensp;
        private System.Windows.Forms.Label label_er_soluong;
        private System.Windows.Forms.Label label_er_dongia;
        private System.Windows.Forms.Label label_er_xuatxu;
        private System.Windows.Forms.Label label_er_danhmuc;
        private System.Windows.Forms.ComboBox comboBox_danhMuc;
    }
}