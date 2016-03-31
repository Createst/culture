using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string account = this.Txtaccount.Text.Trim();
            string password = this.Txtpassword.Text.Trim();//密码可以使用明文密码或使用32位MD5加密
            string mobile = this.Txtmobile.Text.Trim();
            string content = this.Txtcontent.Text.Trim();

            sms sms1 = new sms();

           SubmitResult SubmitResult1 = sms1.Submit(account, password, mobile, content);
           this.LabelRetMsg.Text = "<br>code:" + SubmitResult1.code + "<br>msg:" + SubmitResult1.msg;
           //Response.Write("<br>code:" + SubmitResult1.code + "<br>msg:" + SubmitResult1.msg);
        }
    }
}
