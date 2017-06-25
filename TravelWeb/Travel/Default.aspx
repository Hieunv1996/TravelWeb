<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Travel._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <link rel="stylesheet" href="Template/css/flexslider.css" type="text/css" media="all" property="" />

    <!-- banner -->
    <div class="banner" style="min-height:790px;">
        <div class="header agileinfo-header">
            <!-- header -->
           <%-- <nav class="navbar navbar-default">
                <div class="container">
                    <!-- Brand and toggle get grouped for better mobile display -->
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                        <h1><a href="index.html">Holiday<span> Spot</span></a></h1>
                    </div>
                    <!-- Collect the nav links, forms, and other content for toggling -->
                    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                        <ul class="nav navbar-nav navbar-left">
                            <li><a href="index.html" class="w3ls-hover active">Home</a></li>
                            <li><a href="about.html" class="btn w3ls-hover">About</a></li>
                            <li><a href="tours.html" class="btn w3ls-hover">Tours</a></li>
                            <li><a href="#" class="dropdown-toggle btn w3ls-hover" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Pages <span class="caret"></span></a>
                                <ul class="dropdown-menu">
                                    <li><a href="icons.html">Web Icons</a></li>
                                    <li><a href="codes.html">Short Codes</a></li>
                                </ul>
                            </li>
                            <li><a href="contact.html" class="btn w3ls-hover">Contact</a></li>
                        </ul>
                        <div class="social-icon">
                            <a href="#" class="social-button facebook"><i class="fa fa-facebook"></i></a>
                            <a href="#" class="social-button twitter"><i class="fa fa-twitter"></i></a>
                            <a href="#" class="social-button google"><i class="fa fa-google-plus"></i></a>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <!-- //navbar-collapse -->
                </div>
                <!-- //container-fluid -->
            </nav>--%>
        </div>
        <!-- //header -->
        <!-- banner-text -->
        <div class="banner-text">
            <div class="container">
                <div class="flexslider">

                    <div class="flex-viewport" style="overflow: hidden; position: relative;">
                        <ul class="slides" style="width: 1000%; transition-duration: 0s; transform: translate3d(-1140px, 0px, 0px);">
                            <li class="clone" style="width: 1140px; float: left; display: block;">
                                <div class="banner-w3lstext">
                                    <h3>Khám phá thiên nhiên kỳ thú </h3>
                                    <p>Chúng tôi cung cấp nhiều tour du lịch tới nhiều địa điểm nối tiếng trong nước và trên thế giới</p>
                                </div>
                            </li>
                            <li style="width: 1140px; float: left; display: block;" class="">
                                <div class="banner-w3lstext">
                                    <h3>Dịch vụ cham sóc chu đáo </h3>
                                    <p>Đáp ứng sự hài lòng của khách hàng là tiêu chí hàng đầu của chúng tôi</p>
                                </div>
                            </li>
                            <li class="clone" style="width: 1140px; float: left; display: block;">
                                <div class="banner-w3lstext">
                                    <h2>Chi phí hợp lí</h2>
                                    <p>Các gói tour du lịch với mức giá cực kì hợp lí, nhiều chương trình khuyến mại và ưu đãi đi kèm</p>
                                </div>
                            </li>
                        </ul>
                    </div>
                    <%--<ol class="flex-control-nav flex-control-paging">
                        <li><a class="flex-active">1</a></li>
                        <li><a class="">2</a></li>
                        <li><a class="">3</a></li>
                    </ol>--%>
                    <ul class="flex-direction-nav">
                        <li><a class="flex-prev" href="#">Previous</a></li>
                        <li><a class="flex-next" href="#">Next</a></li>
                    </ul>
                </div>
            </div>
        </div>
        <!-- //banner-text -->
    </div>
    <!-- //banner -->
    <!-- welcome -->
    <div class="welcome">
        <div class="container">
            <div class="welcome-grids">
                <div class="col-md-7 welcome-w3left">
                    <h4>Vịnh Hạ Long</h4>
                    <p>
                        Vịnh Hạ Long (vịnh nơi rồng đáp xuống) là một vịnh nhỏ thuộc phần bờ tây vịnh Bắc Bộ tại khu vực biển Đông Bắc Việt Nam, bao gồm vùng biển đảo thuộc thành phố Hạ Long, thành phố Cẩm Phả và một phần huyện đảo Vân Đồn của tỉnh Quảng Ninh.

Là trung tâm của một khu vực rộng lớn có những yếu tố ít nhiều tương đồng về địa chất, địa mạo, cảnh quan, khí hậu và văn hóa, với vịnh Bái Tử Long phía Đông Bắc và quần đảo Cát Bà phía Tây Nam, vịnh Hạ Long giới hạn trong diện tích khoảng 1.553 km² bao gồm 1.969 hòn đảo lớn nhỏ, phần lớn là đảo đá vôi, trong đó vùng lõi của Vịnh có diện tích 335 km² quần tụ dày đặc 775 hòn đảo.
                    </p>
                    <br>
                    <p>
                        Vịnh Hạ Long – được Unesco nhiều lần công nhận là di sản thiên nhiên của thế giới với hàng nghìn hòn đảo được làm nên bởi tạo hoá kỳ vĩ và sống động.
                    </p>
                </div>
                <div class="col-md-5 welcome-w3right">
                    <img src="Template/images/vinh-ha-long-543f7e5ca4394.jpg" class="img-responsive" alt="" />
                </div>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
    <!-- //welcome -->
    <!--- albums -->
    <div class="albums">
        <div class="w3lalbums-grid">
            <div class="col-md-6 col-sm-6 albums-left">
                <div class="wthree-almubimg">
                </div>
            </div>
            <div class="col-md-6 col-sm-6 albums-right">
                <h4>Vườn quốc gia Phong Nha - Kẻ Bàng</h4>
                <p>Vườn quốc gia Phong Nha-Kẻ Bàng là một vườn quốc gia tại huyện Bố Trạch, và Minh Hóa, tỉnh Quảng Bình, cách thành phố Đồng Hới khoảng 50 km về phía Tây Bắc, cách thủ đô Hà Nội khoảng 500 km về phía nam. </p>
            </div>
            <div class="clearfix"></div>
        </div>
        <div class="w3lalbums-grid">
            <div class="col-md-6 col-sm-6 albums1-right">
                <div class="wthree-almubimg wthree1-almubimg">
                </div>
            </div>
            <div class="col-md-6 col-sm-6 albums1-left">
                <h4>Đảo Cát Bà</h4>
                <p>Quần đảo Cát Bà (Hải Phòng) gồm 367 đảo nhỏ trong đó đảo Cát Bà (hay còn gọi là đảo Ngọc) là đảo du lịch nổi tiếng nhất. Tuy đã được biết đến từ lâu nhưng Cát Bà vẫn giữ được nhiều cảnh đẹp tự nhiên tuyệt đẹp nhờ sự biệt lập của nó. </p>
            </div>
            <div class="clearfix"></div>
        </div>
        <div class="clearfix"></div>
    </div>
    <!--- //albums -->
    <!-- services -->
    <div class="services">
        <div class="container">
            <h3 class="agileits-title">Dịch vụ của chúng tôi</h3>
            <div class="services-w3ls-row">
                <div class="col-xs-6 col-md-3 services-grids">
                    <div class="w3agile-servs-img">
                        <div class="icon-holder">
                            <span class="fa fa-gears icon" aria-hidden="true"></span>
                        </div>
                        <h4 class="mission">Quy trình</h4>
                        <p class="description">đơn giản, nhanh chóng </p>
                    </div>
                </div>
                <div class="col-xs-6 col-md-3 services-grids">
                    <div class="w3agile-servs-img">
                        <div class="icon-holder">
                            <span class="fa fa-group icon" aria-hidden="true"></span>
                        </div>
                        <h4 class="mission">Chăm sóc khác hàng </h4>
                        <p class="description">Tận tình, chu đáo</p>
                    </div>
                </div>
                <div class="col-xs-6 col-md-3 services-grids">
                    <div class="w3agile-servs-img">
                        <div class="icon-holder">
                            <span class="fa fa-briefcase icon" aria-hidden="true"></span>
                        </div>
                        <h4 class="mission">Dịch vụ</h4>
                        <p class="description">Tiện nghi</p>
                    </div>
                </div>
                <div class="col-xs-6 col-md-3 services-grids">
                    <div class="w3agile-servs-img">
                        <div class="icon-holder">
                            <span class="fa fa-list-alt icon" aria-hidden="true"></span>
                        </div>
                        <h4 class="mission">Giá cả</h4>
                        <p class="description">phù hợp, nhiều ưu đãi</p>
                    </div>
                </div>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
    <!-- //services -->
    <!-- slid -->
    <div class="slid">
        <div class="container">
            <h4>Ưu đãi đặc biệt</h4>
            <p>Chúng tôi luôn cung cấp nhiều ưu đại đặc biệt cho khách hàng có tài khoản thành viên trên website</p>
            <p>Đặc biệt giảm giá 5% cho tất cả các tour có trên hệ thống</p>
            <a href="Login.aspx" class="btn btn-success btn-lg" style="margin-top:20px;">Đăng kí ngay</a>
        </div>
    </div>
    <!-- //slid -->
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

    <!-- FlexSlider -->
    <script defer src="Template/js/jquery.flexslider.js"></script>
    <script type="text/javascript">
        $(window).load(function () {
            $('.flexslider').flexslider({
                animation: "slide",
                start: function (slider) {
                    $('body').removeClass('loading');
                }
            });
        });
    </script>
    <!-- End-slider-script -->

</asp:Content>
