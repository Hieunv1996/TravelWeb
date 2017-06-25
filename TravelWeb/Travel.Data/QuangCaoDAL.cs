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
    public class QuangCaoDAL:SqlDataProvider
    {
        public List<QuangCao> QuangCao_GetByTop(string Top, string Where, string Order)
        {
            List<QuangCao> list = new List<QuangCao>();
            using (SqlCommand dbCmd = new SqlCommand("sp_QuangCao_getByTop", openConnection()))
            {
                QuangCao obj = new QuangCao();
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
                        list.Add(obj.QuangCaoIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }
        public bool QuangCao_Insert(QuangCao data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_QuangCao_Insert", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@Image", data.Image));
                    dbCmd.Parameters.Add(new SqlParameter("@Width", data.Width));
                    dbCmd.Parameters.Add(new SqlParameter("@Height", data.Height));
                    dbCmd.Parameters.Add(new SqlParameter("@Url", data.Url));
                    dbCmd.Parameters.Add(new SqlParameter("@Target", data.Target));
                    dbCmd.Parameters.Add(new SqlParameter("@TimeBD", data.TimeBD));
                    dbCmd.Parameters.Add(new SqlParameter("@TimeKT", data.TimeKT));
                    dbCmd.Parameters.Add(new SqlParameter("@LuotClick", data.LuotClick));
                    dbCmd.Parameters.Add(new SqlParameter("@IsActive", data.IsActive));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("QuangCao");

            }
            catch
            {
            }
            return check;
        }
        public bool QuangCao_Update(QuangCao data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_QuangCao_Update", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@ID", data.ID));
                    dbCmd.Parameters.Add(new SqlParameter("@Image", data.Image));
                    dbCmd.Parameters.Add(new SqlParameter("@Width", data.Width));
                    dbCmd.Parameters.Add(new SqlParameter("@Height", data.Height));
                    dbCmd.Parameters.Add(new SqlParameter("@Url", data.Url));
                    dbCmd.Parameters.Add(new SqlParameter("@Target", data.Target));
                    dbCmd.Parameters.Add(new SqlParameter("@TimeBD", data.TimeBD));
                    dbCmd.Parameters.Add(new SqlParameter("@TimeKT", data.TimeKT));
                    dbCmd.Parameters.Add(new SqlParameter("@LuotClick", data.LuotClick));
                    dbCmd.Parameters.Add(new SqlParameter("@IsActive", data.IsActive));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("QuangCao");
            }
            catch
            {
            }
            return check;
        }

        public bool QuangCao_Delete(string ID)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_QuangCao_Delete", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@ID", ID));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("QuangCao");
            }
            catch
            {
            }
            return check;
        }
    }
}
