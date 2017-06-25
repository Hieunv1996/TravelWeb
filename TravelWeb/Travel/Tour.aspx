<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tour.aspx.cs" Inherits="Travel.Tour" %>
<%@ Register TagPrefix="cc1" Namespace="SiteUtils" Assembly="CollectionPager" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="css/swipebox.css">

    <!-- tours -->
    <div class="welcome portfolio">
        <div class="container">
            <h3 class="agileits-title">Các tour du lịch phổ biến</h3>
            <div class="gallery_gds">
                <%--<ul class="simplefilter">
					<li class="active" data-filter="all">All</li>
					<li data-filter="1">Category 1</li>
					<li data-filter="2">Category 2</li>
					<li data-filter="3">Category 3</li>
				</ul>--%>
                <div class="filter">
                    <div class="row">
                        <div class="col-md-6">
                            <div id="custom-search-input">
                                <div class="input-group col-md-12">
                                    <asp:TextBox runat="server" ID="txtTimKiem" CssClass="form-control input-lg" placeholder="Tìm kiếm tour..."></asp:TextBox>
                                    <span class="input-group-btn">
                                        <asp:Button runat="server" CssClass="btn btn-info btn-lg" ID="btnTimKiem" Text='Search' OnClick="btnTimKiem_Click" />
                                            
                                    </span>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="input-group col-md-12">
                                <select class="form-control input-lg" style="border-radius: 5px;">
                                    <option disabled selected>--Select an option--</option>
                                    <option>Sắp xếp theo giá tăng dần</option>
                                    <option>Sắp xếp theo giá tăng dần</option>
                                </select>
                            </div>
                        </div>
                        <div class="col-md-2">
                            <div class="">
                                <span>Hiển thị    </span>
                                <div class="btn-group" style="padding-left: 10px;">
                                    <a href="#" id="list" class="btn btn-default btn-lg"><span class="glyphicon glyphicon-th-list"></span></a>
                                    <a href="#" id="grid" class="btn btn-default btn-lg"><span
                                        class="glyphicon glyphicon-th"></span></a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <asp:DataList runat="server" RepeatColumns="3" ID="dtTourList" Width="100%">
                    <ItemTemplate>
                            <div class="agileits-img" style="height: 241px; overflow: hidden;">
                                <a href='<%# Eval("ID","TourDetail.aspx?ID={0}") %>' class="swipebox" title="Click để xem thông tin chi tiết">
                                    <img class="img-responsive" src='<%# Eval("AnhMoTa") %>' alt="" />
                                </a>
                            </div>
                        <a style="display: block;" href='<%# Eval("ID","TourDetail.aspx?ID={0}") %>'>
                            <div style="border: 1px solid #ddd; cursor: pointer;">
                                <div class="travel-title" style="margin: 0px 15px; padding: 15px 0px; border-bottom: 1px solid #dddddd; height: 64px; overflow: hidden; font-weight: 500; font-size: 1.2em;">
                                    <%# Eval("TieuDe") %>
                                </div>
                                <div class="travel-price row" style="margin: 0px 15px; padding: 15px 0px; height: 75px;">
                                    <div class="col-xs-7 price" style="line-height: 50px; color: red; font-weight: 700; font-size: 1.5em;"><%# String.Format("{0:#,##0}", Double.Parse(Eval("GiaTourNL").ToString())) %><span style="vertical-align: super; font-size: 80%;">đ</span></div>
                                    <div class="col-xs-5" style="line-height: 50px;"><a class="btn btn-success form-control" href='<%# Eval("ID","TourDetail.aspx?ID={0}") %>'>Xem ngay</a></div>
                                </div>
                            </div>
                        </a>
                    </ItemTemplate>
                    <ItemStyle CssClass="col-md-4 col-sm-4 filtr-item" />
                </asp:DataList>
                 <cc1:CollectionPager ID="pager" runat="server" PageSize="9" BackNextDisplay="HyperLinks" BackNextLocation="Split" BackText="Back" LastText="Last" FirstText="First" NextText="Next" MaxPages="3" PageNumbersDisplay="Numbers" PagingMode="QueryString" ShowFirstLast="True" ShowLabel="False" ShowPageNumbers="True" EnableViewState="True" HideOnSinglePage="True" ResultsLocation="Bottom" ControlStyle="float:right; padding-right:15px;" PageNumbersStyle="padding:5px"></cc1:CollectionPager>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
    <!-- //tours -->

</asp:Content>
