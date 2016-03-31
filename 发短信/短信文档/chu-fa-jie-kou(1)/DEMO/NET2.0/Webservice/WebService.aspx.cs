using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _WebService : System.Web.UI.Page 
{
    public static WebReference.sms service = new WebReference.sms();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void ButSubmit_Click(object sender, EventArgs e)
    {
        string account = this.Txtaccount.Text.Trim();
        string password = this.Txtpassword.Text.Trim();//密码可以使用明文密码或使用32位MD5加密
        string mobile = this.Txtmobile.Text.Trim();
        string content = this.Txtcontent.Text.Trim();

        WebReference.SubmitResult state = service.Submit(account, password, mobile, content);

        //您的逻辑
        this.LabelRetMsg.Text = state.code + ":" + state.msg;

    }
}
