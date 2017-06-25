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
    public partial class News : System.Web.UI.Page
    {
        private TinTucBUS obj = new TinTucBUS();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            List<Travel.Entities.TinTuc> lst = obj.TinTuc_GetByTop("", "", "ID DESC");
            if (lst.Count > 0)
            {
                //Set DataSource of Pager to Sample Data 
                pager.DataSource = lst;

                pager.BindToControl = dtNews;

                dtNews.DataSource = pager.DataSourcePaged;
            }
        }

        protected string loadAds()
        {
            string s = "";
            List<QuangCao> lst = new QuangCaoBUS().QuangCao_GetByTop("", "IsActive = 1", "");
            foreach (QuangCao t in lst)
            {
                s += "<div class=\"item\" style=\"height: 250px; margin: 15px 0px;\">"
                + "<a href = \""+t.Url+"\" target = \""+t.Target+"\"><img src = \""+t.Image+"\" /></a>"
                + "</div > ";
            }
            return s;
        }
    }
}