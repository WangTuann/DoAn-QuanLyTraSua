using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_quán_trà_sữa
{
	public partial class frmThongKeNhanVien : Form
	{
		public frmThongKeNhanVien()
		{
			InitializeComponent();
            LoadNhanVienToListView();
        }
		#region khai báo đối tượng toàn cục
		List<NhanVien> listNhanVien = new List<NhanVien>();
        #endregion

        #region Load dữ liệu vào listview
        private void LoadNhanVienToListView()
        {
            NhanVienBL nvBL = new NhanVienBL();

            listNhanVien = nvBL.GetAll();
            int count = 1; // Biến số thứ tự
                           // Xoá dữ liệu trong ListView
            lvNhanVien.Items.Clear();
            // Duyệt mảng dữ liệu để đưa vào ListView
            foreach (var nv in listNhanVien)
            {
                ListViewItem item = lvNhanVien.Items.Add(count.ToString());

                item.SubItems.Add(nv.HoTen);
                item.SubItems.Add(nv.DiaChi);
                item.SubItems.Add(nv.GioiTinh);
                item.SubItems.Add(nv.NgaySinh);
                item.SubItems.Add(nv.SoDienThoai);

                count++;
            }
        }

        #endregion

        #region hiện dialog thêm
        private void btnThemNhanVien_Click(object sender, EventArgs e)
		{
            var themNV = new frmNhanVien();
            if (themNV.ShowDialog() == DialogResult.OK)
            {
                LoadNhanVienToListView();
            }
        }
        #endregion
    }
}
