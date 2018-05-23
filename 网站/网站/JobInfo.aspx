<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JobInfo.aspx.cs" Inherits="JobInfo" %>

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
        <div style="color:yellow;text-align:left;margin-left:3%;">
           &nbsp&nbsp公司名称：<input type="text" id="InputName" ></input>
                    
                        <input type="button" id="Search"  value="搜索" onclick="search();" runat="server" />
                        
                    

        </div>
        <br /><br />
        <table class="div1" id="中国银行"  runat="server" style="background-image:url(tableback.jpg)">
            <tr>
                <td style="width:10%;">
                 <a href="http://jobs.zhaopin.com/380003833305183.htm?ssidkey=y&ss=201&ff=03&sg=1968b665a357461f9e5e223cb3dbde1b&so=1&uid=717971092" >  <img src="img/cb.jpg"  style="width:100px; height: 80px; text-align: left;margin-left:15px" /></a>
                    
                </td>
                <td style="text-align:left;width:30%">
                    公司名称：中国银行<br />
                    联系方式：xxx-xxxx-xxxx<br />
                    学历要求：本科学历<br />
                    岗位招聘：绵阳分行——客户经理助理（暑期实习生）<br />

                </td>
                <td style="width:60%;text-align:left">岗位职责：<br />1、协助开展网点事务性工作；协助网点行长进行阶段性项目完成。<br />2、协助网点进行厅堂客户分流、引导；协助理财经理进行客户营销、网点周边客户分析等。<br />福利待遇：<br />1、我们将为您发放交通及用餐补助。<br />2、实习结束后，实习评价结果为合格及以上的，经本人申请，实习所在单位人力资源部门可为其开具实习证明；实习评价结果为优秀的，可获得我行校园招聘直通卡，只需通过秋季校园招聘统一笔试，即可与我行签订三方协议，加入中行大家庭。</td>

            </tr>
        </table>
        <br /><br />

        <table class="div1" id="腾讯"  runat="server" style="background-image:url(tableback.jpg)">
            <tr>
                <td style="width:10%;">
                 <a href="http://jobs.zhaopin.com/364472418250510.htm?ssidkey=y&ss=201&ff=03&sg=78e804042e2f407493243169c0c104aa&so=4&uid=717971092" >  <img src="img/tencent.jpg"  style="width: 100px; height: 80px; text-align: left;margin-left:5px" /></a>
                    
                </td>
                <td style="text-align:left;width:30%">
                    公司名称：腾讯<br />
                    联系方式：xxx-xxxx-xxxx<br />
                    学历要求：本科学历<br />
                    岗位招聘：企业微信产品 销售代表<br />

                </td>
                <td style="width:60%;text-align:left">岗位职责：<br />1、搜集、挖掘公司潜在客户需求信息并提供专业售前咨询； <br />2、通过网络、电话、上门拜访等方式给予客户专业产品知识，提高用户满意度； <br />3、对客户群体进行开发，建立客户关系，促成签单，完成销售任务； <br />4、对客户跟进服务，提供完善的售前、售后服务。</td>

            </tr>
        </table>
        <br /><br />


       <table class="div1" id="华为"  runat="server" style="background-image:url(tableback.jpg)">
            <tr>
                <td style="width:10%;">
                 <a href="http://jobs.zhaopin.com/447474524250202.htm?ssidkey=y&ss=201&ff=03&sg=45aec9eec3c24ed48b43aea90453800a&so=2&uid=717971092" >  <img src="img/huawei.gif"  style="width: 70px; height: 80px; text-align: left;margin-left:20px" /></a>
                    
                </td>
                <td style="text-align:left;width:30%">
                    公司名称：华为<br />
                    联系方式：xxx-xxxx-xxxx<br />
                    学历要求：本科学历 3-5年工作经验<br />
                    岗位招聘：实施顾问/项目经理<br />

                </td>
                <td style="width:60%;text-align:left">岗位职责：<br />1、协助开展网点事务性工作；协助网点行长进行阶段性项目完成。<br />2、协助网点进行厅堂客户分流、引导；协助理财经理进行客户营销、网点周边客户分析等。<br />福利待遇：<br />1、我们将为您发放交通及用餐补助。<br />2、实习结束后，实习评价结果为合格及以上的，经本人申请，实习所在单位人力资源部门可为其开具实习证明；实习评价结果为优秀的，可获得我行校园招聘直通卡，只需通过秋季校园招聘统一笔试，即可与我行签订三方协议，加入中行大家庭。</td>

            </tr>
        </table>
        <br /><br />


       <table class="div1" id="浪潮"  runat="server" style="background-image:url(tableback.jpg)">
            <tr>
                <td style="width:10%;">
                 <a href="http://jobs.zhaopin.com/449909931250273.htm?ssidkey=y&ss=201&ff=03&sg=da6fb05ba9da46f688873c133ed85e2c&so=2&uid=717971092" >  <img src="img/inspur.jpg"  style="width: 100px; height: 80px; text-align: left;margin-left:5px" /></a>
                    
                </td>
                <td style="text-align:left;width:30%">
                    公司名称：浪潮<br />
                    联系方式：xxx-xxxx-xxxx<br />
                    学历要求：本科学历 1-3年工作经验<br />
                    岗位招聘：前端开发工程师<br />

                </td>
                <td style="width:60%;text-align:left">岗位职责：<br />1、协助开展网点事务性工作；协助网点行长进行阶段性项目完成。<br />2、协助网点进行厅堂客户分流、引导；协助理财经理进行客户营销、网点周边客户分析等。<br />福利待遇：<br />1、我们将为您发放交通及用餐补助。<br />2、实习结束后，实习评价结果为合格及以上的，经本人申请，实习所在单位人力资源部门可为其开具实习证明；实习评价结果为优秀的，可获得我行校园招聘直通卡，只需通过秋季校园招聘统一笔试，即可与我行签订三方协议，加入中行大家庭。</td>

            </tr>
        </table>
        <br /><br />

         <table class="div1" id="抖音"  runat="server" style="background-image:url(tableback.jpg)">
            <tr>
                <td style="width:10%;">
                 <a href="http://jobs.zhaopin.com/CZ519174220J00029510013.htm?ssidkey=y&ss=201&ff=03&sg=4cf4738c51ec4704bdb05766fee6094c&so=3&uid=717971092" >  <img src="img/抖音.jpg"  style="width: 80px; height: 80px; text-align: left;margin-left:15px" /></a>
                    
                </td>
                <td style="text-align:left;width:30%">
                    公司名称：抖音<br />
                    联系方式：xxx-xxxx-xxxx<br />
                    学历要求：本科学历<br />
                    岗位招聘：绵阳分行——客户经理助理（暑期实习生）<br />

                </td>
                <td style="width:60%;text-align:left">岗位职责：<br />1、协助开展网点事务性工作；协助网点行长进行阶段性项目完成。<br />2、协助网点进行厅堂客户分流、引导；协助理财经理进行客户营销、网点周边客户分析等。<br />福利待遇：<br />1、我们将为您发放交通及用餐补助。<br />2、实习结束后，实习评价结果为合格及以上的，经本人申请，实习所在单位人力资源部门可为其开具实习证明；实习评价结果为优秀的，可获得我行校园招聘直通卡，只需通过秋季校园招聘统一笔试，即可与我行签订三方协议，加入中行大家庭。</td>

            </tr>
        </table>
        <br /><br />

         <table class="div1" id="万达"  runat="server" style="background-image:url(tableback.jpg)">
            <tr>
                <td style="width:10%;">
                 <a href="http://jobs.zhaopin.com/505289587250013.htm?ssidkey=y&ss=201&ff=03&sg=9558b73c6cd741aba5efc7751171686b&so=4&uid=717971092" >  <img src="img/wanda.jpg"  style="width: 100px; height: 80px; text-align: left;margin-left:15px" /></a>
                    
                </td>
                <td style="text-align:left;width:30%">
                    公司名称：万达<br />
                    联系方式：xxx-xxxx-xxxx<br />
                    学历要求：本科学历<br />
                    岗位招聘：绵阳分行——客户经理助理（暑期实习生）<br />

                </td>
                <td style="width:60%;text-align:left">岗位职责：<br />1、协助开展网点事务性工作；协助网点行长进行阶段性项目完成。<br />2、协助网点进行厅堂客户分流、引导；协助理财经理进行客户营销、网点周边客户分析等。<br />福利待遇：<br />1、我们将为您发放交通及用餐补助。<br />2、实习结束后，实习评价结果为合格及以上的，经本人申请，实习所在单位人力资源部门可为其开具实习证明；实习评价结果为优秀的，可获得我行校园招聘直通卡，只需通过秋季校园招聘统一笔试，即可与我行签订三方协议，加入中行大家庭。</td>

            </tr>
        </table>
        <br /><br />

         <table class="div1" id="国家电网"  runat="server" style="background-image:url(tableback.jpg)">
            <tr>
                <td style="width:10%;">
                 <a href="http://jobs.zhaopin.com/562167120250089.htm?ssidkey=y&ss=201&ff=03&sg=825b4f7ba14a4294ba563879da433d63&so=1&uid=717971092" >  <img src="img/电网.jpg"  style="width: 80px; height: 80px; text-align: left;margin-left:20px" /></a>
                    
                </td>
                <td style="text-align:left;width:30%">
                    公司名称：国家电网<br />
                    联系方式：xxx-xxxx-xxxx<br />
                    学历要求：本科学历<br />
                    岗位招聘：绵阳分行——客户经理助理（暑期实习生）<br />

                </td>
                <td style="width:60%;text-align:left">岗位职责：<br />1、协助开展网点事务性工作；协助网点行长进行阶段性项目完成。<br />2、协助网点进行厅堂客户分流、引导；协助理财经理进行客户营销、网点周边客户分析等。<br />福利待遇：<br />1、我们将为您发放交通及用餐补助。<br />2、实习结束后，实习评价结果为合格及以上的，经本人申请，实习所在单位人力资源部门可为其开具实习证明；实习评价结果为优秀的，可获得我行校园招聘直通卡，只需通过秋季校园招聘统一笔试，即可与我行签订三方协议，加入中行大家庭。</td>

            </tr>
        </table>
        <br /><br />

         <table class="div1" id="中情局"  runat="server" style="background-image:url(tableback.jpg)">
            <tr>
                <td style="width:10%;">
                 <a href="../中情局.aspx" >  <img src="img/中情局.jpg"  style="width: 80px; height: 80px; text-align: left;margin-left:20px" /></a>
                    
                </td>
                <td style="text-align:left;width:30%">
                    公司名称：神盾局<br />
                    联系方式：xxx-xxxx-xxxx<br />
                    学历要求：博士生学历<br />
                    岗位招聘：先从扫地开始<br />

                </td>
                <td style="width:60%;text-align:left">岗位职责：<br />1、保证让神盾局里面的dalao们满意。<br />2、保证让神盾局里面的dalao们满意。<br />2、保证让神盾局里面的dalao们满意。<br />福利待遇：无</td>

            </tr>
        </table>
        <br /><br />

         <table class="div1" id="招商银行"  runat="server" style="background-image:url(tableback.jpg)">
            <tr>
                <td style="width:10%;">
                 <a href="http://jobs.zhaopin.com/000103360254303.htm?ssidkey=y&ss=201&ff=03&sg=1639c84e9b6f4c3b9e1dd554ad3d98e6&so=1&uid=717971092" >  <img src="img/zhaoshang.jpg"  style="width: 80px; height: 80px; text-align: left;margin-left:15px" /></a>
                    
                </td>
                <td style="text-align:left;width:30%">
                    公司名称：招商银行<br />
                    联系方式：xxx-xxxx-xxxx<br />
                    学历要求：本科学历<br />
                    岗位招聘：绵阳分行——客户经理助理（暑期实习生）<br />

                </td>
                <td style="width:60%;text-align:left">岗位职责：<br />1、协助开展网点事务性工作；协助网点行长进行阶段性项目完成。<br />2、协助网点进行厅堂客户分流、引导；协助理财经理进行客户营销、网点周边客户分析等。<br />福利待遇：<br />1、我们将为您发放交通及用餐补助。<br />2、实习结束后，实习评价结果为合格及以上的，经本人申请，实习所在单位人力资源部门可为其开具实习证明；实习评价结果为优秀的，可获得我行校园招聘直通卡，只需通过秋季校园招聘统一笔试，即可与我行签订三方协议，加入中行大家庭。</td>

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
            中国银行.setAttribute("hidden", "hidden");
            浪潮.setAttribute("hidden", "hidden");
            华为.setAttribute("hidden", "hidden");
            万达.setAttribute("hidden", "hidden");
            中情局.setAttribute("hidden", "hidden");
            抖音.setAttribute("hidden", "hidden");
            招商银行.setAttribute("hidden", "hidden");
            腾讯.setAttribute("hidden", "hidden");
            国家电网.setAttribute("hidden", "hidden");
        //    刘明.removeAttribute("hidden", "hidden");
            var a = document.getElementById("InputName").value;
            
            
            switch(a)
            {
                case "中国银行": 中国银行.removeAttribute("hidden", "hidden");
                    break;
                case "浪潮": 浪潮.removeAttribute("hidden", "hidden");
                    break;
                case "华为": 华为.removeAttribute("hidden", "hidden");
                    break;
                case "万达": 万达.removeAttribute("hidden", "hidden");
                    break;
                case "中情局": 中情局.removeAttribute("hidden", "hidden");
                    break;
                case "抖音": 抖音.removeAttribute("hidden", "hidden");
                    break;
                case "招商银行": 招商银行.removeAttribute("hidden", "hidden");
                    break;
                case "腾讯": 腾讯.removeAttribute("hidden", "hidden");
                    break;
                case "国家电网": 国家电网.removeAttribute("hidden", "hidden");
                    break;
                default: alert("不存在名为"+a+"的公司O_O");
            }
             
				};

				//鼠标点击marker弹出自定义的信息窗体
			
    </script>
        
</body>
</html>
