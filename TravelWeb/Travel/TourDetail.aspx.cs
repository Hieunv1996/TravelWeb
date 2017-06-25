using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Travel.Bussiness;
using Travel.Entities;

namespace Travel
{
    public partial class TourDetail : System.Web.UI.Page
    {
        private TourBUS obj = new TourBUS();
        protected Travel.Entities.Tour tour = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        protected string LoadDichVu()
        {
            string s = "<ul>";
            List<DichVuTour> lst = new DichVuTourBUS().DichVuTour_GetByTop("", "InTour = 1 and IDTour = '"+tour.ID+"'", "");
            if(lst.Count == 0)
            {
                return "<p>(Chưa cập nhật)</p>";
            }
            foreach(DichVuTour t in lst)
            {
                s += "<li>"+t.TenDV+"</li>";
            }
            return s+"</ul>";
        }

        private void LoadData()
        {
            try
            {
                string id = Request.QueryString["ID"];
                if(id != "")
                {
                    tour = obj.Tour_GetByTop("", "ID = '" + id + "'", "").ElementAt(0);
                }
            }
            catch
            {
                tour = null;
            }
        }
    }
}