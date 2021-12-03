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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        #region khai báo đối tượng toàn cục
        NhanVien NhanVienCurrent = new NhanVien();
        #endregion

        #region load dữ liệu vào các control

        #endregion

        #region nút thêm
        //public int InsertNV()
        //{
        //    NhanVien nv = new NhanVien();
        //    nv.MaNV = "0";
        //    // kiểm tra các ô đã đầy đủ thông tin hay chưa
        //    if (txtHoTen.Text == "" || txtDiaChi.Text == "" || txtDiaChi.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng kiểm tra đầy đủ dữ liệu trước khi thêm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    else
        //    {
        //        nv.HoTen = txtHoTen.Text;
        //        nv.DiaChi = txtDiaChi.Text;
        //        nv.GioiTinh = cbbGT.Text;
        //        nv.NgaySinh = dtpNgaySinh.Text;
        //        nv.SoDienThoai = txtSDT.Text;
        //        nv.MaNV = txtMaNV.Text;
        //        // khai báo đối tượng NuocUongBL từ tầng Business
        //        NhanVienBL nvBL = new NhanVienBL();
        //        // chèn dữ liệu vào
        //        return nvBL.Insert(nv);

        //    }
        //    return -1;
        //}
        private void btnThem_Click(object sender, EventArgs e)
        {
        //    int result = InsertNV();
        //    if (result > 0)
        //    {
        //        MessageBox.Show("Đã thêm dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Thêm thất bại, vui lòng nhập lại");
        //        DialogResult = DialogResult.OK;
        //    }
        }
        #endregion

        #region nút reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            cbbGT.SelectedValue = "Khác";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtHoTen.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
        }

        #endregion

        #region nút huỷ
        private void btnHuy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chắc chắn muốn thoát không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            this.Close();
        }
        #endregion

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
