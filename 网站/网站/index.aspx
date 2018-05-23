<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta id="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0" />
    <meta id="description" content="Flatfy Free Flat and Responsive HTML5 Template " />
    <meta id="author" content="" />
    <title>IM信管人交流互助信息系统</title>

    <!-- Bootstrap core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet" />

    <!-- Custom Google Web Font -->
    <link href="font-awesome/css/font-awesome.min.css" rel="stylesheet" />
    <link href='http://fonts.googleapis.com/css?family=Lato:100,300,400,700,900,100italic,300italic,400italic,700italic,900italic' rel='stylesheet' type='text/css' />
    <link href='http://fonts.googleapis.com/css?family=Arvo:400,700' rel='stylesheet' type='text/css' />

    <!-- Custom CSS-->
    <link href="css/general.css" rel="stylesheet" />

    <!-- Owl-Carousel -->
    <link href="css/custom.css" rel="stylesheet" />
    <link href="css/owl.carousel.css" rel="stylesheet" />
    <link href="css/owl.theme.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />
    <link href="css/animate.css" rel="stylesheet" />

    <!-- Magnific Popup core CSS file -->
    <link rel="stylesheet" href="css/magnific-popup.css" />

    <script src="js/modernizr-2.6.2.min.js"></script>
    <!-- Modernizr /-->
    <style>
        .max{width:100%;height:auto;}
       
    </style>
    <script>
                      $(function(){
                          $('#imG').click(function(){
                              $(this).toggleClass('img-responsive');
                              $(this).toggleClass('max');
                          });
                      });
                  </script>
</head>
<body id="home">

    
    <!-- Preloader -->
    <div id="preloader">
        <div id="status"></div>
    </div>

    <!-- FullScreen -->
    <div class="intro-header">
        <div class="col-xs-12 text-center abcen1">
            <h1 class="h1_home wow fadeIn" data-wow-delay="0.4s"><span lang="EN-US">IM</span><span>信管人</span></h1>
            <h3 class="h3_home wow fadeIn" data-wow-delay="0.6s"><span>交流互助信息系统</span></h3>
            <ul class="list-inline intro-social-buttons">
                <li><a href="..\\login\login.aspx" class="btn  btn-lg mybutton_cyano wow fadeIn" data-wow-delay="0.8s"><span class="network-name">Login</span></a>
                </li>
                <li id="download"><a href="../register.aspx" class="btn  btn-lg mybutton_standard wow swing wow fadeIn" data-wow-delay="1.2s"><span class="network-name">Register</span></a>
                </li>
            </ul>
        </div>
        <!-- /.container -->
        <div class="col-xs-12 text-center abcen wow fadeIn">
            <div class="button_down ">
                <a class="imgcircle wow bounceInUp" data-wow-duration="1.5s" href="#whatis">
                    <img class="img_scroll" src="img/icon/circle.png" alt="">
                </a>
            </div>
        </div>
        <br />
    </div>




    <script type="text/javascript">
 var CloseWindow = false;
 function CloseEvent() {
     var s = "<%=CloseWindow()%>";
     //alert(s);
     CloseWindow = true;
 }
 function Closing(cls) {
     if(cls) {
         document.body.onbeforeunload = CloseEvent;
     } else {
         document.body.onbeforeunload = null;
     }
 }
 </script>




    <!-- NavBar-->
    <nav class="navbar-default" role="navigation">

        <div class="container">

            <div class="navbar-header">

                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-ex1-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>

                <a class="navbar-brand" href="#home">主界面</a>
                <img class="rotate rotate" src="img/man.png" alt="Generic placeholder image" width="63px" height="63">
                <asp:Label ID="loginlable" runat="server" Text="请登陆"></asp:Label>
            </div>

            <div class="collapse navbar-collapse navbar-right navbar-ex1-collapse">
                <ul class="nav navbar-nav">

                    <li class="menuItem"><a href="#whatis">What is?</a></li>
                    <li class="menuItem"><a href="#useit">Statistics</a></li>
                    <li class="menuItem"><a href="#screen">Screenshot</a></li>
                    <li class="menuItem"><a href="#credits">Credits</a></li>
                    <li class="menuItem"><a href="../register.aspx">Register</a></li>
                </ul>
            </div>

        </div>
    </nav>

    <!-- What is -->
    <form id="a" runat="server">
    <div id="whatis" class="content-section-b" style="border-top: 0">
        <div class="container">

            <div class="col-md-6 col-md-offset-3 text-center wrap_title">
                <h2>What is?</h2>
                <p class="lead" style="margin-top: 0">A forum for Junior.</p>

            </div>

            <div class="row">

                <div class="col-sm-4 wow fadeInDown text-center">
                <!--    <asp:ImageButton ID="ImageButton1" OnClick="buttonb" CssClass="rotate" ImageUrl="img/icon/tweet.svg" runat="server"  />-->
                    <asp:ImageButton ID="Button1" OnClick="buttonb" CssClass="rotate" ImageUrl="img/icon/tweet.svg" runat="server"  />

                       <h3>Chat</h3>
                    <p class="lead">Epsum factorial non deposit quid pro quo hic escorol. Olypian quarrels et gorilla congolium sic ad nauseum. </p>

                    <!-- <p><a class="btn btn-embossed btn-primary view" role="button">View Details</a></p> -->
                </div>
                <!-- /.col-lg-4 -->

                <div class="col-sm-4 wow fadeInDown text-center">
                    

                 <!--   <img class="rotate" src="img/icon/picture.svg" alt="Generic placeholder image">-->
                    <asp:ImageButton ID="button" OnClick="buttona" CssClass="rotate" ImageUrl="img/icon/picture.svg" runat="server"  />



                    <h3>Sharing learning experience</h3>
                    <p class="lead">Epsum factorial non deposit quid pro quo hic escorol. Olypian quarrels et gorilla congolium sic ad nauseum. </p>
                    <!-- <p><a class="btn btn-embossed btn-primary view" role="button">View Details</a></p> -->
                </div>
                <!-- /.col-lg-4 -->

                <div class="col-sm-4 wow fadeInDown text-center">
                    <img class="rotate" src="img/icon/retina.svg" alt="Generic placeholder image">
                    <h3>Recommendations for related courses</h3>
                    <p class="lead">Epsum factorial non deposit quid pro quo hic escorol. Olypian quarrels et gorilla congolium sic ad nauseum. </p>
                    <!-- <p><a class="btn btn-embossed btn-primary view" role="button">View Details</a></p> -->
                </div>
                <!-- /.col-lg-4 -->

            </div>
            


            <!-- /.row -->

            <div class="row tworow">

                <div class="col-sm-4  wow fadeInDown text-center">
                <!--     <asp:ImageButton ID="Button2" OnClick="buttonc" CssClass="rotate" ImageUrl="img/icon/laptop.svg" runat="server"  />-->
                    <a href="Go://调用">
                        <asp:ImageButton ID="ImageButton2" OnClick="buttond" CssClass="rotate" ImageUrl="img/icon/laptop.svg" runat="server"  />

        <!--            <img class="rotate" src="img/icon/laptop.svg"  alt="Generic placeholder image"></a>-->
                    <h3>Second-hand trading platform</h3>
                    <p class="lead">Epsum factorial non deposit quid pro quo hic escorol. Olypian quarrels et gorilla congolium sic ad nauseum. </p>
                    <!-- <p><a class="btn btn-embossed btn-primary view" role="button">View Details</a></p> -->
                </div>
                <!-- /.col-lg-4 -->

                <div class="col-sm-4 wow fadeInDown text-center">
                    <a href="JobInfo.aspx">
                    <img class="rotate" src="img/icon/map.svg" alt="Generic placeholder image"></a>
                    <h3>Job recruitment</h3>
                    <p class="lead">Epsum factorial non deposit quid pro quo hic escorol. Olypian quarrels et gorilla congolium sic ad nauseum. </p>
                    <!-- <p><a class="btn btn-embossed btn-primary view" role="button">View Details</a></p> -->
                </div>
                <!-- /.col-lg-4 -->

                <div class="col-sm-4 wow fadeInDown text-center">
                    <img class="rotate" src="img/icon/browser.svg" alt="Generic placeholder image">
                    <h3>Contact us</h3>
                    <p class="lead">Epsum factorial non deposit quid pro quo hic escorol. Olypian quarrels et gorilla congolium sic ad nauseum. </p>
                    <!-- <p><a class="btn btn-embossed btn-primary view" role="button">View Details</a></p> -->
                </div>
                <!-- /.col-lg-4 -->

            </div>
            <!-- /.row -->
        </div>
    </div>
</form>

    <!-- Use it -->
    <div id="useit" class="content-section-a">

        <div class="container">

            <div class="row">

                <div class="col-sm-6 pull-right wow fadeInRightBig">
                    <img class="img-responsive " id="imG"  onclick="this.width+=50;this.height+=50" src="img/a.png" alt="">
                  
                </div>

                <div class="col-sm-6 wow fadeInLeftBig" data-animation-delay="200">
                    <h3 class="section-heading">Graduation statistics of graduates</h3>
                    <div class="sub-title lead3">
                        Lorem ipsum dolor sit atmet sit dolor greand fdanrh<br>
                        sdfs sit atmet sit dolor greand fdanrh sdfs
                    </div>
                    <p class="lead">
                        In his igitur partibus duabus nihil erat, quod Zeno commuta rest gestiret. 
						Sed virtutem ipsam inchoavit, nihil ampliusuma. Scien tiam pollicentur, 
						uam non erat mirum sapientiae lorem cupido
						patria esse cariorem. Quae qui non vident, nihilamane umquam magnum ac cognitione.
                    </p>

                    <p>
                        <a class="btn btn-embossed btn-primary" href="#" role="button">View Details</a>
                        <a class="btn btn-embossed btn-info" href="#" role="button">Visit Website</a>
                    </p>
                </div>
            </div>
        </div>
        <!-- /.container -->
    </div>

    <div class="content-section-b">

        <div class="container">
            <div class="row">
                <div class="col-sm-6 wow fadeInLeftBig">
                    <div id="owl-demo-1" class="owl-carousel">
                        <a href="img/iphone.png" class="image-link">
                            <div class="item">
                                <img class="img-responsive img-rounded" src="img/iphone.png" alt="">
                            </div>
                        </a>
                        <a href="img/iphone.png" class="image-link">
                            <div class="item">
                                <img class="img-responsive img-rounded" src="img/iphone.png" alt="">
                            </div>
                        </a>
                        <a href="img/iphone.png" class="image-link">
                            <div class="item">
                                <img class="img-responsive img-rounded" src="img/iphone.png" alt="">
                            </div>
                        </a>
                    </div>
                </div>

                <div class="col-sm-6 wow fadeInRightBig" data-animation-delay="200">
                    <h3 class="section-heading">Drag Gallery</h3>
                    <div class="sub-title lead3">
                        Lorem ipsum dolor sit atmet sit dolor greand fdanrh<br>
                        sdfs sit atmet sit dolor greand fdanrh sdfs
                    </div>
                    <p class="lead">
                        In his igitur partibus duabus nihil erat, quod Zeno commuta rest gestiret. 
						Sed virtutem ipsam inchoavit, nihil ampliusuma. Scien tiam pollicentur, 
						uam non erat mirum sapientiae lorem cupido
						patria esse cariorem. Quae qui non vident, nihilamane umquam magnum ac cognitione.
                    </p>

                    <p>
                        <a class="btn btn-embossed btn-primary" href="#" role="button">View Details</a>
                        <a class="btn btn-embossed btn-info" href="#" role="button">Visit Website</a>
                    </p>
                </div>
            </div>
        </div>
    </div>

    <div class="content-section-a">

        <div class="container">

            <div class="row">

                <div class="col-sm-6 pull-right wow fadeInRightBig">
                    <img class="img-responsive " src="img/doge.png" alt="">
                </div>

                <div class="col-sm-6 wow fadeInLeftBig" data-animation-delay="200">
                    <h3 class="section-heading">Font Awesome & Glyphicon</h3>
                    <p class="lead">
                        A special thanks to Death to the Stock Photo for 
					providing the photographs that you see in this template. 
                    </p>

                    <ul class="descp lead2">
                        <li><i class="glyphicon glyphicon-signal"></i>Reliable and Secure Platform</li>
                        <li><i class="glyphicon glyphicon-refresh"></i>Everything is perfectly orgainized for future</li>
                        <li><i class="glyphicon glyphicon-headphones"></i>Attach large file easily</li>
                    </ul>
                </div>
            </div>
        </div>

    </div>

    <!-- Screenshot -->
    <div id="screen" class="content-section-b">
        <div class="container">
            <div class="row">
                <div class="col-md-6 col-md-offset-3 text-center wrap_title ">
                    <h2>Screen App</h2>
                    <p class="lead" style="margin-top: 0">A special thanks to Death.</p>
                </div>
            </div>
            <div class="row wow bounceInUp">
                <div id="owl-demo" class="owl-carousel">

                    <a href="img/slide/1.png" class="image-link">
                        <div class="item">
                            <img class="img-responsive img-rounded" src="img/slide/1.png" alt="Owl Image">
                        </div>
                    </a>

                    <a href="img/slide/2.png" class="image-link">
                        <div class="item">
                            <img class="img-responsive img-rounded" src="img/slide/2.png" alt="Owl Image">
                        </div>
                    </a>

                    <a href="img/slide/3.png" class="image-link">
                        <div class="item">
                            <img class="img-responsive img-rounded" src="img/slide/3.png" alt="Owl Image">
                        </div>
                    </a>

                    <a href="img/slide/1.png" class="image-link">
                        <div class="item">
                            <img class="img-responsive img-rounded" src="img/slide/1.png" alt="Owl Image">
                        </div>
                    </a>

                    <a href="img/slide/2.png" class="image-link">
                        <div class="item">
                            <img class="img-responsive img-rounded" src="img/slide/2.png" alt="Owl Image">
                        </div>
                    </a>

                    <a href="img/slide/3.png" class="image-link">
                        <div class="item">
                            <img class="img-responsive img-rounded" src="img/slide/3.png" alt="Owl Image">
                        </div>
                    </a>
                </div>
            </div>
        </div>


    </div>

    <div class="content-section-c ">
        <div class="container">
            <div class="row">
                <div class="col-md-6 col-md-offset-3 text-center wrap_title white">
                    <h2>Get Live Updates</h2>
                    <p class="lead" style="margin-top: 0">A special thanks to Death.</p>
                </div>
                <div class="mockup-content">
                    <div class="morph-button wow pulse morph-button-inflow morph-button-inflow-1">
                        <button type="button "><span>Subscribe to our Newsletter</span></button>
                        <div class="morph-content">
                            <div>
                                <div class="content-style-form content-style-form-4 ">
                                    <h2 class="morph-clone">Subscribe to our Newsletter</h2>

                                    <p>
                                        <label>Your Email Address</label><input type="text" />
                                    </p>
                                    <p>
                                        <button>Subscribe me</button>
                                    </p>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Credits -->
    <div id="credits" class="content-section-a">
        <div class="container">
            <div class="row">

                <div class="col-md-6 col-md-offset-3 text-center wrap_title">
                    <h2>Credits</h2>
                    <p class="lead" style="margin-top: 0">A special thanks to Death.</p>
                </div>

                <div class="col-sm-6  block wow bounceIn">
                    <div class="row">
                        <div class="col-md-4 box-icon rotate">
                            <i class="fa fa-desktop fa-4x "></i>
                        </div>
                        <div class="col-md-8 box-ct">
                            <h3>Bootstrap </h3>
                            <p>Lorem ipsum dolor sit ametconsectetur adipiscing elit. Suspendisse orci quam. </p>
                        </div>
                    </div>
                </div>
                <div class="col-sm-6 block wow bounceIn">
                    <div class="row">
                        <div class="col-md-4 box-icon rotate">
                            <i class="fa fa-picture-o fa-4x "></i>
                        </div>
                        <div class="col-md-8 box-ct">
                            <h3>Owl-Carousel </h3>
                            <p>Nullam mo  arcu ac molestie scelerisqu vulputate, molestie ligula gravida, tempus ipsum.</p>
                        </div>
                    </div>
                </div>
            </div>

            <div class="row tworow">
                <div class="col-sm-6  block wow bounceIn">
                    <div class="row">
                        <div class="col-md-4 box-icon rotate">
                            <i class="fa fa-magic fa-4x "></i>
                        </div>
                        <div class="col-md-8 box-ct">
                            <h3>Codrops </h3>
                            <p>Lorem ipsum dolor sit ametconsectetur adipiscing elit. Suspendisse orci quam. </p>
                        </div>
                    </div>
                </div>
                <div class="col-sm-6 block wow bounceIn">
                    <div class="row">
                        <div class="col-md-4 box-icon rotate">
                            <i class="fa fa-heart fa-4x "></i>
                        </div>
                        <div class="col-md-8 box-ct">
                            <h3>Lorem Ipsum</h3>
                            <p>Nullam mo  arcu ac molestie scelerisqu vulputate, molestie ligula gravida, tempus ipsum.</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Banner Download -->

    <!-- Contact -->








    <!-- JavaScript -->
    <script src="js/jquery-1.10.2.js"></script>
    <script src="js/bootstrap.js"></script>
    <script src="js/owl.carousel.js"></script>
    <script src="js/script.js"></script>
    <!-- StikyMenu -->
    <script src="js/stickUp.min.js"></script>
    <script type="text/javascript">
        jQuery(function ($) {
            $(document).ready(function () {
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

</body>
</html>
