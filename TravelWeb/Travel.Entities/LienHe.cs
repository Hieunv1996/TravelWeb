using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Entities
{
    public class LienHe
    {
        public string ID { get; set; }
        public string IDKhachHang { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string NgayLH { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public string PhanHoi { get; set; }
        public string NguoiPH { get; set; }

        public LienHe LienHeIDataReader(IDataReader dr)
        {
            LienHe obj = new LienHe();
            obj.ID = dr["ID"] is DBNull ? string.Empty : dr["ID"].ToString();
            obj.IDKhachHang = dr["IDKhachHang"] is DBNull ? string.Empty : dr["IDKhachHang"].ToString();
            obj.HoTen = dr["HoTen"] is DBNull ? string.Empty : dr["HoTen"].ToString();
            obj.DiaChi = dr["DiaChi"] is DBNull ? string.Empty : dr["DiaChi"].ToString();
            obj.DienThoai = dr["DienThoai"] is DBNull ? string.Empty : dr["DienThoai"].ToString();
            obj.Email = dr["Email"] is DBNull ? string.Empty : dr["Email"].ToString();
            obj.NgayLH = dr["NguoiTao"] is DBNull ? string.Empty : dr["NguoiTao"].ToString();
            obj.TieuDe = dr["TieuDe"] is DBNull ? string.Empty : dr["TieuDe"].ToString();
            obj.NoiDung = dr["NoiDung"] is DBNull ? string.Empty : dr["NoiDung"].ToString();
            obj.PhanHoi = dr["PhanHoi"] is DBNull ? string.Empty : dr["PhanHoi"].ToString();
            obj.NguoiPH = dr["NguoiPH"] is DBNull ? string.Empty : dr["NguoiPH"].ToString();
            return obj;
        }
    }
}
