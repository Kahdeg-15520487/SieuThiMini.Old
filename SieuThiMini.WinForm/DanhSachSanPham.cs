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

namespace SieuThiMini.WinForm
{
    public partial class DanhSachSanPham : Form
    {
        private readonly ISanPhamService _sanPhamService;
        private readonly IServiceProvider _serviceProvider;

        public string DanhMuc { get; internal set; }

        public DanhSachSanPham(ISanPhamService sanPhamService, IServiceProvider serviceProvider)
        {
            _sanPhamService = sanPhamService;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            RefreshListView();

            base.OnShown(e);
        }

        private void RefreshListView()
        {
            listView_sanPham.Items.Clear();

            foreach (var sp in _sanPhamService.GetSanPhams().ToList())
            {
                ListViewItem lvi = new ListViewItem
                {
                    Text = sp.MaSanPham
                };
                lvi.SubItems.Add(sp.TenSanPham);
                lvi.SubItems.Add(sp.SoLuong.ToString());
                lvi.SubItems.Add(sp.DonGia.ToString());
                lvi.SubItems.Add(sp.XuatXu);
                lvi.SubItems.Add(sp.DanhMuc.TenDanhMuc);

                listView_sanPham.Items.Add(lvi);
            }

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_create_sanPham_Click(object sender, EventArgs e)
        {
            var chiTietSanPham = _serviceProvider.GetService<ChiTietSanPham>();
            chiTietSanPham.Mode = ChiTietSanPhamMode.TaoMoi;
            chiTietSanPham.SanPham = new Contract.DTOs.SanPhamDTO();

            if (chiTietSanPham.ShowDialog() == DialogResult.OK)
            {
                RefreshListView();
            }
        }

        private void button_update_sanPham_Click(object sender, EventArgs e)
        {
            var maSP = GetSelectedSanPham();
            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Xin hãy chọn 1 sản phẩm để cập nhật!");
                return;
            }

            var chiTietSanPham = _serviceProvider.GetService<ChiTietSanPham>();
            chiTietSanPham.Mode = ChiTietSanPhamMode.CapNhat;
            chiTietSanPham.SanPham = _sanPhamService.GetSanPham(maSP);

            if (chiTietSanPham.ShowDialog() == DialogResult.OK)
            {
                RefreshListView();
            }
        }

        private void button_delete_sanPham_Click(object sender, EventArgs e)
        {
            var maSP = GetSelectedSanPham();
            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Xin hãy chọn 1 sản phẩm để xóa!");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm: {maSP}", "Cảnh báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }

            try
            {
                if (_sanPhamService.DeleteSanPham(maSP))
                {
                    RefreshListView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetSelectedSanPham()
        {
            if (listView_sanPham.SelectedItems.Count == 0)
            {
                return null;
            }
            else
            {
                return listView_sanPham.SelectedItems[0].Text;
            }
        }
    }
}
