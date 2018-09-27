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
    public partial class MainForm : Form
    {
        private readonly IDanhMucService _danhMucService;
        private readonly IServiceProvider _serviceProvider;

        public MainForm(IDanhMucService danhMucService,IServiceProvider serviceProvider)
        {
            _danhMucService = danhMucService;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            listView_danhMuc.Items.Clear();

            var dms = _danhMucService.GetDanhMucs().ToList();

            foreach (var dm in dms)
            {
                ListViewItem lvi = new ListViewItem
                {
                    Text = dm.MaDM
                };
                lvi.SubItems.Add(dm.TenDanhMuc);
                lvi.SubItems.Add(dm.SanPhams.Length.ToString());

                listView_danhMuc.Items.Add(lvi);
            }

            base.OnLoad(e);
        }

        private void button_get_sanPham_Click(object sender, EventArgs e)
        {
            var danhSachSanPham = _serviceProvider.GetService<DanhSachSanPham>();
            danhSachSanPham.DanhMuc = GetSelectedDanhMuc();

            danhSachSanPham.ShowDialog();
        }

        private string GetSelectedDanhMuc()
        {
            if (listView_danhMuc.SelectedItems.Count == 0)
            {
                return null;
            }
            else
            {
                return listView_danhMuc.SelectedItems[0].Text;
            }
        }

        private void button_delete_sanPham_Click(object sender, EventArgs e)
        {

        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
