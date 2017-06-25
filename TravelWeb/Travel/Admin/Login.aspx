<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Travel.Admin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>SB Admin 2 - Bootstrap Admin Theme</title>

    <!-- Bootstrap Core CSS -->
    <link href="sbAdmin/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

    <!-- MetisMenu CSS -->
    <link href="sbAdmin/vendor/metisMenu/metisMenu.min.css" rel="stylesheet">

    <!-- Custom CSS -->
    <link href="sbAdmin/dist/css/sb-admin-2.css" rel="stylesheet">

    <!-- Custom Fonts -->
    <link href="sbAdmin/vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
                <div class="row">
                    <div class="col-md-4 col-md-offset-4">
                        <div class="login-panel panel panel-default">
                            <div class="panel-heading">
                                <h3 class="panel-title">Please Sign In</h3>
                            </div>
                            <div class="panel-body">
                                <div role="form">
                                    <fieldset>
                                        <div class="form-group">
                                            <asp:TextBox runat="server" ID="username" CssClass="form-control" placeholder="Username" TabIndex="1" autofocus="autofocus"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <asp:TextBox runat="server" ID="password" CssClass="form-control" placeholder="Password" TabIndex="2"></asp:TextBox>
                                        </div>
                                        <div class="checkbox">
                                            <label>
                                                <input name="remember" tabindex="3" id="" type="checkbox" value="Remember Me">Remember Me
                                   
                                            </label>
                                        </div>
                                        <% if (alert != null)
                                        {%>
                                        <div class="form-group">
                                            <asp:Label runat="server" ID="lbMessage" CssClass="text-danger form-control"><%= alert.Content %></asp:Label>
                                        </div>
                                        <%} %>
                                        <!-- Change this to a button or input when using this as a form -->
                                        <asp:Button TabIndex="4" runat="server" CssClass="btn btn-lg btn-success btn-block" Text="Login" ID="btnLogin" OnClick="btnLogin_Click" />
                                    </fieldset>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!-- jQuery -->
            <script src="sbAdmin/vendor/jquery/jquery.min.js"></script>

            <!-- Bootstrap Core JavaScript -->
            <script src="sbAdmin/vendor/bootstrap/js/bootstrap.min.js"></script>

            <!-- Metis Menu Plugin JavaScript -->
            <script src="sbAdmin/vendor/metisMenu/metisMenu.min.js"></script>

            <!-- Custom Theme JavaScript -->
            <script src="sbAdmin/dist/js/sb-admin-2.js"></script>
        </div>
    </form>
</body>
</html>
