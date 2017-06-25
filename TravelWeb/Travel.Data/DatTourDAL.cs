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
    public class DatTourDAL : SqlDataProvider
    {
        public List<DatTour> DatTour_GetByTop(string Top, string Where, string Order)
        {
            List<DatTour> list = new List<DatTour>();
            using (SqlCommand dbCmd = new SqlCommand("sp_DatTour_getByTop", openConnection()))
            {
                DatTour obj = new DatTour();
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
                        list.Add(obj.DatTourIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }
        public bool DatTour_Insert(DatTour data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_DatTour_Insert", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@IDTour", data.IDTour));
                    dbCmd.Parameters.Add(new SqlParameter("@IDKhachHang", data.IDKhachHang));
                    dbCmd.Parameters.Add(new SqlParameter("@HoTen", data.HoTen));
                    dbCmd.Parameters.Add(new SqlParameter("@DienThoai", data.DienThoai));
                    dbCmd.Parameters.Add(new SqlParameter("@Email", data.Email));
                    dbCmd.Parameters.Add(new SqlParameter("@SoNL", data.SoNL));
                    dbCmd.Parameters.Add(new SqlParameter("@SoTE", data.SoTE));
                    dbCmd.Parameters.Add(new SqlParameter("@ThanhTien", data.ThanhTien));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("DatTour");

            }
            catch
            {
            }
            return check;
        }
        public bool DatTour_Update(DatTour data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_DatTour_Update", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@ID", data.ID));
                    dbCmd.Parameters.Add(new SqlParameter("@IDTour", data.IDTour));
                    dbCmd.Parameters.Add(new SqlParameter("@IDKhachHang", data.IDKhachHang));
                    dbCmd.Parameters.Add(new SqlParameter("@HoTen", data.HoTen));
                    dbCmd.Parameters.Add(new SqlParameter("@DienThoai", data.DienThoai));
                    dbCmd.Parameters.Add(new SqlParameter("@Email", data.Email));
                    dbCmd.Parameters.Add(new SqlParameter("@SoNL", data.SoNL));
                    dbCmd.Parameters.Add(new SqlParameter("@SoTE", data.SoTE));
                    dbCmd.Parameters.Add(new SqlParameter("@ThanhTien", data.ThanhTien));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("DatTour");
            }
            catch
            {
            }
            return check;
        }

        public bool DatTour_Delete(string ID)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_DatTour_Delete", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@ID", ID));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("DatTour");
            }
            catch
            {
            }
            return check;
        }
    }
}
