using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class ChucVuDA
    {
        public List<ChucVu> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            //Khai báo đối tượng SqlCommand có kiểu xử lý là StoredProcedure
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.ChucVu_GetAll;
            // Đọc dữ liệu, trả về danh sách các đối tượng Category
            SqlDataReader reader = command.ExecuteReader();
            List<ChucVu> list = new List<ChucVu>();
            while (reader.Read())
            {
                ChucVu cv = new ChucVu();
                cv.MaCV= Convert.ToInt32(reader["MaCV"]);
                cv.TenChucVu= reader["TenChucVu"].ToString();
                list.Add(cv);
            }
            sqlConn.Close();
            return list;
        }
    }
}
