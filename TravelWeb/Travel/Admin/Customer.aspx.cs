using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Travel.Bussiness;
using Travel.Entities;

namespace Travel.Admin
{
    public partial class Customer : System.Web.UI.Page
    {
        private KhachHangBUS obj = new KhachHangBUS();

        private static KhachHang editItem = new KhachHang();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin_Login"] == null) Response.Redirect("Login.aspx");
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }

        private void BindData()
        {
            List<KhachHang> lst = obj.KhachHang_GetByTop("", "", "");
            dgKH.DataSource = lst;
            dgKH.DataBind();
        }

        protected void dgKH_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            dgKH.CurrentPageIndex = e.NewPageIndex;
            BindData();
        }
        protected void dgKH_EditCommand(object source, DataGridCommandEventArgs e)
        {
            ClearText();
            ID.Text = e.Item.Cells[0].Text;
            editItem.ID = ID.Text;
            if (!String.IsNullOrWhiteSpace(e.Item.Cells[1].Text))
                HoTen.Text = e.Item.Cells[1].Text;
            editItem.HoTen = HoTen.Text;
            if (!String.IsNullOrWhiteSpace(e.Item.Cells[2].Text))
                TenDangNhap.Text = e.Item.Cells[2].Text;
            editItem.TenDangNhap = TenDangNhap.Text;
            if (!String.IsNullOrWhiteSpace(e.Item.Cells[3].Text))
                MatKhau.Text = e.Item.Cells[3].Text;
            editItem.MatKhau = MatKhau.Text;
            if (!String.IsNullOrWhiteSpace(e.Item.Cells[4].Text))
                DiaChi.Text = e.Item.Cells[4].Text;
            editItem.DiaChi = DiaChi.Text;
            if (!String.IsNullOrWhiteSpace(e.Item.Cells[5].Text))
                DienThoai.Text = e.Item.Cells[5].Text;
            editItem.DienThoai = DienThoai.Text;
            if (!String.IsNullOrWhiteSpace(e.Item.Cells[6].Text))
                Email.Text = e.Item.Cells[6].Text;
            NgayDangKy.Text = e.Item.Cells[7].Text;
            editItem.Email = Email.Text;
            TieuDe.Text = "Sửa thông tin khách hàng";
            btnSubmit.Text = "Cập nhật";
            pnGridView.Visible = false;
            pnEditData.Visible = true;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            pnEditData.Visible = false;
            pnGridView.Visible = true;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if(ID.Text.Length > 0)
            {
                editItem.Email = Email.Text;
                editItem.DiaChi = DiaChi.Text;
                editItem.DienThoai = DienThoai.Text;
                editItem.HoTen = HoTen.Text;
                editItem.TenDangNhap = TenDangNhap.Text;
                editItem.MatKhau = MatKhau.Text;
                if (obj.KhachHang_Update(editItem))
                {
                    string ms = "Cập nhật thành công";
                    BindData();
                    Response.Write("<script>alert('" + ms + "');</script>");
                    pnEditData.Visible = false;
                    pnGridView.Visible = true;
                }
                else
                {
                    string ms = "Cập nhật không thành công";
                    Response.Write("<script>alert('" + ms + "');</script>");
                }
            }
            else
            {
                editItem.Email = Email.Text;
                editItem.DiaChi = DiaChi.Text;
                editItem.DienThoai = DienThoai.Text;
                editItem.HoTen = HoTen.Text;
                editItem.TenDangNhap = TenDangNhap.Text;
                editItem.MatKhau = MatKhau.Text;
                editItem.NgayDangKy = DateTime.Now.ToString();
                if (obj.KhachHang_Insert(editItem))
                {
                    string ms = "Thêm mới thành công";
                    BindData();
                    Response.Write("<script>alert('" + ms + "');</script>");
                    pnEditData.Visible = false;
                    pnGridView.Visible = true;
                }
                else
                {
                    string ms = "Thêm mới không thành công";
                    Response.Write("<script>alert('" + ms + "');</script>");
                }
            }
        }

        private void ClearText()
        {
            ID.Text = "";
            HoTen.Text = "";
            TenDangNhap.Text = "";
            MatKhau.Text = "";
            DiaChi.Text = "";
            DienThoai.Text = "";
            Email.Text = "";
            btnSubmit.Text = "Thêm mới";
            TieuDe.Text = "Thêm mới khách hàng";
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            ClearText();
            pnEditData.Visible = true;
            pnGridView.Visible = false;
        }

        protected void dgKH_DeleteCommand(object source, DataGridCommandEventArgs e)
        {
            if (obj.KhachHang_Delete(e.Item.Cells[0].Text))
            {
                string ms = "Xóa thành công";
                Response.Write("<script>alert('" + ms + "');</script>");
                BindData();
            }
            else
            {
                string ms = "Xóa không thành công";
                Response.Write("<script>alert('" + ms + "');</script>");
            }
        }
    }
}