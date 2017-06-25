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
    public partial class Booking : System.Web.UI.Page
    {
        protected Travel.Entities.Tour tour = null;
        private DatTourBUS obj = new DatTourBUS();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string id = Request.QueryString["ID"];
                tour = new TourBUS().Tour_GetByTop("", "ID = '" + id + "'","").ElementAt(0);
            }
            catch
            {
                tour = null;
            }
        }

        protected void btnThanhToan_Click(object sender, EventArgs e)
        {
            string soNL, soTE;
            if (Session["KhachHang_Login"] == null)
            {
                if (ValidForm(false))
                {
                    string hoten = HoTen.Text;
                    string std = DienThoai.Text;
                    string email = Email.Text;
                    soNL = _SoNL.Text;
                    soTE = _SoTE.Text;
                    DatTour dt = new DatTour();
                    dt.HoTen = hoten;
                    dt.DienThoai = std;
                    dt.Email = email;
                    dt.SoNL = soNL;
                    dt.SoTE = soTE;
                    dt.IDTour = tour.ID;
                    dt.ThanhTien = (int.Parse(soNL) * Double.Parse(tour.GiaTourNL) + int.Parse(soTE) * Double.Parse(tour.GiaTourTE)).ToString();
                    if (obj.DatTour_Insert(dt))
                    {
                        string ms = "Số tiền cần thanh toán " + dt.ThanhTien + " VNĐ";
                        Response.Write("<script>alert('" + ms + "');</script>");
                        Response.Write("<script>window.location.href=\"Default.aspx\";</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Lỗi khi đặt tour');</script>");
                    }
                }
                else
                {
                }
            }
            else
            {
                if (ValidForm(true))
                {
                    soNL = SoNL.Text;
                    soTE = SoTE.Text;
                    DatTour dt = new DatTour();
                    try
                    {
                        string username = (string)Session["KhachHang_Login"];
                        KhachHang kh = new KhachHangBUS().KhachHang_GetByTop("", "TenDangNhap = '" + username + "'", "").ElementAt(0);
                        dt.IDKhachHang = kh.ID;
                        dt.SoNL = soNL;
                        dt.SoTE = soTE;
                        dt.IDTour = tour.ID;
                        double tien = (int.Parse(soNL) * Double.Parse(tour.GiaTourNL) + int.Parse(soTE) * Double.Parse(tour.GiaTourTE));
                        dt.ThanhTien = (tien * 95 / 100).ToString();
                        if (obj.DatTour_Insert(dt))
                        {
                            string ms = "Số tiền cần thanh toán " + dt.ThanhTien +" VNĐ. Đã giảm " + tien*5/100;
                            Response.Write("<script>alert('" + ms + "');</script>");
                            Response.Write("<script>window.location.href=\"Default.aspx\";</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('Lỗi khi đặt tour');</script>");
                        }
                    }
                    catch { }
                }
                else
                {
                }
            }
        }

        private bool ValidForm(bool isKhachHang)
        {
            if (isKhachHang)
            {
                try
                {
                    int.Parse(SoNL.Text);
                    int.Parse(SoTE.Text);
                }
                catch
                {
                    string message = "Vui lòng nhập lại số lượng người lớn/trẻ em";
                    Response.Write("<script>alert('" + message + "');</script>");
                    return false;
                }
                if (int.Parse(SoNL.Text) > int.Parse(tour.ConNL))
                {
                    string ms = "Số người lớn tối đa là" + tour.ConNL;
                    Response.Write("<script>alert('"+ms+"');</script>");
                    return false;
                }
                if (int.Parse(SoTE.Text) > int.Parse(tour.ConTE))
                {
                    string ms = "Số trẻ em tối đa là" + tour.ConTE;
                    Response.Write("<script>alert('" + ms + "');</script>");
                    return false;
                }
            }
            else
            {
                if(HoTen.Text.Trim() == string.Empty)
                {
                    Response.Write("<script>alert('Vui lòng nhập họ tên');</script>");
                    return false;
                }
                if (DienThoai.Text.Trim() == string.Empty)
                {
                    Response.Write("<script>alert('Vui lòng nhập điện thoại');</script>");
                    return false;
                }
                if (Email.Text.Trim() == string.Empty)
                {
                    Response.Write("<script>alert('Vui lòng nhập email');</script>");
                    return false;
                }
                try
                {
                    int.Parse(SoNL.Text);
                    int.Parse(SoTE.Text);
                }
                catch
                {
                    string message = "Vui lòng nhập lại số lượng người lớn/trẻ em";
                    Response.Write("<script>alert('" + message + "');</script>");
                    return false;
                }
                if (int.Parse(_SoNL.Text) > int.Parse(tour.ConNL))
                {
                    string ms = "Số người lớn tối đa là" + tour.ConNL;
                    Response.Write("<script>alert('" + ms + "');</script>");
                    return false;
                }
                if (int.Parse(_SoTE.Text) > int.Parse(tour.ConTE))
                {
                    string ms = "Số trẻ em tối đa là" + tour.ConTE;
                    Response.Write("<script>alert('" + ms + "');</script>");
                    return false;
                }
            }
            return true;
        }
    }
}