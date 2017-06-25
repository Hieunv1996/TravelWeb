using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Data;
using Travel.Entities;

namespace Travel.Bussiness
{
    public class DiaDanhBUS
    {
        private DiaDanhDAL obj = new DiaDanhDAL();

        public List<DiaDanh> DiaDanh_GetByTop(string Top, string Where, string Order)
        {
            return obj.DiaDanh_GetByTop(Top, Where, Order);
        }
        public bool DiaDanh_Insert(DiaDanh data)
        {
            return obj.DiaDanh_Insert(data);
        }
        public bool DiaDanh_Update(DiaDanh data)
        {
            return obj.DiaDanh_Update(data);
        }

        public bool DiaDanh_Delete(string ID)
        {
            return obj.DiaDanh_Delete(ID);
        }
    }
}
