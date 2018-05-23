<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login_login" %>
<%@ Import Namespace = "System.Data"%> 
<%@ Import Namespace = "System.Data.SqlClient"%>
<!DOCTYPE html>


   
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8">
        <title>Login</title>
        <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
        <meta name="description" content=""/>
        <meta name="author" content=""/>

        <!-- CSS -->
        <link rel='stylesheet' href='http://fonts.googleapis.com/css?family=PT+Sans:400,700'/>
        <link rel="stylesheet" href="assets/css/reset.css"/>
        <link rel="stylesheet" href="assets/css/supersized.css"/>
        <link rel="stylesheet" href="assets/css/style.css"/>

        <!-- HTML5 shim, for IE6-8 support of HTML5 elements -->
        <!--[if lt IE 9]>
            <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
        <![endif]-->
</head>
<body>
    <div class="page-container">
            <h1>Login</h1>
            <form id="form1" runat="server">
                                
                 <asp:textbox ID="user" name="user" CssClass="Username" runat="server"></asp:textbox>
                <asp:textbox ID="pwd" name="pwd" CssClass="Username" runat="server"></asp:textbox>

                <asp:Button Text="Sign me in" ID="Button1" OnClick="Button1_Click"    Runat="Server"/>
               
                   <script>
                var btn = document.getElementById("Button1");
                btn.onmouseover = function () {
                    this.style.background = "red";//鼠标移入变成红色
                }
                btn.onmouseout = function () {
                    this.style.background = "#FF8800";//鼠标移出变成橙色
                }
            </script>
                <asp:Button Text="Register" ID="Button2" OnClick="Button2_Click" Runat="Server"/>
                <script>
                var btn = document.getElementById("Button2");
                btn.onmouseover = function () {
                    this.style.background = "red";//鼠标移入变成红色
                }
                btn.onmouseout = function () {
                    this.style.background = "#FF8800";//鼠标移出变成橙色
                }
            </script>
                <div class="error"><span>+</span></div>
                
            </form>
            
        </div>
        
        <!-- Javascript -->
        <script src="assets/js/jquery-1.8.2.min.js"></script>
        <script src="assets/js/supersized.3.2.7.min.js"></script>
        <script src="assets/js/supersized-init.js"></script>
        <script src="assets/js/scripts.js"></script>
</body>
</html>
