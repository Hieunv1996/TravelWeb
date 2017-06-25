using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Entities
{
    public class Admin
    {
        public string ID { get; set; }
        public string HoTen { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }

        public Admin AdminIDataReader(IDataReader dr)
        {
            Admin obj = new Admin();
            obj.ID = dr["ID"] is DBNull ? string.Empty : dr["ID"].ToString();
            obj.HoTen = dr["HoTen"] is DBNull ? string.Empty : dr["HoTen"].ToString();
            obj.TenDangNhap = dr["TenDangNhap"] is DBNull ? string.Empty : dr["TenDangNhap"].ToString();
            obj.MatKhau = dr["MatKhau"] is DBNull ? string.Empty : dr["MatKhau"].ToString();
            return obj;
        }
    }
}
