using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Entities
{
    public class TinTuc
    {
        public string ID { get; set; }
        public string TieuDe { get; set; }
        public string MoTa { get; set; }
        public string NoiDung { get; set; }
        public string AnhDaiDien { get; set; }
        public string NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string HoTen { get; set; }

        public TinTuc TinTucIDataReader(IDataReader dr)
        {
            TinTuc obj = new TinTuc();
            obj.ID = dr["ID"] is DBNull ? string.Empty : dr["ID"].ToString();
            obj.TieuDe = dr["TieuDe"] is DBNull ? string.Empty : dr["TieuDe"].ToString();
            obj.MoTa = dr["MoTa"] is DBNull ? string.Empty : dr["MoTa"].ToString();
            obj.NoiDung = dr["NoiDung"] is DBNull ? string.Empty : dr["NoiDung"].ToString();
            obj.AnhDaiDien = dr["AnhDaiDien"] is DBNull ? string.Empty : dr["AnhDaiDien"].ToString();
            obj.NgayTao = dr["NgayTao"] is DBNull ? string.Empty : dr["NgayTao"].ToString();
            obj.NguoiTao = dr["NguoiTao"] is DBNull ? string.Empty : dr["NguoiTao"].ToString();
            obj.HoTen = dr["HoTen"] is DBNull ? string.Empty : dr["HoTen"].ToString();
            return obj;
        }
    }
}
