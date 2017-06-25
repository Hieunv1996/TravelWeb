using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Entities
{
    public class Page
    {
        public string ID { get; set; }
        public string NoiDung { get; set; }
        public Page PageIDataReader(IDataReader dr)
        {
            Page obj = new Page();
            obj.ID = dr["ID"] is DBNull ? string.Empty : dr["ID"].ToString();
            obj.NoiDung = dr["NoiDung"] is DBNull ? string.Empty : dr["NoiDung"].ToString();
            return obj;
        }
    }
}
