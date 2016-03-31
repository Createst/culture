/**
 * Created by 王军 on 2015/1/25.
 */

$(function(){
    $(".about-nav li").on("mousedown",function(e){
        if(e.which !=1)
        {
            return;
        }
        $(this).addClass("active2").css("background","#f2f2f2").siblings().removeClass("active2").css("background","#fdfdfd");
        var index = $(this).index();
        $("#showme > div:eq("+index+")").css({"display":"block","z-index":"10"}).siblings().css({"display":"none","z-index":"0"});
    })
})
