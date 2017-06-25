<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" Inherits="Travel.Booking" %>

<%@ Register TagPrefix="uc1" TagName="ErrorPage" Src="~/UserControl/404.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%if (tour == null)
        { %>
    <uc1:ErrorPage runat="server" />
    <%}
        else
        { %>

    <div class="container" style="padding: 90px 0px 40px 0px;">
        <h1 style="text-align: center; padding-bottom: 20px; font-family: 'Times New Roman', Times, serif;">Đặt tour</h1>
        <p style="font-weight: bold; font-size: 1.5em; color: red; width: 50%; margin: 0px auto; text-align: center; padding-bottom: 10px; border-bottom: 1px solid #ddd; margin-bottom: 30px;"><%= tour.TieuDe %></p>
        <div class="row">
            <div class="col-md-3"></div>
            <div class="col-md-6">
                <% if (Session["KhachHang_Login"] == null)
                    { %>
                <div class="form-group">
                    <asp:TextBox runat="server" CssClass="form-control" TabIndex="1" placeholder="Họ tên" ID="HoTen"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox runat="server" CssClass="form-control" TabIndex="2" placeholder="Điện thoại" ID="DienThoai"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox runat="server" CssClass="form-control" TabIndex="3" placeholder="Email" ID="Email"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox runat="server" TextMode="Number" CssClass="form-control" TabIndex="4" placeholder="Số người lớn" ID="_SoNL"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox runat="server" TextMode="Number" CssClass="form-control" TabIndex="5" placeholder="Số trẻ em" ID="_SoTE"></asp:TextBox>
                </div>
                <asp:Button runat="server" CssClass="btn btn-lg btn-success" ID="btnThanhToan" OnClick="btnThanhToan_Click" TabIndex="5" Text="Thanh toán" Width="100%" ToolTip="Thanh toán" />
                <%}
                    else
                    { %>
                <div class="form-group">
                    <asp:TextBox runat="server" TextMode="Number" CssClass="form-control" TabIndex="1" placeholder="Số người lớn" ID="SoNL"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox runat="server" TextMode="Number" CssClass="form-control" TabIndex="2" placeholder="Số trẻ em" ID="SoTE"></asp:TextBox>
                </div>
                <asp:Button runat="server" CssClass="btn btn-lg btn-success" ID="Button1" OnClick="btnThanhToan_Click" TabIndex="4" Text="Thanh toán" Width="100%" ToolTip="Thanh toán" />
                <%} %>
            </div>
            <div class="col-md-3"></div>
        </div>
    </div>

    <%} %>
</asp:Content>
