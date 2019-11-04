<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CardInfo.aspx.cs" Inherits="MyBBS.CardManage.CardInfo" %>

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
    <table align="center" style="width: 794px;" class="TableCss" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td style="vertical-align: top; width: 794px;text-align: left;">
            <table border="0" cellpadding="0" cellspacing="0" class="TableCss" align="center">
                <tr>
                    <td colspan="5" rowspan="1" style="background-image: url(../Images/帖子及回帖信息页/头一小条.jpg);
                        width: 794px; height: 8px; text-align: center">
                    </td>
                </tr>
                                <tr>
                                    <td style="width: 160px; height: 148px; text-align: center; background-image: url(../Images/帖子及回帖信息页/1.jpg);" rowspan="2">
                                        发帖人信息<br /><asp:Image ID="Image2" runat="server"   />
                                        <br /><br />
                                        <asp:Label ID="Label2" runat="server"></asp:Label></td>
                                    <td style="width: 374px; height: 23px; text-align:left; background-image: url(../Images/帖子及回帖信息页/2.jpg);">
                                    &nbsp;<asp:Label ID="Label4" runat="server"></asp:Label></td>
                                    <td style="width: 182px; height: 23px; background-image: url(../Images/帖子及回帖信息页/3.jpg);">
                                    发表时间：<asp:Label ID="Label1" runat="server"></asp:Label></td>
                                    <td style="width: 78px; height: 23px; background-image: url(../Images/帖子及回帖信息页/4.jpg);" colspan="2">
                                        <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="Black" OnClick="LinkButton1_Click" Width="38px" Font-Underline="False">回复</asp:LinkButton></td>
                                </tr>
                                <tr>
                                    <td colspan="4" style="vertical-align: top; text-align:left; height: 125px; background-image: url(../Images/帖子及回帖信息页/5.jpg); width: 634px;">
                                        &nbsp;&nbsp;<asp:Label ID="Label8" runat="server"></asp:Label></td>
                                </tr>
                            </table></td>
        </tr>
            <tr>
                <td style="vertical-align: top; text-align: left; width: 794px;">
                    <asp:DataList ID="dlInfo" runat="server" OnDeleteCommand="dlInfo_DeleteCommand">
                        <ItemTemplate>
                            <table border="0" cellpadding="0" cellspacing="0" class="TableCss" style="width: 794px">
                                <tr>
                                    <td style="width: 160px; height: 148px; text-align: center; background-image: url(../Images/帖子及回帖信息页/1.jpg);" rowspan="2">
                                        回帖人信息<br />
                                        <asp:Image ID="Image1" runat="server" Height="44px" Width="44px" ImageUrl='<%# getPhoto(Convert.ToString(DataBinder.Eval(Container.DataItem,"revertid"))) %>'/>
                                        <br />
                                        <br />
                                        <asp:Label ID="Label2" runat="server"><%# DataBinder.Eval(Container.DataItem,"revertpeople") %></asp:Label></td>
                                    <td style="width: 374px; height: 23px; text-align:left; background-image: url(../Images/帖子及回帖信息页/2.jpg);">
                                    &nbsp;回帖主题：<asp:Label ID="Label5" runat="server"><%# DataBinder.Eval(Container.DataItem,"revertid") %></asp:Label>--<asp:Label ID="Label3" runat="server"><%# DataBinder.Eval(Container.DataItem,"cardid")%></asp:Label></td>
                                    <td style="width: 182px; height: 23px; background-image: url(../Images/帖子及回帖信息页/3.jpg);">
                                    回帖时间：<asp:Label ID="Label1" runat="server"><%# DataBinder.Eval(Container.DataItem,"reverttime") %></asp:Label></td>
                                    <td colspan="2" style="height: 23px; width: 78px; background-image: url(../Images/帖子及回帖信息页/4.jpg);">
                                        <asp:LinkButton ID="lbtnDel" runat="server" CommandName="Delete" ForeColor="Black">删除</asp:LinkButton></td>
                                </tr>
                                <tr>
                                    <td colspan="4" style="vertical-align: top; text-align:left; height: 125px; background-image: url(../Images/帖子及回帖信息页/5.jpg); width: 634px;">&nbsp; &nbsp;<%# DataBinder.Eval(Container.DataItem,"revertcontent") %></td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList></td>
            </tr>
            <tr>
                <td style="height: 25px; width: 753px;">
                    <table cellpadding="0" cellspacing="0" style="width: 800px; height: 28px;">
                        <tr>
                            <td style="font-size: 9pt; width: 800px; text-align: right; height: 30px; background-image: url(../Images/当前页码.jpg);">
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
