/**
 * Created by 王军 on 2016/1/7.
 */
var flag3 = false;
var flag4 = false;
var flag2 = false;
var flag5 = false;
var timebind;
//点击发送验证码的倒计时
clickCode();
function clickCode()
{
    $("#scode").on("mousedown",function(e){
        if(e.which !=1 || !flag2)
        {
            return;
        }
        timebind = window.setInterval("time60()",1000);
        sendyan();
        $(this).off("mousedown");
    })
}

var index = 60;
function time60()
{
    index --;
    if(index < 1)
    {
        index = 60;
        $("#scode").text("发送验证码");
        window.clearInterval(timebind);
        clickCode();
    }else{

        $("#scode").text(index+"秒后重发");
    }

}
//发送验证码
function sendyan(){
    var phone = $("#username").val();

    if (phone && /^1[3|4|5|8]\d{9}$/.test(phone) && flag2) {
        $.ajax({
            url: "/user/sms",
            type: 'post',
            data: {"phoneNum": phone},
            dataType: 'json',  // 处理Ajax跨域问题
            success: function (data) {

            }
        });
    }
}
/*验证修改的密码*/
function isnull(){

    var phnumber = document.getElementById("username").value;
    var yan = document.getElementById("yan").value;
    if(!phnumber ||!yan || !flag2 || !flag5){
       $(".alertinfo").text("请检查你输入的是否符合要求！");
    }else{
        $(".hiddenname").val(phnumber);
        $("#findpsw1").css("display","none");
        $("#findpsw2").css("display","block");
    }

}



/*验证手机号*/
$("#username").on("blur",function(){
    var _username = $(this).val();

    if(/^1[3|4|5|8]\d{9}$/.test(_username))
    {

        /*验证改手机号是否已注册*/
        $.ajax({
            url:"/user/isregister",
            type:"post",
            dataType:"text",
            data:{tel:_username},
            success:function(data){
                if("false" == data)
                {
                    $("#username").parents(".username").addClass("has-error").removeClass("has-success")
                        .siblings(".col-xs-3").find("span").html("该手机号未注册");
                    flag2 = false;
                }else
                {
                    $("#username").parents(".username").addClass("has-success").removeClass("has-error")
                        .siblings(".col-xs-3").find("span").html("<span class='glyphicon glyphicon-ok pswinfo2' style='color: greenyellow'></span>");
                    flag2 = true;
                }
            }
        })

    }else
    {
        $(this).parents(".username").addClass("has-error").removeClass("has-success")
            .siblings(".col-xs-3").find("span").html("手机号不合法！");
        flag2 = false;
    }
})

/*验证验证码*/
$("#yan").on("blur",function(){
    var _yan = $(this).val();

    if(/^[0-9]{6}$/.test(_yan))
    {

        /*验证验证码是否正确*/
        $.ajax({
            url:"/user/iscode",
            type:"post",
            dataType:"text",
            data:{code:_yan},
            success:function(data){

                if("true" == data)
                {
                    $("#yan").parents(".yan").addClass("has-success").removeClass("has-error")
                        .siblings(".col-xs-3").find("span").html("<span class='glyphicon glyphicon-ok pswinfo2' style='color: greenyellow'></span>");
                    flag5= true;
                }else
                {
                    $("#yan").parents(".yan").addClass("has-error").removeClass("has-success")
                        .siblings(".col-xs-3").find("span").html("验证码错误！");
                    flag5 = false;
                }

            }
        })

    }else
    {
        $(this).parents(".yan").addClass("has-error").removeClass("has-success")
            .siblings(".col-xs-3").find("span").html("6位验证码");
        flag5 = false;
    }
});
/*---------------------------------------------------------------------------------*/

    /*注册提交*/
    function isnullagin(){

      var password1 = document.getElementById("password").value;
        var passwordagain = document.getElementById("passwordagain").value;

        if( !password1 || !passwordagain || !flag3 || !flag4){
            $(".alertinfo2").text("请检查你输入的是否符合要求！");
        }else{

            var uname = $(".hiddenname").val();
            $.ajax({
                url:"/user/changepwd2",
                data:{username:uname,password:password1},
                type:"post",
                dataType:"json",
                success:function(data){

                    if(data.flag == true)
                    {
                        $("#findpsw1").css("display","none");
                         $("#findpsw2").css("display","none");
                         $("#findpsw3").css("display","block");
                    }else{
                        $(".alertinfo2").text("提交失败！");
                    }
                }

            })

        }

    }

    /*验证密码*/
    $("#password").on("blur",function(){
        var _password = $(this).val();

        if(/^[0-9a-zA-Z_]{6,20}$/.test(_password))
        {
            $(this).parents(".password").addClass("has-success").removeClass("has-error")
                .siblings(".col-xs-3").find("span").html("<span class='glyphicon glyphicon-ok pswinfo2' style='color: greenyellow'></span>");
            flag3 = true;
        }else
        {
            $(this).parents(".password").addClass("has-error").removeClass("has-success")
                .siblings(".col-xs-3").find("span").html("6-20位，数字、字母、下划线组合");
            flag3 = false;
        }
    })

    /*验证密码*/
    $("#passwordagain").on("blur",function(){
        var _passwordagain = $(this).val();
        var _password = $("#password").val();
        if(_passwordagain == _password && _password != "")
        {
            $(this).parents(".passwordagain").addClass("has-success").removeClass("has-error")
                .siblings(".col-xs-3").find("span").html("<span class='glyphicon glyphicon-ok pswinfo2' style='color: greenyellow'></span>");
            flag4 = true;
        }else
        {
            $(this).parents(".passwordagain").addClass("has-error").removeClass("has-success")
                .siblings(".col-xs-3").find("span").html("两次输入的密码不同！");
            flag4 = false;
        }
    })
