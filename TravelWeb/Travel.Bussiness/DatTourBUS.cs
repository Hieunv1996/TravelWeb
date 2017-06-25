using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Data;
using Travel.Entities;

namespace Travel.Bussiness
{
    public class DatTourBUS
    {
        private DatTourDAL obj = new DatTourDAL();

        public List<DatTour> DatTour_GetByTop(string Top, string Where, string Order)
        {
            return obj.DatTour_GetByTop(Top, Where, Order);
        }
        public bool DatTour_Insert(DatTour data)
        {
            return obj.DatTour_Insert(data);
        }
        public bool DatTour_Update(DatTour data)
        {
            return obj.DatTour_Update(data);
        }

        public bool DatTour_Delete(string ID)
        {
            return obj.DatTour_Delete(ID);
        }
    }
}
