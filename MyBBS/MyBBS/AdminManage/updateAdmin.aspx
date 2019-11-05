<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updateAdmin.aspx.cs" Inherits="MyBBS.AdminManage.updateAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <head runat="server">
    <title>无标题页</title>
    <link href="../CSS/StyleSheet.css" rel="Stylesheet" type="text/css" />
    <style>
    body{margin-top:0px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="width: 794px; height: 489px; background-image: url(../Images/大背景.jpg);" class="TableCss" align="center" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td colspan="1" style="font-size: 14pt; width: 223px">
                </td>
                <td colspan="3" style="font-size: 14pt">
                    <br />
                    管理员信息</td>
                <td colspan="1" style="font-size: 14pt; width: 193px">
                </td>
            </tr>
            <tr>
                <td style="width: 223px">
                </td>
                <td style="width: 97px">
                    姓名：</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
                        ErrorMessage="管理员姓名不能为空"></asp:RequiredFieldValidator></td>
                <td style="width: 193px">
                </td>
            </tr>
            <tr>
                <td style="width: 223px">
                </td>
                <td style="width: 97px">
                    密码：</td>
                <td>
                    <asp:TextBox ID="txtPwd" runat="server" Width="149px"></asp:TextBox></td>
                <td>
                </td>
                <td style="width: 193px">
                </td>
            </tr>
            <tr>
                <td style="width: 223px">
                </td>
                <td style="width: 97px">
                    确认密码：</td>
                <td>
                    <asp:TextBox ID="txtSPwd" runat="server" TextMode="Password" Width="149px"></asp:TextBox></td>
                <td>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPwd"
                        ControlToValidate="txtSPwd" ErrorMessage="密码输入不一致"></asp:CompareValidator></td>
                <td style="width: 193px">
                </td>
            </tr>
            <tr>
                <td style="width: 223px">
                </td>
                <td style="width: 97px">
                </td>
                <td colspan="2" style="text-align: left">
                    &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Button ID="btnEdit" runat="server" Text="修改" CssClass="ButtonCss" OnClick="btnEdit_Click" />
                    &nbsp;<a href="javascript:window.history.back();" style="font-size:10pt; color:Black; text-decoration:underline;">返回</a></td>
                <td colspan="1" style="width: 193px; text-align: left">
                </td>
            </tr>
        <tr>
            <td style="width: 223px; height: 226px">
            </td>
            <td style="width: 97px; height: 226px">
            </td>
            <td colspan="2" style="height: 226px; text-align: left">
            </td>
            <td colspan="1" style="width: 193px; height: 226px; text-align: left">
            </td>
        </tr>
        </table>
    </div>
    </form>
</body>
</html>

