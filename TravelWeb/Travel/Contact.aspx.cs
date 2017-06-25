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
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            LienHe lh = new LienHe();
            lh.NgayLH = DateTime.Now.ToString();
            string ms = "";
            if (Session["KhachHang_Login"] == null)
            {
                if (HoTen.Text == "")
                {
                    ms = "Hãy nhập họ tên";
                    Response.Write("<script>alert('" + ms + "');</script>");
                    return;
                }
                if (DienThoai.Text == "")
                {
                    ms = "Hãy nhập số điện thoại";
                    Response.Write("<script>alert('" + ms + "');</script>");
                    return;
                }
                if (Email.Text == "")
                {
                    ms = "Hãy nhập email";
                    Response.Write("<script>alert('" + ms + "');</script>");
                    return;
                }
                if (TieuDe.Text == "")
                {
                    ms = "Hãy nhập tiêu đề";
                    Response.Write("<script>alert('" + ms + "');</script>");
                    return;
                }
                if (NoiDung.Text.Length < 10)
                {
                    ms = "Hãy nhập đầy đủ nội dung";
                    Response.Write("<script>alert('" + ms + "');</script>");
                    return;
                }
                lh.DiaChi = DiaChi.Text;
                lh.DienThoai = DienThoai.Text;
                lh.HoTen = HoTen.Text;
                lh.Email = Email.Text;
                lh.TieuDe = TieuDe.Text;
                lh.NoiDung = NoiDung.Text;
                if(new LienHeBUS().LienHe_Insert(lh))
                {
                    ms = "Cảm ơn bạn đã gửi phản hồi. Chúng tôi sẽ sớm liên hệ với bạn";
                    Response.Write("<script>alert('" + ms + "');</script>");
                    Response.Write("<script>window.location.href=\"Default.aspx\";</script>");
                }
            }
            else
            {
                if (KH_TieuDe.Text == "")
                {
                    ms = "Hãy nhập tiêu đề";
                    Response.Write("<script>alert('" + ms + "');</script>");
                    return;
                }
                if (KH_NoiDung.Text.Length < 10)
                {
                    ms = "Hãy nhập đầy đủ nội dung";
                    Response.Write("<script>alert('" + ms + "');</script>");
                    return;
                }
                try
                {
                    string username = (string)Session["KhachHang_Login"];
                    lh.IDKhachHang = new KhachHangBUS().KhachHang_GetByTop("", "TenDangNhap = '" + username + "'", "").ElementAt(0).ID;
                    lh.TieuDe = KH_TieuDe.Text;
                    lh.NoiDung = KH_NoiDung.Text;
                    if (new LienHeBUS().LienHe_Insert(lh))
                    {
                        ms = "Cảm ơn bạn đã gửi phản hồi. Chúng tôi sẽ sớm liên hệ với bạn";
                        Response.Write("<script>alert('" + ms + "');</script>");
                        Response.Write("<script>window.location.href=\"Default.aspx\";</script>");
                    }
                }
                catch
                {

                }

            }
        }
    }
}