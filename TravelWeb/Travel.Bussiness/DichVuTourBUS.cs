using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Data;
using Travel.Entities;

namespace Travel.Bussiness
{
    public class DichVuTourBUS
    {
        private DichVuTourDAL obj = new DichVuTourDAL();

        public List<DichVuTour> DichVuTour_GetByTop(string Top, string Where, string Order)
        {
            return obj.DichVuTour_GetByTop(Top, Where, Order);
        }
        public bool DichVuTour_Insert(DichVuTour data)
        {
            return obj.DichVuTour_Insert(data);
        }
        public bool DichVuTour_Update(DichVuTour data)
        {
            return obj.DichVuTour_Update(data);
        }

        public bool DichVuTour_Delete(string ID)
        {
            return obj.DichVuTour_Delete(ID);
        }
    }
}
