using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Travel.Bussiness;
using Travel.Common;

namespace Travel
{
    public partial class Login : System.Web.UI.Page
    {
        private KhachHangBUS obj = new KhachHangBUS();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if(usernameRegister.Text.Trim() == "")
            {
                Response.Write("<script>alert('Bạn phải nhập tên đăng nhập');</script>");
                return;
            }
            String tenDangNhap = usernameRegister.Text;

            String email = emailRegister.Text;
            if(email == "")
            {
                Response.Write("<script>alert('Bạn phải nhập email');</script>");
                return;
            }
            if(passwordRegister.Text == "")
            {
                Response.Write("<script>alert('Bạn phải nhập mật khẩu');</script>");
                return;
            }
            if(passwordRegister.Text != confirmPasswordRegister.Text)
            {
                Response.Write("<script>alert('Mật khẩu không khớp');</script>");
            }
            Travel.Entities.KhachHang kh = new Entities.KhachHang();
            kh.TenDangNhap = tenDangNhap;
            kh.Email = email;
            kh.MatKhau = passwordRegister.Text;
            if (obj.KhachHang_Insert(kh))
            {
                Response.Write("<script>alert('Đăng kí thành công. Hãy đăng nhập');</script>");
            }
            else
            {
                Response.Write("<script>alert('Lỗi đăng kí');</script>");
            }
        }

        protected void loginSubmit_Click(object sender, EventArgs e)
        {
            string u = usernameLogin.Text;
            string p = passwordLogin.Text;
            if(u == null || u.Trim() == string.Empty)
            {
                Response.Write("<script>alert('Vui lòng nhập tên đăng nhập');</script>");
                return;
            }
            if (p == null || p.Trim() == string.Empty)
            {
                Response.Write("<script>alert('Vui lòng nhập mật khẩu');</script>");
                return;
            }
            if (obj.KhachHang_Login(u, p))
            {
                Response.Write("<script>alert('Đăng nhập thành công');</script>");
                Session["KhachHang_Login"] = u;
                Response.Write("<script>window.location.href=\"Default.aspx\";</script>");
            }
            else
            {
                Response.Write("<script>alert('Sai tên đăng nhập hoặc mật khẩu');</script>");
            }
        }
    }
}