<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RevertCard.aspx.cs" Inherits="MyBBS.CardManage.RevertCard" %>

<%@ Register Assembly="FreeTextBox" Namespace="FreeTextBoxControls" TagPrefix="FTB" %>

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
        <table align="center" border="0" cellpadding="0" cellspacing="0" class="TableCss"
            style="width: 794px; background-image: url(../Images/发表帖子页面.jpg); height: 489px;">
            <tr>
                <td rowspan="1" style="vertical-align: top; width: 215px">
                </td>
                <td style="width: 530px; height: 25px; text-align: left">
                </td>
            </tr>
            <tr>
                <td style="width: 215px; vertical-align: top;" rowspan="5"><br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <table style="width: 195px" border="0" cellpadding="0" cellspacing="0" class="TableCss">
                        <tr>
                            <td style="height: 20px">
                                回复人信息</td>
                        </tr>
                        <tr>
                            <td style="height: 60px">
                                <asp:Image ID="imgPhoto" runat="server" Height="50px" Width="45px" /></td>
                        </tr>
                        <tr>
                            <td style="height: 22px">
                                <asp:Label ID="labName" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="height: 22px">
                                Email：<asp:Label ID="labEmail" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="height: 22px">
                                QQ：<asp:Label ID="labQQ" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="height: 22px">
                                个人主页：<asp:Label ID="labIndex" runat="server"></asp:Label></td>
                        </tr>
                    </table>
                </td>
                <td style="width: 530px; text-align: left; height: 25px;">
                    &nbsp;帖子名称：<asp:Label ID="labCName" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 530px; text-align: left; height: 25px;">
                    &nbsp;回复主题：<asp:TextBox ID="txtName" runat="server" Width="442px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 530px;  text-align: left; height: 22px;">
                    &nbsp;内 &nbsp;&nbsp;容：</td>
            </tr>
            <tr>
                <td style="width: 530px; vertical-align: top;">
                <FTB:FreeTextBox id="FreeTextBox1" runat="Server" Language="zh-cn"  SupportFolder="../aspnet_client/FreeTextBox/" Height="190px" Width="500px" HtmlModeDefaultsToMonoSpaceFont="True" DownLevelCols="50" DownLevelRows="10" ButtonDownImage="False" GutterBackColor="LightSteelBlue" ToolbarBackgroundImage="True" ToolbarLayout="ParagraphMenu,FontFacesMenu,FontSizesMenu,FontForeColorsMenu|Bold,Italic,Underline,Strikethrough;Superscript,Subscript,RemoveFormat|JustifyLeft,JustifyRight,JustifyCenter,JustifyFull;BulletedList,NumberedList,Indent,Outdent;CreateLink,Unlink,InsertImage,InsertRule|Cut,Copy,Paste;Undo,Redo,Print" ToolbarStyleConfiguration="NotSet" />
                </td>
            </tr>
            <tr>
                <td style="width: 530px; height: 40px;">
                    <asp:Button ID="btnSubmit" runat="server" Text="提交" CssClass="ButtonCss" OnClick="btnSubmit_Click" />
                    &nbsp;
                    <asp:Button ID="btnCancel" runat="server" Text="取消" CssClass="ButtonCss" OnClick="btnCancel_Click" /></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

