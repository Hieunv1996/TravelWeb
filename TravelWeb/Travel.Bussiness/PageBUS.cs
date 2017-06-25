using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Data;
using Travel.Entities;

namespace Travel.Bussiness
{
    public class PageBUS
    {
        private PageDAL obj = new PageDAL();

        public List<Page> Page_GetByTop(string Top, string Where, string Order)
        {
            return obj.Page_GetByTop(Top, Where, Order);
        }
        public bool Page_Insert(Page data)
        {
            return obj.Page_Insert(data);
        }
        public bool Page_Update(Page data)
        {
            return obj.Page_Update(data);
        }

        public bool Page_Delete(string ID)
        {
            return obj.Page_Delete(ID);
        }
    }
}
