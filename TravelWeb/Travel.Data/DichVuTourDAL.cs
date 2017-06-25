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
    public class DichVuTourDAL : SqlDataProvider
    {
        public List<DichVuTour> DichVuTour_GetByTop(string Top, string Where, string Order)
        {
            List<DichVuTour> list = new List<DichVuTour>();
            using (SqlCommand dbCmd = new SqlCommand("sp_DichVuTour_getByTop", openConnection()))
            {
                DichVuTour obj = new DichVuTour();
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
                        list.Add(obj.DichVuTourIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }
        public bool DichVuTour_Insert(DichVuTour data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_DichVuTour_Insert", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@IDTour", data.IDTour));
                    dbCmd.Parameters.Add(new SqlParameter("@TenDV", data.TenDV));
                    dbCmd.Parameters.Add(new SqlParameter("@MoTaDV", data.MoTaDV));
                    dbCmd.Parameters.Add(new SqlParameter("@InTour", data.InTour));
                    dbCmd.Parameters.Add(new SqlParameter("@DonGia", data.DonGia));
                    dbCmd.Parameters.Add(new SqlParameter("@NgayTao", data.NgayTao));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("DichVuTour");

            }
            catch
            {
            }
            return check;
        }
        public bool DichVuTour_Update(DichVuTour data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_DichVuTour_Update", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@ID", data.ID));
                    dbCmd.Parameters.Add(new SqlParameter("@IDTour", data.IDTour));
                    dbCmd.Parameters.Add(new SqlParameter("@TenDV", data.TenDV));
                    dbCmd.Parameters.Add(new SqlParameter("@MoTaDV", data.MoTaDV));
                    dbCmd.Parameters.Add(new SqlParameter("@InTour", data.InTour));
                    dbCmd.Parameters.Add(new SqlParameter("@DonGia", data.DonGia));
                    dbCmd.Parameters.Add(new SqlParameter("@NgayTao", data.NgayTao));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("DichVuTour");
            }
            catch
            {
            }
            return check;
        }

        public bool DichVuTour_Delete(string ID)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_DichVuTour_Delete", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@ID", ID));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("DichVuTour");
            }
            catch
            {
            }
            return check;
        }
    }
}
