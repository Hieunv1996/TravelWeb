using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Data;
using Travel.Entities;

namespace Travel.Bussiness
{
    public class AdminBUS
    {
        private AdminDAL obj = new AdminDAL();

        public List<Admin> Admin_GetByTop(string Top, string Where, string Order)
        {
            return obj.Admin_GetByTop(Top, Where, Order);
        }
        public bool Admin_Insert(Admin data)
        {
            return obj.Admin_Insert(data);
        }
        public bool Admin_Update(Admin data)
        {
            return obj.Admin_Update(data);
        }

        public bool Admin_Delete(string ID)
        {
            return obj.Admin_Delete(ID);
        }
        public bool Admin_Login(string u, string p)
        {
            return obj.Admin_Login(u, p);
        }
    }
}
