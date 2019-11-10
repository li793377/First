<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModuleInfo.aspx.cs" Inherits="MyBBS.ModuleManage.ModuleInfo" %>

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
        <table align="center" style="width: 800px;" class="TableCss" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td style="background-image: url(../Images/版块分类.jpg); vertical-align: top; width: 800px;
                    height: 21px">
                </td>
            </tr>
            <tr>
                <td style="vertical-align: top; width: 800px;">
                    <asp:DataList ID="dlInfo" runat="server"
                        Width="758px">
                        <ItemTemplate>
                            <table border="0" cellpadding="0" cellspacing="0" style="width: 800px">
                                <tr>
                                    <td rowspan="2" style="width: 71px; height: 53px; background-image: url(../Images/图标.jpg);">
                                        </td>
                                    <td style="vertical-align:top; text-align: left; width: 610px; height: 35px; background-image: url(../Images/版块分类名称上部分.jpg);">
                                    <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <a href='../CardManage/Card.aspx?ModuleID=<%# DataBinder.Eval(Container.DataItem,"ModuleID") %>'
                                            style="font-size: 9pt;text-decoration:none; color:Black;">
                                            <%# DataBinder.Eval(Container.DataItem,"ModuleName") %>
                                            </a></td>
                                    <td rowspan="2" style="width: 119px;
                                        height: 53px; text-align: left; background-image: url(../Images/全新论坛精彩评论.jpg);">
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align: left; width: 610px; height: 18px; background-image: url(../Images/版块分类名称下部分.jpg);">
                                    &nbsp;&nbsp;版主：<asp:Label ID="Label1" runat="server"><%# getHost(Convert.ToString(DataBinder.Eval(Container.DataItem,"ModuleID")))%></asp:Label></td>
                                </tr>
                            </table>
                        </ItemTemplate>
                        <SeparatorStyle BorderStyle="None" />
                    </asp:DataList></td>
            </tr>
            <tr>
                <td style="width: 800px;">
                    <table cellpadding="0" cellspacing="0" style="width: 800px; background-image: url(../Images/当前页码.jpg); height: 28px;">
                        <tr>
                            <td style="font-size: 9pt; width: 800px; text-align: right; height: 28px;">
                                <asp:Label ID="Label7" runat="server" Text="当前页码为："></asp:Label>
                                [
                                <asp:Label ID="labPage" runat="server" Text="1"></asp:Label>
                                ]
                                <asp:Label ID="Label6" runat="server" Text="总页码为："></asp:Label>
                                [
                                <asp:Label ID="labBackPage" runat="server"></asp:Label>
                                ]<asp:LinkButton ID="lnkbtnOne" runat="server" Font-Underline="False" ForeColor="Red"
                                    OnClick="lnkbtnOne_Click">第一页</asp:LinkButton>
                                <asp:LinkButton ID="lnkbtnUp" runat="server" Font-Underline="False" ForeColor="Red"
                                    OnClick="lnkbtnUp_Click">上一页</asp:LinkButton>
                                <asp:LinkButton ID="lnkbtnNext" runat="server" Font-Underline="False" ForeColor="Red"
                                    OnClick="lnkbtnNext_Click">下一页</asp:LinkButton>&nbsp;
                                <asp:LinkButton ID="lnkbtnBack" runat="server" Font-Underline="False" ForeColor="Red"
                                    OnClick="lnkbtnBack_Click">最后一页</asp:LinkButton>
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
