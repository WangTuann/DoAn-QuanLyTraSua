using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;
namespace Quản_lý_quán_trà_sữa
{

	public partial class frmAccount : Form
	{
		//ds toan cuc bang cate
		List<TaiKhoan> listTaiKhoan = new List<TaiKhoan>();

		List<ChucVu> listCV = new List<ChucVu>();
		//doi tuong tkhoan dang chon hien hanh
		TaiKhoan currentTK = new TaiKhoan();
		public frmAccount()
		{
			InitializeComponent();
			
		}
		private void btnHuy_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có đăng xuất ứng dụng hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
			{
				txtHoTen.Text = "";
				//txtMaNV.Text = "";
				txtTenDangNhap.Text = "";
				txtMK.Text = "";
				//txtChucVu.Text = "";
			}
		}

        private void frmAccount_Load(object sender, EventArgs e)
        {
			LoadData_TK_ToListView();
		}


		public void LoadData_TK_ToListView()
        {
			//goi doi tuong TaiKhoanBL tu tang BL
			TaiKhoanBL tkBL = new TaiKhoanBL();
			//lay data
			listTaiKhoan = tkBL.GetAll();
			int count = 1;
			lvTaiKhoan.Items.Clear();
			//duyet mang
			foreach (var taiKhoan in listTaiKhoan)
            {
				ListViewItem item = lvTaiKhoan.Items.Add(count.ToString());
				item.SubItems.Add(taiKhoan.TenTaiKhoan);
				item.SubItems.Add(taiKhoan.MatKhau);
				item.SubItems.Add(taiKhoan.HoTen);
				item.SubItems.Add(taiKhoan.Email);
				item.SubItems.Add(taiKhoan.SoDienThoai);
				item.SubItems.Add(taiKhoan.NgayTao);
				item.SubItems.Add(taiKhoan.TrangThai.ToString());
				//string tenCV = listCV.Find(x => x.MaCV == taiKhoan.MaCV).TenChucVu;
				item.SubItems.Add(taiKhoan.MaCV.ToString());
				count++;
			}
        }

		//ham them tk
		public int Insert_TaiKhoan()
        {
			TaiKhoan tk = new TaiKhoan();
			//
			;
            if (txtTenDangNhap.Text==""||txtMK.Text==""||txtHoTen.Text=="")
            {
				MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
			}
            else
            {
				tk.TenTaiKhoan = txtTenDangNhap.Text;
				tk.MatKhau = txtMK.Text;
				tk.HoTen = txtHoTen.Text;
				tk.NgayTao = dtpNgayTao.Value.ToString();
				tk.SoDienThoai = txtSDT.Text;
				TaiKhoanBL tkbl = new TaiKhoanBL();
				return tkbl.Insert(tk);
            }
			return -1;


		}

        private void btnThem_Click(object sender, EventArgs e)
        {
			int result = Insert_TaiKhoan();
            if (result>0)
            {
				MessageBox.Show("Thêm sinh viên thành công");
			}
			else MessageBox.Show("Thêm thất bại, vui lòng nhập lại");
			DialogResult = DialogResult.OK;
		}
    }
}
