using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

using SieuThiMini.AppService;
using SieuThiMini.DAL;
using SieuThiMini.Contract.IServices;
using SieuThiMini.Contract.DTOs;
using System.Drawing;

namespace SieuThiMini.WinForm
{
    public enum ChiTietSanPhamMode
    {
        TaoMoi,
        CapNhat
    }
    public partial class ChiTietSanPham : Form
    {
        private readonly ISanPhamService _sanPhamService;
        private readonly IDanhMucService _danhMucService;

        public ChiTietSanPhamMode Mode { get; set; } = ChiTietSanPhamMode.TaoMoi;

        public SanPhamDTO SanPham { get; set; }

        public ChiTietSanPham(ISanPhamService sanPhamService, IDanhMucService danhMucService)
        {
            _sanPhamService = sanPhamService;
            _danhMucService = danhMucService;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            comboBox_danhMuc.Items.Clear();
            foreach (var dm in _danhMucService.GetDanhMucs())
            {
                comboBox_danhMuc.Items.Add(dm.TenDanhMuc);
            }

            switch (Mode)
            {
                case ChiTietSanPhamMode.TaoMoi:
                    break;

                case ChiTietSanPhamMode.CapNhat:
                    textBox_masp.Enabled = false;
                    textBox_tensp.Text = SanPham.TenSanPham;
                    textBox_masp.Text = SanPham.MaSanPham;
                    textBox_soluong.Text = SanPham.SoLuong.ToString();
                    textBox_dongia.Text = SanPham.DonGia.ToString();
                    textBox_xuatxu.Text = SanPham.XuatXu;

                    comboBox_danhMuc.SelectedIndex = comboBox_danhMuc.Items.IndexOf(SanPham.DanhMuc.TenDanhMuc);
                    button_create.Text = "Cập nhật sản phẩm";
                    break;
            }

            base.OnShown(e);
        }

        private bool ValidateTextbox()
        {
            bool result = true;

            if (string.IsNullOrWhiteSpace(textBox_masp.Text))
            {
                label_er_masp.Text = "  ";
                label_er_masp.BackColor = Color.Red;
                result = false;
            }
            else
            {
                label_er_masp.BackColor = Color.Transparent;
            }

            if (string.IsNullOrWhiteSpace(textBox_tensp.Text))
            {
                label_er_tensp.Text = "  ";
                label_er_tensp.BackColor = Color.Red;
                result = false;
            }
            else
            {
                label_er_tensp.BackColor = Color.Transparent;
            }

            if (string.IsNullOrWhiteSpace(textBox_soluong.Text)
             && !int.TryParse(textBox_soluong.Text, out int sl))
            {
                label_er_soluong.Text = "  ";
                label_er_soluong.BackColor = Color.Red;
                result = false;
            }
            else
            {
                label_er_soluong.BackColor = Color.Transparent;
            }

            if (string.IsNullOrWhiteSpace(textBox_dongia.Text)
             && !int.TryParse(textBox_dongia.Text, out int dongia))
            {
                label_er_dongia.Text = "  ";
                label_er_dongia.BackColor = Color.Red;
                result = false;
            }
            else
            {
                label_er_dongia.BackColor = Color.Transparent;
            }

            if (string.IsNullOrWhiteSpace(textBox_xuatxu.Text))
            {
                label_er_xuatxu.Text = "  ";
                label_er_xuatxu.BackColor = Color.Red;
                result = false;
            }
            else
            {
                label_er_xuatxu.BackColor = Color.Transparent;
            }

            if (string.IsNullOrWhiteSpace(comboBox_danhMuc.SelectedItem?.ToString()))
            {
                label_er_danhmuc.Text = "  ";
                label_er_danhmuc.BackColor = Color.Red;
                result = false;
            }
            else
            {
                label_er_danhmuc.BackColor = Color.Transparent;
            }

            return result;
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            if (ValidateTextbox())
            {
                UpdateSanPham();
                var result = Mode == ChiTietSanPhamMode.TaoMoi ? _sanPhamService.CreateSanPham(SanPham) :
                            Mode == ChiTietSanPhamMode.CapNhat ? _sanPhamService.UpdateSanPham(SanPham) : false;
                if (result)
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void UpdateSanPham()
        {
            SanPham.MaSanPham = textBox_masp.Text;
            SanPham.TenSanPham = textBox_tensp.Text;
            SanPham.SoLuong = int.Parse(textBox_soluong.Text);
            SanPham.DonGia = int.Parse(textBox_dongia.Text);
            SanPham.XuatXu = textBox_xuatxu.Text;
            SanPham.DanhMuc = _danhMucService.GetDanhMucs().FirstOrDefault(dm => dm.TenDanhMuc.Equals(comboBox_danhMuc.SelectedItem.ToString()));
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
