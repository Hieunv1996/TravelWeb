using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Entities
{
    public class KhachHang
    {
        public string ID { get; set; }
        public string HoTen { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string NgayDangKy { get; set; }
        public KhachHang KhachHangIDataReader(IDataReader dr)
        {
            KhachHang obj = new KhachHang();
            obj.ID = dr["ID"] is DBNull ? string.Empty : dr["ID"].ToString();
            obj.HoTen = dr["HoTen"] is DBNull ? string.Empty : dr["HoTen"].ToString();
            obj.TenDangNhap = dr["TenDangNhap"] is DBNull ? string.Empty : dr["TenDangNhap"].ToString();
            obj.MatKhau = dr["MatKhau"] is DBNull ? string.Empty : dr["MatKhau"].ToString();
            obj.DiaChi = dr["DiaChi"] is DBNull ? string.Empty : dr["DiaChi"].ToString();
            obj.DienThoai = dr["DienThoai"] is DBNull ? string.Empty : dr["DienThoai"].ToString();
            obj.Email = dr["Email"] is DBNull ? string.Empty : dr["Email"].ToString();
            obj.NgayDangKy = dr["NgayDangKy"] is DBNull ? string.Empty : dr["NgayDangKy"].ToString();
            return obj;
        }
    }
}
