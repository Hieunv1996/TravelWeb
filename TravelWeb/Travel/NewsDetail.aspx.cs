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
    public partial class NewsDetail : System.Web.UI.Page
    {
        private TinTucBUS obj = new TinTucBUS();
        protected TinTuc tintuc = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    string id = Request.QueryString["ID"];
                    tintuc = obj.TinTuc_GetByTop("", "ID = '" + id + "'", "").ElementAt(0);
                    TieuDe.Text = tintuc.TieuDe;
                    MoTa.Text = tintuc.MoTa;
                    lbNgayTao.Text = tintuc.NgayTao;
                    lbNguoiTao.Text = tintuc.HoTen;
                    NoiDung.Text = tintuc.NoiDung;
                    AnhDaiDien.ImageUrl = tintuc.AnhDaiDien;
                }
                catch
                {
                    tintuc = null;
                }
            }
        }
    }
}