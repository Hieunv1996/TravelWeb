<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TourDetail.aspx.cs" Inherits="Travel.TourDetail" %>
<%@ Register TagPrefix="uc1" TagName="ErrorPage" Src="~/UserControl/404.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%if (tour == null)
        { %>
    <div class="container" style="padding: 90px 0px 20px 0px;">
        <uc1:ErrorPage runat="server" />
    </div>
    <%}
        else
        { %>
    <div class="container" style="padding: 90px 0px 20px 0px;">
        <div class="row">
            <div class="col-md-8 col-xs-12">
                <div class="img">
                    <img src="Template/images/img1.jpg" alt="" style="width: 100%;" />
                </div>
                <div class="info" style="margin: 0px 15px; padding: 15px 0px;">
                    <div class="title" style="font-weight: 700; font-size: 1.5em;">
                        <%= tour.TieuDe %>
                    </div>
                    <div class="detail">
                        <p>Địa điểm xuất phát: <span><%= tour.DiaDiemXuatPhat %></span></p>
                        <p>Địa điểm kết thúc: <span><%= tour.DiaDiemKetThuc %></span></p>
                        <p>Thời gian Tour: <span><%= tour.NgayKhoiHanh + " - " + tour.NgayKetThuc %></span></p>
                        <p style="font-weight: bold; font-size: 1.2em;">Mô tả tour</p>
                        <p style="padding-left: 15px;"><%= tour.MoTaTour %></p>
                        <p style="font-weight: bold; font-size: 1.2em;">Mô tả phương tiện</p>
                        <p style="padding-left: 15px;"><%= tour.MoTaPhuongTien %></p>
                        <p style="font-weight: bold; font-size: 1.2em;">Danh sách các địa điểm đi qua</p>
                        <p style="padding-left: 15px;"><%= tour.DSDiaDanh.ToString().Replace(";"," - ") %></p>
                    </div>
                </div>
            </div>
            <div class="col-md-4 col-xs-12">
                <p style="font-weight: bold; font-size: 1.3em; color: grey;">Thông tin chi tiết Tour</p>
                <div class="price" style="padding-left: 15px;">
                    <p>Thời gian khởi hành:<span><%= tour.NgayKhoiHanh %></span></p>
                    <p>Giá tour người lớn: <span style="color: red; font-weight: bold;"><%= String.Format("{0:#,##0}",Double.Parse(tour.GiaTourNL)) %><span style="vertical-align: super; color: red;">đ</span></span></p>
                    <p>Giá tour trẻ em: <span style="color: red; font-weight: bold;"><%= String.Format("{0:#,##0}",Double.Parse(tour.GiaTourTE)) %><span style="vertical-align: super; color: red;">đ</span></span></p>
                    <p>Số chỗ còn người lớn: <%= tour.ConNL %></p>
                    <p>Số chỗ còn trẻ em: <%= tour.ConTE %></p>
                    <p style="font-weight:bold;">Dịch vụ đi kèm</p>
                    <div style="padding-left:20px;">
                        <%= LoadDichVu() %>
                    </div>
                    <% if (Session["KhachHang_Login"] == null)
                        { %>
                    <p style="color: red; font-size: 1.2em;font-weight:bold;">Giám giá 5% cho thành viên >> <a href="Login.aspx">Nhận ngay</a></p>
                    <%}
                    else
                    { %>
                    <p style="color: red; font-size: 1.2em;font-weight:bold;">Đặt ngay để được giảm giá 5%</p>
                    <%} %>
                </div>
                <a style="margin-top: 20px; width: 100%;" href="<%= "Booking.aspx?ID="+tour.ID %>" class="btn btn-success btn-lg">Đặt ngay</a>
            </div>
        </div>
    </div>
    <%} %>
</asp:Content>
