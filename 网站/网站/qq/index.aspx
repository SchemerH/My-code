<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="qq_index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="UTF-8"/>
<title></title>

<link rel="stylesheet" type="text/css" href="css/qq.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div class="qqBox">
	<div class="BoxHead">
		<div class="headImg">
			<img src="img/6.jpg"/>
		</div>
	<!--	<div class="internetName">90后大叔</div>-->
        <asp:Label ID="name" class="internetName" Text="请登陆" runat="server"></asp:Label>
	</div>
	<div class="context">
		<div class="conLeft">

<ul id="J_List">
           </ul> 


			<ul>
				<li>
					<div class="liLeft"><img src="img/20170926103645_04.jpg"/></div>
					<div class="liRight">
						<span class="intername">前端交流群</span>
						<span class="infor">厉害了</span>
					</div>
				</li>
				
				
				
			</ul>
		</div>
		<div class="conRight">
			<div class="Righthead">
				<div class="headName">赵鹏</div>
				<div class="headConfig">
					<ul>
						<li><img src="img/20170926103645_06.jpg"/></li>
						<li><img src="img/20170926103645_08.jpg"/></li>
						<li><img src="img/20170926103645_10.jpg"/></li>
						<li><img src="img/20170926103645_12.jpg"/></li>
					</ul>
				</div>
			</div>
			<div class="RightCont">
				<ul class="newsList">

				<asp:TextBox ID="dope2"  style="width: 99%;height: 75px; border: none;outline: none;" name="" runat="server"></asp:TextBox>


				</ul>
			</div>
			<div class="RightFoot">
				<div class="emjon">
					<ul>
						<li><img src="img/em_02.jpg"/></li>
						<li><img src="img/em_05.jpg"/></li>
						<li><img src="img/em_07.jpg"/></li>
						<li><img src="img/em_12.jpg"/></li>
						<li><img src="img/em_14.jpg"/></li>
						<li><img src="img/em_16.jpg"/></li>
						<li><img src="img/em_20.jpg"/></li>
						<li><img src="img/em_23.jpg"/></li>
						<li><img src="img/em_25.jpg"/></li>
						<li><img src="img/em_30.jpg"/></li>
						<li><img src="img/em_31.jpg"/></li>
						<li><img src="img/em_33.jpg"/></li>
						<li><img src="img/em_37.jpg"/></li>
						<li><img src="img/em_38.jpg"/></li>
						<li><img src="img/em_40.jpg"/></li>
						<li><img src="img/em_45.jpg"/></li>
						<li><img src="img/em_47.jpg"/></li>
						<li><img src="img/em_48.jpg"/></li>
						<li><img src="img/em_52.jpg"/></li>
						<li><img src="img/em_54.jpg"/></li>
						<li><img src="img/em_55.jpg"/></li>
					</ul>
				</div>
				<div class="footTop">
					<ul>
						<li><img src="img/20170926103645_31.jpg"/></li>
						<li class="ExP"><img src="img/20170926103645_33.jpg"/></li>
						<li><img src="img/20170926103645_35.jpg"/></li>
						<li><img src="img/20170926103645_37.jpg"/></li>
						<li><img src="img/20170926103645_39.jpg"/></li>
						<li><img src="img/20170926103645_41.jpg" alt="" /></li>
						<li><img src="img/20170926103645_43.jpg"/></li>
						<li><img src="img/20170926103645_45.jpg"/></li>
					</ul>
				</div>
				<div class="inputBox">
                    <textarea id="dope" style="width: 99%;height: 75px; border: none;outline: none;" name="" rows="" cols=""></textarea>-->
					<button class="sendBtn">发送(s)</button> -->
                    </div>
			</div>
		</div>
	</div>
</div>

<script type="text/javascript" src="js/jquery.min.js"></script>
<script type="text/javascript" src="js/chat.js"></script>
    </form>
</body>
</html>
