using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Entities
{
    public class Tour
    {
        public string ID { get; set; }
        public string TieuDe { get; set; }
        public string DiaDiemXuatPhat { get; set; }
        public string DiaDiemKetThuc { get; set; }
        public string SoLuongTE { get; set; }
        public string SoLuongNL { get; set; }
        public string MoTaTour { get; set; }
        public string MoTaPhuongTien { get; set; }
        public string GiaTourTE { get; set; }
        public string GiaTourNL { get; set; }
        public string NgayKhoiHanh { get; set; }
        public string NgayKetThuc { get; set; }
        public string AnhMoTa { get; set; }
        public string DSDiaDanh { get; set; }
        public string ConNL { get; set; }
        public string ConTE { get; set; }


        public Tour TourIDataReader(IDataReader dr)
        {
            Tour obj = new Tour();
            obj.ID = dr["ID"] is DBNull ? string.Empty : dr["ID"].ToString();
            obj.TieuDe = dr["TieuDe"] is DBNull ? string.Empty : dr["TieuDe"].ToString();
            obj.DiaDiemXuatPhat = dr["DiaDiemXuatPhat"] is DBNull ? string.Empty : dr["DiaDiemXuatPhat"].ToString();
            obj.DiaDiemKetThuc = dr["DiaDiemKetThuc"] is DBNull ? string.Empty : dr["DiaDiemKetThuc"].ToString();
            obj.SoLuongTE = dr["SoLuongTE"] is DBNull ? string.Empty : dr["SoLuongTE"].ToString();
            obj.SoLuongNL = dr["SoLuongNL"] is DBNull ? string.Empty : dr["SoLuongNL"].ToString();
            obj.MoTaTour = dr["MoTaTour"] is DBNull ? string.Empty : dr["MoTaTour"].ToString();
            obj.MoTaPhuongTien = dr["MoTaPhuongTien"] is DBNull ? string.Empty : dr["MoTaPhuongTien"].ToString();
            obj.GiaTourTE = dr["GiaTourTE"] is DBNull ? string.Empty : dr["GiaTourTE"].ToString();
            obj.GiaTourNL = dr["GiaTourNL"] is DBNull ? string.Empty : dr["GiaTourNL"].ToString();
            obj.NgayKhoiHanh = dr["NgayKhoiHanh"] is DBNull ? string.Empty : dr["NgayKhoiHanh"].ToString();
            obj.NgayKetThuc = dr["NgayKetThuc"] is DBNull ? string.Empty : dr["NgayKetThuc"].ToString();
            obj.AnhMoTa = dr["AnhMoTa"] is DBNull ? string.Empty : dr["AnhMoTa"].ToString();
            obj.DSDiaDanh = dr["DSDiaDanh"] is DBNull ? string.Empty : dr["DSDiaDanh"].ToString();
            obj.ConNL = dr["ConNL"] is DBNull ? string.Empty : dr["ConNL"].ToString();
            obj.ConTE = dr["ConTE"] is DBNull ? string.Empty : dr["ConTE"].ToString();
            return obj;
        }
    }
}
