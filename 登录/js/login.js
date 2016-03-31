/**
 * Created by wangjun on 2016/1/11.
 */

$(function(){
    var _tel = window.localStorage.getItem("tel");
    if(null != _tel)
    {
        $("input[name='username']").val(_tel);
    }
});

/*验证是否为空*/
function loginVerify(){

    var rempsw = $("input[type='checkbox']");
    if(rempsw[0].checked)//是否保存用户名
    {
        window.localStorage.setItem("tel",$("input[name='username']").val());
    }

    if($("#uname").val()=="" || $("#psw").val()=="")
    {
       $("#alertinfo").text("用户名或密码不能为空！");
        return false;
    }else{
        $("#alertinfo").text("");
        return true;
    }

}
