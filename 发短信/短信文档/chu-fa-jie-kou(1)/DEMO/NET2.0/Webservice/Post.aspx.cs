using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Post : System.Web.UI.Page
{
    public static string PostUrl = ConfigurationManager.AppSettings["WebReference.Service.PostUrl"];
    protected void Page_Load(object sender, EventArgs e)
    {
        string account = "用户名";
        string password = "密码";//密码可以使用明文密码或使用32位MD5加密
        string mobile = Request.QueryString["mobile"];
        string content = "您的验证码是：3548。请不要把验证码泄露给其他人。";

        string postStrTpl = "account={0}&password={1}&mobile={2}&content={3}";

        UTF8Encoding encoding = new UTF8Encoding();
        byte[] postData = encoding.GetBytes(string.Format(postStrTpl, account, password, mobile, content));

        HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(PostUrl);
        myRequest.Method = "POST";
        myRequest.ContentType = "application/x-www-form-urlencoded";
        myRequest.ContentLength = postData.Length;

        Stream newStream = myRequest.GetRequestStream();
        // Send the data.
        newStream.Write(postData, 0, postData.Length);
        newStream.Flush();
        newStream.Close();

        HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
        if (myResponse.StatusCode == HttpStatusCode.OK)
        {
            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);

               //Response.Write(reader.ReadToEnd());

               string res = reader.ReadToEnd();
               int len1 = res.IndexOf("</code>");
               int len2 = res.IndexOf("<code>");
               string code=res.Substring((len2+6),(len1-len2-6));
               //Response.Write(code);

               int len3 = res.IndexOf("</msg>");
               int len4 = res.IndexOf("<msg>");
               string msg=res.Substring((len4+5),(len3-len4-5));
               Response.Write(msg);

               Response.End();

        }
        else
        {
            //访问失败
        }
    }
}
