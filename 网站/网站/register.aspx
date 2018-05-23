<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta  http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta id="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0">
    <meta id="description" content="Flatfy Free Flat and Responsive HTML5 Template ">
    <meta id="author" content="">

    <title>Flatfy – Free Flat and Responsive HTML5 Template</title>

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
    </style>
</head>
<body>
    <form id="form1" runat="server">
    

	
	
	<!-- Contact -->
	<div id="contact" class="content-section-a">
        <div class="container">
            <div class="row">

                <div class="col-md-6 col-md-offset-3 text-center wrap_title">
                    <h2>Register</h2>
                    <p class="lead" style="margin-top: 0">A special thanks to Death.</p>
                </div>

               
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="name">Your Name</label>
                            <div class="input-group">
                                <asp:textbox ID="name" name="name" class="form-control" runat="server" placeholder="Enter Name" required></asp:textbox>
                             <!--   <input type="text" class="form-control" name="InputName" id="InputName" placeholder="Enter Name" required>  -->
                                <span class="input-group-addon"><i class="glyphicon glyphicon-ok form-control-feedback"></i></span>
                            </div>
                        </div>

                        <div class="form-group">
                            <label for="password">Your Password</label>
                            <div class="input-group">
                                <asp:textbox ID="password" name="password" class="form-control" runat="server" required></asp:textbox>
                           
                                
                                <span class="input-group-addon"><i class="glyphicon glyphicon-ok form-control-feedback"></i></span>
                            </div>
                        </div>


                        <div class="form-group">
                            <label for="password">Confirm Your Password</label>
                            <div class="input-group">
                                <asp:textbox ID="password1" name="password1" class="form-control" runat="server" required></asp:textbox>
                           
                                
                                <span class="input-group-addon"><i class="glyphicon glyphicon-ok form-control-feedback"></i></span>
                            </div>
                        </div>

                        

                   
                        <asp:Button Text="Register" ID="Button2" OnClick="Button1_Click" class="btn wow tada btn-embossed btn-primary pull-right" Runat="Server"/>
                        
                      <!--  <input type="submit" name="submit" id="button" value="Submit"  onclick="Button1_Click" class="btn wow tada btn-embossed btn-primary pull-right"> -->
                    </div>
			</form>
			
		

    <!-- JavaScript -->
    <script src="js/jquery-1.10.2.js"></script>
    <script src="js/bootstrap.js"></script>
	<script src="js/owl.carousel.js"></script>
	<script src="js/script.js"></script>
	<!-- StikyMenu -->
	<script src="js/stickUp.min.js"></script>
	<script type="text/javascript">
	  jQuery(function($) {
		$(document).ready( function() {
		  $('.navbar-default').stickUp();
		  
		});
	  });
	
	</script>
	<!-- Smoothscroll -->
	<script type="text/javascript" src="js/jquery.corner.js"></script> 
	<script src="js/wow.min.js"></script>
	<script>
	 new WOW().init();
	</script>
	<script src="js/classie.js"></script>
	<script src="js/uiMorphingButton_inflow.js"></script>
	<!-- Magnific Popup core JS file -->
	<script src="js/jquery.magnific-popup.js"></script> 

    </form>
</body>
</html>
