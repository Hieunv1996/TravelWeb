using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Data;
using Travel.Entities;

namespace Travel.Bussiness
{
    public class QuangCaoBUS
    {
        private QuangCaoDAL obj = new QuangCaoDAL();

        public List<QuangCao> QuangCao_GetByTop(string Top, string Where, string Order)
        {
            return obj.QuangCao_GetByTop(Top, Where, Order);
        }
        public bool QuangCao_Insert(QuangCao data)
        {
            return obj.QuangCao_Insert(data);
        }
        public bool QuangCao_Update(QuangCao data)
        {
            return obj.QuangCao_Update(data);
        }

        public bool QuangCao_Delete(string ID)
        {
            return obj.QuangCao_Delete(ID);
        }
    }
}
