using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Travel.Bussiness;

namespace Travel.Admin
{
    public partial class Account : System.Web.UI.Page
    {
        private AdminBUS obj = new AdminBUS();
        private static Travel.Entities.Admin editItem = new Travel.Entities.Admin();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin_Login"] == null) Response.Redirect("Login.aspx");
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }

        protected void dgAccount_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            dgAccount.CurrentPageIndex = e.NewPageIndex;
            BindData();
        }

        protected void dgAccount_DeleteCommand(object source, DataGridCommandEventArgs e)
        {
            if (obj.Admin_Delete(e.Item.Cells[0].Text))
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

        protected void dgAccount_EditCommand(object source, DataGridCommandEventArgs e)
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

            TieuDe.Text = "Sửa thông tin tài khoản Admin";
            btnSubmit.Text = "Cập nhật";
            pnGridView.Visible = false;
            pnEditData.Visible = true;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ID.Text.Length > 0)
            {
                editItem.HoTen = HoTen.Text;
                editItem.TenDangNhap = TenDangNhap.Text;
                editItem.MatKhau = MatKhau.Text;
                if (obj.Admin_Update(editItem))
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
                editItem.HoTen = HoTen.Text;
                editItem.TenDangNhap = TenDangNhap.Text;
                editItem.MatKhau = MatKhau.Text;
                if (obj.Admin_Insert(editItem))
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

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            pnEditData.Visible = false;
            pnGridView.Visible = true;
        }
        protected void btnThem_Click(object sender, EventArgs e)
        {
            ClearText();
            pnEditData.Visible = true;
            pnGridView.Visible = false;
        }
        private void BindData()
        {
            List<Travel.Entities.Admin> lst = obj.Admin_GetByTop("", "", "");
            dgAccount.DataSource = lst;
            dgAccount.DataBind();
        }

        private void ClearText()
        {
            ID.Text = "";
            HoTen.Text = "";
            TenDangNhap.Text = "";
            MatKhau.Text = "";
            btnSubmit.Text = "Thêm mới";
            TieuDe.Text = "Thêm mới tài khoản admin";
        }

        
    }
}