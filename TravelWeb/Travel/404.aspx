<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="404.aspx.cs" Inherits="Travel._404" %>
<%@ Register TagPrefix="uc1" TagName="ErrorPage" Src="~/UserControl/404.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:ErrorPage  runat="server"/>
</asp:Content>
