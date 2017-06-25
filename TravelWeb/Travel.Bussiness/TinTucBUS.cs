using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Data;
using Travel.Entities;

namespace Travel.Bussiness
{
    public class TinTucBUS
    {
        private TinTucDAL obj = new TinTucDAL();

        public List<TinTuc> TinTuc_GetByTop(string Top, string Where, string Order)
        {
            return obj.TinTuc_GetByTop(Top, Where, Order);
        }
        public bool TinTuc_Insert(TinTuc data)
        {
            return obj.TinTuc_Insert(data);
        }
        public bool TinTuc_Update(TinTuc data)
        {
            return obj.TinTuc_Update(data);
        }

        public bool TinTuc_Delete(string ID)
        {
            return obj.TinTuc_Delete(ID);
        }
    }
}
