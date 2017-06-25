<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="Travel.News" %>

<%@ Register TagPrefix="cc1" Namespace="SiteUtils" Assembly="CollectionPager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" style="padding: 90px 0px 40px 0px;">
        <div class="row">
            <%--<div class="col-md-8 col-xs-12">
                <div class="newsItem" style="height: 200px; overflow: hidden; margin: 20px 0px;">
                    <div class="row">
                        <div class="col-xs-4 img" style="overflow: hidden;">
                            <img src="Template/images/img1.jpg" style="" />
                        </div>
                        <div class="col-xs-8 info" style="overflow:hidden;">
                            <h3 style="font-family:'Times New Roman', Times, serif; height:30px;overflow:hidden;"><a href="#">Đây là tiêu đề bài viết Đây là nội dung mô tả của bài viết.Đây là nội dung mô tả của bài viết Đây là nội dung mô tả của bài viết Đây là nội dung mô tả của bài viết Đây là nội dung mô tả của bài viết</a></h3>
                            <p style="text-align:justify;">Đây là nội dung mô tả của bài viết.Đây là nội dung mô tả của bài viết Đây là nội dung mô tả của bài viết Đây là nội dung mô tả của bài viết Đây là nội dung mô tả của bài viết
                                Đây là nội dung mô tả của bài viết.Đây là nội dung mô tả của bài viết Đây là nội dung mô tả của bài viết Đây là nội dung mô tả của bài viết Đây là nội dung mô tả của bài viết
                                Đây là nội dung mô tả của bài viết.Đây là nội dung mô tả của bài viết Đây là nội dung mô tả của bài viết Đây là nội dung mô tả của bài viết Đây là nội dung mô tả của bài viết
                            </p>
                        </div>
                    </div>
                </div>
            </div>--%>
            <div class="col-md-8 col-xs-12">
                <asp:DataList runat="server" ID="dtNews" RepeatColumns="1">
                    <ItemTemplate>
                        <div class="newsItem" style="height: 200px; overflow: hidden; margin: 20px 0px;">
                            <div class="row">
                                <div class="col-xs-4 img" style="overflow: hidden;">
                                    <img src='<%# Eval("AnhDaiDien") %>' style="" />
                                </div>
                                <div class="col-xs-8 info" style="overflow: hidden;">
                                    <h3 style="margin-bottom:10px;font-family: 'Times New Roman', Times, serif; height: 30px; overflow: hidden;"><a href='<%# Eval("ID","NewsDetail.aspx?ID={0}") %>'><%# Eval("TieuDe") %></a></h3>
                                    <div class="row">
                                        <div class="col-xs-6"><i class="fa fa-user"></i> <%# Eval("HoTen"," {0}") %></div>
                                        <div class="col-xs-6"><i class="fa fa-calendar-o"></i><%# Eval("NgayTao"," {0}") %></div>
                                    </div>
                                    <p style="text-align: justify;"><%# Eval("MoTa") %></p>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:DataList>
                <cc1:CollectionPager ID="pager" runat="server" PageSize="5" BackNextDisplay="HyperLinks" BackNextLocation="Split" BackText="Back" LastText="Last" FirstText="First" NextText="Next" MaxPages="3" PageNumbersDisplay="Numbers" PagingMode="QueryString" ShowFirstLast="True" ShowLabel="False" ShowPageNumbers="True" EnableViewState="True" HideOnSinglePage="True" ResultsLocation="Bottom" ControlStyle="float:right; padding-right:15px;" PageNumbersStyle="padding:5px"></cc1:CollectionPager>
            </div>
            <div class="col-md-4">
                <div class="ads">
                    <%= loadAds() %>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
