$(function () {
	'use strict';
	$("#login").click(function () {
		$("#login-box1").show();
	});
	$("#btn-close").click(function () {
		$("#login-box1").hide();
	});
	$("#btn-login").click(function () {
		$("#login-box1").hide();
		$("#login").hide();
		$("#contect").prepend("<a href='#' id='name'><span>用户：" + $("#number").val() + "</span></a>");
		$("#name").after("<a href='#' class='logout'><span>&nbsp&nbsp注销</span></a>");
	});
	$(Document).on("click",".logout",function () {
		$("#login").show();
		$("#name").remove();
		$(".logout").remove();
	});

	$("#box6").click(function(){
		$(".blue").css("display","block");
		$(".red").css("display","none");
	});
	$("#box7").click(function(){
	$(".blue").css("display","none");
	$(".red").css("display","block");
	});
	
	$("#num li").mouseover(function(){
		var x=$(this).text();
		
		$(this).css("background-color","yellow").siblings().css("background-color","white");
		
		$("#images li").eq(x-1).animate({height:391},100).siblings().animate({height:0},100);
	});
	
});
