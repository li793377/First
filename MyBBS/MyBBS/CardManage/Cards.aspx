<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cards.aspx.cs" Inherits="MyBBS.CardManage.Cards" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <link href="CSS/StyleSheet.css" rel="Stylesheet" type="text/css" />
    <style>
    body{margin-top:0px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center" style="width: 800px;" class="TableCss" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td style="vertical-align: top; width: 800px; height: 21px; text-align: left; background-image: url(../Images/帖子信息页/帖子信息.jpg);">
                </td>
        </tr>
            <tr>
                <td style="vertical-align: top; text-align: left; width: 800px;">
                    <asp:DataList ID="dlInfo" runat="server" OnEditCommand="dlInfo_EditCommand">
                        <ItemTemplate>
                            <table style="width: 800px;" border="0" cellpadding="0" cellspacing="0" class="TableCss">
                                <tr>
                                    <td style="width: 373px; height: 30px; text-align:left; background-image: url(../Images/帖子信息页/主题分布区--1.jpg);">
                                    &nbsp;<asp:Label ID="Label3" runat="server"><%# getModule()%></asp:Label> --<a href='CardInfo.aspx?CardID=<%# DataBinder.Eval(Container.DataItem,"CardID") %>'
                                            style="font-size: 9pt;text-decoration:none; color:Black;">
                                            <%# DataBinder.Eval(Container.DataItem,"CardName") %>
                                            </a></td>
                                    <td style="width: 233px; height: 30px; background-image: url(../Images/帖子信息页/主题分布区--2.jpg);">
                                    发表时间：<asp:Label ID="Label1" runat="server"><%# DataBinder.Eval(Container.DataItem,"CardTime") %></asp:Label></td>
                                    <td style="width: 116px; height: 30px; background-image: url(../Images/帖子信息页/主题分布区--3.jpg);">
                                    发帖人：<asp:Label ID="Label2" runat="server"><%# DataBinder.Eval(Container.DataItem,"CardPeople") %></asp:Label></td>
                                    <td style="width: 78px; height: 30px; background-image: url(../Images/帖子信息页/主题分布区--4.jpg);">
                                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit" ForeColor="Black">回复</asp:LinkButton></td>
                                </tr>
                                <tr>
                                    <td colspan="4" style="vertical-align: top; text-align:left; height: 105px; background-image: url(../Images/帖子信息页/主题内容区.jpg); width: 798px;">&nbsp; &nbsp;<%# DataBinder.Eval(Container.DataItem,"CardContent") %></td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList></td>
            </tr>
            <tr>
                <td style="height: 28px; width: 800px;">
                    <table cellpadding="0" cellspacing="0" style="width: 800px; background-image: url(../Images/当前页码.jpg); height: 28px;">
                        <tr>
                            <td style="font-size: 9pt; width: 800px; text-align: right; height: 31px;">
                                <asp:Label ID="Label7" runat="server" Text="当前页码为："></asp:Label>[
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
                                    OnClick="lnkbtnNext_Click">下一页</asp:LinkButton>
                                <asp:LinkButton ID="lnkbtnBack" runat="server" Font-Underline="False" ForeColor="Red"
                                    OnClick="lnkbtnBack_Click">最后一页</asp:LinkButton>
                                &nbsp; &nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
