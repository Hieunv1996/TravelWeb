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
    public class LienHeDAL  :SqlDataProvider
    {
        public List<LienHe> LienHe_GetByTop(string Top, string Where, string Order)
        {
            List<LienHe> list = new List<LienHe>();
            using (SqlCommand dbCmd = new SqlCommand("sp_LienHe_getByTop", openConnection()))
            {
                LienHe obj = new LienHe();
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
                        list.Add(obj.LienHeIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }
        public bool LienHe_Insert(LienHe data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_LienHe_Insert", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@IDKhachHang", data.IDKhachHang));
                    dbCmd.Parameters.Add(new SqlParameter("@HoTen", data.HoTen));
                    dbCmd.Parameters.Add(new SqlParameter("@DiaChi", data.DiaChi));
                    dbCmd.Parameters.Add(new SqlParameter("@DienThoai", data.DienThoai));
                    dbCmd.Parameters.Add(new SqlParameter("@Email", data.Email));
                    dbCmd.Parameters.Add(new SqlParameter("@NgayLH", data.NgayLH));
                    dbCmd.Parameters.Add(new SqlParameter("@TieuDe", data.TieuDe));
                    dbCmd.Parameters.Add(new SqlParameter("@NoiDung", data.NoiDung));
                    dbCmd.Parameters.Add(new SqlParameter("@PhanHoi", data.PhanHoi));
                    dbCmd.Parameters.Add(new SqlParameter("@NguoiPH", data.NguoiPH));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("LienHe");

            }
            catch
            {
            }
            return check;
        }
        public bool LienHe_Update(LienHe data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_LienHe_Update", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@ID", data.ID));
                    dbCmd.Parameters.Add(new SqlParameter("@IDKhachHang", data.IDKhachHang));
                    dbCmd.Parameters.Add(new SqlParameter("@HoTen", data.HoTen));
                    dbCmd.Parameters.Add(new SqlParameter("@DiaChi", data.DiaChi));
                    dbCmd.Parameters.Add(new SqlParameter("@DienThoai", data.DienThoai));
                    dbCmd.Parameters.Add(new SqlParameter("@Email", data.Email));
                    dbCmd.Parameters.Add(new SqlParameter("@NgayLH", data.NgayLH));
                    dbCmd.Parameters.Add(new SqlParameter("@TieuDe", data.TieuDe));
                    dbCmd.Parameters.Add(new SqlParameter("@NoiDung", data.NoiDung));
                    dbCmd.Parameters.Add(new SqlParameter("@PhanHoi", data.PhanHoi));
                    dbCmd.Parameters.Add(new SqlParameter("@NguoiPH", data.NguoiPH));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("LienHe");
            }
            catch
            {
            }
            return check;
        }

        public bool LienHe_Delete(string ID)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_LienHe_Delete", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@ID", ID));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("LienHe");
            }
            catch
            {
            }
            return check;
        }
    }
}
