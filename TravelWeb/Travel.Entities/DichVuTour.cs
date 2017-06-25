using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Entities
{
    public class DichVuTour
    {
        public string ID { get; set; }
        public string IDTour { get; set; }
        public string TenDV { get; set; }
        public string MoTaDV { get; set; }
        public string InTour { get; set; }
        public string DonGia { get; set; }
        public string NgayTao { get; set; }

        public DichVuTour DichVuTourIDataReader(IDataReader dr)
        {
            DichVuTour obj = new DichVuTour();
            obj.ID = dr["ID"] is DBNull ? string.Empty : dr["ID"].ToString();
            obj.IDTour = dr["IDTour"] is DBNull ? string.Empty : dr["IDTour"].ToString();
            obj.TenDV = dr["TenDV"] is DBNull ? string.Empty : dr["TenDV"].ToString();
            obj.MoTaDV = dr["MoTaDV"] is DBNull ? string.Empty : dr["MoTaDV"].ToString();
            obj.InTour = dr["InTour"] is DBNull ? string.Empty : dr["InTour"].ToString();
            obj.DonGia = dr["DonGia"] is DBNull ? string.Empty : dr["DonGia"].ToString();
            obj.NgayTao = dr["NgayTao"] is DBNull ? string.Empty : dr["NgayTao"].ToString();
            return obj;
        }
    }
}
