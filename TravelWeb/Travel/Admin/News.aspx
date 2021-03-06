﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="Travel.Admin.News" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel runat="server" ID="pnGridView">
        <h1 style="text-align: center; margin-bottom: 30px;">Danh sách quảng cáo</h1>

        <div class="text-right" style="margin-bottom: 40px;">
            <asp:Button runat="server" CssClass="btn btn-success" Text="Thêm tin tức" ID="btnThem" OnClick="btnThem_Click" />
        </div>
        <asp:DataGrid ID="dgNews" runat="server"
            AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" AutoGenerateDeleteButton="True"
            AutoGenerateEditButton="True" Width="100%" CellPadding="5" OnPageIndexChanged="dgNews_PageIndexChanged"
            OnDeleteCommand="dgNews_DeleteCommand" OnEditCommand="dgNews_EditCommand"
            GridLines="None">
            <Columns>
                <asp:BoundColumn HeaderText="ID" DataField="ID"></asp:BoundColumn>
                <asp:BoundColumn HeaderText="TieuDe" DataField="TieuDe"></asp:BoundColumn>
                <%--<asp:BoundColumn HeaderText="MoTa" DataField="MoTa"></asp:BoundColumn>--%>
                <%--<asp:BoundColumn HeaderText="NoiDung" DataField="NoiDung"></asp:BoundColumn>--%>
                <%--<asp:BoundColumn HeaderText="AnhDaiDien" DataField="AnhDaiDien"></asp:BoundColumn>--%>
                <asp:BoundColumn HeaderText="NgayTao" DataField="NgayTao"></asp:BoundColumn>
                <asp:BoundColumn HeaderText="NguoiTao" DataField="NguoiTao"></asp:BoundColumn>
                <asp:TemplateColumn HeaderText="Sửa">

                    <ItemTemplate>
                        <asp:LinkButton runat="server" CausesValidation="false" CommandName="Edit" Text="Sửa"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn HeaderText="Xóa">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" CausesValidation="false" OnClientClick="return confirm('Bạn muốn xóa bản ghi?');" CommandName="Delete" Text="Delete"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateColumn>
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" VerticalAlign="Middle" Height="30px" Mode="NumericPages" />
            <AlternatingItemStyle BackColor="White" />
            <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <HeaderStyle BackColor="#990000" HorizontalAlign="Center" VerticalAlign="Middle" Height="30px" Font-Bold="True" ForeColor="White" />

        </asp:DataGrid>
    </asp:Panel>
    <asp:Panel runat="server" ID="pnEditData" Visible="false">
        <h1>
            <asp:Label runat="server" ID="TieuDe" CssClass="text-center" EnableTheming="True" Font-Bold="True" Font-Strikeout="False" Font-Underline="True" Width="100%">Thêm mới quảng cáo</asp:Label></h1>
        <div class="form-group">
            <label>ID</label>
            <asp:TextBox Enabled="false" runat="server" ID="ID" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Tiêu đề</label>
            <asp:TextBox runat="server" ID="_TieuDe" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Mô tả</label>
            <asp:TextBox runat="server" ID="MoTa" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Nội dung</label>
            <asp:TextBox runat="server" TextMode="MultiLine" ID="NoiDung" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Ảnh đại diện</label>
            <asp:TextBox runat="server" ID="AnhDaiDien" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Ngày tạo</label>
            <asp:TextBox runat="server" Enabled="false" ID="NgayTao" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Người tạo</label>
            <asp:TextBox runat="server" Enabled="false" ID="NguoiTao" CssClass="form-control"></asp:TextBox>
        </div>
        
        <asp:Button runat="server" ID="btnSubmit" CssClass="btn btn-success btn-lg" OnClick="btnSubmit_Click" Text="Thêm mới" />
        <asp:Button runat="server" ID="btnCancel" CssClass="btn btn-default btn-lg" OnClick="btnCancel_Click" Text="Hủy bỏ" />
    </asp:Panel>
</asp:Content>
