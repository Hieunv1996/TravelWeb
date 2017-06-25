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
    public class TinTucDAL : SqlDataProvider
    {
        public List<TinTuc> TinTuc_GetByTop(string Top, string Where, string Order)
        {
            List<TinTuc> list = new List<TinTuc>();
            using (SqlCommand dbCmd = new SqlCommand("sp_TinTuc_getByTop", openConnection()))
            {
                TinTuc obj = new TinTuc();
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
                        list.Add(obj.TinTucIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }
        public bool TinTuc_Insert(TinTuc data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_TinTuc_Insert", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@TieuDe", data.TieuDe));
                    dbCmd.Parameters.Add(new SqlParameter("@Mota", data.MoTa));
                    dbCmd.Parameters.Add(new SqlParameter("@NoiDung", data.NoiDung));
                    dbCmd.Parameters.Add(new SqlParameter("@AnhDaiDien", data.AnhDaiDien));
                    dbCmd.Parameters.Add(new SqlParameter("@NgayTao", data.NgayTao));
                    dbCmd.Parameters.Add(new SqlParameter("@nguoiTao", data.NguoiTao));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("TinTuc");

            }
            catch
            {
            }
            return check;
        }
        public bool TinTuc_Update(TinTuc data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_TinTuc_Update", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@ID", data.ID));
                    dbCmd.Parameters.Add(new SqlParameter("@TieuDe", data.TieuDe));
                    dbCmd.Parameters.Add(new SqlParameter("@Mota", data.MoTa));
                    dbCmd.Parameters.Add(new SqlParameter("@NoiDung", data.NoiDung));
                    dbCmd.Parameters.Add(new SqlParameter("@AnhDaiDien", data.AnhDaiDien));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("TinTuc");
            }
            catch
            {
            }
            return check;
        }

        public bool TinTuc_Delete(string ID)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_TinTuc_Delete", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@ID", ID));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("TinTuc");
            }
            catch
            {
            }
            return check;
        }
    }
}
