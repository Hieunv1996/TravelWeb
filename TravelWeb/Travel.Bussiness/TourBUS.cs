using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Data;
using Travel.Entities;

namespace Travel.Bussiness
{
    public class TourBUS
    {
        private TourDAL obj = new TourDAL();

        public List<Tour> Tour_GetByTop(string Top, string Where, string Order)
        {
            return obj.Tour_GetByTop(Top, Where, Order);
        }
        public bool Tour_Insert(Tour data)
        {
            return obj.Tour_Insert(data);
        }
        public bool Tour_Update(Tour data)
        {
            return obj.Tour_Update(data);
        }

        public bool Tour_Delete(string ID)
        {
            return obj.Tour_Delete(ID);
        }
    }
}
