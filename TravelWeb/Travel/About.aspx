<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Travel.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- about -->
    <div class="welcome about">
        <div class="container">
            <h3 class="agileits-title">Về chúng tôi</h3>
            <div class="about-grids">
                <div class="col-md-5 welcome-w3right">
                    <img src="Template/images/img4.jpg" class="img-responsive" alt="" />
                </div>
                <div class="col-md-7 welcome-w3left">
                    <h4>Giới thiệu công ty</h4>
                    <p>
                        Tháng 12 năm 1996, Holiday Spot được thành lập với thành viên đầu tiên với vai trò tổng đại lý của nhiều hãng hàng không quốc tế tại Việt Nam. 
                        Tiếp nối những thành công gặt hái được tại mảng hàng không, năm 1998, trước nhu cầu về một công ty lữ hành chuyên nghiệp, có khả năng đáp ứng những đòi hỏi ngày càng khắt khe của du khách về các sản phẩm tour độc đáo, hấp dẫn mà giá cả lại không kém phần cạnh tranh, Holiday Spot đã ra đời như sự lựa chọn của UY TÍN và CHẤT LƯỢNG.
                    </p>
                    <br>
                    <br>
                    <h4>Tầm nhìn và Cam kết
                    </h4>
                    <p>
                        Holiday Spot cam kết cung cấp chất lượng dịch vụ tốt nhất, mang tính chuyên nghiệp cao nhất đến với khách hàng. Holiday Spot đã, đang và sẽ không ngừng phấn đấu để củng cố hơn nữa niềm tin của Quý khách hàng dành cho chúng tôi trong suốt thời gian vừa qua.
.
                    </p>
                </div>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
    <!-- //about -->
    <!-- statistics -->
    <div class="container">
        <div class="stats welcome">
            <div class="col-xs-4 col-md-4 agileinfo_stats_grid">
                <h4 class="counter">5654</h4>
                <h5>Tổng số tour cung cấp</h5>
            </div>
            <div class="col-xs-4 col-md-4 agileinfo_stats_grid">
                <h4 class="counter">432</h4>
                <h5>Địa điểm du lịch</h5>
            </div>
            <div class="col-xs-4 col-md-4 agileinfo_stats_grid">
                <h4 class="counter">25</h4>
                <h5>Quốc giá khác nhau</h5>
            </div>
            <div class="clearfix"></div>
            <!-- Stats-Number-Scroller-Animation-JavaScript -->
            <script src="js/waypoints.min.js"></script>
            <script src="js/counterup.min.js"></script>
            <script>
                jQuery(document).ready(function ($) {
                    $('.counter').counterUp({
                        delay: 10,
                        time: 1000
                    });
                });
            </script>
            <!-- //Stats-Number-Scroller-Animation-JavaScript -->
        </div>
    </div>
    <!-- //statistics -->
    <!-- about-features -->
    <div class="slid about-slid">
        <div class="container">
            <h3>“Hãy ngắm nhìn thế giới. Điều đó tuyệt vời hơn bất cứ giấc mơ nào. “</h3>
            <p style="text-align:right;">- Ray Bradbury -</p>
        </div>
    </div>
    <!-- //about-features -->
    
    <!-- newsletter -->
    <div class="newsletter">
        <div class="container">
            <h3 class="agileits-title">Đăng kí nhận bản tin</h3>
            <p>Nhập email của bạn để đăng kí nhận tin tức cập nhật mới nhất của chúng tôi </p>
            <form action="#" method="post">
                <input type="text" name="email" placeholder="Nhập địa chỉ email..." required="">
                <input type="submit" value="Đăng kí">
                <div class="clearfix"></div>
            </form>
        </div>
    </div>
    <!-- //newsletter -->
</asp:Content>
