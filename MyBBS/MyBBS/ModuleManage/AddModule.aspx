<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddModule.aspx.cs" Inherits="MyBBS.ModuleManage.AddModule" %>

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
     <table style="width: 794px; background-image: url(../Images/大背景.jpg); height: 489px;" class="TableCss" align="center" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td colspan="1" style="font-size: 14pt; width: 311px">
                </td>
                <td colspan="2" style="font-size: 14pt">
                    <br />
                    添加版块</td>
                <td colspan="1" style="font-size: 14pt; width: 336px">
                </td>
            </tr>
            <tr>
                <td style="width: 311px">
                </td>
                <td style="width: 82px">
                    版块编号：</td>
                <td style="width: 170px">
                    <asp:TextBox ID="txtID" runat="server" ReadOnly="True"></asp:TextBox></td>
                <td style="width: 336px">
                </td>
            </tr>
        <tr>
            <td style="width: 311px">
            </td>
            <td style="width: 82px">
                版块名称：</td>
            <td style="width: 170px">
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
            <td style="width: 336px">
            </td>
        </tr>
            <tr>
                <td style="width: 311px">
                </td>
                <td style="width: 82px">
                </td>
                <td colspan="1" style="text-align: left; width: 170px;">
                    &nbsp; &nbsp; &nbsp;
                    <asp:Button ID="btnAdd" runat="server" Text="添加" CssClass="ButtonCss" OnClick="btnAdd_Click" />
                    &nbsp;
                    <asp:Button ID="btnCancel" runat="server" Text="取消" CssClass="ButtonCss" OnClick="btnCancel_Click" CausesValidation="False" /></td>
                <td colspan="1" style="width: 336px; text-align: left">
                </td>
            </tr>
         <tr>
             <td style="width: 311px; height: 258px">
             </td>
             <td style="width: 82px; height: 258px">
             </td>
             <td colspan="1" style="width: 170px; height: 258px; text-align: left">
             </td>
             <td colspan="1" style="width: 336px; height: 258px; text-align: left">
             </td>
         </tr>
        </table>
    </div>
    </form>
</body>
</html>

