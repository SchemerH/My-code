<%@ Page Language="C#" AutoEventWireup="true" CodeFile="talk.aspx.cs" Inherits="talk" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        body{
            background-image:url(back.jpg);
            background-repeat:no-repeat;
            background-size:cover;

        }
    </style>

    <meta id="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0">
    <meta id="description" content="Flatfy Free Flat and Responsive HTML5 Template ">
    <meta id="author" content="">

   

    <!-- Bootstrap core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet">
 
    <!-- Custom Google Web Font -->
    <link href="font-awesome/css/font-awesome.min.css" rel="stylesheet">
    <link href='http://fonts.googleapis.com/css?family=Lato:100,300,400,700,900,100italic,300italic,400italic,700italic,900italic' rel='stylesheet' type='text/css'>
	<link href='http://fonts.googleapis.com/css?family=Arvo:400,700' rel='stylesheet' type='text/css'>
	
    <!-- Custom CSS-->
    <link href="css/general.css" rel="stylesheet">
	
	 <!-- Owl-Carousel -->
    <link href="css/custom.css" rel="stylesheet">
	<link href="css/owl.carousel.css" rel="stylesheet">
    <link href="css/owl.theme.css" rel="stylesheet">
	<link href="css/style.css" rel="stylesheet">
	<link href="css/animate.css" rel="stylesheet">
	
	<!-- Magnific Popup core CSS file -->
	<link rel="stylesheet" href="css/magnific-popup.css"> 
	
	<script src="js/modernizr-2.6.2.min.js"></script>  <!-- Modernizr /-->
    <style type="text/css">
        .auto-style1 {
            left: 0px;
            top: 0px;
        }
        .liLeft img{
	margin: 10px;
}
.liRight span{
	display:block;
	font-size: 16px;
	height: 31px;
	line-height: 31px;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        
        <asp:TextBox ID="name" runat="server" class="form-control" style="background-color:transparent;color:white;"  Columns="99" Height="500px" TextMode="MultiLine"  ></asp:TextBox>
<asp:textbox ID="text" name="text" Columns="99" style="background-color:transparent;color:white;" class="form-control" runat="server"  Height="200px" TextMode="MultiLine"></asp:textbox>
                           
                       


     <!--    <asp:Button ID="dope2" runat="server" BorderStyle="Ridge" style="background-color:Window; width:100px;height:38px;position:relative;top:90px;left:-100px" Text="发送" />-->
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
       <asp:Button Text="发送" ID="Button2"  OnClick="Do" class="btn wow tada btn-embossed btn-primary pull-right" Runat="Server"/>
        

    </form>
    </body>
</html>
