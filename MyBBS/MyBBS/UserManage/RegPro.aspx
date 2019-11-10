<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegPro.aspx.cs" Inherits="MyBBS.UserManage.RegPro" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>无标题页</title>
    <link href="../CSS/StyleSheet.css" rel="Stylesheet" type="text/css" />
    <style>
    body{margin-top:0px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table style="width: 794px; height: 489px; background-image: url(../Images/大背景.jpg);" cellpadding="0" cellspacing="0" align="center" class="TableCss" border="0">
            <tr>
                <td style="font-size: 14pt">
                    <br />
                    用户注册协议</td>
            </tr>
            <tr>
                <td style="width: 794px; text-align: left; font-size:9pt; height: 340px; vertical-align:top;"><br /><br /><br /> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp;
                    &nbsp; 为了更好的管理和维护网站，请您自觉遵守以下条款： <br>
        <br>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        （一）不得利用本网站进行商业广告宣传； <br>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        （二）不得利用本网站发送非法文章；<br>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;（三）不得利用本网站进行上传非法图片；&nbsp;<br>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; （四）互相尊重，对自己的言论和行为负责； <br>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;（五）普通用户欲删除文章、评论、图片等信息，请与管理员联系；<br>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        （六）本网站版权归明日科技公司，不得对本网站进行转载或作为私用；<br />
                    <br />
                    <br />
                    <br />
                    <br>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;<asp:Button ID="btnAgree" runat="server" Text="同意" OnClick="btnAgree_Click" Font-Size="9pt" />
                    &nbsp; &nbsp;
                    <asp:Button ID="btnRefuse" runat="server" Text="拒绝" OnClick="btnRefuse_Click" Font-Size="9pt" />
                    </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
