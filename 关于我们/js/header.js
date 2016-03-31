/**
 * Created by 王军 on 2016/1/5.
 */

function getTime()
{
    var date = new Date();
    $("#header-time").text("你好，欢迎访问镇江文化馆！"+date.getFullYear()+"年"+(date.getMonth()+1)+"月"+date.getDate()+"日" );
}
getTime();


