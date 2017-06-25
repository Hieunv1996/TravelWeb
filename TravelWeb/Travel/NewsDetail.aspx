<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewsDetail.aspx.cs" Inherits="Travel.NewsDetail" %>

<%@ Register TagPrefix="uc1" TagName="ErrorPage" Src="~/UserControl/404.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <% if (tintuc == null)
        { %>
    <uc1:ErrorPage runat="server" />
    <%}
        else
        { %>
    <div class="container" style="padding:90px 0px 40px 0px;">
        <div class="row">
            <div class="col-xs-2"></div>
            <div class="col-xs-8">
                <h1>
                    <asp:Label runat="server" ID="TieuDe" Font-Names="Times New Roman, Times, serif"  > </asp:Label></h1>
                <div class="row">
                    <div class="col-xs-6"><i class="fa fa-user"></i>
                        <asp:Label runat="server" ID="lbNguoiTao"></asp:Label></div>
                    <div class="col-xs-6"><i class="fa fa-calendar-o"></i>
                        <asp:Label runat="server" ID="lbNgayTao"></asp:Label></div>
                </div>
                <asp:Image runat="server" ID="AnhDaiDien" ImageUrl="~/Template/images/img1.jpg" />
                <div class="text">
                    <p class="des" style="font-weight: bold; text-align: justify;">
                        <asp:Label runat="server" ID="MoTa"> </asp:Label></p>
                    <p class="content">
                        <asp:Label runat="server" ID="NoiDung"></asp:Label>
                    </p>
                </div>
            </div>
            <div class="col-xs-2"></div>
        </div>
    </div>
    <%} %>
</asp:Content>
