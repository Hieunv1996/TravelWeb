using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Travel.Bussiness;

namespace Travel
{
    public partial class Tour : System.Web.UI.Page
    {
        private TourBUS obj = new TourBUS();
        List<Travel.Entities.Tour> lst;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string q = Request.QueryString["Query"];
                
                if (q != null)
                {
                    txtTimKiem.Text = q;
                    q = "ConNL > 0 and " + "TieuDe like N'%" + q + "%'";
                    LoadData("", q, "");
                    string ms = "Tìm thấy " + lst.Count + " bản ghi";
                    Response.Write("<script>alert('" + ms + "');</script>");
                }
                else
                {
                    LoadData("", "ConNL > 0", "");
                }
            }
            catch
            {
                Response.Redirect("404.aspx");
            }
        }

        private void LoadData(string t, string w, string o)
        {
            lst = obj.Tour_GetByTop(t,w,o);
            if(lst.Count > 0)
            {
                //Set DataSource of Pager to Sample Data 
                pager.DataSource = lst;

                pager.BindToControl = dtTourList;

                dtTourList.DataSource = pager.DataSourcePaged;
            }
            else
            {
                
            }
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            Response.Redirect("Tour.aspx?Query=" + txtTimKiem.Text);
        }
    }
}