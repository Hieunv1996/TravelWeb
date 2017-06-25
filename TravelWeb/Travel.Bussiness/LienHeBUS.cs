using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Data;
using Travel.Entities;

namespace Travel.Bussiness
{
    public class LienHeBUS
    {
        private LienHeDAL obj = new LienHeDAL();

        public List<LienHe> LienHe_GetByTop(string Top, string Where, string Order)
        {
            return obj.LienHe_GetByTop(Top, Where, Order);
        }
        public bool LienHe_Insert(LienHe data)
        {
            return obj.LienHe_Insert(data);
        }
        public bool LienHe_Update(LienHe data)
        {
            return obj.LienHe_Update(data);
        }

        public bool LienHe_Delete(string ID)
        {
            return obj.LienHe_Delete(ID);
        }
    }
}
