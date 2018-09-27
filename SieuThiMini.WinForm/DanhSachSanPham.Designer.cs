namespace SieuThiMini.WinForm
{
    partial class DanhSachSanPham
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
            this.listView_sanPham = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_create_sanPham = new System.Windows.Forms.Button();
            this.button_update_sanPham = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_delete_sanPham = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_sanPham
            // 
            this.listView_sanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_sanPham.FullRowSelect = true;
            this.listView_sanPham.Location = new System.Drawing.Point(12, 84);
            this.listView_sanPham.Name = "listView_sanPham";
            this.listView_sanPham.Size = new System.Drawing.Size(585, 236);
            this.listView_sanPham.TabIndex = 0;
            this.listView_sanPham.UseCompatibleStateImageBehavior = false;
            this.listView_sanPham.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Sản phẩm";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Sản phẩm";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Xuất xứ";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Danh mục";
            // 
            // button_create_sanPham
            // 
            this.button_create_sanPham.Location = new System.Drawing.Point(12, 12);
            this.button_create_sanPham.Name = "button_create_sanPham";
            this.button_create_sanPham.Size = new System.Drawing.Size(140, 65);
            this.button_create_sanPham.TabIndex = 1;
            this.button_create_sanPham.Text = "Thêm sản phẩm";
            this.button_create_sanPham.UseVisualStyleBackColor = true;
            this.button_create_sanPham.Click += new System.EventHandler(this.button_create_sanPham_Click);
            // 
            // button_update_sanPham
            // 
            this.button_update_sanPham.Location = new System.Drawing.Point(159, 12);
            this.button_update_sanPham.Name = "button_update_sanPham";
            this.button_update_sanPham.Size = new System.Drawing.Size(140, 65);
            this.button_update_sanPham.TabIndex = 2;
            this.button_update_sanPham.Text = "Cập nhật sản phẩm";
            this.button_update_sanPham.UseVisualStyleBackColor = true;
            this.button_update_sanPham.Click += new System.EventHandler(this.button_update_sanPham_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(472, 12);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(125, 65);
            this.button_exit.TabIndex = 3;
            this.button_exit.Text = "Thoát";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_delete_sanPham
            // 
            this.button_delete_sanPham.Location = new System.Drawing.Point(305, 12);
            this.button_delete_sanPham.Name = "button_delete_sanPham";
            this.button_delete_sanPham.Size = new System.Drawing.Size(140, 65);
            this.button_delete_sanPham.TabIndex = 4;
            this.button_delete_sanPham.Text = "Xóa sản phẩm";
            this.button_delete_sanPham.UseVisualStyleBackColor = true;
            this.button_delete_sanPham.Click += new System.EventHandler(this.button_delete_sanPham_Click);
            // 
            // DanhSachSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 332);
            this.Controls.Add(this.button_delete_sanPham);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_update_sanPham);
            this.Controls.Add(this.button_create_sanPham);
            this.Controls.Add(this.listView_sanPham);
            this.Name = "DanhSachSanPham";
            this.Text = "DanhSachSanPham";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_sanPham;
        private System.Windows.Forms.Button button_create_sanPham;
        private System.Windows.Forms.Button button_update_sanPham;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_delete_sanPham;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}