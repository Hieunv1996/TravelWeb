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
    public class DiaDanhDAL: SqlDataProvider
    {
        public List<DiaDanh> DiaDanh_GetByTop(string Top, string Where, string Order)
        {
            List<DiaDanh> list = new List<DiaDanh>();
            using (SqlCommand dbCmd = new SqlCommand("sp_DiaDanh_getByTop", openConnection()))
            {
                DiaDanh obj = new DiaDanh();
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
                        list.Add(obj.DiaDanhIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }
        public bool DiaDanh_Insert(DiaDanh data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_DiaDanh_Insert", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@TenDiaDanh", data.TenDiaDanh));
                    dbCmd.Parameters.Add(new SqlParameter("@MoTa", data.MoTa));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("DiaDanh");

            }
            catch
            {
            }
            return check;
        }
        public bool DiaDanh_Update(DiaDanh data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_DiaDanh_Update", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@ID", data.ID));
                    dbCmd.Parameters.Add(new SqlParameter("@TenDiaDanh", data.TenDiaDanh));
                    dbCmd.Parameters.Add(new SqlParameter("@MoTa", data.MoTa));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("DiaDanh");
            }
            catch
            {
            }
            return check;
        }

        public bool DiaDanh_Delete(string ID)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_DiaDanh_Delete", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@ID", ID));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("DiaDanh");
            }
            catch
            {
            }
            return check;
        }
    }
}
