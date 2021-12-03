using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    //lớp TaiKhoanBl có các phương thức xử lý bảng Foood
    public class TaiKhoanBL
    {
        //Đối tượng CategoryDA từ DataAccess
        TaiKhoanDA tkDA = new TaiKhoanDA();
        //Phương thức lấy hết dữ liệu
        public List<TaiKhoan> GetAll()
        {
            return tkDA.GetAll();
        }
        // Phương thức lấy về đối tượng Food theo khoá chính
        public TaiKhoan GetByName(string name)
        {
            List<TaiKhoan> list = GetAll();
            foreach (var item in list)
            {
                if (item.TenTaiKhoan==name)
                {
                    return item;
                }
            }
            return null;
        }

        // phương thức thêm dữ liệu
        public int Insert(TaiKhoan tk)
        {
            return tkDA.Insert_Update_Delete(tk, 0);
        }
        // phương thức xóa dữ liệu
        public int Delete(TaiKhoan tk)
        {
            return tkDA.Insert_Update_Delete(tk, 1);
        }
        // phương thức sửa dữ liệu
        public int Update(TaiKhoan tk)
        {
            return tkDA.Insert_Update_Delete(tk, 2);
        }

        //kiểm tra đăng nhập

        //phân quyền





    }
}
