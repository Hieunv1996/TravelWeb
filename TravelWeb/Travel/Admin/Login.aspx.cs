using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Travel.Bussiness;
using Travel.Common;

namespace Travel.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        private AdminBUS obj = new AdminBUS();
        protected Alert alert = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string u = username.Text;
            string p = password.Text;
            if (u == null || u.Trim() == string.Empty)
            {
                alert = new Alert("Vui lòng nhập tên đăng nhập", "");
                return;
            }
            if (p == null || p.Trim() == string.Empty)
            {
                alert = new Alert("Vui lòng nhập mật khẩu", "");
                return;
            }
            if (obj.Admin_Login(u, p))
            {
                Session["Admin_Login"] = u;
                Response.Redirect("Default.aspx");
            }
            else
            {
                alert = new Alert("Sai tên đăng nhập hoặc mật khẩu", "");
            }
        }
    }
}