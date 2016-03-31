package wj;

/**
 * 泽本信息版权所有 2014-2016
 * 创建者：王军
 * 创建于:2015/1/26
 * 项目名称：镇江文化馆
 * 修改记录：
 * 当前版本：1.0
 * 功能描述：
 */
public class Send {

    public static void main(String[] args)
    {
        SendMsg sendMsg = new SendMsg();
        sendMsg.setPhoneNum("13770527535");
        try {
            sendMsg.send("你的1234123412");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
