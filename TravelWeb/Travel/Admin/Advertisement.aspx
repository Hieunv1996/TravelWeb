﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site.Master" AutoEventWireup="true" CodeBehind="Advertisement.aspx.cs" Inherits="Travel.Admin.Advertisement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel runat="server" ID="pnGridView">
        <h1 style="text-align: center; margin-bottom: 30px;">Danh sách quảng cáo</h1>

        <div class="text-right" style="margin-bottom: 40px;">
            <asp:Button runat="server" CssClass="btn btn-success" Text="Thêm quảng cáo" ID="btnThem" OnClick="btnThem_Click" />
        </div>
        <asp:DataGrid ID="dgAds" runat="server"
            AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" AutoGenerateDeleteButton="True"
            AutoGenerateEditButton="True" Width="100%" CellPadding="5" OnPageIndexChanged="dgAds_PageIndexChanged"
            OnDeleteCommand="dgAds_DeleteCommand" OnEditCommand="dgAds_EditCommand"
            GridLines="None">
            <Columns>
                <asp:BoundColumn HeaderText="ID" DataField="ID"></asp:BoundColumn>
                <asp:BoundColumn HeaderText="Image" DataField="Image"></asp:BoundColumn>
                <asp:BoundColumn HeaderText="Width" DataField="Width"></asp:BoundColumn>
                <asp:BoundColumn HeaderText="Height" DataField="Height"></asp:BoundColumn>
                <asp:BoundColumn HeaderText="Url" DataField="Url"></asp:BoundColumn>
                <asp:BoundColumn HeaderText="Target" DataField="Target"></asp:BoundColumn>
                <asp:BoundColumn HeaderText="TimeBD" DataField="TimeBD"></asp:BoundColumn>
                <asp:BoundColumn HeaderText="TimeKT" DataField="TimeKT"></asp:BoundColumn>
                <asp:BoundColumn HeaderText="LuotClick" DataField="LuotClick"></asp:BoundColumn>
                <asp:BoundColumn HeaderText="IsActive" DataField="IsActive"></asp:BoundColumn>
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
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" Mode="NumericPages" />
            <AlternatingItemStyle BackColor="White" />
            <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />

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
            <label>Image</label>
            <asp:TextBox runat="server" ID="Image" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Width</label>
            <asp:TextBox runat="server" ID="Width" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Height</label>
            <asp:TextBox runat="server" ID="Height" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Url</label>
            <asp:TextBox runat="server" ID="Url" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Target</label>
            <asp:TextBox runat="server" ID="Target" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Thời gian bắt đầu</label>
            <asp:TextBox runat="server" ID="TimeBD" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Thời gian kết thúc</label>
            <asp:TextBox runat="server" ID="TimeKT" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Lượt Click</label>
            <asp:TextBox runat="server" ID="LuotClick" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Active</label>
            <asp:TextBox runat="server" ID="IsActive" CssClass="form-control"></asp:TextBox>
        </div>
        
        <asp:Button runat="server" ID="btnSubmit" CssClass="btn btn-success btn-lg" OnClick="btnSubmit_Click" Text="Thêm mới" />
        <asp:Button runat="server" ID="btnCancel" CssClass="btn btn-default btn-lg" OnClick="btnCancel_Click" Text="Hủy bỏ" />
    </asp:Panel>
</asp:Content>
