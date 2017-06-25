using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Entities
{
    public class DiaDanh
    {
        public string ID { get; set; }
        public string TenDiaDanh { get; set; }
        public string MoTa { get; set; }
        public DiaDanh DiaDanhIDataReader(IDataReader dr)
        {
            DiaDanh obj = new DiaDanh();
            obj.ID = dr["ID"] is DBNull ? string.Empty : dr["ID"].ToString();
            obj.TenDiaDanh = dr["TenDiaDanh"] is DBNull ? string.Empty : dr["TenDiaDanh"].ToString();
            obj.MoTa = dr["MoTa"] is DBNull ? string.Empty : dr["MoTa"].ToString();
            return obj;
        }
    }
}
