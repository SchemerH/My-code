<%@ Page Language="C#" AutoEventWireup="true" CodeFile="talkInfo.aspx.cs" Inherits="talkInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .table {
            border-color: yellow;
            width: 98%;
            height: 90px;
            border-radius: 10px;
            text-align: center;
            border-collapse: collapse;
        }

            .table tr td {
                border: 1px solid yellow;
                border-radius: 10px;
            }

        #Search {
            margin-left: 3%;
            border-radius:4px;
        }

        .div1 {
            border: 1px solid blue;
            height: 150px;
            width: 98%;
            border-radius: 10px;
        }

        body {
            background-image: url(back1.jpg);
            background-repeat: no-repeat;
            background-size: cover;
        }
        #InputName{
            border-radius:4px;
        }
        #GraduateTime1{
            border-radius:4px;
        }
         #GraduateTime2{
            border-radius:4px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table id="table" cellpadding="0" cellspacing="0" class="table">
                <tr>
                    <td style="color:yellow;text-align:left;margin-left:3%;">&nbsp&nbsp姓名：<input type="text" id="InputName" ></input></td>
                    <td style="color:yellow;text-align:left;margin-left:3%;">&nbsp&nbsp毕业年份：<asp:TextBox ID="GraduateTime1" runat="server"></asp:TextBox>-<asp:TextBox ID="GraduateTime2" runat="server"></asp:TextBox>
                        <input type="button" id="Search"  value="搜索" onclick="search();" runat="server" />
                        
                    </td>
                </tr>


            </table>
        </div>
        <br /><br />
        <table class="div1" id="张文瑶"  runat="server" style="background-image:url(tableback.jpg)">
            <tr>
                <td style="width:10%;">
                 <a href="../qq/张文瑶.html" >  <img src="img/man.png"  style="width: 80px; height: 80px; text-align: left;" /></a>
                    
                </td>
                <td style="text-align:left;width:30%">
                    姓名：学神：张文瑶<br />
                    联系方式：xxx-xxxx-xxxx<br />
                    就业/读研位置：北京市 北京大学<br />
                    毕业年份：2019<br />

                </td>
                <td style="width:60%;text-align:left">个人简介:忠实诚信,讲原则，说到做到，决不推卸责任；有自制力，做事情始终坚持有始有终，从不半途而废；肯学习,有问题不逃避,愿意虚心向他人学习；自信但不自负,不以自我为中心；愿意以谦虚态度赞扬接纳优越者,权威者；会用100%的热情和精力投入到工作中；平易近人。为人诚恳,性格开朗,积极进取,适应力强、勤奋好学、脚踏实地，有较强的团队精神,工作积极进取,态度认真。</td>

            </tr>
        </table>
        <br /><br />

         <table class="div1" id="陈炫臣" style="background-image:url(tableback.jpg)">
            <tr>
                <td style="width:10%;">
                    <img src="img/man.png" style="width: 80px; height: 80px; text-align: left;" />
                    
                </td>
                <td style="text-align:left;width:30%">
                    姓名：学霸：陈炫臣<br />
                    联系方式：xxx-xxxx-xxxx<br />
                    就业/读研位置：北京市 清华大学<br />
                    毕业年份：2019<br />

                </td>
                <td style="width:60%;text-align:left">个人简介:忠实诚信,讲原则，说到做到，决不推卸责任；有自制力，做事情始终坚持有始有终，从不半途而废；肯学习,有问题不逃避,愿意虚心向他人学习；自信但不自负,不以自我为中心；愿意以谦虚态度赞扬接纳优越者,权威者；会用100%的热情和精力投入到工作中；平易近人。为人诚恳,性格开朗,积极进取,适应力强、勤奋好学、脚踏实地，有较强的团队精神,工作积极进取,态度认真。</td>

            </tr>
        </table>
        <br /><br />


         <table class="div1" id="张伟" style="background-image:url(tableback.jpg)">
            <tr>
                <td style="width:10%;">
                    <img src="img/man.png" style="width: 80px; height: 80px; text-align: left;" />
                    
                </td>
                <td style="text-align:left;width:30%">
                    姓名：张伟<br />
                    联系方式：xxx-xxxx-xxxx<br />
                    就业/读研位置：济南市 中国银行济南分部<br />
                    毕业年份：2017<br />

                </td>
                <td style="width:60%;text-align:left">个人简介:忠实诚信,讲原则，说到做到，决不推卸责任；有自制力，做事情始终坚持有始有终，从不半途而废；肯学习,有问题不逃避,愿意虚心向他人学习；自信但不自负,不以自我为中心；愿意以谦虚态度赞扬接纳优越者,权威者；会用100%的热情和精力投入到工作中；平易近人。为人诚恳,性格开朗,积极进取,适应力强、勤奋好学、脚踏实地，有较强的团队精神,工作积极进取,态度认真。</td>

            </tr>
        </table>
        <br /><br />


         <table class="div1" id="李琛" style="background-image:url(tableback.jpg)">
            <tr>
                <td style="width:10%;">
                    <img src="img/man.png" style="width: 80px; height: 80px; text-align: left;" />
                    
                </td>
                <td style="text-align:left;width:30%">
                    姓名：李琛<br />
                    联系方式：xxx-xxxx-xxxx<br />
                    就业/读研位置：深圳市 用友公司深圳分部<br />
                    毕业年份：2019<br />

                </td>
                <td style="width:60%;text-align:left">个人简介:忠实诚信,讲原则，说到做到，决不推卸责任；有自制力，做事情始终坚持有始有终，从不半途而废；肯学习,有问题不逃避,愿意虚心向他人学习；自信但不自负,不以自我为中心；愿意以谦虚态度赞扬接纳优越者,权威者；会用100%的热情和精力投入到工作中；平易近人。为人诚恳,性格开朗,积极进取,适应力强、勤奋好学、脚踏实地，有较强的团队精神,工作积极进取,态度认真。</td>

            </tr>
        </table>
        <br /><br />

         <table class="div1"id="刘明" style="background-image:url(tableback.jpg)">
            <tr>
                <td style="width:10%;">
                    <img src="img/man.png" style="width: 80px; height: 80px; text-align: left;" />
                    
                </td>
                <td style="text-align:left;width:30%">
                    姓名：刘明<br />
                    联系方式：xxx-xxxx-xxxx<br />
                    就业/读研位置：北京市 北京大学<br />
                    毕业年份：2019<br />

                </td>
                <td style="width:60%;text-align:left">个人简介:忠实诚信,讲原则，说到做到，决不推卸责任；有自制力，做事情始终坚持有始有终，从不半途而废；肯学习,有问题不逃避,愿意虚心向他人学习；自信但不自负,不以自我为中心；愿意以谦虚态度赞扬接纳优越者,权威者；会用100%的热情和精力投入到工作中；平易近人。为人诚恳,性格开朗,积极进取,适应力强、勤奋好学、脚踏实地，有较强的团队精神,工作积极进取,态度认真。</td>

            </tr>
        </table>
        <br /><br />

         <table class="div1" id="胡裕阳" style="background-image:url(tableback.jpg)">
            <tr>
                <td style="width:10%;">
                    <img src="img/man.png" style="width: 80px; height: 80px; text-align: left;" />
                    
                </td>
                <td style="text-align:left;width:30%">
                    姓名：胡裕阳<br />
                    联系方式：xxx-xxxx-xxxx<br />
                    就业/读研位置：北京市 北京大学<br />
                    毕业年份：2019<br />

                </td>
                <td style="width:60%;text-align:left">个人简介:忠实诚信,讲原则，说到做到，决不推卸责任；有自制力，做事情始终坚持有始有终，从不半途而废；肯学习,有问题不逃避,愿意虚心向他人学习；自信但不自负,不以自我为中心；愿意以谦虚态度赞扬接纳优越者,权威者；会用100%的热情和精力投入到工作中；平易近人。为人诚恳,性格开朗,积极进取,适应力强、勤奋好学、脚踏实地，有较强的团队精神,工作积极进取,态度认真。</td>

            </tr>
        </table>
        <br /><br />

         <table class="div1" id="晏起煌" style="background-image:url(tableback.jpg)">
            <tr>
                <td style="width:10%;">
                    <img src="img/man.png" style="width: 80px; height: 80px; text-align: left;" />
                    
                </td>
                <td style="text-align:left;width:30%">
                    姓名：晏起煌<br />
                    联系方式：xxx-xxxx-xxxx<br />
                    就业/读研位置：北京市 北京大学<br />
                    毕业年份：2019<br />

                </td>
                <td style="width:60%;text-align:left">个人简介:忠实诚信,讲原则，说到做到，决不推卸责任；有自制力，做事情始终坚持有始有终，从不半途而废；肯学习,有问题不逃避,愿意虚心向他人学习；自信但不自负,不以自我为中心；愿意以谦虚态度赞扬接纳优越者,权威者；会用100%的热情和精力投入到工作中；平易近人。为人诚恳,性格开朗,积极进取,适应力强、勤奋好学、脚踏实地，有较强的团队精神,工作积极进取,态度认真。</td>

            </tr>
        </table>
        <br /><br />

         <table class="div1" id="宋璐璐" style="background-image:url(tableback.jpg)">
            <tr>
                <td style="width:10%;">
                    <img src="img/man.png" style="width: 80px; height: 80px; text-align: left;" />
                    
                </td>
                <td style="text-align:left;width:30%">
                    姓名：宋璐璐<br />
                    联系方式：xxx-xxxx-xxxx<br />
                    就业/读研位置：北京市 北京大学<br />
                    毕业年份：2019<br />

                </td>
                <td style="width:60%;text-align:left">个人简介:忠实诚信,讲原则，说到做到，决不推卸责任；有自制力，做事情始终坚持有始有终，从不半途而废；肯学习,有问题不逃避,愿意虚心向他人学习；自信但不自负,不以自我为中心；愿意以谦虚态度赞扬接纳优越者,权威者；会用100%的热情和精力投入到工作中；平易近人。为人诚恳,性格开朗,积极进取,适应力强、勤奋好学、脚踏实地，有较强的团队精神,工作积极进取,态度认真。</td>

            </tr>
        </table>
        <br /><br />

         <table class="div1" id="卢本伟" style="background-image:url(tableback.jpg)">
            <tr>
                <td style="width:10%;">
               <a href="../qq/卢本伟.html" >      <img src="img/man.png" style="width: 80px; height: 80px; text-align: left;" /></a>
                    
                </td>
                <td style="text-align:left;width:30%">
                    姓名：卢本伟<br />
                    联系方式：xxx-xxxx-xxxx<br />
                    就业/读研位置：北京市 北京大学<br />
                    毕业年份：2019<br />

                </td>
                <td style="width:60%;text-align:left">个人简介:忠实诚信,讲原则，说到做到，决不推卸责任；有自制力，做事情始终坚持有始有终，从不半途而废；肯学习,有问题不逃避,愿意虚心向他人学习；自信但不自负,不以自我为中心；愿意以谦虚态度赞扬接纳优越者,权威者；会用100%的热情和精力投入到工作中；平易近人。为人诚恳,性格开朗,积极进取,适应力强、勤奋好学、脚踏实地，有较强的团队精神,工作积极进取,态度认真。</td>

            </tr>
        </table>
        <br /><br />
    </form>




    <script type="text/javascript">



        function search() 
                {
//            zhang.Style["hidden"] = "hidden";
  //          zhang.attributes.Add(hidden, "hidden");
    //        zhang.style.visibility = "hidden";
  //          $("#zhang").hide();
    //        zhang.hidden = "hidden";
      //      zhang.hidden;
        //    $("#zhang").attr("hidden", "hidden");
            张文瑶.setAttribute("hidden", "hidden");
            陈炫臣.setAttribute("hidden", "hidden");
            张伟.setAttribute("hidden", "hidden");
            李琛.setAttribute("hidden", "hidden");
            刘明.setAttribute("hidden", "hidden");
            胡裕阳.setAttribute("hidden", "hidden");
            晏起煌.setAttribute("hidden", "hidden");
            宋璐璐.setAttribute("hidden", "hidden");
            卢本伟.setAttribute("hidden", "hidden");
        //    刘明.removeAttribute("hidden", "hidden");
            var a = document.getElementById("InputName").value;
            
            
            switch(a)
            {
                case "张文瑶": 张文瑶.removeAttribute("hidden", "hidden");
                    break;
                case "陈炫臣": 陈炫臣.removeAttribute("hidden", "hidden");
                    break;
                case "张伟": 张伟.removeAttribute("hidden", "hidden");
                    break;
                case "李琛": 李琛.removeAttribute("hidden", "hidden");
                    break;
                case "刘明": 刘明.removeAttribute("hidden", "hidden");
                    break;
                case "胡裕阳": 胡裕阳.removeAttribute("hidden", "hidden");
                    break;
                case "晏起煌": 晏起煌.removeAttribute("hidden", "hidden");
                    break;
                case "宋璐璐": 宋璐璐.removeAttribute("hidden", "hidden");
                    break;
                case "卢本伟": 卢本伟.removeAttribute("hidden", "hidden");
                    break;
                default: alert("不存在名为"+a+"的人物O_O");
            }
             
				};

				//鼠标点击marker弹出自定义的信息窗体
			
    </script>
        
</body>
</html>
