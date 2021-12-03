using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class NhanVienDA
    {
        public List<NhanVien> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.NhanVien_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<NhanVien> list = new List<NhanVien>();
            while (reader.Read())
            {
                NhanVien nv = new NhanVien();
                nv.HoTen = reader["MaNV"].ToString();
                nv.HoTen = reader["HoTen"].ToString();
                nv.DiaChi = reader["DiaChi"].ToString();
                nv.GioiTinh = reader["GioiTinh"].ToString();
                nv.NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()).ToShortDateString();
                nv.SoDienThoai = reader["SoDienThoai"].ToString();
                list.Add(nv);
            }
            sqlConn.Close();
            return list;
        }
        //public int Insert_Update_Delete(NhanVien nv,int action)
        //{
            //SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            //sqlConn.Open();

            //SqlCommand cmd = sqlConn.CreateCommand();
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = Ultilities.NhanVien_InsertUpdate;

            //cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar, 20).Value=nv.MaNV;
            //cmd.Parameters.Add("@HoTen",SqlDbType.NVarChar,100).Value=nv.HoTen;
            //cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50).Value=nv.DiaChi;
            //cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 10).Value=nv.GioiTinh;
            //cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = nv.NgaySinh;
            //cmd.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar, 100).Value = nv.SoDienThoai;
            //cmd.Parameters.Add("@Action", SqlDbType.Int).Value = action;
            //int result = cmd.ExecuteNonQuery();

            //if (result > 0)
            //    return (int)cmd.Parameters["@MaNV"].Value;
            //return 0;
        //}
    }
}
