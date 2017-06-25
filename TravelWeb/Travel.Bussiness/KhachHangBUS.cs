using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Data;
using Travel.Entities;

namespace Travel.Bussiness
{
    public class KhachHangBUS
    {
        private KhachHangDAL obj = new KhachHangDAL();

        public List<KhachHang> KhachHang_GetByTop(string Top, string Where, string Order)
        {
            return obj.KhachHang_GetByTop(Top, Where, Order);
        }
        public bool KhachHang_Insert(KhachHang data)
        {
            return obj.KhachHang_Insert(data);
        }
        public bool KhachHang_Update(KhachHang data)
        {
            return obj.KhachHang_Update(data);
        }

        public bool KhachHang_Delete(string ID)
        {
            return obj.KhachHang_Delete(ID);
        }
        public bool KhachHang_Login(string u, string p)
        {
            return obj.KhachHang_Login(u, p);
        }
    }
}
