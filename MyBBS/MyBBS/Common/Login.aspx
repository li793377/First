<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MyBBS.Common.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>登录框</title>
    <link href="../CSS/StyleSheet.css" rel="Stylesheet" type="text/css" />
</head>
<body style="background-image: url(../Images/登录.jpg)">
    <form id="form1" runat="server">
    <div>
        <table style="width: 260px; height: 125px" class="TableCss" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label1" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 65px">
                    登录名：</td>
                <td style="width: 120px">
                    <asp:TextBox ID="txtName" runat="server" Width="100px"></asp:TextBox></td>
                <td style="width: 75px">
                </td>
            </tr>
            <tr>
                <td style="width: 65px">
                    密&nbsp; 码：</td>
                <td style="width: 120px">
                    <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" Width="100px"></asp:TextBox></td>
                <td style="width: 75px">
                </td>
            </tr>
             <tr>
                <td style="width: 65px">
                    验证码：</td>
                <td style="width: 120px">
                    <asp:TextBox ID="txtCode" runat="server" Width="100px"></asp:TextBox></td>
                <td style="width: 75px">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Common/checkcode.aspx"/></td>
            </tr>
            <tr>
                <td style="width: 65px">
                </td>
                <td colspan="2">
                    <asp:Button ID="btnLogin" runat="server" CssClass="ButtonCss" OnClick="btnLogin_Click"
                        Text="登录" />
                    &nbsp;
                    <asp:Button ID="btnClose" runat="server" CssClass="ButtonCss" OnClick="btnClose_Click"
                        Text="关闭" /></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
