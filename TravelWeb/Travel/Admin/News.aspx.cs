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
    public partial class News : System.Web.UI.Page
    {
        private TinTucBUS obj = new TinTucBUS();
        private static TinTuc editItem = new TinTuc();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin_Login"] == null) Response.Redirect("Login.aspx");
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }

        protected void dgNews_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            dgNews.CurrentPageIndex = e.NewPageIndex;
            
            
                BindData();
            
        }

        protected void dgNews_DeleteCommand(object source, DataGridCommandEventArgs e)
        {
            if (obj.TinTuc_Delete(e.Item.Cells[0].Text))
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

        protected void dgNews_EditCommand(object source, DataGridCommandEventArgs e)
        {
            ClearText();
            TinTuc t = obj.TinTuc_GetByTop("", "ID=" + e.Item.Cells[0].Text, "").ElementAt(0);
            editItem.ID = t.ID;
            if (!String.IsNullOrWhiteSpace(e.Item.Cells[1].Text.Replace("&nbsp;", "")))
                _TieuDe.Text = t.TieuDe;
            editItem.TieuDe = _TieuDe.Text;
            if (!String.IsNullOrWhiteSpace(e.Item.Cells[2].Text.Replace("&nbsp;", "")))
                MoTa.Text = t.MoTa;
            editItem.MoTa = MoTa.Text;
            if (!String.IsNullOrWhiteSpace(e.Item.Cells[3].Text.Replace("&nbsp;", "")))
                NoiDung.Text = t.NoiDung;
            editItem.NoiDung = NoiDung.Text;
            if (!String.IsNullOrWhiteSpace(e.Item.Cells[4].Text.Replace("&nbsp;", "")))
                AnhDaiDien.Text = t.AnhDaiDien;
            editItem.AnhDaiDien = AnhDaiDien.Text;
            if (!String.IsNullOrWhiteSpace(e.Item.Cells[5].Text.Replace("&nbsp;", "")))
                NgayTao.Text = t.NgayTao;
            editItem.NgayTao = NgayTao.Text;
            if (!String.IsNullOrWhiteSpace(e.Item.Cells[6].Text.Replace("&nbsp;", "")))
                NguoiTao.Text = t.NguoiTao;
            editItem.NguoiTao = NguoiTao.Text;
            
            TieuDe.Text = "Sửa tin tức";
            btnSubmit.Text = "Cập nhật";
            pnGridView.Visible = false;
            pnEditData.Visible = true;
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            ClearText();
            pnEditData.Visible = true;
            pnGridView.Visible = false;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ID.Text.Length > 0)
            {
                editItem.TieuDe = _TieuDe.Text;
                editItem.MoTa = MoTa.Text;
                editItem.NoiDung = NoiDung.Text;
                editItem.AnhDaiDien = AnhDaiDien.Text;
                if (obj.TinTuc_Update(editItem))
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
                editItem.TieuDe = _TieuDe.Text;
                editItem.MoTa = MoTa.Text;
                editItem.NoiDung = NoiDung.Text;
                editItem.AnhDaiDien = AnhDaiDien.Text;
                editItem.NgayTao = DateTime.Now.ToString();
                editItem.NguoiTao = NguoiTao.Text;
                if (obj.TinTuc_Insert(editItem))
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
        private void BindData()
        {
            List<Travel.Entities.TinTuc> lst = obj.TinTuc_GetByTop("", "", "");
            dgNews.DataSource = lst;
            dgNews.DataBind();
        }

        private void ClearText()
        {
            ID.Text = "";
            _TieuDe.Text = "";
            MoTa.Text = "";
            NoiDung.Text = "";
            AnhDaiDien.Text = "";
            btnSubmit.Text = "Thêm mới";
            TieuDe.Text = "Thêm mới tin tức";
            NguoiTao.Text = new AdminBUS().Admin_GetByTop("", "TenDangNhap = '" + (string)Session["Admin_Login"] + "'", "").ElementAt(0).ID;
            NgayTao.Text = DateTime.Now.ToString();
        }
    }
}