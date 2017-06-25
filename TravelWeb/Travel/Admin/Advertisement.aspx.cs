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
    public partial class Advertisement : System.Web.UI.Page
    {
        private QuangCaoBUS obj = new QuangCaoBUS();
        private static QuangCao editItem = new QuangCao();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin_Login"] == null) Response.Redirect("Login.aspx");
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }

        protected void dgAds_DeleteCommand(object source, DataGridCommandEventArgs e)
        {
            if (obj.QuangCao_Delete(e.Item.Cells[0].Text))
            {
                string ms = "Xóa thành công";
                Response.Write("<script>alert('" + ms + "');</script>");
                BindData();
                Response.Redirect("Advertisement.aspx");
            }
            else
            {
                string ms = "Xóa không thành công";
                Response.Write("<script>alert('" + ms + "');</script>");
            }
        }

        protected void dgAds_EditCommand(object source, DataGridCommandEventArgs e)
        {
            ClearText();
            ID.Text = e.Item.Cells[0].Text;
            editItem.ID = ID.Text;
            if (!String.IsNullOrWhiteSpace(e.Item.Cells[1].Text.Replace("&nbsp;", "")))
                Image.Text = e.Item.Cells[1].Text;
            editItem.Image = Image.Text;
            if (!String.IsNullOrWhiteSpace(e.Item.Cells[2].Text.Replace("&nbsp;", "")))
                Width.Text = e.Item.Cells[2].Text;
            editItem.Width = Width.Text;
            if (!String.IsNullOrWhiteSpace(e.Item.Cells[3].Text.Replace("&nbsp;", "")))
                Height.Text = e.Item.Cells[3].Text;
            editItem.Height = Height.Text;
            if (!String.IsNullOrWhiteSpace(e.Item.Cells[4].Text.Replace("&nbsp;", "")))
                Url.Text = e.Item.Cells[4].Text;
            editItem.Url = Url.Text;
            if (!String.IsNullOrWhiteSpace(e.Item.Cells[5].Text.Replace("&nbsp;", "")))
                Target.Text = e.Item.Cells[5].Text;
            editItem.Target = Target.Text;
            if (!String.IsNullOrWhiteSpace(e.Item.Cells[6].Text.Replace("&nbsp;", "")))
                TimeBD.Text = e.Item.Cells[6].Text;
            editItem.TimeBD = TimeBD.Text;
            if (!String.IsNullOrWhiteSpace(e.Item.Cells[7].Text.Replace("&nbsp;", "")))
                TimeKT.Text = e.Item.Cells[7].Text;
            editItem.TimeKT = TimeKT.Text;
            if (!String.IsNullOrWhiteSpace(e.Item.Cells[8].Text.Replace("&nbsp;", "")))
                LuotClick.Text = e.Item.Cells[8].Text;
            editItem.LuotClick = LuotClick.Text;
            if (!String.IsNullOrWhiteSpace(e.Item.Cells[9].Text.Replace("&nbsp;", "")))
                IsActive.Text = e.Item.Cells[9].Text;
            editItem.IsActive = IsActive.Text;

            TieuDe.Text = "Sửa thông tin quảng cáo";
            btnSubmit.Text = "Cập nhật";
            pnGridView.Visible = false;
            pnEditData.Visible = true;
        }

        protected void dgAds_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            dgAds.CurrentPageIndex = e.NewPageIndex;
            BindData();
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
                editItem.Image = Image.Text;
                editItem.Width = Width.Text;
                editItem.Height = Height.Text;
                editItem.Target = Target.Text;
                editItem.Url = Url.Text;
                editItem.TimeBD = TimeBD.Text;
                editItem.TimeKT = TimeKT.Text;
                editItem.IsActive = IsActive.Text;
                editItem.LuotClick = LuotClick.Text;
                if (obj.QuangCao_Update(editItem))
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
                editItem.Image = Image.Text;
                editItem.Width = Width.Text;
                editItem.Height = Height.Text;
                editItem.Target = Target.Text;
                editItem.Url = Url.Text;
                editItem.TimeBD = TimeBD.Text;
                editItem.TimeKT = TimeKT.Text;
                editItem.IsActive = IsActive.Text;
                editItem.LuotClick = LuotClick.Text;
                if (obj.QuangCao_Insert(editItem))
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
            List<Travel.Entities.QuangCao> lst = obj.QuangCao_GetByTop("", "", "");
            dgAds.DataSource = lst;
            dgAds.DataBind();
        }

        private void ClearText()
        {
            ID.Text = "";
            Image.Text = "";
            Width.Text = "";
            Height.Text = "";
            Url.Text = "";
            Target.Text = "";
            IsActive.Text = "";
            LuotClick.Text = "";
            TimeBD.Text = "";
            TimeKT.Text = "";
            btnSubmit.Text = "Thêm mới";
            TieuDe.Text = "Thêm mới quảng cáo";
        }
    }
}