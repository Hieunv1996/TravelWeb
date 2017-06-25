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
    public class AdminDAL : SqlDataProvider
    {
        public List<Admin> Admin_GetByTop(string Top, string Where, string Order)
        {
            List<Admin> list = new List<Admin>();
            using (SqlCommand dbCmd = new SqlCommand("sp_Admin_getByTop", openConnection()))
            {
                Admin obj = new Admin();
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
                        list.Add(obj.AdminIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }
        public bool Admin_Insert(Admin data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Admin_Insert", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@HoTen", data.HoTen));
                    dbCmd.Parameters.Add(new SqlParameter("@TenDangNhap", data.TenDangNhap));
                    dbCmd.Parameters.Add(new SqlParameter("@MatKhau", data.MatKhau));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("Admin");

            }
            catch
            {
            }
            return check;
        }
        public bool Admin_Update(Admin data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Admin_Update", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@ID", data.ID));
                    dbCmd.Parameters.Add(new SqlParameter("@HoTen", data.HoTen));
                    dbCmd.Parameters.Add(new SqlParameter("@TenDangNhap", data.TenDangNhap));
                    dbCmd.Parameters.Add(new SqlParameter("@MatKhau", data.MatKhau));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("Admin");
            }
            catch
            {
            }
            return check;
        }

        public bool Admin_Delete(string ID)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Admin_Delete", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@ID", ID));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("Admin");
            }
            catch
            {
            }
            return check;
        }

        public bool Admin_Login(string u, string p)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Admin_Login", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@TenDangNhap", u));
                    dbCmd.Parameters.Add(new SqlParameter("@MatKhau", p));
                    int r = (int)dbCmd.ExecuteScalar();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("Admin");
            }
            catch
            {
            }
            return check;
        }
    }
}
