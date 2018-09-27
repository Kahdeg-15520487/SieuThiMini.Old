namespace SieuThiMini.WinForm
{
    partial class MainForm
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
            this.listView_danhMuc = new System.Windows.Forms.ListView();
            this.button_get_sanPham = new System.Windows.Forms.Button();
            this.button_delete_sanPham = new System.Windows.Forms.Button();
            this.button_thoat = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView_danhMuc
            // 
            this.listView_danhMuc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_danhMuc.FullRowSelect = true;
            this.listView_danhMuc.Location = new System.Drawing.Point(15, 11);
            this.listView_danhMuc.Name = "listView_danhMuc";
            this.listView_danhMuc.Size = new System.Drawing.Size(483, 215);
            this.listView_danhMuc.TabIndex = 0;
            this.listView_danhMuc.UseCompatibleStateImageBehavior = false;
            this.listView_danhMuc.View = System.Windows.Forms.View.Details;
            // 
            // button_get_sanPham
            // 
            this.button_get_sanPham.Location = new System.Drawing.Point(15, 232);
            this.button_get_sanPham.Name = "button_get_sanPham";
            this.button_get_sanPham.Size = new System.Drawing.Size(155, 77);
            this.button_get_sanPham.TabIndex = 1;
            this.button_get_sanPham.Text = "Xem danh sách sản phẩm";
            this.button_get_sanPham.UseVisualStyleBackColor = true;
            this.button_get_sanPham.Click += new System.EventHandler(this.button_get_sanPham_Click);
            // 
            // button_delete_sanPham
            // 
            this.button_delete_sanPham.Location = new System.Drawing.Point(176, 232);
            this.button_delete_sanPham.Name = "button_delete_sanPham";
            this.button_delete_sanPham.Size = new System.Drawing.Size(160, 77);
            this.button_delete_sanPham.TabIndex = 2;
            this.button_delete_sanPham.Text = "Xóa danh sách sản phẩm";
            this.button_delete_sanPham.UseVisualStyleBackColor = true;
            this.button_delete_sanPham.Click += new System.EventHandler(this.button_delete_sanPham_Click);
            // 
            // button_thoat
            // 
            this.button_thoat.Location = new System.Drawing.Point(342, 232);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(156, 77);
            this.button_thoat.TabIndex = 3;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã danh mục";
            this.columnHeader1.Width = 144;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên danh mục";
            this.columnHeader2.Width = 182;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số sản phẩm";
            this.columnHeader3.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 321);
            this.Controls.Add(this.button_thoat);
            this.Controls.Add(this.button_delete_sanPham);
            this.Controls.Add(this.button_get_sanPham);
            this.Controls.Add(this.listView_danhMuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_danhMuc;
        private System.Windows.Forms.Button button_get_sanPham;
        private System.Windows.Forms.Button button_delete_sanPham;
        private System.Windows.Forms.Button button_thoat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

