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
    public partial class Account : System.Web.UI.Page
    {
        private KhachHangBUS obj = new KhachHangBUS();

        protected static Travel.Entities.KhachHang kh = null;
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack) LoadData();
        }

        private void LoadData()
        {
            try
            {
                string user = (string)Session["KhachHang_Login"];
                if (user == null)
                {
                    Response.Redirect("404.aspx");
                    return;
                }
                kh = obj.KhachHang_GetByTop("", "TenDangNhap = '" + user + "'", "").ElementAt(0);
                if (kh.HoTen != null)
                    HoTen.Text = kh.HoTen;
                if (kh.Email != null)
                    EmailAddress.Text = kh.Email;
                if (kh.DienThoai != null)
                    DienThoai.Text = kh.DienThoai;
                if (kh.DiaChi != null)
                    DiaChi.Text = kh.DiaChi;
                if (kh.TenDangNhap != null)
                    TenDangNhap.Text = kh.TenDangNhap;
            }
            catch
            {
                kh = null;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["KhachHang_Login"] = null;
            Response.Write("<script>alert('Đăng xuất thành công');</script>");
            Response.Write("<script>window.location.href=\"Default.aspx\";</script>");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            KhachHang k = new KhachHang();
            if (MatKhau.Text != "")
            {
                if (MatKhau.Text != ReMatKhau.Text)
                {
                    string ms = "Mật khẩu không khớp";
                    Response.Write("<script>alert('" + ms + "');</script>");
                    return;
                }
                k.MatKhau = MatKhau.Text;
            }
            else
            {
                k.MatKhau = kh.MatKhau;
            }
            k.ID = kh.ID;
            k.TenDangNhap = kh.TenDangNhap;
            k.NgayDangKy = kh.NgayDangKy;
            k.HoTen = HoTen.Text;
            k.DiaChi = DiaChi.Text;
            k.Email = EmailAddress.Text;
            if (k.HoTen.Trim() == "" || k.Email == "" || k.DiaChi == "")
            {
                string ms = "Vui lòng nhập đủ thông tin";
                Response.Write("<script>alert('" + ms + "');</script>");
                return;
            }
            if (obj.KhachHang_Update(k))
            {
                string ms = "Cập nhật thành công";
                Response.Write("<script>alert('" + ms + "');</script>");
            }
            else
            {
                string ms = "Cập nhật không thành công";
                Response.Write("<script>alert('" + ms + "');</script>");
            }
        }
    }
}