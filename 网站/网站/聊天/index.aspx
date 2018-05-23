<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="聊天_index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="UTF-8" />
  <title>仿ad QQ带列表的聊天器，支持PC和Android</title>
  <style type="text/css">
    *{font-family:"开心软件萝莉简体",sans-serif}
	input{border:1px solid #ff0000}
	input[type=button]{border:1px solid #ff0000;background-color:#ffffff}
  </style>
</head>
<body>
    <form id="form1" runat="server">
   <script type="text/javascript" src="main.talk"></script>
 <script type="text/javascript">
  function _$(i){return document.getElementById(i)}
  function event_down(id,i){
   if(_$(id).addEventListener){
    _$(id).addEventListener("mousedown",function(event){var event=event||window.event;if(event.button!=2){if(i)i()}})
    _$(id).addEventListener("touchstart",i)
   }else{
    _$(id).attachEvent("onmousedown",i)
   }
  }
  function event_up(id,i){
   _$(id).addEventListener("mouseup",function(event){var event=event||window.event;if(event.button!=2){if(i)i()}})
   _$(id).addEventListener("touchend",i)
  }
  function tk(i,j,k){
   var b=document.createElement("div")
   b.innerHTML="<span style='padding:25px;background-color:"+(k||"#cccccc")+";border-radius:15px'>"+((k||"")==""?_$(j).value:j)+"</span>"
   b.style.textAlign=((k||"")==""?"right":"left")
   b.style.height="80px"
   _$(i).appendChild(b)
  }
  function longmenu(i,j,k){
   var i=_$(i),a
   i.addEventListener("touchstart",function(event){var event=event||window.event;
    a=setTimeout(function(){_$(j).style.display="";_$(k).style.display="";
	},250)
	event.preventDefault();
   })
   i.addEventListener("touchend",function(){
	clearTimeout(a)
   })
   _$(j).addEventListener("touchstart",function(){_$(j).style.display="none";_$(k).style.display="none";})
   _$(j).addEventListener("touchmove",function(){_$(j).style.display="none";_$(k).style.display="none";})
   _$(k).addEventListener("touchend",function(){_$(j).style.display="none";_$(k).style.display="none";})

  }
  function rightmenu(i,j,k){
   var i=_$(i),a
   i.addEventListener("mouseup",function(event){
    var event=event||window.event;
    if(event.button==2){
    _$(j).style.display="";
	_$(k).style.display="";
	_$(k).style.left=event.clientX+"px";
	_$(k).style.top=event.clientY+"px";
    }
   })
   i.addEventListener("contextmenu",function(event){var event=event||window.event;event.preventDefault();})
   _$(j).addEventListener("contextmenu",function(event){var event=event||window.event;event.preventDefault();})
   _$(k).addEventListener("contextmenu",function(event){var event=event||window.event;event.preventDefault();})
   _$(j).addEventListener("mousedown",function(){_$(j).style.display="none";_$(k).style.display="none";})
   _$(k).addEventListener("mouseup",function(){_$(j).style.display="none";_$(k).style.display="none";})

  }

  function scrolls(){
   document.body.scrollTop=1e10
   document.documentElement.scrollTop=1e10
  }

 </script>
  <div style="position:fixed;left:0;top:0px;overflow:hidden;width:100%;height:100%;z-index:2;background-color:#ffffff" id="sndd">
       <div style="width:100%;text-align:center;position:absolute;left:0;top:0px;background-color:#ff0000;padding:10px 0px;font-size:25px;" id="abd">聊天会话</div>
        <asp:Label Text="请登陆！" style="width:100%;text-align:left;position:absolute;left:0;top:0px;background-color:#ff0000;padding:10px 0px;font-size:25px;" ID="name" runat="server"></asp:Label>
 
   <div id="abd2"></div>
   <div style="width:100%;background-color:#dec2c8;padding:10px 5px;font-size:20px;cursor:pointer;" id="sib1">开心小明<div style="font-size:10px;" id="sie1">你好，我是开心小明</div></div>
   <div style="width:100%;background-color:#dec2c8;padding:10px 5px;font-size:20px;cursor:pointer;" id="sib2">开心小花<div style="font-size:10px;" id="sie2">你好，我是开心小花</div></div>
   <div style="width:100%;background-color:#dec2c8;padding:10px 5px;font-size:20px;cursor:pointer;" id="sib3">开心小乐<div style="font-size:10px;" id="sie3">你好，我是开心小乐</div></div>
   <div style="width:100%;background-color:#dec2c8;padding:10px 5px;font-size:20px;cursor:pointer;" id="sib4">开心小晴<div style="font-size:10px;" id="sie4">你好，我是开心小晴</div></div>
   <div style="width:100%;background-color:#dec2c8;padding:10px 5px;font-size:20px;cursor:pointer;" id="sib5">开心小蛋<div style="font-size:10px;" id="sie5">你好，我是开心小蛋</div></div>
  </div>

  <div  style="position:absolute;left:0;top:0px;overflow:hidden;width:100%;display:none;" id="talk1">
   <div style="width:100%;text-align:center;position:fixed;left:0;top:0px;background-color:#ff0000;padding:10px 0px;font-size:25px;"><div style="position:absolute;left:0;top:5px;cursor:pointer" id="b1">&lt;</div>开心小明</div>
   <div style="height:80px"></div>
   <span id="tk1"></span>
   <div style="height:50px"></div>
   <div style="position:fixed;left:0;bottom:0px;width:100%;"><input type="text" style="width:95%;height:35px;" id="tlk1"><input type="button" value="发送" style="width:100px;height:38px;position:absolute;right:0;top:0px;" onclick="tk('tk1','tlk1');scrolls();_$('sie1').innerHTML=_$('tlk1').value;_$('tlk1').value=''"></div>
  </div>

  <div style="position:absolute;left:0;top:0px;overflow:hidden;width:100%;display:none;" id="talk2">
   <div style="width:100%;text-align:center;position:fixed;left:0;top:0px;background-color:#ff0000;padding:10px 0px;font-size:25px;"><div style="position:absolute;left:0;top:5px;cursor:pointer" id="b2">&lt;</div>开心小花</div>
   <div style="height:80px"></div>
   <span id="tk2"></span>
   <div style="height:50px"></div>
   <div style="position:fixed;left:0;bottom:0px;width:100%;"><input type="text" style="width:95%;height:35px;" id="tlk2"><input type="button" value="发送" style="width:100px;height:38px;position:absolute;right:0;top:0px;" onclick="tk('tk2','tlk2');scrolls();_$('sie2').innerHTML=_$('tlk2').value;_$('tlk2').value=''"></div>
  </div>

  <div style="position:absolute;left:0;top:0px;overflow:hidden;width:100%;display:none;" id="talk3">
   <div style="width:100%;text-align:center;position:fixed;left:0;top:0px;background-color:#ff0000;padding:10px 0px;font-size:25px;"><div style="position:absolute;left:0;top:5px;cursor:pointer" id="b3">&lt;</div>开心小乐</div>
   <div style="height:80px"></div>
   <span id="tk3"></span>
   <div style="height:50px"></div>
   <div style="position:fixed;left:0;bottom:0px;width:100%;"><input type="text" style="width:95%;height:35px;" id="tlk3"><input type="button" value="发送" style="width:100px;height:38px;position:absolute;right:0;top:0px;" onclick="tk('tk3','tlk3');scrolls();_$('sie3').innerHTML=_$('tlk3').value;_$('tlk3').value=''"></div>
  </div>

  <div style="position:absolute;left:0;top:0px;overflow:hidden;width:100%;display:none;" id="talk4">
   <div style="width:100%;text-align:center;position:fixed;left:0;top:0px;background-color:#ff0000;padding:10px 0px;font-size:25px;"><div style="position:absolute;left:0;top:5px;cursor:pointer" id="b4">&lt;</div>开心小晴</div>
   <div style="height:80px"></div>
   <span id="tk4"></span>
   <div style="height:50px"></div>
   <div style="position:fixed;left:0;bottom:0px;width:100%;"><input type="text" style="width:95%;height:35px;" id="tlk4"><input type="button" value="发送" style="width:100px;height:38px;position:absolute;right:0;top:0px;" onclick="tk('tk4','tlk4');scrolls();_$('sie4').innerHTML=_$('tlk4').value;_$('tlk4').value=''"></div>
  </div>

  <div style="position:absolute;left:0;top:0px;overflow:hidden;width:100%;display:none;" id="talk5">
   <div style="width:100%;text-align:center;position:fixed;left:0;top:0px;background-color:#ff0000;padding:10px 0px;font-size:25px;">
     <div style="position:absolute;left:0;top:5px;cursor:pointer" id="b5">&lt;</div>
     开心小蛋</div>
   <div style="height:80px"></div>
   <span id="tk5"></span>
   <div style="height:50px"></div>
   <div style="position:fixed;left:0;bottom:0px;width:100%;">
     <input type="text" style="width:95%;height:35px;" id="tlk5">
       
       
     <input type="button" value="发送" style="width:100px;height:38px;position:absolute;right:0;top:0px;" onclick="tk('tk5','tlk5');scrolls();_$('sie5').innerHTML=_$('tlk5').value;_$('tlk5').value=''"></div>
  </div>

        <div style="position:absolute;left:0;top:0px;overflow:hidden;width:100%;display:none;" id="talk5">
   <div style="width:100%;text-align:center;position:fixed;left:0;top:0px;background-color:#ff0000;padding:10px 0px;font-size:25px;">
     <div style="position:absolute;left:0;top:5px;cursor:pointer" id="b5">&lt;</div>
     开心小蛋</div>
   <div style="height:80px"></div>
   <span id="tk5"></span>
   <div style="height:50px"></div>
   <div style="position:fixed;left:0;bottom:0px;width:100%;">
     <input type="text" style="width:95%;height:35px;" id="tlk5">
       
       
     <input type="button" value="发送" style="width:100px;height:38px;position:absolute;right:0;top:0px;" onclick="tk('tk5','tlk5');scrolls();_$('sie5').innerHTML=_$('tlk5').value;_$('tlk5').value=''"></div>
  </div>



  <div style="position:absolute;left:0;top:0px;overflow:hidden;width:100%;display:none;" id="talk6">
   <div style="width:100%;text-align:center;position:fixed;left:0;top:0px;background-color:#ff0000;padding:10px 0px;font-size:25px;">
     <div style="position:absolute;left:0;top:5px;cursor:pointer" id="b6">&lt;</div>
     hyy</div>
   <div style="height:80px"></div>
   <span id="tk6"></span>
   <div style="height:50px"></div>
   <div style="position:fixed;left:0;bottom:0px;width:100%;">
     
       <asp:TextBox runat="server" style="width:95%;height:35px;" ID="text"></asp:TextBox>
       <asp:Button Text="发送" style="width:100px;height:38px;position:absolute;right:0;top:0px;"  runat="server" />
     <input type="button" value="发送" style="width:100px;height:38px;position:absolute;right:0;top:0px;" onclick="tk('tk6','tlk6');scrolls();_$('sie5').innerHTML=_$('tlk5').value;_$('tlk5').value=''"></div>
  </div>
        
        













  <div style="position:absolute;left:0;top:0px;background-color:#000;opacity:.5;width:100%;height:100%;display:none;z-index:5" id="menuandroid1"></div>
  <div style="position:absolute;left:10%;top:30%;background-color:#fff;width:80%;display:none;z-index:6;border:1px solid #ff0000;" id="menuandroid2">
   <div style="padding:10px" ontouchend="qknr()">清除所有聊天内容</div>
   <div style="padding:10px">关于sd版QQ软件</div>
  </div>

  <div style="position:absolute;left:0;top:0px;width:100%;height:100%;display:none;z-index:5" id="menupc1"></div>
  <div style="position:absolute;left:10;top:30;background-color:#fff;width:200px;display:none;z-index:6;border:1px solid #ff0000;" id="menupc2">
   <div style="padding:3px 3px 3px 10px;cursor:pointer" onmouseover="style.backgroundColor='#dec2c8'" onmouseout="style.backgroundColor=''" onmouseup="qknr()">清除所有聊天内容</div>
   <div style="padding:3px 3px 3px 10px;cursor:pointer" onmouseover="style.backgroundColor='#dec2c8'" onmouseout="style.backgroundColor=''">关于sd版QQ软件</div>
  </div>
<script type="text/javascript">
longmenu("sndd","menuandroid1","menuandroid2")
rightmenu("sndd","menupc1","menupc2")

</script>
  <script type="text/javascript">
   _$("abd2").style.marginTop=_$("abd").offsetHeight+"px"
   event_up("sib1",function(){ _$("sndd").style.display="none";_$("talk1").style.display="";scrolls()})
   event_up("sib2",function(){ _$("sndd").style.display="none";_$("talk2").style.display="";scrolls()})
   event_up("sib3",function(){ _$("sndd").style.display="none";_$("talk3").style.display="";scrolls()})
   event_up("sib4",function(){ _$("sndd").style.display="none";_$("talk4").style.display="";scrolls()})
   event_up("sib5",function(){ _$("sndd").style.display="none";_$("talk5").style.display="";scrolls()})
   event_up("b1",function(){ _$("sndd").style.display="";_$("talk1").style.display="none";scrolls()})
   event_up("b2",function(){ _$("sndd").style.display="";_$("talk2").style.display="none";scrolls()})
   event_up("b3",function(){ _$("sndd").style.display="";_$("talk3").style.display="none";scrolls()})
   event_up("b4",function(){ _$("sndd").style.display="";_$("talk4").style.display="none";scrolls()})
   event_up("b5",function(){ _$("sndd").style.display="";_$("talk5").style.display="none";scrolls()})
   function sto(s,g){
	function b(){if(s){s()};setTimeout(b,Math.floor(Math.random()*g))}
    setTimeout(b,Math.floor(Math.random()*g))
   }
   sto(function(){var gy=huihuatiaos[Math.floor(Math.random()*huihuatiaos.length)];tk("tk1",gy,"red");_$("sie1").innerHTML=gy;scrolls()},100000)
   sto(function(){var gy=huihuatiaos[Math.floor(Math.random()*huihuatiaos.length)];tk("tk2",gy,"red");_$("sie2").innerHTML=gy;scrolls()},80000)
   sto(function(){var gy=huihuatiaos[Math.floor(Math.random()*huihuatiaos.length)];tk("tk3",gy,"red");_$("sie3").innerHTML=gy;scrolls()},60000)
   sto(function(){var gy=huihuatiaos[Math.floor(Math.random()*huihuatiaos.length)];tk("tk4",gy,"red");_$("sie4").innerHTML=gy;scrolls()},90000)
   sto(function(){var gy=huihuatiaos[Math.floor(Math.random()*huihuatiaos.length)];tk("tk5",gy,"red");_$("sie5").innerHTML=gy;scrolls()},110000)
   tk("tk1","你好，我是开心小明","blue");tk("tk2","你好，我是开心小花","blue");tk("tk3","你好，我是开心小乐","blue");tk("tk4","你好，我是开心小晴","blue");tk("tk5","你好，我是开心小蛋","blue");
   function qknr(){_$("tk1").innerHTML="";_$("tk2").innerHTML="";_$("tk3").innerHTML="";_$("tk4").innerHTML="";_$("tk5").innerHTML="";}
  </script>
    </div>
    </form>
</body>
</html>
