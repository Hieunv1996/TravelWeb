<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Travel.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row" style="padding: 90px 0px 50px 0px;">
        <h1 style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; padding-bottom: 20px;text-align:center;">Liên hệ với chúng tôi</h1>
        <div class="col-md-2"></div>
        <div class="col-md-8">
            <div class="form">
                <% if (Session["KhachHang_Login"] != null)
                    { %>
                <div class="form-group">
                    <label>Tiêu đề</label>
                    <asp:TextBox runat="server" ID="KH_TieuDe" TabIndex="5" CssClass="form-control" placeholder="Tiêu đề(required)"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>Nội dung</label>
                    <asp:TextBox TextMode="MultiLine" runat="server" ID="KH_NoiDung" TabIndex="6" CssClass="form-control" placeholder="Nội dung(required)" Height="200px"></asp:TextBox>
                </div>
                <%}
                    else
                    { %>
                <div class="form-group">
                    <label>Họ tên</label>
                    <asp:TextBox runat="server" ID="HoTen" TabIndex="1" CssClass="form-control" placeholder="Họ tên(required)"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>Điện thoại</label>
                    <asp:TextBox runat="server" ID="DienThoai" TabIndex="2" CssClass="form-control" placeholder="Điện thoại(required)"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>Emial</label>
                    <asp:TextBox runat="server" ID="Email" TabIndex="3" CssClass="form-control" placeholder="Email(required)"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>Địa chỉ</label>
                    <asp:TextBox runat="server" ID="DiaChi" TabIndex="4" CssClass="form-control" placeholder="Địa chỉ"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>Tiêu đề</label>
                    <asp:TextBox runat="server" ID="TieuDe" TabIndex="5" CssClass="form-control" placeholder="Tiêu đề(required)"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>Nội dung</label>
                    <asp:TextBox TextMode="MultiLine" runat="server" ID="NoiDung" TabIndex="6" CssClass="form-control" placeholder="Nội dung(required)" Height="200px"></asp:TextBox>
                </div>

                <%} %>
                <asp:Button runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" Text="Gửi Câu Hỏi" CssClass="btn btn-success btn-lg" Width="100%" />
            </div>
            <div>
                <h3 style="text-align:center;margin:50px 0px;font-family:'Times New Roman', Times, serif;">Thông tin liên hệ</h3>
                <center>
                    <address>
                    One Microsoft Way<br />
                    Redmond, WA 98052-6399<br />
                    <abbr title="Phone">Phone:</abbr>
                    425.555.0100
                </address>
                <address>
                    <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
                    <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
                </address>
                </center>
            </div>
        </div>
        <div class="col-md-2"></div>
    </div>
</asp:Content>
