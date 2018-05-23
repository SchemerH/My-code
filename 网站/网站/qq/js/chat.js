$('.conLeft li').on('click',function(){
		$(this).addClass('bg').siblings().removeClass('bg');
		var intername=$(this).children('.liRight').children('.intername').text();
		$('.headName').text(intername);
		$('.newsList').html('');
	})
	$('.sendBtn').on('click',function(){
		var news=$('#dope').val();
		if(news==''){
			alert('不能为空');
		}else{
			$('#dope').val('');
		var str='';
		str+='<li>'+
				'<div class="nesHead"><img src="img/6.jpg"/></div>'+
				'<div class="news"><img class="jiao" src="img/20170926103645_03_02.jpg">'+news+'</div>'+
			'</li>';
		$('.newsList').append(str);
		setTimeout(answers,1000); 
		$('.conLeft').find('li.bg').children('.liRight').children('.infor').text(news);
		$('.RightCont').scrollTop($('.RightCont')[0].scrollHeight );
	}
	
	})
	function answers(){
		var arr=["你好，你们可爱的张文瑶学姐出现啦！","小鲜肉有什么想问的吗"];
		var aa=Math.floor((Math.random()*arr.length));
		var answer='';
		answer+='<li>'+
					'<div class="answerHead"><img src="img/tou.jpg"/></div>'+
					'<div class="answers"><img class="jiao" src="img/jiao.jpg">'+arr[aa]+'</div>'+
				'</li>';
		$('.newsList').append(answer);	
		$('.RightCont').scrollTop($('.RightCont')[0].scrollHeight );
	}
	$('.ExP').on('mouseenter',function(){
		$('.emjon').show();
	})
	$('.emjon').on('mouseleave',function(){
		$('.emjon').hide();
	})
	$('.emjon li').on('click',function(){
		var imgSrc=$(this).children('img').attr('src');
		var str="";
		str+='<li>'+
				'<div class="nesHead"><img src="img/6.jpg"/></div>'+
				'<div class="news"><img class="jiao" src="img/20170926103645_03_02.jpg"><img class="Expr" src="'+imgSrc+'"></div>'+
			'</li>';
		$('.newsList').append(str);
		$('.emjon').hide();
		$('.RightCont').scrollTop($('.RightCont')[0].scrollHeight );
	})




	function addLi(useName, useEamil, usePhone) {
	    var li_1 = document.createElement("li");
	    li_1.setAttribute("class", "newLi");
	    addSpan(li_1, userName);
	    addSpan(li_1, userEamil);
	    addSpan(li_1, userPhone);
	    addDelBtn(li_1);
	    document.getElementById("J_List").appendChild(li_1);
	}
	//为姓名或邮箱等添加span标签，好设置样式
	function addSpan(li, text) {
	    var span_1 = document.createElement("span");
	    span_1.innerHTML = text;
	    li.appendChild(span_1);
	}
	//添加删除按钮及设置删除按钮的样式及添加点击事件
	function addDelBtn(li) {
	    var span_1 = document.createElement("span");
	    var btn = document.createElement("button");
	    btn.setAttribute("type", "button");
	    btn.setAttribute("class", "delBtn");
	    btn.setAttribute("onclick", "delBtnData(this)");
	    btn.innerHTML = "删除";
	    span_1.appendChild(btn);
	    li.appendChild(span_1);
	}
	//为删除按钮添加删除节点功能
	function delBtnData(obj) {
	    var ul = document.getElementById("J_List");
	    var oLi = obj.parentNode.parentNode;
	    //obj.parentNode指删除按钮的span层
	    //obj.parentNode.parentNode为li层
	    ul.removeChild(oLi);
	}