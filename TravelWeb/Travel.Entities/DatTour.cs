using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Entities
{
    public class DatTour
    {
        public string ID { get; set; }
        public string IDTour { get; set; }
        public string IDKhachHang { get; set; }
        public string HoTen { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string SoNL { get; set; }
        public string SoTE { get; set; }
        public string ThanhTien { get; set; }

        public DatTour DatTourIDataReader(IDataReader dr)
        {
            DatTour obj = new DatTour();
            obj.ID = dr["ID"] is DBNull ? string.Empty : dr["ID"].ToString();
            obj.IDTour = dr["IDTour"] is DBNull ? string.Empty : dr["IDTour"].ToString();
            obj.IDKhachHang = dr["IDKhachHang"] is DBNull ? string.Empty : dr["IDKhachHang"].ToString();
            obj.HoTen = dr["HoTen"] is DBNull ? string.Empty : dr["HoTen"].ToString();
            obj.DienThoai = dr["DienThoai"] is DBNull ? string.Empty : dr["DienThoai"].ToString();
            obj.Email = dr["Email"] is DBNull ? string.Empty : dr["Email"].ToString();
            obj.SoNL = dr["SoNL"] is DBNull ? string.Empty : dr["SoNL"].ToString();
            obj.SoTE = dr["SoTE"] is DBNull ? string.Empty : dr["SoTE"].ToString();
            obj.ThanhTien = dr["ThanhTien"] is DBNull ? string.Empty : dr["ThanhTien"].ToString();
            return obj;
        }
    }
}
