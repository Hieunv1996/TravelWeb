<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="Travel.Account" %>

<%@ Register TagPrefix="uc1" TagName="ErrorPage" Src="~/UserControl/404.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%if (kh == null)
        { %>
    <uc1:ErrorPage runat="server" />
    <%}
        else
        { %>
    <div class="container" style="padding: 90px 0px 40px 0px;">
        <div class="row">
            <div class="col-md-3"></div>
            <div class="col-md-6">
                <p style="font-size: 1.5em;">
                    Xin chào <%= kh.HoTen %> (
                    <asp:LinkButton runat="server" ID="btnLogout" OnClick="btnLogout_Click">Đăng xuất</asp:LinkButton>
                    )
                </p>
                <h3 style="text-align: center; padding-bottom: 30px;">Thông tin tài khoản</h3>
                <div class="userForm">
                    <div class="form-group">
                        <asp:TextBox runat="server" CssClass="form-control" ID="HoTen" placeholder="Họ tên (required)"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:TextBox runat="server" CssClass="form-control" ID="TenDangNhap" placeholder="Tên đăng nhập" Enabled="False"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:TextBox runat="server" CssClass="form-control" ID="MatKhau" TextMode="Password" placeholder="Mật khẩu mới"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:TextBox runat="server" CssClass="form-control" ID="ReMatKhau" TextMode="Password" placeholder="Nhập lại mật khẩu mới"> </asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:TextBox runat="server" CssClass="form-control" ID="DiaChi" placeholder="Địa chỉ (required)"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:TextBox runat="server" CssClass="form-control" TextMode="Phone" ID="DienThoai" placeholder="Điện thoại (required)"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:TextBox runat="server" CssClass="form-control" TextMode="Email" ID="EmailAddress" placeholder="Email (required)"></asp:TextBox>
                    </div>
                    <asp:Button runat="server" ID="btnCapNhat" OnClick="btnCapNhat_Click" CssClass="btn btn-success btn-lg" Width="100%" />
                </div>
            </div>
        </div>
        <div class="col-md-3"></div>
    </div>
    <%} %>
</asp:Content>
