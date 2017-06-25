using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Entities
{
    public class QuangCao
    {
        public string ID { get; set; }
        public string Image { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Url { get; set; }
        public string Target { get; set; }
        public string TimeBD { get; set; }
        public string TimeKT { get; set; }
        public string LuotClick { get; set; }

        public string IsActive { get; set; }

        public QuangCao QuangCaoIDataReader(IDataReader dr)
        {
            QuangCao obj = new QuangCao();
            obj.ID = dr["ID"] is DBNull ? string.Empty : dr["ID"].ToString();
            obj.Image = dr["Image"] is DBNull ? string.Empty : dr["Image"].ToString();
            obj.Width = dr["Width"] is DBNull ? string.Empty : dr["Width"].ToString();
            obj.Height = dr["Height"] is DBNull ? string.Empty : dr["Height"].ToString();
            obj.Url = dr["Url"] is DBNull ? string.Empty : dr["Url"].ToString();
            obj.Target = dr["Target"] is DBNull ? string.Empty : dr["Target"].ToString();
            obj.IsActive = dr["IsActive"] is DBNull ? string.Empty : dr["IsActive"].ToString();
            return obj;
        }
    }
}
