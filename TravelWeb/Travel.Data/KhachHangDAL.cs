using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Entities;

namespace Travel.Data
{
    public class KhachHangDAL : SqlDataProvider
    {
        public List<KhachHang> KhachHang_GetByTop(string Top, string Where, string Order)
        {
            List<KhachHang> list = new List<KhachHang>();
            using (SqlCommand dbCmd = new SqlCommand("sp_KhachHang_getByTop", openConnection()))
            {
                KhachHang obj = new KhachHang();
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.Add(new SqlParameter("@Top", Top));
                dbCmd.Parameters.Add(new SqlParameter("@Where", Where));
                dbCmd.Parameters.Add(new SqlParameter("@Order", Order));
                SqlDataReader dr = dbCmd.ExecuteReader();
                dr.Close();
                dr = dbCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        list.Add(obj.KhachHangIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }
        public bool KhachHang_Insert(KhachHang data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_KhachHang_Insert", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@HoTen", data.HoTen));
                    dbCmd.Parameters.Add(new SqlParameter("@TenDangNhap", data.TenDangNhap));
                    dbCmd.Parameters.Add(new SqlParameter("@MatKhau", data.MatKhau));
                    dbCmd.Parameters.Add(new SqlParameter("@DiaChi", data.DiaChi));
                    dbCmd.Parameters.Add(new SqlParameter("@DienThoai", data.DienThoai));
                    dbCmd.Parameters.Add(new SqlParameter("@Email", data.Email));
                    dbCmd.Parameters.Add(new SqlParameter("@NgayDangKy", data.NgayDangKy));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("KhachHang");

            }
            catch
            {
            }
            return check;
        }
        public bool KhachHang_Update(KhachHang data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_KhachHang_Update", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@ID", data.ID));
                    dbCmd.Parameters.Add(new SqlParameter("@HoTen", data.HoTen));
                    dbCmd.Parameters.Add(new SqlParameter("@TenDangNhap", data.TenDangNhap));
                    dbCmd.Parameters.Add(new SqlParameter("@MatKhau", data.MatKhau));
                    dbCmd.Parameters.Add(new SqlParameter("@DiaChi", data.DiaChi));
                    dbCmd.Parameters.Add(new SqlParameter("@DienThoai", data.DienThoai));
                    dbCmd.Parameters.Add(new SqlParameter("@Email", data.Email));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("KhachHang");
            }
            catch
            {
            }
            return check;
        }

        public bool KhachHang_Delete(string ID)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_KhachHang_Delete", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@ID", ID));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("KhachHang");
            }
            catch
            {
            }
            return check;
        }
        public bool KhachHang_Login(string u, string p)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_KhachHang_Login", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@TenDangNhap", u));
                    dbCmd.Parameters.Add(new SqlParameter("@MatKhau", p));
                    int r = (int)dbCmd.ExecuteScalar();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("KhachHang");
            }
            catch
            {
            }
            return check;
        }
    }
}
