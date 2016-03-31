<%@ Page Title="主页" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

    <div>
        <table cellpadding="4" cellspacing="0" frame="box" rules="none"
            style="border-collapse: collapse">
            <tr>
                <td class="frmHeader" style="border-right: white 2px solid">参数</td>
                <td class="frmHeader">值</td>
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
                    <asp:TextBox CssClass="frmInput" id="Txtcontent" runat="server" name="content" Width="272px" value="您的验证码是：8531。请不要把验证码泄露给其他人。" /></td>
            </tr>
            <tr>    
                <td></td>            
                <td align="center"><asp:Button ID="Button2" runat="server" onclick="Button1_Click" Text="提交" /></td>
            </tr>
            <tr>    
                <td></td>            
                <td align="left"><asp:Label ID="LabelRetMsg" runat="server"></asp:Label></td>
            </tr>
        </table>
    
    </div>

</asp:Content>
