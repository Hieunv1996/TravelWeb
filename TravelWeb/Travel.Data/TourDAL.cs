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
    public class TourDAL: SqlDataProvider
    {
        public List<Tour> Tour_GetByTop(string Top, string Where, string Order)
        {
            List<Tour> list = new List<Tour>();
            using (SqlCommand dbCmd = new SqlCommand("sp_Tour_getByTop", openConnection()))
            {
                Tour obj = new Tour();
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
                        list.Add(obj.TourIDataReader(dr));
                    }
                }
                dr.Close();
                obj = null;
            }
            return list;
        }
        public bool Tour_Insert(Tour data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Tour_Insert", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@TieuDe", data.TieuDe));
                    dbCmd.Parameters.Add(new SqlParameter("@DiaDiemXuatPhat", data.DiaDiemXuatPhat));
                    dbCmd.Parameters.Add(new SqlParameter("@DiaDiemKetThuc", data.DiaDiemKetThuc));
                    dbCmd.Parameters.Add(new SqlParameter("@SoLuongTE", data.SoLuongTE));
                    dbCmd.Parameters.Add(new SqlParameter("@SoLuongNL", data.SoLuongNL));
                    dbCmd.Parameters.Add(new SqlParameter("@MoTaTour", data.MoTaTour));
                    dbCmd.Parameters.Add(new SqlParameter("@MoTaPhuongTien", data.MoTaPhuongTien));
                    dbCmd.Parameters.Add(new SqlParameter("@GiaTourTE", data.GiaTourTE));
                    dbCmd.Parameters.Add(new SqlParameter("@GiaTourNL", data.GiaTourNL));
                    dbCmd.Parameters.Add(new SqlParameter("@NgayKhoiHanh", data.NgayKhoiHanh));
                    dbCmd.Parameters.Add(new SqlParameter("@NgayKetThuc", data.NgayKetThuc));
                    dbCmd.Parameters.Add(new SqlParameter("@AnhMoTa", data.AnhMoTa));
                    dbCmd.Parameters.Add(new SqlParameter("@DSDiaDanh", data.DSDiaDanh));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("Tour");

            }
            catch
            {
            }
            return check;
        }
        public bool Tour_Update(Tour data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Tour_Update", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@ID", data.ID));
                    dbCmd.Parameters.Add(new SqlParameter("@TieuDe", data.TieuDe));
                    dbCmd.Parameters.Add(new SqlParameter("@DiaDiemXuatPhat", data.DiaDiemXuatPhat));
                    dbCmd.Parameters.Add(new SqlParameter("@DiaDiemKetThuc", data.DiaDiemKetThuc));
                    dbCmd.Parameters.Add(new SqlParameter("@SoLuongTE", data.SoLuongTE));
                    dbCmd.Parameters.Add(new SqlParameter("@SoLuongNL", data.SoLuongNL));
                    dbCmd.Parameters.Add(new SqlParameter("@MoTaTour", data.MoTaTour));
                    dbCmd.Parameters.Add(new SqlParameter("@MoTaPhuongTien", data.MoTaPhuongTien));
                    dbCmd.Parameters.Add(new SqlParameter("@GiaTourTE", data.GiaTourTE));
                    dbCmd.Parameters.Add(new SqlParameter("@GiaTourNL", data.GiaTourNL));
                    dbCmd.Parameters.Add(new SqlParameter("@NgayKhoiHanh", data.NgayKhoiHanh));
                    dbCmd.Parameters.Add(new SqlParameter("@NgayKetThuc", data.NgayKetThuc));
                    dbCmd.Parameters.Add(new SqlParameter("@AnhMoTa", data.AnhMoTa));
                    dbCmd.Parameters.Add(new SqlParameter("@DSDiaDanh", data.DSDiaDanh));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("Tour");
            }
            catch
            {
            }
            return check;
        }

        public bool Tour_Delete(string ID)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Tour_Delete", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@ID", ID));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
                //Clear cache
                System.Web.HttpContext.Current.Cache.Remove("Tour");
            }
            catch
            {
            }
            return check;
        }
    }
}
