using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Travel.Entities;

namespace Travel.Data
{
   public class PageDAL: SqlDataProvider
    {
        public List<Page> Page_GetByTop(string Top, string Where, string Order)
        {
            List<Page> list = new List<Page>();
            using (SqlCommand dbCmd = new SqlCommand("sp_Page_getByTop", openConnection()))
            {
                Page obj = new Page();
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
                        list.Add(obj.PageIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }
        public bool Page_Insert(Page data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Page_Insert", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@NoiDung", data.NoiDung));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("Page");

            }
            catch
            {
            }
            return check;
        }
        public bool Page_Update(Page data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Page_Update", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@ID", data.ID));
                    dbCmd.Parameters.Add(new SqlParameter("@NoiDung", data.NoiDung));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("Page");
            }
            catch
            {
            }
            return check;
        }

        public bool Page_Delete(string ID)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Page_Delete", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@ID", ID));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("Page");
            }
            catch
            {
            }
            return check;
        }
    }
}
