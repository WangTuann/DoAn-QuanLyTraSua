using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class NhanVienBL
    {
        NhanVienDA nvDA = new NhanVienDA();

        public List<NhanVien> GetAll()
        {
            return nvDA.GetAll();
        }

        public NhanVien GetByID(string maNV)
        {
            List<NhanVien> list = GetAll();

            foreach (var item in list)
            {
                if (item.MaNV == maNV) // Nếu gặp khoá chính
                    return item; // thì trả về kết quả
            }
            return null;
        }
        //Phương thức tìm kiếm theo khoá
        public List<NhanVien> Find(string key)
        {
            List<NhanVien> list = GetAll(); // Lấy hết
            List<NhanVien> result = new List<NhanVien>();
            // Duyệt theo danh sách
            foreach (var item in list)
            {
                // Nếu từng trường chứa từ khoá
                if (item.MaNV.ToString().Contains(key)
                || item.HoTen.Contains(key)
                || item.DiaChi.Contains(key)
                || item.GioiTinh.Contains(key)
                || item.NgaySinh.ToString().Contains(key)
                || item.SoDienThoai.Contains(key))
                    result.Add(item); // Thì thêm vào danh sách kết quả
            }
            return result;
        }
        //Phương thức thêm dữ liệu
        //public int Insert(NhanVien nv)
        //{
        //    //return nvDA.Insert_Update_Delete(nv, 0);
        //}
        //Phương thức cập nhật dữ liệu
        //public int Update(NhanVien nv)
        //{
        //   // return nvDA.Insert_Update_Delete(nv, 1);
        //}
    }
}
