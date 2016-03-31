<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="WebService.aspx.cs" Inherits="_WebService" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table bordercolor="#dcdcdc" cellpadding="4" cellspacing="0" frame="box" rules="none"
            style="border-collapse: collapse">
            <tr>
                <td background="#dcdcdc" class="frmHeader" style="border-right: white 2px solid">参数</td>
                <td background="#dcdcdc" class="frmHeader">值</td>
            </tr>
            <tr>
                <td class="frmText" style="font-weight: normal; color: #000000">account</td>
                <td><asp:TextBox CssClass="frmInput" Id="Txtaccount" runat="server" name="account" Width="272px" value="用户名" /></td>
            </tr>
            <tr>
                <td class="frmText" style="font-weight: normal; color: #000000">password</td>
                <td><asp:TextBox  CssClass="frmInput" id="Txtpassword" runat="server" name="password" Width="272px" value="密码" /></td>
            </tr>
            <tr>
                <td class="frmText" style="font-weight: normal; color: #000000">mobile</td>
                <td>
                    <asp:TextBox  CssClass="frmInput" id="Txtmobile" runat="server" name="mobile" Width="272px" value="手机号码" /></td>
            </tr>
            <tr>
                <td class="frmText" style="font-weight: normal; color: #000000">content</td>
                <td>
                    <asp:TextBox CssClass="frmInput" id="Txtcontent" runat="server" name="content" Width="272px" value="您的验证码是：3548。请不要把验证码泄露给其他人。" /></td>
            </tr>
            <tr>    
                <td></td>            
                <td align="center"><asp:Button ID="ButSubmit" runat="server" Text="提交" OnClick="ButSubmit_Click" /></td>
            </tr>
            <tr>    
                <td></td>            
                <td align="center"><asp:Label ID="LabelRetMsg" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>